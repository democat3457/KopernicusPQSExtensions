using System;

namespace KopernicusPQSExtensions.VertexHeightSpike
{
    public class PQSMod_VertexHeightSpike : PQSMod
    {
        public SpikeLevel spikeLevel;

        public Boolean doubleSpikeLevel;

        public Double spikeHeight;

        public override void OnSetup()
        {
            spikeHeight = ((double) spikeLevel) / 10;
            if (doubleSpikeLevel)
            {
                spikeHeight *= 2;
            }
        }
        
        public override void OnVertexBuildHeight(PQS.VertexBuildData data)
        {
            data.vertHeight *= spikeHeight;
        }

        public enum SpikeLevel
        {
            Low = 20,
            Standard = 30,
            Medium = 35,
            High = 50
        }
    }
}
