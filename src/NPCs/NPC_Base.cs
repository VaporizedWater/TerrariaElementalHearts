using System;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementalHeartsRevivedMod.src.NPCs {
    public abstract class NPC_Base(int npcType = -1, int item = -1, bool shopLoot = true) : GlobalNPC {
        private readonly int npcType = npcType;
        private readonly int item = item;
        private readonly bool shopLoot = shopLoot;

        public virtual void SetupShop(int type, Chest shop, ref int nextSlot) {
            if (type != npcType || !shopLoot)
                return;
            shop.item[nextSlot].SetDefaults(item);
            shop.item[nextSlot].shopCustomPrice = new int?(shop.item[nextSlot].value);
            ++nextSlot;
        }

        public override void OnKill(NPC npc) {
            if (Array.IndexOf([NPCID.EaterofWorldsTail, NPCID.EaterofWorldsHead, NPCID.EaterofWorldsBody], npc.type) > -1) {
                Item.NewItem(null, npc.position, item);
            }
            base.OnKill(npc);
        }

        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot) {
            if (npc.type != npcType || shopLoot)
                return;
            npcLoot.Add(ItemDropRule.Common(item));
            base.ModifyNPCLoot(npc, npcLoot);
        }
    }
}
