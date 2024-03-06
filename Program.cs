using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment_pattern
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            //Square_Hollow();
            //NumberTrianglePat();
            //Number_increasing_Pyramid();
            //Number_increasing_Reverse_Pyramid();
            //Number_Pyramid();
            //Zero_One_triangle();
            //Palindrome_Triangle();
            //Rhombus_Pattern();
            //Diamond_Star();
            //Mirror_Image_Triangle();
            //Hollow_Triangle();
            //Hollow_Rerverse_Triangle();
            //Hollow_Daimond_Triangle();
            Hollow_HourGlass();
            //Pascal_pattern();

        }


        static void Square_Hollow()
        {
            int size;
            Console.WriteLine("Pattern 1: Enter ther size of Square:");
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            //i is use for row of square
            for (int i = 0; i < size; i++)
            {
                //j is use for column of square

                for (int j = 0; j < size; j++)
                {
                    // size-1 is for the last coloum or row value 
                    if (i == 0 || j == 0 || i == size - 1 || j == size - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine("");
            }
        }


        static void NumberTrianglePat()
        {
            int row, spa;
            Console.Write(" Pattern 2: Enter the Row:");
            row = Convert.ToInt32(Console.ReadLine());
            spa = row + 4 - 1;

            for (int i = 1; i <= row; i++)
            {
                for (int k = spa; k >= 1; k--)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
                spa--;
            }
        }

        static void Number_increasing_Pyramid()
        {

            int num;
            Console.WriteLine(" Pattern 3: Enter the Number value for number incresing the number");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        static void Number_increasing_Reverse_Pyramid()
        {
            int num;
            Console.Write("Pattern 4: Enter the value to reverse print the increaseing number:");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = num; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        static void Number_Pyramid()
        {
            int num,count=1;
            Console.Write(" Pattern 5: Enter the   number Rows :");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(count);
                    count++;
                }
                Console.WriteLine();
            }
        }

        static void Zero_One_triangle()
        {
            int num;
            Console.Write("Pattern 6: Enter the   number Rows :");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if((i%2)==(j%2))
                    {
                        Console.Write(1);
                    }
                    else
                    {
                        Console.Write(0);
                    }
                   
                }
                Console.WriteLine();
            }
        }

        static void Palindrome_Triangle()
        {
            int num;
            Console.Write("Pattern 7: Enter the   number Rows Palindrome_Triangle :");
            num = Convert.ToInt32(Console.ReadLine());
            //use to rows--->
            for (int i = 1;i<=num;i++)
            {
                //use to print spaces--->
                for (int j = 1; j<=(num-i);j++)
                {
                    Console.Write(" ");
                }
                //use to print number--->

                for (int k=i;k>=1;k--)
                {
                    Console.Write( k);
                }
                //use for second triangle--->
                for (int l=2;l<=i;l++)
                {
                    Console.Write( l);
                }
                Console.WriteLine();
            }
           
        }

        static void Rhombus_Pattern()
        {
            int num;
            Console.Write("Pattern 8: Enter the number Rows Rhombus_Pattern :");
            num = Convert.ToInt32(Console.ReadLine());


            //use to Rows--->
            for (int i=1;i<=num;i++)
            {
                //use to print spaces--->
                for (int j=i;j<=num;j++)
                {
                    Console.Write(" ");
                }
                //use to print stars--->
                for (int k = 1; k <= num; k++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void Diamond_Star()
        {
            int num;
            Console.Write("Pattern 9: Enter the number Rows for Diamond Star :");
            num = Convert.ToInt32(Console.ReadLine());

            // triangle to Upwords

            //use to Rows--->
            for (int i = 1; i <= num; i++)
            {
                //use to print spaces--->
                for (int j = 1; j <= num-i; j++)
                {
                    Console.Write(" ");
                }
                //use to print stars--->
                for (int k = 1; k <= (2*i-1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
   //  Reverse triangle to Downwords
            //use to Reverse Rows--->
            for (int i = num-1; i >= 1; i--)
            {
                //use to print spaces--->
                for (int j = 1; j <= num - i; j++)
                {
                    Console.Write(" ");
                }
                //use to print stars--->
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void Mirror_Image_Triangle()
        {
            int num;
            Console.WriteLine("Pattern 10: Enter Value to ");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = i; k <= num; k++)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine();
            }

            for (int i = num - 1; i >= 1; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = i; k <= num; k++)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine();
            }

        }

        static void Hollow_Triangle()
        {
            int num;
            Console.Write("Pattern 11: Enter the number Rows  Hollow Triangle :");
            num = Convert.ToInt32(Console.ReadLine());
        //use to Rows--->
            for (int i = 1; i <= num; i++)
            {
                //use to print spaces--->
                for (int j = i; j < num ; j++)
                {
                    Console.Write(" ");
                }
                for(int k=1; k <= (2*i-1);k++)
                {
                    if (i == num || k == 1||k== (2 * i - 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void Hollow_Rerverse_Triangle()
        {
            int num;
            Console.Write("Pattern 12: Enter the number Rows  Hollow Triangle :");
            num = Convert.ToInt32(Console.ReadLine());

            //use to Rows--->
            for (int i = 1; i <= num; i++)
            {
                //use to print spaces--->
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }
                {
                    for (int k = 1; k <= (num * 2 - (2 * i - 1)); k++)
                    {
                        if (i == 1 || k == 1 || k == (num * 2 - (2 * i - 1)))
                        {
                            Console.Write("*");
                        }


                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }


        static void Hollow_Daimond_Triangle()
        {
            int num;
            Console.Write("Pattern 13:  Enter the number Rows  Hollow daimond :");
            num = Convert.ToInt32(Console.ReadLine());

            //use to Rows--->
            for (int i = 1; i <= num; i++)
            {
             for (int j=1;j<=num-i;j++)
                {
                    Console.Write(" ");
                }
               for(int k=1;k<=2*i-1;k++)
                {
                    if(k==1||k==2*i-1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            
            // lower Half start from here---->
            // for row --------------------->
            for(int i = 1; i <= num-1;i++)
            {
                //for coloumn -------->
                for(int j=1;j<=i;j++)
                {
                    Console.Write(" ");
                }
                for(int k=1;k<=(2*(num-i) - 1);k++)
                {
                    if(k==1||k==(2 * (num - i) - 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }



        static void Hollow_HourGlass()
        {
            int num;
            Console.Write("Pattern 14: Enter the number Rows  Hollow Hour Glass :");
            num = Convert.ToInt32(Console.ReadLine());

            //use to Rows--->
            for (int i = 1; i <= num; i++)
            {
                //use to print spaces--->
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }
                {
                    for (int k = 1; k <= (num * 2 - (2 * i - 1)); k++)
                    {
                        if (i == 1 || k == 1 || k == (num * 2 - (2 * i - 1)))
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            
            }
            //lower Half start from here---- >
            // for row--------------------->
            for (int i = num - 1; i >= 1; i--)
            {
                //for coloumn -------->
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = i; k <= (num * 2 - (2 * i)); k++)
                {
                    if (i == 1 || k == i || k == (num * 2 - (2 * i)))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        


        static void  Pascal_pattern()
        {
            int num;
            int c=0;
            Console.Write("Pattern 15: Enter the number Rows  for Pascal's pattern :");
            num = Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<=num;i++)
            {
                for(int j=1;j<=num-i;j++)
                {
                    Console.Write(" ");
                }
                for(int k=0;k<=i;k++)
                {
                    if(i==0||k==0)
                    {
                        c = 1;
                        Console.Write(c+" ");
                    }
                    else
                    {
                      
                         c =  c * (i - k + 1)/k;
                        Console.Write(c+" " );
                    }
                }
                Console.WriteLine();
            }
        }

       
    }
}
