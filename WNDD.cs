using Terraria.ModLoader;

namespace WNDD
{
	class WNDD : Mod
	{
		public WNDD()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true,
			};
		}
	}
}
