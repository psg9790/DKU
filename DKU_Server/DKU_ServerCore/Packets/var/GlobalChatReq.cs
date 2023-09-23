﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DKU_ServerCore.Packets.var
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, Pack = 1)] // pack=1: 1byte 단위로 데이터 크기를 맞춤
    public class GlobalChatReq : Data<GlobalChatReq>
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDefine.MAX_PACKET_STRING_LENGTH)]
        public string chat_message;

        //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        //public TestStructData[] m_test_data_array = new TestStructData[10];
    }
}
