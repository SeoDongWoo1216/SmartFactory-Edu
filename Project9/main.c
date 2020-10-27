#include<stdio.h>
#pragma warning(disable: 4996)

int main(void) 
{
	//int num = 1;
	//int sum = 0;

	//while (num <= 10) 
	//{
	//	if (!(num % 2))
	//	{
	//		sum += num;
	//		printf("입력된 짝수 : %d\n", num);
	//	}
	//	num++;
	//}
	//printf("1부터 10사이 짝수의 합 : %d\n", sum);

	////////////////////////////////////////////////////////

	//int val = 1;
	//int idx = 1;
	//printf("출력하고자 하는 구구단은 몇 단? : ");
	//scanf("%d", &val);

	//while (idx != 10) 
	//{
	//	printf("%d * %d = %d \n", val, idx, val * idx);
	//	idx++;
	//}

	////////////////////////////////////////////////////////

	//int num = 0;
	//int sum = 0;
	//do
	//{
	//	printf("Input Number : ");
	//	scanf("%d", &num);
	//	sum += num;
	//} while (num != 0);
	//printf("Total sum : %d \n", sum);

	//return 0;

	////////////////////////////////////////////////////

	//int num = 0;
	//int sum = 0;
	//int idx = 0;

	//printf("0부터 num까지의 덧셈, num? \n");
	//scanf("%d", &num);

	//for (idx = 0; idx <= num; idx++) 
	//{
	//	sum += idx;
	//}

	//printf("0부터 %d까지 덧셈 결과 : %d \n", num, sum);
	//return 0;
	
	////////////////////////////////////////////////////////

	int sum = 0;
	int count = 0;
	while (count < 5)
	{
		sum = sum + count;
		++count;
	}
	printf("%d\n", sum);





	//////////////////////////////////////////////////////////



	for (sum = 0, count = 0; count < 5; ++count)
	{
		sum = sum + count;
	}
	printf("%d\n", sum);


	//int sum = 0;
	//int count = 0;
	//for ( ; count < 5; ++count)
	//{
	//	sum = sum + count;
	//	++count;
	//}
	//printf("%d\n", sum);


	return 0;
}

//int main() {
//	while (1) 
//	{
//		printf("test");
//	}
//
//	for(;;)
//	{
//		printf("test");
//	}
//	return 0;
//}