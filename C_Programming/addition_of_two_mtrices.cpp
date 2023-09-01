#include<stdio.h>
int main()
{
	int row,col;
	int arry1[2][2]={{1,2},{3,4}};
	int arry2[2][2]={{5,6},{7,8}};
	int arry3[2][2];
	
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			arry3[row][col]=arry1[row][col]+arry2[row][col];
		}
	}
		for(row=0;row<2;row++)
		{
			for(col=0;col<2;col++)
			{
				printf("[%d]",arry3[row][col]);
			}
			printf("\n");
		}
}
