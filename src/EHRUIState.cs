using Microsoft.Xna.Framework;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;

namespace ElementalHeartsRevivedMod.src
{
    public class EHRUIState : UIState
    {
        public override void OnInitialize()
        {
        }

        public void CreateText(string text, Color color)
        {
            UIText uiText = new UIText(text, 1f, false);
            uiText.HAlign = 0.83f;
            uiText.VAlign = 0.02f;
            uiText.TextColor = color;
            Append(uiText);
        }
    }
}
