#include<stdio.h>
int main()
{
	int num,counter=2,rem=0;
	
	while(counter>=20)
	{
		rem=num%counter;
		if(counter<num)
		{
			printf("%d",counter);
		}
		
	}
	counter=counter+1;
}
