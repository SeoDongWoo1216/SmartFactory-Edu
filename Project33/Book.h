#ifndef __BOOK_H__   // define �Ǿ����� ������ endif������ �ڵ带 ����־��.

#define __BOOK_H__

//#ifdef  // ���࿡ �ڿ��� define �̸��� ���̸� endif������ �ڵ带 �����������.
          // __�� ������� �����ϱ����� �ٿ���.(������ �׳� ������� ���̸�ȴ�)


typedef struct _book
{
	char Name[50];
	int Price;
	struct _book* Next;
}Book;
#endif  // __BOOK_H__  // �� �ּ��� �޾������ν� �� ��Ʈ��� ���� ǥ������.