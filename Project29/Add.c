#include <stdio.h>
#pragma warning(disable:4996)

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
	printf("������ ���� ��� : %d\n", val);
	printf("*********END*********\n");
}

void Intro(void)
{
	printf("*********START*********\n");
	printf("�� ���� ���� �Է� : \n");
}