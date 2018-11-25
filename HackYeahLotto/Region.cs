using System.Collections.Generic;

namespace HackYeahLotto{
	public class Region{
		private int _id;

		private int _numberOfTokensInRegion;
		//todo lista wszytkich grup w regionie

		private List<Group> _listOfGroupsInRegion = new List<Group>();
		//todo initialize the list properly

		public int SumNumberOfTokens(){
			foreach(var group in _listOfGroupsInRegion){
				_numberOfTokensInRegion += group.NumberOfTokensInGroup;
			}

			return _numberOfTokensInRegion;
		}


		public int Id{
			get => _id;
			set => _id = value;
		}

		public int NumberOftokensInRegion{
			get => _numberOfTokensInRegion;
			set => _numberOfTokensInRegion = value;
		}

		public List<Group> ListOfGroupsInRegion{
			get => _listOfGroupsInRegion;
			set => _listOfGroupsInRegion = value;
		}
	}
}