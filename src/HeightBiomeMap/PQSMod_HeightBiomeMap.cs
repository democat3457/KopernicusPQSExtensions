using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Kopernicus;
using Kopernicus.ConfigParser.Attributes;
using Kopernicus.ConfigParser.BuiltinTypeParsers;
using Kopernicus.ConfigParser.Enumerations;
using Kopernicus.ConfigParser.Interfaces;
using Kopernicus.Configuration.ModLoader;
using Kopernicus.Configuration.Parsing;
using Kopernicus.UI;
using UnityEngine;

namespace KopernicusPQSExtensions
{
    public class PQSMod_HeightBiomeMap : PQSMod
    {
        public PQSMod_HeightBiomeMap()
        {
            throw new NotImplementedException();
        }

        // Token: 0x06005313 RID: 21267 RVA: 0x00029EA8 File Offset: 0x000280A8
        public override void OnSetup()
        {
            throw new NotImplementedException();
        }

        // Token: 0x06005314 RID: 21268 RVA: 0x00029EB0 File Offset: 0x000280B0
        public override void OnVertexBuild(PQS.VertexBuildData data)
        {
            throw new NotImplementedException();
        }

        // Token: 0x06005315 RID: 21269 RVA: 0x00029EB8 File Offset: 0x000280B8
        public void SelectLandClassByHeight(double height)
        {
            throw new NotImplementedException();
        }

        // Token: 0x06005316 RID: 21270 RVA: 0x00029EC0 File Offset: 0x000280C0
        public static double Lerp(double v2, double v1, double dt)
        {
            throw new NotImplementedException();
        }

        // Token: 0x06005317 RID: 21271 RVA: 0x00029EC8 File Offset: 0x000280C8
        public double CubicHermite(double start, double end, double startTangent, double endTangent, double t)
        {
            throw new NotImplementedException();
        }

        // Token: 0x06005318 RID: 21272 RVA: 0x00029ED0 File Offset: 0x000280D0
        public static double Clamp(double v, double low, double high)
        {
            throw new NotImplementedException();
        }

        // Token: 0x0400453B RID: 17723
        public PQSMod_HeightBiomeMap.LandClass[] landClasses;

        // Token: 0x0400453C RID: 17724
        public float blend;

        // Token: 0x0400453D RID: 17725
        [HideInInspector]
        public int lcCount;

        // Token: 0x02000CC2 RID: 3266
        [Serializable]
        public class LandClass
        {
            // Token: 0x06005319 RID: 21273 RVA: 0x00029ED8 File Offset: 0x000280D8
            public LandClass(string name, double fractalStart, double fractalEnd, Color baseColor, Color colorNoise, double colorNoiseAmount)
            {
                throw new NotImplementedException();
            }

            // Token: 0x17000BB8 RID: 3000
            // (get) Token: 0x0600531A RID: 21274 RVA: 0x00029EE0 File Offset: 0x000280E0
            // (set) Token: 0x0600531B RID: 21275 RVA: 0x00029EE8 File Offset: 0x000280E8
            public double FractalDelta
            {
                [CompilerGenerated]
                get
                {
                    throw new NotImplementedException();
                }
                [CompilerGenerated]
                set
                {
                    throw new NotImplementedException();
                }
            }

            // Token: 0x0400453E RID: 17726
            public string name;

            // Token: 0x0400453F RID: 17727
            public double altStart;

            // Token: 0x04004540 RID: 17728
            public double altEnd;

            // Token: 0x04004541 RID: 17729
            public Color color;

            // Token: 0x04004542 RID: 17730
            public bool lerpToNext;
        }
    }
}
