using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Not_Again_Space_Invaders
{
    class Bullet : Sprite
    {
        private bool fired = false;
        private int xposition;
        private int yposition; 

        public Bullet(Rectangle inposition, Texture2D intexture, Color incolour) : base(inposition, intexture, incolour)
        {

        }

        public void InitialPosition(Sprite insprite)
        {
            fired = false;
            xposition = insprite.Position.X + spritetexture.Width / 2 - 5;
            spritePosition = new Rectangle(xposition, insprite.Position.Y, 10, 10);
            yposition = spritePosition.Y;
        }
        public void FireBullet(Sprite inSprite)
        {
            if(Keyboard.GetState().IsKeyDown(Keys.Space))
            {
                fired = true;
            }

            if(spritePosition.Y > 0 && fired == true)
            {
                spritePosition = new Rectangle(xposition, yposition, 10, 10);
                yposition -= 10;
            }
            else
            {
                InitialPosition(inSprite);
                fired = false;
            }
            
        }

    }
}
