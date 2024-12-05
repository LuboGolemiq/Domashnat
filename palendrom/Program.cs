namespace palendrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] chr = word.ToCharArray();
            Stack<char> stk = new Stack<char>(chr);
            Array.Reverse(chr);
            Stack<char> reversedword = new Stack<char>();
            Print(stk, reversedword);

        }
        static void Print(Stack<char> stk, Stack<char> reversedword)
        {
            for (int i = 0; i < stk.Count; i++)
            {
                if (stk.Pop() != reversedword.Pop())
                {
                    Console.WriteLine("dumata ne e palendrom");
                    break;
                }

                if (i == stk.Count)
                {
                    Console.WriteLine("dumata e palendrom");
                }
            }
        }
    }
}
