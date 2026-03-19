using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace fabricmethod
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private CircleCreator _circleCreator;
        private SquareCreator _squareCreator;
        private TriangleCreator _triangleCreator;
        private RedFactory _redFactory;

        private void ColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            DrawingPanel.Children.Clear();

            var selectedItem = (ComboBoxItem)ColorComboBox.SelectedItem;
            string color = selectedItem.Content.ToString();

            switch (color)
            {
                case "Красный":
                    _circleCreator = new RedCircleCreator();
                    _squareCreator = new RedSquareCreator();
                    _triangleCreator = new RedTriangleCreator();
                    break;
                case "Синий":
                    _circleCreator = new BlueCircleCreator();
                    _squareCreator = new BlueSquareCreator();
                    _triangleCreator = new BlueTriangleCreator();
                    break;
                case "Зелёный":
                    _circleCreator = new GreenCircleCreator();
                    _squareCreator = new GreenSquareCreator();
                    _triangleCreator = new GreenTriangleCreator();
                    break;
                case "Красная фабрика":
                    _redFactory = new RedFactory();
                    _redFactory.CreateTriangle();
                    break;
            }
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void AddFigures_Click(object sender, RoutedEventArgs e)
        {
            if (_circleCreator == null) return;

            
            var circle = _circleCreator.CreateCircle();
            var square = _squareCreator.CreateSquare();
            var triangle = _triangleCreator.CreateTriangle();
            

            
            DrawingPanel.Children.Add(circle.CreateUIElement());
            DrawingPanel.Children.Add(square.CreateUIElement());
            DrawingPanel.Children.Add(triangle.CreateUIElement());

        }
    }
}
