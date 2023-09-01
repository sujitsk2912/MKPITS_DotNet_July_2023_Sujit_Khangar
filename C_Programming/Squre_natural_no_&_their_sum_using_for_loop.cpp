#include<stdio.h>
int main()
{
	int num1,num2,i,sum=0;
	printf("Enter Number From:",num1);
	scanf("\n%d",&num1);
	printf("Enter Number To:",num2);
	scanf("\n%d",&num2);
	
	for(i=num1;i<=num2;i++)
	{
		sum+=(i*i);
		printf("\n%d",i*i);
	}
	printf("\n\nThe sum of the Squre natural Numbers are: %d",sum);
}

