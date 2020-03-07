namespace Kiosk.Classes
{

    /// <summary>
    /// This class is for Kiosks
    /// </summary>
    public class Kiosk : IPoint
    {
        public int Id { get; set; }
        public string X { get; set; }
        public string Y { get; set; }
        public int FloorNbr { get; set; }
    }
}
