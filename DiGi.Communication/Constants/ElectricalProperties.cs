namespace DiGi.Communication.Constants
{
    /// <summary>
    /// Provides predefined standard material electrical properties.
    /// </summary>
    public static class ElectricalProperties
    {
        /// <summary>
        /// Gets predefined electrical properties representing a vacuum.
        /// </summary>
        public static readonly Classes.ElectricalProperties Vacuum = new("Vacuum", 1, 0, 0, 0, new Core.Classes.Range<double>(0.001, 100));

        /// <summary>
        /// Gets predefined electrical properties representing concrete.
        /// </summary>
        public static readonly Classes.ElectricalProperties Concrete = new("Concrete", 5.31, 0, 0.0326, 0.8095, new Core.Classes.Range<double>(1, 100));
    }
}