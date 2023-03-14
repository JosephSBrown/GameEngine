using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameEngineProject.Game_Engine
{
    public class PlayerController
    {
        private static bool left;
        private static bool right;
        private static bool up;
        private static bool down;
        private static bool jump;
        public static bool rotate;

        private static float playerSpeed = 0.5f;
        private static float playerJumpHeight = 5f;

        public static float gravity;

        private static Vector2 lastPosition = Vector2.Zero();

        public static void playerMovement(Shape2D player)
        { 
            if (up)
            {
                player.Position.Y -= playerSpeed;
            }
            if (down)
            {
                player.Position.Y += playerSpeed;
            }
            if (left)
            {
                player.Position.X -= playerSpeed;
            }
            if (right)
            {
                player.Position.X += playerSpeed;
            }
            if (jump)
            {
                player.Position.Y -= playerJumpHeight;
            }
            if (rotate)
            {
                return;
            }
        }

        public static void PlayerCollision(Shape2D player, string tag)
        {
            if (player.IsColliding(tag))
            {
                gravity = 0f;
                player.Position.X = lastPosition.X;
                player.Position.Y = lastPosition.Y;
            }
            else
            {
                gravity = 1f;
                lastPosition.X = player.Position.X;
                lastPosition.Y = player.Position.Y;
                player.Position.Y += gravity;
            }
        }

        public static void GetKeyDown(System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                up = true;
            }
            if (e.KeyCode == Keys.S)
            {
                down = true;
            }
            if (e.KeyCode == Keys.A)
            {
                left = true;
            }
            if (e.KeyCode == Keys.D)
            {
                right = true;
            }
            if (e.KeyCode == Keys.Space)
            {
                jump = true;
            }
        }

        public static void GetKeyUp(System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                up = false;
            }
            if (e.KeyCode == Keys.S)
            {
                down = false;
            }
            if (e.KeyCode == Keys.A)
            {
                left = false;
            }
            if (e.KeyCode == Keys.D)
            {
                right = false;
            }
            if (e.KeyCode == Keys.Space)
            {
                jump = false;
            }
        }

    }
}
