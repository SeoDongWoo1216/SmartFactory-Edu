using System;
using System.Collections.Generic;
namespace _20200821_001Array_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lstNames = new List<string>();     // List<string> 클래스의 인스턴스 lstNames를 생성
            lstNames.Add("dog");             // Add 메서드로 5개의 값을 리스트에 저장
            lstNames.Add("cow");
            lstNames.Add("rabbit");
            lstNames.Add("goat");
            lstNames.Add("sheep");
            lstNames.Sort();             // Sort() 메서드로 정렬
            foreach (string s in lstNames)    // 정렬된 리스트의 내용을 출력
                Console.Write(s + " ");
            Console.WriteLine();

            string[] arrNames = new string[100];  // 인덱스를 사용하여 5개의 값을 배열에 저장
            arrNames[0] = "dog";
            arrNames[1] = "cow";
            arrNames[2] = "rabbit";
            arrNames[3] = "goat";
            arrNames[4] = "sheep";
            Array.Sort(arrNames);         // Array.Sort(arrNames) 메서드를 사용하여 배열을 정렬
            foreach (var s in lstNames)   // 정렬된 배열의 내용을 출력
                Console.Write(s + " ");
            Console.WriteLine();
        }
    }
}