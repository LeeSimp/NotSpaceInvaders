using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Not_Again_Space_Invaders
{
    class EnemyShips : Sprite
    {
        private Enemy[,] enemyArray;
        Sprite otherSprite;
        private const int SPACE_BETWEEN_SHIPS = 10;
        private bool moveLeft;
        private bool moveRight;

        public EnemyShips(Rectangle inposition, Texture2D intexture, Color incolour, Enemy[,] inEnemyArray, Sprite inOtherSprite)
            : base(inposition, intexture, incolour)
        {
            enemyArray = inEnemyArray;
            otherSprite = inOtherSprite;
        }

        public void InitialiseEnemyShips()
        {
            for (int i = 0; i<= enemyArray.GetUpperBound(0); i++)
            {
                for(int j = 0; j <= enemyArray.GetUpperBound(1); j++)
                {
                    enemyArray[i, j] = new Enemy(new Rectangle((i * spritetexture.Width) + (i * SPACE_BETWEEN_SHIPS),
                                                (j * spritetexture.Height) + (j * SPACE_BETWEEN_SHIPS), spritetexture.Width,
                                                spritetexture.Height), spritetexture, Color.White, true, otherSprite);
                }
            }
        }
        public void movement(GraphicsDeviceManager inGraphics)
        {
            for (int i = 0; i < enemyArray.GetUpperBound(0); i++)
            {
                for (int j = 0; j < enemyArray.GetUpperBound(1); j++)
                {
                    if (enemyArray[enemyArray.GetUpperBound(0), j].Position.X + enemyArray[enemyArray.GetUpperBound(1), j].Texture.Width
                        >= inGraphics.PreferredBackBufferWidth)
                    {
                        moveLeft = true;
                        moveRight = false;
                    }
                    if (enemyArray[i, j].Position.X <= 0)
                    {
                        moveRight = true;
                        moveLeft = false;
                    }
                }
            }


            foreach (Enemy e in enemyArray)
            {
                if(moveRight)
                {
                    e.Position = new Rectangle(e.Position.X + 1, e.Position.Y, Texture.Width, Texture.Height);
                }
                if(moveLeft)
                {
                    e.Position = new Rectangle(e.Position.X - 1, e.Position.Y, Texture.Width, Texture.Height);
;                }
            }
        }
    }
}
