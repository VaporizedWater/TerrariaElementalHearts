using Microsoft.Xna.Framework;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.lib.Interfaces.Rarity {
    /// <summary>
    /// Rarity Level: 9
    /// </summary>
    internal interface CyanRarity : ItemRarityBase {
        new int ItemRarity => ItemRarityID.Cyan;
        new Color ItemColor() => Colors.RarityCyan;
    }
}
