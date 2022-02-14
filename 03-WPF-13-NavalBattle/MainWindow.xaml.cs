using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _03_WPF_13_NavalBattle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _mapSize = 5;
        private int _shipCount = 15;

        private Player _player;
        private Player _computer;

        public MainWindow()
        {
            InitializeComponent();
            //vytvořit oba hráče
            _player = new Player(_mapSize, _shipCount);
            _computer = new Player(_mapSize, _shipCount);

            //testovací střílení na hlavní diagonálu
            //for (int i = 0; i < _mapSize; i++)
            //{
            //    _player.HandleShot(new Coordinates() { X = i, Y = i });
            //}

            //vykreslit jejich moře
            InitializeDisplay(PlayerSeaDisplay, _player.RealSea);
            InitializeDisplay(ComputerSeaDisplay, _computer.VisibleSea, true);


            //když hraje hráč, čekat na kliknutí
            //když hraje PC, vybrat cíl náhodně

            //vyřešit a vykreslit výsledek střely

            //když cíl nemá žádné lodě, skončit
        }

        private void InitializeDisplay(Grid display, TileState[,] sea, bool isClickable = false)
        {
            for (int i = 0; i < _mapSize; i++)
            {
                RowDefinition rowDefinition = new RowDefinition();
                display.RowDefinitions.Add(rowDefinition);
            }
            for (int i = 0; i < _mapSize; i++)
            {
                ColumnDefinition columnDefinition = new ColumnDefinition();
                display.ColumnDefinitions.Add(columnDefinition);
            }
            for (int x = 0; x < _mapSize; x++)
            {
                for (int y = 0; y < _mapSize; y++)
                {
                    Rectangle tile = new Rectangle();

                    if (isClickable)
                    { 
                        tile.MouseDown += Tile_MouseDown;
                        tile.Cursor = Cursors.Hand; //nic moc, vzhled a kód smíchány
                    }

                    RenderTile(tile, sea[x, y]);

                    display.Children.Add(tile);

                    Grid.SetColumn(tile, x);
                    Grid.SetRow(tile, y);
                }
            }

        }

        private void Tile_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Rectangle clicked = (Rectangle)sender;

            //zjistit souřadnice dlaždice
            Coordinates target = FindCoordinates(clicked);
            //poslat na ně výstřel počítači
            _computer.HandleShot(target);
            //vykreslit výsledek
            RenderTile(clicked, _computer.VisibleSea[target.X, target.Y]);
            RenderScore(ComputerShips, _computer.Wrecks);

            if (!_computer.IsAlive)
            {
                MessageBox.Show("Victory", "You Win!");
                Close();
            }
        }

        private Coordinates FindCoordinates(Rectangle tile)
        {
            int row = Grid.GetRow(tile);
            int column = Grid.GetColumn(tile);
            return new Coordinates() {X = column, Y = row };
        }

        private void RenderTile(Rectangle tile, TileState state)
        {
            switch (state)
            {
                case TileState.Sea:
                    tile.Style = FindResource("Sea") as Style;
                    break;
                case TileState.Ship:
                    tile.Style = FindResource("Ship") as Style;
                    break;
                case TileState.Shot:
                    tile.Style = FindResource("Shot") as Style;
                    break;
                case TileState.Wreck:
                    tile.Style = FindResource("Wreck") as Style;
                    break;
                default:
                    break;
            }
        }
        private void RenderScore(Label display, int wreckCount)
        {
            display.Content = $"{wreckCount}/{_shipCount}";
        }
    }
}
