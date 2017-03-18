using WowPacketParser.Messages.Submessages;

namespace WowPacketParser.Messages.PlayerCli
{
    public unsafe struct PlayerCliAuctionListItems
    {
        public ulong Auctioneer;
        public byte SortCount;
        public byte MaxLevel;
        public uint Offset;
        public int ItemClass;
        public byte MinLevel;
        public int InvType;
        public int Quality;
        public int ItemSubclass;
        public bool ExactMatch;
        public string Name;
        public bool OnlyUsable;
        public Data Sorts;
    }
}