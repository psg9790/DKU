
using DKU_ServerCore.Packets;
using DKU_ServerCore.Packets.var.server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKU_DummyClient.Packets.var
{
    public class S_LoginRes_Handler
    {
        public static void Method(Packet packet)
        {
            S_LoginRes res = Data<S_LoginRes>.Deserialize(packet.m_data);
            if (res.success)
            {
                // ����
                Console.WriteLine("�α��� ����");
                Network.Instance.m_user_data = res.udata;
            }
            else
            {
                // ����
                Console.WriteLine("�α��� ����");
            }
        }
    }
}