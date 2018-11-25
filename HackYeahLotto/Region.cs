using System.Collections.Generic;

namespace HackYeahLotto {
	public class Region {
		
		private int _id;
		private int _numberOftokensInRegion;
		//todo lista wszytkich grup w regionie

		private List<Group> _listOfGroupsInRegion = new List<Group>();
		//todo initialize the list properly
		
		public int SumNumberOfTokens()
		{
			foreach (var group in _listOfGroupsInRegion)
			{
				_numberOftokensInRegion+=group.NumberOfTokensInGroup;
			}

			return _numberOftokensInRegion;
		}


		public int Id {
			get => _id;
			set => _id = value;
		}

		public int NumberOftokensInRegion {
			get => _numberOftokensInRegion;
			set => _numberOftokensInRegion = value;
		}

		public List<Group> ListOfGroupsInRegion {
			get => _listOfGroupsInRegion;
			set => _listOfGroupsInRegion = value;
		}
		

	}
}