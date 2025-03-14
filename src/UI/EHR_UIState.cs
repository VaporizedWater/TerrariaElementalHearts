﻿using Microsoft.Xna.Framework;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;

namespace ElementalHeartsRevivedMod.src._UI {
    public class EHR_UIState : UIState {
        public override void OnInitialize() {
        }

        public void CreateText(string text, Color color) {
            UIText uiText = new(text) {
                HAlign = 0.83f,
                VAlign = 0.02f,
                TextColor = color
            };
            Append(uiText);
        }
    }
}
