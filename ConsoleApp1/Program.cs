using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Update
{
    class Program
    {

        static int numTries;
        static int numQuestions;
        // Questions for quiz
        static string[] QuestionArray;
        //Options for answers to quiz
        // Should be an array of arrays
        // A single element array indicates a True/False question, 
        // Otherwise, a multiple choice.
        static string[][] OptionArray;
        // Solution: Correct Answers
        static string[] SolutionKeyArray;
        // Raw student responses
        static string[] StudentResponseArray;

        static void Main(string[] args)
        {
            Console.WriteLine("Submitted by: David San Clemente");
            Console.WriteLine("Engineering 115");
            Console.WriteLine("Checkpoint 5 for Quiz");

            
            numTries = 3;
            numQuestions = 10;

            QuestionArray = new String[numQuestions];
            OptionArray = new String[numQuestions][];
            SolutionKeyArray = new String[numQuestions];
            StudentResponseArray = new String[numQuestions];

            QuestionArray[0] = "Question 1: The Spartans were the only soldiers at Thermopylae. True or False";
            OptionArray[0] = new string[] { "True or False"};
            SolutionKeyArray[0] = "false";

            QuestionArray[1] = "Question 2: This civilization had a Ceasar";
            OptionArray[1] = new string[] { "Rome", "Greece", "Macedonia", "Persia" };            

            QuestionArray[2] = "Question 3: Germany placed the first object into space";
            OptionArray[2] = new string[] { "True or False" };

            QuestionArray[3] = "Question 4: The year humans first landed on the moon this year";
            OptionArray[3] = new string[] { "1968", "1969", "1965", "1970" };

            QuestionArray[4] = "Question 5: The Titanic had no faults on its maiden voyage.True or False";
            OptionArray[4] = new string[] { "True or False" };

            QuestionArray[5] = "Question 6: The year William The Conqueror invaded Great Britain";
            OptionArray[5] = new string[] { "1501", "1051", "1066", "1102"};

            QuestionArray[6] = "Question 7: Pi has a finite number of decimals. True or False";
            OptionArray[6] = new string[] { "True or False" };

            QuestionArray[7] = "Question 8: Popular sci-fi franchise based a long time ago in a galaxy far far away";
            OptionArray[7] = new string[] { "Star Trek", "Dr Who", "Conan the Barbarian", "Star Wars" };

            QuestionArray[8] = "Question 9: Harrison Ford rescued distressed hikers with his helicopter. True or False";
            OptionArray[8] = new string[] { "True or False" };

            QuestionArray[9] = "Question 10: The tallest building in the world.";
            OptionArray[9] = new string[] { "Empire State Building", "Shanghai Tower",
                             "Burj Khalifa", "Wuhan Greenland Center"};


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

            if (SolutionKeyArray[0] == "False" || SolutionKeyArray[0] == "false")
            {
                Console.WriteLine("Correct");
            }
            else if (SolutionKeyArray[0] != "False" || SolutionKeyArray[0] != "false")
            {
                Console.WriteLine("Incorrect");
            }

            if (SolutionKeyArray[1] == "a" || SolutionKeyArray[1] == "A" || SolutionKeyArray[1] == "rome" || SolutionKeyArray[1] == "Rome")
            {
                Console.WriteLine("Correct");
            }
            else if (SolutionKeyArray[1] != "a" || SolutionKeyArray[1] != "A" || SolutionKeyArray[1] != "rome" || SolutionKeyArray[1] != "Rome")
            {
                Console.WriteLine("Incorrect");

            }

            if (SolutionKeyArray[2] == "True" || SolutionKeyArray[2] == "true")
            {
                Console.WriteLine("Correct");
            }
            else if (SolutionKeyArray[2] != "True" || SolutionKeyArray[2] != "true")
            {
                Console.WriteLine("Incorrect");
            }

            if (SolutionKeyArray[3] == "b" || SolutionKeyArray[3] == "B" || SolutionKeyArray[3] == "1969")
            {
                Console.WriteLine("Correct");
            }
            else if (SolutionKeyArray[3] != "b" || SolutionKeyArray[3] != "B" || SolutionKeyArray[3] != "1969")
            {
                Console.WriteLine("Incorrect");

            }

            if (SolutionKeyArray[4] == "False" || SolutionKeyArray[4] == "false")
            {
                Console.WriteLine("Correct");
            }
            else if (SolutionKeyArray[4] != "False" || SolutionKeyArray[4] != "true")
            {
                Console.WriteLine("Incorrect");
            }

            if (SolutionKeyArray[5] == "c" || SolutionKeyArray[5] == "C" || SolutionKeyArray[5] == "1066")
            {
                Console.WriteLine("Correct");
            }
            else if (SolutionKeyArray[5] != "c" || SolutionKeyArray[5] != "C" || SolutionKeyArray[5] != "1066")
            {
                Console.WriteLine("Incorrect");

            }

            if (SolutionKeyArray[6] == "False" || SolutionKeyArray[6] == "false")
            {
                Console.WriteLine("Correct");
            }
            else if (SolutionKeyArray[6] != "False" || SolutionKeyArray[6] != "true")
            {
                Console.WriteLine("Incorrect");
            }

            if (SolutionKeyArray[7] == "d" || SolutionKeyArray[7] == "D" || SolutionKeyArray[7] == "Star Wars" || SolutionKeyArray[7] == "star wars")
            {
                Console.WriteLine("Correct");
            }
            else if (SolutionKeyArray[7] != "d" || SolutionKeyArray[7] != "D" || SolutionKeyArray[7] != "Star Wars" || SolutionKeyArray[7] != "star wars")
            {
                Console.WriteLine("Incorrect");

            }

            if (SolutionKeyArray[8] == "True" || SolutionKeyArray[8] == "true")
            {
                Console.WriteLine("Correct");
            }
            else if (SolutionKeyArray[8] != "True" || SolutionKeyArray[8] != "true")
            {
                Console.WriteLine("Incorrect");
            }

            if (SolutionKeyArray[9] == "c" || SolutionKeyArray[9] == "C" || SolutionKeyArray[9] == "Burj Khalifa" || SolutionKeyArray[9] == "burj khalifa")
            {
                Console.WriteLine("Correct");
            }
            else if (SolutionKeyArray[9] != "c" || SolutionKeyArray[9] != "C" || SolutionKeyArray[9] != "Burj Khalifa" || SolutionKeyArray[9] != "burj khalifa")
            {
                Console.WriteLine("Incorrect");

            }

            Console.Read();

        }

        static void printQuestion(int questionNumber)
        {
            // TODO: Include options, handling True/False and multiple choice appropriately.
            Console.WriteLine(QuestionArray[questionNumber]);
        }

        /* True/False questiosn are handled differently than 
            multiple choice questions, so differentiating them is important.
            If the option array is the single entry "True or False"
            then it indicates we aren't dealing with a 
            multiple choice question.
         */ 
        static bool isTrueFalseQuestion(int answerNumber)
        {
            return OptionArray[answerNumber].Length == 1;            
        }


        // Determine if the Student Response fits one of the 
        // Given response options.
        static bool isValidAnswer(int answerNumber)
        {
            //TODO:
            return true;
        }

        static bool isAnswerCorrect(int answerNumber)
        {
            // TODO: Create seperate implementation for T/F vs Multiple choice answers.
            return StudentResponseArray[answerNumber] == SolutionKeyArray[answerNumber]
        }

    }
}
