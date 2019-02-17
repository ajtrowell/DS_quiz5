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
        /* Options for answers to quiz. Should be an array of arrays
        A single element array indicates a True/False question, Otherwise, a multiple choice.
        */
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

            
            numTries = 3; // Attempts to get each question correct.

            // Populate the Questions, Options, and Solution Arrays.
            setupQuizQuestionsAndAnswers();

            while (numTries > 0)
            {
                int i_question = 0;
                while (i_question < numQuestions)
                {
                    // Keep asking same question until we get a valid answer.
                    while(!isValidAnswer(i_question))
                    {
                        printQuestionWithOptions(i_question);
                        StudentResponseArray[i_question] = Console.ReadLine();
                    }

                    i_question = i_question + 1;
                }

                numTries = numTries - 1;
            }

            Console.Read(); // Run until final keypress.

        } // End main function


        static void setupQuizQuestionsAndAnswers()
        {

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
            SolutionKeyArray[1] = "Rome";

            QuestionArray[2] = "Question 3: Germany placed the first object into space";
            OptionArray[2] = new string[] { "True or False" };
            SolutionKeyArray[2] = "true";

            QuestionArray[3] = "Question 4: The year humans first landed on the moon this year";
            OptionArray[3] = new string[] { "1968", "1969", "1965", "1970" };
            SolutionKeyArray[3] = "1969";

            QuestionArray[4] = "Question 5: The Titanic had no faults on its maiden voyage.True or False";
            OptionArray[4] = new string[] { "True or False" };
            SolutionKeyArray[4] = "false";

            QuestionArray[5] = "Question 6: The year William The Conqueror invaded Great Britain";
            OptionArray[5] = new string[] { "1501", "1051", "1066", "1102"};
            SolutionKeyArray[5] = "1066";

            QuestionArray[6] = "Question 7: Pi has a finite number of decimals. True or False";
            OptionArray[6] = new string[] { "True or False" };
            SolutionKeyArray[6] = "false";

            QuestionArray[7] = "Question 8: Popular sci-fi franchise based a long time ago in a galaxy far far away";
            OptionArray[7] = new string[] { "Star Trek", "Dr Who", "Conan the Barbarian", "Star Wars" };
            SolutionKeyArray[6] = "Star Wars";

            QuestionArray[8] = "Question 9: Harrison Ford rescued distressed hikers with his helicopter. True or False";
            OptionArray[8] = new string[] { "True or False" };
            SolutionKeyArray[8] = "true";

            QuestionArray[9] = "Question 10: The tallest building in the world.";
            OptionArray[9] = new string[] { "Empire State Building", "Shanghai Tower",
                             "Burj Khalifa", "Wuhan Greenland Center"};
            SolutionKeyArray[9] = "Burj Khalifa";

        }

        static void printQuestionWithOptions(int questionNumber)
        {
            Console.WriteLine(); //Adds a line between questions.
            Console.WriteLine(QuestionArray[questionNumber]);
            if (isTrueFalseQuestion(questionNumber))
            {
                Console.WriteLine("True or False");
            } else
            {
                // For Multiple choice, We need to add correct letter prefixes.
                //Console.WriteLine()
                string optionFormatting;
                for(int i=0; i<OptionArray[questionNumber].Length; i++)
                {
                    optionFormatting = Number2String(i + 1,true) + ": " + OptionArray[questionNumber][i];
                    Console.WriteLine(optionFormatting);
                }
            }
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
            if (StudentResponseArray[answerNumber] == null)
            {
                return false;
            }

            bool isValid = false; // Default value, permits |= use;
            string studentResponse = StudentResponseArray[answerNumber].ToLower();

            if (isTrueFalseQuestion(answerNumber))
            {
                isValid = (studentResponse == "true" || studentResponse == "false" || studentResponse == "t" || studentResponse == "f");
                return isValid;
            }
            else
            {
                // Valid Multiple choice responses include any of the options, or their letters, in any case.
                for (int i_option = 0; i_option < OptionArray[answerNumber].Length; i_option++)
                {
                    // If any line is true, isValid will be true.
                    isValid |= (studentResponse == Number2String(i_option + 1, false));
                    isValid |= (studentResponse == OptionArray[answerNumber][i_option].ToLower());
                }
            }
            return isValid;
        }

        static bool isAnswerCorrect(int answerNumber)
        {
            // TODO: Create seperate implementation for T/F vs Multiple choice answers.
            return StudentResponseArray[answerNumber] == SolutionKeyArray[answerNumber];
        }

        // Turns a number to a string: 1>A, 4>D, and so on.
        static String Number2String(int number, bool isCaps)
        {
            Char c = (Char)((isCaps ? 65 : 97) + (number - 1));
            return c.ToString();
        }

        // Assume Lowercase, single argument.
        static String Number2String(int number)
        {
            return Number2String(number, false);
        }

    }
}
