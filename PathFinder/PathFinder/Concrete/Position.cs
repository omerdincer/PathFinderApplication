using PathFinder.Abstract;

namespace PathFinder
{
    /// <summary>
    /// It store size of the plateau and rover positions
    /// </summary>
    public class Position : IPosition
    {
        public int x { get; set; }
        public int y { get; set; }

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}