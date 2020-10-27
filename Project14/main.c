#include <stdio.h>

int main() {
	float fnum1 = 3.125f;
	float fnum2 = 5.0625f;
	float fnum3 = 123.6f;
	char* chP = (char*)&fnum3;

	printf("%f\n", fnum1);
	printf("%f\n", fnum2);
	printf("%f\n\n", fnum3); // 123.599998 이 출력되는데, 6을 2진수 표현하는데 오차가 생긴다는 뜻
	
	// 3.125f 대입, 3.125는 16진수로 00 00 48 40 이다.
	*chP = 0x00;
	++chP;
	*chP = 0x00;
	++chP;
	*chP = 0x48;
	++chP;
	*chP = 0x40;

	printf("%f\n", fnum3); // 대입이 잘 됬는지 확인해보자.
	// char 포인터로 1바이트 단위로 데이터 영역을 조작할 수 있다
	
}