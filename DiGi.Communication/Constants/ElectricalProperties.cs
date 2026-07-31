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

        /// <summary>
        /// Gets predefined electrical properties representing brick.
        /// </summary>
        public static readonly Classes.ElectricalProperties Brick = new("Brick", 3.75, 0, 0.038, 0, new Core.Classes.Range<double>(1, 10));

        /// <summary>
        /// Gets predefined electrical properties representing plasterboard.
        /// </summary>
        public static readonly Classes.ElectricalProperties Plasterboard = new("Plasterboard", 2.94, 0, 0.0116, 0.7076, new Core.Classes.Range<double>(1, 100));

        /// <summary>
        /// Gets predefined electrical properties representing wood.
        /// </summary>
        public static readonly Classes.ElectricalProperties Wood = new("Wood", 1.99, 0, 0.0047, 1.0718, new Core.Classes.Range<double>(0.001, 100));

        /// <summary>
        /// Gets predefined electrical properties representing glass.
        /// </summary>
        public static readonly Classes.ElectricalProperties Glass = new("Glass", 6.27, 0, 0.0043, 1.1925, new Core.Classes.Range<double>(0.1, 100));

        /// <summary>
        /// Gets predefined electrical properties representing ceiling board.
        /// </summary>
        public static readonly Classes.ElectricalProperties CeilingBoard = new("Ceiling board", 1.50, 0, 0.0005, 1.1634, new Core.Classes.Range<double>(1, 100));

        /// <summary>
        /// Gets predefined electrical properties representing chipboard.
        /// </summary>
        public static readonly Classes.ElectricalProperties Chipboard = new("Chipboard", 2.58, 0, 0.0217, 0.78, new Core.Classes.Range<double>(1, 100));

        /// <summary>
        /// Gets predefined electrical properties representing floorboard.
        /// </summary>
        public static readonly Classes.ElectricalProperties Floorboard = new("Floorboard", 3.66, 0, 0.0044, 1.3515, new Core.Classes.Range<double>(50, 100));

        /// <summary>
        /// Gets predefined electrical properties representing metal.
        /// </summary>
        public static readonly Classes.ElectricalProperties Metal = new("Metal", 1, 0, 107, 0, new Core.Classes.Range<double>(1, 100));

        /// <summary>
        /// Gets predefined electrical properties representing very dry ground.
        /// </summary>
        public static readonly Classes.ElectricalProperties VeryDryGround = new("Very dry ground", 3, 0, 0.00015, 2.52, new Core.Classes.Range<double>(1, 10));

        /// <summary>
        /// Gets predefined electrical properties representing medium dry ground.
        /// </summary>
        public static readonly Classes.ElectricalProperties MediumDryGround = new("Medium dry ground", 15, -0.1, 0.035, 1.63, new Core.Classes.Range<double>(1, 10));

        /// <summary>
        /// Gets predefined electrical properties representing wet ground.
        /// </summary>
        public static readonly Classes.ElectricalProperties WetGround = new("Wet ground", 30, -0.4, 0.15, 1.3, new Core.Classes.Range<double>(1, 10));
    }
}