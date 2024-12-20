using ElementalHeartsRevivedMod.lib;
using System;
using System.Reflection.Metadata;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementalHeartsRevivedMod
{
    internal class EHR_RippleEffect : ModProjectile
    {
        public float rippleCount;
        public float rippleSize;
        public float rippleSpeed;
        public float distortStrength = 333f;
        public int initialStrength = 333;

        public override void SetDefaults()
        {
            Projectile.width = 1;
            Projectile.height = 1;
            Projectile.alpha = byte.MaxValue;
            Projectile.friendly = true;
            Projectile.hostile = false;
            Projectile.tileCollide = false;
            Projectile.ignoreWater = true;
            Projectile.timeLeft = 333;
        }

        public void SetWaveValues(int count = 1, int size = 30)
        {
            rippleCount = count;
            rippleSize = size + (float)((rippleCount + 1.0) * 7.0);
            rippleSpeed = (float)(10.0 + rippleSize / 2.0);
            distortStrength = (float)(333.0 / (rippleSpeed / 10.0) + 100.0);
            Projectile.ai[0] = 1f;
        }

        public override void AI()
        {
            if (Projectile.ai[0] == 1.0)
            {
                Projectile.ai[0] = 2f;
                if (Main.netMode != NetmodeID.Server && !((EffectManager<Filter>)Filters.Scene)[Constants.RippleEffectName].IsActive())
                    Filters.Scene.Activate(Constants.RippleEffectName, Projectile.Center, Array.Empty<object>()).GetShader().UseColor(rippleCount, rippleSize, rippleSpeed).UseTargetPosition(Projectile.Center);
            }
            if (Main.netMode == NetmodeID.Server || !((EffectManager<Filter>)Filters.Scene)[Constants.RippleEffectName].IsActive())
                return;
            float num = (333 - Projectile.timeLeft) / 90f;
            ((EffectManager<Filter>)Filters.Scene)[Constants.RippleEffectName].GetShader().UseProgress(num).UseOpacity(distortStrength * (float)(1.0 - (double)num / 3.0));
        }

        public override void OnKill(int timeLeft)
        {
            if (Main.netMode == NetmodeID.Server || !((EffectManager<Filter>)Filters.Scene)[Constants.RippleEffectName].IsActive())
                return;
            ((EffectManager<Filter>)Filters.Scene)[Constants.RippleEffectName].Deactivate(Array.Empty<object>());
        }
    }
}
