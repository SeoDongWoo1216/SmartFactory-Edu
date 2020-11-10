#include <stdio.h>
#pragma warning(disable:4996)

int Add(int, int);
int Input(void);
void PrintResult(int);
void Intro(void);

int main(void) 
{
	int a, b;
	int ret;

	Intro();
	a = Input();
	b = Input();

	ret = Add(a, b);
	PrintResult(ret);
	return 0;
}

int Add(int a, int b)
{
	return a + b;
}

int Input(void)
{
	int input;
	scanf("%d", &input);
	return input;
}

void PrintResult(int val)
{
	printf("덧셈에 대한 결과 : %d\n", val);
	printf("*********END*********\n");
}

void Intro(void) 
{
	printf("*********START*********\n");
	printf("두 개의 정수 입력 : \n");
}



/*
int test(int i1, int i2) 
{
	return i1 + i2;
}

int main()
{
	int t1;
	int t2;
	char* p = "[%d][%d]\n";

	t1 = test(5, 6);
	t2 = 5 + 3;
	printf(p, t1, t2);

	return 0;
}
*/