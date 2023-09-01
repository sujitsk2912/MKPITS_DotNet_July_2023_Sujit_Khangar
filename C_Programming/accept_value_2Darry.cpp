#include<stdio.h>
int main()
{
	int arry[3] [3];
	
	int row,col;

	for(row=0;row<3;row++)
	{
		for(col=0;col<3;col++)
		{
			printf("Enter Number: ");
			scanf("%d",&arry[row][col]);
		}
	}
	for(row=0;row<3;row++)
    {
		for(col=0;col<3;col++)
		{
			printf("arry[%d][%d]=[%d]\n",row,col,arry[row][col]);
		}
	}		
}
