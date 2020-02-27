using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Midterm_Support
{
    class Program
    {
        static void Main(string[] args)
        {
            //Namespace System.Collections

            //Method 1: ArrayList.Reverse
            // Creates and initializes a new ArrayList.
            ArrayList myAL = new ArrayList();
            myAL.Add("The");
            myAL.Add("quick");
            myAL.Add("brown");
            myAL.Add("fox");
            myAL.Add("jumps");
            myAL.Add("over");
            myAL.Add("the");
            myAL.Add("lazy");
            myAL.Add("dog");


            // Displays the values of the ArrayList.
            Console.WriteLine("The ArrayList initially contains the following values:");
            PrintValues(myAL);

            // Reverses the sort order of the values of the ArrayList.
            myAL.Reverse();

            // Displays the values of the ArrayList.
            Console.WriteLine("After reversing:");
            PrintValues(myAL);

            //Reference: https://docs.microsoft.com/en-us/dotnet/api/system.collections.arraylist.reverse?view=netframework-4.8#System_Collections_ArrayList_Reverse


            Console.WriteLine("\nPress Enter to Continue to my Example");
            Console.ReadLine();

            ArrayList intarr = new ArrayList { 1, 2, 3, 4, 5 };//Made my own list.

            PrintValues(intarr);//Using method from Referenced source to display Array list.

            intarr.Reverse();//Method to reverse the list.

            PrintValues(intarr);//Using method from Referenced source to display Array list in reverse.

            Console.WriteLine("\nPress Enter to Continue");
            Console.ReadLine();

            //Method 2: ArrayList.Sort Method

            Console.WriteLine("The ArrayList initially contains the following values:");
            PrintValues(myAL);

            // Sorts the values of the ArrayList.
            myAL.Sort();

            // Displays the values of the ArrayList.
            Console.WriteLine("After sorting:");
            PrintValues(myAL);
            //Reference: https://docs.microsoft.com/en-us/dotnet/api/system.collections.arraylist.sort?view=netframework-4.8#System_Collections_ArrayList_Sort


            Console.WriteLine("\nPress Enter to Continue to my Example");
            Console.ReadLine();

            ArrayList myUnorgArr = new ArrayList { "Tyler", "Trevor", "Tarra", "Tanner", "Amanda" };//Made my own list.
            PrintValues(myUnorgArr);//Using method from Referenced source to display Array list.

            myUnorgArr.Sort();//Sorts array in alphabetical order.

            PrintValues(myUnorgArr);//Using method from Referenced source to display Array list sorted.

            Console.WriteLine("\nPress Enter to Continue");
            Console.ReadLine();


            //Method 3: Object.GetType Method

            object a = "hello";//created a string variable.

            Console.WriteLine("Identifying the type:\n\nobject o = myDerived: Type is {0}", a.GetType());//displays the data type of variable a.

            Console.WriteLine("\nPress Enter to Continue to my Example");
            Console.ReadLine();

            Console.WriteLine("myUnorgArr type is {0}", myUnorgArr.GetType());// displays the data type of variable myUnorgArr. 

            Console.WriteLine("\nPress Enter to Continue");
            Console.ReadLine();

            //Reference: https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype?view=netframework-4.8#System_Object_GetType

            //Method 4: ArrayList.GetRange(Int32, Int32) Method

            // Creates and initializes the source ICollection.
            Queue mySourceList = new Queue();
            mySourceList.Enqueue("big");
            mySourceList.Enqueue("gray");
            mySourceList.Enqueue("wolf");

            // Displays the values of five elements starting at index 0 From myAL array list from before.
            ArrayList mySubAL = myAL.GetRange(0, 5);
            Console.WriteLine("Index 0 through 4 contains:");
            PrintValues(mySubAL, '\t');

            // Replaces the values of five elements starting at index 1 with the values in the ICollection.
            myAL.SetRange(1, mySourceList);

            // Displays the values of five elements starting at index 0.
            mySubAL = myAL.GetRange(0, 5);
            Console.WriteLine("Index 0 through 4 now contains:");
            PrintValues(mySubAL, '\t');

            //Reference: https://docs.microsoft.com/en-us/dotnet/api/system.collections.arraylist.getrange?view=netframework-4.8#System_Collections_ArrayList_GetRange_System_Int32_System_Int32_

            Console.WriteLine("\nPress Enter to Continue to my Example");
            Console.ReadLine();

            Console.WriteLine("This pulled Index 0 through 1 from my example ArrayList");
            PrintValues(myUnorgArr.GetRange(0, 2));//Pulls two first two obects in the array list starting from the 0 index.

            Console.WriteLine("\nPress Enter to Continue");
            Console.ReadLine();

            //Method 5: 

            // Creates and initializes a new ArrayList.
            // Displays the values of the ArrayList.
            Console.WriteLine("The ArrayList contains the following values:");
            PrintIndexAndValues(myAL);

            // Copies the elements of the ArrayList to a string array.
            String[] myArr = (String[])myAL.ToArray(typeof(string));

            // Displays the contents of the string array.
            Console.WriteLine("The string array contains the following values:");
            PrintIndexAndValues(myArr);

            Console.WriteLine("\nPress Enter to Continue to my Example");
            Console.ReadLine();

            ArrayList aArrL = myUnorgArr;

            String[] aArr = (String[])aArrL.ToArray(typeof(string));

            Console.WriteLine("The string array I created contains the following values:");
            PrintIndexAndValues(aArrL);
            //Reference: https://docs.microsoft.com/en-us/dotnet/api/system.collections.arraylist.toarray?view=netframework-4.8#System_Collections_ArrayList_ToArray_System_Type_

            //Namespace: System
            //Method 1: string.trim Method
            //Commonly used to remove whitespace from the outside of strings, but can remove other unwanted characters from a string. 
            //Takes in a string value and returns a string value

            //identifying characters to remove 
            char[] charsToTrim = { '*', ' ', '\'' };
            //initial string variable
            string banner = "*** Much Ado About Nothing ***";
            //calling the trim method and attching it to banner. passing the character array through the parameters
            string result = banner.Trim(charsToTrim);
            //Outputting the differences between the result and the original string
            Console.WriteLine("Trimmmed\n   {0}\nto\n   '{1}'", banner, result);

            Console.WriteLine("\nMy Example");
            //My Example
            //Set a string
            string myStrVar = "!   Hello User    !";

            //Call the method
            string myTrim = myStrVar.Trim(' ', '!');
            // Output the result
            Console.WriteLine("\nMy Example:\n{0}\nTo\n'{1}'", myStrVar, myTrim);
            //Reference: https://docs.microsoft.com/en-us/dotnet/api/system.string.trim?view=netframework-4.8#System_String_Trim_System_Char___


            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            //Method 2: Char.IsWhiteSpace Method

            //This method will identify if the character selected is 'whitespace',
            //It returns a boolean value
            //Insert a string value in the parameters and the character index you wan to test
            //Note: if you select a

            string str = "black matter";


            Console.WriteLine("------------------------");
            Console.WriteLine("Finding the white space in, '{0}' \nand return a boolean expression if in the 1 index", str);
            Console.WriteLine(Char.IsWhiteSpace(str, 1));      // Output: "False"
            Console.WriteLine("------------------------");
            Console.WriteLine("Finding the white space in, '{0}' \nand return a boolean expression if in the 5 index", str);
            Console.WriteLine(Char.IsWhiteSpace(str, 5));	// Output: "True"
            Console.WriteLine("------------------------");


            string x = "01234 6789";
            Console.WriteLine("Finding the white space in, '{0}' \nand return a boolean expression if in the 5 index", x);
            Console.WriteLine("\nMy Example:\n" + Char.IsWhiteSpace(x, 5));    //Output: "True" 


            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            //Reference: https://docs.microsoft.com/en-us/dotnet/api/system.char.iswhitespace?view=netframework-4.8

            //Method 3: Array.Exists method
            //This method passes elements from an array individually through other methods in the other parameter.
            //It returns boolean expresions and the method is a O(n) operation where n is the length of the array

            String[] names = { "Adam", "Adel", "Bridgette", "Carla",
                         "Charles", "Daniel", "Elaine", "Frances",
                         "George", "Gillian", "Henry", "Irving",
                         "James", "Janae", "Lawrence", "Miguel",
                         "Nicole", "Oliver", "Paula", "Robert",
                         "Stephen", "Thomas", "Vanessa",
                         "Veronica", "Wilberforce" };
            Char[] charsToFind = { 'A', 'K', 'W', 'Z' };//Assigns character values

            Console.WriteLine($"Within the array");
            foreach (var charToFind in charsToFind)
                Console.WriteLine("One or more names begin with '{0}': {1}",
                                  charToFind,
                                  Array.Exists(names,//The first parameter is the array and the second parameter is pulling the character out of the string in the array
                                               s =>
                                               {
                                                   if (String.IsNullOrEmpty(s))//If the value is null or empty it will return false
                                                       return false;

                                                   if (s.Substring(0, 1).ToUpper() == charToFind.ToString())//Takes one input at the 0 index and if equal to the characters above then the value is true
                                                       return true;
                                                   else//I neither is true then it is false
                                                       return false;
                                               }));
            //Reference: https://docs.microsoft.com/en-us/dotnet/api/system.array.exists?view=netframework-4.8 

            Console.WriteLine("Press enter to continue");
            Console.ReadLine();



            //Method 4: Array.Find<T>(T[], Predicate<T>) Method

            // Create an array of five Point structures.
            //Useing System drawings
            Point[] points = { new Point(100, 200),
            new Point(150, 250), new Point(250, 375),
            new Point(275, 395), new Point(295, 450) };

            // Find the first Point structure for which X times Y 
            // is greater than 100000. 
            Point first = Array.Find(points, p => p.X * p.Y > 100000);

            // Display the first structure found.
            Console.WriteLine("Found: X = {0}, Y = {1}", first.X, first.Y);
            //Reference: https://docs.microsoft.com/en-us/dotnet/api/system.array.find?view=netframework-4.8

            Console.WriteLine("\nPress Enter to Continue to my Example");
            Console.ReadLine();

            Console.WriteLine("\nMy Example");

            //My Example:
            string[] mooreFamNames = { "Tyler", "Trevor", "Tarra", "Tanner", "Amanda" };
            Console.WriteLine("\nMy Array:");
            foreach (var item in mooreFamNames)
            {
                Console.Write("{0},\n", item);
            }
            Console.WriteLine("In my array I searched for the name that started with 'A'");
            string mooreFinder = Array.Find(mooreFamNames, namees => namees.StartsWith("A", StringComparison.Ordinal));
            Console.WriteLine(mooreFinder);

            //Method 5: StartsWith(String)
            string[] strSource = { "<b>This is bold text</b>", "<H1>This is large Text</H1>",
                "<b><i><font color=green>This has multiple tags</font></i></b>",
                "<b>This has <i>embedded</i> tags.</b>",
                "<This line simply begins with a lesser than symbol, it should not be modified" };

            // Display the initial string array.
            Console.WriteLine("The original strings:");
            Console.WriteLine("---------------------");
            foreach (var s in strSource)
                Console.WriteLine(s);
            Console.WriteLine();

            Console.WriteLine("Strings after starting tags have been stripped:");
            Console.WriteLine("-----------------------------------------------");

            // Display the strings with starting tags removed.
            foreach (var s in strSource)
                Console.WriteLine(StripStartTags(s));
            //Reference: https://docs.microsoft.com/en-us/dotnet/api/system.string.startswith?view=netframework-4.8#System_String_StartsWith_System_String_ 

            Console.WriteLine("\nPress Enter to Continue to my Example");
            Console.ReadLine();
            //My Example
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("\nMy Example\nI send the array through the four loop\nto find the name that starts with 'A'");
            string[] burchFamName = { "Amanda", "Jordan", "Dan", "Mel" };
            for (int i = 0; i < burchFamName.Length; i++)
            {

                Console.WriteLine("Inside my other Array: {0}", burchFamName[i]);


            }
            Console.WriteLine();

            Console.WriteLine("\nMy Example\nI send the array through the four loop\nto find the name that starts with 'A'\nAnswer:");

            for (int i = 0; i < burchFamName.Length; i++)
            {
                burchFamName[i].ToUpper();
                if (burchFamName[i].StartsWith("A"))
                    Console.WriteLine(burchFamName[i]);
            }

            Console.WriteLine("-----------------------------------------------");


            //NameSpace : System.Math Methods

            //Method 1: Absolute Value Method
            Console.WriteLine("\nThis example shows the:\nMath.Abs Method\n------------------------------ ");

            int[] values = { Int32.MaxValue, 16921, 0, -804128, Int32.MinValue };
            foreach (int value in values)
            {
                try
                {
                    Console.WriteLine($"Abs({value}) = {Math.Abs(value)}");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Unable to calculate the absolute value of {0}.",
                                      value);
                }
            }

            Console.WriteLine("\nPress Enter to Continue");
            Console.ReadLine();

            Console.WriteLine("\nThis example shows the:\nMath.BigMul(Int32, Int32) Method\n------------------------------ ");
            //Reference: https://docs.microsoft.com/en-us/dotnet/api/system.math.abs?view=netframework-4.8 

            //Method 2: Math.BigMul(Int32, Int32) Method
            int int1 = Int32.MaxValue;
            int int2 = Int32.MaxValue;
            long longResult;
            //
            longResult = Math.BigMul(int1, int2);
            Console.WriteLine("Calculate the product of two Int32 values:");
            Console.WriteLine("{0} * {1} = {2}", int1, int2, longResult);

            /*This example produces the following results:
            Calculate the product of two Int32 values:
            2147483647 * 2147483647 = 4611686014132420609*/

            Console.WriteLine("\nPress Enter to Continue");
            Console.ReadLine();
            //Reference:  https://docs.microsoft.com/en-us/dotnet/api/system.math.bigmul?view=netframework-4.8
            //
            //This is an example that determines wich int variable is the highest.

            //Method 3: Math.Max() Method
            Console.WriteLine("\nThis example shows the:\nMath.Max Method\n------------------------------ ");
            int num1 = 45;
            int num2 = 54;
            Console.WriteLine("Between the numbers {0} and {1}: {2} is the highest", num2, num1, Math.Max(num1, num2));
            //Reference:https://docs.microsoft.com/en-us/dotnet/api/system.math.max?view=netframework-4.8#System_Math_Max_System_UInt32_System_UInt32_ 

            Console.WriteLine("\nPress Enter to Continue");
            Console.ReadLine();

            //Method 4: Math.Min() Method
            //This is an example that determines wich int variable is the lowest.
            Console.WriteLine("\nThis example shows the:\nMath.Min Method\n------------------------------ ");
            Console.WriteLine("Between the numbers {0} and {1}: {2} is the lowest", num1, num2, Math.Min(num1, num2));
            //Reference: https://docs.microsoft.com/en-us/dotnet/api/system.math.min?view=netcore-3.1#System_Math_Min_System_Int32_System_Int32_

            Console.WriteLine("\nPress Enter to Continue");
            Console.ReadLine();

            //Method 5: Math.Sqrt() Method
            double mydub = 2911231;
            Math.Sqrt(mydub);
            Console.WriteLine("\nThis example shows the:\nMath.Sqrt Method\n------------------------------ ");
            Console.WriteLine("The number {0} is the square root of {1}", Math.Sqrt(mydub), mydub);
            //Reference: https://docs.microsoft.com/en-us/dotnet/api/system.math.sqrt?view=netcore-3.1 

        }


        //Methods for Midterm Project
        private static string StripStartTags(string item)
        {
            //Used for 5th Example
            // Determine whether a tag begins the string.
            if (item.Trim().StartsWith("<"))
            {
                // Find the closing tag.
                int lastLocation = item.IndexOf(">");
                // Remove the tag.
                if (lastLocation >= 0)
                {
                    item = item.Substring(lastLocation + 1);

                    // Remove any additional starting tags.
                    item = StripStartTags(item);
                }
            }

            return item;
        }
        public static void PrintValues(IEnumerable myList)
        {
            foreach (Object obj in myList)
                Console.WriteLine("   {0}", obj);
            Console.WriteLine();
        }
        public static void PrintValues(IEnumerable myList, char mySeparator)
        {
            foreach (Object obj in myList)
                Console.Write("{0}{1}", mySeparator, obj);
            Console.WriteLine();
        }
        public static void PrintIndexAndValues(ArrayList myList)
        {
            int i = 0;
            foreach (Object o in myList)
                Console.WriteLine("\t[{0}]:\t{1}", i++, o);
            Console.WriteLine();


        }
        public static void PrintIndexAndValues(String[] myArr)
        {
            for (int i = 0; i < myArr.Length; i++)
                Console.WriteLine("\t[{0}]:\t{1}", i, myArr[i]);
            Console.WriteLine();
        }


    }
}
