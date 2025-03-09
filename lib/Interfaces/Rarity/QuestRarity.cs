using Microsoft.Xna.Framework;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.lib.Interfaces.Rarity {
    /// <summary>
    /// Rarity Level: Quest (Amber) = -11 <br></br>
    /// Used for most Boss Hearts.
    /// </summary>
    internal interface QuestRarity : ItemRarityBase {
        new int ItemRarity => ItemRarityID.Quest;
        new Color ItemColor() => Colors.RarityAmber;
    }
}