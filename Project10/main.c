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
//	printf("출력하고자하는 구구단은 몇 단인가요? : ");
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
//	1에서 50까지의 수에서 3의 배수만 출력
//	A : 1에서 50까지의 수에서
//	B : 3의 배수만 출력
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
	//printf("%X\n", &iNum); // iNum의 주소 출력
	//printf("%d\n", iNum);

	iNum = 200;
	//printf("%d\n", iNum);

	*((int*)0x0019FEDC) = 300; // 왼쪽에는 항상 변수가 와야한다.
	//주소를 포인터라고 한다.
	// 주소값을 이용해서 값을 바꾸거나 읽어오는 것을 '포인터를 이용한다.' 라고한다.
	// 주소를 이용한 변수 접근법을 포인터라고 한다.
	// 모든 메모리를 휘젓고 다닐 수 있다(주소 위치만 알면되니까)
	
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
