using Terraria;
using Terraria.ModLoader;

namespace Tremor.Projectiles
{
	public class PoisonedKunai : ModProjectile
	{
		public override void SetDefaults()
		{

			projectile.width = 1;
			projectile.height = 1;
			projectile.friendly = true;
			projectile.aiStyle = 1;
			projectile.timeLeft = 1200;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Poisoned Kunai");

		}

		public override void Kill(int timeLeft)
		{
			for (int k = 0; k < 5; k++)
			{
				int dust = Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 73, projectile.oldVelocity.X * 0.7f, projectile.oldVelocity.Y * 0.7f);
			}
			Main.PlaySound(0, (int)projectile.position.X, (int)projectile.position.Y, 27);
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			if (Main.rand.Next(2) == 0)
			{
				target.AddBuff(20, 180, false);
			}

			projectile.ai[0] += 0.1f;
			projectile.velocity *= 0.75f;
		}

		public override void OnHitPvp(Player target, int damage, bool crit)
		{
			if (Main.rand.Next(2) == 0)
			{
				target.AddBuff(20, 180, false);
			}
		}
	}
}
