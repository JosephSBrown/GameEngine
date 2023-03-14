using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngineProject.Game_Engine
{
    public class Shape2D
    {
        public Vector2 Position = null;
        public Vector2 Scale = null;

        public string Tag = "";
        public string Shape = "";

        public Shape2D(Vector2 Position, Vector2 Scale, string Tag, string Shape)
        {
            this.Position = Position;
            this.Scale = Scale;
            this.Tag = Tag;
            this.Shape = Shape;

            Log.InfoMessage($"[SHAPE2D] {Tag} has been Registerd...");
            GameEngine.RegisterShape(this);
        }

        public void DestroySelf()
        {
            Log.InfoMessage($"[SHAPE2D] {Tag} has been Destroyed...");
            GameEngine.UnRegisterShape(this);
        }

        public bool IsColliding(string tag)
        {
            foreach (Shape2D b in GameEngine.AllShapes)
            {
                if (b.Tag == tag)
                { 
                    if (Position.X < b.Position.X + b.Scale.X &&
                    Position.X + Scale.X > b.Position.X &&
                    Position.Y < b.Position.Y + b.Scale.Y &&
                    Position.Y + Scale.Y > b.Position.Y)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
