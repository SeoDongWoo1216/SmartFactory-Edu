using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
    
}
class Program
{
    public static void solution(string s)
    {
        bool answer = true;
        char[] a = s.ToCharArray();
        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] == '0')
                continue;
            else if (a[i] == '1')
                continue;
            else if (a[i] == '2')
                continue;
            else if (a[i] == '3')
                continue;
            else if (a[i] == '4')
                continue;
            else if (a[i] == '5')
                continue;
            else if (a[i] == '6')
                continue;
            else if (a[i] == '7')
                continue;
            else if (a[i] == '8')
                continue;
            else if (a[i] == '9')
                continue;
            else
                answer = false;
        }
        //return answer;
        Console.WriteLine(answer);
    }
    static void Main(string[] args)
    {
        string s = "123412";
        solution(s);


    }
}


///*
//        프로그래머스 모바일은 개인정보 보호를 위해 고지서를 보낼 때 고객들의 전화번호의 일부를 가립니다.
//        전화번호가 문자열 phone_number로 주어졌을 때, 전화번호의 뒷 4자리를 제외한 나머지 숫자를 
//        전부 *으로 가린 문자열을 리턴하는 함수, solution을 완성해주세요.
//        phone_number	return
//        01033334444  *******4444
//        027778888	   *****8888
//         */

//string a = Console.ReadLine();
//char[] b = a.ToCharArray();
//        for (int i = 0; i<(a.Length) - 4; i++)
//        {
//            b[i] = '*';
//         }
//        Console.WriteLine(b);



/*
         int n = 12;
        int j = 0;
        for (int i = 1; i <=n; i++) 
        { 
        if(n%i == 0)
            { 
                j += i;
            }
            
        }
        Console.WriteLine(j);

 */




/*
         이 문제에는 표준 입력으로 두 개의 정수 n과 m이 주어집니다.
        별(*) 문자를 이용해 가로의 길이가 n, 세로의 길이가 m인 직사각형 형태를 출력해보세요.
    */
/*
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
        for (int i=0; i<b; i++)
        {
            for(int j=0; j<a; j++) 
            { 
               Console.Write("*");
            }
            Console.WriteLine();
        }
 */
