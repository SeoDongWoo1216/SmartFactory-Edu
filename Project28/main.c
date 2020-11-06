#include <stdio.h>
#pragma warning(disable:4996)

// 유니온은 제일 큰 자료형 하나만 공간을 할당하고 작은 애들과 같이쓴다
typedef union MyUnion
{
	int    a;
	short  b;
	char   c;

	char   d[4];  // 같은 4바이트 용량을 선언하면 뭐가 출력될까?
}MyUnion;

int main()
{
	MyUnion aMyUnion;
	
	aMyUnion.a = 0x12345678;
	//aMyUnion.b = 0x3333;
	//aMyUnion.c = 0x22;

	printf("aMyUnion.a : [%p]\n", aMyUnion.a);
	printf("aMyUnion.b : [%p]\n", aMyUnion.b);
	printf("aMyUnion.c : [%p]\n\n", aMyUnion.c);

	// d 출력
	printf("aMyUnion.d : [%p]\n", aMyUnion.d[0]);
	printf("aMyUnion.d : [%p]\n", aMyUnion.d[1]);
	printf("aMyUnion.d : [%p]\n", aMyUnion.d[2]);
	printf("aMyUnion.d : [%p]\n", aMyUnion.d[3]);

	return 0;
}