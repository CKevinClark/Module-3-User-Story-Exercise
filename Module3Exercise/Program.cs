// See https://aka.ms/new-console-template for more information
using System;

namespace MyConsoleApp

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, Shugyosha, to this humble hole. What is your name?");
           string name = Console.ReadLine();

            if (!string.IsNullOrEmpty(name) && char.IsLetter(name[0]))

            {
                char firstChar = char.ToUpper(name[0]); 

                switch (firstChar)
                {
                    case 'A':
                        Console.WriteLine("Ah, I see, by the numeration of the old masters - you reveal Leadership qualities, independence, pioneering spirit, ambitious, self-reliant...");
                        break;
                    case 'B':
                        Console.WriteLine("Ah, I see, by the numeration of the old masters - you reveal Practicality, stability, determination, loyalty, responsibility, grounded...");
                        break;
                    case 'C':
                        Console.WriteLine("Ah, I see, by the numeration of the old masters - you reveal Sociable, creative, expressive, optimistic, imaginative, charming...");
                        break;
                    case 'D':
                        Console.WriteLine("Ah, I see, by the numeration of the old masters - you reveal Hardworking, disciplined, reliable, practical, methodical, systematic...");
                        break;
                    case 'E':
                        Console.WriteLine("Ah, I see, by the numeration of the old masters - you reveal Adventurous, energetic, curious, freedom-loving, versatile, dynamic...");
                        break;
                    case 'F':
                        Console.WriteLine("Ah, I see, by the numeration of the old masters - you reveal Loving, nurturing, compassionate, harmonious, responsible, domestic...");
                        break;
                    case 'G':
                        Console.WriteLine("Ah, I see, by the numeration of the old masters - you reveal Introspective, analytical, philosophical, intuitive, wise, seeking knowledge...");
                        break;
                    case 'H':
                        Console.WriteLine("Ah, I see, by the numeration of the old masters - you reveal Ambitious, authoritative, powerful, practical, materialistic, disciplined...");
                        break;
                    case 'I':
                        Console.WriteLine("Ah, I see, by the numeration of the old masters - you reveal Idealistic, compassionate, intuitive, romantic, sensitive, humanitarian...");
                        break;
                    case 'J':
                        Console.WriteLine("Ah, I see, by the numeration of the old masters - you reveal Artistic, creative, expressive, diplomatic, charismatic, sociable...");
                        break;
                    case 'K':
                        Console.WriteLine("Ah, I see, by the numeration of the old masters - you reveal Dynamic, assertive, inspirational, influential, magnetic, ambitious...");
                        break;
                    case 'L':
                        Console.WriteLine("Ah, I see, by the numeration of the old masters - you reveal Charismatic, communicative, optimistic, sociable, affectionate, joyful...");
                        break;
                    case 'M':
                        Console.WriteLine("Ah, I see, by the numeration of the old masters - you reveal Practical, hardworking, disciplined, responsible, strong-willed, reliable...");
                        break;
                    case 'N':
                        Console.WriteLine("Ah, I see, by the numeration of the old masters - you reveal Innovative, adventurous, independent, energetic, unconventional, freedom-loving...");
                        break;
                    case 'O':
                        Console.WriteLine("Ah, I see, by the numeration of the old masters - you reveal Idealistic, intuitive, spiritual, compassionate, generous, humanitarian...");
                        break;
                    case 'P':
                        Console.WriteLine("Ah, I see, by the numeration of the old masters - you reveal Compassionate, nurturing, sensitive, imaginative, artistic, empathetic...");
                        break;
                    case 'Q':
                        Console.WriteLine("Ah, I see, by the numeration of the old masters - you reveal Charismatic, energetic, pioneering, courageous, confident, independent...");
                        break;
                    case 'R':
                        Console.WriteLine("Ah, I see, by the numeration of the old masters - you reveal Resourceful, determined, ambitious, practical, strong-willed, resilient...");
                        break;
                    case 'S':
                        Console.WriteLine("Ah, I see, by the numeration of the old masters - you reveal Sociable, adaptable, communicative, expressive, charming, versatile...");
                        break;
                    case 'T':
                        Console.WriteLine("Ah, I see, by the numeration of the old masters - you reveal Hardworking, disciplined, practical, reliable, determined, ambitious...");
                        break;
                    case 'U':
                        Console.WriteLine("Ah, I see, by the numeration of the old masters - you reveal Charismatic, optimistic, inspirational, communicative, imaginative, compassionate...");
                        break;
                    case 'V':
                        Console.WriteLine("Ah, I see, by the numeration of the old masters - you reveal Visionary, intuitive, idealistic, humanitarian, innovative, spiritual...");
                        break;
                    case 'W':
                        Console.WriteLine("Ah, I see, by the numeration of the old masters - you reveal Creative, expressive, imaginative, adaptable, versatile, adventurous...");
                        break;
                    case 'X':
                        Console.WriteLine("Ah, I see, by the numeration of the old masters - you reveal Visionary, intuitive, innovative, unconventional, independent, determined...");
                        break;
                    case 'Y':
                        Console.WriteLine("Ah, I see, by the numeration of the old masters - you reveal Idealistic, intuitive, compassionate, sensitive, imaginative, spiritual...");
                        break;
                    case 'Z':
                        Console.WriteLine("Ah, I see, by the numeration of the old masters - you reveal Charismatic, adventurous, unconventional, imaginative, visionary, optimistic...");
                        break;
                    default:
                        Console.WriteLine("You came so far to play games with me Shugyosha?");
                        break;
                }
            }
            else if (!string.IsNullOrEmpty(name) && char.IsDigit(name[0]))
            {
                Console.WriteLine("You are walking a fine line... Shugyosha.");
            }
            else
            {
                Console.WriteLine("Wrong again, Shugyosha.");
            }
           
            Console.WriteLine("Tell me Shugyosha, what cannot be seen, cannot be felt, \nCannot be heard, cannot be smelt, \nIt lies behind stars and under hills, \nAnd empty holes it fills \nIt comes first and follows after, \nEnds life, kills laughter.");

            string answer = Console.ReadLine();

            if (answer == "Darkness" ) {
                Console.WriteLine("I see you are already on the path Shugyasha... fair you well until our next meeting. 111, 222, 333");
            }
            else {
                Console.WriteLine("Your are not ready yet... Shugyasha"); 
                    };
        }
    }

}
