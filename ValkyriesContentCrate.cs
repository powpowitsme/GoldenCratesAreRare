using Terraria.ModLoader;

namespace ValkyriesContentCrate
{
	class ValkyriesContentCrate : Mod
	{
		public ValkyriesContentCrate()
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
