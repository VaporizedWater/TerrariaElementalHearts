using ElementalHeartsRevivedMod.src.Hearts.Boss;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementalHeartsRevivedMod.src.NPCs.Boss {
    public class PlanteraNPC : NPC_Base {
        public PlanteraNPC()
          : base(NPCID.Plantera, ModContent.ItemType<Plantera>(), false) {
        }
    }
}
