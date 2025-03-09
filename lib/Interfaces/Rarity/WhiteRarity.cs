using Microsoft.Xna.Framework;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.lib.Interfaces.Rarity {
    /// <summary>
    /// Rarity Level: 0
    /// </summary>
    internal interface WhiteRarity : ItemRarityBase {
        new int ItemRarity => ItemRarityID.White;
        new Color ItemColor() => Colors.RarityNormal;
    }
}