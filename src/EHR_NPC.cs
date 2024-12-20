using System;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementalHeartsRevivedMod.src
{
    public abstract class EHR_NPC : GlobalNPC
    {
        private readonly int npcType;
        private readonly int item;
        private readonly bool shopLoot;
        private readonly int killsRequired;
        private readonly bool isEaterOfWorlds;

        public EHR_NPC(int npcType = -1, int item = -1, bool shopLoot = true, int killsRequired = 1, bool isEaterOfWorlds = false)
        {
            this.npcType = npcType;
            this.item = item;
            this.shopLoot = shopLoot;
            this.killsRequired = killsRequired;
            this.isEaterOfWorlds = isEaterOfWorlds;
        }

        public virtual void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type != npcType || !shopLoot)
                return;
            shop.item[nextSlot].SetDefaults(item);
            shop.item[nextSlot].shopCustomPrice = new int?(shop.item[nextSlot].value);
            ++nextSlot;
        }

        public override void OnKill(NPC npc)
        {
            if (isEaterOfWorlds && npc.boss && Array.IndexOf(array: new int[] { NPCID.EaterofWorldsTail, NPCID.EaterofWorldsHead, NPCID.EaterofWorldsBody }, npc.type) > -1)
            {
                Item.NewItem(null, npc.position, item, 1, false, 0, false, false);
            }
        }

        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.type != npcType || shopLoot)
                return;
            npcLoot.Add(ItemDropRule.Common(item, 1, 1, 1));
        }
    }
}
