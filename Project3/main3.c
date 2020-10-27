
// 문자를 화면에 출력하고 벨소리를 출력하는 프로그램
#include <stdio.h>

int main() {
	printf("Print Character: %c\n", 104);
	printf("Print Character: %c\n", 105);
	printf("bell sound \a\n\n");

	printf("A, B 같은지 비교\n");
	int A = 65;
	int B = 'A';
	printf("A : %c\n", A);
	printf("B : %c\n", B);
	printf("A : %d\n", A);
	printf("B : %d\n", B);
	return 0;
}


//// 자판기 잔돈 계산 프로그램
//int main1() {
//	int input, change;  // input은 투입액, change는 잔돈을 저장할 변수ㅡ
//	int w500, w100, w50, w10;  // 각 동전의 개수를 저장할 변수
//	printf("돈을 입력하세요 : ");
//	scanf("%d", &input);
//	change = input - 150;  // 커피값이 150원일때 잔돈 계산
//	w500 = change / 500;   // 500원 동전의 개수
//	change = change % 500;  // 아직 지급하지 못한 남은 잔돈
//	w100 = change / 100;
//	change = change % 100;
//	w50 = change / 50;
//	change = change % 50;
//	w10 = change / 10;
//	printf("500원짜리 동전 %d개\n", w500);
//	printf("100원짜리 동전 %d개\n", w100);
//	printf("50원짜리 동전 %d개\n", w50);
//	printf("10원짜리 동전 %d개\n", w10);
//
//	return 0;
//}