#include<stdio.h>
int main()
{
    int num,i,sum=0;
    printf("Enter the number: ");
    scanf("%d",&num);
    
    for(i=1;i<num;i++)
    {
    	if(num%i==0)
    	{
    		sum=sum+i;
    		printf("\n%d",i);
		}
    }
        if (sum==num)
        {
        	printf("\n\nSum of the all divisible numbers is %d",sum);
        	printf("\n\ntherefor %d is a perfect number",num);
		}
        else
        {
        	printf("\n\nSum of the all divisible numbers is %d",sum);
    	    printf("\n\nTherefor %d is not a perfect number",num);
	    }
}
