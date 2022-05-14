namespace Lab5
{
    public class Line3D : Line
    {
        public Line3D(int[] coordinatesA, int[] coordinatesB) 
            : base(coordinatesA, coordinatesB) { }

        public override bool IsParallel(Line line)
        {
            return VectorCoordinates()[0] / line.VectorCoordinates()[0] == 
                   VectorCoordinates()[1] / line.VectorCoordinates()[1] && 
                   VectorCoordinates()[0] / line.VectorCoordinates()[0] == 
                   VectorCoordinates()[2] / line.VectorCoordinates()[2];
        }
        
        public override bool IsPerpendicular(Line line)
        {
            return VectorCoordinates()[0] * line.VectorCoordinates()[0] +
                   VectorCoordinates()[1] * line.VectorCoordinates()[1] +
                   VectorCoordinates()[2] * line.VectorCoordinates()[2]== 0;
        }
 
        public override bool PointBelongs(int[] coordinatesP)
        {
            return IsParallel(new Line3D(coordinatesA, coordinatesP));
        }
    }
}