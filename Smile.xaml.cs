using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Smile
{
    public partial class Smile : Window
    {
        SolidColorBrush white = new SolidColorBrush(Colors.White); // 0
        SolidColorBrush brown = new SolidColorBrush(Colors.SaddleBrown); // 1
        SolidColorBrush yellow = new SolidColorBrush(Colors.Yellow); // 2
        
        uint[,] GridMatrix = {
            { 0,0,0,0,0,1,1,1,1,1,0,0,0,0,0 },
            { 0,0,0,1,1,2,2,2,2,2,1,1,0,0,0 },
            { 0,0,1,2,2,2,2,2,2,2,2,2,1,0,0 },
            { 0,1,2,2,2,2,2,2,2,2,2,2,2,1,0 },
            { 0,1,2,2,2,2,2,2,2,2,2,2,2,1,0 },
            { 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 },
            { 1,2,1,1,0,0,1,1,1,1,0,0,1,2,1 },
            { 1,2,1,1,1,0,1,2,1,1,1,0,1,2,1 },
            { 1,2,2,1,1,1,2,2,2,1,1,1,2,2,1 },
            { 1,2,2,2,2,2,2,2,2,2,2,2,2,2,1 },
            { 0,1,2,2,1,2,2,2,2,2,2,2,2,1,0 },
            { 0,1,2,2,2,1,1,1,1,2,2,2,2,1,0 },
            { 0,0,1,2,2,2,2,2,2,2,2,2,1,0,0 },
            { 0,0,0,1,1,2,2,2,2,2,1,1,0,0,0 },
            { 0,0,0,0,0,1,1,1,1,1,0,0,0,0,0 },
        };
        public Smile()
        {
            InitializeComponent();
            FillMatrix();
        }   
        void FillMatrix()
        {
            for (uint i = 0; i < 15; i++)
            {
                gridView.ColumnDefinitions.Add(new ColumnDefinition());
                gridView.RowDefinitions.Add(new RowDefinition());
            }

            for (uint i = 0; i < 15; i++)
            {
                for (uint j = 0; j < 15; j++)
                {
                    System.Windows.Shapes.Rectangle r = new System.Windows.Shapes.Rectangle();
                    if (GridMatrix[j, i] == 0)
                    {
                        r.Fill = white;
                    }
                    else if (GridMatrix[j, i] == 1)
                    {
                        r.Fill = brown;
                    }
                    else if (GridMatrix[j, i] == 2)
                    {
                        r.Fill = yellow;
                    }
                    gridView.Children.Add(r);
                    Grid.SetColumn(r, (int)i);
                    Grid.SetRow(r, (int)j);
                }
            }

        }
    }
}
