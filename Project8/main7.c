#include <stdio.h>
#pragma warning(disable: 4996) 
int main(void) {

	goto TEST2;

TEST1:
	printf("1\n");
TEST2:
	printf("2\n");
	goto TEST1;





	//int lot;

	//printf("��÷ ��ȣ�� �Է��ϼ���: ");
	//scanf("%d", &lot);

	//switch (lot) {
	//case 11:
	//	printf("1�� : 10��\n");
	//	break;
	//case 22:
	//	printf("2�� : 3��\n");
	//	break;
	//case 33:
	//	printf("3�� : 10��\n");
	//	break;
	//default:
	//	printf("��÷��ȣ�� �����ϴ�.\n");
	//	break;
	//}
}

//int main2(void) 
//{
	//int num;

	//printf("������ �Է��Ͻÿ� : ");
	//scanf("%d", &num);
	//if (num % 2) {
	//	printf("%d�� Ȧ�� �Դϴ�. \n", num);
	//}
	//else
	//{
	//	printf("%d�� ¦�� �Դϴ�. \n", num);
	//}

	//double avg;
	//char grade;
	//printf("��������� �Է��ϼ��� : ");
	//scanf("%lf", &avg);
	//if (avg >= 90.0) grade = 'A';
	//else if (avg >= 80.0) grade = 'B';
	//else if (avg >= 70.0) grade = 'C';
	//else grade = 'F';

	//printf("������ %c�Դϴ�. \n", grade);
	//return 0;


//
//	float A = 0.5;
//
//
//	if (-1) {
//		printf("1");
//	}
//	else {
//		printf("2");
//	}
//}






//int main(void) {
	/*������ �Է¹޾� ������ ���, ����� ������ ����ϴ� ���α׷�*/
	/*-7�Է��ϸ� 7, 29�� �ԷµǸ� -29�� ��µ�. ��Ʈ���� ������*/

	/*int iNum;
	printf("���� 1���� �Է��ϼ��� : ");
	scanf_s("%d", &iNum);
	printf("�Է��� ���� �ݴ� ��ȣ : %d\n", ~iNum+1);
	printf("�Է��� ���� �ݴ� ��ȣ : %d\n", iNum*(-1));
	printf("�Է��� ���� �ݴ� ��ȣ : %d\n", -iNum);*/


	/*�Է¹��� ���� �������� ����ϴ� ���α׷� �ۼ�*/
	// (�ݵ�� ��Ʈ ���� ������ ���)
	//
	//int iNum = 0;
	//printf("���� 1���� �Է��ϼ��� : ");
	//scanf_s("%d", &iNum);
	//printf("�Է��� ������ ���� �� : %d", iNum<<1);


	/*���� �� �ΰ��� �Ժ��޾Ƽ�, ���� ������ 
	���� �������� ũ�� 1, ������ 0, ������ -1�� ����ϴ� ���α׷� �ۼ�*/
	/*int iNum1, iNum2;
	int Com;
	printf("���� 2���� �Է��ϼ��� : ");
	scanf_s("%d %d", &iNum1, &iNum2);
	Com = (iNum1 > iNum2) ? 1 : (iNum1 < iNum2) ? -1 : 0;
	printf("\nũ�� 1, ������ -1, ������ 0 �� ��µ˴ϴ�. ==> ");
	printf("%d\n", Com);*/



	/*�ΰ��� ���ڸ� �Է¹޾�, �����Ǵ� ��Ʈ���� ���ϴ� ���α׷�
	���� ��Ʈ�� ���� ��� �� ��Ʈ�� ��ȣ ���(��Ʈ�������̿�)*/

	//char a = 'a';
	//char b = 'O';
	//printf("%x %x\n", a, b);
	//printf("%x \n", a^b);
	//printf("%x \n", ~(a ^ b));
//}