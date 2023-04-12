namespace JustWcfServiceCalc
{
    internal static class Cache
    {
        public static FigureContract cachedFigure = new FigureContract();
    }

    public class FigureService : IFigureService
    {

        public FigureContract Load()
        {
            return Cache.cachedFigure;
        }

        public void Save(FigureContract figure)
        {
            Cache.cachedFigure = new FigureContract
            {
                OffsetTop = figure.OffsetTop,
                OffsetLeft = figure.OffsetLeft,
                Width = figure.Width,
                Height = figure.Height,
                Color = figure.Color,
            };
        }
    }
}
