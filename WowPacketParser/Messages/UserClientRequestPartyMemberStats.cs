using System.Collections.Generic;
using WowPacketParser.Misc;

namespace WowPacketParser.Messages
{
    public unsafe struct UserClientRequestPartyMemberStats
    {
        public ulong Target;
        public byte PartyIndex;
    }
}