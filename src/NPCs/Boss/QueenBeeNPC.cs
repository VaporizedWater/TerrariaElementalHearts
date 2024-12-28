using ElementalHeartsRevivedMod.src.Hearts.Boss;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementalHeartsRevivedMod.src.NPCs.Boss {
    public class QueenBeeNPC : NPC_Base {
        public QueenBeeNPC()
          : base(NPCID.QueenBee, ModContent.ItemType<QueenBee>(), false) {
        }
    }
}
