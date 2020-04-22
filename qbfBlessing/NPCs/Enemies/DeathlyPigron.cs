using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace qbfBlessing.NPCs.Enemies
{
    class DeathlyPigron : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Deathly Pigron");
            Main.npcFrameCount[npc.type] = 14;

        }

        public override void SetDefaults()
        {
            npc.aiStyle = 2; 
            npc.lifeMax = 52000; 
            npc.damage = 100; 
            npc.defense = 200; 
            npc.knockBackResist = 10f; 
            npc.width = 100;
            npc.height = 100;
            npc.value = 10000;
            npc.npcSlots = 1f; 
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.HitSound = SoundID.NPCHit27;
            npc.DeathSound = SoundID.NPCDeath17;
        }

    }

}


