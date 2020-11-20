#ifndef __BOOK_H__   // define 되어있지 않으면 endif까지의 코드를 집어넣어라.

#define __BOOK_H__

//#ifdef  // 만약에 뒤에꺼 define 이름이 참이면 endif까지의 코드를 집어넣지마라.
          // __는 어셈블리와 구별하기위해 붙였다.(개수는 그냥 지맘대로 붙이면된다)


typedef struct _book
{
	char Name[50];
	int Price;
	struct _book* Next;
}Book;
#endif  // __BOOK_H__  // 이 주석을 달아줌으로써 한 세트라는 것을 표시해줌.