namespace Kiosk.Classes
{
    /// <summary>
    /// This class is for shopping places
    /// </summary>
    public class Target : IPoint
    {
        public int Id { get; set; }
        public string X { get; set; }
        public string Y { get; set; }

        /// <summary>
        /// It describes what shop place name's
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// It declare which floor is
        /// </summary>
        public int FloorNbr { get; set; }


    }
}
