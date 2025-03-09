using Microsoft.Xna.Framework;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.lib.Interfaces.Rarity {
    /// <summary>
    /// Rarity Level: 10
    /// </summary>
    internal interface RedRarity : ItemRarityBase {
        new int ItemRarity => ItemRarityID.Red;
        new Color ItemColor() => Colors.RarityDarkRed;
    }
}