using ElementalHeartsRevivedMod.Assets.Effects;
using ElementalHeartsRevivedMod.lib;
using ElementalHeartsRevivedMod.lib.Markers.ItemCategory;
using ElementalHeartsRevivedMod.Localization;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.Graphics.Effects;
using Terraria.ID;
using Terraria.ModLoader;


namespace ElementalHeartsRevivedMod.src.Hearts {
    public partial class Heart_Base : ModItem {
        private const string UnusedHeartTooltipValue = "[0/";

        public string tag;
        public string name;
        public int rarity;
        public int bonusHP;
        public int station;
        public int material;
        public int coinCost;
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
        protected string heartsNotUsed;

        private static readonly EHR_ModSystem EHR_ModSystem = ModContent.GetInstance<EHR_ModSystem>();
        private static readonly EHR_Mod EHR_Mod = ModContent.GetInstance<EHR_Mod>();
        private static readonly Config Config = ModContent.GetInstance<Config>();
        private static readonly EHR_RippleEffect RippleEffect = ModContent.GetInstance<EHR_RippleEffect>();

        public Heart_Base(
          int station = TileID.Dirt,
          int material = ItemID.None,
          int rarity = ItemRarityID.Gray,
          int coinCost = 100,
          bool rainbowEffect = false,
          bool isConsumable = true) {
            this.station = station;
            this.material = material;
            this.rainbowEffect = rainbowEffect;
            this.isConsumable = isConsumable;
            this.coinCost = coinCost;

            rarity = rarity != -1 ? rarity : material == 0 ? 0 : new Item(material).rare;

            if (this is BossHeart) {
                rarity = ItemRarityID.Quest;
                pathCategoryPrefix = "Boss/";
                bonusHP = (int)(Math.Round(Config.EHRLovePower * 2 / 5.0) * 5.0);
                EHR_Mod.bossHearts.Add(this, EHR_Mod.bossHearts.Count + 1);

            } else {
                if (this is PreHardmodeHeart) {
                    pathCategoryPrefix = "PreHardmode/";
                } else if (this is HardmodeHeart) {
                    pathCategoryPrefix = "Hardmode/";
                } else if (this is UtilityHeart) {
                    pathCategoryPrefix = "Utility/";
                }

                bonusHP = (rarity + 1) * Config.EHRLovePower;
                EHR_Mod.naturalHearts.Add(this, EHR_Mod.naturalHearts.Count + 1);
            }
            tag = RegexExtensions.CapitalLetters.Replace(GetType().Name, " $0").Trim();
            texturePath = Constants.HeartsPath + pathCategoryPrefix + RegexExtensions.Spaces.Replace(tag, string.Empty);

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


            //update localized tooltips
            bonus = LocalizationUtility.GetText("CommonItemTooltip.IncreaseLifeBy", bonusHP.ToString());
            bossHeartsDisabled = LocalizationUtility.GetText("CommonItemTooltip.BossHearsDisabled");
            materialHeartsDisabled = LocalizationUtility.GetText("CommonItemTooltip.MaterialHeartsDisabled");
            maxConsumed = LocalizationUtility.GetText("CommonItemTooltip.MaxConsumed");
            maxHP = LocalizationUtility.GetText("CommonItemTooltip.MaxHP");
            heartsNotUsed = LocalizationUtility.GetText("CommonItemTooltip.HeartNotUsed");

            // Not to be confused with the Tooltip, which automatically gets included above any additional text,
            // so this allows tooltip/flavor text to be ordered how I want it (down below in CalculateTooltip).
            optionalTip = LocalizationUtility.GetText("Items." + GetType().Name + ".OptionalTip");
            if (optionalTip.Contains("Mods.ElementalHeartsRevivedMod")) {
                optionalTip = string.Empty;
            }

            name = LocalizationUtility.GetText("Items." + GetType().Name + ".DisplayName");
        }

        public override string Texture => texturePath;

        public override bool CanUseItem(Player player) {
            if (this is BossHeart) {
                if (!Config.EHRBossEnabled) {
                    return false;
                }
            } else if (!Config.EHRMaterialEnabled) {
                return false;
            }
            if (Config.EHRMaxHearts == 0 || Filters.Scene[Constants.RippleEffectName].IsActive()) {
                return false;
            }

            EHR_Player modPlayer = player.GetModPlayer<EHR_Player>();
            return !modPlayer.used.ContainsKey(tag) || modPlayer.used[tag] < Config.EHRMaxHearts * bonusHP;
        }

        public override bool? UseItem(Player player) {
            player.statLifeMax2 += bonusHP;
            player.statLife += bonusHP;

            if (Main.myPlayer == player.whoAmI) {
                player.HealEffect(bonusHP, true);
            }

            EHR_Player modPlayer = player.GetModPlayer<EHR_Player>();
            if (modPlayer.used.ContainsKey(tag)) {
                modPlayer.used[tag] += bonusHP;
            } else {
                modPlayer.used.Add(tag, bonusHP);
            }

            if (Main.netMode != NetmodeID.Server && !Filters.Scene[Constants.RippleEffectName].IsActive() && Config.EHRWaveEnabled) {
                int index = Projectile.NewProjectile(new EntitySource_ItemUse(player, Item), player.Center, new Vector2(0.0f, 0.0f), RippleEffect.Type, 0, 0.0f, Owner: Main.myPlayer);
                (Main.projectile[index].ModProjectile as EHR_RippleEffect).SetWaveValues(bonusHP);
            }

            EHR_ModSystem.DeleteText();
            return true;
        }

