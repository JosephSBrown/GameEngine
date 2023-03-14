using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GameEngineProject.Game_Engine
{
    public class FrameRateCounter
    {
        private static int lastTick;
        private static int lastFrameRate;
        private static int frameRate;
        public static int CalculateFrameRate()
        {

            if (System.Environment.TickCount - lastTick >= 1000)
            {
                lastFrameRate = frameRate;
                frameRate = 0;
                lastTick = System.Environment.TickCount;
            }
            frameRate++;
            return lastFrameRate;
        }

        public static void FrameRate()
        {
            string frames = CalculateFrameRate().ToString();
            if (lastFrameRate == Convert.ToInt32(frames))
            {
                Console.WriteLine($"Framerate: {frames}");
            }
            else
            {
                return;
            }
        }
    }
}
