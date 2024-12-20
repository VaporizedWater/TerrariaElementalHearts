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
    public class EHR_Mod : Mod
    {
        public IDictionary<EHR_Base, int> bossHearts = new Dictionary<EHR_Base, int>();
        public IDictionary<EHR_Base, int> naturalHearts = new Dictionary<EHR_Base, int>();
        public IDictionary<ModItem, int> otherHearts = new Dictionary<ModItem, int>();
    }

    [Autoload(Side = ModSide.Client)]
    public class EHR_ModSystem : ModSystem
    {
        private GameTime _lastUpdateUiGameTime;
        internal EHR_Mod mod = ModContent.GetInstance<EHR_Mod>();
        public UserInterface EHRInterface;
        internal EHR_UIState EHRUIState;

        public override void Load()
        {
            EHRInterface = new UserInterface();
            EHRUIState = new EHR_UIState();
            EHRUIState.Activate();
            Asset<Effect> shader =  ModContent.Request<Effect>("ElementalHeartsRevivedMod/Assets/Effects/EHR_RippleEffect", AssetRequestMode.ImmediateLoad);
            Filters.Scene["EHR_Wave"] = new Filter(new ScreenShaderData(shader, "EHR_RippleEffect"), EffectPriority.VeryHigh);
            Filters.Scene["EHR_Wave"].Load();
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
