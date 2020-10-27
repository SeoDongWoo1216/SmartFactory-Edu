#include <stdio.h>
void TTTtest() 
{
	// 그냥 테스트용으로 만든 메서드
	printf("TTTtest\n");
}
int main() 
{
	//// 스택의 대략적인 주소를 알고싶다.
	//int a; // stack
	//int b; // stack
	//int c; // stack


	//printf("Stack %p\n", &a);
	//printf("Stack %p\n", &b);
	//printf("Stack %p\n\n", &c);


	//// 함수(메서드)는 데이터영역에 있다.
	//// main 이름자체가 주소이다(상수이다)
	//// C#에서는 델리게이트
	//printf("Code  %p\n", main);  // main의 주소 출력
	//printf("Code  %p\n", printf);
	//printf("Code  %p\n", scanf_s);
	//printf("Code  %p\n", TTTtest); // 임의로 만든 메서드 주소 출력
	//printf("Code  %p\n", "Hello World");  // 문자열의 주소 출력
	//printf("Code  %p\n\n", "Hello World1");
	////변수는 변수끼리, 메서드는 메서드끼리 주소가 비슷하다.
 //   // Code 영역은 메서드, 상수가 저장되고, 읽기만 가능하다.

	char* p = 0x00415020;
	printf("%02X\n", *p); // *p의 값을 2자리 16진수로 출력

	// *p는 main의 주소인데 읽기만 가능한 코드영역이다.
	// 그래서 수정하려고하면 프로그램이 터질수도있어서 윈도우가 미리 컷하는 것임.
	*p = 0x55;  // 이거 넣는 순간 윈도우가 짤라서 End가 안나옴

	printf("End\n");

	return 0;
}


//void main() {
//	//int n = 10;
//	//int* p1 = &n;
//	//int* p2 = p1;
//
//	//printf("%d\n", (*p1)++);
//	//printf("%d\n", (*p2)++);
//	//printf("%d\n", n);
//
//	///////////////////////////////////
//
//	int a = 1;
//	int b = 10;
//	int c = 20;
//
//	(*(a ? &b : &c))++;  // 삼항연산자
//
//	printf("a : %d\n", a);
//	printf("b : %d\n", b);
//	printf("c : %d\n", c);
//	
//}