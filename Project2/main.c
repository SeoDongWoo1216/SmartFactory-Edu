#pragma warning(disable: 4996) 
#include <stdio.h>

//int main1(void) {
//	int a, b;
//	float f;
//
//	a = 123;
//	b = -12;
//	f = 123.4567;
//
//	printf("*1234567890*\n");
//	printf("%5d*\n", a+b);
//	printf("*%7d*\n", b);
//	printf("*%8.2f*\n", f);
//}

//int main2(void) {
//	int num;
//	char ch;
//	float fnum;
//
//	printf("�� ���� ���� �Է��Ͻÿ� : [����][����][�Ǽ�]\n");
//
//	//scanf("%d %c %f", &num, &ch, &fnum);
//
//	scanf("%d %c %f",&num, &ch, &fnum );
//
//	printf("�Է¿� ���� ��� : [���� = %d] [���� = %5c] [�Ǽ� = %f]\n",
//									num, ch, fnum);
//	return 0;
//}

//int main3(void) {
//	int num1 = 0;
//	int num2 = 0;
//	int num3 = 0;
//	printf("3���� ������ �Է��Ͻÿ�(0�̻� 6�̸��̳�) : ");
//	scanf_s("%d %d %d", &num1, &num2, &num3);
//	printf("���� : %d \n", num1 + num2 + num3);
//	printf("��� : %.1f \n", (float)(num1 + num2 + num3)/3);
//}

//int main4(void) {
//	int BirthYear = 0;
//	int TargetYear = 0;
//
//	printf("�¾ ������? : ");
//	scanf("%d", &BirthYear);
//
//	printf("��� ������? : ");
//	scanf("%d", &TargetYear);
//
//	printf("����� %d���϶� ���̴� %d�� �Դϴ�.",BirthYear,(TargetYear - BirthYear));
//}

//int main5(void) {
//	int iNum = 0;
//	printf("������ ������ �Է��ϼ��� : ");
//	scanf("%d", &iNum);
//	printf("%d �� ������ ������ %d �Դϴ�.\n", iNum, iNum * iNum);
//}

int main(void) {
	int iNum1 = 0;
	int iNum2 = 0;
	int iNum3 = 0;
	printf("3���� ������ �Է��ϼ��� : ");
	scanf("%d %d %d", &iNum1, &iNum2, &iNum3);
	
	printf("(a-b)*(b+c)*(c%%a)�� ��� : %d \n", (iNum1-iNum2)*(iNum2+iNum3)*(iNum3%iNum1));
}