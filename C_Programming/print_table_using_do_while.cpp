#include<stdio.h>
int main()
{
	int num,counter=1;
	printf("Enter Any Number\n");
	scanf("%d",&num);
	
	do
	{
		printf("\n%d*%d=%d",num,counter,num*counter);
		counter=counter+1;	
	}
	while(counter<=10);
}

