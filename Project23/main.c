#include <stdio.h>
#include <string.h>

#define MAX_STD 5     // 전처리 : MAX_STD를 5로 바꾸겠다는 의미
#define NAME_LEN 25   // 전처리 : NAME_LEN을 25로 바꾸겠다는 의미이다.


int main2(void) {
	char stdbuf[MAX_STD][NAME_LEN] = { 0, }; // 문자열 배열[5][25]
	char* strptr[MAX_STD];      // char형을 가리키는 포인터 배열
	char* temp = NULL;

	int idx = 0;
	int jdx = 0;

	puts("학생 이름 입력 : ");
	// put은 놓다, get은 가지다
	// s는 string,  puts는 " " 안의 글자만 출력한다.(받는 인자가없다)

	while (idx != MAX_STD)
	{
		fflush(stdin);  // 리다이렉션
		fgets(stdbuf[idx], sizeof(stdbuf[idx]), stdin);
		// gets(stdbuf[idx]);
		strptr[idx++] = stdbuf[idx];
	}


	/*문자열 오름차순 정렬*/

	for (idx = 0; idx < MAX_STD - 1; idx++)
		for (jdx = idx + 1; jdx < MAX_STD; jdx++)
		{
			if (strcmp(strptr[idx], strptr[jdx]) > 0)
			{
				temp = strptr[jdx];
				strptr[jdx] = strptr[idx];
				strptr[idx] = temp;
			}
		}

	puts("-- 학생 리스트 -- \n");
	for (idx = 0; idx != MAX_STD; idx++)
	{
		printf("[%d] %s\n", (idx + 1), strptr[idx]);
	}

	return 0;
}



int main3()
{
	char Original[5][6] = {
	  "apple",
	  "Apple",
	  "APple",
	  "APPLe",
	  "APPLE"
	};
	char* Pointer[5];
	char* Temp;

	int iCount1;
	int iCount2;

	for (iCount1 = 0; iCount1 < 5; ++iCount1)
	{
		Pointer[iCount1] = Original[iCount1];
		printf("[%s]\n", Pointer[iCount1]);
	}
	printf("\n");
	for (iCount1 = 0; iCount1 < 4; ++iCount1)
	{
		for (iCount2 = iCount1 + 1; iCount2 < 5; ++iCount2)
		{
			if (strcmp(Pointer[iCount1], Pointer[iCount2]) > 0)  // 정렬 로직
			{
				Temp = Pointer[iCount2];
				Pointer[iCount2] = Pointer[iCount1];
				Pointer[iCount1] = Temp;
			}
		}
	}

	for (iCount1 = 0; iCount1 < 5; ++iCount1)  // 포인터를 이용해서 데이터의 이동을 줄이고 가리키는 곳만 바꿔서 정렬시키는 것임 -> 인덱스의 역할을 해준다
	{
		printf("[%s]\n", Pointer[iCount1]);
	}
	printf("\n");

	for (iCount1 = 0; iCount1 < 5; ++iCount1)
	{
		printf("[%s]\n", Original[iCount1]);
	}
	printf("\n");

	return 0;
}


int main4() 
{
	int iRet1, iRet2, iRet3;   
	
	// 알파벳의 아스키코드값을 비교해서 첫번째 인자값이 크면 1, 첫번째 인자값이 작으면 -1, 아스키코드값이 같으면 0 반환
	iRet1 = strcmp("A", "A");  // 문자열이 같으면 0 출력
	iRet2 = strcmp("A", "a");  
	iRet3 = strcmp("a", "A");
	printf("문자열이 같을때         : %d\n", iRet1);
	printf("첫번째 인자값이 작을 때 : %d\n", iRet2);
	printf("첫번째 인자값이 클 때   : %d\n\n", iRet3);

	int iRet4;
	iRet4 = strcmp("Apple", "APPPLE"); // 다른 문자열을 만날때까지 돌려서 다른걸 찾자마자 바로 출력한다
	printf("%d\n\n", iRet4);

	int iRet5;
	iRet5 = printf("헬로키티\n");   // printf도 int를 반환한다  
	printf("%d", iRet5);      // printf가 화면에 출력하는 글자 개수를 개수로 반환한다.(\n도 1개로 쳐준다)
	                          // 한글은 영어 2글자(2바이트)이므로 한글자당 2를 출력한다.


	// const char *str1
	//문자열에대해 str1를 읽기전용으로 참고만하겠다는 뜻임.
	// 이런 함수들을 모아둔 것은 API(어플리케이션 프로그래밍 인터페이스)라고 한다.



	return 0;
}


