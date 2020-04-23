using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace qbfBlessing.Items.Armour
{
    [AutoloadEquip(EquipType.Head)]
    public class SingularityHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Singularity Helmet");
            Tooltip.SetDefault("A helmet, infused with the energy of a singularity");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 666666;
            item.rare = 100;
            item.defense = 450; // The Defence value for this piece of armour.
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("SingularityBreastplate") && legs.type == mod.ItemType("SingularityGreaves");
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
            r.AddIngredient(null, "SingularityBar", 10);
            r.AddTile(TileID.Anvils); // Anvils = Iron, Lead, Mythril, etc
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}