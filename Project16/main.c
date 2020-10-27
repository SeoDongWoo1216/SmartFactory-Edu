#include <stdio.h>
#pragma warning(disable:4996)

// string 문자타입을 배열형태로 만들어서 저장한다. -> 문자열이라고한다.
// C#은 char타입이 존재하는데 문자열을 할때는 스트링이라는 클래스 자료형이 따로있다
// char를 배열형태로 묶어가지고 저장하는데 그것을 문자열이라고 정의한다.
// 기본적으로 문자열은 배열형태인 것이다.
// 인간은 동물인거다.


//int main() {
//
//	//char word[5];
//	//word[0] = 'L';
//	//word[1] = 'o';
//	//word[2] = 'v';
//	//word[3] = 'e';
//	//word[4] = 0;
//	////word[4] = '\0';
//	
//	//char word[5] = { "Love" };
//	char word[5] = "Love";
//
//	printf("[%c]\n", word[0]);
//	printf("[%c]\n", word[1]);
//	printf("[%c]\n", word[2]);
//	printf("[%c]\n", word[3]);
//
//	printf("[%s]\n", word);
//	return 0;
//}


// 문자열 길이 구하는 예제
//int main() {
//	char string[] = { "Happy Day" };
//	int idx;
//
//	for (idx = 0; string[idx] != '\0'; idx++) {
//		printf("%c", string[idx]);
//	}
//	printf("\nString length : %d\n", idx);
//	return 0;
//}



// 문자열 로테이션 시키는 예제
int main() {
	int idx;
	char ch;
	char str[9] = { "Rotation" };

	printf(" -- 변경 전 문자열 -- \n");
	printf("%s\n", str);

	for (idx = 0; idx != 9; idx++)
		printf("%c ", str[idx]);


	printf("\n\n -- 변경 중 -- \n");
	for (idx = 0; idx != 4; idx++) {
		ch = str[7 - idx];
		str[7 - idx] = str[idx];
		str[idx] = ch;

		printf("%s\n", str);
	}

	printf("\n -- 변경 후 문자열 -- \n");
	printf("%s\n", str);
	return 0;
}




//int main() {
//	int idx;
//	int score[10];
//	long sum = 0;
//	float average;
//
//	for (idx = 0; idx != (sizeof(score)/sizeof(score[0])); idx++) {
//		printf("input score [%d]\n", idx + 1); // 사용자는 1번부터지만 백엔드에서 처리는 0번부터
//		scanf("%d", &score[idx]);
//	}
//
//	for (idx = 0; idx != (sizeof(score) / sizeof(score[0]));idx++) {
//		sum += score[idx];
//		average = sum / 10;
//	}
//
//	printf("Average score : %.2f\n", average);
//}