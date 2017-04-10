using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvadersPractice
{
    class PlayingState : GameObjectList
    {
        public Player ship;
        GameObjectList invaders;
        GameObjectList bullets;
        private int invaderSize = 9;

        public PlayingState()
        {
            ship = new Player();
            invaders = new GameObjectList();
            bullets = new GameObjectList();

            this.Add(ship);
            this.Add(invaders);
            this.Add(bullets);

            for (int i = 0; i < invaderSize; i++)
            {
                this.invaders.Add(new Invader(0 + 32 * i, 0, "blue_invader"));
                this.invaders.Add(new Invader(0 + 32 * i, 32, "yellow_invader"));
                this.invaders.Add(new Invader(0 + 32 * i, 64, "red_invader"));
            }
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);

            if (inputHelper.KeyPressed(Keys.Space))
            {
                this.bullets.Add(new Bullet(ship.Position.X, ship.Position.Y));
            }
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            foreach (Invader invader in invaders.Objects)
            {
                foreach (Bullet bullet in bullets.Objects)
                {
                    if (bullet.CollidesWith(invader))
                    {
                        bullet.Visible = false;
                        invader.Visible = false;
                        //score.ScoreValue += 10;
                    }
                }

            }
        }

    }
}
