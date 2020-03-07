namespace Kiosk.Classes
{
    public class DetailWay : IWay
    {
        public int Id { get; set; }
        public int Kid { get; set; }
        public int Tid { get; set; }

        /// <summary>
        /// it is a TargetPoint identify key
        /// </summary>
        public int TargetPointId { get; set; }

        /// <summary>
        /// Description to way
        /// </summary>
        public string Description { get; set; }
    }
}
