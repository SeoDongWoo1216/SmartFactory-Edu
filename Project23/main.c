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


int main()
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
			if (strcmp(Pointer[iCount1], Pointer[iCount2]) > 0)
			{
				Temp = Pointer[iCount2];
				Pointer[iCount2] = Pointer[iCount1];
				Pointer[iCount1] = Temp;
			}
		}
	}

	for (iCount1 = 0; iCount1 < 5; ++iCount1)
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