using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace BoneSawsMod.Items
{
	public class BoneSaw : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bone Saw");
			Tooltip.SetDefault("Capable of cutting even the strongest of bones despite being made out of bones.");
		}
		public override void SetDefaults()
		{
			item.damage = 38;
			item.melee = true;
			item.width = 80;
			item.height = 80;
			item.useTime = 19;
			item.useAnimation = 38;
			item.axe = 20;
			item.useStyle = 1;
			item.knockBack = 0;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Bone, 10);
			recipe.AddIngredient(ItemID.IronBar, 3);
			recipe.AddTile(TileID.BoneWelder);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
		public override Vector2? HoldoutOffset()
		{
		return new Vector2(10, 10);
		}
	}
}