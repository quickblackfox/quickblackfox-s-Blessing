using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.World.Generation;
using static Terraria.ModLoader.ModContent;
using qbfBlessing.Items.Tiles;

namespace qbfBlessingWorld
{
    public class qbfBlessingWorldGen : ModWorld
    {
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int shinesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
            if(shinesIndex != -1)
            {
                tasks.Insert(shinesIndex + 1, new PassLegacy("Singularity Ore Generation", OreGeneration));
            }
        }

        private void OreGeneration(GenerationProgress progress)
        {
            progress.Message = "Generating the ore of the Gods";
            for(var i = 0; i < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 24E-05); i++)
            {
                int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceHigh, Main.maxTilesY);
                WorldGen.TileRunner(
                    x,
                    y,
                    (double)WorldGen.genRand.Next(6, 12),
                    WorldGen.genRand.Next(4, 12),
                    mod.TileType("SingularityOre"),
                    false,
                    0f,
                    0f,
                    false,
                    true
                );
            }

            int count = 0;
            while (count < 1)
            {
                for (var i = 0; i < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 24E-05); i ++)
                {
                    int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                    int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceHigh, Main.maxTilesY);
                    Tile tile = Framing.GetTileSafely(x, y);
                    if (tile.active () && (tile.type == TileID.Stone))
                    {
                        WorldGen.TileRunner(x, y, (double)WorldGen.genRand.Next(2, 4), WorldGen.genRand.Next(3, 5), TileType<SingularityOrePlaced>());
                        count++;
                    }
                }
            }
        }
    }
}