using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HackYeahLotto{
	public class Game{
		private int _numberOfPlayers;
		private int _numberOfGroups;
		private int _numberOfRegions;
		private int _sumOfAllTokens;
		private int _buyingCost;
		private int _sellingCost;
		private Random rnd;

		// var initialListOfAllPlayers = new List<Players>();
		private List<Player> _listOfAllPlayers = new List<Player>();
		private List<Region> _listOfAllRegions;


		public Game(){
			SetNumberOfGroups();
			SetNumberOfRegions();
			InitializeRegions(_listOfAllRegions);
			InitializePlayer(500);
			AddPlayersToGroups();
		}


		private void SetNumberOfGroups(){
			var groupCount = _listOfAllPlayers.Count / Settings.playersInGroup;
			for(int i = 0; i < groupCount; i++){
				_numberOfGroups++;
			}
		}

		private void SetNumberOfRegions(){
			var regionsCount = _numberOfGroups / Settings.groupsInRegion;
			for(int i = 0; i < regionsCount; i++){
				_numberOfRegions++;
			}
		}

		private void InitializeRegions(List<Region> listOfRegions){
			var groupsInRegions = Settings.groupsInRegion;
			for(var i = 0; i < _numberOfRegions; i++){
				var region = new Region();

				for(var j = 0; j < groupsInRegions; j++){
					region.ListOfGroupsInRegion.Add(new Group());
				}

				listOfRegions.Add(region);
			}
		}

		private void InitializePlayer(int num){
			for(var i = 0; i < num; i++){
				var player = new Player(NumberOfPlayers++, rnd.Next(0, 100), rnd.Next(0, 100));
				_listOfAllPlayers.Add(player);
			}
		}

		private void AddPlayersToGroups(){
			var j = 0;
			var playerCount = Settings.playersInGroup;
			foreach(var region in _listOfAllRegions){
				foreach(var group in region.ListOfGroupsInRegion){
					for(int i = 0; i < playerCount; i++){
						group.PlayersInGroup.Add(_listOfAllPlayers[j]);
						j++;
					}
				}
			}
		}

		void setRandomNumberOfTokens(){
			var playerCount = Settings.playersInGroup;
			foreach(var region in _listOfAllRegions){
				foreach(var group in region.ListOfGroupsInRegion){
					foreach(var player in group.PlayersInGroup){
						player.NumberOfTokens = rnd.Next(1, 30);
					}
				}
			}
		}

		private List<Region> SetNewRegions(List<Group> winningGroups, int numberOfGroupsInRegion){
			//assumes the number of provided groups % numberOfGroupsInRegion == 0
			var createdRegions = new List<Region>();
			for(var i = 0; i < winningGroups.Count / numberOfGroupsInRegion; i++){
				createdRegions.Add(new Region());
			}

			var count = 0;
			for(var i = 0; i < winningGroups.Count; i++){
				createdRegions[count].ListOfGroupsInRegion.Add(winningGroups[i]);
				if(i + 1 % numberOfGroupsInRegion == 0){
					count++;
				}
			}

			return createdRegions;
		}


		public int NumberOfPlayers{ get; set; }

		public int NumberOfGroups{ get; set; }

		public int NumberOfRegions{ get; set; }

		public int SumOfAllTokens{ get; set; }

		public int BuyingCost{ get; set; }

		public int SellingCost{ get; set; }

		public List<Player> ListOfAllPlayers{ get; set; }
	}
}