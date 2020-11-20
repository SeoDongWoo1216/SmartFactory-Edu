#include <stdio.h>
#pragma warning(disable:4996)

#define PI 3.14159
#define SQUARE(x) ((x)*(x))

int main(void)
{
	double radius;
	printf("반지름을 입력하세요 : ");
	scanf("%lf", &radius);
	printf("원의 면적은 : %.2lf\n", PI * SQUARE(radius));
	return 0;
}








enum {SUM = 43, SUB = 45, MUL = 42, DIV = 47};

#define FSUM(x,y) x+y
#define FSUB(x,y) x-y
#define FMUL(x,y) x*y
#define FDIV(x,y) x/y

int main2(void)
{
	int a, b;
	int ret = 0;
	char opcode;

	/*puts("두 개의 정수를 입력 : ");*/
	printf("두 개의 정수를 입력 : ");
	scanf("%d %d", &a, &b);

	puts("연산자 입력(+,-,*,/) : ");
	fflush(stdin);
	scanf("%c", &opcode);

	switch (opcode) {
	case SUM:
		ret = FSUM(a, b);
		break;
	case SUB:
		ret = FSUB(a, b);
		break;
	case MUL:
		ret = FMUL(a, b);
		break;
	case DIV:
		if (!a || !b)
			ret = 0;
		else
			ret = FDIV(a, b);
		break;
	default:
		puts("잘못된 연산자 사용");
		return 0;
	}

	printf("연산결과는 %d 입니다.\n", ret);
	return 0;
}