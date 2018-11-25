using System.Collections.Generic;

namespace HackYeahLotto{
	public class Group{
		private int _id;

		//todo: how to initialize the list of players

		void SumNumberOfTokens(){
			foreach(var player in PlayersInGroup){
				NumberOfTokensInGroup += player.NumberOfTokens;
			}
		}

		public int Id{
			get => _id;
			set => _id = value;
		}

		public int NumberOfTokensInGroup{ get; set; }

		public List<Player> PlayersInGroup{ get; set; } = new List<Player>();
	}
}