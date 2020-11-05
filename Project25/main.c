// 학생의 이름과 성적을 입력받아 평균을 출력하는 프로그램
#include <stdio.h>
#pragma warning(disable:4996)
#define MAX_NAME 20

struct STUDENT 
{
	char	m_name[MAX_NAME];
	int		m_eng;
	int		m_math;
	float	m_average;

};

int main2(void) {
	struct STUDENT std;
	printf("학생 이름 입력 : ");
	
	//scanf("%s", std.m_name, MAX_NAME - 1);
	//gets(std.m_name);

	fgets(std.m_name, MAX_NAME, stdin);
	std.m_name[strlen(std.m_name) - 1] = 0;  
	// fgets는 엔터를 갖고있으므로 엔터자리에 = 0으로 null로 바꿔줌
	// strlen은 문자열 길이 측정해주는 함수


	printf("영어 점수 입력 : ");
	fflush(stdin);
	scanf("%d", &std.m_eng);

	printf("수학 점수 입력 : ");
	fflush(stdin);
	scanf("%d", &std.m_math);

	std.m_average = (float)(std.m_eng + std.m_math) / 2;

	printf("\n학생 이름 : %s\n", std.m_name);
	printf("평균 점수 : %6.3f\n", std.m_average);
}




struct Test
{
	int a;
	int b;
};

int main() 
{
	struct Test aTest;
	struct Test* pTest;

	aTest.a = 100;
	aTest.b = 200;
	pTest = &aTest;
	
	printf("aTest.a : %d\n", aTest.a);
	printf("aTest.b : %d\n\n", aTest.b);

	printf("aTest->a : %d\n", pTest->a);
	printf("aTest->b : %d\n\n", pTest->b);

	printf("aTest Size : %d\n", sizeof(aTest));
	printf("pTest Size : %d\n\n", sizeof(pTest));

	return 0;
}