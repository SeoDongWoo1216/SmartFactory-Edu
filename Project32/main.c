#include <stdio.h>
#pragma warning(disable:4996)

#define PI 3.14159
#define SQUARE(x) ((x)*(x))

int main(void)
{
	double radius;
	printf("�������� �Է��ϼ��� : ");
	scanf("%lf", &radius);
	printf("���� ������ : %.2lf\n", PI * SQUARE(radius));
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

	/*puts("�� ���� ������ �Է� : ");*/
	printf("�� ���� ������ �Է� : ");
	scanf("%d %d", &a, &b);

	puts("������ �Է�(+,-,*,/) : ");
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
		puts("�߸��� ������ ���");
		return 0;
	}

	printf("�������� %d �Դϴ�.\n", ret);
	return 0;
}