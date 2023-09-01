
#include<stdio.h>
int main()
{
	int arry[2] [2] = {{1,2}, {3,4}};
	int row, col;
	for (row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			printf("arry[%d] [%d] = [%d]\n",row,col,arry[row][col]);
		}
	}
}
