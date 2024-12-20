using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Terraria;
using Terraria.ModLoader;

namespace ElementalHeartsRevivedMod.src
{
    internal class EHR_Info : InfoDisplay
    {

        public override bool Active() => ModContent.GetInstance<EHR_Config>().EHRInfoEnabled;

        public override string DisplayValue(ref Color displayColor, ref Color displayShadowColor)/* tModPorter Suggestion: Set displayColor to InactiveInfoTextColor if your display value is "zero"/shows no valuable information */
        {
            int num = 0;
            if (Main.LocalPlayer.GetModPlayer<EHR_Tracker>().used.Count > 1)
            {
                foreach (KeyValuePair<string, int> keyValuePair in Main.LocalPlayer.GetModPlayer<EHR_Tracker>().used)
                    num += keyValuePair.Value;
            }
            DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
            interpolatedStringHandler.AppendLiteral("+");
            interpolatedStringHandler.AppendFormatted(num);
            return interpolatedStringHandler.ToStringAndClear();
        }
    }
}
