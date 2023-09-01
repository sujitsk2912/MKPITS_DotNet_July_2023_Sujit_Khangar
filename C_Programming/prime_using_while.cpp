#include<stdio.h>
int main()
{
	int rem=0,num,counter=2;
	printf("Enter Number\n");
	scanf("%d",&num);
	
	while(counter<num)
	{
		rem=num%counter;
		
	if(rem==0)
		{
			printf("The Number is not Prime\n");
			break;
		}
		counter=counter+1;
	}
	if(num==counter)
		{
	     	printf("The Number is Prime\n");
		}
}
