namespace Kiosk
{
    interface IPoint
    {
        /// <summary>
        /// Key to identify
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// X coordination
        /// </summary>
        string X { get; set; }

        /// <summary>
        /// Y coordination
        /// </summary>
        string Y { get; set; }

        int FloorNbr { get; set; }
    }
}
