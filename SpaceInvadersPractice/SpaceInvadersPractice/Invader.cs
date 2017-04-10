using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace SpaceInvadersPractice
{
    class Invader : SpriteGameObject
    {
        private int speed = 250;

        public Invader(int x, int y, string assetname, int layer = 0, string id = "", int sheetIndex = 0) : base(assetname, layer, id, sheetIndex)
        {
            this.Velocity = new Vector2(speed, 0);
            this.Position = new Vector2(x, y);

            this.Reset();
        }

        public override void Reset()
        {
            base.Reset();


        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            if (this.position.X < 0 || this.position.X + this.sprite.Width > SpaceInvaders.Screen.X)
            {
                Velocity *= -1;
                this.position = new Vector2(this.position.X, position.Y + 32);
            }
        }
    }
}
