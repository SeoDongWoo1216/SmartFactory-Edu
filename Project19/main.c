#include <stdio.h>

int main() {
	int ary[5] = { 10, 20, 30, 40, 50 };
	int* ap = ary;
	int iCount;

	for (iCount = 0; iCount < 5; ++iCount) {
		printf("%d", ary[iCount]);
	}

	return 0;
}