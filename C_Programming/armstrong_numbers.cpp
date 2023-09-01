#include<stdio.h>
int main()
{
    int num,i,sum=0,rem=0;
    printf("Enter Any three digit number: ");
    scanf("%d",&num);

    for(rem=num;num!=0;num=num/10)
	{
         i=num % 10;
         sum=sum+(i*i*i);
    }
    if(sum==rem)
    {
    	printf("%d is an Armstrong number.\n",rem);
	}  
    else
    {
    	printf("%d is not an Armstrong number.\n",rem);
	}
         

}