        public override void SetStaticDefaults() {
            Mod.Logger.Info(tag + " initialized."); //Do not localize logs, these are more for the developer than the player
        }

        public override void SetDefaults() {
            Item.CloneDefaults(ItemID.LifeFruit);
            Item.rare = rarity;

            if (material != 0) {
                Item.value = (int)(new Item(material, 1, 0).value * (CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[material] / 1.25));
            } else {
                Item.value = coinCost;
            }

            Item.consumable = isConsumable;
        }

        public override void HoldItem(Player player) {
            if (!base.CanUseItem(player)) { return; }

            StringBuilder text = new('+');
            text.Append(bonusHP).Append(' ').Append(maxHP);
            EHR_ModSystem.SendEHRText(text.ToString(), rareColor);
        }

        public override void UpdateInventory(Player player) {
            if (player.HeldItem != Item) { EHR_ModSystem.DeleteText(); }

            Config config = Config;

            if (this is BossHeart) {
                if (config.EHRBossEnabled) {
                    return;
                }
                player.SellItem(Item);
                Item.TurnToAir();
            } else {
                if (config.EHRMaterialEnabled) {
                    return;
                }
                player.SellItem(Item);
                Item.TurnToAir();
            }
        }

        /// <summary>
        /// Provides an override-able method for utility hearts to change the tooltip content without modifying tooltip behavior.
        /// </summary>
        /// <param name="tooltip"></param>
        protected virtual void ModifyTooltip(TooltipLine tooltip) {
            tooltip.Text = CalculateTooltip();
        }


        public override void ModifyTooltips(List<TooltipLine> tooltips) {
            if (!tooltipCreated) {
                TooltipLine tooltipLine = new(Mod, tag, name);
                tooltips.Add(tooltipLine);
                tooltipCreated = true;
            }
            if (!tooltipCreated)
                return;

            TooltipLine tooltip = tooltips.Find(ttl => {
                return ttl.Name == tag;
            });
            if (tooltip != null) {
                ModifyTooltip(tooltip);
            }
        }

        public override void Update(ref float gravity, ref float maxFallSpeed) {
            EHR_ModSystem system = EHR_ModSystem;
            system?.DeleteText();
        }

        public override void AddRecipes() {
            if (this is not BossHeart && Config.EHRMaterialEnabled && material != 0) {
                Recipe heartRecipe = CreateRecipe().AddIngredient(
                    material,
                    CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[material] * Config.EHRRecipeDifficulty
                );
                if (Config.EHRCraftingStationRequired) {
                    heartRecipe.AddTile(station);
                    heartRecipe.Register();
                } else {
                    heartRecipe.Register();
                }
                if (Config.EHRRecycleEnabled) {
                    Recipe recipe = Recipe.Create(material, Math.Max(1, (int)(CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[material] * Config.EHRRecipeDifficulty / 1.25)));
                    recipe.AddIngredient(this);
                    recipe.AddTile(TileID.Extractinator);
                    recipe.Register();
                }
                return;
            }
        }

        /// <summary>
        /// Given the current properties of this heart, construct and return the optional tooltip.
        /// </summary>
        /// <returns>This heart's optional tooltip text</returns>
        private string CalculateTooltip() {
            StringBuilder tooltipReturned = new(bonus);

            //calculate bonus + optional tooltip first to reduce complexity of checks below
            if (string.IsNullOrWhiteSpace(optionalTip)) {
                tooltipReturned.Append('\n');
            } else {
                tooltipReturned.Append('\n').Append(optionalTip).Append('\n');
            }

            //if current heart is a boss heart and boss hearts are disabled
            if (this is BossHeart) {
                if (!Config.EHRBossEnabled) {
                    tooltipReturned.Append(bossHeartsDisabled);
                    return tooltipReturned.ToString();
                }
            }

            //if current heart is a crafted material heart and material hearts are disabled
            else if (!Config.EHRMaterialEnabled) {
                tooltipReturned.Append(materialHeartsDisabled);
                return tooltipReturned.ToString();
            }

            //if the max hearts in the mod config are set to 1 (default behavior) and if player cannot use the item, then that means they've already used it
            if (Config.EHRMaxHearts == 1) {
                if (!CanUseItem(Main.LocalPlayer)) {
                    tooltipReturned.Append(maxConsumed);
                    return tooltipReturned.ToString();
                }
            }

            //if max hearts in the config is greater than 1 then show the amount of hearts used out of the max amount of hearts that can be used
            if (Config.EHRMaxHearts > 1) {
                Main.LocalPlayer.GetModPlayer<EHR_Player>().used.TryGetValue(tag, out int usedHearts);
                int amountUsed = usedHearts / bonusHP;
                if (Main.LocalPlayer.GetModPlayer<EHR_Player>().used.ContainsKey(tag)) {
                    tooltipReturned.Append('[').Append(amountUsed).Append('/').Append(Config.EHRMaxHearts).Append(']');
                } else {
                    tooltipReturned.Append(UnusedHeartTooltipValue).Append(Config.EHRMaxHearts).Append(']');
                }
                return tooltipReturned.ToString();
            }

            tooltipReturned.Append(heartsNotUsed);
            return tooltipReturned.ToString();
        }

        public override Color? GetAlpha(Color lightColor) {
            return rainbowEffect ? new Color?(Main.DiscoColor) : new Color?(lightColor);
        }
    }
}
