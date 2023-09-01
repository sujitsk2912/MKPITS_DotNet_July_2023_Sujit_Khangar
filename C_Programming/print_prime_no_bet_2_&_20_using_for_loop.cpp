#include<stdio.h>
int main()
{
	int num,counter=2,rem=0;
	
	for(num=3;num<=20;num++)
	{
		counter=2;
		while(counter<num)
		{
	     	rem=num%counter;
			if(rem==0)
			{
				break;
			}
			counter++;
		}
		if(num==counter)
		{
			printf("\n%d",num);
		}
	}
	printf("\nThese are prime number's between 2 to 20");
}
