#include<stdio.h>
int main()
{
	int i,j,num,a,arry[100];
	printf("Enter value of N: ");
	scanf("%d",&num);
	printf("Enter Number:\n");

	for(i=0;i<num;i++)
		scanf("\n%d",&arry[i]);
		for(i=0;i<num;i++)
		{
			for(j=i+1;j<num;j++)
			{
				if(arry[i] < arry[j])
				{
					a = arry[i];
					arry[i] = arry[j];
					arry[j] = a;
				}
			}
		}
		printf("The numbers in assending order are given as below:\n");
    	for(i=0;i<num;i++)
    	{
    		printf("\n%d",arry[i]);
		}	
}
	
