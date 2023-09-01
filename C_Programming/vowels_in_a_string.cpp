#include<stdio.h>
#include<string.h>
int main()
{
	int counter=0;
	char name[20];
	char *ptr;
	printf("Enter Name: ");
	gets(name);
	ptr=name;
	while(*ptr!='\0')
	{
		if(*ptr=='a' || *ptr=='e' || *ptr=='i' || *ptr=='o' || *ptr=='u')
		{
		   counter=counter+1;	
		} 
		printf("%c",*ptr);
		ptr++;
	}
	printf("\nNo. of vowels in a string is %d",counter);
}

