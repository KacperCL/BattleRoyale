﻿using GTANetworkServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTANetworkShared;
namespace BattleRoyale
{
	public class OnRespawn : Script
	{
		public OnRespawn()
		{
			API.onPlayerRespawn += OnPlayerRespawn;	
		}

		private void OnPlayerRespawn(Client player)
		{
			API.setEntityPosition(player.CharacterHandle, Main.globalSettings.WaitingPosition);
		}
	}
}
