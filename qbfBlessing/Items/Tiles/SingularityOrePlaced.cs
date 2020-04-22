using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace qbfBlessing.Items.Tiles
{
    public class SingularityOrePlaced : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;

            drop = ItemType<Items.Tiles.SingularityOre>();

            ModTranslation name = CreateMapEntryName();
            AddMapEntry(new Color(0, 0, 0), name);

            minPick = 666;
        }
    }
}