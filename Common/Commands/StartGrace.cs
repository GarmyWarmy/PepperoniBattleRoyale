using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using PepperoniBattleRoyale.Content.Buffs;
using Terraria.Chat;
using static PepperoniBattleRoyale.PepperoniBattleRoyalePlayer;
using PepperoniBattleRoyale.Common;

namespace PepperoniBattleRoyale.Common.Commands
{
    public class StartGrace : ModCommand
    {
        public override CommandType Type => CommandType.Server;
        public override string Command => "grace";
        public override string Usage
            => "/grace <seconds>";
        public override string Description => "Initiates grace period";
        public override void Action(CommandCaller caller, string input, string[] args)
        {
            if (IsPlayerLocalServerOwner(caller.Player.whoAmI))
            {
                if (args.Length == 0)
                {
                    throw new UsageException("At least one arguement was expected");
                }

                if (!int.TryParse(args[0], out int seconds))
                {
                    throw new UsageException(args[0] + " is not a correct integer value");
                }

                ModContent.GetInstance<GameStatePlayer>().graceTime = seconds * 60;
                ModContent.GetInstance<GameStatePlayer>().totalPlayers = 0;
                for (int i = 0; i < Main.maxPlayers; i++)
                {
                    if (Main.player[i].active)
                    {
                        ModContent.GetInstance<GameStatePlayer>().totalPlayers++;
                    }
                }
                /*for (int i = 0; i < Main.maxPlayers; i++)
                {
                    if (Main.player[i].active)
                        Main.player[i].AddBuff(ModContent.BuffType<Grace>(), seconds * 60);
                    if (Main.netMode == NetmodeID.MultiplayerClient)
                    {
                        NetMessage.SendData(MessageID.AddPlayerBuff);
                    }
                }*/
            }
        }
        public static bool IsPlayerLocalServerOwner(int whoAmI)
        {
            if (Main.netMode == NetmodeID.MultiplayerClient)
            {
                if (Netplay.Connection.Socket.GetRemoteAddress().IsLocalHost())
                    return true;
                else return false;
            }
            return true;
        }
    }
}
