#include <stdio.h>

int main() 
{
	// �����ʹ� �ּҸ� �����ϱ⶧���� ũ�Ⱑ ���� 4����Ʈ�̴�.
	// �տ� ���� �ٵ簣�� ��� ������ Ÿ���̶�� �Ѵ�.
	printf("������ ������ : %d\n", sizeof(char  *));
	printf("������ ������ : %d\n", sizeof(int   *));
	printf("������ ������ : %d\n\n", sizeof(double*));

	// �޸𸮸� ��� �ؼ��� ���ΰ�??
	int iNum = 0x123456AB;
	char* cp;
	short* sp;
	int* ip;

	// 3���� �����Ϳ� iNum�ּҸ� ���Խ��Ѻ���
	//cp = &iNum;
	//sp = &iNum;
	cp = (char*)&iNum;
	sp = (short*)&iNum;
	ip = &iNum;

	return 0;
}



//int main() {
//	//������ ������ ������ int�� ������ ���� ����ϴ� ���α׷�
//	char ch, * pch;
//	int iNum, * piNum;
//	float fNum, * pfNum;
//
//	ch = 'a';
//	iNum = 0x1314;
//	fNum = 25.3;
//
//	pch = &ch;
//	piNum = &iNum;
//	pfNum = &fNum;
//
//	printf("ch   : %5c,        *pch : %5c\n", ch, *pch);
//	printf("iNum : %5x,      *piNum : %5x\n", iNum, *piNum);
//	printf("fNum : %5.2f,      *pfNum : %5.2f\n\n", fNum, *pfNum);
//
//	pch = (char*)piNum;
//	printf("pch  : %p,     *pch : %x\n", pch, *pch);
//	pch++;
//	printf("pch  : %p,     *pch : %x\n", pch, *pch);
//
//	return 0;
//}