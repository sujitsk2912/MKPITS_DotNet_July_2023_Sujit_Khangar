#include<stdio.h>
int main()
{
	int num,i,sum=0,rem;
	printf("Enter Any Number\n");
	scanf("\n%d",&num);
	
	for(i=num;i<=num;i++)
	{
		rem=num%i;
		if(num%i==0)
		{
			printf("It is perfect number",i);
		}
		sum=sum+1;
	}
}
