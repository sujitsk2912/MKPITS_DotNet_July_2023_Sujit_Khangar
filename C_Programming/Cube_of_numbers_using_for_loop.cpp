#include<stdio.h>
int main()
{
	int num,i,cube;
	printf("Enter a Number\n");
	scanf("%d",&num);
	
	for(i=1;i<=num;i++)
	{
		cube=i*i*i;
		printf("\n%d Cube is %d",i,cube);
	}
	
}
