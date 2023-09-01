#include<stdio.h>
#include<string.h>
int main()
{
	char name[10];
	char *ptr;
	printf("Enter Your Name: ");
	gets(name);
	ptr=name;
	while (*ptr!='\0')
	{
		printf("Your Name is %c",*ptr);
		ptr++;
	}
}
