using System;

namespace Mandelbrot
{
    /// <summary>
    /// This class generates Mandelbrot sets in the console window!
    /// </summary>

    //PE4 FINAL GRADE: 80


    class Class1
    {
        /// <summary>
        /// This is the Main() method for Class1 -
        /// this is where we call the Mandelbrot generator!
        /// </summary>
        /// <param name="args">
        /// The args parameter is used to read in
        /// arguments passed from the console window
        /// </param>

        [STAThread]
        static void Main(string[] args)
        {
            double imagCoordEnd, imagCoordStart;
            double realCoordEnd, realCoordStart;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;
            double imagCoordInc, realCoordDec;


            Console.WriteLine("Enter a start number:\n");
            imagCoordStart = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter an end number:\n");
            imagCoordEnd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter another start number:\n");
            realCoordStart = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter another end number:\n");
            realCoordEnd = Convert.ToDouble(Console.ReadLine());

            if (imagCoordStart < imagCoordEnd || realCoordStart > realCoordEnd) 
            {
                Console.WriteLine("INVALID NUMBERS");
            }

            imagCoordInc = (imagCoordStart - imagCoordEnd) / 48;
            realCoordDec = (realCoordEnd - realCoordStart) / 80;

            for (;imagCoordStart >= imagCoordEnd; imagCoordStart -= imagCoordInc)
            {
                for (double realCoordTemp = realCoordStart; realCoordTemp <= realCoordEnd ; realCoordTemp += realCoordDec)
                {

                    iterations = 0;
                    realTemp = realCoordTemp;
                    imagTemp = imagCoordStart;
                    arg = (realCoordTemp * realCoordTemp) + (imagCoordStart * imagCoordStart);
                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                           - realCoordTemp;
                            imagTemp = (2 * realTemp * imagTemp) - imagCoordStart;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                        iterations += 1;
                    }
                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }
                }
                Console.Write("\n");
            }

        }
    }
}

