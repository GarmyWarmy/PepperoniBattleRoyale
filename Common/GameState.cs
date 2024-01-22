using Terraria;
using System.IO;
using Terraria.ID;
using Terraria.ModLoader;
using static PepperoniBattleRoyale.Common.Commands.StartGrace;
using PepperoniBattleRoyale.Content.Buffs;
using static PepperoniBattleRoyale.Common.GameState;
using static PepperoniBattleRoyale.Common.GameStatePlayer;
using PepperoniBattleRoyale.Common;

namespace PepperoniBattleRoyale.Common
{
    public class GameState : ModSystem
    {
        public override void PostUpdateTime()
        {
            timer++;
            if (timer >= 60)
            {
                NetMessage.SendData(MessageID.WorldData);
                timer = 0;
            }

            if ((ModContent.GetInstance<GameStatePlayer>().totalPlayers <= 3 || ModContent.GetInstance<GameStatePlayer>().totalPlayers < ModContent.GetInstance<GameStatePlayer>().totalPlayers / 3) && isPregame == false && ModContent.GetInstance<GameStatePlayer>().graceTime == 0)
            {
                gamePhase = State.Pinging;
            }
            else if (ModContent.GetInstance<GameStatePlayer>().graceTime == 0 && isPregame == false)
            {
                gamePhase = State.PvP;
            }
            else if (ModContent.GetInstance<GameStatePlayer>().graceTime > 0)
            {
                gamePhase = State.Grace;
                isPregame = false;
            }
            else
            {
                gamePhase = State.Pregame;
            }
            /*if (ModContent.GetInstance<GameStatePlayer>().graceTime > 0)
            {
                gamePhase = State.Grace;
                isPregame = false;
            }
            else if (ModContent.GetInstance<GameStatePlayer>().graceTime == 0 && isPregame == false)
            {
                gamePhase = State.PvP;
            }*/

            for (int i = 0; i < Main.maxPlayers; i++)
            {
                Player player = Main.player[i];
                if (ModContent.GetInstance<GameStatePlayer>().graceTime == 3600 && player.active && !player.dead && !player.invis)
                {
                    CombatText.NewText(player.Hitbox, Colors.RarityAmber, "Grace ends in 1 minute!");
                }
                
                switch (gamePhase)
                {
                    case State.Pregame:
                        if (!player.dead && player.active)
                        {
                            player.hostile = false;
                            player.ClearBuff(ModContent.BuffType<Grace>());
                            player.ClearBuff(ModContent.BuffType<Pregame>());
                            player.AddBuff(ModContent.BuffType<Pregame>(), ModContent.GetInstance<GameStatePlayer>().graceTime);
                        }
                        break;

                    case State.Grace:
                        if (!player.dead && player.active)
                        {
                            player.hostile = false;
                            player.ClearBuff(ModContent.BuffType<Grace>());
                            player.ClearBuff(ModContent.BuffType<Pregame>());
                            player.AddBuff(ModContent.BuffType<Grace>(), ModContent.GetInstance<GameStatePlayer>().graceTime);
                        }
                        break;

                    case State.PvP:
                        if (!player.dead && player.active)
                        {
                            player.hostile = true;
                            player.ClearBuff(ModContent.BuffType<Grace>());
                            player.ClearBuff(ModContent.BuffType<Pregame>());
                        }
                        break;

                    case State.Pinging:
                        if (!player.dead && player.active)
                        {
                            player.hostile = true;
                            player.ClearBuff(ModContent.BuffType<Grace>());
                            player.ClearBuff(ModContent.BuffType<Pregame>());

                            if (pinging == 1200)
                            {
                                Main.TriggerPing(player.Center / 16);
                                if (!player.invis)
                                {
                                    CombatText.NewText(player.Hitbox, Colors.RarityAmber, "Players have been pinged!");
                                }
                            }

                            if (pinging >= 1200)
                            {
                                pinging = 0;
                            }
                            pinging++;
                        }
                        break;
                }
            }
            if (ModContent.GetInstance<GameStatePlayer>().graceTime <= 0)
            {
                ModContent.GetInstance<GameStatePlayer>().graceTime = 0;
            }
            else
            {
                ModContent.GetInstance<GameStatePlayer>().graceTime--;
            }
        }
        public override void NetSend(BinaryWriter writer)
        {
            writer.Write(ModContent.GetInstance<GameStatePlayer>().graceTime);
            writer.Write((byte)gamePhase);
            writer.Write((int)pinging);
        }
        public override void NetReceive(BinaryReader reader)
        {
            ModContent.GetInstance<GameStatePlayer>().graceTime = reader.ReadInt32();
            gamePhase = (State)reader.ReadByte();
            pinging = reader.ReadInt32();
        }
        /*
        public void ReceivePlayerSync(BinaryReader reader)
        {
            gamePhase = (State)reader.ReadByte();
        }
        public override void CopyClientState(ModPlayer targetCopy)
        {
            GameState clone = (GameState)targetCopy;
            clone.gamePhase = gamePhase;
        }
        public override void SendClientChanges(ModPlayer clientPlayer)
        {
            GameState clone = (GameState)clientPlayer;

            if (gamePhase != clone.gamePhase)
                SyncPlayer(-1, Main.myPlayer, false);
        }
    } */

    }
    public class GameStatePlayer : ModPlayer
    {
        public enum State
        {
            Pregame = 0,
            Grace = 1,
            PvP = 2,
            Pinging = 3,
        }
        public static State gamePhase = 0;
        public int graceTime;
        public static int timer = 0;
        public static int pinging = 1200;
        public static bool isPregame = true;
        public int totalPlayers = 0;
    }
}
