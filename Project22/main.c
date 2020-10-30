#include <stdio.h>
#include <string.h>

#define MAX_STD 5     // 전처리 : MAX_STD를 5로 바꾸겠다는 의미
#define NAME_LEN 25   // 전처리 : NAME_LEN을 25로 바꾸겠다는 의미이다.


// 학생이름 입력받아 알파벳 오름차순으로 정렬하여 출력하기

int main(void) {
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

	for(idx = 0; idx < MAX_STD - 1; idx++)
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
	for (idx = 0; idx != MAX_STD; idx++) {
		printf("[%d] %s\n", (idx + 1), strptr[idx]);
	}

	return 0;
}








// 2*4 배열을 4*2 배열로 변환
int main2(void) {
	int arr1[2][4] = { 1,2,3,4,5,6,7,8 };
	int arr2[4][2];
	int idx, jdx;

	for (idx = 0; idx != 2; idx++)
		for (jdx = 0; jdx != 4; jdx++)
			arr2[jdx][idx] = arr1[idx][jdx];

	for (idx = 0; idx != 4; idx++)
	{
		for (jdx = 0; jdx != 2; jdx++)
			printf("%4d", arr2[idx][jdx]);
		printf("\n");
	}
	return 0;
}


// 포인터 배열1 
int main3() {

	char* season[4] = { "Spring", "Summer", "Fall", "Winter" };
	int idx;

	for (idx = 0; idx != 4; idx++) {
		printf("%s\n", season[idx]);
	}

	return 0;
}
