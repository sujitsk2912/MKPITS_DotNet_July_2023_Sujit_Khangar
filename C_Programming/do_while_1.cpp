#include<stdio.h>
int main()
{
	int rem=0,num,counter=2;
	printf("Enter Any Number\n");
	scanf("%d",&num);
	do
	{
		rem=num%counter;
		if(rem==0)
		{
			printf("It is Not prime number\n");
			break;
		}
		counter=counter+1;
	}
	while(counter<num);
	if(num==counter)
	{
		printf("It is a prime number");
	}
}
