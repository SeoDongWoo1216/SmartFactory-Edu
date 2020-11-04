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
			if (strcmp(Pointer[iCount1], Pointer[iCount2]) > 0)  // ���� ����
			{
				Temp = Pointer[iCount2];
				Pointer[iCount2] = Pointer[iCount1];
				Pointer[iCount1] = Temp;
			}
		}
	}

	for (iCount1 = 0; iCount1 < 5; ++iCount1)  // �����͸� �̿��ؼ� �������� �̵��� ���̰� ����Ű�� ���� �ٲ㼭 ���Ľ�Ű�� ���� -> �ε����� ������ ���ش�
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
	
	// ���ĺ��� �ƽ�Ű�ڵ尪�� ���ؼ� ù��° ���ڰ��� ũ�� 1, ù��° ���ڰ��� ������ -1, �ƽ�Ű�ڵ尪�� ������ 0 ��ȯ
	iRet1 = strcmp("A", "A");  // ���ڿ��� ������ 0 ���
	iRet2 = strcmp("A", "a");  
	iRet3 = strcmp("a", "A");
	printf("���ڿ��� ������         : %d\n", iRet1);
	printf("ù��° ���ڰ��� ���� �� : %d\n", iRet2);
	printf("ù��° ���ڰ��� Ŭ ��   : %d\n\n", iRet3);

	int iRet4;
	iRet4 = strcmp("Apple", "APPPLE"); // �ٸ� ���ڿ��� ���������� ������ �ٸ��� ã�ڸ��� �ٷ� ����Ѵ�
	printf("%d\n\n", iRet4);

	int iRet5;
	iRet5 = printf("���ŰƼ\n");   // printf�� int�� ��ȯ�Ѵ�  
	printf("%d", iRet5);      // printf�� ȭ�鿡 ����ϴ� ���� ������ ������ ��ȯ�Ѵ�.(\n�� 1���� ���ش�)
	                          // �ѱ��� ���� 2����(2����Ʈ)�̹Ƿ� �ѱ��ڴ� 2�� ����Ѵ�.


	// const char *str1
	//���ڿ������� str1�� �б��������� �����ϰڴٴ� ����.
	// �̷� �Լ����� ��Ƶ� ���� API(���ø����̼� ���α׷��� �������̽�)��� �Ѵ�.



	return 0;
}


