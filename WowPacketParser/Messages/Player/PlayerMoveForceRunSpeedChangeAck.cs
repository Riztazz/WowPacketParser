using WowPacketParser.Messages.Cli;
using WowPacketParser.Messages.Submessages;

namespace WowPacketParser.Messages.Player
{
    public unsafe struct PlayerMoveForceRunSpeedChangeAck
    {
        public CliMovementSpeedAck Data;
    }
}
