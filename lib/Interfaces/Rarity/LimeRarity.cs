using Microsoft.Xna.Framework;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.lib.Interfaces.Rarity {
    /// <summary>
    /// Rarity Level: 7
    /// </summary>
    internal interface LimeRarity : ItemRarityBase {
        new int ItemRarity => ItemRarityID.Lime;
        new Color ItemColor() => Colors.RarityLime;
    }
}