using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode
{
    public class _353_贪吃蛇游戏
    {
        public class SnakeGame
        {
            struct Point
            {
                public int x;
                public int y;
            }

            private Queue<Point> q;
            private int _width;
            private int _height;
            private int foodIdx;
            private int[][] _food;
            private Point head;
            private int score;

            /** Initialize your data structure here.
                @param width - screen width
                @param height - screen height 
                @param food - A list of food positions
                E.g food = [[1,1], [1,0]] means the first food is positioned at [1,1], the second is at [1,0]. */
            public SnakeGame(int width, int height, int[][] food)
            {
                _width = width;
                _height = height;
                foodIdx = 0;
                _food = food;
                head = new Point { x = 0, y = 0 };
                q = new Queue<Point>();
                q.Enqueue(head);
            }

            /** Moves the snake.
                @param direction - 'U' = Up, 'L' = Left, 'R' = Right, 'D' = Down 
                @return The game's score after the move. Return -1 if game over. 
                Game over when snake crosses the screen boundary or bites its body. */
            public int Move(string direction)
            {
                Point nextPoint;
                switch (direction)
                {
                    case "U":
                        {
                            nextPoint = new Point { x = head.x - 1, y = head.y };
                            break;
                        }
                    case "L":
                        {
                            nextPoint = new Point { x = head.x, y = head.y - 1 };
                            break;
                        }
                    case "R":
                        {
                            nextPoint = new Point { x = head.x, y = head.y + 1 };
                            break;
                        }
                    default:
                        {
                            nextPoint = new Point { x = head.x + 1, y = head.y };
                            break;
                        }
                }

                
                if (foodIdx < _food.Length && _food[foodIdx][0] == nextPoint.x && _food[foodIdx][1] == nextPoint.y)
                {
                    foodIdx++;
                    score++;
                }
                else
                {
                    q.Dequeue();

                    if (willDie(nextPoint.x, nextPoint.y))
                    {
                        return -1;
                    }
                }

                q.Enqueue(nextPoint);
                head = nextPoint;

                return score;
            }

            private bool willDie(int x, int y)
            {
                if (x < 0 || x >= _height || y < 0 || y >= _width)
                {
                    return true;
                }

                foreach (var p in q)
                {
                    if (p.x == x && p.y == y)
                    {
                        return true;
                    }
                }

                return false;
            }
        }
    }
}
