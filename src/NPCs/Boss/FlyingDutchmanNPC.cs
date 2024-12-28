using ElementalHeartsRevivedMod.src.Hearts.Boss;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementalHeartsRevivedMod.src.NPCs.Boss {
    public class FlyingDutchmanNPC : NPC_Base {
        public FlyingDutchmanNPC()
          : base(NPCID.PirateShip, ModContent.ItemType<FlyingDutchman>(), false) {
        }
    }
}
