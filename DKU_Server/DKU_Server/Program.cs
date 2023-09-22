﻿using System;
using System.Net;
using System.Threading;
using DKU_Server.Connections;
using DKU_ServerCore;

namespace DKU_Server
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("============================");
            Console.WriteLine("           Server           ");
            Console.WriteLine("============================");

            ClientListener listener = new ClientListener();
            //string host = Dns.GetHostName();
            //IPHostEntry entry = Dns.GetHostEntry(host);
            //IPAddress ipAddr = entry.AddressList[0];
            //Console.WriteLine(ipAddr);
            //Console.WriteLine(ipAddr);
            //listener.Start(ipAddr.ToString(), CommonDefine.IP_PORT, 10);
            listener.Start("192.168.0.4", CommonDefine.IP_PORT, 10);

            while (true) 
            { 
                Thread.Sleep(1000);
                NetworkManager.Instance.TestPing();
            }
        }
    }
}
