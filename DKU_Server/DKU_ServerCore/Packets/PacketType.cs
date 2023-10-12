  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKU_ServerCore.Packets
{
    [Serializable]
    public enum PacketType
    {
        TYPE_NONE = -1,
        
		C_ChatReq,
		C_LoginReq,
		C_LogoutReq,
		C_PingReq,
		C_RegisterReq,
		C_StartAuthReq,
		C_StopWaitingReq,
		C_TryAuthReq,
		C_UserPosReq,


		S_ChatRes,
		S_LogoutRes,
		S_PingRes,
		S_StartAuthRes,
		S_TryAuthRes,
		S_UserPosRes,


		Q_LoginRes,
		Q_QueueStartRes,
		Q_RegisterRes,
		Q_YourWidRes,
		QC_LoginReq,
		QC_RegisterReq,


		GS_QueueStartReq,

        PACKET_COUNT
    }
}
