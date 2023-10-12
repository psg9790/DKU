
using DKU_ServerCore;
using DKU_ServerCore.Packets;
using DKU_ServerCore.Packets.var.server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GamePacketHandler
{
    public void ParsePacket(Packet packet)
    {
        switch ((PacketType)packet.m_type)
        {

            case PacketType.GS_QueueStartReq:
                GS_QueueStartReq_Impl(packet);
                break;

            case PacketType.QC_LoginReq:
                QC_LoginReq_Impl(packet);
                break;

            case PacketType.QC_RegisterReq:
                QC_RegisterReq_Impl(packet);
                break;

        }
    }

    void GS_QueueStartReq_Impl(Packet packet)
    {
        GS_QueueStartReq_Handler.Method(packet);
    }

    void QC_LoginReq_Impl(Packet packet)
    {
        QC_LoginReq_Handler.Method(packet);
    }

    void QC_RegisterReq_Impl(Packet packet)
    {
        QC_RegisterReq_Handler.Method(packet);
    }

}
