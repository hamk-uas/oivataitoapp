using ChartJs.Blazor.Common;
using ChartJs.Blazor.Common.Axes;

namespace OivaTaitoApp.ChartJSClasses
{
    public class StackedLinearCartesianAxes : LinearCartesianAxis
    {
        public StackedLinearCartesianAxes()
        {
        }
        public bool Stacked { get; set; }
    }
}
