using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GreenFox;

namespace RpgGame
{
    class Hero : Character
    {
        int position = 0;


        public static Random rmd = new Random();

        public Hero(FoxDraw foxDraw)
        {
            int d6 = rmd.Next(1, 7);            
            maxHP = 20 + 3 * d6;
            currentHP = maxHP;
            DP = 2 * d6;
            SP = 5 + d6;
            level = 1;
            DrawHero(foxDraw);
        }

        public void DrawHero(FoxDraw foxDraw)
        {
            foxDraw.AddImage("./Assets/hero-down.png", Map.CoordinateCollection[0]);
        }
        public void MoveLeft(FoxDraw foxDraw)
        {
            if (Map.floorSurfaceList.Contains(position -1) && position % 10 != 0)
            {
                foxDraw.AddImage("./Assets/hero-left.png", Map.CoordinateCollection[position -= 1]);
            }
            else
            {
                foxDraw.AddImage("./Assets/hero-left.png", Map.CoordinateCollection[position]);
            }
        }
        public void MoveRight(FoxDraw foxDraw)
        {
            if (Map.floorSurfaceList.Contains(position + 1) && position % 10 != 9)
            {
                foxDraw.AddImage("./Assets/hero-right.png", Map.CoordinateCollection[position += 1]);
            }
            else
            {
                foxDraw.AddImage("./Assets/hero-right.png", Map.CoordinateCollection[position]);
            }
        }
        public void MoveUp(FoxDraw foxDraw)
        {
            if (Map.floorSurfaceList.Contains(position - 10) &&  position > 9)
            {
                foxDraw.AddImage("./Assets/hero-up.png", Map.CoordinateCollection[position -= 10]);
            }
            else
            {
                foxDraw.AddImage("./Assets/hero-up.png", Map.CoordinateCollection[position]);
            }
        }
        public void MoveDown(FoxDraw foxDraw)
        {
            if (Map.floorSurfaceList.Contains(position + 10) && position < 90)
            {
                foxDraw.AddImage("./Assets/hero-down.png", Map.CoordinateCollection[position += 10]);
            }
            else
            {
                foxDraw.AddImage("./Assets/hero-down.png", Map.CoordinateCollection[position]);
            }
        }        
    }
}
