#include<stdio.h>
#include<string.h>
struct book
{
	char title[50];
	char author[50];
	int bookid;
};
int main()
{
	struct book b1;
	printf("Enter title,author,Book id: ");
	scanf("%s",b1.title);
	scanf("%s",b1.author);
	scanf("%d",&b1.bookid);


	printf("\n title= %s",b1.title);
	printf("\n author= %s",b1.author);
	printf("\n bookid= %d",b1.bookid);
}
