#include<stdio.h>
int main()
{
    int i;
	for(i=1;i<=10;i++)
	{
		printf("\n%d",i);
		if(i%2==1)
		{
		break;
		}
	}
	printf("\nBye");
}
