using System.Collections.Generic;

namespace Kiosk.Classes
{
    /// <summary>
    /// This class is sign of general description
    /// </summary>
    public class Navigation : IWay
    {
        public int Id { get; set; }

        public int Kid { get; set; }

        public int Tid { get; set; }

        public string Description { get; set; }

        public List<DetailWay> DetailWays { get; set; }
    }
}
