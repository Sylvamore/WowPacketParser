using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V9_0_1_36216.Hotfix
{
    [HotfixStructure(DB2Hash.NamesProfanity, HasIndexInData = false)]
    public class NamesProfanityEntry
    {
        public string Name { get; set; }
        public sbyte Language { get; set; }
    }
}
