#include<stdio.h>
int main()
{
   int i;
   int sum=0;
   int marks[3];
   marks [0]=99;
   marks [1]=67;
   marks [2]=83;
   
   for(i=0;i<3;i++)
   {
   	printf("\nmarks= %d",marks[i]);
   	sum=sum+marks[i];
   }
   printf("\nTotal Marks= %d",sum);
}
