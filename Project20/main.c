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


	//char str[100];  // ���� scanf���� ���ڿ� 99�� �Ѿ�� ���� �����÷ο�߻�
	//int nLen = 0;
	//int idx = 0;
	//char big_ch = 0;

	//printf("���ڿ� �Է� : ");
	//scanf("%s", str);  // str�� char �迭�̱⶧���� �迭�̸��� �ּ��̹Ƿ� &�Ⱥٿ����ȴ�.

	//for (idx = 0; str[idx] != '\0'; ++idx)
	//{
	//	if (big_ch < str[idx])
	//		big_ch = str[idx];
	//}
	//printf("�Էµ� ���ڿ� : %s\n", str);
	//printf("�ƽ�Ű �ڵ尪�� ���� ū ���� : %c\n", big_ch);
	//// ���� ū �ƽ�Ű �ڵ� ���� char���·� ���


	///////////////////////////////////////////////////////////


	//int numbers[5] = { 10, 20, 30, 40, 50 };

	//int* pNum = numbers;  // �迭�̸��� �ּ��̱⶧���� &�� ������ �ʾƵ��ȴ�.

	//printf("%d\n", *pNum);

	//printf("%d\n", *(++pNum));   // ���� ���� ��ȭ������ ���
	//printf("%d\n", *(++pNum));
	//printf("%d\n", *(pNum + 1));  // ���� ���� �����Ѱ� ���(���� ���� �������ʴ´�)
	//printf("%d\n", *(pNum + 2));


	////////////////////////////////////////////////////////////


	char buffer[] = "tusyeab. learyac kuxoey";
	char* p;

	p = buffer + sizeof(buffer) - 2;
	// buffer + 24 - 2 == buffer + 22 -> y �ڸ�
	// ��, ���ڿ� �迭�� ���� ���� ���ڷ� �ּҸ� �̵��Ѵ�.
	
	// 1000���� <= 1024����
	// 1000���� <= 1022����
	// ...
	// 1000���� <= 1000���� ���� ���
	while (buffer <= p) 
	{
		printf("%c", *p);
		p -= 2;
	}
	printf("\n");


	//////////////////////////////////////////////////////////////

	return 0;


}