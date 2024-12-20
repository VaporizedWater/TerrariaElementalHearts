using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace ElementalHeartsRevivedMod.lib
{
    public class Config : ModConfig
    {

        [Header(Constants.BaseConfig + "Headers.Basic")]
        [Category("Regular")]
        [BackgroundColor(255, 64, 159, 255)]
        [DefaultValue(false)]
        [LabelKey(Constants.BaseConfig + "EHRInfoEnabled.Label")]
        [TooltipKey(Constants.BaseConfig + "EHRInfoEnabled.Tooltip")]
        [Description(Constants.BaseConfig + "EHRInfoEnabled.Tooltip")]
        public bool EHRInfoEnabled;


        [Category("Regular")]
        [BackgroundColor(128, 141, 158, 255)]
        [DefaultValue(true)]
        [LabelKey(Constants.BaseConfig + "EHRWaveEnabled.Label")]
        [TooltipKey(Constants.BaseConfig + "EHRWaveEnabled.Tooltip")]
        [Description(Constants.BaseConfig + "EHRWaveEnabled.Tooltip")]
        public bool EHRWaveEnabled;


        [Category("Regular")]
        [BackgroundColor(193, 223, 156, 255)]
        [DefaultValue(true)]
        [LabelKey(Constants.BaseConfig + "EHRRecycleEnabled.Label")]
        [TooltipKey(Constants.BaseConfig + "EHRRecycleEnabled.Tooltip")]
        [Description(Constants.BaseConfig + "EHRRecycleEnabled.Tooltip")]
        public bool EHRRecycleEnabled;


        [Header(Constants.BaseConfig + "Headers.DontTouch")]
        [Category("Advanced")]
        [BackgroundColor(255, 0, 102, 150)]
        [DefaultValue(1)]
        [Range(1, int.MaxValue)]
        [ReloadRequired]
        [LabelKey(Constants.BaseConfig + "EHRMaxHearts.Label")]
        [TooltipKey(Constants.BaseConfig + "EHRMaxHearts.Tooltip")]
        [Description(Constants.BaseConfig + "EHRMaxHearts.Tooltip")]
        public int EHRMaxHearts;


        [Category("Advanced")]
        [BackgroundColor(255, 130, 243, 150)]
        [DefaultValue(2)]
        [Range(1, 100)]
        [ReloadRequired]
        [LabelKey(Constants.BaseConfig + "EHRLovePower.Label")]
        [TooltipKey(Constants.BaseConfig + "EHRLovePower.Tooltip")]
        [Description(Constants.BaseConfig + "EHRLovePower.Tooltip")]
        public int EHRLovePower;


        [Category("Advanced")]
        [BackgroundColor(135, 255, 235, 150)]
        [DefaultValue(1)]
        [Range(1, 100)]
        [ReloadRequired]
        [LabelKey(Constants.BaseConfig + "EHRRecipeDifficulty.Label")]
        [TooltipKey(Constants.BaseConfig + "EHRRecipeDifficulty.Tooltip")]
        [Description(Constants.BaseConfig + "EHRRecipeDifficulty.Tooltip")]
        public int EHRRecipeDifficulty;

        [Category("Advanced")]
        [DefaultValue(true)]
        [ReloadRequired]
        [LabelKey(Constants.BaseConfig + "EHRCraftingStationRequired.Label")]
        [TooltipKey(Constants.BaseConfig + "EHRCraftingStationRequired.Tooltip")]
        [Description(Constants.BaseConfig + "EHRCraftingStationRequired.Tooltip")]
        public bool EHRCraftingStationRequired;

        [Category("Advanced")]
        [DefaultValue(true)]
        [ReloadRequired]
        [LabelKey(Constants.BaseConfig + "EHRBossEnabled.Label")]
        [TooltipKey(Constants.BaseConfig + "EHRBossEnabled.Tooltip")]
        [Description(Constants.BaseConfig + "EHRBossEnabled.Tooltip")]
        public bool EHRBossEnabled;


        [Category("Advanced")]
        [DefaultValue(true)]
        [ReloadRequired]
        [LabelKey(Constants.BaseConfig + "EHRMaterialEnabled.Label")]
        [TooltipKey(Constants.BaseConfig + "EHRMaterialEnabled.Tooltip")]
        [Description(Constants.BaseConfig + "EHRMaterialEnabled.Tooltip")]
        public bool EHRMaterialEnabled;


        [Category("Advanced")]
        [BackgroundColor(128, 117, 121, 150)]
        [DefaultValue(false)]
        [LabelKey(Constants.BaseConfig + "RoamingLogsEnabled.Label")]
        [TooltipKey(Constants.BaseConfig + "RoamingLogsEnabled.Tooltip")]
        [Description(Constants.BaseConfig + "RoamingLogsEnabled.Tooltip")]
        public bool RoamingLogsEnabled;


        public override ConfigScope Mode => ConfigScope.ServerSide;
    }
}
