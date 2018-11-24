using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HackYeahLotto {
	public class Game {
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

		private void InitializePlayersList(int numberOfPlayers) {
			for (int i = 0; i < numberOfPlayers; i++) {
				// _listOfAllPlayers.Add(new Player());
				//todo: define how players should bew added to the list
			}
		}

		public Game()
		{
			SetNumberOfGroups();
			SetNumberOfRegions();
			InitializeRegions();
			for (int i = 0; i < 100; i++) //robie 100 graczy, bo taki mam kaprys
			{
				InitializePlayer();
			}
			AddPlayersToGroups();
			
		}

		
		private void SetNumberOfGroups()
		{
			var groupCount = _listOfAllPlayers.Count / Settings.playersInGrup;
			for (int i = 0; i < groupCount; i++)
			{
				_numberOfGroups++;
			}
		}

		private void SetNumberOfRegions()
		{
			var regionsCount = _numberOfGroups/Settings.grupsInRegion;
			for (int i = 0; i < regionsCount; i++)
			{
				_numberOfRegions++;
			}
			
		}
		
		private void InitializeRegions()
		{
			var groupsInRegions = Settings.grupsInRegion;
			for (int i = 0; i < _numberOfRegions; i++)
			{
				
				Region region = new Region();
				
				for (int j = 0; j < groupsInRegions; j++)
				{
					region.ListOfGroupsInRegion.Add(InitializeGroups());
				}
				_listOfAllRegions.Add(region);
			}
		}



		private Group InitializeGroups()  //tu dodac
		{
			return new Group();
		}

		private void InitializePlayer()
		{
			_listOfAllPlayers.Add(new Player(NumberOfPlayers++, rnd.Next(0, 100), rnd.Next(0, 100)));
		}
		private void AddPlayersToGroups()
		{
			
			var playerCount = Settings.playersInGrup;
			foreach (var region in _listOfAllRegions)
			{
				foreach (var @group in region.ListOfGroupsInRegion)
				{
					for (int i = 0; i < playerCount; i++)
					{
						@group.PlayersInGroup.Add(_listOfAllPlayers[i]);
					}
				}
			}
			
		}

		
		

		public int NumberOfPlayers {
			get => _numberOfPlayers;
			set => _numberOfPlayers = value;
		}

		public int NumberOfGroups {
			get => _numberOfGroups;
			set => _numberOfGroups = value;
		}

		public int NumberOfRegions {
			get => _numberOfRegions;
			set => _numberOfRegions = value;
		}

		public int SumOfAllTokens {
			get => _sumOfAllTokens;
			set => _sumOfAllTokens = value;
		}

		public int BuyingCost {
			get => _buyingCost;
			set => _buyingCost = value;
		}

		public int SellingCost {
			get => _sellingCost;
			set => _sellingCost = value;
		}

		public List<Player> ListOfAllPlayers {
			get => _listOfAllPlayers;
			set => _listOfAllPlayers = value;
		}


		
	}
}