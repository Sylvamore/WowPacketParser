using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V9_0_1_36216.Hotfix
{
    [HotfixStructure(DB2Hash.AzeriteLevelInfo, HasIndexInData = false)]
    public class AzeriteLevelInfoEntry
    {
        public ulong BaseExperienceToNextLevel { get; set; }
        public ulong MinimumExperienceToNextLevel { get; set; }
        public int ItemLevel { get; set; }
    }
}
