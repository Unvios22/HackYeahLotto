using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HackYeahLotto {
	public class Game {
		private int _numberOfPlayers;
		private int _numberOfGrups;
		private int _numberOfRegions;
		private int _sumOfAllTokens;
		private int _buyingCost;
		private int _sellingCost;

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
			InitializeGroups();
		}

		
		private void SetNumberOfGroups()
		{
			var groupCount = _listOfAllPlayers.Count / Settings.playersInGrup;
			for (int i = 0; i < groupCount; i++)
			{
				_numberOfGrups++;
			}
		}

		private void SetNumberOfRegions()
		{
			var regionsCount = _numberOfGrups/Settings.grupsInRegion;
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

		private Group InitializeGroups()
		{
			return new Group();
		}
		

		public int NumberOfPlayers {
			get => _numberOfPlayers;
			set => _numberOfPlayers = value;
		}

		public int NumberOfGrups {
			get => _numberOfGrups;
			set => _numberOfGrups = value;
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