#include<stdio.h>
int main()
{
	int i,j,count=0;
	int arry[5];
	
	for(i=0;i<5;i++)
	{
		printf("Enter Number: ");
		scanf("%d",&arry[i]);
	}
	for(i=0;i<5;i++)
	{
		for(j=i+1;j<5;j++)
		{
			if (arry[i]==arry[j])
			{
				count++;
				break;
			}
		}
	}
	printf("No. of duplicate elements are: %d",count);
}
