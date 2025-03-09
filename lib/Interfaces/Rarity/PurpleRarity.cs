using Microsoft.Xna.Framework;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.lib.Interfaces.Rarity {
    /// <summary>
    /// Rarity Level: 11
    /// </summary>
    internal interface PurpleRarity : ItemRarityBase {
        new int ItemRarity => ItemRarityID.Purple;
        new Color ItemColor() => Colors.RarityDarkPurple;
    }
}
