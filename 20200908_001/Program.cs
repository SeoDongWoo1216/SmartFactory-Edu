//암호화 예제(헬로를 XOR시켜서 암호화를 실습해보자)
using System;
    class Program
    {
        static void Main(string[] args)
        {
            string PlainText = "반도"; 
            char[] PlainTextArray = PlainText.ToCharArray();
            char Key = (char)0x0908;   // 오른쪽의 정수를 char로 캐스팅 

            string CyperText;
            char[] CyperTextArray;
            CyperTextArray = new char[PlainTextArray.Length];
            CyperTextArray[0] = (char)(PlainTextArray[0] ^ Key); // PlainText와 Key를 XOR화
            CyperTextArray[1] = (char)(PlainTextArray[1] ^ Key);

            CyperText = CyperTextArray.ToString();
            Console.WriteLine("PlainTextArray : {0}{1}", PlainTextArray[0], PlainTextArray[1]); // 원래 데이터 출력
            Console.WriteLine("CyperTextArray : {0}{1}", CyperTextArray[0], CyperTextArray[1]); // 데이터를 암호호화한 값 출력

            char[] PlainTextArray2 = new char[CyperTextArray.Length];  // 암호화해제를 위해 새로운 문자배열객체 생성
            PlainTextArray2[0] = (char)(CyperTextArray[0] ^ Key); // PlainText와 Key를 다시 XOR
            PlainTextArray2[1] = (char)(CyperTextArray[1] ^ Key);
            Console.WriteLine("PlainTextArray2 : {0}{1}", PlainTextArray2[0], PlainTextArray2[1]);
        }
    }
