using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameEngineProject.Game_Engine
{
    public class Sprite2D
    {
        public Vector2 Position = null;
        public Vector2 Scale = null;
        public string Directory = "";
        public string Tag = "";
        public Image Sprite = null;

        public Sprite2D(Vector2 Position, Vector2 Scale,string Directory, string Tag)
        {
            this.Position = Position;
            this.Scale = Scale;
            this.Directory = Directory;
            this.Tag = Tag;

            Image tmp = Image.FromFile($"Assets/Sprites/{Directory}.png") as Bitmap;
            Bitmap sprite = new Bitmap(tmp);
            Sprite = sprite;

            Log.InfoMessage($"[SPRITE2D] {Tag} has been Registered...");
            GameEngine.RegisterSprite(this);
        }

        public void DestroySelf()
        {
            Log.InfoMessage($"[SPRITE2D] {Tag} has been Destroyed...");
            GameEngine.UnRegisterSprite(this);
        }

    }
}
