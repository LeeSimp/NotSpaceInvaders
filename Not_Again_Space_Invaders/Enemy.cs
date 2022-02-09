using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Not_Again_Space_Invaders
{
    class Enemy : Sprite
    {
        private bool isDrawn;
        private Sprite otherSprite;

        public Enemy(Rectangle inposition, Texture2D intexture, Color incolour, bool inisDrawn, Sprite inotherSprite) : base(inposition, intexture, incolour)
        {
            isDrawn = inisDrawn;
            otherSprite = inotherSprite;
        }

        public bool checkCollided(Sprite inOtherSprite)
        {
            bool Collided = false;
            if(spritePosition.Intersects(inOtherSprite.Position))
            {
                Collided = true;
            }
            return Collided;
        }

        public bool isdrawn
        {
            get { return isDrawn; }
            set { isDrawn = value; }
        }


    }
}
