using Microsoft.Xna.Framework;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.lib.Interfaces.Rarity {
    /// <summary>
    /// Rarity Level: 1
    /// </summary>
    internal interface BlueRarity : ItemRarityBase {
        new int ItemRarity => ItemRarityID.Blue;
        new Color ItemColor() => Colors.RarityBlue;
    }
}
