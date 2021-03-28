using JobTask.Constants;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace JobTask.Functions
{
    public static class DrawHelper
    {
        public static void DrawSiteZone()
        {
            Polygon site = new Polygon
            {
                Points = StaticVariables.Coordinates_Site,
                Stroke = Brushes.DarkOrange,
                StrokeThickness = 2
            };

            site.Arrange(new Rect(StaticVariables.win.uniformGrid.RenderSize));
            site.Measure(StaticVariables.win.uniformGrid.RenderSize);
              

            Polygon restrictionZone = new Polygon
            {
                Points = StaticVariables.Coordinates_RestrictionZone,
                Stroke = Brushes.Red,
                StrokeThickness = 2
            };

            restrictionZone.Arrange(new Rect(StaticVariables.win.uniformGrid.RenderSize));
            restrictionZone.Measure(StaticVariables.win.uniformGrid.RenderSize);


            CombinedGeometry geometry = new CombinedGeometry() { GeometryCombineMode = GeometryCombineMode.Exclude };
            geometry.Geometry1 = site.RenderedGeometry;
            geometry.Geometry2 = restrictionZone.RenderedGeometry;

            int rowSpacing = int.Parse(StaticVariables.win.rowSpacingTextBox.Text);
            int columnSpacing = int.Parse(StaticVariables.win.columnSpacingTextBox.Text);

            StaticVariables.win.path.Data = geometry;

            Rectangle rectangle = new Rectangle
            {
                Height = int.Parse(StaticVariables.win.lengthTextBox.Text),
                Width = int.Parse(StaticVariables.win.widthTextBox.Text),
                Margin = new Thickness(0,0,columnSpacing,rowSpacing),
                Stroke = Brushes.Red,
                StrokeThickness = 2
            };

            var bottomQuarter = new RectangleGeometry(
            new Rect(new Size(int.Parse(StaticVariables.win.lengthTextBox.Text), int.Parse(StaticVariables.win.widthTextBox.Text))));
            rectangle.Arrange(new Rect(StaticVariables.win.uniformGrid.RenderSize));
            rectangle.Measure(StaticVariables.win.uniformGrid.RenderSize);

            var combinedGeometry = new CombinedGeometry(GeometryCombineMode.Exclude,
                                           geometry, bottomQuarter);


            StaticVariables.win.path.Data = combinedGeometry;
            StaticVariables.win.path.Stroke = Brushes.Blue;
        }
    }
}
