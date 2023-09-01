#include<stdio.h>
int main()
{
	int counter=2;
	do
	{
		if(counter%2==0)
		{
			printf("\n%d",counter);
		}
		while (counter<=10);
		counter=counter+1;
	}
	
}
