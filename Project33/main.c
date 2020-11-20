// ���� ���Ḯ��Ʈ : 3�� ����������� #define���� 0, 1������ ������� �������ְ� �� �� ����
#include <stdio.h>   // ǥ�� �����
#include <stdlib.h>  // ǥ�� ���̺귯�� // ������ malloc ����Ϸ��� ����

#include "book.h"
#define LINKED_LIST_TEST 0

/*
C#�� new : Ű����/�����(if���� ����)
C�� malloc : �Լ��̸�(printf�� ����) -> Heap������ �Ҵ�
*/

int main(void) 
{
	char* test = "å 1111";
	Book* Head;
	//Head = malloc(58);  // �ϵ��ڵ�

	// ����Ʈ �ڵ�(�ڷ����� ��ȭ�� �������)
	Head = (Book*)malloc(sizeof(Book));    // Ÿ���� ��ġ�� ���� ĳ�����������(���� �����Ϸ�(�����Ʃ��� �Ź���)�� ���ص���) 
	if(Head != 0)  // �����Ҵ��� �ݵ�� �޴°� �ƴϱ⶧���� ���ǹ����� �����ش�
	{
		strcpy(Head->Name, "å 1111");  // ��Ʈ�� ī��
		Head->Price = 2000;
		Head->Next = malloc(sizeof(Book));
		strcpy(Head->Next->Name, "å 2222");

		printf("å �̸� : [%s]\n", Head->Name);
		printf("å ���� : [%d]\n", Head->Price);
		printf("å �̸� : [%s]\n", Head->Name);
		printf("å ���� : [%d]\n", Head->Price);
	}
	

	
	free(Head->Next);
	free(Head); // Heap������ ��� �Ҵ�ް������Ƿ� free�� ���� �� �ִ�.
	return 0;
}





int main1(void) 
{
	Book aBook1 = { "å 1111", 2000};
	Book aBook2 = { "å 2222", 2001 };
	Book aBook3 = { "å 3333", 2002 };
	Book aBook4 = { "å 4444", 2003 };

	aBook1.Next = &aBook2;
#if LINKED_LIST_TEST
	aBook2.Next = &aBook4;
#else
	aBook2.Next = &aBook3;
	aBook3.Next = &aBook4;
#endif

#if 1  
	// �����϶� ��ó������ ��������.(�ڵ���ü�� �ƿ� ����� -> �ּ�ó���� ȿ�� ����)
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