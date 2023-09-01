#include<stdio.h>
int main()
{
	int rem=2,num,counter=2;
	printf("Enter Number\n");
	scanf("%d",&num);
	
	do
	{
		rem=num%counter;
		
	    if(rem==0)
		{
			printf("The Number is not Prime\n");
			break;
		}
		counter=counter+1;
	}
	while(counter<num);
	if (num==counter)
  	    {
	    	printf("The Number is Prime\n");
     	}	
}
