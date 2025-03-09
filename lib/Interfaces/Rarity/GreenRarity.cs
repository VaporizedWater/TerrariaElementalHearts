using Microsoft.Xna.Framework;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.lib.Interfaces.Rarity {
    /// <summary>
    /// Rarity Level: 2
    /// </summary>
    internal interface GreenRarity : ItemRarityBase {
        new int ItemRarity => ItemRarityID.Green;
        new Color ItemColor() => Colors.RarityGreen;
    }
}
