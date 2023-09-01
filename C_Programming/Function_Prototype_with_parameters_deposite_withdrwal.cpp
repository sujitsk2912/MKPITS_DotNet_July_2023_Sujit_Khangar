#include<stdio.h>
int deposite(int amt, int bal);
int withdrawl(int amt, int bal);
int main()
{
 char ch='d';
 char ch='w';
do
  {
	{
	
	int amt,bal=1000;
	printf("Enter Amount: ");
	scanf("\n%d",&amt);
	deposite(amt,bal);
	withdrawl(amt,bal);
    }
       int deposite(int amt, int bal)
    {
	bal=bal+amt;
	printf("\nAmount deposited succesfully, Total Balance= %d",bal);
	printf("Do you Want to Deposite, Press 'd'\n");
	scanf("%c",&ch;)
    }
     int withdrawl(int amt, int bal)
    {
	bal=bal-amt;
	printf("\nAmount withdrawled succesfully, Total Balance= %d",bal);
	printf("Do you Want to Withdrwl, Press 'w'\n");
	scanf("%c",&ch;)
    }
     while(ch=='d''w');
  }
}
