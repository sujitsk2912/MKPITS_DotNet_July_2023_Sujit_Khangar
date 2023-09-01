#include<stdio.h>
int main()
{
	int counter=20;
	do
	{
		if(counter%2==1)
		{
			printf("\n%d",counter);
		}
		counter=counter+1;
	}
		while(counter<=30);
}
