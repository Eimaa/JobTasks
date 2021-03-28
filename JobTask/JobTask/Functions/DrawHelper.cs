using JobTask.Constants;
using System;
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

            StaticVariables.win.path.Data = geometry;

            //**************************************************************
            //Works until here, below just effort to do something. All in all, I create initial shape geometry in which u could render geometries.

            //int length = int.Parse(StaticVariables.win.lengthTextBox.Text);
            //int width = int.Parse(StaticVariables.win.widthTextBox.Text);
            //int rowSpacing = int.Parse(StaticVariables.win.rowSpacingTextBox.Text);
            //int columnSpacing = int.Parse(StaticVariables.win.columnSpacingTextBox.Text);



            //var totalShapeArea = geometry.GetArea();
            //double adjustedWidth = length + columnSpacing;
            //double adjustedHeight = width + rowSpacing;
            //double solarPanelArea = (length + columnSpacing) * (width + rowSpacing);
            //var possiblePanelsNumber = Math.Round(totalShapeArea / solarPanelArea);


            //GeometryGroup myGeometryGroup = new GeometryGroup();
            //myGeometryGroup.Children.Add(geometry);



            //RectangleGeometry myRectGeometry = new RectangleGeometry();
            //myRectGeometry.Rect = new Rect(new Size(adjustedWidth, adjustedHeight));
            //myGeometryGroup.Children.Add(myRectGeometry);


            //StaticVariables.win.path.Data = myGeometryGroup;
            //StaticVariables.win.path.Stroke = Brushes.Blue;
        }


        public static bool CheckIfChildIsInsideParent(Geometry parentShape, Geometry childShape)
        {
            return (parentShape.FillContainsWithDetail(childShape) == IntersectionDetail.FullyContains);
        }
    }
}
