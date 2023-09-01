#include<stdio.h>
int main()
{
	int num,counter,res=0;
	printf("Enter Any Number\n");
	scanf("\n%d",&num);
	
	for(counter=1;counter<=10;counter++)
	{
		res=num*counter;
		printf("\n%d*%d=%d",num,counter,res);
	}
}
