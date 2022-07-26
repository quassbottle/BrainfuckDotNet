using System;

namespace BrainfuckDotNet
{
    public class Brainfuck
    {
        private int _dataSize;
        public Brainfuck(int size = 30000)
        {
            _dataSize = size;
        }
        public void Run(string code)
        {
            int[] array = new int[_dataSize];
            int p = array.Length / 2;
            int b = 0;

            for (int i = 0; i < code.Length; i++)
            {
                switch (code[i])
                {
                    case '>':
                        p++;
                        break;
                    case '<':
                        p--;
                        break;
                    case '+':
                        array[p]++;
                        break;
                    case '-':
                        array[p]--;
                        break;
                    case '.':
                        Console.Write((char)array[p]);
                        break;
                    case ',':
                        array[p] = Console.Read();
                        break;
                    case '[':
                        if (array[p] == 0)
                        {
                            b++;
                            while (b > 0)
                            {
                                i++;
                                if (code[i] == '[')
                                {
                                    b++;
                                }
                                if (code[i] == ']')
                                {
                                    b--;
                                }
                            }
                        }
                        break;
                    case ']':
                        if (array[p] == 0)
                        {
                            break;
                        }
                        else
                        {
                            if (code[i] == ']')
                            {
                                b++;
                            }
                            while (b > 0)
                            {
                                i--;
                                if (code[i] == '[')
                                {
                                    b--;
                                }
                                if (code[i] == ']')
                                {
                                    b++;
                                }
                            }
                            i--;
                        }
                        break;
                }
            }
        }
    }
    }
