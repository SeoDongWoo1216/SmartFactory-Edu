#include <stdio.h>
//#pragma warning(disable:4996)

/*
enum {SUM = 43, SUB = 45, MUL = 42, DIV = 470};

int Sum(int, int);
int Sub(int, int);
int Mul(int, int);
int Div(int, int);

int main(void) {
	int a, b;
	int ret = 0;
	char opcode;

	puts("�ΰ��� ������ �Է��Ͻÿ� : ");
	scanf("%d %d", &a, &b);

	puts("�����ڸ� �Է��Ͻÿ�(+,-,*,/) : ");
	fflush(stdin);
	scanf("%c", &opcode);

	switch(opcode)
	{
		case SUM:
			ret = Add(a, b);
			break;
		case SUB:
			ret = Sub(a, b);
			break;
		case MUL:
			ret = Mul(a, b);
			break;
		case DIV:
			ret = Div(a, b);
			break;
		default:
			puts("�߸��� �����ڸ� �Է��߽��ϴ�.");
			return 0;
	}

	printf("���� ����� %d �Դϴ�.\n", ret);
	return 0;
}

int Add(int a, int b) 
{
	return a + b;
}
int Sub(int a, int b)
{
	return a - b;
}
int Mul(int a, int b)
{
	return a * b;
}
int Div(int a, int b)
{
	if (!a || !b)
		return 0;
	else
	return (int)a / b;
}
*/



// ���� ���� ȣ��
/*
void swap(int a, int b);

int main(void)
{
	int val1 = 10;
	int val2 = 20;
	printf("�ٲٱ� �� : %d, %d \n", val1, val2);
	swap(val1, val2);
	printf("�ٲ��� �� : %d, %d \n", val1, val2);
	return 0;
}



void swap(int a, int b)
{
	int temp = a;
	a = b;
	b = temp;
	printf("�ٲٴ� �� : %d, %d\n", a, b);
}
*/


// ������ ���� ȣ��
void swap(int *pa, int *pb);

int main(void)
{
	int val1 = 10;
	int val2 = 20;
	printf("�ٲٱ� �� : %d, %d \n", val1, val2);
	swap(&val1, &val2);
	printf("�ٲ��� �� : %d, %d \n", val1, val2);
	return 0;
}

void swap(int *pa, int *pb)
{
	int temp = *pa;
	*pa = *pb;
	*pb = temp;
	printf("�ٲٴ� �� : %d, %d\n", *pa, *pb);
}