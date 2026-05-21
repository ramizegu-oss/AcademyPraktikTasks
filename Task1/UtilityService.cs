using System.Reflection.Metadata.Ecma335;

namespace ClassInTheAcademy.Task1
{
    internal class UtilityService
    {
        public string word;
        public int[] arrInt;
        public int VowelsLettersCount()
        {
            char[] volwesletters = ['a','e','u','i','o','y'];
            int count = 0;


            foreach (char item in word.ToLower())
            {
                if (volwesletters.Contains(item))
                {
                    count++;
                }
                else
                {
                    continue;
                }
            }
            return count;
            
        }



        public string StrReverse()
        {
            char[] arrWord = word.ToArray();

            var res = arrWord.Reverse();


            return string.Concat(res);
        }



        public int MediumValue()
        {
            int sum = 0;

            foreach (var item in arrInt)
            {
                sum += item;
            }
           return sum / arrInt.Length;
        }


        public int BiggestElem()
        {
            int BiggestValue = arrInt[0];
            for (int i = 1; i < arrInt.Length; i++)
            {
                if (arrInt[i] > BiggestValue)
                {
                    BiggestValue = arrInt[i];
                    
                }

            }
            return BiggestValue;
        }


        public void CutElem()
        {
            foreach (var item in arrInt)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine(item);
                }
                else
                {
                    continue;
                }
            }
            
        }



        public bool Palindrome()
        {

            char[] wordArr = word.ToCharArray();
            Array.Reverse(wordArr);



            if (word == string.Concat(wordArr))
            {
                word.ToString();
                return true;
            }
            else
            {
                return false;
            }
        }


        public int CheckBigLetter()
        {
            int count = 0;

            int res = word.Count(m =>  char.IsUpper(m));

            return res;
           
            
        }



        public int CountLes()
        {

            int count = 0;
            foreach (var item in arrInt)
            {
                if (item < 0)
                {
                    count++;
                }
                else
                {
                    continue;
                }
            }
            return count;
        }


        public bool Equals()
        {
            Console.WriteLine("Input second text");
            string word2 = Console.ReadLine();
            if (word.ToLower() == word2.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void Unick()
        {
            
            


            

        }
    }
}
