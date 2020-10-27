#include <stdio.h>
#pragma warning(disable: 4996)

int main() {
	//int ary[5] = { 10, 20, 30, 40, 50 };
	//int* ap = ary;
	//int iCount;

	//for (iCount = 0; iCount < 5; ++iCount) 
	//{
	//	printf("%d ", ary[iCount]);
	//}

	//printf("\n");
	//for (iCount = 0; iCount < 5; ++iCount) 
	//{
	//	printf("%d ", *(ary + iCount));
	//}

	//printf("\n");
	//for (iCount = 0; iCount < 5; ++iCount) 
	//{
	//	printf("%d ", *(ap + iCount));
	//}

	//printf("\n");
	//for (iCount = 0; iCount < 5; ++iCount) 
	//{
	//	printf("%d ", ap[iCount]);
	//}
	//

	//////////////////////////////////////////////////////////////


	//char str[100];  // 만약 scanf에서 문자열 99개 넘어가면 버퍼 오버플로우발생
	//int nLen = 0;
	//int idx = 0;
	//char big_ch = 0;

	//printf("문자열 입력 : ");
	//scanf("%s", str);  // str은 char 배열이기때문에 배열이름은 주소이므로 &안붙여도된다.

	//for (idx = 0; str[idx] != '\0'; ++idx)
	//{
	//	if (big_ch < str[idx])
	//		big_ch = str[idx];
	//}
	//printf("입력된 문자열 : %s\n", str);
	//printf("아스키 코드값이 가장 큰 문자 : %c\n", big_ch);
	//// 제일 큰 아스키 코드 값을 char형태로 출력


	///////////////////////////////////////////////////////////


	//int numbers[5] = { 10, 20, 30, 40, 50 };

	//int* pNum = numbers;  // 배열이름이 주소이기때문에 &을 붙이지 않아도된다.

	//printf("%d\n", *pNum);

	//printf("%d\n", *(++pNum));   // 변수 값의 변화에따라 출력
	//printf("%d\n", *(++pNum));
	//printf("%d\n", *(pNum + 1));  // 변수 값에 연산한거 출력(변수 값은 변하지않는다)
	//printf("%d\n", *(pNum + 2));


	////////////////////////////////////////////////////////////


	char buffer[] = "tusyeab. learyac kuxoey";
	char* p;

	p = buffer + sizeof(buffer) - 2;
	// buffer + 24 - 2 == buffer + 22 -> y 자리
	// 즉, 문자열 배열의 제일 끝의 문자로 주소를 이동한다.
	
	// 1000번지 <= 1024번지
	// 1000번지 <= 1022번지
	// ...
	// 1000번지 <= 1000번지 까지 출력
	while (buffer <= p) 
	{
		printf("%c", *p);
		p -= 2;
	}
	printf("\n");


	//////////////////////////////////////////////////////////////

	return 0;


}