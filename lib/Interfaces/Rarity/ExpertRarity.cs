using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.lib.Interfaces.Rarity {
    /// <summary>
    /// Rarity Level: Expert (Rainbow) = -12
    /// </summary>
    internal interface ExpertRarity : ItemRarityBase {
        new int ItemRarity => ItemRarityID.Expert;
        new Color ItemColor() => Main.DiscoColor;
    }
}