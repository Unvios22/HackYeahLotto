namespace HackYeahLotto{
	public class Player{
		public Player(int id, int numberOfTokens, int positionX, int positionY){
			Id = id;
			NumberOfTokens = numberOfTokens;
			PositionX = positionX;
			PositionY = positionY;
		}

		public Player(int id, int positionX, int positionY){
			Id = id;
			NumberOfTokens = 0;
			PositionX = positionX;
			PositionY = positionY;
		}

		void buyTokens(int amount){
			//todo
		}

		void setCords(){
			//todo
			//get position i tak dalej
		}

		public int Id{ get; set; }

		public int NumberOfTokens{ get; set; }

		public float PositionX{ get; set; }

		public float PositionY{ get; set; }
	}
}