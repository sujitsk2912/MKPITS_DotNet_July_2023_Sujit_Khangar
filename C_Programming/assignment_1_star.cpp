#include<stdio.h>
int main()
{
	int row,col,k,spc;
	spc=row+3-1;
	for(row=1;row<=3;row++)
	{
		for(k=spc;k>=1;k--)
		{
			printf(" ");
		}
		for(col=1;col<=row;col++)
		{
			printf(" *",col);
		}
		spc--;
		printf("\n");
	}
}
