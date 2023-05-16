using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auditorium
{
    class make_shape_set
    {
        public make_shape_set(int size)
        {
            return_shape = new int[size, size];
            check_return_shape = new int[size, size];
            check_small = new int[size, size];
            first = 0;
            second = 0;
            third = 0;
            number = 1;
            init(size);
            fill_check(size);
            if (number > 1)
            {
                small_checking(size, number);
                fst_sum(size);
            }

        }

        private void init(int size)
        {
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    check_return_shape[i, j] = 0;
                    check_small[i, j] = 1000;
                    if (i == size / 2 && j == size / 2)
                    {
                        return_shape[i, j] = 4;
                    }
                    else
                    {
                        if (rand.Next(10) % 2 == 0)
                        {
                            return_shape[i, j] = 0;
                        }
                        else
                        {
                            int use = rand.Next(9);
                            if (use % 3 == 0)
                            {
                                return_shape[i, j] = 1;
                                first++;
                            }
                            else if (use % 3 == 1)
                            {
                                return_shape[i, j] = 2;
                                second++;
                            }
                            else
                            {
                                return_shape[i, j] = 3;
                                third++;
                            }
                        }
                    }
                }
            }
        }

        private void fill_check(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (check_return_shape[i, j] == 0 && return_shape[i, j] != 0)
                    {
                        filling(i, j, size);
                        number++;
                    }
                }
            }
        }

        private void filling(int i, int j, int size)
        {
            if (0 <= i && i < size && 0 <= j && j < size)
            {
                if (return_shape[i, j] != 0)
                {
                    if (check_return_shape[i, j] == 0)
                    {
                        check_return_shape[i, j] = number;
                        filling(i + 1, j, size);
                        filling(i - 1, j, size);
                        filling(i, j + 1, size);
                        filling(i, j - 1, size);
                    }
                }
            }
            else
            {
                return;
            }
        }

        private void small_checking(int size, int number)
        {
            for (int c = 1; c < number; c++)
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (check_return_shape[i, j] == c)
                        {
                            other_small_checking(i, j, size, c);
                        }
                    }
                }
            }
        }

        private void other_small_checking(int c_i, int c_j, int size, int num)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (check_return_shape[i, j] != num && check_return_shape[i, j] != 0)
                    {
                        int small_dis = small_distance(c_i, c_j, i, j);
                        if (check_small[c_i, c_j] > small_dis)
                            check_small[c_i, c_j] = small_dis;
                    }
                }
            }
        }

        private int small_distance(int my_i, int my_j, int other_i, int other_j)
        {
            return Math.Abs(other_i - my_i) + Math.Abs(other_j - my_j) - 1;
        }

        private void fst_sum(int size)
        {
            small_list = new int[number];
            for (int i = 1; i < number; i++)
            {
                small_list[i] = 1000;
            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (check_return_shape[i, j] != 0)
                    {
                        if (small_list[check_return_shape[i, j]] > check_small[i, j])
                        {
                            small_list[check_return_shape[i, j]] = check_small[i, j];
                        }
                    }
                }
            }
            int total = 0;
            for (int i = 1; i < number; i++)
            {
                total += small_list[i];
            }
            Random rand = new Random();
            int save_rand = 0;
            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    save_rand = rand.Next(total);
                    first += save_rand;
                    total -= save_rand;
                }
                else if (i == 1)
                {
                    save_rand = rand.Next(total);
                    second += save_rand;
                    total -= save_rand;
                }
                else
                {
                    second += total;
                }
            }

        }

        public int return_first()
        {
            return first;
        }

        public int return_second()
        {
            return second;
        }

        public int return_third()
        {
            return third;
        }

        public int[,] re_return_shape()
        {
            return return_shape;
        }

        private int[] small_list;
        private int[,] return_shape;
        private int[,] check_return_shape;
        private int[,] check_small;
        private int first;
        private int second;
        private int third;
        private int number;
    }
}
