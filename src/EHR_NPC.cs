﻿using System;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementalHeartsRevivedMod.src
{
    public abstract class EHR_NPC(int npcType = -1, int item = -1, bool shopLoot = true, bool isEaterOfWorlds = false) : GlobalNPC
    {
        private readonly int npcType = npcType;
        private readonly int item = item;
        private readonly bool shopLoot = shopLoot;
        private readonly bool isEaterOfWorlds = isEaterOfWorlds;

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
            if (isEaterOfWorlds && npc.boss && Array.IndexOf(array: [NPCID.EaterofWorldsTail, NPCID.EaterofWorldsHead, NPCID.EaterofWorldsBody], npc.type) > -1)
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
