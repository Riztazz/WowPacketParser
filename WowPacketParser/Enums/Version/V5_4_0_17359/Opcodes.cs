using WowPacketParser.Misc;

namespace WowPacketParser.Enums.Version.V5_4_0_17359
{
    public static class Opcodes_5_4_0
    {
        public static BiDictionary<Opcode, int> Opcodes()
        {
            return Opcs;
        }

        private static readonly BiDictionary<Opcode, int> Opcs = new BiDictionary<Opcode, int>
        {
            {Opcode.CMSG_ADDON_REGISTERED_PREFIXES, 0x10BD},
            {Opcode.CMSG_AUTH_SESSION, 0x0790},
            {Opcode.CMSG_CHANNEL_LIST, 0x1C14},
            {Opcode.CMSG_CREATURE_QUERY, 0x1585},
            {Opcode.CMSG_DB_QUERY_BULK, 0x1A8B},
            {Opcode.CMSG_GAMEOBJECT_QUERY, 0x15A4},
            {Opcode.CMSG_GOSSIP_HELLO, 0x1A3F},
            {Opcode.CMSG_GOSSIP_SELECT_OPTION, 0x136B},
            {Opcode.CMSG_LOAD_SCREEN, 0x160B},
            {Opcode.CMSG_LOG_DISCONNECT, 0x0380},
            {Opcode.CMSG_MESSAGECHAT_SAY, 0x10BE},
            {Opcode.CMSG_NAME_QUERY, 0x16DB},
            {Opcode.CMSG_NPC_TEXT_QUERY, 0x108B},
            {Opcode.CMSG_PLAYER_LOGIN, 0x1BC7},
            {Opcode.CMSG_REALM_SPLIT, 0x129F},
            {Opcode.CMSG_REDIRECT_AUTH_PROOF, 0x0A93},
            {Opcode.CMSG_SAVE_CUF_PROFILES, 0x158D},
            {Opcode.CMSG_SET_SELECTION, 0x1B76},
            {Opcode.CMSG_TIME_SYNC_RESP, 0x0784}, 
            {Opcode.CMSG_VIOLENCE_LEVEL, 0x1927},
            {Opcode.CMSG_UNKNOWN_903, 0x0387},
            {Opcode.SMSG_ACCOUNT_DATA_TIMES, 0x0890},
            {Opcode.SMSG_ADDON_INFO, 0x0128},
            {Opcode.SMSG_ALL_ACHIEVEMENT_DATA, 0x0816},
            {Opcode.SMSG_ATTACKERSTATEUPDATE, 0x1BC0},
            {Opcode.SMSG_AURA_UPDATE, 0x19B3},
            {Opcode.SMSG_AUTH_CHALLENGE, 0x016A},
            {Opcode.SMSG_AUTH_RESPONSE, 0x090E},
            {Opcode.SMSG_BINDPOINTUPDATE, 0x0404},
            {Opcode.SMSG_CHAR_ENUM, 0x0193},
            {Opcode.SMSG_CLIENTCACHE_VERSION, 0x0825},
            {Opcode.SMSG_CHANNEL_LIST, 0x1760},
            {Opcode.SMSG_CREATURE_QUERY_RESPONSE, 0x01B4},
            {Opcode.SMSG_CRITERIA_UPDATE, 0x082C},
            {Opcode.SMSG_DB_REPLY, 0x0025},
            {Opcode.SMSG_DEFENSE_MESSAGE, 0x0826},
            {Opcode.SMSG_EMOTE, 0x1B7D},
            {Opcode.SMSG_FEATURE_SYSTEM_STATUS, 0x00B9},
            {Opcode.SMSG_GAMEOBJECT_QUERY_RESPONSE, 0x0015},
            {Opcode.SMSG_GOSSIP_MESSAGE, 0x1508},
            {Opcode.SMSG_GROUP_LIST, 0x013D},
            {Opcode.SMSG_GUILD_EVENT, 0x0D47},
            {Opcode.SMSG_GUILD_QUERY_RESPONSE, 0x0D42},
            {Opcode.SMSG_GUILD_ROSTER, 0x044E},
            {Opcode.SMSG_LIST_INVENTORY, 0x088D},
            {Opcode.SMSG_LOAD_CUF_PROFILES, 0x009D},
            {Opcode.SMSG_LOGIN_VERIFY_WORLD, 0x0896},
            {Opcode.SMSG_MAIL_LIST_RESULT, 0x088C}, 
            {Opcode.SMSG_MESSAGECHAT, 0x092F},
            {Opcode.SMSG_MONSTER_MOVE, 0x137A},
            {Opcode.SMSG_MOTD, 0x082A},
            {Opcode.SMSG_NAME_QUERY_RESPONSE, 0x00B7},
            {Opcode.SMSG_NEW_WORLD, 0x01AE},
            {Opcode.SMSG_NPC_TEXT_UPDATE, 0x0886},
            {Opcode.SMSG_PAGE_TEXT_QUERY_RESPONSE, 0x0114},
            {Opcode.SMSG_PERIODICAURALOG, 0x1097},
            {Opcode.SMSG_PET_NAME_QUERY_RESPONSE, 0x05A1},
            {Opcode.SMSG_PLAYER_MOVE, 0x139F},
            {Opcode.SMSG_QUESTGIVER_QUEST_DETAILS, 0x142D},
            {Opcode.SMSG_QUEST_QUERY_RESPONSE, 0x19AB},
            {Opcode.SMSG_REALM_QUERY_RESPONSE, 0x042B},
            {Opcode.SMSG_REALM_SPLIT, 0x0099},
            {Opcode.SMSG_SEND_SERVER_LOCATION, 0x0883},
            {Opcode.SMSG_SET_PHASE_SHIFT, 0x0919},
            {Opcode.SMSG_SPELLNONMELEEDAMAGELOG, 0x1085},
            {Opcode.SMSG_SPELL_GO, 0x1C17},
            {Opcode.SMSG_SPELL_START, 0x10B6},
            {Opcode.SMSG_THREAT_UPDATE, 0x000B},
            {Opcode.SMSG_TUTORIAL_FLAGS, 0x1F35},
            {Opcode.SMSG_UPDATE_OBJECT, 0x17D9}
        };
    }
}
