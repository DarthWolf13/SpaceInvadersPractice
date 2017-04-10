using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvadersPractice
{
    class PlayingState : GameObjectList
    {
        Player ship;
        GameObjectList invaders;

        public PlayingState()
        {
            ship = new Player();
            invaders = new GameObjectList();

            this.Add(ship);
            this.Add(invaders);
        }

    }
}
