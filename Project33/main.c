// 정적 연결리스트 : 3을 연결안했지만 #define으로 0, 1에따라 연결끊고 연결해주고 할 수 있음
#include <stdio.h>   // 표준 입출력
#include <stdlib.h>  // 표준 라이브러리 // 지금은 malloc 사용하려고 선언

#include "book.h"
#define LINKED_LIST_TEST 0

/*
C#의 new : 키워드/예약어(if문과 동급)
C의 malloc : 함수이름(printf와 동급) -> Heap영역에 할당
*/

int main(void) 
{
	char* test = "책 1111";
	Book* Head;
	//Head = malloc(58);  // 하드코딩

	// 소프트 코딩(자료형의 변화에 영향없음)
	Head = (Book*)malloc(sizeof(Book));    // 타입의 일치를 위해 캐스팅해줘야함(신형 컴파일러(비쥬얼스튜디오 신버전)는 안해도됨) 
	if(Head != 0)  // 동적할당을 반드시 받는게 아니기때문에 조건문으로 묶어준다
	{
		strcpy(Head->Name, "책 1111");  // 스트링 카피
		Head->Price = 2000;
		Head->Next = malloc(sizeof(Book));
		strcpy(Head->Next->Name, "책 2222");

		printf("책 이름 : [%s]\n", Head->Name);
		printf("책 가격 : [%d]\n", Head->Price);
		printf("책 이름 : [%s]\n", Head->Name);
		printf("책 가격 : [%d]\n", Head->Price);
	}
	

	
	free(Head->Next);
	free(Head); // Heap영역은 계속 할당받고있으므로 free로 없앨 수 있다.
	return 0;
}





int main1(void) 
{
	Book aBook1 = { "책 1111", 2000};
	Book aBook2 = { "책 2222", 2001 };
	Book aBook3 = { "책 3333", 2002 };
	Book aBook4 = { "책 4444", 2003 };

	aBook1.Next = &aBook2;
#if LINKED_LIST_TEST
	aBook2.Next = &aBook4;
#else
	aBook2.Next = &aBook3;
	aBook3.Next = &aBook4;
#endif

#if 1  
	// 컴파일때 전처리에서 지워진다.(코드자체가 아예 사라짐 -> 주석처리와 효과 동일)
	printf("[%s] ->", aBook1.Name);
	printf("[%s] ->", aBook1.Next->Name);
	printf("[%s] ->", aBook1.Next->Next->Name);
#if !LINKED_LIST_TEST
	printf("[%s] ->", aBook1.Next->Next->Next->Name);
#endif 
	printf("NULL\n");
#endif

	return 0;
}