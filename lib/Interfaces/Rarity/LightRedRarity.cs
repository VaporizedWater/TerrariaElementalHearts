using Microsoft.Xna.Framework;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.lib.Interfaces.Rarity {
    /// <summary>
    /// Rarity Level: 4
    /// </summary>
    internal interface LightRedRarity : ItemRarityBase {
        new int ItemRarity => ItemRarityID.LightRed;
        new Color ItemColor() => Colors.RarityRed;
    }
}