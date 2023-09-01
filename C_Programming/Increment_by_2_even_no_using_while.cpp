#include<stdio.h>
int main()
{
	int counter=2;
	while (counter<=10)
	{
		if(counter%2==0)
		{
			printf("\n%d",counter);
		}
		else
		{
			printf("\n %d",counter);
		}
		counter=counter+1;
	}
}
