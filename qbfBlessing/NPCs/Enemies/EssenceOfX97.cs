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
    [AutoloadBossHead]
    class EssenceOfX97 : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Essence Of X97");
            Main.npcFrameCount[npc.type] = 1;

        }

        public override void SetDefaults()
        {
            npc.aiStyle = 30; // Reti AI for now.. might improve later or make my own, if I feel adventurous.
            npc.lifeMax = 666666; // Ha funny
            npc.damage = 500; // Ha funny (again)
            npc.defense = 500; // No more 'Ha, funny', this is an endgame boss btw
            npc.knockBackResist = 0f; // It's an eye boss...
            npc.width = 100;
            npc.height = 100;
            npc.value = 10000000;
            npc.npcSlots = 1f; // Is 1/200 (i think) max NPC slots
            npc.boss = true; // It's a BOSS.
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.HitSound = SoundID.NPCHit55;
            npc.DeathSound = SoundID.NPCDeath59;
            music = MusicID.Boss2;
        }

        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * 0.666f * bossLifeScale);
            npc.damage = (int)(npc.damage * 0.666f);
            npc.defense = (int)(npc.defense * 0.666f);
        }

    }

}


