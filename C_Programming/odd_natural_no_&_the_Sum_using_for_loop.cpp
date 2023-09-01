#include<stdio.h>
int main()
{
	int num1,num2,i;
	int sum=0;
	printf("Enter Range from:",num1);
	scanf("\n%d",&num1);
	printf("Enter Range To:",num2);
	scanf("\n%d",&num2);
	
	for(i=num1;i<=num2;i++)
	{
		if(i%2==1)
		{
			printf("\n%d",i);
			sum=sum+i;
		}
	}
	printf("\nThe sum of all Odd numbers are: %d",sum);
}
