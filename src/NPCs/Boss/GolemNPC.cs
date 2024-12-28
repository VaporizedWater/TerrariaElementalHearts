using ElementalHeartsRevivedMod.src.Hearts.Boss;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementalHeartsRevivedMod.src.NPCs.Boss {
    public class GolemNPC : NPC_Base {
        public GolemNPC()
          : base(NPCID.Golem, ModContent.ItemType<Golem>(), false) {
        }
    }
}
