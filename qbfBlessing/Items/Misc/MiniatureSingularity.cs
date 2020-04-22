using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Terraria.ID;

namespace qbfBlessing.Items.Misc
{
    public class MiniatureSingularity : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Miniature Singularity");

            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5,4)); // Animation
            ItemID.Sets.AnimatesAsSoul[item.type] = true; // Animates as a soul
            ItemID.Sets.ItemIconPulse[item.type] = true; // Pulses
            ItemID.Sets.ItemNoGravity[item.type] = true; // No gravity
        }

        public override void SetDefaults()
        {
            Item refItem = new Item();
            refItem.SetDefaults(ItemID.SoulofFright);
            item.width = refItem.width;
            item.height = refItem.height;
            item.maxStack = 9999;
            item.value = Item.buyPrice(gold: 69);
            item.rare = 100;
        }

        public override void GrabRange(Player player, ref int grabRange)
        {
            grabRange *= 3;
        }

        public override bool GrabStyle(Player player)
        {
            Vector2 vectorItemToPlayer = player.Center - item.Center;
            Vector2 movement = vectorItemToPlayer.SafeNormalize(default(Vector2)) * 0.3f;
            item.velocity = item.velocity + movement;
            item.velocity = Collision.TileCollision(item.position, item.velocity, item.width, item.height);
            return true;
        }

        public override void PostUpdate()
        {
            Lighting.AddLight(item.Center, Color.Black.ToVector3() * 0.35f * Main.essScale);
        }

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(null, "SingularityOre", 4);
            r.AddTile(TileID.Anvils); // Anvils = Iron, Lead, Mythril, etc
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}