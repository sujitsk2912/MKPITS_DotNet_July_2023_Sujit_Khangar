#include<stdio.h>
int main()
{
	int counter=10,sum=0;
	while(counter<=20)
	{
		sum=sum+counter;
		counter=counter+1;
	}
	printf("\nsum=%d",sum);
}
