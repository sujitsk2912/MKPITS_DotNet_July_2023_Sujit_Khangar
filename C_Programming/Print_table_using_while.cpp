#include<stdio.h>
int main()
{
	int num,counter=1;
	printf("Enter Any Number\n");
	scanf("%d",&num);
	
	while(counter<=10)
	{
		printf("\n%d*%d=%d",num,counter,num*counter);
		counter=counter+1;	
	}
}

