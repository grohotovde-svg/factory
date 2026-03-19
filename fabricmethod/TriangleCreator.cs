using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace fabricmethod
{
    public abstract  class TriangleCreator
    {
        public abstract Triangle CreateTringle () ;
    }

    public class RedTringleCreator : TriangleCreator
    {
        public override Triangle CreateTringle() => new Triangle { Color = Colors.Red };
    }
    public class BlueTringleCreator : TriangleCreator
    {
        public override Triangle CreateTringle() => new Triangle { Color = Colors.Blue };
    }

    public class GreenTriangleCreator : TriangleCreator 
    {
        public override Triangle CreateTringle() => new Triangle { Color = Colors.Green };
    }
}
