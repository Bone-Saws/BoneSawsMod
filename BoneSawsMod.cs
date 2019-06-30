using Terraria.ModLoader;

namespace BoneSawsMod
{
	class BoneSawsMod : Mod
	{
		public BoneSawsMod()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}