﻿using ElementalHeartsRevivedMod.Assets.Effects;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.Graphics.Effects;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementalHeartsRevivedMod.src {
    public class EHRBase : ModItem {
        public bool boss;
        public string tag;
        public string name;
        public int rarity;
        public int bonusHP;
        public int cat;
        public int station;
        public int material;
        public int backupValue;
        public string texturePath;
        private readonly string pathCategoryPrefix;
        public Color rareColor;
        public bool tooltipCreated;
        public bool rainbowEffect;
        protected string optionalTip;
        protected bool isConsumable;
        protected string bonus;
        protected string bossHeartsDisabled;
        protected string materialHeartsDisabled;
        protected string maxConsumed;
        protected string maxHP;
        protected string heartNotUsed;
        protected string path = "ElementalHeartsRevivedMod/Assets/Items/Consumables/Hearts/";

        public EHRBase(
          int category,
          int station = 0,
          int material = 0,
          int rarity = -1,
          int val = 100,
          bool boss = false,
          bool rainbowEffect = false,
          bool isConsumable = true) {
            this.boss = boss;
            cat = category;
            rarity = rarity != -1 ? rarity : material == 0 ? 0 : new Item(material, 1, 0).rare;
            if (boss)
                rarity = ItemRarityID.Quest;
            this.station = station;
            this.material = material;
            tag = Regex.Replace(GetType().Name, "[A-Z]", " $0").Trim();
            switch (cat) {
                case 1:
                    pathCategoryPrefix = "Boss/";
                    break;
                case 2:
                    pathCategoryPrefix = "Hardmode/";
                    break;
                case 3:
                    pathCategoryPrefix = "Other/";
                    break;
                case 4:
                    pathCategoryPrefix = "PreHardmode/";
                    break;
            }
            bonusHP = !boss ? (rarity + 1) * ModContent.GetInstance<EHRConfig>().EHRLovePower : (int)(Math.Round(ModContent.GetInstance<EHRConfig>().EHRLovePower * 2 / 5.0) * 5.0);
            texturePath = path + pathCategoryPrefix + Regex.Replace(tag, " ", string.Empty);
            if (boss)
                ModContent.GetInstance<EHRMod>().bossHearts.Add(this, ModContent.GetInstance<EHRMod>().bossHearts.Count + 1);
            else if (!boss)
                ModContent.GetInstance<EHRMod>().naturalHearts.Add(this, ModContent.GetInstance<EHRMod>().naturalHearts.Count + 1);

            switch (rarity) {
                case ItemRarityID.Quest:
                    rareColor = Colors.RarityAmber;
                    break;
                case 0:
                    rareColor = Colors.RarityNormal;
                    break;
                case 1:
                    rareColor = Colors.RarityBlue;
                    break;
                case 2:
                    rareColor = Colors.RarityGreen;
                    break;
                case 3:
                    rareColor = Colors.RarityOrange;
                    break;
                case 4:
                    rareColor = Colors.RarityRed;
                    break;
                case 5:
                    rareColor = Colors.RarityPink;
                    break;
                case 6:
                    rareColor = Colors.RarityPurple;
                    break;
                case 7:
                    rareColor = Colors.RarityLime;
                    break;
                case 8:
                    rareColor = Colors.RarityYellow;
                    break;
                case 9:
                    rareColor = Colors.RarityCyan;
                    break;
                case 10:
                    rareColor = Colors.RarityDarkRed;
                    break;
                case 11:
                    rareColor = Colors.RarityDarkPurple;
                    break;
            }
            backupValue = val;
            this.rainbowEffect = rainbowEffect;
            this.isConsumable = isConsumable;

            //update localized tooltips
            bonus = Localization.GetText("CommonItemTooltip.IncreaseLifeBy", bonusHP.ToString());
            bossHeartsDisabled = Localization.GetText("CommonItemTooltip.BossHearsDisabled");
            materialHeartsDisabled = Localization.GetText("CommonItemTooltip.MaterialHeartsDisabled");
            maxConsumed = Localization.GetText("CommonItemTooltip.MaxConsumed");
            maxHP = Localization.GetText("CommonItemTooltip.MaxHP");
            heartNotUsed = Localization.GetText("CommonItemTooltip.HeartNotUsed");

            // Not to be confused with the Tooltip, which automatically gets included above any additional text,
            // so this allows tooltip/flavor text to be ordered how I want it (down below in CalculateTooltip).
            optionalTip = Localization.GetText("Items." + GetType().Name + ".OptionalTip");
            if (optionalTip.Contains("Mods.ElementalHeartsRevivedMod")) {
                optionalTip = string.Empty;
            }


            name = Localization.GetText("Items." + GetType().Name + ".DisplayName");
        }

        public override string Texture => texturePath;

        public override bool CanUseItem(Player player) {
            if (boss) {
                if (!ModContent.GetInstance<EHRConfig>().EHRBossEnabled)
                    return false;
            } else if (!ModContent.GetInstance<EHRConfig>().EHRMaterialEnabled)
                return false;
            if (ModContent.GetInstance<EHRConfig>().EHRMaxHearts == 0 || ((EffectManager<Filter>)Filters.Scene)["EHRWave"].IsActive())
                return false;
            return !player.GetModPlayer<EHRTracker>().used.ContainsKey(tag) || player.GetModPlayer<EHRTracker>().used[tag] < ModContent.GetInstance<EHRConfig>().EHRMaxHearts * bonusHP;
        }

        public override bool? UseItem(Player player) {
            player.statLifeMax2 += bonusHP;
            player.statLife += bonusHP;
            if (Main.myPlayer == player.whoAmI)
                player.HealEffect(bonusHP, true);
            if (player.GetModPlayer<EHRTracker>().used.ContainsKey(tag))
                player.GetModPlayer<EHRTracker>().used[tag] += bonusHP;
            else
                player.GetModPlayer<EHRTracker>().used.Add(tag, bonusHP);
            if (Main.netMode != NetmodeID.Server && !((EffectManager<Filter>)Filters.Scene)["EHRWave"].IsActive() && ModContent.GetInstance<EHRConfig>().EHRWaveEnabled) {
                int index = Projectile.NewProjectile(new EntitySource_ItemUse(player, Item, null), player.Center, new Vector2(0.0f, 0.0f), ModContent.GetInstance<EHRWave>().Type, 0, 0.0f, Main.myPlayer, 0.0f, 0.0f);
                (Main.projectile[index].ModProjectile as EHRWave).SetWaveValues(bonusHP);
            }
            ModContent.GetInstance<EHRModSystem>().DeleteText();
            return new bool?(true);
        }

        public override void SetStaticDefaults() {
            Mod.Logger.Info(tag + " initialized."); //Do not localize logs, these are more for the developer than the player
            //CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[material] = 1;
        }

        public override void SetDefaults() {
            Item.CloneDefaults(ItemID.LifeFruit);
            Item.rare = rarity;
            if (material != 0)
                Item.value = (int)(new Item(material, 1, 0).value * (CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[material] / 1.25));
            else
                Item.value = backupValue;
            Item.consumable = isConsumable;
        }

        public override void HoldItem(Player player) {
            if (!base.CanUseItem(player))
                return;
            ModContent.GetInstance<EHRModSystem>().SendEHRText("+" + bonusHP.ToString() + " " + maxHP, rareColor);
        }

        public override void UpdateInventory(Player player) {
            if (player.HeldItem != Item)
                ModContent.GetInstance<EHRModSystem>().DeleteText();
            if (boss) {
                //Guard clauses can sometimes be nice, but I feel like the whole mod should be structured better, so 
                //guard clauses are not needed at all because that just encourages lazy organization.

                if (ModContent.GetInstance<EHRConfig>().EHRBossEnabled)
                    return;
                player.SellItem(Item, -1);
                Item.TurnToAir();
            } else {
                if (ModContent.GetInstance<EHRConfig>().EHRMaterialEnabled)
                    return;
                player.SellItem(Item, -1);
                Item.TurnToAir();
            }
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips) {
            if (!tooltipCreated) {
                TooltipLine tooltipLine = new TooltipLine(Mod, tag, name);
                tooltips.Add(tooltipLine);
                tooltipCreated = true;
            }
            if (!tooltipCreated)
                return;

            TooltipLine tooltip = tooltips.Find(ttl => {
                return ttl.Name == tag;
            });
            if (tooltip != null) {
                tooltip.Text = CalculateTooltip();
            }
        }

        public override void Update(ref float gravity, ref float maxFallSpeed) {
            EHRModSystem system = ModContent.GetInstance<EHRModSystem>();
            if (system != null) {
                system.DeleteText();
            }
        }

        public override void AddRecipes() {
            if (!boss && ModContent.GetInstance<EHRConfig>().EHRMaterialEnabled && material != 0) {
                Recipe heartRecipe = CreateRecipe().AddIngredient(
                    material,
                    CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[material] * ModContent.GetInstance<EHRConfig>().EHRRecipeDifficulty
                );
                if (ModContent.GetInstance<EHRConfig>().EHRCraftingStationRequired) {
                    heartRecipe.AddTile(station).Register();
                } else {
                    heartRecipe.Register();
                }
                if (ModContent.GetInstance<EHRConfig>().EHRRecycleEnabled) {
                    Recipe recipe = Recipe.Create(material, Math.Max(1, (int)(CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[material] * ModContent.GetInstance<EHRConfig>().EHRRecipeDifficulty / 1.25)));
                    recipe.AddIngredient(this);
                    recipe.AddTile(TileID.Extractinator);
                    recipe.Register();
                }
                return;
            }
        }

        public virtual string CalculateTooltip() {
            string tooltipReturned;


            //calculate bonus + optional tooltip first to reduce complexity of checks below
            if (string.IsNullOrWhiteSpace(optionalTip))
                tooltipReturned = bonus + "\n";
            else
                tooltipReturned = bonus + "\n" + optionalTip + "\n";

            //if current heart is a boss heart and boss hearts are disabled
            if (boss) {
                if (!ModContent.GetInstance<EHRConfig>().EHRBossEnabled) {
                    tooltipReturned += bossHeartsDisabled;
                    return tooltipReturned;
                }
            }

            //if current heart is a crafted material heart and material hearts are disabled
            else if (!ModContent.GetInstance<EHRConfig>().EHRMaterialEnabled) {
                tooltipReturned += materialHeartsDisabled;
                return tooltipReturned;
            }

            //if the max hearts in the mod config are set to 1 (default behavior) and if player cannot use the item, then that means they've already used it
            if (ModContent.GetInstance<EHRConfig>().EHRMaxHearts == 1) {
                if (!CanUseItem(Main.LocalPlayer)) {
                    tooltipReturned += maxConsumed;
                    return tooltipReturned;
                }
            }

            //if max hearts in the config is greater than 1 then show the amount of hearts used out of the max amount of hearts that can be used
            if (ModContent.GetInstance<EHRConfig>().EHRMaxHearts > 1) {
                int usedHearts;
                Main.LocalPlayer.GetModPlayer<EHRTracker>().used.TryGetValue(tag, out usedHearts);
                int amountUsed = usedHearts / bonusHP;
                if (Main.LocalPlayer.GetModPlayer<EHRTracker>().used.ContainsKey(tag)) {
                    tooltipReturned += "[" + amountUsed.ToString() + "/" + ModContent.GetInstance<EHRConfig>().EHRMaxHearts.ToString() + "]";
                } else {
                    tooltipReturned += "[0/" + ModContent.GetInstance<EHRConfig>().EHRMaxHearts.ToString() + "]";
                }
                return tooltipReturned;
            }

            return tooltipReturned += heartNotUsed;
            //return tooltipReturned;
        }

        public override Color? GetAlpha(Color lightColor) {
            return rainbowEffect ? new Color?(Main.DiscoColor) : new Color?(lightColor);
        }
    }
}