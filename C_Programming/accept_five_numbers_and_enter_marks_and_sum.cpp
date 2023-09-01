#include<stdio.h>
int main()
{
	int i,sum=0;
	int marks[5];
	for(i=0;i<5;i++)
	{
		printf("Enter marks: ");
		scanf("%d",&marks[i]);
	}
	for(i=0;i<5;i++)
	{
		sum=sum+marks[i];
	}
	printf("\n Total Marks= %d",sum);
}
