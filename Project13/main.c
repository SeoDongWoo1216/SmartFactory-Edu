#include <stdio.h>

int main() {

	//int iNum = 0x12345678;

	////포인터 변수 타입을 통해 데이터를 어떻게 볼것인지 정할 수 있다.
	//int* p1 = &iNum;
	//char* p2 = &iNum;  // int*형이나 char*이나 크기는 4바이트이다.
	//
	//printf("%08x\n", *p1);
	//printf("%08x\n\n", *p2);
	//// 00000078 이 출력되는데, 원래 char형이 1바이트를 가지므로 iNum주소의 1바이트만 출력되는데, 출력을 %08x로 했으므로 00000078이 출력된다.

	//*p2 = 0xAB;
	//printf("%08x\n", iNum); // char*으로 메모리의 1바이트의 값만을 바꿀 수 있다.

	////////////////////////////////////////

	//일반 연산과 주소 연산은 다르다.

	//int iNum = 0x12345678;
	//int* p = &iNum;
	//printf("%p\n", &iNum);
	//printf("%p\n\n", p);

	//printf("%p\n", &iNum+1);  // 주소 + 1을 통해 4바이트 이동 => 4가 +됨
	//printf("%p\n", p+1);

	//char cNum = 0x12345678;
	//char* p = &cNum;
	//printf("%p\n", &cNum);
	//printf("%p\n\n", p);

	//printf("%p\n", &cNum + 1);  // 주소 + 1을 통해 1바이트 이동 => 1이 +됨
	//printf("%p\n", p + 1);

	//// 주소값 + 1 => 주소 연산
	//// 100 + 1과 주소 + 1 의미는 다르다.


	///////////////////////////////////////

	//int iNum = 0x12345678;
	//char* p = &iNum;
	//printf("%02x\n\n", *p);

	////printf("%02x\n", *(p + 0));    // 주소 + 1을 먼저 연산해서 저장된 메모리의 값들을 1바이트씩 출력
	////printf("%02x\n", *(p + 1));
	////printf("%02x\n", *(p + 2));
	////printf("%02x\n\n", *(p + 3));




	////반복문으로 출력
	//for(int i = 0; i<4; i++)
	//{
	//	printf("%02x\n", *(p++));
	//}

	// 만약 i<5로 지정해주면 4바이트를 초과했기때문에 아무 값도 넣지않은 쓰레기값이 출력될것이다.
	// 이 쓰레기값 구간에 포인터 변수의 범위를 초과했기때문에(아무 값도 넣지 않은 곳이기때문) 이때 *p에 값을 넣으면 over flow가 발생한다.


	///////////////////////////////////////////


	int iNum = 0x12345678;
	char* cp = (char*)&iNum;
	short* sp = (short*)&iNum;
	int* ip = &iNum;

	printf("%08x\n", *cp);
	printf("%08x\n", *sp);
	printf("%08x\n\n", *ip);


	//3456 출력

	sp = (short*)((char*)cp + 1);
	printf("%04x\n", *sp); 

	sp = (short*)((char*)&iNum + 1);
	printf("%04x\n", *sp);

	sp = (short*)((char*)ip + 1);
	printf("%04x\n", *sp);

	// 3.125
	// 5.0625 2진수로 바꿔오기


	////////////////////////////////////////

	//포인터 변수 연산 예제
	//int n = 10;
	//int* p1 = &n;
	//int* p2 = p1;

	//printf("%d\n", (*p1)++);
	//printf("%d\n", (*p2)++);
	//printf("%d\n", n);

	/////////////////////////////////////

	//포인터 변수 연산 예제2
	//int a = 1;
	//int b = 10;
	//int c = 20;
	//(*(a ? &b : &c))++;

	//printf("a : %d\n", a);
	//printf("b : %d\n", b);
	//printf("c : %d\n", c);

	return 0;
}