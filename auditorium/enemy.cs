using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auditorium
{
    class enemy
    {
        public enemy(int x, int y)
        {
            enemy_x = x;
            enemy_y = y;
        }

        public void change_enemy_xy(int x, int y)
        {
            enemy_x = x;
            enemy_y = y;
        }

        public void change_direction_xy(int x, int y)
        {
            enemy_direction_x = x;
            enemy_direction_y = y;
        }

        public void direction_change(int east, int west, int south, int north)
        {
            List<char> check = new List<char>();
            if (east == 1)
                check.Add('e');
            if (west == 1)
                check.Add('w');
            if (south == 1)
                check.Add('s');
            if (north == 1)
                check.Add('n');

            if (check.Count != 0)
            {
                Random rand = new Random();
                int rand_dir = rand.Next(check.Count);
                if (check[rand_dir] == 'e')
                {
                    enemy_direction_x = 1;
                    enemy_direction_y = 0;
                }
                else if (check[rand_dir] == 'w')
                {
                    enemy_direction_x = -1;
                    enemy_direction_y = 0;
                }
                else if (check[rand_dir] == 's')
                {
                    enemy_direction_x = 0;
                    enemy_direction_y = 1;
                }
                else
                {
                    enemy_direction_x = 0;
                    enemy_direction_y = -1;
                }
            }
        }

        public int return_enemy_x()
        {
            return enemy_x;
        }

        public int return_enemy_y()
        {
            return enemy_y;
        }

        public int return_direction_x()
        {
            return enemy_direction_x;
        }

        public int return_direction_y()
        {
            return enemy_direction_y;
        }

        private int enemy_x;
        private int enemy_y;
        private int enemy_direction_x;
        private int enemy_direction_y;
    }
}
