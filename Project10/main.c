#include <stdio.h>
#pragma warning(disable: 4996)

//int main()
//{
//	int iCount;
//	int iDan;
//	//for(iDan = 1; iDan < 10; ++iDan)
//	//{
//	//	if((iDan % 2) == 0)
//	//	{
//	//		for (iCount = 1; iCount < 10; ++iCount)
//	//		{
//	//			printf("%d * %d = %d\n", iDan, iCount, iDan * iCount);
//	//		}
//	//	}
//	//	printf("\n");
//	//}
//
//	printf("����ϰ����ϴ� �������� �� ���ΰ���? : ");
//	scanf("%d", &iDan);
//	for (iCount = 1; iCount < 10; ++iCount)
//	{
//		printf("%d * %d = %d\n", iDan, iCount, iDan * iCount);
//	}
//
//}


//int main() 
//{
//	/*
//	1���� 50������ ������ 3�� ����� ���
//	A : 1���� 50������ ������
//	B : 3�� ����� ���
//	*/
//	int iCount;
//	for(iCount = 1; 50 >= iCount; ++iCount)
//	{
//		if((iCount % 3) == 0)
//		{
//			printf("%d\n", iCount);
//		}
//	
//	}
//}


int main() {
	int iNum = 100;
	char cNum = 100;
	short sNum = 100;
	//printf("%X\n", &iNum); // iNum�� �ּ� ���
	//printf("%d\n", iNum);

	iNum = 200;
	//printf("%d\n", iNum);

	*((int*)0x0019FEDC) = 300; // ���ʿ��� �׻� ������ �;��Ѵ�.
	//�ּҸ� �����Ͷ�� �Ѵ�.
	// �ּҰ��� �̿��ؼ� ���� �ٲٰų� �о���� ���� '�����͸� �̿��Ѵ�.' ����Ѵ�.
	// �ּҸ� �̿��� ���� ���ٹ��� �����Ͷ�� �Ѵ�.
	// ��� �޸𸮸� ������ �ٴ� �� �ִ�(�ּ� ��ġ�� �˸�Ǵϱ�)
	
	//printf("%d\n", iNum);

	return 0;
}


	//printf("5*1 = 5\n");
	//printf("5*2 = 10\n");
	//printf("5*3 = 15\n");
	//printf("5*4 = 20\n");
	//printf("5*5 = 25\n");
	//printf("5*6 = 30\n");
	//printf("5*7 = 35\n");
	//printf("5*8 = 40\n");
	//printf("5*9 = 45\n");
