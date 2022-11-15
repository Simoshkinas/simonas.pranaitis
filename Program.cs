
public class Readingfiles
{


    public static void Main()
    {
        StreamReader src = new StreamReader("Data.txt");

        while (!src.EndOfStream)
        {
            string line = src.ReadLine();
            char[] charArr = line.ToCharArray();
            string compressedLine; 
            int numOfRep = 0;
            char c;
            List<char> chars = new List<char>();

            for (int i = 0; i < charArr.Length; i++)
            {
                c = charArr[i];
                chars.Add(charArr[i]);

                if (chars[i] == charArr[i])
                {
                  numOfRep++;

                }
            }
            //Console.WriteLine(numOfRep + c);
        }

    }
}
