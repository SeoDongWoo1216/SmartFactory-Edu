﻿// data 리스트에서 20보다 큰 짝수를 내림차순으로 정렬하여 저장
// 이 값을 2씩 곱해서 오름차순으로 정렬하여 저장
using System;
using System.Collections.Generic;
using System.Linq;

namespace _20200821_005_LinQ_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int> { 123, 34, 12, 89, 456, 1, 4, 74, 46 };

            Print("data : ", data);

            var lstEven = from item in data
                          where (item > 20 && item % 2 == 0)
                          orderby item descending
                          select item;

            Print("20보다 큰 짝수 검색결과: ", lstEven);

            var lstSorted = from item in lstEven
                            orderby item ascending
                            select item * 2;

            Print("2를 곱해서 오름차순 정렬: ", lstSorted);
        }

        private static void Print(string s,IEnumerable<int> data)
        {
            Console.WriteLine(s);
            foreach (var i in data)
                Console.Write(" " + i);
            Console.WriteLine();
        }
    }
}