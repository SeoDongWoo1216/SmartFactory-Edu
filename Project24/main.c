#include <stdio.h>


int main2()
{
	int a = 100;

	{
		int a = 101;
		printf("%d\n", a);
	}
	printf("%d\n", a);

	return 0;
}

// ���������� ��� ����ֱ⶧���� �޸��� �뷮�� ��� �����ϰ� �ִ�.
// �׷��� ������ ũ�⿡ ������ ��ģ��.
int b1 = 101;      // �ʱ�ȭ�ϸ� Data �������� ����.
int b2;            // �ʱ�ȭ���ϸ� BSS �������� ����.
int b3 = 103;
int b4;
int b5 = 105;

char TTTT[1024 * 1024] = {'A', };  // 1MB�� char �迭 ����


// ���������� �� �޼��尡 ������ �޸𸮿� �Ҵ�� ������ �ױ⶧���� �޸� �뷮
int main()
{
	int a1 = 101;
	int a2 = 102;
	int a3 = 103;
	int a4 = 104;
	int a5 = 105;

	printf("Stack Adress : %p\n", &a1);     // �Լ��� ����(��������)
	printf("Stack Adress : %p\n", &a2);
	printf("Stack Adress : %p\n", &a3);
	printf("Stack Adress : %p\n", &a4);
	printf("Stack Adress : %p\n\n", &a5);

	printf("Code  Adress : %p\n", main);     // �Լ�(�޼���), ��� �� Text ����
	printf("Code  Adress : %p\n", printf);
	printf("Code  Adress : %p\n\n", "ABC");

	printf("Data  Adress : %p\n", &b1);    // ���� ���� (BSS, Data ����)
	printf("Data  Adress : %p\n", &b2);
	printf("Data  Adress : %p\n", &b3);
	printf("Data  Adress : %p\n", &b4);
	printf("Data  Adress : %p\n\n", &b5);
}