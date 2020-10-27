#include <stdio.h>

//int main() {

	//printf("%d\n", 3451853);
	//printf("%10d\n", 3451853);  // 10칸 확보해서 숫자출력(칸남으면 빈칸)
	//printf("%011d\n\n", 3451853);  // 11칸 확보해서 숫자출력(빈칸에는 0 채움)
	//// C#은 string.format("%d", 100); 으로 printf처럼 사용할 수 있다.
	//
	//printf("%o\n", 3451853);
	//printf("%x\n", 3451853); 
	//printf("%X\n", 3451853);   // 16진수에서 알파벳을 대문자로 출력
	//printf("%08X\n", 3451853);  // 8칸을 확보하고 16진수로 출력(빈칸은 0 채움)
	//printf("%p\n", 3451853);   // %08X와 똑같이 출력된다 
	//printf("0x%08X\n", 3451853); // 16진수의 가장 우아한 형태
	//printf("0x%p\n", 3451853); // 16진수의 가장 우아한 형태2
//}


int main() 
{
	int		iNum;
	int *   p;

	iNum = 100;
	p = &iNum;
	
	printf("iNum의 값   : %d\n", iNum);
	printf("iNum의 주소 : 0x%p\n", &iNum);

	printf("p의 값      : 0x%p\n", p);  // p의 주소는 어디인가?
	printf("p의 주소    : 0x%p\n", &p); // p는 어떤 값을 가지고있는가?
	printf("*p의 값     : %d\n\n", *p); // p가 가지고 있는 값으로 가보자.

	printf("/////////////////////////////////////////////////////\n\n");

	printf("iNum의 값   : %d\n", iNum);
	printf("iNum의 주소 : 0x%p\n", &iNum);
	printf("*&iNum      : %d\n\n", *&iNum);  // &iNum의 값을 따라가보자. -> iNum값(*&가 만나면 상쇄된다!!!)

	printf("p의 값      : 0x%p\n", p);
	printf("p의 주소    : 0x%p\n", &p);
	printf("*&p         : %d\n", *&p);  // &p의 값을 따라가보자 -> iNum의 주소가 출력
	printf("*p의 값     : %d\n\n", *p);

	// 별의 개수만큼 변수 앞에 *를 붙일 수 있다!!

	printf("/////////////////////////////////////////////////////\n\n");

	printf("iNum        : %d\n", iNum);
	printf("*&iNum      : %d\n", *&iNum);
	printf("p           : %p\n", p);
	printf("*&p         : %p\n", *&p);

	return 0;
}
