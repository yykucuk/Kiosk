namespace Kiosk
{
    interface IWay
    {
        /// <summary>
        /// The key to identify
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Kiosk id
        /// </summary>
        int Kid { get; set; }

        /// <summary>
        /// Target id
        /// </summary>
        int Tid { get; set; }
    }
}
