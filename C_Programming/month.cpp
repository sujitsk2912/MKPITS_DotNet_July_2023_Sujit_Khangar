#include<stdio.h>
int main()
{
	int month;
	printf("Enter Month in Number\n");
	scanf("%d",&month);
	
	switch (month)
	{
		case 1:
	    	printf("\n31 Days");
	     	break;
	    
	    case 2:
	    	printf("\n29 Days");
	    	break;
	    	
	    case 3:
	    	printf("\n30 Days");
	    	break;
	    	
	    case 4:
	    	printf("\n31 Days");
	    	break;
	    
	    case 5:
	    	printf("\n28 Days");
	    	break;
	    	
	    case 6:
	    	printf("\n29 Days");
	    	break;
	    	
	    case 7:
	    	printf("\n31 Days");
	     	break;
	    
	    case 8:
	    	printf("\n29 Days");
	    	break;
	    	
	    case 9:
	    	printf("\n30 Days");
	    	break;
	    	
	    case 10:
	    	printf("\n31 Days");
	    	break;
	    
	    case 11:
	    	printf("\n28 Days");
	    	break;
	    	
	    case 12:
	    	printf("\n29 Days");
	    	break;
	    	
	    	
	    	default:
	    	printf("No months found");
	    	break;
    }		
}
