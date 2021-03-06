using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V9_0_1_36216.Hotfix
{
    [HotfixStructure(DB2Hash.GarrPlotBuilding, HasIndexInData = false)]
    public class GarrPlotBuildingEntry
    {
        public byte GarrPlotID { get; set; }
        public byte GarrBuildingID { get; set; }
    }
}
