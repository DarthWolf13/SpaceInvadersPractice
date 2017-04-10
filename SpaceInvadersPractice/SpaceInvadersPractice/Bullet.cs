using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvadersPractice
{
    class Bullet : SpriteGameObject
    {        
        public Bullet() : base("bullet")
        {
            PlayingState PS = GameWorld as PlayingState;
            this.Position = PS.ship.Position;
        }

        public Bullet(float x, float y) : base("bullet")
        {
            this.Position = new Vector2(x, y);
            this.Velocity = new Vector2(0, -300);
        }
    }
}
