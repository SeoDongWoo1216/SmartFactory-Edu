#include <stdio.h>
#pragma warning(disable: 4996) // ��ó�����, ��ŷ���ϵ縻�� ���ڴ�. ��� ��

int main(void) 
{
	int a = 0;
	int b = 0;

	++a;
	b++;
	printf("a = %d, b = %d \n", a, b);

	b = a++;
	printf("a = %d, b = %d \n", a, b);

	printf("a = %d, b = %d \n", a++, b++);
	printf("a = %d, b = %d \n", a, b);

	return 0;
	//////////////////////////////////////////////////////////

	//int a = 0;
	//int b = 1;
	//int o = 1;
	//printf("a < b && o > a ��� : %d \n", a < b && o > a);
	//printf("a > b && o > a ��� : %d \n", a > b && o > a);
	//printf("a < b || o > a ��� : %d \n", a < b || o > a);
	//printf("��ȣ�� ����ϴ°� �� �� ����ҵ�\n");
	//printf("(a < b) || (o > a) ��� : %d \n", (a < b) || (o > a));

	///////////////////////////////////////////////////////////

	/*int a = 0;
	int b = 1;
	printf("�� ���� 1 && 2 �� ��� : %d \n", 1 && 2);
	printf("�� ���� 0 && 2 �� ��� : %d \n", 0 && 2);
	printf("�� ���� 0 || 2 �� ��� : %d \n", 0 || 2);
	printf("�� ���� 0 || 0 �� ��� : %d \n", 0 || 0);
	printf("�� ���� !a �� ��� : %d \n", !a);
	printf("�� ���� !b �� ��� : %d \n", !b);*/

	////////////////////////////////////////////////////////////
	
	//int a = 10;
	//int b = 20;

	//printf("[%d > %d] ��� : %d\n", a, b, a > b);
	//printf("[%d < %d] ��� : %d\n", a, b, a < b);
	//printf("[%d >= %d] ��� : %d\n", a, b, a >= b);
	//printf("[%d <= %d] ��� : %d\n", a, b, a <= b);
	//printf("[%d == %d] ��� : %d\n", a, b, a == b);
	//printf("[%d != %d] ��� : %d\n", a, b, a != b);


	//int A;
	//// ȣȯ���� �������ٴ� ������ �ִ�.
	//scanf_s("%d", &A);  // &�� ���ۻ����� �θ���.
	//printf("A = %d\n", A);

	//////////////////////////////////////////////////////

	//int x, y;
	//printf("�ΰ��� ������ �Է��ϼ��� : ");
	//scanf("%d %d", &x, &y);

	//printf("x+y = %d\n", x + y);
	//printf("x-y = %d\n", x - y);
	//printf("x*y = %d\n", x * y);
	//printf("x/y = %.2f\n", (float)x / y);
	//printf("x%y = %d\n", x % y);

	//////////////////////////////////////////////////

	//// sizeof ����. sizeof�� int�� ��ȯ�ȴ�.
	//// C���� sizeof�� �������̴�.(�Լ��� �޼��尡 �ƴϴ�)

	//printf("int���� ũ�� : %d\n", sizeof(4));
	//printf("float���� ũ�� : %d\n", sizeof(float));
	//printf("double���� ũ�� : %d\n\n", sizeof(double));

	//printf("4�� ũ�� : %d\n", sizeof(4));
	//printf("1000�� ũ�� : %d\n", sizeof(1000));
	//printf("3.14�� ũ�� : %d\n", sizeof(3.14)); // double��
	//printf("3.14f�� ũ�� : %d\n", sizeof(3.14f)); // float��
	
	////////////////////////////////////////////////////////////
	//char a;
	//int i;
	//double d;
	//float f;
	//printf("a�� ũ�� : %d\n", sizeof(a));
	//printf("i�� ũ�� : %d\n", sizeof(i));
	//printf("d�� ũ�� : %d\n", sizeof(d));
	//printf("f�� ũ�� : %d\n", sizeof(f));
	
	///////////////////////////////////////////////

	return 0;
}