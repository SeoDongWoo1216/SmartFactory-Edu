#include <stdio.h>
#pragma warning(disable:4996)

// string ����Ÿ���� �迭���·� ���� �����Ѵ�. -> ���ڿ��̶���Ѵ�.
// C#�� charŸ���� �����ϴµ� ���ڿ��� �Ҷ��� ��Ʈ���̶�� Ŭ���� �ڷ����� �����ִ�
// char�� �迭���·� ������� �����ϴµ� �װ��� ���ڿ��̶�� �����Ѵ�.
// �⺻������ ���ڿ��� �迭������ ���̴�.
// �ΰ��� �����ΰŴ�.


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


// ���ڿ� ���� ���ϴ� ����
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



// ���ڿ� �����̼� ��Ű�� ����
int main() {
	int idx;
	char ch;
	char str[9] = { "Rotation" };

	printf(" -- ���� �� ���ڿ� -- \n");
	printf("%s\n", str);

	for (idx = 0; idx != 9; idx++)
		printf("%c ", str[idx]);


	printf("\n\n -- ���� �� -- \n");
	for (idx = 0; idx != 4; idx++) {
		ch = str[7 - idx];
		str[7 - idx] = str[idx];
		str[idx] = ch;

		printf("%s\n", str);
	}

	printf("\n -- ���� �� ���ڿ� -- \n");
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
//		printf("input score [%d]\n", idx + 1); // ����ڴ� 1���������� �鿣�忡�� ó���� 0������
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