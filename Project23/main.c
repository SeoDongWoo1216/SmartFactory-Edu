#include <stdio.h>
#include <string.h>

#define MAX_STD 5     // ��ó�� : MAX_STD�� 5�� �ٲٰڴٴ� �ǹ�
#define NAME_LEN 25   // ��ó�� : NAME_LEN�� 25�� �ٲٰڴٴ� �ǹ��̴�.

int main2(void) {
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

	puts("-- �л� ����Ʈ -- \n");
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