using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvadersPractice
{
    class Player : SpriteGameObject
    {
        Vector2 StartPosition;
        private int speed = 500;

        public Player() : base("ship")
        {
            StartPosition = new Vector2(SpaceInvaders.Screen.X / 2 - this.Width / 2, SpaceInvaders.Screen.Y - this.Height);

            this.Reset();
        }

        public override void Reset()
        {
            base.Reset();

            this.Position = StartPosition;
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);

            if (inputHelper.IsKeyDown(Keys.Left) && this.position.X > 0)
                this.Velocity = new Vector2(-speed, 0);
            else if (inputHelper.IsKeyDown(Keys.Right) && this.position.X + this.Width < SpaceInvaders.Screen.X)
                this.Velocity = new Vector2(speed, 0);
            else this.Velocity = Vector2.Zero;
        }

    }
}
