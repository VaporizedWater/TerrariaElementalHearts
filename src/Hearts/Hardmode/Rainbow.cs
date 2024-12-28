using ElementalHeartsRevivedMod.lib.Markers.ItemCategory;
using Terraria.ID;

namespace ElementalHeartsRevivedMod.src.Hearts.Hardmode
{
    public class Rainbow : Heart_Base, HardmodeHeart {
        public Rainbow()
          : base(TileID.Anvils, 662, rainbowEffect: true) {
        }
    }
}
