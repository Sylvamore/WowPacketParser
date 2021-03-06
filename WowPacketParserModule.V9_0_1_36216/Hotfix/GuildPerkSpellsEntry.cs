using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V9_0_1_36216.Hotfix
{
    [HotfixStructure(DB2Hash.GuildPerkSpells, HasIndexInData = false)]
    public class GuildPerkSpellsEntry
    {
        public int SpellID { get; set; }
    }
}
