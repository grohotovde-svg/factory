using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Controls;

namespace fabricmethod
{
    public abstract class CircleCreator
    {
        public abstract Circle CreateCircle();
    }
    public class RedCircleCreator : CircleCreator
    {
        public override Circle CreateCircle() => new Circle{Color = Colors.Red};
    }

}
