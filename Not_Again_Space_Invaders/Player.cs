using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Not_Again_Space_Invaders
{
    class Player : Sprite
    {
        private int lives = 3;

        public Player(Rectangle inposition, Texture2D intexture, Color incolour): base(inposition, intexture, incolour)
        {   
        }

        public void movement()
        {
            if(Keyboard.GetState().IsKeyDown(Keys.Right) && spritePosition.X + spritetexture.Width < GraphicsDeviceManager.DefaultBackBufferWidth)
            {
                spritePosition.X += 3;
            }
            if(Keyboard.GetState().IsKeyDown(Keys.Left) && spritePosition.X > 0)
            {
                spritePosition.X -= 3;
            }
        }

        public void shoot()
        {
            
        }


        public bool collided()
        {
            //write the logic
            return true;
        }
    }
}
