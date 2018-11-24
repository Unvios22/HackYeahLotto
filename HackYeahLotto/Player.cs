namespace HackYeahLotto
{
    public class Player
    {
        

        private int _id;
        private int _numberofTokens;
        private int _positionX;
        private int _positionY;

        Player(int id, int numberOfTokens, int positionX, int positionY ) {
            Id = id;
            NumberofTokens = numberOfTokens;
            PositionX = positionX;
            PositionY = positionX;
        }
        
        void buyTokens(int amount)
        {
            //todo
        }

        void setCords()
        {
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

        public int PositionX {
            get => _positionX;
            set => _positionX = value;
        }

        public int PositionY {
            get => _positionY;
            set => _positionY = value;
        }
        
    }
}