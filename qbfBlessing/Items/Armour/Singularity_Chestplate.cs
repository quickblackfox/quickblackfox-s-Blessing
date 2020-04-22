using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace qbfBlessing.Items.Armour
{
    // Added instread of AutoLoad
    [AutoloadEquip(EquipType.Body)]
    public class SingularityChestplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Singularity Breastplate"); // Set the name
            Tooltip.SetDefault("Infused with the energy of a singularity\nGives you +600 mana\nImmune to On Fire"); // Set the tooltop
        }

        public override void SetDefaults()
        {
            /* Removed in 0.10
            item.name = "Tutorial Breastplate";
            item.toolTip = "This is the Tutorial Breastplate";
            */
            item.width = 18;
            item.height = 18;
            item.value = 666666;
            item.rare = 100;
            item.defense = 500; // The Defence value for this piece of armour.
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == mod.ItemType("SingularityHelmet") && legs.type == mod.ItemType("SingularityGreaves");
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