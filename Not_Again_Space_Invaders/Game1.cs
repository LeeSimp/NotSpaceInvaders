using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Not_Again_Space_Invaders
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Player player1;
        Bullet bulletsprite;
        EnemyShips enemysprite;
        private Enemy[,] shipArray = new Enemy[7, 3];
        private bool Collided;


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            Texture2D mytexture = Content.Load<Texture2D>("Brick");
            // TODO: use this.Content to load your game content here
            player1 = new Player(new Rectangle((GraphicsDeviceManager.DefaultBackBufferWidth / 2) - mytexture.Width / 2,
                                GraphicsDeviceManager.DefaultBackBufferHeight - mytexture.Height, mytexture.Width, mytexture.Height),
                                mytexture, Color.White);
            bulletsprite = new Bullet(new Rectangle(player1.Position.X, player1.Position.Y, 10, 10), mytexture, Color.Red);
            enemysprite = new EnemyShips(new Rectangle(0, 0, mytexture.Width, mytexture.Height), mytexture, Color.White, shipArray, bulletsprite);
            bulletsprite.InitialPosition(player1);
            for (int i = 0; i <= shipArray.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= shipArray.GetUpperBound(1); j++)
                {
                    enemysprite.InitialiseEnemyShips();
                }
            }
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            player1.movement();
            bulletsprite.FireBullet(player1);
            enemysprite.movement(_graphics);
                      

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            _spriteBatch.Begin();
            foreach(Enemy e in shipArray)
            {
                Collided = e.checkCollided(bulletsprite);
                if(Collided)
            }

            player1.DrawSprite(_spriteBatch);
            bulletsprite.DrawSprite(_spriteBatch);
                foreach(Enemy e in shipArray)
                {
                    if (Collided == false)
                    {
                        e.DrawSprite(_spriteBatch);
                    }
                }
            _spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
