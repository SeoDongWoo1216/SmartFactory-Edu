#include <stdio.h>
int main() 
{
	// ABCDEFG�� �ڵ念���� ������ִ�.
	// Stack ������ str�� ����ǰ�, �����ʹϱ� ABCDEFG�� ����Ų��
	// Stack �������� arr�� 7����Ʈ�� ABCDEFG�� ����Ǿ��ִ�
	// str[0] = 'Z'; �� ���ָ�
	// *(str + 0); �� ������, �̶� Z�� ������� �߱⶧���� �ڵ念���� ���� �����Ϸ��������Ƿ� ���α׷��� ������,
	// arr[0] = 'Z' �� ���ÿ������� ���� �����ϴ� ���̱⶧���� Z�� �����ؼ� ���� �ٲ� �� �ִ�.

	// char* str�� ����Ű�� ������ 4����Ʈ, �ڵ念���� 7����Ʈ�� ����ؼ� �� 11����Ʈ ���
	// char arr[]�� ���ÿ� 7����Ʈ, �ڵ念���� 7����Ʈ�� ����ؼ� 14����Ʈ�� ���

	// arr[]�� ���������� �޸� �뷮�� �� ��ƸԱ⶧���� ���뵵�� ���� ����ؾ��Ѵ�


	char* str = "ABCDEFG";
	char arr[] = "ABCDEFG";  // �Ȱ��� ���ڿ��̸� �����Ϸ��� 1���� �����.
	//char arr[] = "ABCDEFG1";   // �ٵ� �̷��� 1�� �ٿ��ָ� ABCDEG1�� �� ���� �޸� �������� �ȴ�.
	
	printf("%c\n", str[0]); 
	printf("%c\n\n", arr[0]);  
	
	str[0] = 'Z';  // ���α׷� ���̳�
	//arr[0] = 'Z';

	printf("str[%s]\n", str);
	printf("arr[%s]\n", arr);
	return 0;
}

int main2() 
{
	int A = 100;
	int* p = &A;

	/*int B = 200;
	int iArray[2];*/

	printf("%d\n", *p);
	printf("%d\n", *(p + 0));
	printf("%d\n", p[0]);
	printf("%d\n", p[1]);  // A���� 4����Ʈ��ŭ ��� ���� ��� => ������ �����Ⱚ ���

	//p = &B;        // p�� �����ϱ� �ٲ� �� �ִ�.
	//iArray = &B;   // iArray�� ����ϱ� �ٲ� �� ����.
	//iArray = 100;  // iArray�� Ÿ���� int[] Ÿ���̹Ƿ� Ÿ���� �ٸ��Ƿ� ���ԺҰ�
	// C������ �迭�� �ּҴϱ� ������ ������ �������ƾ��Ѵ�.


	return 0;
}

int main3() {
	//int A = 0x12345678;
	int iArray[5] = {100, 101, 102, 103, 104};
	int* ap = iArray;
	//int B = 0xABCDEF12;
	
	printf("%d\n", iArray[0]);
	printf("%d\n", *(iArray + 0));
	printf("%d\n", *(ap + 0));
	printf("%d\n", ap[0]);

	// �ּ�
	printf("-------------�ּ�-----------\n");
	printf("%d\n", &iArray[0]);
	printf("%p\n", iArray + 0);
	printf("%p\n", iArray + 1);
	printf("%p\n", iArray + 2);
	printf("%p\n", iArray + 3);
	printf("%p\n\n", iArray + 4);

	// ��
	printf("-------------��-------------\n");
	printf("%d\n", iArray[0]);
	printf("%d\n", *(iArray + 0));
	printf("%d\n", *(iArray + 1));
	printf("%d\n", *(iArray + 2));
	printf("%d\n", *(iArray + 3));
	printf("%d\n", *(iArray + 4));
}