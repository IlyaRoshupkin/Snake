using System;

namespace Snake
{
    internal class FoodCreator
    {
        private int _mapWidth;
        private int _mapHeigth;
        private char _sym;

        Random rnd = new Random();

        public FoodCreator(int mapWidth, int mapHeigth, char sym)
        {
            _mapWidth = mapWidth;
            _mapHeigth = mapHeigth;
            _sym = sym;
        }

        internal Point CreateFood()
        {
            int x = rnd.Next(3, _mapWidth - 3);
            int y = rnd.Next(3, _mapHeigth - 3);
            return new Point(x, y, _sym);
        }
    }
}