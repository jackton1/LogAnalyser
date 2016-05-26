#include<stdio.h>
#include<stdlib.h>
#include<ctype.h>
#include<string.h>
//A program that calculates the HB for each device with a giving duration
//It should take the start and end time in  24 hours
// give the expected number of HB for each device during that duration
//Type NEXT to continue the execution of the program or EXIT to close.
/*Implement a minute conversion of the hours and add it to the minutes to get the total duration*/
void test();
void run();
void help();
void print_star();
void terminate();
void print_line();
void print_shortline();

void main(){
        //system("cls");
        system("COLOR F1");
        system("mode CON: COLS=85 LINES=50");
        print_star();
        printf("\n\t\t\tWELCOME TO MICARE LOG ANALYZER\n\n");
        print_star();
        print_star();
        printf("\t\tType \"H\" for HELP to show list of commands or \"S\" to START \n");
        print_line();
        help();
}

void print_shortline(){
    int i;
    for(i=0; i <13; i++){
         printf("_"); }
}

void print_star(){
    int i;
    for ( i=0; i < 85; i++){
        printf("*");}
}

void print_line(){
     int i;
    for ( i=0; i < 85; i++){
        printf("_");}
}

void help(){
        char arg[1];
        int count = 0;
        printf("\n:");
        gets(arg);
        switch (arg[0]){
            case 's':
            case 'S':
                run();
                break;
            case 'h':
            case 'H':
                test();
                break;
            default:
                printf("Sorry not a valid command\n");
                help();
                break;
    }
}

void test(){
    char val[1];
    printf("\nThese are the list of commands available\n");
    print_line();
    printf("\n-'S' to start program\n-'R' to restart\n-'T' to terminate\n");
   do{ printf("\n:");
      gets(val);
      switch (val[0]){
        case 'R':
        case 'r':
            system("cls");
            main();
            break;
        case 'S':
        case 's':
            run();
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
    }
       while(strlen(val) != 1);
}

void run(){
    unsigned int hr1,min1,hr2,min2;
    int counter = 0;
    char t1[20];
    char t2[20];
    int noon = 12;
    char am[] = "am";
    char pm[]  = "pm";
    unsigned int hour,m,m1,m2;
    unsigned int nc2000hb, nc500hb, nc103hb, nc201hb;
    char nc2000[1], nc500[1], nc103[1], nc201[1];
            printf("\n");
        do{ printf("\nEnter the HB Settings like \"6H or 6h\" for Six hours interval 'm' for minute\n");
            print_line();
            printf("\n\nRouter(s)\n");
            print_shortline();
            printf("\n\nPatient Unit (NC-2000) HB Set to(Hours/Minutes): ");
            scanf("%d%c", &nc2000hb,&nc2000);
            fflush(stdin);
            printf("\nBeacon(NC-201)HB Set to (Hours/Minutes): ");
            scanf("%d%c",&nc201hb, &nc201);
            fflush(stdin);
            printf("\n\nEnd Device(s)\n");
            print_shortline();
            printf("\n\nPendant (NC-500) HB Set to (Hours/Minutes): ");
            scanf("%d%c",&nc500hb, &nc500);
            fflush(stdin);
            printf("\nPull Station (NC-103) HB Set to (Hours/Minutes): ");
            scanf("%d%c",&nc103hb, &nc103);
            fflush(stdin);
            counter += 1;
            if(counter == 3){
                print_line();
                printf("\nYou have exceeded the number of retries\n");
                print_line();
                terminate();
            }}
        while (isdigit(nc2000hb) != 0||isdigit(nc500hb) !=0||isdigit(nc103hb)!= 0||isdigit(nc201hb)!=0);

            printf("\n\nDURATION\n");
            print_shortline();
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

                        if(hour <= 24 ){
                                print_line();
                                printf("\nHB EXPECTED FOR EACH DEVICE \n");
                                print_line();
                                printf("\nThe total time is %d hours %d minute(s) \n", hour, m);
                                printf("\nRouter(s)\n");
                                print_shortline();
                                int total_hours = hour;
                                unsigned int total_min = hour * 60 + m;
                                unsigned int val[4]={nc2000hb,nc201hb,nc500hb,nc103hb};
                                int i;
                                unsigned int HB[4], HB2[4];
                                    for(i=0; i<4; i++){
                                        HB2[i]=total_min/val[i];
                                        HB[i]=total_hours/val[i];
                                        }
                                    if(nc2000[0] == 'h'){
                                        if(val[0]> total_hours){
                                            printf("\n\nPatient unit (NC-2000): NO HB(s) Expected\n");}
                                        else{
                                            printf("\n\nPatient unit (NC-2000): %d HB(s) Expected\n",HB[0]);}}

                                    if(nc2000[0] == 'm'){printf("\n\nPatient unit (NC-2000): %d HB(s) Expected\n",HB2[0]);}

                                    if(nc201[0] == 'h') {
                                        if(val[1]> total_hours){
                                            printf("\nBeacon (NC-201)         : NO HB(s) Expected\n\n\nEnd Devices\n");}
                                    else{
                                        printf("\nBeacon (NC-201)         : %d HB(s) Expected\n\n\nEnd Device(s)\n",HB[1]);}}

                                    if(nc201[0] == 'm') {printf("\nBeacon (NC-201)         : %d HB(s) Expected\n\n\nEnd Device(s)\n",HB2[1]);}

                                    if(nc500[0] == 'h') {print_shortline();
                                        if(val[2]> total_hours){
                                            print_shortline();
                                            printf("\n\nPendant (NC-500)      : NO HB(s) Expected\n");}
                                    else{
                                        printf("\n\nPendant (NC-500)      : %d HB(s) Expected\n",HB[2]);}}
                                    if(nc500[0] == 'm'){
                                        print_shortline();
                                        printf("\n\nPendant (NC-500)      : %d HB(s) Expected\n",HB2[2]);}
                                    if(nc103[0] == 'h') {
                                        if(val[3]> total_hours){
                                            printf("\nPull Station (NC-103)   : NO HB(s) Expected\n");}
                                        else{
                                            printf("\nPull Station (NC-103)   : %d HB(s) Expected\n",HB[3]);}}
                                    if(nc103[0] == 'm') {printf("\nPull Station (NC-103)   : %d HB(s) Expected\n",HB2[3]);}
                                }

                        else{
                                printf("Sorry You can only Check For Duration of 24 hours");
                            }
                terminate();
}

void terminate(){

        char val;
        int count = 0;
        do{
        fflush(stdin);
        printf("\nAre you sure you want to Quit? Press'Y/N' or 'R' to restart>:");
        scanf("%c", &val);
        val = tolower(val);
        count+= 1;
        switch(val){
            case 'y':
                //printf("\nPress ENTER a 2 times to terminate the program");
                //fflush(stdout);
                // getchar(); to terminate the program
                //getchar(); to restart:
                break;
            case 'r':
                system("cls");
                fflush(stdin);
                main();
                break;
            case 'n':
                run();
                break;
            default:
                printf("\nDidn't Enter a right choice\n");
                print_line();
                printf("\nTRY AGAIN YOU HAVE %d TRIE(S) LEFT\n", 3-count);
                //terminate();
                break;
                }
         if(count == 2){
            printf("Exiting Program !!!");
            exit(0);
         }
        }
        while(val != 'r' || val != 'n' || val != 'y');

}
