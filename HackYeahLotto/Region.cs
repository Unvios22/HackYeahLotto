using System.Collections.Generic;

namespace HackYeahLotto {
	public class Region {
		
		private int _id;
		private int _numberOftokensInRegion;
		//todo lista wszytkich grup w regionie

		private List<Group> _listOfGroupsInRegion = new List<Group>();
		//todo initialize the list properly
		
		void SumNumberOfTokens()
		{
			foreach (var group in _listOfGroupsInRegion)
			{
				_numberOftokensInRegion+=group.NumberOfTokensInGroup;
			}
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