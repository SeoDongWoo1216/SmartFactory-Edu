#include <stdio.h>
#include <string.h>

#define MAX_STD 5     // ��ó�� : MAX_STD�� 5�� �ٲٰڴٴ� �ǹ�
#define NAME_LEN 25   // ��ó�� : NAME_LEN�� 25�� �ٲٰڴٴ� �ǹ��̴�.


// �л��̸� �Է¹޾� ���ĺ� ������������ �����Ͽ� ����ϱ�

int main(void) {
	char stdbuf[MAX_STD][NAME_LEN] = { 0, }; // ���ڿ� �迭[5][25]
	char* strptr[MAX_STD];      // char���� ����Ű�� ������ �迭
	char* temp = NULL;

	int idx = 0;
	int jdx = 0;

	puts("�л� �̸� �Է� : ");  
	// put�� ����, get�� ������
	// s�� string,  puts�� " " ���� ���ڸ� ����Ѵ�.(�޴� ���ڰ�����)

	while (idx != MAX_STD) 
	{
		fflush(stdin);  // �����̷���
		fgets(stdbuf[idx], sizeof(stdbuf[idx]), stdin);
		// gets(stdbuf[idx]);
		strptr[idx++] = stdbuf[idx];
	}


	/*���ڿ� �������� ����*/

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

	puts("-- �л� ����Ʈ -- \n");
	for (idx = 0; idx != MAX_STD; idx++) {
		printf("[%d] %s\n", (idx + 1), strptr[idx]);
	}

	return 0;
}








// 2*4 �迭�� 4*2 �迭�� ��ȯ
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


// ������ �迭1 
int main3() {

	char* season[4] = { "Spring", "Summer", "Fall", "Winter" };
	int idx;

	for (idx = 0; idx != 4; idx++) {
		printf("%s\n", season[idx]);
	}

	return 0;
}
