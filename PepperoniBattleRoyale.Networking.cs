using System.IO;
using Terraria;
using Terraria.ID;
using PepperoniBattleRoyale.Common;
using static PepperoniBattleRoyale.Common.GameState;
//using static PepperoniBattleRoyale.Common.GameState.State;

namespace PepperoniBattleRoyale
{
    partial class PepperoniBattleRoyale
    {
        /*public override void HandlePacket(BinaryReader reader, int whoAmI)
        {
            byte playerNumber = reader.ReadByte();
            GameState gameState = Main.player[playerNumber].GetModPlayer<GameState>();
            gameState.ReceivePlayerSync(reader);

            if (Main.netMode == NetmodeID.Server)
            {
                gameState.SyncPlayer(-1, whoAmI, false);
            }
        }*/
    }
}
