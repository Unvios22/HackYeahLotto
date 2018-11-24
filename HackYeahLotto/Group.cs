using System.Collections.Generic;

namespace HackYeahLotto {
    public class Group {



        private int _id;
        private int _numberOfTokensInGroup;

        private List<Player> _playersInGroup = new List<Player>();
        //todo: how to initialize the list of players

        public int Id {
            get => _id;
            set => _id = value;
        }

        public int NumberOfTokensInGroup {
            get => _numberOfTokensInGroup;
            set => _numberOfTokensInGroup = value;
        }

        public List<Player> PlayersInGroup {
            get => _playersInGroup;
            set => _playersInGroup = value;

        }
    }
}