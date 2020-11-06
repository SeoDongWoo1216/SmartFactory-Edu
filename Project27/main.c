#include <stdio.h>
#pragma warning(disable:4996)

struct test
{
	int a;
	int b;
};

typedef struct test TEST;

typedef struct test1
{
	int a;
	int b;
} TEST1;



int main3()
{

	struct test aTest;
	TEST bTest;

	aTest.a = 100;
	bTest.a = 200;

	aTest = bTest;

	return 0;
}


////////////////////////////////////////////////////////
// typedef 올드타입 뉴타입;
typedef unsigned int aaaa;


int main1()
{
	aaaa num = 100; // unsigned int num = 100;
	unsigned int num2 = 200;

	printf("%d\n", num);
	num = num2;

	return 0;
}



////////////////////////////////////////////////////////

// 문자로 쓰는데 번호를 부여하고 싶을때 enum 방식을 사용한다.
typedef enum{SUN, MON, TUE, WED, THU, FRI, SAT} Days;
//                    0, 1, 2, 3, 4, 5, 6  순임

int main(void) {
	Days day = SUN;

	printf("요일 입력 >> ");  // 0~6 사이의 숫자 입력
	scanf("%d", &day);
	
	switch (day) 
	{
		case SUN:
			puts("Sunday");
			break;
		case MON:
			puts("Monday");
			break;
		case TUE:
			puts("Tuesday");
			break;
		case WED:
			puts("Wednesday");
			break;
		case THU:
			puts("Thursday");
			break;
		case FRI:
			puts("Friday");
			break;
		case SAT:
			puts("Saturday");
			break;
	}
	return 0;
}










