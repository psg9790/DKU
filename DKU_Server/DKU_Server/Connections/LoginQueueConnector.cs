﻿using DKU_Server.Connections.Tokens;
using DKU_ServerCore;
using DKU_ServerCore.Packets;
using DKU_ServerCore.Packets.var.gserver;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DKU_Server.Connections
{
    public class LoginQueueConnector
    {
        Socket m_socket;
        public UserToken m_token;

        public void Init()
        {
            Connect();
        }

        public void Connect()
        {
            m_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            m_socket.NoDelay = true;

            IPAddress target = IPAddress.Parse(CommonDefine.LOGIN_QUEUE_IPv4_ADDRESS);
            IPEndPoint endPoint = new IPEndPoint(target, CommonDefine.IP_PORT);

            // 접속용 args
            SocketAsyncEventArgs args = new SocketAsyncEventArgs();
            args.Completed += onConnected;
            args.RemoteEndPoint = endPoint;
            args.UserToken = new GS_QueueStartReq();

            bool pending = m_socket.ConnectAsync(args);
            if (!pending)
                onConnected(null, args);
        }

        void onConnected(object sender, SocketAsyncEventArgs args)
        {
            if (args.SocketError == SocketError.Success)
            {
                UserToken token = new UserToken(false);
                token.m_socket = m_socket;
                token.Init();
                token.StartRecv();
                m_token = token;
                LogManager.Log("[LoginQueueConnector] connected");
            }
            else
            {
                Connect();
            }
        }
    }
}
