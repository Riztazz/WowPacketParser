using WowPacketParser.Messages.Cli;
using WowPacketParser.Messages.Submessages;

namespace WowPacketParser.Messages.Player
{
    public unsafe struct PlayerMoveForceUnrootAck
    {
        public CliMovementAck Data;
    }
}
