using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Not_Again_Space_Invaders
{
    class Sprite
    {
        protected Rectangle spritePosition;
        protected Texture2D spritetexture;
        protected Color spritecolour;

        public Sprite(Rectangle inposition, Texture2D intexture, Color incolour)
        {
            spritePosition = inposition;
            spritetexture = intexture;
            spritecolour = incolour; 
        }

        public void DrawSprite(SpriteBatch inspritebatch)
        {
            inspritebatch.Draw(spritetexture, spritePosition, spritecolour);
        }
            
        public Rectangle Position
        {
            get { return spritePosition; }
            set { spritePosition = value; }
        }

        public Texture2D Texture
        {
            get { return spritetexture; }
            set { spritetexture = value; }
        }
    }
}
