#include<stdio.h>
#pragma warning(disable:4996)

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

	(*pTest).a = 500;   // �� ���� �Ȱ��� �ڵ��̴�.(�ӵ��� �Ȱ���)
	pTest->a = 500;

	// Part 3 : 100�� ����ϴ� 5���� ���
	printf("Value   : (*pTest)    .a [%d]\n", (*pTest).a); // ȭ��ǥ�� �켱������ ���⶧���� ���������� ()ó���ϰ�(���ϸ� �������� ó��) . ���� �ؾ���
	printf("Value   : pTest      ->a [%d]\n", pTest->a);
	printf("Value   : aTest       .a [%d]\n", aTest.a);
	printf("Value   : 0x0019FED4)->a [%d]\n", ((struct Test*)0x0019FED4)->a);
	printf("Value   : 0x0019FED4) .a [%d]\n\n", (*((struct Test*)0x0019FED4)).a);

	// Part 2
	printf("////////////////////////////////////////\n\n");
	printf("Address : aTest [%p]\n", &aTest);
	printf("Value   : pTest [%p]\n", pTest);
	printf("Value   : 0x0019FED4 ->a [%d]\n", ((struct Test*)0x0019FED4)->a);
	printf("Value   : pTest      ->a [%d]\n\n", pTest->a);
	
	// Part 1
	printf("////////////////////////////////////////\n\n");
	printf("aTest.a : %d\n", aTest.a);
	printf("aTest.b : %d\n\n", aTest.b);
	printf("aTest->a : %d\n", pTest->a);
	printf("aTest->b : %d\n\n", pTest->b);
	printf("aTest Size : %d\n", sizeof(aTest));
	printf("pTest Size : %d\n\n", sizeof(pTest));
	
	return 0;
}


#define MAX_INFO 3

struct PIMS
{
	char m_name[20];
	char m_tel[20];

};


int main2(void) 
{
	struct PIMS pArray[MAX_INFO];
	int idx;

	for(idx = 0; idx != MAX_INFO; idx++)
	{
		printf("�̸�, ��ȭ��ȣ ������ �Է� : \n");
		scanf("%19s %19s", pArray[idx].m_name, pArray[idx].m_tel);
	}

	for (idx = 0; idx != MAX_INFO; idx++)
	{
		printf("�̸� : %-19s, ��ȭ��ȣ : %-19s\n", pArray[idx].m_name, pArray[idx].m_tel);
	}

	return 0;
}