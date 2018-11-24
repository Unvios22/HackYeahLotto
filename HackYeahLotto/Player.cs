namespace HackYeahLotto {
	public class Player {
		private int _id;
		private int _numberofTokens;
		private float _positionX;
		private float _positionY;

		public Player(int id, int numberOfTokens, int positionX, int positionY) {
			Id = id;
			NumberofTokens = numberOfTokens;
			PositionX = positionX;
			PositionY = positionX;
		}

		public Player(int id, int positionX, int positionY) {
			Id = id;
			NumberofTokens = 0;
			PositionX = positionX;
			PositionY = positionX;
		}

		void buyTokens(int amount) {
			//todo
		}

		void setCords() {
			//todo
			//get position i tak dalej
		}

		public int Id {
			get => _id;
			set => _id = value;
		}

		public int NumberofTokens {
			get => _numberofTokens;
			set => _numberofTokens = value;
		}

		public float PositionX {
			get => _positionX;
			set => _positionX = value;
		}

		public float PositionY {
			get => _positionY;
			set => _positionY = value;
		}
	}
}