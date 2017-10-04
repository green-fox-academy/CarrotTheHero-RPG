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
using GreenFox;
using System.IO;

namespace RpgGame
{
    public partial class MainWindow : Window
    {
        public Random rnd = new Random();
        FoxDraw foxDraw;
        Hero hero;
        Character character;
        Map map;

        public MainWindow()
        {
            InitializeComponent();
            foxDraw = new FoxDraw(canvas);
            map = new Map(foxDraw);
            hero = new Hero(foxDraw);
            character = new Character();
        }

        private void WindowKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                foxDraw.ClearCanvas();
                map.MapDraw(foxDraw);
                hero.MoveLeft(foxDraw);
            }

            if (e.Key == Key.Right)
            {
                foxDraw.ClearCanvas();
                map.MapDraw(foxDraw);
                hero.MoveRight(foxDraw);
            }

            if (e.Key == Key.Up)
            {
                foxDraw.ClearCanvas();
                map.MapDraw(foxDraw);
                hero.MoveUp(foxDraw);
            }

            if (e.Key == Key.Down)
            {
                foxDraw.ClearCanvas();
                map.MapDraw(foxDraw);
                hero.MoveDown(foxDraw);
            }
        }
    }
}