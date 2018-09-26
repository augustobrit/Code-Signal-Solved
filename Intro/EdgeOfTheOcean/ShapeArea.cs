public static class ShapeArea
{
    public static int GetShapeArea(int n) 
    {
        var area = 1;
        var diff = 0;
        
        for (var i = 0; i < n; i++)
        {
            area = area + diff;
            diff = diff + 4;
        }
        
        return area;
    }
}