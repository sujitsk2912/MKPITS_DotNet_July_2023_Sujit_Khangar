#include<stdio.h>
#include<string.h>
int main()
{
	int count=0;
	char name[100];
	char *ptr;
	printf("Enter Name: ");
	gets(name);
	ptr=name;
	while(*ptr!=0)
	{
		ptr++;
		count=count+1;
	}
	printf("no of a string length=%d",count);
}
