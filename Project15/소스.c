#include <stdio.h>
void TTTtest() 
{
	// �׳� �׽�Ʈ������ ���� �޼���
	printf("TTTtest\n");
}
int main() 
{
	//// ������ �뷫���� �ּҸ� �˰�ʹ�.
	//int a; // stack
	//int b; // stack
	//int c; // stack


	//printf("Stack %p\n", &a);
	//printf("Stack %p\n", &b);
	//printf("Stack %p\n\n", &c);


	//// �Լ�(�޼���)�� �����Ϳ����� �ִ�.
	//// main �̸���ü�� �ּ��̴�(����̴�)
	//// C#������ ��������Ʈ
	//printf("Code  %p\n", main);  // main�� �ּ� ���
	//printf("Code  %p\n", printf);
	//printf("Code  %p\n", scanf_s);
	//printf("Code  %p\n", TTTtest); // ���Ƿ� ���� �޼��� �ּ� ���
	//printf("Code  %p\n", "Hello World");  // ���ڿ��� �ּ� ���
	//printf("Code  %p\n\n", "Hello World1");
	////������ ��������, �޼���� �޼��峢�� �ּҰ� ����ϴ�.
 //   // Code ������ �޼���, ����� ����ǰ�, �б⸸ �����ϴ�.

	char* p = 0x00415020;
	printf("%02X\n", *p); // *p�� ���� 2�ڸ� 16������ ���

	// *p�� main�� �ּ��ε� �б⸸ ������ �ڵ念���̴�.
	// �׷��� �����Ϸ����ϸ� ���α׷��� ���������־ �����찡 �̸� ���ϴ� ����.
	*p = 0x55;  // �̰� �ִ� ���� �����찡 ©�� End�� �ȳ���

	printf("End\n");

	return 0;
}


//void main() {
//	//int n = 10;
//	//int* p1 = &n;
//	//int* p2 = p1;
//
//	//printf("%d\n", (*p1)++);
//	//printf("%d\n", (*p2)++);
//	//printf("%d\n", n);
//
//	///////////////////////////////////
//
//	int a = 1;
//	int b = 10;
//	int c = 20;
//
//	(*(a ? &b : &c))++;  // ���׿�����
//
//	printf("a : %d\n", a);
//	printf("b : %d\n", b);
//	printf("c : %d\n", c);
//	
//}