#include <stdio.h>
#pragma warning(disable: 4996) // 전처리언어, 해킹당하든말든 쓰겠다. 라는 뜻

int main(void) 
{
	int a = 0;
	int b = 0;

	++a;
	b++;
	printf("a = %d, b = %d \n", a, b);

	b = a++;
	printf("a = %d, b = %d \n", a, b);

	printf("a = %d, b = %d \n", a++, b++);
	printf("a = %d, b = %d \n", a, b);

	return 0;
	//////////////////////////////////////////////////////////

	//int a = 0;
	//int b = 1;
	//int o = 1;
	//printf("a < b && o > a 결과 : %d \n", a < b && o > a);
	//printf("a > b && o > a 결과 : %d \n", a > b && o > a);
	//printf("a < b || o > a 결과 : %d \n", a < b || o > a);
	//printf("괄호를 사용하는게 좀 더 깔끔할듯\n");
	//printf("(a < b) || (o > a) 결과 : %d \n", (a < b) || (o > a));

	///////////////////////////////////////////////////////////

	/*int a = 0;
	int b = 1;
	printf("논리 연산 1 && 2 의 결과 : %d \n", 1 && 2);
	printf("논리 연산 0 && 2 의 결과 : %d \n", 0 && 2);
	printf("논리 연산 0 || 2 의 결과 : %d \n", 0 || 2);
	printf("논리 연산 0 || 0 의 결과 : %d \n", 0 || 0);
	printf("논리 연산 !a 의 결과 : %d \n", !a);
	printf("논리 연산 !b 의 결과 : %d \n", !b);*/

	////////////////////////////////////////////////////////////
	
	//int a = 10;
	//int b = 20;

	//printf("[%d > %d] 결과 : %d\n", a, b, a > b);
	//printf("[%d < %d] 결과 : %d\n", a, b, a < b);
	//printf("[%d >= %d] 결과 : %d\n", a, b, a >= b);
	//printf("[%d <= %d] 결과 : %d\n", a, b, a <= b);
	//printf("[%d == %d] 결과 : %d\n", a, b, a == b);
	//printf("[%d != %d] 결과 : %d\n", a, b, a != b);


	//int A;
	//// 호환성이 떨어진다는 단점이 있다.
	//scanf_s("%d", &A);  // &는 엔퍼샌드라고 부른다.
	//printf("A = %d\n", A);

	//////////////////////////////////////////////////////

	//int x, y;
	//printf("두개의 정수를 입력하세요 : ");
	//scanf("%d %d", &x, &y);

	//printf("x+y = %d\n", x + y);
	//printf("x-y = %d\n", x - y);
	//printf("x*y = %d\n", x * y);
	//printf("x/y = %.2f\n", (float)x / y);
	//printf("x%y = %d\n", x % y);

	//////////////////////////////////////////////////

	//// sizeof 복습. sizeof은 int로 반환된다.
	//// C에서 sizeof는 연산자이다.(함수나 메서드가 아니다)

	//printf("int형의 크기 : %d\n", sizeof(4));
	//printf("float형의 크기 : %d\n", sizeof(float));
	//printf("double형의 크기 : %d\n\n", sizeof(double));

	//printf("4의 크기 : %d\n", sizeof(4));
	//printf("1000의 크기 : %d\n", sizeof(1000));
	//printf("3.14의 크기 : %d\n", sizeof(3.14)); // double형
	//printf("3.14f의 크기 : %d\n", sizeof(3.14f)); // float형
	
	////////////////////////////////////////////////////////////
	//char a;
	//int i;
	//double d;
	//float f;
	//printf("a의 크기 : %d\n", sizeof(a));
	//printf("i의 크기 : %d\n", sizeof(i));
	//printf("d의 크기 : %d\n", sizeof(d));
	//printf("f의 크기 : %d\n", sizeof(f));
	
	///////////////////////////////////////////////

	return 0;
}