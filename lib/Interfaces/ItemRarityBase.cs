using Microsoft.Xna.Framework;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.lib.Interfaces {
    public interface ItemRarityBase {
        virtual int ItemRarity => ItemRarityID.White;
        virtual Color ItemColor() => Color.White;
    }
}
