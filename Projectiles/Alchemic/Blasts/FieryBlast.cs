using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Tremor.Projectiles.Alchemic.Blasts
{
	public class FieryBlast : AlchemistProjectile
	{
		public override void SetStaticDefaults()
		{
			Main.projFrames[projectile.type] = 5;
		}

		public override void SetDefaults()
		{
			projectile.timeLeft = 420;
			projectile.width = 52;
			projectile.height = 52;
			projectile.friendly = true;
			projectile.tileCollide = false;
			projectile.penetrate = -1;
		}

		public override Color? GetAlpha(Color lightColor)
		{
			return Color.White;
		}

		public override void AI()
		{
			projectile.frameCounter++;
			if (projectile.frameCounter > 2)
			{
				projectile.frame++;
				projectile.frameCounter = 0;
			}
			if (projectile.frame >= 5)
			{ projectile.Kill(); }
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			if (Main.rand.Next(2) == 0)
			{
				target.AddBuff(24, 180, false);
			}
		}
	}
}