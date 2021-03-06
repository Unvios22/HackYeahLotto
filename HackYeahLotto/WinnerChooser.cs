using System;
using System.Collections.Generic;

namespace HackYeahLotto{
	public class WinnerChooser{
		public Group ChooseWinner(IEnumerable<Group> listOfGroups, int numberOfTokensInRegion){
			var randomizedNumberGroupPairs = new Dictionary<float, Group>();
			var random = new Random();
			foreach(var group in listOfGroups){
				var percentageChance = (float) group.NumberOfTokensInGroup / numberOfTokensInRegion;
				//casting to float to counter possible loss of fraction;
				var randomizedNumber = random.Next(0, 10000) / percentageChance;
				randomizedNumberGroupPairs.Add(randomizedNumber, group);
			}

			float smallestNumber = 10000;
			foreach(var pair in randomizedNumberGroupPairs){
				if(pair.Key < smallestNumber){
					smallestNumber = pair.Key;
				}
			}

			return randomizedNumberGroupPairs[smallestNumber];
		}

		public Player ChooseWinner(IEnumerable<Player> listOfPlayers, int numberOfTokensInGroup){
			var randomizedNumberPlayerPairs = new Dictionary<float, Player>();
			var random = new Random();
			foreach(var player in listOfPlayers){
				var percentageChance = (float) player.NumberOfTokens / numberOfTokensInGroup;
				//casting to float to counter possible loss of fraction;
				var randomizedNumber = random.Next(0, 10000) / percentageChance;
				randomizedNumberPlayerPairs.Add(randomizedNumber, player);
			}

			float smallestNumber = 10000;
			foreach(var pair in randomizedNumberPlayerPairs){
				if(pair.Key < smallestNumber){
					smallestNumber = pair.Key;
				}
			}

			return randomizedNumberPlayerPairs[smallestNumber];
		}
	}
}