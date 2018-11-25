using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HackYeahLotto {
	public class Game {
	//test
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


		public Game()
		{
			SetNumberOfGroups();
			SetNumberOfRegions();
			InitializeRegions(_listOfAllRegions);
			for (int i = 0; i < 100; i++) //robie 100 graczy, bo taki mam kaprys
			{
				InitializePlayer();
			}
			AddPlayersToGroups();
			
		}

		
		private void SetNumberOfGroups()
		{
			
			var groupCount = _listOfAllPlayers.Count / Settings.playersInGroup;
			for (int i = 0; i < groupCount; i++)
			{
				_numberOfGroups++;
			}
		}

		private void SetNumberOfRegions()
		{
			var regionsCount = _numberOfGroups/Settings.groupsInRegion;
			for (int i = 0; i < regionsCount; i++)
			{
				_numberOfRegions++;
			}
			
		}
		
		private void InitializeRegions(List<Region> listOfRegions)
		{
			var groupsInRegions = Settings.groupsInRegion;
			for (int i = 0; i < _numberOfRegions; i++)
			{
				
				Region region = new Region();
				
				for (int j = 0; j < groupsInRegions; j++)
				{
					region.ListOfGroupsInRegion.Add(InitializeGroups());
				}
				listOfRegions.Add(region);
			}
		}



		private Group InitializeGroups() 
		{
			return new Group();
		}

		private void InitializePlayer()
		{
			_listOfAllPlayers.Add(new Player(NumberOfPlayers++, rnd.Next(0, 100), rnd.Next(0, 100)));
		}
		
		private void AddPlayersToGroups()
		{
			var j = 0;
			var playerCount = Settings.playersInGroup;
			foreach (var region in _listOfAllRegions)
			{
				foreach (var @group in region.ListOfGroupsInRegion)
				{
					
					for (int i = 0; i < playerCount; i++)
					{
						@group.PlayersInGroup.Add(_listOfAllPlayers[j]);
						j++;
					}
				}
			}
		}

		void setRandomNumberOfTokens()
		{
			var playerCount = Settings.playersInGroup;
			foreach (var region in _listOfAllRegions)
			{
				foreach (var @group in region.ListOfGroupsInRegion)
				{
					foreach (var player in group.PlayersInGroup)
					{
						player.NumberofTokens = rnd.Next(1, 30);
					}
				
				}
			}
		}

		private void setNewRegions()
		{
			// nowe Regiony, ze starymi Grupami, ze starymi Playerami
			
			
			WinnerChooser chooser = new WinnerChooser();
			List<Region> newRegions = new List<Region>();
			_numberOfRegions /= 5; // ilość regionów do stworzenia;
			InitializeRegions(newRegions); //nowe Regiony
			var i = 0; //Zakładamy, że mieliśmy 20 Regionów. Teraz mamy w newRegions 4 regiony
			foreach (var regions in newRegions) //Dla każdego z 4 Regionów
			{
				var count = regions.ListOfGroupsInRegion.Count;
				for (int j = 0; j < count; j++)
				{
					regions.ListOfGroupsInRegion[j] = chooser.ChooseWinner(_listOfAllRegions[i].ListOfGroupsInRegion,_listOfAllRegions[i].SumNumberOfTokens());
					i++;
				}
			}

			_listOfAllRegions = newRegions;
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