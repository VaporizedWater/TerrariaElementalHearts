using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System.Collections.Generic;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ModLoader;
using Terraria.UI;

namespace ElementalHeartsRevivedMod.src
{
    public class EHRMod : Mod
    {
        public IDictionary<EHRBase, int> bossHearts = new Dictionary<EHRBase, int>();
        public IDictionary<EHRBase, int> naturalHearts = new Dictionary<EHRBase, int>();
        public IDictionary<ModItem, int> otherHearts = new Dictionary<ModItem, int>();
        //public UserInterface EHRInterface;
        //internal EHRUIState EHRUIState;

        //public override void Load() {
        //    if (Main.dedServ)
        //        return;
        //    EHRInterface = new UserInterface();
        //    EHRUIState = new EHRUIState();
        //    EHRUIState.Activate();
        //    Ref<Effect> effect = new Ref<Effect>(Assets.Request<Effect>("Effects/EHRWaveEffect", AssetRequestMode.ImmediateLoad).Value);
        //    ((EffectManager<Filter>)Filters.Scene)["EHRWave"] = new Filter(new ScreenShaderData(effect, "Shockwave"), EffectPriority.VeryHigh);
        //    ((EffectManager<Filter>)Filters.Scene)["EHRWave"].Load();
        //}

        //public override void PostSetupContent() => EHRInterface?.SetState(EHRUIState);

        //public void SendEHRText(string text, Color color) => EHRUIState.CreateText(text, color);

        //public void DeleteText() => EHRUIState.RemoveAllChildren();
    }

    [Autoload(Side = ModSide.Client)]
    public class EHRModSystem : ModSystem
    {
        private GameTime _lastUpdateUiGameTime;
        internal EHRMod mod = ModContent.GetInstance<EHRMod>();
        public UserInterface EHRInterface;
        internal EHRUIState EHRUIState;

        public override void Load()
        {
            EHRInterface = new UserInterface();
            EHRUIState = new EHRUIState();
            EHRUIState.Activate();
            Ref<Effect> effect = new Ref<Effect>(mod.Assets.Request<Effect>("Effects/EHRWaveEffect", AssetRequestMode.ImmediateLoad).Value);
            ((EffectManager<Filter>)Filters.Scene)["EHRWave"] = new Filter(new ScreenShaderData(effect, "Shockwave"), EffectPriority.VeryHigh);
            ((EffectManager<Filter>)Filters.Scene)["EHRWave"].Load();
        }

        public void SendEHRText(string text, Color color) => EHRUIState.CreateText(text, color);

        public void DeleteText() => EHRUIState.RemoveAllChildren();

        public override void PostSetupContent()
        {
            EHRInterface?.SetState(EHRUIState);
        }

        public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
        {
            int num = layers.FindIndex((layer) => layer.Name.Equals("Vanilla: Mouse Text"));

            GameInterfaceDrawMethod callback = () =>
            {
                bool currentState;
                if (_lastUpdateUiGameTime != null)
                {
                    UserInterface eHRInterface = EHRInterface;
                    if (eHRInterface != null)
                    {
                        currentState = eHRInterface.CurrentState != null;
                    }
                    else
                    {
                        currentState = false;
                    }
                    if (currentState)
                    {
                        EHRInterface.Draw(Main.spriteBatch, _lastUpdateUiGameTime);
                    }
                }
                return true;
            };

            if (num != -1)
            {
                layers.Insert(num, new LegacyGameInterfaceLayer("Elemental Hearts: UI", callback, InterfaceScaleType.UI));
            }
        }

        public override void UpdateUI(GameTime gameTime)
        {
            bool currentState;
            _lastUpdateUiGameTime = gameTime;
            UserInterface eHRInterface = EHRInterface;
            if (eHRInterface != null)
            {
                currentState = eHRInterface.CurrentState != null;
            }
            else
            {
                currentState = false;
            }
            if (currentState)
            {
                EHRUIState.Update(gameTime);
            }
        }
    }
}
