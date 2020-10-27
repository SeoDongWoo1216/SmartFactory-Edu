#include <stdio.h>
int main() 
{
	// ABCDEFG는 코드영역에 저장되있다.
	// Stack 영역의 str이 저장되고, 포인터니까 ABCDEFG를 가리킨다
	// Stack 영역에서 arr은 7바이트로 ABCDEFG가 저장되어있다
	// str[0] = 'Z'; 을 해주면
	// *(str + 0); 과 같은데, 이때 Z를 넣으라고 했기때문에 코드영역의 값을 수정하려고했으므로 프로그램이 뻑난다,
	// arr[0] = 'Z' 는 스택영역에서 값을 수정하는 것이기때문에 Z를 대입해서 값을 바꿀 수 있다.

	// char* str은 가리키는 포인터 4바이트, 코드영역의 7바이트를 사용해서 총 11바이트 사용
	// char arr[]은 스택에 7바이트, 코드영역의 7바이트를 사용해서 14바이트를 사용

	// arr[]이 안전하지만 메모리 용량을 더 잡아먹기때문에 사용용도에 따라 사용해야한다


	char* str = "ABCDEFG";
	char arr[] = "ABCDEFG";  // 똑같은 문자열이면 컴파일러가 1개만 만든다.
	//char arr[] = "ABCDEFG1";   // 근데 이렇게 1을 붙여주면 ABCDEG1을 또 만들어서 메모리 공간낭비가 된다.
	
	printf("%c\n", str[0]); 
	printf("%c\n\n", arr[0]);  
	
	str[0] = 'Z';  // 프로그램 뻑이남
	//arr[0] = 'Z';

	printf("str[%s]\n", str);
	printf("arr[%s]\n", arr);
	return 0;
}

int main2() 
{
	int A = 100;
	int* p = &A;

	/*int B = 200;
	int iArray[2];*/

	printf("%d\n", *p);
	printf("%d\n", *(p + 0));
	printf("%d\n", p[0]);
	printf("%d\n", p[1]);  // A보다 4바이트만큼 띄운 값을 출력 => 지금은 쓰레기값 출력

	//p = &B;        // p는 변수니까 바꿀 수 있다.
	//iArray = &B;   // iArray는 상수니까 바꿀 수 없다.
	//iArray = 100;  // iArray의 타입이 int[] 타입이므로 타입이 다르므로 대입불가
	// C에서는 배열이 주소니까 대입할 생각은 하지말아야한다.


	return 0;
}

int main3() {
	//int A = 0x12345678;
	int iArray[5] = {100, 101, 102, 103, 104};
	int* ap = iArray;
	//int B = 0xABCDEF12;
	
	printf("%d\n", iArray[0]);
	printf("%d\n", *(iArray + 0));
	printf("%d\n", *(ap + 0));
	printf("%d\n", ap[0]);

	// 주소
	printf("-------------주소-----------\n");
	printf("%d\n", &iArray[0]);
	printf("%p\n", iArray + 0);
	printf("%p\n", iArray + 1);
	printf("%p\n", iArray + 2);
	printf("%p\n", iArray + 3);
	printf("%p\n\n", iArray + 4);

	// 값
	printf("-------------값-------------\n");
	printf("%d\n", iArray[0]);
	printf("%d\n", *(iArray + 0));
	printf("%d\n", *(iArray + 1));
	printf("%d\n", *(iArray + 2));
	printf("%d\n", *(iArray + 3));
	printf("%d\n", *(iArray + 4));
}