using System.Windows;
using System.Windows.Media;

namespace JobTask.Constants
{
    public static class StaticVariables
    {
        public static PointCollection Coordinates_Site = new PointCollection();
        public static PointCollection Coordinates_RestrictionZone = new PointCollection();
        public static MainWindow win = null;


        public static void LoadCoordinatesData()
        { 
            Coordinates_Site.Add(new Point(83, 136));
            Coordinates_Site.Add(new Point(124, 186));
            Coordinates_Site.Add(new Point(252, 155));
            Coordinates_Site.Add(new Point(277, 47));
            Coordinates_Site.Add(new Point(183, 82));
            Coordinates_Site.Add(new Point(163, 4));
            Coordinates_Site.Add(new Point(80, 25));
            Coordinates_Site.Add(new Point(83, 136));

            Coordinates_RestrictionZone.Add(new Point(173, 123));
            Coordinates_RestrictionZone.Add(new Point(182, 143));
            Coordinates_RestrictionZone.Add(new Point(145, 147));
            Coordinates_RestrictionZone.Add(new Point(134, 121));
        }
    }
}
