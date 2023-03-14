using System;
using GameEngineProject.Game_Engine;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Reflection.Emit;

namespace GameEngineProject
{
    class Demo : Game_Engine.GameEngine
    {
        Shape2D player;
        Shape2D rain;
        Sprite2D logo;

        string[,] Map =
        {
            {".", ".", ".", ".", ".", "."},
            {".", ".", ".", ".", "g", "."},
            {".", ".", "g", ".", "g", "."},
            {"g", "g", "g", "g", "g", "g"},
            {"g", ".", ".", ".", ".", "g"}
        };

        public Demo() : base(new Vector2(612, 515), "Game Engine Demo")
        {

        }

        public override void Splash()
        {
            BackgroundColour = Color.White;
            logo = new Sprite2D(new Vector2(250, 200), new Vector2(500, 500), "Logo/Moduro", "Engine Logo");
            Thread.Sleep(2000);
            logo.DestroySelf();
        }

        public override void OnLoad()
        {
            rain = new Shape2D(new Vector2(0, 0), new Vector2(5, 10), "Rain", "Oval");

            for (int i = 0; i < Map.GetLength(1); i++)
            {
                for (int j = 0; j < Map.GetLength(0); j++)
                {
                    if (Map[j, i] == "g")
                    {
                        new Shape2D(new Vector2(i * 100, j * 100), new Vector2(100, 100), "Ground", "Square");
                    }
                }
            }

            player = new Shape2D(new Vector2(10, 250), new Vector2(50,50), "Player", "Circle");
        }

        public override void OnUpdate()
        {
            FrameRateCounter.FrameRate();

            PlayerController.playerMovement(player);
            PlayerController.PlayerCollision(player, "Ground");

            rain.Position.Y += 0.5f;
            if (rain.IsColliding("Ground"))
            {
                rain.DestroySelf();
            }
        }

        public override void OnDraw()
        {
            
        }

    }
}
