using System.Collections.Generic;
using WowPacketParser.Misc;

namespace WowPacketParser.Messages
{
    public unsafe struct PlayerSaveGuildEmblem
    {
        public ulong Vendor;
        public int Bg;
        public int EStyle;
        public int EColor;
        public int BColor;
        public int BStyle;
    }
}