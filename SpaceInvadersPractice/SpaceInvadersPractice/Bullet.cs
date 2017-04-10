using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvadersPractice
{
    class Bullet : SpriteGameObject
    {
        Vector2 StartPosition;
        public Vector2 FirePosition;
        private int speed = 200;

        public Bullet() : base("bullet")
        {
            StartPosition = new Vector2(-100, -100);

            this.Reset();
        }

        public Bullet(float x, float y) : base("bullet")
        {
            this.Position = new Vector2(x, y);
            this.Velocity = new Vector2(0, -300);
        }

        public override void Reset()
        {
            base.Reset();

            this.Velocity = Vector2.Zero;
            this.Position = StartPosition;
        }
    }
}
