#include <stdio.h>
#pragma warning(disable:4996)

// ���Ͽ��� ���� ū �ڷ��� �ϳ��� ������ �Ҵ��ϰ� ���� �ֵ�� ���̾���
typedef union MyUnion
{
	int    a;
	short  b;
	char   c;

	char   d[4];  // ���� 4����Ʈ �뷮�� �����ϸ� ���� ��µɱ�?
}MyUnion;

int main()
{
	MyUnion aMyUnion;
	
	aMyUnion.a = 0x12345678;
	//aMyUnion.b = 0x3333;
	//aMyUnion.c = 0x22;

	printf("aMyUnion.a : [%p]\n", aMyUnion.a);
	printf("aMyUnion.b : [%p]\n", aMyUnion.b);
	printf("aMyUnion.c : [%p]\n\n", aMyUnion.c);

	// d ���
	printf("aMyUnion.d : [%p]\n", aMyUnion.d[0]);
	printf("aMyUnion.d : [%p]\n", aMyUnion.d[1]);
	printf("aMyUnion.d : [%p]\n", aMyUnion.d[2]);
	printf("aMyUnion.d : [%p]\n", aMyUnion.d[3]);

	return 0;
}