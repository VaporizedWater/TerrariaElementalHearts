using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.lib.Interfaces.Rarity {
    /// <summary>
    /// Rarity Level: Master (Fiery Red) = -13
    /// </summary>
    internal interface MasterRarity : ItemRarityBase {
        new int ItemRarity => ItemRarityID.Master;

        // Color values might not be accurate, they were taken from the start and end frames
        // in the Fiery Red gif shown on the https://terraria.fandom.com/wiki/Rarity page
        // also, i'm not even sure if this will lerp correctly, should be worth testing
        // because if not, it'll simplify the code a lot if this is removed and turned to a static color
        // but it would look sooo cool if it worked, so maybe it's worth updating the tooltip every frame
        new Color ItemColor() => Color.Lerp(new(209, 16, 0), new(229, 161, 0), Main.masterColor);
    }
}