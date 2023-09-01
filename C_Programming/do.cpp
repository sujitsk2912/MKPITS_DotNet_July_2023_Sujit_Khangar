#include<stdio.h>
int main()
{
	int rem=0,num,counter=0;
	printf("Enter Any Number\n");
	scanf("%d",&num);
	
	do
	{
		rem=num%counter;
		if(rem==0)
		{
			printf("\nIt is Not prime number\n");
			break;
		}
		counter=counter+1;
	}
	while(counter<num);
	if(num==counter)
	{
		printf("\nIt is a prime number");
	}
}
