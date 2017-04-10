using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvadersPractice
{
    class TitleScreenState : GameObjectList
    {
        public TitleScreenState()
        {

        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);

            if (inputHelper.KeyPressed(Keys.Space))
                SpaceInvaders.GameStateManager.SwitchTo("PlayingState");
        }
    }
}
