#include <stdio.h> 

int main() 
{
	int A;
	int B = 3;
	int C = 2;
	A = B + C;   // 2 + 3은 컴파일러가 미리 계산해주기때문에 변수 값을 대입했다.
	printf("%d", A);
}

//int main() 
//{
//	int i;
//	for (;;) {}
//	while (1);
//}

//int main()
//{
//	int A1 = 1;
//	int A2 = 2;
//	int A3 = A1 + A2;
//	int A4 = A3 + 6;
//}