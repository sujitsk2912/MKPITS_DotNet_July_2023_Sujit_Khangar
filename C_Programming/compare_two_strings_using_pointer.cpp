#include<stdio.h>
#include<string.h>
int main()
{
	int result;
	char str1[10];
	char *ptr1;
	printf("Enter String 1: ");
	gets(str1);
	char str2[10];
	char *ptr2;
	printf("Enter String 2: ");
	gets(str2);
	result=strcmp(str1,str2);
	if(result==0)
	{
		
		printf("String's Are Matched");
	}
	else
	{
		printf("String's Are Not Matched");
	}
	
}
