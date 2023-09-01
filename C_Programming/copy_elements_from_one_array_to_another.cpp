#include<stdio.h>
int main()
{
	int i, arry1[5], arry2[5];
	for(i=0;i<5;i++)
	{
		printf("Enter Number: ");
		scanf("%d",&arry1[i]);
	}
	for(i=0;i<5;i++)
	{
		arry2[i]=arry1[i];
	}
	printf("\nElement of array 1: ");
	for (i=0;i<5;i++)
	{
		printf("%d",arry1[i]);
	}
	printf("\nElement of array 2: ");
	for (i=0;i<5;i++)
	{
		printf("%d",arry2[i]);
	}
}
