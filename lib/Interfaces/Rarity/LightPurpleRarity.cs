using Microsoft.Xna.Framework;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.lib.Interfaces.Rarity {
    /// <summary>
    /// Rarity Level: 6
    /// </summary>
    internal interface LightPurpleRarity : ItemRarityBase {
        new int ItemRarity => ItemRarityID.LightPurple;
        new Color ItemColor() => Colors.RarityPurple;
    }
}