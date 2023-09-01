#include<stdio.h>
#include<string.h>
struct book
{
	char title[50];
	char author[50];
	int bookid;
};
void printbook(struct book b1);
int main()
{
	struct book b1;
	printf("Enter title,author,bookid: ");
	scanf("%s",b1.title);
	scanf("%s",b1.author);
	scanf("%d",&b1.bookid);
}
void printbook(struct book b1)
{
	printf("\nTitle=%s",b1.title);
	printf("\nAuthor=%s",b1.author);
	printf("\nBookid=%d",b1.bookid);
}
