using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Update
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Submitted by: David San Clemente");
            Console.WriteLine("Engineering 115");
            Console.WriteLine("Checkpoint 5 for Quiz");

            int numQuestions = 10;
            int numTries = 3;
            String[] QuestionArray = new String[numQuestions];
            String[] AnswerArray = new String[numQuestions];
            String[] OptionArray = new String[numQuestions];
            String[] StudentArray = new String[numQuestions];
            String[] ResponseArray = new String[numQuestions];

            QuestionArray[0] = "Question 1: The Spartans were the only soldiers at Thermopylae. True or False";
            OptionArray[0] = "True or False";
            ResponseArray[0] = "False";
            QuestionArray[1] = "Question 2: This civilization had a Ceasar";
            OptionArray[1] = "A: Rome  B: Greece   C: Macedonia  D: Persia";
            QuestionArray[2] = "Question 3: Germany placed the first object into space";
            OptionArray[2] = "True or False";
            QuestionArray[3] = "Question 4: The year humans first landed on the moon this year";
            OptionArray[3] = "A: 1968  B: 1969   C: 1965  D: 1970";
            QuestionArray[4] = "Question 5: The Titanic had no faults on its maiden voyage.True or False";
            OptionArray[4] = "True or False";
            QuestionArray[5] = "Question 6: The year William The Conqueror invaded Great Britain";
            OptionArray[5] = "A: 1501  B: 1051  C: 1066  D: 1102";
            QuestionArray[6] = "Question 7: Pi has a finite number of decimals. True or False";
            OptionArray[6] = "True or False";
            QuestionArray[7] = "Question 8: Popular sci-fi franchise based a long time ago in a galaxy far far away";
            OptionArray[7] = "A: Star Trek  B: Dr Who  C: Conan the Barbarian  D: Star Wars";
            QuestionArray[8] = "Question 9: Harrison Ford rescued distressed hikers with his helicopter. True or False";
            OptionArray[8] = "True or False";
            QuestionArray[9] = "Question 10: The tallest building in the world.";
            OptionArray[9] = "A: Empire State Building  B: Shanghai Tower  C: Burj Khalifa  D: Wuhan Greenland Center";

            while (numTries > 0)
            {
                int i = 0;
                while (i < numQuestions)
                {
                    Console.WriteLine(QuestionArray[i]);
                    Console.WriteLine(OptionArray[i]);
                    Console.ReadLine();


                    i = i + 1;

                }

                numTries = numTries - 1;
            }

            if (ResponseArray[0] == "False" || ResponseArray[0] == "false")
            {
                Console.WriteLine("Correct");
            }
            else if (ResponseArray[0] != "False" || ResponseArray[0] != "false")
            {
                Console.WriteLine("Incorrect");
            }

            if (ResponseArray[1] == "a" || ResponseArray[1] == "A" || ResponseArray[1] == "rome" || ResponseArray[1] == "Rome")
            {
                Console.WriteLine("Correct");
            }
            else if (ResponseArray[1] != "a" || ResponseArray[1] != "A" || ResponseArray[1] != "rome" || ResponseArray[1] != "Rome")
            {
                Console.WriteLine("Incorrect");

            }

            if (ResponseArray[2] == "True" || ResponseArray[2] == "true")
            {
                Console.WriteLine("Correct");
            }
            else if (ResponseArray[2] != "True" || ResponseArray[2] != "true")
            {
                Console.WriteLine("Incorrect");
            }

            if (ResponseArray[3] == "b" || ResponseArray[3] == "B" || ResponseArray[3] == "1969")
            {
                Console.WriteLine("Correct");
            }
            else if (ResponseArray[3] != "b" || ResponseArray[3] != "B" || ResponseArray[3] != "1969")
            {
                Console.WriteLine("Incorrect");

            }

            if (ResponseArray[4] == "False" || ResponseArray[4] == "false")
            {
                Console.WriteLine("Correct");
            }
            else if (ResponseArray[4] != "False" || ResponseArray[4] != "true")
            {
                Console.WriteLine("Incorrect");
            }

            if (ResponseArray[5] == "c" || ResponseArray[5] == "C" || ResponseArray[5] == "1066")
            {
                Console.WriteLine("Correct");
            }
            else if (ResponseArray[5] != "c" || ResponseArray[5] != "C" || ResponseArray[5] != "1066")
            {
                Console.WriteLine("Incorrect");

            }

            if (ResponseArray[6] == "False" || ResponseArray[6] == "false")
            {
                Console.WriteLine("Correct");
            }
            else if (ResponseArray[6] != "False" || ResponseArray[6] != "true")
            {
                Console.WriteLine("Incorrect");
            }

            if (ResponseArray[7] == "d" || ResponseArray[7] == "D" || ResponseArray[7] == "Star Wars" || ResponseArray[7] == "star wars")
            {
                Console.WriteLine("Correct");
            }
            else if (ResponseArray[7] != "d" || ResponseArray[7] != "D" || ResponseArray[7] != "Star Wars" || ResponseArray[7] != "star wars")
            {
                Console.WriteLine("Incorrect");

            }

            if (ResponseArray[8] == "True" || ResponseArray[8] == "true")
            {
                Console.WriteLine("Correct");
            }
            else if (ResponseArray[8] != "True" || ResponseArray[8] != "true")
            {
                Console.WriteLine("Incorrect");
            }

            if (ResponseArray[9] == "c" || ResponseArray[9] == "C" || ResponseArray[9] == "Burj Khalifa" || ResponseArray[9] == "burj khalifa")
            {
                Console.WriteLine("Correct");
            }
            else if (ResponseArray[9] != "c" || ResponseArray[9] != "C" || ResponseArray[9] != "Burj Khalifa" || ResponseArray[9] != "burj khalifa")
            {
                Console.WriteLine("Incorrect");

            }

            Console.Read();

        }

        static string WriteTryAgain()
        {
            Console.WriteLine("Invalid entry, try again");
            return Console.ReadLine();
        }

        static void ShowQuestion(int i)
        {

        }

        static Boolean TakeAnswer(int i)
        {

            return true;
        }

    }
}
