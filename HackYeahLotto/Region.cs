using System.Collections.Generic;

namespace HackYeahLotto {
	public class Region {
		private int id;

		private int numberOftokensInRegion;
		//todo lista wszytkich grup w regionie

		private List<Group> _listOfGroupsInRegion = new List<Group>();
		//todo initialize the list properly

		public int Id {
			get => id;
			set => id = value;
		}

		public int NumberOftokensInRegion {
			get => numberOftokensInRegion;
			set => numberOftokensInRegion = value;
		}

		public List<Group> ListOfGroupsInRegion {
			get => _listOfGroupsInRegion;
			set => _listOfGroupsInRegion = value;
		}
	}
}