using System;

namespace lab_one
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarations
            String[] answerkey = { "B", "B", "C", "A", "D", "A", "A", "C", "D", "A" };
            String[] anwserKey1 = new String[10];  //empty array to store awnsers
            String userSelection;
            String[] questions = { "Which Company owns .NETCORE? ",
                                   "what year was the first version of dotnet core released?",
                                   "What is the current version of .NETCORE ?",
                                   "What operating systems support .NETCORE ?",
                                   "who are the developers of dotnet core? ",
                                   "Is .NETCORE an open source or paid services ?",
                                   "What year was the first major release of . NET Core along with the correspondent versions of ASP . NET Core and Entity Framework Core.?",
                                   "Are developers required to compile Nuget packages included in .NET Core?",
                                   "what other platforms does microsoft creat  ?",
                                   "What is .NETCORE used for ?" };
            // muti dimensional array 
            string[,] optionChoices =  {
                                     {"A) Apple","B)Microsoft","C)Micro","D)Google"},
                                     {"A) 1998","B)2002","C)2003","D)2008"},
                                     {"A) 1.0","B)5.0","C)2.2","D)3.0"},
                                     {"A) All of the above","B)Windows","C)macOS","D)Linux"},
                                     {"A) Apple Foundation","B)Console","C).NET Google","D).NET Foundation"},
                                     {"A) Open Soirce","B)Paid","C)Trial","D)No"},
                                     {"A) Mid-2016","B)2017","C)2000","D)2012"},
                                     {"A) No","B)Nuget.netcore","C)Yes","D)Maybe"},
                                     {"A) System Center","B)Microsoft SQL Server","C)Microsoft .NET Framework.","D) All of the above"},
                                     {"A) Used to build .Net Frame works","B) It's incomplete","C) Used to build","D) used to build device, cloud, and IoT applications." }
                                    };
            string Begin; //primer
            string EXIT = "1";
            int x, y;  //looping vars
            double totalCorrect, inCorrect;

            //welcome message and instructions for the program and end user 
            Console.WriteLine("Welcome to the .NETCORE knowledge base questions. This quiz is aimed at testing your knowledge of the Microsoft .NETCORE frame work. \n PLease Awnser the questions \n You need seven out of TEN to be considered a successful candidate");
            Console.WriteLine("To get started, please type the word begin and press ENTER ");
            Begin = Console.ReadLine();

            while (Begin != EXIT)
            {
                //reseting for next round
                totalCorrect = 0;
                inCorrect = 0;
                //loop to out put questions 
                for (x = 0; x < questions.Length; x++)
                {
                    Console.WriteLine(questions[x]);
                    //nested loop for options choices
                    for (y = 0; y < optionChoices.GetLength(1); y++) //optionChoices.GetLength(y)
                    {

                        Console.WriteLine(optionChoices[x, y]);
                    }//end for loop for awnsers
                    Console.WriteLine("Please Enter your awnser");
                    userSelection = Console.ReadLine();

                    //decision making logic to determine if they got the question correct or not 
                    Console.Clear();

                    if (userSelection.ToUpper() == answerkey[x])
                    {
                        totalCorrect++; //adding to correct 
                    }
                    else inCorrect++;

                    Console.WriteLine($"you have {totalCorrect} correct awnsers and got {inCorrect} Wrong");
                }//end questions loop
                double POSSIBLEPOINT = 10;
                //Console.WriteLine($"you have {totalCorrect} correct awnsers and got {inCorrect} Wrong");
                //math to find out the % of the score 
                double precentage = 0;
                precentage = (100 * (totalCorrect / POSSIBLEPOINT));

                Console.WriteLine($"{precentage}%");
                if (totalCorrect >= 7) { Console.WriteLine("you passed"); }

                else { Console.WriteLine("you failed the test. Revisit your notes and try again next time"); }

                //Asking the primer again
                Console.WriteLine("To take Quiz again type ENTER of 1 to Exit");

                Begin = Console.ReadLine();


            }//end while loop 

        }
    }
}
