using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interview_prep
{
    class Program
    {
        static void Main(string[] args)
        {
            //change("1234");
            //string z = charMultiplt('#', 6);
            //Console.WriteLine(z);

            //string Z = stringCompression("AaAYYYYOOOOAAA");
            // Console.WriteLine(Z);
            //Console.WriteLine("Enter the integer to add up");
            //string Ay1 = Console.ReadLine();
            //int Ay = Int32.Parse(Ay1);
            //Ay = add(Ay);

            ////Console.WriteLine(Ay);
            //Random rndnum = new Random();
            //int zaza = rndnum.Next(1,100);
            //Console.WriteLine(zaza);
            //permutation("ayo");

            //isUniqueChars("Ayo");

            //char[] message = { 'c', 'a', 'k', 'e', ' ', 'T', 'h','e' };
            //ReverseWords(message);

            //int[] numbers = { 1, 2, 3, 4, 5, 5, 4, 2, 1, 4, 4 ,4,6};
            //int result = 0;
            //foreach (int item in numbers)
            //{
            //    result ^= item;
            //}
            //Console.WriteLine(result);

            //StringBuilder ayo = new StringBuilder();

            // playHideAndSeek();
           

            //countAllCharInstances("AbacDazabacaasDADlLLAodoonnrrmakkkefkkdkmbvlsllskfkmvpsppskf");



            Console.ReadLine();
            
        }
        private static void name()
        {
            string first = "Ayomikun";
            string middle = "James";
            string last = "Oluwayemi";
            int age = 20;
            int height = 194;
            //formating
            //format
            Console.WriteLine(String.Format("{0} {1} {2}", first, middle, last));
            Console.WriteLine(String.Format("{0}    {1}", age, height));
            Console.WriteLine("{0}    {1}", age + 100, height + 100);
            
        }
        private static void change(string z)
        {
            int b = Int32.Parse(z);
            Console.WriteLine(b);

          
        }
        private static string charMultiplt(char a, int b)
        {
            string zozo = new string(a,b);

            return zozo;
        }
        private static string stringCompression(string a)
        {
            char[] newString = a.ToCharArray();
            int i = 0;
            int z = 0;
            int count = 0;
            string num = "";
            for (z = 0; z < newString.Length; z++)
            {
                for (i = z; i < newString.Length; i++)
                {
                    if (char.ToLower(newString[z]) == char.ToLower(newString[i]))
                    {
                        count++;
                    }
                    else
                        break;
                    
                }
                num += newString[z];
                num += count;
                count = 0;
                z = i-1;



            }
                 return num;
            //while (char.ToLower(newString[i]) == char.ToLower(newString[z]))
            //{
            //    count++;

            //    if (z >= newString.Length)
            //    {
            //        break;
            //    }
            //    z++;
            //}
        }
        private static int add(int x)
        {
            if (x < 10)
                return x;
            else
            {
                int sum = 0;
                int a = addup(x,sum);
                return a;
            }
        }
        private static int addup(int x, int sum)
        {
            if (x > 0)
            {
                sum += x % 10;
                x = x / 10;
                return addup(x, sum);
            }
            else
            {
                return sum;
            }
        }
        private static void countAllCharInstances(string x)
        {
            x = x.ToLower();
            //x.Substring(-1);
            char[] xchar = x.ToCharArray();
            for(int i=0; i<xchar.Length; i++)
            {
                if(xchar[i] == ' ')
                {
                    continue;
                }
                char temp = xchar[i];
                int count = 0;
                for (int j=i; j<xchar.Length; j++)
                {
                    if(temp == xchar[j])
                    {
                        count++;
                        xchar[j] = ' ';
                    }

                }
                Console.WriteLine(String.Format("{0} Ocurred {1} time(s)",temp,count));
            }
        }
       
        private static void permutation(string str, string prefix)
        {
            if(str.Length == 0)
            {
                Console.WriteLine(prefix);
            }
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    string a = str.Substring(0, i);
                    string b = str.Substring(i + 1);
                    string rem = a + b;
                    Console.WriteLine(prefix);

                    permutation(rem, prefix + str[i]);

                }
            }
           
        }
        
        private static bool isUniqueChars(string str)
        {
            // implementing an algorithm to determine if a string has all unique characters
            if (str.Length > 128) return false;
            else
            {
                bool[] char_set = new bool[128];
                for (int i = 0; i<str.Length; i++)
                {
                    int val = (int)(str[i]);
                    if (char_set[val])
                    {
                        return false;
                    }
                    char_set[val] = true;
                }
                return true;
               
            }
        }

        private static void ReverseWords(char[] ayo)
        {
            string ayo1 = string.Join("",ayo.ToArray());
            string[] messagereverse = ayo1.Split(' ');
            for(int i = messagereverse.Length-1; i>=0; i--)
            {
                Console.WriteLine(messagereverse[i]);
            }
            
        }

        private static void HideAndSeekBoard(int dimension)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            int num = 1;
            int[,] board = new int[dimension, dimension];
            for(int i=0; i<dimension; i++)
            {
                Console.WriteLine("");
                for(int j=0; j<dimension; j++)
                {
                    board[i, j] = num;
                    if(num < 10)
                    {
                        Console.Write("    " + num);
                    }
                    else{
                        Console.Write("   " + num);
                    }
                    
                    num++;
                }
            }
            Console.WriteLine("");
        }

        private static string Hider(int a, int dimension)
        {
            StringBuilder hideplace = new StringBuilder();
            int[,] board = new int[dimension, dimension];
            int num = 1;
            for(int i=0; i<dimension; i++)
            {
                for(int j=0; j<dimension; j++)
                {
                    board[i, j] = num;
                    if(num == a)
                    {
                        hideplace.Append(i);
                        hideplace.Append(j);
                    }
                    num++;
                }
            }

            return hideplace.ToString();
        }

        private static string Seeker(int a, int dimension)
        {
            StringBuilder hideplace = new StringBuilder();
            int[,] board = new int[dimension, dimension];
            int num = 1;
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    board[i, j] = num;
                    if (num == a)
                    {
                        hideplace.Append(i);
                        hideplace.Append(j);
                    }
                    num++;
                }
            }

            return hideplace.ToString();
        }

        private static void playHideAndSeek()
        {
            Console.WriteLine("Enter the dimension of the board");
            string boarddimension = Console.ReadLine();
            int boarddimension1 = Int32.Parse(boarddimension);

            //HideAndSeekBoard(boarddimension1);
            Boolean game = true;

            while (game)
            {
                HideAndSeekBoard(boarddimension1);
                Console.WriteLine("Enter the position you would like to Hide");
                string hideplace = Console.ReadLine();
                int hideplace1 = Int32.Parse(hideplace);
                string hiderp = Hider(hideplace1, boarddimension1);
                //HideAndSeekBoard(boarddimension1)
               
                // clear the board before handing the computer over to the seeker
                Console.WriteLine("Enter the position you want to Seek");
                string seekplace = Console.ReadLine();
                int seekplace1 = Int32.Parse(seekplace);
                string seekerp = Seeker(seekplace1, boarddimension1);
                //HideAndSeekBoard(boarddimension1);


                if (hiderp == seekerp || hiderp[0] == seekerp[0] || hiderp[1] == seekerp[1])
                {
                    game = false;
                    Console.WriteLine("Seeker has Found the hidden player, HIDE HARDER");

                }
                else
                {
                    Console.WriteLine("Seeker has not found the hidden player, try again");
                }
            }
        }

       

    }
}
