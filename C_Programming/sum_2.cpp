#include<stdio.h>
int main()
{
	int counter=1,sum=0;
	do
	{
	 	sum=sum+counter;
	 	counter=counter+1;
	 }
	 while(counter<=5);
	 printf("sum=%d",sum);
}



