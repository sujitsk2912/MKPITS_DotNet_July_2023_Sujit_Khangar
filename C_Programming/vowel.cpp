#include<stdio.h>
int main()
{
char ch;
printf("Enter Charachter\n");
scanf("%c",&ch);
switch (ch)
  {
	case 'a':
	case 'e':
	case 'i':
	case 'o':
	case 'u':
		printf("it is vowel");
		break;
		default:
		printf("it is not vowel");
		break;
  }
}
