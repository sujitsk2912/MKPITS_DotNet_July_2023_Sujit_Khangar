#include<stdio.h>
int main()
{
	int arry[2][2]={{1,2},{3,4}};
	int sum=0;
	int i,j;
	for(i=0;i<2;i++)
	{
		sum=0;
		for(j=0;j<2;j++)
		{
			sum+=arry[i][j];
		}
		printf("sum of row %d= %d\n",i+1,sum);
	    
	}
	for(i=0;i<2;i++)
	{
		sum=0;
		for(j=0;j<2;j++)
		{
			sum+=arry[j][i];
		}
		printf("sum of col %d= %d\n",i+1,sum);
	}
}
