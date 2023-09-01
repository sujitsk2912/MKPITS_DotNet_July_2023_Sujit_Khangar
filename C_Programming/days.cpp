#include<stdio.h>
int main()
{
    int num1,num2,result=0;
    char op;
    printf("\n Enter Any 2 Numbers\n");
    scanf("%d%d",&num1,num2);
    printf("\nEnter(+,-,*,/)");
    fflush(stdin);
    scanf("%c",&op);
    switch (op)
   {
    case '+':
         result=num1+num2;
         break;
    
    case '-':
         result=num1-num2;
         break;
    
    case '*':
         result=num1*num2;
         break;
    
    case '/':
         result=num1/num2;
         break;
    
    default:
         printf("\n Invalid Op");
         break;
    } 
        printf("result=%d",result);
}
