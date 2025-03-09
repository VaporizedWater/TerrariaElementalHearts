using Microsoft.Xna.Framework;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.lib.Interfaces.Rarity {
    /// <summary>
    /// Rarity Level: 3
    /// </summary>
    internal interface OrangeRarity : ItemRarityBase {
        new int ItemRarity => ItemRarityID.Orange;
        new Color ItemColor() => Colors.RarityOrange;
    }
}
