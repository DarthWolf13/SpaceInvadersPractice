using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvadersPractice
{
    class Player : SpriteGameObject
    {
        Vector2 StartPosition;

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
    }
}
