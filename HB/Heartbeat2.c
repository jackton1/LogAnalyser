#include<stdio.h>
#include<stdlib.h>
#include<ctype.h>
#include<string.h>
//A program that calculates the HB for each device with a giving duration
//It should take the start and end time in  24 hours
// give the expected number of HB for each device during that duration
//Type NEXT to continue the execution of the program or EXIT to close.
/*Implement a minute conversion of the hours and add it to the minutes to get the total duration*/
void start(void);
void print(char str[]);
int data_get();
void test();
int run();
void help();
void terminate();
int write_to_file();


void start(void)
{
    char s[5] = "star";
    char l[5] = "line";
    system("COLOR F1");
    system("mode CON: COLS=85 LINES=50");
    print(s);
    printf("\n\t\t\tWELCOME TO MICARE LOG ANALYZER\n\n");
    print(s);
    print(s);
    printf("\t\tType \"H\" for HELP to show list of commands or \"S\" to START \n");
    print(l);
    help();
    //system("cls");
}

void print(char str [])
{
    int i;
	if(strcmp("sline",str) == 0){
   	    for(i=0; i <13; i++){
        	printf("_");
    	}
    }
    if(strcmp("star",str) == 0){
    	for (i=0; i < 85; i++){
        	printf("*");
        }
    }
   if(strcmp("line",str) == 0){
    	for (i=0; i < 85; i++){
            printf("_");
    	}
    }

}


int data_get()
{
    char s[5] = "star";
    char l[5] = "line";
    char sl[6] = "sline";
	unsigned int hr1,min1,hr2,min2;
    int counter = 0;
    char t1[20];
    char t2[20];
    int noon = 12;
    char am[] = "am";
    char pm[]  = "pm";
    unsigned int hour,m,m1,m2;
    unsigned int nc2000hb, nc500hb, nc103hb, nc201hb;
    char nc2000, nc500, nc103, nc201;
        printf("\n");
        printf("\nEnter the HB Settings like \"6H or 6h\" for Six hours interval 'm' for minute\n");
        print(l);
        printf("\n\nRouter(s)\n");
        print(sl);
        printf("\n\nPatient Unit (NC-2000) HB Set to(Hours/Minutes): ");
        scanf("%d%c", &nc2000hb,&nc2000);
        fflush(stdin);
        printf("\nBeacon(NC-201)HB Set to (Hours/Minutes): ");
        scanf("%d%c",&nc201hb, &nc201);
        fflush(stdin);
        printf("\n\nEnd Device(s)\n");
        print(sl);
        printf("\n\nPendant (NC-500) HB Set to (Hours/Minutes): ");
        scanf("%d%c",&nc500hb, &nc500);
        fflush(stdin);
        printf("\nPull Station (NC-103) HB Set to (Hours/Minutes): ");
        scanf("%d%c",&nc103hb, &nc103);
        fflush(stdin);
        printf("\n\nDURATION\n");
        print(sl);
        fflush(stdin);
        printf("\n\nEnter the Start Time of the Test using 12hour clock like HH:MM am/pm?: ");
        scanf(" %d:%d %s", &hr1, &min1, t1);
        //Implement the am and pm analysis
        //Changing the data to display both the entered start time and the end time in a 12hour clock
        fflush(stdin);
        printf("\nEnter the End Time of the Test using 12hour clock like HH:MM am/pm?: ");
        scanf(" %d:%d %s", &hr2, &min2, t2);
            if (strcmp(am,t1) == 0){
                     hr1 = hr1;
                     }
            if (strcmp(pm,t1) == 0){
                     hr1 = hr1 + 12;
                     }
            if (strcmp(am,t2) == 0){
                     hr2= hr2;
                     }
            if (strcmp(pm, t2) == 0){
                     hr2 = hr2 + 12;
                     }
            if(min1 > min2){
                     m =  (min2+ 60) - min1;
                     hour = hr2 - hr1 - 1;}
            if(min2 >= min1) {
                    hour = hr2 - hr1;
                    m = min2 - min1;}

    	run(nc2000hb,nc2000,nc201hb,nc201,nc500hb,nc500,nc103hb,nc103,hr1,min1,t1,hr2,min2,t2, hour, m);

}


