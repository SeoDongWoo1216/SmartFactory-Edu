#include <stdio.h>

int main() 
{
	// 포인터는 주소를 저장하기때문에 크기가 전부 4바이트이다.
	// 앞에 뭐가 붙든간에 모두 포인터 타입이라고 한다.
	printf("포인터 사이즈 : %d\n", sizeof(char  *));
	printf("포인터 사이즈 : %d\n", sizeof(int   *));
	printf("포인터 사이즈 : %d\n\n", sizeof(double*));

	// 메모리를 어떻게 해석할 것인가??
	int iNum = 0x123456AB;
	char* cp;
	short* sp;
	int* ip;

	// 3개의 포인터에 iNum주소를 대입시켜보자
	//cp = &iNum;
	//sp = &iNum;
	cp = (char*)&iNum;
	sp = (short*)&iNum;
	ip = &iNum;

	return 0;
}



//int main() {
//	//문자형 포인터 변수가 int형 변수의 값을 출력하는 프로그램
//	char ch, * pch;
//	int iNum, * piNum;
//	float fNum, * pfNum;
//
//	ch = 'a';
//	iNum = 0x1314;
//	fNum = 25.3;
//
//	pch = &ch;
//	piNum = &iNum;
//	pfNum = &fNum;
//
//	printf("ch   : %5c,        *pch : %5c\n", ch, *pch);
//	printf("iNum : %5x,      *piNum : %5x\n", iNum, *piNum);
//	printf("fNum : %5.2f,      *pfNum : %5.2f\n\n", fNum, *pfNum);
//
//	pch = (char*)piNum;
//	printf("pch  : %p,     *pch : %x\n", pch, *pch);
//	pch++;
//	printf("pch  : %p,     *pch : %x\n", pch, *pch);
//
//	return 0;
//}