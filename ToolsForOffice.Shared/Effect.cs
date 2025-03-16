using System.Drawing;

namespace ToolsForOffice.Shared
{
    public struct Effect
    {
        public Effect(float x, float y, float speed, float size, float time, Bitmap img)
        {
            X = x;
            Y = y;
            Speed = speed;
            Size = size;
            Time = time;
            Img = img;
        }

        public float X { get; set; }
        public float Y { get; set; }
        public float Speed { get; set; }
        public float Size { get; set; }
        public float Time { get; set; }
        public Bitmap Img { get; set; }
    }
}