int run(nc2000hb,nc2000,nc201hb,nc201,nc500hb,nc500,nc103hb,nc103,hr1,min1,t1,hr2,min2,t2,hour,m)
{
    int i;
    FILE *fp;
    fp = fopen("Micare Test Report 30-05-2016.doc","w");
	if (fp == NULL){
        perror("\nError Opening File");
	}
    if (fp != NULL){
	    char s[5] = "star";
	    char l[5] = "line";
	    char sl[6] = "sline";
		fprintf(fp,"MICARE TEST REPORT\n");
		for (i=0; i < 70; i++){
	            fprintf(fp,"_");
	    	}
	    fprintf(fp,"\nStart Time: %d:%d %s \nEnd Time: %d:%d %s\n" ,hr1,min1,t1,hr2,min2,t2);
	    for (i=0; i < 70; i++){
	            fprintf(fp,"_");
	    	}
	    fprintf(fp,"\nHB EXPECTED FOR EACH DEVICE \n");
	    for (i=0; i < 70; i++){
	            fprintf(fp,"_");
	    	}
	    fprintf(fp,"\nThe total time is %d hours %d minute(s) \n", hour, m);
	    fprintf(fp,"\nRouter(s)\n");
	    for (i=0; i < 14; i++){
	            fprintf(fp,"_");
	    	}
	    int total_hours = hour;
	    unsigned int total_min = hour * 60 + m;
	    unsigned int val[4]={nc2000hb,nc201hb,nc500hb,nc103hb};
	    unsigned int HB[4], HB2[4];
	        for(i=0; i<4; i++){
	            HB2[i]=total_min/val[i];
	            HB[i]=total_hours/val[i];
	            }
	        if(nc2000== 'h'){
	            if(val[0] > total_hours){
	                fprintf(fp,"\n\nPatient unit (NC-2000): NO HB(s) Expected\n");}
	            else{
	                fprintf(fp,"\n\nPatient unit (NC-2000): %d HB(s) Expected\n",HB[0]);}}

	        if(nc2000 == 'm'){
	            fprintf(fp,"\n\nPatient unit (NC-2000): %d HB(s) Expected\n",HB2[0]);
	       	}
			if(nc201 == 'h') {

	             if(val[1]> total_hours){
					fprintf(fp,"\nBeacon (NC-201)         : NO HB(s) Expected\n\n\nEnd Devices\n");
	                    for (i=0; i < 14; i++){
	                        fprintf(fp,"_");
	                    }
				 }
	        	 else{
	           		fprintf(fp,"\nBeacon (NC-201)         : %d HB(s) Expected\n\n\nEnd Device(s)\n",HB[1]);
	                    for (i=0; i < 14; i++){
	                        fprintf(fp,"_");
	                    }
	                }
	        }

	        if(nc201 == 'm') {
	        	 fprintf(fp,"\nBeacon (NC-201)         : %d HB(s) Expected\n\n\nEnd Device(s)\n",HB2[1]);
	        }

	        if(nc500 == 'h') {print(sl);

	             if(val[2]> total_hours){
	                 print(sl);
	                 fprintf(fp,"\n\nPendant (NC-500)      : NO HB(s) Expected\n");
	             }
	        	 else{
	            	 fprintf(fp,"\n\nPendant (NC-500)      : %d HB(s) Expected\n",HB[2]);
	             }
	        }
	        if(nc500 == 'm'){
	             for (i=0; i < 14; i++){
	                fprintf(fp,"_");
	             }
	             fprintf(fp,"\n\nPendant (NC-500)      : %d HB(s) Expected\n",HB2[2]);
	        }
	        if(nc103 == 'h') {
	            if(val[3]> total_hours){
	                fprintf(fp,"\nPull Station (NC-103)   : NO HB(s) Expected\n");
	            }
	            else{
	                fprintf(fp,"\nPull Station (NC-103)   : %d HB(s) Expected\n",HB[3]);
	            }
	        }
	        if(nc103 == 'm') {
	        	fprintf(fp,"\nPull Station (NC-103)   : %d HB(s) Expected\n",HB2[3]);
	        }
	    printf("\n");
	    print(sl);
	    printf("\nSAVED TO FILE\n");
	    print(sl);
    }
 	terminate();
}

void terminate()
{
    char l[5] = "line";
    int val;
    int count = 0;
    LOOP:do {
	        fflush(stdin);
	        printf("\n");
	        printf("\nAre you sure you want to Quit? Press'Y/N' or 'R' to restart>:");
	        scanf("%c", &val);
	        val = tolower(val);
	        switch(val){
	        case 'y':
                    exit(0);
	                break;
	        case 'r':
	                system("cls");
	                fflush(stdin);
	                start();
	                break;
	        case 'n':
	                data_get();
	                break;
	        default:
                    count += 1;
                    print(l);
	                printf("\nDidn't Enter a right choice TRY AGAIN!!!\n");
	                print(l);
                    if(count == 3 ){
                        printf("\nYou've exceeded the number of retries !!!\n");
                        print(l);
                        printf("\nEXITING POGRAM !!!");
                        exit(0);
                    }
                    else{
	                goto LOOP;
                    }
            }
     	}while(val != 'r' || val != 'n' || val != 'y');

}

void help()
{
        char arg[1];
        printf("\n:");
        gets(arg);
        switch (arg[0]){
        case 's':
        case 'S':
                data_get();
                break;
        case 'h':
        case 'H':
                test();
                break;
        default:
                printf("Sorry not a valid command\n");
                break;
        }
}

void test(){
    char val[1];
    char l[5] = "line";
    printf("\nThese are the list of commands available\n");
    print(l);
    printf("\n-'S' to start program\n-'R' to restart\n-'T' to terminate\n");
   do {
	   	printf("\n:");
	    gets(val);
	    switch (val[0]){
	    case 'R':
	    case 'r':
	            system("cls");
	            start();
	           	break;
	    case 'S':
	    case 's':
	           	data_get();
	            break;
	    case 'T':
	    case 't':
	            terminate();
	            break;
	    default:
	            //system("cls");
	            printf("Didn't Enter a right choice TRY AGAIN\n");
	            //test();
	           	break;
	    }
    } while(strlen(val) != 1);
}




void main(void)
{
        start();
}
