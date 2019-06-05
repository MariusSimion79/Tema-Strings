using System;
using System.Text;

namespace Strings_final
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoveCharFromString();
            //RemoveOddChar();
            //ChangeChase();
            //ReversedString();
            //RemoveNewLine();
            //FormatString();
            //Console.WriteLine(FormatAsPercentage());
            //ReverseString();
            //StripChar();
            //ToLowerCaseNCharacters();
            //CapitaliseFirstAndLast();
            //SumOfDigits();
            //EliminateChar();
            //SuffixingString();
            //ObfurcateEmail();
            //ReString();
            //ReplaceChars();
            //SwapChars();
            //FindAndReplace();
            //LongestWord();
            //GetLastPart();
            //CheckIfStart();
            //CountSubstringOccurence();
            //SwapCommaAndDot();
            //RemoveSpaces();
            //Palindrome();

        }

        #region 01 REMOVE n-th CHARACTER FROM A STRING
        // Write a method that to remove the nth index character from a nonempty string.
        public static void RemoveCharFromString()
        {
            Console.Write("Please enter a string: ");
            string myString = Console.ReadLine();


            Console.Write($"Please enther the n-th index (between 0 and {myString.Length - 1}) that you want to remove: ");
            int indexToRemove = int.Parse(Console.ReadLine());

            if (indexToRemove.ToString() == "")
            {
                Console.WriteLine($"You didn`t enter an index between 0 and {myString.Length - 1}.");
            }
            else
            {
                myString = myString.Remove(indexToRemove, 1);
                Console.WriteLine(myString);
            }
        }
        #endregion

        #region 02 REMOVE CHARACTER FROM ODD INDEX
        //Write a method that to remove the characters which have odd index values of a given string.
        public static void RemoveOddChar()
        {
            Console.Write("Please enter a string: ");
            string myString = Console.ReadLine();

            int oddIndex = 0;

            StringBuilder newString = new StringBuilder();
            while (oddIndex < myString.Length)
            {
                if (oddIndex % 2 == 0)
                {
                    newString.Append(myString[oddIndex]);
                }
                oddIndex++;
            }
            Console.WriteLine(newString);
        }
        #endregion

        #region 03 CONVERT TO UPPER OR TO LOWER
        //Write a method that takes input from the user and displays that input back in upper and lower cases.

        public static void ChangeChase()
        {
            Console.Write("Please enter a string: ");
            string myString = Console.ReadLine();
            while (myString == "")
            {
                Console.Write("Please enter a longer string: ");
                myString = Console.ReadLine();
            }

            Console.WriteLine(myString.ToUpper());
            Console.WriteLine(myString.ToLower());
        }

        #endregion

        #region 04 REVERSE A STRING IF LENGTH IS MULTIPLE OF 4
        // Write a method that reverses a string if it's length is a multiple of 4
        public static void ReversedString()
        {
            Console.Write("Please enter a string: ");
            string myString = Console.ReadLine();
            if (myString.Length % 4 != 0)
            {
                Console.WriteLine($"String`s length is not an multiple of 4! The string remain {myString}");
            }
            else
            {
                StringBuilder reversedString = new StringBuilder();
                int stringIndex = (myString.Length - 1);

                while (stringIndex >= 0)
                {
                    reversedString.Append(myString[stringIndex]);
                    stringIndex--;
                }
                Console.WriteLine(reversedString);
            }
        }


        #endregion

        #region 05 CONVERT TO UPPER A STRING IF CONTAIN 2 UPPER CHARS IN FIRST 4 CHARS
        // Write method to convert a given string to all uppercase if it contains at least 2 uppercase characters in the first 4 characters.
        public static void CheckUpper()
        {
            Console.Write("Please enter a string: ");
            string myString = Console.ReadLine();
            int checkUpper = 0;
            int index = 0;
            while ((index >= 0) && (index < 4))
            {
                string c = myString[index].ToString();
                string cUp = c.ToUpper();
                if (c == cUp)
                {
                    checkUpper++;
                }
                index++;
            }
            if (checkUpper >= 2)
            {
                Console.WriteLine(myString.ToUpper());
            }
            else
            {
                Console.WriteLine(myString);
            }
        }


        #endregion

        #region 06 REMOVE A NEWLINE
        // Write a method that to remove a newline.
        public static void RemoveNewLine()
        {
            string myString = "If \nyou\n can rea\nd this, the co\nde is OK!";
            Console.WriteLine($"Your string is: {myString}");

            string newString = myString.Replace("\n", "");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine($"Your string is now:  {newString}");
        }


        #endregion

        #region 07 DISPLAY FORMATTED TEXT
        // Write a method to display formatted text (width=50) as output. 
        // For example: If I have a text that's 134 characters long, the formatted string should have maximum of 50 characters 
        // per line. In this case we will have 3 lines of text.
        public static void FormatString()
        {
            string myString = "111111111122222222223333333333444444444455555555556666666666777777777788888888889999999999000000000011111111112222222222333333333344444444445555555555666666666677777777778888888888999999999900000000001111111111222222222233333333334444444444555555555566666666667777777777888888888899999999990000000000";
            Console.WriteLine($"Your unformatted string is: \n{myString}");


            StringBuilder newString = new StringBuilder();
            int myStringLength = myString.Length;
            int rowLength = 50;
            int startIndex = 0;
            while (myStringLength >= rowLength)
            {
                newString.Append(myString.Substring(startIndex, 50));
                newString.Append("\n");
                startIndex += rowLength;
                myStringLength -= rowLength;
            }
            Console.WriteLine("=============================================================================");
            Console.WriteLine($"Your formatted string is: \n{newString}");
        }
        #endregion

        #region 08 FORMAT A NUMBER AS PERCENTAGE
        // Write a method that formats a number with a percentage
        static string FormatAsPercentage()
        {
            Console.Write("Please enter a number: ");
            decimal myNumber = decimal.Parse(Console.ReadLine());
            return myNumber.ToString($"P{4}");
        }
        #endregion

        #region 09 REVERSE A STRING
        //Write a method that reverses a string.
        public static void ReverseString()
        {
            Console.Write("Please enter a string: ");
            string myString = Console.ReadLine();
            StringBuilder reversedString = new StringBuilder();
            int stringIndex = (myString.Length - 1);
            while (stringIndex >= 0)
            {
                reversedString.Append(myString[stringIndex]);
                stringIndex--;
            }
            Console.WriteLine(reversedString); ;
        }
        #endregion

        #region 10 STRIP CHARACTERS FROM STRING
        // Write a method that strips a set of characters from a string.
        public static void StripChar()
        {
            string myString = "~!If #y$#o$%u ^&%c&%^$a#$n r#$e#$ad t!*^%hi#$s, ~t#%h#$e $^m&^et$%^&ho$%^d w$%or#$%^ke%$%^^d f%$%%in%^#e";
            Console.WriteLine($"Your string currently looks like: \n{myString}");
            Console.Write("Please enter the charater that you want to eliminate: ");
            string forbiddenChars = Console.ReadLine();
            int myStringLength = myString.Length;
            string myStrippedString = myString;

            for (int i = 0; i < myStringLength; i++)
            {
                while (forbiddenChars != "")
                {

                    myStrippedString = myStrippedString.Replace(forbiddenChars, "");
                    Console.WriteLine($"Your stripped string is now: \n{myStrippedString}");
                    Console.WriteLine();
                    Console.Write("Please enter the charater that you want to eliminate: ");
                    forbiddenChars = Console.ReadLine();
                    Console.WriteLine();
                }
            }
            Console.WriteLine($"Your stripped string is finally looking as: \n{myStrippedString}");
        }
        #endregion

        #region 11 TRANSFORM TO LOWERCASE FIRST n CHAR
        // Write a method that transforms to lowercase first n characters in a string
        public static void ToLowerCaseNCharacters()
        {
            Console.Write("Please enter a string in UpperCase: ");
            string myString = Console.ReadLine();

            Console.Write("Please enter how many characters you want to transform to LowerCase: ");
            int stringIndex = int.Parse(Console.ReadLine());
            while (stringIndex > myString.Length)
            {
                Console.Write("Please re-enter how many characters you want to transform to LowerCase: ");
                stringIndex = int.Parse(Console.ReadLine());
            }
            StringBuilder convertedString = new StringBuilder();
            string mySubstring1 = myString.Substring(0, stringIndex);
            int myStringLength = myString.Length;
            string mySubstring2 = myString.Substring((stringIndex), (myStringLength - (stringIndex)));

            convertedString.Append(mySubstring1.ToLower());
            convertedString.Append(mySubstring2);
            Console.WriteLine($"Your string is now looking as: ");
            Console.WriteLine(convertedString);
        }
        #endregion

        #region 12 CAPITALIZE THE FIRST AND THE LAST
        // Write a method to capitalize first and last letters of each word of a given string.
        public static string CleanMyString()
        {
            string myString = "If you write an application that accepts input from an user, you can never be sure what case he or she will use to enter the data.";
            string myCleanString = myString.Replace(",", string.Empty);
            myCleanString = myCleanString.Replace(".", string.Empty);
            return myCleanString;
        }
        public static void CapitaliseFirstAndLast()
        {
            string myString = CleanMyString();
            StringBuilder newString = new StringBuilder();
            string[] myArray = myString.Split(" ");
            foreach (var word in myArray)
            {
                if (word.Length <= 2)
                {
                    newString.Append(word.ToUpper());
                    newString.Append(" ");
                }
                else
                {
                    newString.Append(word[0].ToString().ToUpper());
                    newString.Append(word.Substring(1, word.Length - 2));
                    newString.Append(word[word.Length - 1].ToString().ToUpper());
                    newString.Append(" ");
                }
            }

            Console.WriteLine(newString);
        }
        #endregion

        #region 13 COMPUTE SUM OF ALL DIGITS
        // Write a method to compute sum of digits of a given string (if any).
        public static void SumOfDigits()
        {
            Console.Write("Please enter a string: ");
            string myString = Console.ReadLine();
            if (myString.Length > 19)
            {
                Console.WriteLine("Please enter a string with maximum 19 chars: ");
                myString = Console.ReadLine();
            }
            int sum = 0;
            int i = 0;
            while (i < myString.Length)
            {
                if (char.IsDigit(myString[i]))
                {
                    sum += int.Parse(myString[i].ToString());
                }
                i++;
            }
            Console.WriteLine($"Sum of entered numbers in your string is: {sum}");
        }
        #endregion

        #region 14 CLEAN THE TEXT
        /*Clean the text
        You will get a text from where you will need to clean the text because it contains a lot of strange characters that don’t belong there( ^ <, > &+ @%$)

        Input:
        Hi^>there<<I’m+ telling%%you, you &need% to$ do& your $homeworks.@Hate ^me^ %now% and %thank% me &later.
        Output:
        Hi there I’m telling you, you need to do your homeworks.Hate me now and thank me later.*/

        public static void EliminateChar()
        {
            string myString = "Hi^>there<<I’m+ telling%%you, you &need% to$ do& your $homeworks. @Hate ^me^ %now% and %thank% me &later.";
            Console.WriteLine($"Your string currently looks like: \n{myString}");

            string[] forbiddenChars = new string[] { "^", ">", "+", "<", "%", "$", "&", "@" };

            foreach (var character in forbiddenChars)
            {
                myString = myString.Replace(character, " ");
                myString = myString.Replace("  ", " ");
            }
            Console.WriteLine(myString);
        }


        #endregion

        #region 15 ING, LY
        /*Ing, ly
        Write a method to add 'ing' at the end of a given string (length should be at least 3). If the given string already ends with 'ing' then add 'ly' instead. If the string length of the given string is less than 3, leave it unchanged.
        Input : 'abc'
        Output : 'abcing' 
        Input : 'string'
        Output: 'stringly'*/

        public static void SuffixingString()
        {
            Console.Write("Enter your string: ");
            string myString = Console.ReadLine();
            string suffixedString = "";
            int index = myString.Length - 1;
            int i = index;
            string last = "";
            string last3 = "";
            while ((index - i < 3) && (i >= 0))
            {
                last = myString[i].ToString();
                last3 += last;
                i--;
            }
            if (last3 == "gni")
            {
                suffixedString = myString + "ly";
            }
            else
            {
                suffixedString = myString + "ing";
            }
            Console.Write("Your suffixed string is:  ");
            Console.WriteLine(suffixedString);
        }
        #endregion

        #region 16 OBFURCATE EMAIL
        /*Obfucate Email
        You have some text that contains your email address. And you want to hide that. 
        You decide to censor your email: to replace all characters in it with asterisks ('*') except the domain. 
        Assume your email address will always be in format [username]@[domain]. 
        You need to replace the username with asterisks of equal number of letters and keep the domain unchanged. 
        You will get as input the email address you need to obfuscate

        Input: awesome@dotnet.com
        Output: *******@dotnet.com*/
        public static void ObfurcateEmail()
        {
            Console.Write("Please enter your e-mail address: ");
            string eMail = Console.ReadLine();
            StringBuilder obfurcatedEmail = new StringBuilder();
            eMail.IndexOf("@");

            string user = eMail.Substring(0, eMail.IndexOf("@"));
            string domain = eMail.Substring(eMail.IndexOf("@"));

            foreach (var letter in user)
            {
                user = user.Replace(letter, '*');
            }

            obfurcatedEmail.Append(user);
            obfurcatedEmail.Append(domain);
            Console.WriteLine(obfurcatedEmail);
        }
        #endregion

        #region 17 RE-STRING
        /*Re-string
        Write a method to get a string made of the first 2 and the last 2 chars from a given a string. 
        If the string length is less than 2, return instead of the empty string.

        Sample String : “w3resource”
        Expected Result :”'w3ce”
        Sample String :”w3”
        Expected Result : “w3w3”
        Sample String : “w”
        Expected Result : Empty String */
        public static void ReString()
        {
            Console.Write("Please enter your string: ");
            string myString = Console.ReadLine();
            string resultedString = "";
            int i = 0;
            int j = myString.Length - 2;
            string letter = "";

            if (myString.Length < 2)
            {
                resultedString = "Empty String";
            }
            else
            {
                while (i < 2)
                {
                    letter = myString[i].ToString();
                    resultedString = resultedString + letter;
                    i++;
                }
                while (j < myString.Length)
                {
                    letter = myString[j].ToString();
                    resultedString = resultedString + letter;
                    j++;
                }
            }
            Console.WriteLine($"You string is now:  {resultedString}.");
        }

        #endregion

        #region 18 REPLACE CHAR
        /*Replace Char
        Write a method to get a string from a given string where all occurrences of its first char have been changed to '$', 
        except the first char itself.
        Sample String : 'restart'
        Expected Result : 'resta$t'
        */
        public static void ReplaceChars()
        {
            Console.Write("Please enter your string: ");
            string myString = Console.ReadLine();
            string[] words = myString.Split(" ");
            StringBuilder finalString = new StringBuilder();
            string firstLetter = "";
            string restOfWord = "";
            foreach (var element in words)
            {
                firstLetter = element[0].ToString();
                restOfWord = element.ToString().Substring(1);
                restOfWord = restOfWord.Replace(firstLetter, "$");
                finalString.Append(firstLetter);
                finalString.Append(restOfWord);
                finalString.Append(" ");
            }
            Console.WriteLine(finalString);
        }
        #endregion

        #region 19 GET A SINGLE STRING FROM 2 STRINGS, AND SWAP CHARS
        /* Write a method to get a single string from two given strings, separated by a space and swap the first two characters of each string.
        Input: 'abc', 'xyz' 
        Output: 'xyc abz'
        */
        public static void SwapChars()
        {
            Console.Write("Please enter the string 1: ");
            string myString1 = Console.ReadLine();

            Console.Write("Please enter the string 2: ");
            string myString2 = Console.ReadLine();

            string firstLettersOfString1 = "";
            string lastLettersOfString1 = "";
            string firstLettersOfString2 = "";
            string lastLettersOfString2 = "";
            int i = 0;
            int j = 2;

            while (i < 2)
            {
                firstLettersOfString1 += myString1[i];
                firstLettersOfString2 += myString2[i];
                i++;
            }

            while (j < myString1.Length)
            {
                lastLettersOfString1 += myString1[j];
                j++;
            }
            j = 2;
            while (j < myString2.Length)
            {
                lastLettersOfString2 += myString2[j];
                j++;
            }

            string finalString = firstLettersOfString2 + lastLettersOfString1 + " " + firstLettersOfString1 + lastLettersOfString2;
            Console.WriteLine(finalString);
        }
        #endregion

        #region 20 FIND THE FIRST APPEARANCE OF THE STRING AND REPLACE IT
        /* Write a method to find the first appearance of the substring 'not' and 'poor' from a given string.
         * if 'not' is before 'poor', replace the whole 'not'...'poor' substring with 'good'. Return the resulting string.

        Input: 'The lyrics is not that poor!'
        Output : 'The lyrics is good!'

        Input  : 'The lyrics is poor!'
        Output : 'The lyrics is poor!'
         */
        public static void FindAndReplace()
        {
            Console.WriteLine("Please enter your string: ");
            string myString = Console.ReadLine();
            int indexOfNot = myString.IndexOf("not");
            int indexOfPoor = myString.IndexOf("poor");
            Console.WriteLine(indexOfNot);
            Console.WriteLine(indexOfPoor);
            if (indexOfNot < indexOfPoor)
            {
                myString = myString.Replace("not that poor", "good");
                Console.WriteLine(myString);
            }
            else
            {
                Console.WriteLine(myString);
            }
        }
        #endregion

        #region 21 LONGEST WORD
        /*Write a method that takes a list of words and returns the length of the longest one.*/
        public static void LongestWord()
        {
            Console.WriteLine("Please enter your string: ");
            string myString = Console.ReadLine();


            string[] words = myString.Split(new[] { " " }, StringSplitOptions.None);
            string longestWord = "";
            int counter = 0;
            foreach (var word in words)
            {
                if (word.Length > counter)
                {
                    longestWord = word;
                    counter = word.Length;
                }
            }
            Console.WriteLine($"The longest word from your string is: {longestWord}\n His length is {longestWord.Length} characters.");
        }
        #endregion

        #region 22 GET THE LAST PART OF A STRING
        /* Write a method to get the last part of a string before a specified character.

            Input :  https://www.siit.com/net-exercises
                      -
            Output:  https://www.siit.com/net   */

        public static void GetLastPart()
        {
            Console.Write("Please enter your string: ");
            string myString = Console.ReadLine();
            Console.Write("Please enter the separator char: ");
            string separator = Console.ReadLine();
            int separatorIndex = myString.IndexOf(separator);

            myString = myString.Substring(0, separatorIndex);
            Console.WriteLine(myString);
        }
        #endregion

        #region 23 CHECK IF A STRING STARTS WITH SPECIFIED CHARS
        /*Write a method to check whether a string starts with specified characters
         input: awesome string
                a
         output : Yes, starts with a
         */
        public static void CheckIfStart()
        {
            Console.Write("Please enter your string: ");
            string myString = Console.ReadLine();
            if (myString == "")
            {
                Console.WriteLine("Please enter your string with at least one character: ");
                myString = Console.ReadLine();
            }
            Console.WriteLine("Please enter your character to check: ");
            string toCheck = Console.ReadLine();

            if (myString[0].ToString() == toCheck)
            {
                Console.WriteLine($"Yes, starts with {toCheck}");
            }
            else
            {
                Console.WriteLine($"No, your string doesn`t start with {toCheck}");
            }
        }
        #endregion

        #region 24 COUNT OCCURENCE OF A SUBSTRING IN A STRING
        /*Write a method to count occurrences of a substring in a string
            input: alabala portocala
                    ala
            output : 3
            */
        public static void CountSubstringOccurence()
        {
            Console.Write("Please enter a string: ");
            string myString = Console.ReadLine();
            Console.Write("Please enter a substring to check for occurence: ");
            string toCheck = Console.ReadLine();

            string newString = myString.Replace(toCheck, "");

            int count = (myString.Length - newString.Length) / toCheck.Length;

            if (count == 0)
            {
                Console.WriteLine($"The substring {toCheck} was not found in your string.");
            }
            else
            {
                Console.WriteLine($"The substring <<{toCheck}>> was found {count} times in your string");
            }

        }
        #endregion

        #region 25 SWAP COMMA AND DOT
        /*  Write a method to swap comma and dot in a string.
            Input: "32.054,23"
            Output: "32,054.23"     */
        public static void SwapCommaAndDot()
        {
            Console.Write("Please enter your numeric strig: ");
            string myString = Console.ReadLine();
            string letter = "";
            string myNewString = "";
            int i = 0;
            while (i < myString.Length)
            {
                letter = myString[i].ToString();
                if (letter == ".")
                {
                    letter = ",";
                }
                else if (letter == ",")
                {
                    letter = ".";
                }
                else
                {

                }
                myNewString += letter;
                i++;
            }
            Console.WriteLine($"Your string is now: {myNewString}");
        }



        #endregion

        #region 26 REMOVE SPACES FROM A STRING
        /*Write a method to remove spaces from a given string.*/
        public static void RemoveSpaces()
        {
            Console.Write("Please enter your string: ");
            string myString = Console.ReadLine();
            myString = myString.Replace(" ", "");
            Console.WriteLine($"Your string is now: {myString}");
        }
        #endregion

        #region 27 CHECK IF A STRING IS PALINDROME
        /*Check if a string is palindrome(same value read from left to right and right to left) Ex: alabala -> True*/
        public static void Palindrome()
        {
            Console.WriteLine("Please enter your string: ");
            string myString = Console.ReadLine();
            string reversedString;

            char[] c = myString.ToCharArray();
            Array.Reverse(c);
            reversedString = new string(c);
            bool b = myString.Equals(reversedString, StringComparison.OrdinalIgnoreCase);
            if (b == true)
            {
                Console.WriteLine($"{myString} is a palindrome");
            }
            else
            {
                Console.WriteLine($"{myString} is not a palindrome");
            }


        }



        #endregion



    }
}
