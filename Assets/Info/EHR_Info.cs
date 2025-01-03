﻿using ElementalHeartsRevivedMod.lib;
using ElementalHeartsRevivedMod.src;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Terraria;
using Terraria.ModLoader;

namespace ElementalHeartsRevivedMod.Assets.Info
{
    public class EHR_Info : InfoDisplay {

        public override bool Active() => ModContent.GetInstance<Config>().EHRInfoEnabled;

        public override string DisplayValue(ref Color displayColor, ref Color displayShadowColor)/* tModPorter Suggestion: Set displayColor to InactiveInfoTextColor if your display value is "zero"/shows no valuable information */
        {
            int num = 0;
            if (Main.LocalPlayer.GetModPlayer<EHR_Player>().used.Count > 1) {
                foreach (KeyValuePair<string, int> keyValuePair in Main.LocalPlayer.GetModPlayer<EHR_Player>().used)
                    num += keyValuePair.Value;
            }
            DefaultInterpolatedStringHandler interpolatedStringHandler = new(1, 1);
            interpolatedStringHandler.AppendLiteral("+");
            interpolatedStringHandler.AppendFormatted(num);
            return interpolatedStringHandler.ToStringAndClear();
        }
    }
}
