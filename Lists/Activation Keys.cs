using System;
using System.Linq;
using System.Collections.Generic;

namespace Activation_Keys
{
    class Program
    {
        static void Main()
        {
            List<string> keys = Console.ReadLine().Split("&").ToList();

            for (int i = 0; i < keys.Count; i++)
            {
                if (keys[i].Length == 16)
                {
                    string token = "";
                    string word = keys[i];
                    bool isValid = true;

                    for (int j = 0; j < word.Length; j++)
                    {
                        if (j % 4 == 0 && j != 0)
                        {
                            if (char.IsDigit(word[j]))
                            {
                                int number = 9 - int.Parse(word[j].ToString());
                                token += "-" + number;
                            }
                            else if (char.IsLetter(word[j]))
                            {
                                token += "-" + word[j];
                            }
                            else
                            {
                                isValid = false;
                                break;
                            }
                        }                        
                        else
                        {
                            if (char.IsDigit(word[j]))
                            {
                                int number = 9 - int.Parse(word[j].ToString());
                                token += number;
                            }
                            else if (char.IsLetter(word[j]))
                            {
                                token += word[j];
                            }
                            else
                            {
                                isValid = false;
                                break;
                            }
                        }
                    }

                    if (isValid)
                    {
                        keys[i] = token.ToUpper();
                    }
                    else
                    {
                        keys.Remove(keys[i]);
                        i--;
                    }
                }
                else if (keys[i].Length == 25)
                {
                    string token = "";
                    string word = keys[i];
                    bool isValid = true;

                    for (int j = 0; j < word.Length; j++)
                    {
                        if (j % 5 == 0 && j != 0)
                        {
                            if (char.IsDigit(word[j]))
                            {
                                int number = 9 - int.Parse(word[j].ToString());
                                token += "-" + number;
                            }
                            else if (char.IsLetter(word[j]))
                            {
                                token += "-" + word[j];
                            }
                            else
                            {
                                isValid = false;
                                break;
                            }
                        }
                        else
                        {
                            if (char.IsDigit(word[j]))
                            {
                                int number = 9 - int.Parse(word[j].ToString());
                                token += number;
                            }
                            else if (char.IsLetter(word[j]))
                            {
                                token += word[j];
                            }
                            else
                            {
                                isValid = false;
                                break;
                            }
                        }                        
                    }

                    if (isValid)
                    {
                        keys[i] = token.ToUpper();
                    }
                    else
                    {
                        keys.Remove(keys[i]);
                        i--;
                    }
                }
                else
                {
                    keys.Remove(keys[i]);
                    i--;
                }
            }

            Console.WriteLine(string.Join(", ", keys));
        }
    }
}
