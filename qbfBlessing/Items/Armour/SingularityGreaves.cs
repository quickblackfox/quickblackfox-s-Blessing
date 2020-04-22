using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace qbfBlessing.Items.Armour
{
    [AutoloadEquip(EquipType.Legs)]
    public class SingularityGreaves : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Singularity Greaves");
            Tooltip.SetDefault("Impbued with mysterious energy");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 6666;
            item.rare = 100;
            item.defense = 400; // The Defence value for this piece of armour.
        }
        
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("SingularityChestplate") && head.type == mod.ItemType("SingularityHelmet");
        }
        

        public override void UpdateArmorSet(Player player)
        {
            player.AddBuff(BuffID.Archery, 6666);
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.OnFire] = true;
            player.statManaMax2 += 600;
        }


        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(null, "SingularityBar", 69);
            r.AddTile(TileID.Anvils); // Anvils = Iron, Lead, Mythril, etc
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}