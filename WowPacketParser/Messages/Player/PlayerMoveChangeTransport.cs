using WowPacketParser.Messages.Cli;
using WowPacketParser.Messages.Submessages;

namespace WowPacketParser.Messages.Player
{
    public unsafe struct PlayerMoveChangeTransport
    {
        public CliMovementStatus Status;
    }
}
