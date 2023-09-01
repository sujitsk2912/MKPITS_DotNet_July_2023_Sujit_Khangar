#include<stdio.h>
int main()
{
	int num,factorial=1;
	printf("Enter Any Number\n");
	scanf("%d",&num);
	
	while(num>0)
	{
		factorial=factorial*num;
		num=num-1;	
	}
	printf("\nfactoial=%d",factorial);
}
