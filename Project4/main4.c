#include <stdio.h>

//int main(void) {
//
//	float fNum = 6.125f;
//	printf("%f\n", fNum);
//	return 0;
//}

//int main(void) 
//{
//	int bonbong, bouns, total;          // ����, ���ʽ�, �Ѽ��Ծ�
//	double tax, real_income, tax_rate;  // ����, �Ǽ��Ծ�, ����
//	bonbong = 230;
//	bouns = 60;
//	printf("������ �Է��ϼ���(�ۼ�Ʈ) >>  ");
//	scanf("%lf", &tax_rate);  // Ű����� ���� �Է�
//	total = bonbong + bouns; // �� ���Ծ��� ���� + ���ʽ�
//	tax = total * (tax_rate/100);
//	real_income = total - tax;
//	printf("\n�� ���Ծ��� %.3lf �Դϴ�\n", real_income);
//
//	return 0;
//}

//int main(void) {
//
//	printf("������ ��� 100�� 10����, 8����, 16������ ����ϴ� ���α׷�\n");
//	printf("10���� : %#d, 8���� : %#o, 16���� : %#x\n\n", 100, 100, 100);
//
//	printf("������ ��� 100�� 10����, 8����, 16������ ����ϴ� ���α׷� #������\n");
//	printf("10���� : %d, 8���� :  %o, 16���� : %x\n\n", 100, 100, 100);
//
//	printf("������ ��� ũ�⸦ ����ϴ� ���α׷�\n");
//	printf("The size of int 67 is %3d\n", sizeof(67));
//	printf("The size of int 67L is %3d\n\n", sizeof(67.0));
//
//	// �ڷ����� ũ�Ⱑ ��� ����ϴ� ����
//	printf("�ڷ����� ũ�� ����\n");
//	printf("char : %d,  short : %d,    int : %d \n", sizeof(char), sizeof(short), sizeof(int));
//	printf("long : %d,  long int : %d, long long : %d \n", sizeof(long), sizeof(long int), sizeof(long long));
//	printf("float : %d, double : %d,   long double : %d \n", sizeof(float), sizeof(double), sizeof(long double));
//}

//int main() {
//	// 255���� ���� 10������ �Է¹޾� ȭ�鿡 ���ڷ� ����ϴ� ���α׷��� �ۼ��Ͻÿ�.
//
//	int iNum;
//	printf("255���� ���� ������ �Է��Ͻÿ� : ");
//	scanf("%d", &iNum);
//	printf("������ ASCII �ڵ� : %c\n", iNum);
//}

//int main() {
//	//�ﰢ���� ���̸� ���ϴ� ���α׷�
//	int Width, Hight;
//	printf("�غ��� ���̸� �Է��ϼ��� : ");
//	scanf("%d %d", &Width, &Hight);
//
//	int Sum = (Width * Hight) / 2;
//
//	printf("�ﰢ���� ���� : %d\n", Sum);
//}



//int main() {
//	// 3���� ����(���� 0�̻� 6�̸�)�� �Է¹޾� �׵��� ���հ� ����� ���
//	// ����� �Ҽ��� ��° �ڸ����� �ݿø��Ͽ� ���
//
//	int iNum1, iNum2, iNum3;
//	printf("3���� ������ �Է��ϼ���(���� 0�̻� 6�̸�) : ");
//	scanf("%d %d %d", &iNum1, &iNum2, &iNum3);
//
//	printf("���� : %d \n", (iNum1+iNum2+iNum3) );
//	printf("��� : %.2f \n", (float)(iNum1 + iNum2 + iNum3) / 3);
//}



//int main() {
//	//Ű����� ���ĺ� �ϳ��� �Է¹޾�, 
//	// �̸� �ҹ��ڳ� �빮�ڷθ� ��ȯ�Ͽ� ����ϴ� ���α׷� �ۼ�
//	char ch;
//	printf("���ĺ��� �ϳ� �Է��ϼ��� : ");
//	scanf("%c", &ch);
//
//	if (ch >= 'A' && ch <= 'Z') // �빮�� A~Z �ΰ�?
//	{
//		printf("\n�빮�ڸ� �Է��ϼ̽��ϴ�.\n");
//		printf("�ҹ��ڷ� ��ȯ : %c\n", ch + 32);
//	}
//	else if (ch >= 'a' && ch <= 'z') // �ҹ��� a~z�ΰ�?
//	{
//		printf("\n�ҹ��ڸ� �Է��ϼ̽��ϴ�.\n");
//		printf("�빮�ڷ� ��ȯ : %c\n", ch - 32);
//	}
//	else
//		printf("\n���ĺ��� �Է����� �����̽��ϴ�\n");
//}


//int main() {
//	//ȭ���µ��� �Է¹޾� �����µ��� ����ϴ� ���α׷��� �ۼ�
//	int iNum1;
//	printf("ȭ�� �µ�(��)�� �Է��ϼ��� : ");
//	scanf("%d", &iNum1);
//
//	int iNum2 = 1.8 * (float)(iNum1 - 32);
//	printf("���� �µ��� : %.2f�� �Դϴ�.\n", (float)iNum2);
//}