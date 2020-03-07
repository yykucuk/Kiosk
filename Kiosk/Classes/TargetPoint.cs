namespace Kiosk.Classes
{
    /// <summary>
    /// This class is to destination points of Targets which are shopping places.
    /// </summary>
    public class TargetPoint : IPoint
    {
        public int Id { get; set; }
        public string X { get; set; }
        public string Y { get; set; }

        /// <summary>
        /// It identifies Target entity
        /// </summary>
        public int TId { get; set; }
        public int FloorNbr { get; set; }
    }
}
