#include <stdio.h>


int main2()
{
	int a = 100;

	{
		int a = 101;
		printf("%d\n", a);
	}
	printf("%d\n", a);

	return 0;
}

// 전역변수는 계속 살아있기때문에 메모리의 용량을 계속 차지하고 있다.
// 그래서 파일의 크기에 영향을 미친다.
int b1 = 101;      // 초기화하면 Data 영역으로 들어간다.
int b2;            // 초기화안하면 BSS 영역으로 들어간다.
int b3 = 103;
int b4;
int b5 = 105;

char TTTT[1024 * 1024] = {'A', };  // 1MB의 char 배열 생성


// 지역변수는 그 메서드가 끝나면 메모리에 할당된 변수도 죽기때문에 메모리 용량
int main()
{
	int a1 = 101;
	int a2 = 102;
	int a3 = 103;
	int a4 = 104;
	int a5 = 105;

	printf("Stack Adress : %p\n", &a1);     // 함수의 변수(지역변수)
	printf("Stack Adress : %p\n", &a2);
	printf("Stack Adress : %p\n", &a3);
	printf("Stack Adress : %p\n", &a4);
	printf("Stack Adress : %p\n\n", &a5);

	printf("Code  Adress : %p\n", main);     // 함수(메서드), 상수 등 Text 영역
	printf("Code  Adress : %p\n", printf);
	printf("Code  Adress : %p\n\n", "ABC");

	printf("Data  Adress : %p\n", &b1);    // 전역 변수 (BSS, Data 영역)
	printf("Data  Adress : %p\n", &b2);
	printf("Data  Adress : %p\n", &b3);
	printf("Data  Adress : %p\n", &b4);
	printf("Data  Adress : %p\n\n", &b5);
}