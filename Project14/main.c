#include <stdio.h>

int main() {
	float fnum1 = 3.125f;
	float fnum2 = 5.0625f;
	float fnum3 = 123.6f;
	char* chP = (char*)&fnum3;

	printf("%f\n", fnum1);
	printf("%f\n", fnum2);
	printf("%f\n\n", fnum3); // 123.599998 �� ��µǴµ�, 6�� 2���� ǥ���ϴµ� ������ ����ٴ� ��
	
	// 3.125f ����, 3.125�� 16������ 00 00 48 40 �̴�.
	*chP = 0x00;
	++chP;
	*chP = 0x00;
	++chP;
	*chP = 0x48;
	++chP;
	*chP = 0x40;

	printf("%f\n", fnum3); // ������ �� ����� Ȯ���غ���.
	// char �����ͷ� 1����Ʈ ������ ������ ������ ������ �� �ִ�
	
}