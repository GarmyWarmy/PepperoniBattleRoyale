using Terraria;
using System.IO;
using Terraria.ID;
using Terraria.ModLoader;
using static PepperoniBattleRoyale.Common.Commands.StartGrace;
using PepperoniBattleRoyale.Content.Buffs;
using static PepperoniBattleRoyale.Common.GameState;

namespace PepperoniBattleRoyale.Common
{
    public class GameState : ModPlayer
    {
        public int graceTime;
        /*public enum State
        {
            Pregame = 0,
            Grace = 1,
            PvP = 2,
            Pinging = 3,
        }
        public State gamePhase = 0;
        public int graceTime;
        public override void SyncPlayer(int toWho, int fromWho, bool newPlayer)
        {
            ModPacket packet = Mod.GetPacket();
            packet.Write((byte)Player.whoAmI);
            packet.Write((byte)gamePhase);
            packet.Send(toWho, fromWho);
        }
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
        }*/
    }
    /*public class GameStateServer : ModSystem
    {
        public override void PostUpdateTime()
        {
            for (int j = 0; j < Main.maxPlayers; j++)
            {
                Player players = Main.player[j];
                int grace = 0;
                if (players.active)
                    grace = players.GetModPlayer<GameState>().graceTime;


                if (grace <= 0 && players.active)
                    players.GetModPlayer<GameState>().graceTime = 0;
                else
                    players.GetModPlayer<GameState>().graceTime--;

                if (players.GetModPlayer<GameState>().graceTime == 3600 && players.active)
                {
                    for (int i = 0; i < Main.maxPlayers; i++)
                    {
                        Player player = Main.player[i];
                        if (!player.dead && !player.invis && player.active)
                            CombatText.NewText(player.Hitbox, Colors.RarityOrange, "Grace ends in 1 minute!", true);
                    }
                }

                if (players.GetModPlayer<GameState>().graceTime > 0 && players.active)
                {
                    for (int i = 0; i < Main.maxPlayers; i++)
                    {
                        players.GetModPlayer<GameState>().gamePhase = State.Grace;
                    }
                }
                else if (players.GetModPlayer<GameState>().graceTime == 0 && players.GetModPlayer<GameState>().gamePhase != State.Pregame && players.active)
                {
                    for (int i = 0; i < Main.maxPlayers; i++)
                    {
                        players.GetModPlayer<GameState>().gamePhase = State.PvP;
                    }
                }

                switch (players.GetModPlayer<GameState>().gamePhase)
                {
                    case State.Pregame:
                        for (int i = 0; i < Main.maxPlayers; i++)
                        {
                            Player player = Main.player[i];
                            if (!player.dead && player.active)
                            {
                                player.hostile = false;
                                CombatText.NewText(player.Hitbox, Colors.RarityOrange, "Pregame", true);
                            }
                        }
                        break;

                    case State.Grace:
                        for (int i = 0; i < Main.maxPlayers; i++)
                        {
                            Player player = Main.player[i];
                            if (!player.dead && player.active)
                            {
                                player.hostile = false;
                                player.AddBuff(ModContent.BuffType<Grace>(), players.GetModPlayer<GameState>().graceTime);
                                CombatText.NewText(player.Hitbox, Colors.RarityOrange, "Grace", true);
                            }
                        }
                        break;

                    case State.PvP:
                        for (int i = 0; i < Main.maxPlayers; i++)
                        {
                            Player player = Main.player[i];
                            if (!player.dead && player.active)
                            {
                                player.hostile = true;
                                CombatText.NewText(player.Hitbox, Colors.RarityOrange, "Pvp", true);
                            }
                        }
                        break;

                    case State.Pinging:
                        for (int i = 0; i < Main.maxPlayers; i++)
                        {
                            Player player = Main.player[i];
                            if (!player.dead && player.active)
                            {
                                player.hostile = true;
                            }
                        }
                        break;
                }
            }
        }
    }*/
}
