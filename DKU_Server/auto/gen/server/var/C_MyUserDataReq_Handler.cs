
using DKU_ServerCore.Packets.var.client;
using DKU_ServerCore.Packets.var.queue;
using DKU_ServerCore.Packets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKU_Server.Packets.var
{
    public class C_MyUserDataReq_Handler
    {
        public static void Method(Packet packet)
        {
            C_MyUserDataReq req = Data<C_MyUserDataReq>.Deserialize(packet.m_data);

        }
    }
}