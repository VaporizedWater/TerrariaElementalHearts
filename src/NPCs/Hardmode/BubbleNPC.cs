using ElementalHeartsRevivedMod.src.Hearts.Hardmode;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementalHeartsRevivedMod.src.NPCs.Hardmode {
    public class BubbleNPC : NPC_Base {
        public BubbleNPC()
          : base(NPCID.PartyGirl, ModContent.ItemType<Bubble>()) {
        }
    }
}
