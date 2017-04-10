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
        private int invaderSize = 9;

        public PlayingState()
        {
            ship = new Player();
            invaders = new GameObjectList();

            this.Add(ship);
            this.Add(invaders);

            for (int i = 0; i < invaderSize; i++)
            {
                this.invaders.Add(new Invader(0 + 32 * i, 0, "blue_invader"));
                this.invaders.Add(new Invader(0 + 32 * i, 32, "yellow_invader"));
                this.invaders.Add(new Invader(0 + 32 * i, 64, "red_invader"));
            }
        }

    }
}
