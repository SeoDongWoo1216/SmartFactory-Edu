using System;
class Program
{
    static void Main(string[] args)
    {
        int n = 7;
        string answer = "수박";
        if(n%2 == 0) 
        {
            for(int i = 0; i<n/2; i++)
            {
                Console.Write(answer);
            }
        }

        else 
        {
            for(int j = 0; j<n/2; j++)
            {
                Console.Write(answer);
            }
            Console.Write("수");
        }
    }
}