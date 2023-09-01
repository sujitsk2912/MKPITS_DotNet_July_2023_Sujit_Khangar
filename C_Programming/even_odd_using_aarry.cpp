#include<stdio.h>
int main()
{
	int num,i;
	int arry[num];
	printf("Enter Value: ");
	scanf("%d",&num);
	printf("Enter %d numbers: ",num);
	for(i=1;i<=num;i++)
	{
		scanf("%d",&arry[i]);
	}
	printf("Even numbers are: ");
	for(i=1;i<=num;i++)
	{
		if(arry[i]%2==1)
		{
			printf("%d ",arry[i]);
		}
	}
		printf("\nOdd numbers are: ");
		for(i=1;i<=num;i++)
		{
			if(arry[i]%2==0)
			{
			printf("%d ",arry[i]);	
			}
		}	
}
