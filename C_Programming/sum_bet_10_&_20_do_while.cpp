#include<stdio.h>
int main()
{
	int counter=10,sum=0;
	do
	{
		sum=sum+counter;
		counter=counter+1;
	}
		while(counter<=20);
	printf("\nsum=%d",sum);
}
