using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
                char room = giveRandomRoom();
                Console.WriteLine("\n\nVaccum cleaner in room = " + room);
                checkIfRoomEmpty(room);
            if (room == 'a')
            {
                Console.WriteLine("\n\nVaccum cleaner in room = b" );
                checkIfRoomEmpty('b');
            }
            else
            {
                Console.WriteLine("\n\nVaccum cleaner in room = a");
                checkIfRoomEmpty('a');
            }
        }

        static char giveRandomRoom()
        {
            Random rnd = new Random();
            int num = rnd.Next(2);
            if(num==0)
            {
                return 'a';
            }
            else
            {
                return 'b';
            }
        }

        static void checkIfRoomEmpty(char A)
        {
            int space1 = generate1or2();
            int space2 = generate1or2();
            int position = generate1or2();
            Console.WriteLine("Room : " + A + " | Space 1 is : " + space1 + " | Space 2 is : " + space2);
            if(position==0) {
                Console.WriteLine("Vaccum Cleaner in space1");
            }
            else
            {
                Console.WriteLine("Vaccum Cleaner in space2");
            }
            
            int count = doWork(A, space1, space2,position);  
          
        }

        static int generate1or2()
        {
            Random rnd = new Random();
            int num = rnd.Next(2);
            return num;
        }

        static int doWork(char room, int space1,int space2,int position)
        {
            int count = 0;
            if(position == 0)
            {
                if(space1 == 1)
                {
                    Console.WriteLine("[DIRTY]Suck + Turn Left");
                    count++;
                    count++;
                    if(space2 == 1)
                    {
                        Console.WriteLine("[DIRTY]Move Forward + Suck");
                        count++;
                        Console.WriteLine("Room : " + room + " is clean.");
                        Console.WriteLine("NUmber of movements : " + count);
                    }
                    else
                    {
                        Console.WriteLine("Room : " + room + " is clean.");
                        Console.WriteLine("NUmber of movements : " + count);
                    }
                }
                else
                {
                    Console.WriteLine("[DIRTY]Turn Left + Move Forward");
                    count++;
                    count++;
                    if(space2 ==1)
                    {
                        Console.WriteLine("[DIRTY]Suck");
                        count++;
                        Console.WriteLine("Room : " + room + " is clean.");
                        Console.WriteLine("NUmber of movements : " + count);
                    }
                    else
                    {
                        Console.WriteLine("Room : " + room + " is clean.");
                        Console.WriteLine("NUmber of movements : " + count);
                    }
                }
            }
            else
            {
                if (space2 == 1)
                {
                    Console.WriteLine("Suck + Turn Right");
                    count++;
                    count++;
                    if (space1 == 1)
                    {
                        Console.WriteLine("Move Forward + Suck");
                        count++;
                        count++;
                        Console.WriteLine("Room : " + room + " is clean.");
                        Console.WriteLine("NUmber of movements : " + count);
                    }
                    else
                    {
                        Console.WriteLine("Room : " + room + " is clean.");
                        Console.WriteLine("NUmber of movements : " + count);
                    }
                }
                else
                {
                    Console.WriteLine("Turn Right + Move Forward");
                    count++;
                    count++;
                    if (space1 == 1)
                    {
                        Console.WriteLine("Suck");
                        count++;
                        Console.WriteLine("Room : " + room + " is clean.");
                        Console.WriteLine("NUmber of movements : " + count);
                    }
                    else
                    {
                        Console.WriteLine("Room : " + room + " is clean.");
                        Console.WriteLine("NUmber of movements : " + count);
                    }
                }

            }
            return count;
        }
    }
}
