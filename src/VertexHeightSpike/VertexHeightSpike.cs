using System;
using Kopernicus.ConfigParser.Attributes;
using Kopernicus.ConfigParser.BuiltinTypeParsers;
using Kopernicus.Configuration.ModLoader;

namespace KopernicusPQSExtensions.VertexHeightSpike
{
    public class VertexHeightSpike : ModLoader<PQSMod_VertexHeightSpike>
    {
        [ParserTarget("spikeLevel")]
        public EnumParser<PQSMod_VertexHeightSpike.SpikeLevel> SpikeLevel
        {
            get { return base.Mod.spikeLevel; }
            set { base.Mod.spikeLevel = value.Value; }
        }

        [ParserTarget("doubleSpikeLevel")]
        public NumericParser<Boolean> DoubleSpikeLevel
        {
            get { return Mod.doubleSpikeLevel; }
            set { Mod.doubleSpikeLevel = value; }
        }
    }
}
