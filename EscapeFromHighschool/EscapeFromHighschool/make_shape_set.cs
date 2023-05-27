using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auditorium
{
    class make_shape_set
    {
        public make_shape_set(int size) // size를 받아 size x size의 배열 생성
        {
            return_shape = new int[size, size];
            check_return_shape = new int[size, size];
            check_small = new int[size, size];
            first = 0;
            second = 0;
            third = 0;
            number = 1;
            init(size); // 배열 생성
            fill_check(size); // 떨어져 있는 것들 표시
            if (number > 1) // 떨어진 것이 1개 이상이면 실행
            {
                small_checking(size, number); // 배열에서 가장 작은 곳이 어딘지 확인
                fst_sum(size); // 떨어진 것을 적절하게 더하기
            }

        }

        private void init(int size)
        {
            Random rand = new Random(); // 랜덤으로 배열을 생성
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    check_return_shape[i, j] = 0;
                    check_small[i, j] = 25;
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
                            int use = rand.Next(9); // 색상도 랜덤으로 지정
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

        private void fill_check(int size) // 떨어져 있는 것들을 번호로 표시
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (check_return_shape[i, j] == 0 && return_shape[i, j] != 0)
                    {
                        filling(i, j, size); // 같이 붙어 있는 모든 것을 같은 번호를 붙임
                        number++;
                    }
                }
            }
        }

        private void filling(int i, int j, int size) // 붙어 있는지 확인
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

        private void small_checking(int size, int number) // 배열에서 떨어져있는 조각의 최소 지점 계산
        {
            for (int c = 1; c < number; c++)
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (check_return_shape[i, j] == c)
                        {
                            other_small_checking(i, j, size, c); // 색이 있는 블록에서 다른 떨어져있는 지점까지의 최소거리 구하기
                        }
                    }
                }
            }
        }

        private void other_small_checking(int c_i, int c_j, int size, int num)  // 색이 있는 블록에서 다른 떨어져있는 지점까지의 최소거리 구하기
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (check_return_shape[i, j] != num && check_return_shape[i, j] != 0)
                    {
                        int small_dis = small_distance(c_i, c_j, i, j); // 가장 작은 거리 구하기
                        if (check_small[c_i, c_j] > small_dis)
                            check_small[c_i, c_j] = small_dis;
                    }
                }
            }
        }

        private int small_distance(int my_i, int my_j, int other_i, int other_j) // 가장 작은 거리 구하기
        {
            return Math.Abs(other_i - my_i) + Math.Abs(other_j - my_j) - 1;
        }

        private void fst_sum(int size) // 구한 떨어진 거리를 적절하게 배분
        {
            small_list = new int[number]; // 떨어진 것들마다 최소 거리를 구하기 위한 배열
            for (int i = 1; i < number; i++)
            {
                small_list[i] = 26;
            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (check_return_shape[i, j] != 0)
                    {
                        if (small_list[check_return_shape[i, j]] > check_small[i, j]) // 최소 배열을 구함
                        {
                            small_list[check_return_shape[i, j]] = check_small[i, j];
                        }
                    }
                }
            }
            int total = 0;
            for (int i = 1; i < number; i++) // 모든 최소 거리를 더함
            {
                total += small_list[i];
            }
            Random rand = new Random(); // 랜덤을 이용해 적절하게 색상마다 추가적으로 부여
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
