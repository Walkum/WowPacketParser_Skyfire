using WowPacketParser.Misc;

namespace WowPacketParser.Enums.Version.V5_4_7_17930
{
    public static class Opcodes_5_4_7
    {
        public static BiDictionary<Opcode, int> Opcodes()
        {
            return Opcs;
        }

        private static readonly BiDictionary<Opcode, int> Opcs = new BiDictionary<Opcode, int>
        {
            {Opcode.CMSG_AUTH_SESSION, 0x1A51},
            {Opcode.CMSG_CANCEL_TRADE, 0x1D32},
            {Opcode.CMSG_CHAR_CREATE, 0x09B9},
            {Opcode.CMSG_CHAR_DELETE, 0x113B},
            {Opcode.CMSG_CHAR_ENUM, 0x12C2},
            {Opcode.CMSG_CONNECT_TO_FAILED, 0x16C8},
            {Opcode.CMSG_CREATURE_QUERY, 0x1E72},
            {Opcode.CMSG_GAMEOBJECT_QUERY, 0x14EA},
            {Opcode.CMSG_LEARN_TALENT, 0x1F5A},
            {Opcode.CMSG_LOAD_SCREEN, 0x1691},
            {Opcode.CMSG_LOGOUT_CANCEL, 0x11D4},
            {Opcode.CMSG_LOGOUT_REQUEST, 0x0476},
            {Opcode.CMSG_LOG_DISCONNECT, 0x1A13},
            {Opcode.CMSG_MESSAGECHAT_GUILD, 0x070B},
            {Opcode.CMSG_MESSAGECHAT_SAY, 0x0C41},
            {Opcode.CMSG_MESSAGECHAT_WHISPER, 0x0D60},
            {Opcode.CMSG_MESSAGECHAT_YELL, 0x0C43},
            {Opcode.CMSG_NAME_QUERY, 0x0DB3},
            {Opcode.CMSG_OBJECT_UPDATE_FAILED, 0x882},
            {Opcode.CMSG_PING, 0x1070},
            {Opcode.CMSG_PLAYER_LOGIN, 0x17D3},
            {Opcode.CMSG_READY_FOR_ACCOUNT_DATA_TIMES, 0x13CB},
            {Opcode.CMSG_REALM_QUERY, 0x1899},
            {Opcode.CMSG_REDIRECTION_AUTH_PROOF, 0x1A5B},
            {Opcode.CMSG_SET_PRIMARY_TALENT_TREE, 0x04AA},
            {Opcode.CMSG_SET_SELECTION, 0x10D5},
            {Opcode.CMSG_TIME_SYNC_RESP, 0x0413},
            {Opcode.CMSG_TUTORIAL_FLAG, 0x07A4},
            {Opcode.CMSG_VIOLENCE_LEVEL, 0x05A0},
            {Opcode.CMSG_WARDEN_DATA, 0x1681},
            {Opcode.MSG_MOVE_FALL_LAND, 0x055B},
            {Opcode.MSG_MOVE_HEARTBEAT, 0x017B},
            {Opcode.MSG_MOVE_JUMP, 0x0438},
            {Opcode.MSG_MOVE_SET_FACING, 0x005A},
            {Opcode.MSG_MOVE_SET_PITCH, 0x047A},
            {Opcode.MSG_MOVE_SET_RUN_MODE, 0x0878},
            {Opcode.MSG_MOVE_SET_WALK_MODE, 0x0138},
            {Opcode.MSG_MOVE_START_ASCEND, 0x0430},
            {Opcode.MSG_MOVE_START_BACKWARD, 0x0459},
            {Opcode.MSG_MOVE_START_DESCEND, 0x0132},
            {Opcode.MSG_MOVE_START_FORWARD, 0x041B},
            {Opcode.MSG_MOVE_START_PITCH_DOWN, 0x093B},
            {Opcode.MSG_MOVE_START_PITCH_UP, 0x0079},
            {Opcode.MSG_MOVE_START_STRAFE_LEFT, 0x0873},
            {Opcode.MSG_MOVE_START_STRAFE_RIGHT, 0x0C12},
            {Opcode.MSG_MOVE_START_SWIM, 0x0871},
            {Opcode.MSG_MOVE_START_TURN_LEFT, 0x011B},
            {Opcode.MSG_MOVE_START_TURN_RIGHT, 0x0411},
            {Opcode.MSG_MOVE_STOP, 0x0570},
            {Opcode.MSG_MOVE_STOP_ASCEND, 0x0012},
            {Opcode.MSG_MOVE_STOP_PITCH, 0x0071},
            {Opcode.MSG_MOVE_STOP_STRAFE, 0x0171},
            {Opcode.MSG_MOVE_STOP_SWIM, 0x0578},
            {Opcode.MSG_MOVE_STOP_TURN, 0x0530},
            {Opcode.MSG_MOVE_TELEPORT, 0x00D5},
            {Opcode.MSG_MOVE_TELEPORT_ACK, 0x0978},
            {Opcode.MSG_MOVE_WORLDPORT_ACK, 0x18BB},
            {Opcode.MSG_VERIFY_CONNECTIVITY, 0x4F57},
            {Opcode.SMSG_ACCOUNT_DATA_TIMES, 0x0F40},
            {Opcode.SMSG_ACTION_BUTTONS, 0x1768},
            {Opcode.SMSG_ADDON_INFO, 0x10E2},
            {Opcode.SMSG_AUTH_CHALLENGE, 0x14B8},
            {Opcode.SMSG_AUTH_RESPONSE, 0x15A0},
            {Opcode.SMSG_CHAR_CREATE, 0x1469},
            {Opcode.SMSG_CHAR_DELETE, 0x1529},
            {Opcode.SMSG_CHAR_ENUM, 0x040A},
            {Opcode.SMSG_CLIENTCACHE_VERSION, 0x1E41},
            {Opcode.SMSG_CREATURE_QUERY_RESPONSE, 0x00E0},
            {Opcode.SMSG_DESTROY_OBJECT, 0x1D69},
            {Opcode.SMSG_GAMEOBJECT_QUERY_RESPONSE, 0x066A},
            {Opcode.SMSG_INITIAL_SPELLS, 0x1B05},
            {Opcode.SMSG_LEARNED_SPELL, 0x0C99},
            {Opcode.SMSG_LOGIN_SETTIMESPEED, 0x0F4A},
            {Opcode.SMSG_LOGIN_VERIFY_WORLD, 0x0603},
            {Opcode.SMSG_LOGOUT_CANCEL_ACK, 0x0E0A},
            {Opcode.SMSG_LOGOUT_COMPLETE, 0x0429},
            {Opcode.SMSG_LOGOUT_RESPONSE, 0x0D2B},
            {Opcode.SMSG_MESSAGECHAT, 0x0E60},
            {Opcode.SMSG_MONSTER_MOVE, 0x12D8},
            {Opcode.SMSG_MOTD, 0x0E20},
            {Opcode.SMSG_MOVE_SET_CAN_FLY, 0x01F4},
            {Opcode.SMSG_MOVE_SET_FLIGHT_SPEED, 0x02DC},
            {Opcode.SMSG_MOVE_SET_RUN_SPEED, 0x1B9B},
            {Opcode.SMSG_MOVE_SET_SWIM_SPEED, 0x01D4},
            {Opcode.SMSG_MOVE_SET_WALK_SPEED, 0x00A0},
            {Opcode.SMSG_MOVE_UNSET_CAN_FLY, 0x1D81},
            {Opcode.SMSG_MULTIPLE_PACKETS, 0x05B1},
            {Opcode.SMSG_NAME_QUERY_RESPONSE, 0x1E5B},
            {Opcode.SMSG_NEW_WORLD, 0x05AB},
            {Opcode.SMSG_PLAYER_MOVE, 0x1CB2},
            {Opcode.SMSG_PONG, 0x15B1},
            {Opcode.SMSG_REALM_QUERY_RESPONSE, 0x1652},
            {Opcode.SMSG_SET_PROFICIENCY, 0x1E3B},
            {Opcode.SMSG_SERVER_TIMEZONE, 0x0C2B},
            {Opcode.SMSG_TALENTS_INFO, 0x0C68},
            {Opcode.SMSG_TIME_SYNC_REQ, 0x12F1},
            {Opcode.SMSG_TRANSFER_PENDING, 0x0440},
            {Opcode.SMSG_TUTORIAL_FLAGS, 0x10A7},
            {Opcode.SMSG_UPDATE_OBJECT, 0x1725},
            {Opcode.SMSG_WARDEN_DATA, 0x14EB}
        };
    }
}
