using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvadersPractice
{
    class PlayingState : GameObjectList
    {
        Player ship;

        public PlayingState()
        {
            ship = new Player();

            this.Add(ship);
        }

    }
}
