using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Terraria;
using Terraria.ModLoader;

namespace ElementalHeartsRevivedMod.src
{
    internal class EHInfo : InfoDisplay
    {

        public override bool Active() => ModContent.GetInstance<EHRConfig>().EHRInfoEnabled;

        public override string DisplayValue(ref Color displayColor, ref Color displayShadowColor)/* tModPorter Suggestion: Set displayColor to InactiveInfoTextColor if your display value is "zero"/shows no valuable information */
        {
            int num = 0;
            if (Main.LocalPlayer.GetModPlayer<EHRTracker>().used.Count > 1)
            {
                foreach (KeyValuePair<string, int> keyValuePair in (IEnumerable<KeyValuePair<string, int>>)Main.LocalPlayer.GetModPlayer<EHRTracker>().used)
                    num += keyValuePair.Value;
            }
            DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
            interpolatedStringHandler.AppendLiteral("+");
            interpolatedStringHandler.AppendFormatted(num);
            return interpolatedStringHandler.ToStringAndClear();
        }
    }
}
