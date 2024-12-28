using ElementalHeartsRevivedMod.src.Hearts.Boss;
using Terraria.ModLoader;

namespace ElementalHeartsRevivedMod.src.NPCs.Boss {
    public class SoulOfFrightNPC : NPC_Base {
        public SoulOfFrightNPC()
          : base(sbyte.MaxValue, ModContent.ItemType<SoulOfFright>(), false) {
        }
    }
}
