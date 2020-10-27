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

	//printf("당첨 번호를 입력하세요: ");
	//scanf("%d", &lot);

	//switch (lot) {
	//case 11:
	//	printf("1등 : 10억\n");
	//	break;
	//case 22:
	//	printf("2등 : 3억\n");
	//	break;
	//case 33:
	//	printf("3등 : 10억\n");
	//	break;
	//default:
	//	printf("당첨번호가 없습니다.\n");
	//	break;
	//}
}

//int main2(void) 
//{
	//int num;

	//printf("정수를 입력하시오 : ");
	//scanf("%d", &num);
	//if (num % 2) {
	//	printf("%d는 홀수 입니다. \n", num);
	//}
	//else
	//{
	//	printf("%d는 짝수 입니다. \n", num);
	//}

	//double avg;
	//char grade;
	//printf("평균점수를 입력하세요 : ");
	//scanf("%lf", &avg);
	//if (avg >= 90.0) grade = 'A';
	//else if (avg >= 80.0) grade = 'B';
	//else if (avg >= 70.0) grade = 'C';
	//else grade = 'F';

	//printf("학점은 %c입니다. \n", grade);
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
	/*정수를 입력받아 음수면 양수, 양수면 음수로 출력하는 프로그램*/
	/*-7입력하면 7, 29가 입력되면 -29가 출력됨. 비트단위 연산사용*/

	/*int iNum;
	printf("정수 1개를 입력하세요 : ");
	scanf_s("%d", &iNum);
	printf("입력한 수의 반대 부호 : %d\n", ~iNum+1);
	printf("입력한 수의 반대 부호 : %d\n", iNum*(-1));
	printf("입력한 수의 반대 부호 : %d\n", -iNum);*/


	/*입력받은 값의 제곱값을 계산하는 프로그램 작성*/
	// (반드시 비트 단위 연산자 사용)
	//
	//int iNum = 0;
	//printf("정수 1개를 입력하세요 : ");
	//scanf_s("%d", &iNum);
	//printf("입력한 정수의 제곱 값 : %d", iNum<<1);


	/*정수 값 두개를 입벽받아서, 앞의 정수가 
	뒤의 정수보다 크면 1, 같으면 0, 작으면 -1을 출력하는 프로그램 작성*/
	/*int iNum1, iNum2;
	int Com;
	printf("정수 2개를 입력하세요 : ");
	scanf_s("%d %d", &iNum1, &iNum2);
	Com = (iNum1 > iNum2) ? 1 : (iNum1 < iNum2) ? -1 : 0;
	printf("\n크면 1, 작으면 -1, 같으면 0 이 출력됩니다. ==> ");
	printf("%d\n", Com);*/



	/*두개의 문자를 입력받아, 대응되는 비트끼리 비교하는 프로그램
	대응 비트가 같은 경우 그 비트의 번호 출력(비트연산자이용)*/

	//char a = 'a';
	//char b = 'O';
	//printf("%x %x\n", a, b);
	//printf("%x \n", a^b);
	//printf("%x \n", ~(a ^ b));
//}