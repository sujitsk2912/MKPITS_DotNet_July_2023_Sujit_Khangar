#include<stdio.h>
int main()
{
	int row,col,k,spc;
	spc=row+4-1;
	for(row=1;row<=4;row++)
	{
		for(k=1;k<=spc;k++)
		{
			printf(" ");
		}
		for(col=1;col<=(2*row-1);col++)
		{
			printf("*");
		}
		spc--;
		printf("\n");
	}
}
