#include <stdio.h>

//int main(void) {
//
//	float fNum = 6.125f;
//	printf("%f\n", fNum);
//	return 0;
//}

//int main(void) 
//{
//	int bonbong, bouns, total;          // 본봉, 보너스, 총수입액
//	double tax, real_income, tax_rate;  // 세금, 실수입액, 세율
//	bonbong = 230;
//	bouns = 60;
//	printf("세율을 입력하세요(퍼센트) >>  ");
//	scanf("%lf", &tax_rate);  // 키보드로 세율 입력
//	total = bonbong + bouns; // 총 수입액은 본봉 + 보너스
//	tax = total * (tax_rate/100);
//	real_income = total - tax;
//	printf("\n실 수입액은 %.3lf 입니다\n", real_income);
//
//	return 0;
//}

//int main(void) {
//
//	printf("정수형 상수 100을 10진수, 8진수, 16진수로 출력하는 프로그램\n");
//	printf("10진수 : %#d, 8진수 : %#o, 16진수 : %#x\n\n", 100, 100, 100);
//
//	printf("정수형 상수 100을 10진수, 8진수, 16진수로 출력하는 프로그램 #없을때\n");
//	printf("10진수 : %d, 8진수 :  %o, 16진수 : %x\n\n", 100, 100, 100);
//
//	printf("정수형 상수 크기를 출력하는 프로그램\n");
//	printf("The size of int 67 is %3d\n", sizeof(67));
//	printf("The size of int 67L is %3d\n\n", sizeof(67.0));
//
//	// 자료형의 크기가 어떤지 출력하는 예제
//	printf("자료형의 크기 나열\n");
//	printf("char : %d,  short : %d,    int : %d \n", sizeof(char), sizeof(short), sizeof(int));
//	printf("long : %d,  long int : %d, long long : %d \n", sizeof(long), sizeof(long int), sizeof(long long));
//	printf("float : %d, double : %d,   long double : %d \n", sizeof(float), sizeof(double), sizeof(long double));
//}

//int main() {
//	// 255보다 작은 10진수를 입력받아 화면에 문자로 출력하는 프로그램을 작성하시오.
//
//	int iNum;
//	printf("255보다 작은 정수를 입력하시오 : ");
//	scanf("%d", &iNum);
//	printf("숫자의 ASCII 코드 : %c\n", iNum);
//}

//int main() {
//	//삼각형의 넓이를 구하는 프로그램
//	int Width, Hight;
//	printf("밑변과 높이를 입력하세요 : ");
//	scanf("%d %d", &Width, &Hight);
//
//	int Sum = (Width * Hight) / 2;
//
//	printf("삼각형의 높이 : %d\n", Sum);
//}



//int main() {
//	// 3개의 정수(각각 0이상 6미만)를 입력받아 그들의 총합과 평균을 출력
//	// 평균을 소수점 둘째 자리에서 반올림하여 출력
//
//	int iNum1, iNum2, iNum3;
//	printf("3개의 정수를 입력하세요(각각 0이상 6미만) : ");
//	scanf("%d %d %d", &iNum1, &iNum2, &iNum3);
//
//	printf("총합 : %d \n", (iNum1+iNum2+iNum3) );
//	printf("평균 : %.2f \n", (float)(iNum1 + iNum2 + iNum3) / 3);
//}



//int main() {
//	//키보드로 알파벳 하나를 입력받아, 
//	// 이를 소문자나 대문자로를 변환하여 출력하는 프로그램 작성
//	char ch;
//	printf("알파벳을 하나 입력하세요 : ");
//	scanf("%c", &ch);
//
//	if (ch >= 'A' && ch <= 'Z') // 대문자 A~Z 인가?
//	{
//		printf("\n대문자를 입력하셨습니다.\n");
//		printf("소문자로 변환 : %c\n", ch + 32);
//	}
//	else if (ch >= 'a' && ch <= 'z') // 소문자 a~z인가?
//	{
//		printf("\n소문자를 입력하셨습니다.\n");
//		printf("대문자로 변환 : %c\n", ch - 32);
//	}
//	else
//		printf("\n알파벳을 입력하지 않으셨습니다\n");
//}


//int main() {
//	//화씨온도를 입력받아 섭씨온도로 출력하는 프로그램을 작성
//	int iNum1;
//	printf("화씨 온도(℉)를 입력하세요 : ");
//	scanf("%d", &iNum1);
//
//	int iNum2 = 1.8 * (float)(iNum1 - 32);
//	printf("섭씨 온도는 : %.2f℃ 입니다.\n", (float)iNum2);
//}