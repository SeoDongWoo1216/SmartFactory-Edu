// �л��� �̸��� ������ �Է¹޾� ����� ����ϴ� ���α׷�
#include <stdio.h>
#pragma warning(disable:4996)
#define MAX_NAME 20

struct STUDENT 
{
	char	m_name[MAX_NAME];
	int		m_eng;
	int		m_math;
	float	m_average;

};

int main2(void) {
	struct STUDENT std;
	printf("�л� �̸� �Է� : ");
	
	//scanf("%s", std.m_name, MAX_NAME - 1);
	//gets(std.m_name);

	fgets(std.m_name, MAX_NAME, stdin);
	std.m_name[strlen(std.m_name) - 1] = 0;  
	// fgets�� ���͸� ���������Ƿ� �����ڸ��� = 0���� null�� �ٲ���
	// strlen�� ���ڿ� ���� �������ִ� �Լ�


	printf("���� ���� �Է� : ");
	fflush(stdin);
	scanf("%d", &std.m_eng);

	printf("���� ���� �Է� : ");
	fflush(stdin);
	scanf("%d", &std.m_math);

	std.m_average = (float)(std.m_eng + std.m_math) / 2;

	printf("\n�л� �̸� : %s\n", std.m_name);
	printf("��� ���� : %6.3f\n", std.m_average);
}




struct Test
{
	int a;
	int b;
};

int main() 
{
	struct Test aTest;
	struct Test* pTest;

	aTest.a = 100;
	aTest.b = 200;
	pTest = &aTest;
	
	printf("aTest.a : %d\n", aTest.a);
	printf("aTest.b : %d\n\n", aTest.b);

	printf("aTest->a : %d\n", pTest->a);
	printf("aTest->b : %d\n\n", pTest->b);

	printf("aTest Size : %d\n", sizeof(aTest));
	printf("pTest Size : %d\n\n", sizeof(pTest));

	return 0;
}