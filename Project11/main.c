#include <stdio.h>

//int main() {

	//printf("%d\n", 3451853);
	//printf("%10d\n", 3451853);  // 10ĭ Ȯ���ؼ� �������(ĭ������ ��ĭ)
	//printf("%011d\n\n", 3451853);  // 11ĭ Ȯ���ؼ� �������(��ĭ���� 0 ä��)
	//// C#�� string.format("%d", 100); ���� printfó�� ����� �� �ִ�.
	//
	//printf("%o\n", 3451853);
	//printf("%x\n", 3451853); 
	//printf("%X\n", 3451853);   // 16�������� ���ĺ��� �빮�ڷ� ���
	//printf("%08X\n", 3451853);  // 8ĭ�� Ȯ���ϰ� 16������ ���(��ĭ�� 0 ä��)
	//printf("%p\n", 3451853);   // %08X�� �Ȱ��� ��µȴ� 
	//printf("0x%08X\n", 3451853); // 16������ ���� ����� ����
	//printf("0x%p\n", 3451853); // 16������ ���� ����� ����2
//}


int main() 
{
	int		iNum;
	int *   p;

	iNum = 100;
	p = &iNum;
	
	printf("iNum�� ��   : %d\n", iNum);
	printf("iNum�� �ּ� : 0x%p\n", &iNum);

	printf("p�� ��      : 0x%p\n", p);  // p�� �ּҴ� ����ΰ�?
	printf("p�� �ּ�    : 0x%p\n", &p); // p�� � ���� �������ִ°�?
	printf("*p�� ��     : %d\n\n", *p); // p�� ������ �ִ� ������ ������.

	printf("/////////////////////////////////////////////////////\n\n");

	printf("iNum�� ��   : %d\n", iNum);
	printf("iNum�� �ּ� : 0x%p\n", &iNum);
	printf("*&iNum      : %d\n\n", *&iNum);  // &iNum�� ���� ���󰡺���. -> iNum��(*&�� ������ ���ȴ�!!!)

	printf("p�� ��      : 0x%p\n", p);
	printf("p�� �ּ�    : 0x%p\n", &p);
	printf("*&p         : %d\n", *&p);  // &p�� ���� ���󰡺��� -> iNum�� �ּҰ� ���
	printf("*p�� ��     : %d\n\n", *p);

	// ���� ������ŭ ���� �տ� *�� ���� �� �ִ�!!

	printf("/////////////////////////////////////////////////////\n\n");

	printf("iNum        : %d\n", iNum);
	printf("*&iNum      : %d\n", *&iNum);
	printf("p           : %p\n", p);
	printf("*&p         : %p\n", *&p);

	return 0;
}