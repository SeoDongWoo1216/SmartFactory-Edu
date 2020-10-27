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
//	printf("세 개의 값을 입력하시오 : [정수][문자][실수]\n");
//
//	//scanf("%d %c %f", &num, &ch, &fnum);
//
//	scanf("%d %c %f",&num, &ch, &fnum );
//
//	printf("입력에 대한 출력 : [정수 = %d] [문자 = %5c] [실수 = %f]\n",
//									num, ch, fnum);
//	return 0;
//}

//int main3(void) {
//	int num1 = 0;
//	int num2 = 0;
//	int num3 = 0;
//	printf("3개의 정수를 입력하시오(0이상 6미만이내) : ");
//	scanf_s("%d %d %d", &num1, &num2, &num3);
//	printf("총합 : %d \n", num1 + num2 + num3);
//	printf("평균 : %.1f \n", (float)(num1 + num2 + num3)/3);
//}

//int main4(void) {
//	int BirthYear = 0;
//	int TargetYear = 0;
//
//	printf("태어난 연도는? : ");
//	scanf("%d", &BirthYear);
//
//	printf("희망 연도는? : ");
//	scanf("%d", &TargetYear);
//
//	printf("당신이 %d년일때 나이는 %d살 입니다.",BirthYear,(TargetYear - BirthYear));
//}

//int main5(void) {
//	int iNum = 0;
//	printf("제곱할 정수를 입력하세요 : ");
//	scanf("%d", &iNum);
//	printf("%d 를 제곱한 정수는 %d 입니다.\n", iNum, iNum * iNum);
//}

int main(void) {
	int iNum1 = 0;
	int iNum2 = 0;
	int iNum3 = 0;
	printf("3개의 정수를 입력하세요 : ");
	scanf("%d %d %d", &iNum1, &iNum2, &iNum3);
	
	printf("(a-b)*(b+c)*(c%%a)한 결과 : %d \n", (iNum1-iNum2)*(iNum2+iNum3)*(iNum3%iNum1));
}