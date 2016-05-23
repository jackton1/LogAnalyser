#include<stdio.h>
#include<stdlib.h>
#include<ctype.h>
#include<string.h>
//Create a program that take calculates the HB for each device with a giving duration
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
        print_star();
        printf("\n\t\tWELCOME TO MICARE LOG ANALYZER\n");
        print_star();
        printf("\n\t\tType 'H' for command list or 'S' to START \n");
        print_line();
        help();
}

void print_shortline(){
    int i;
    for(i=0; i <13; i++){
                        printf("_");
                    }
}
void print_star(){
    int i;
    for ( i=0; i < 80; i++){
        printf("*");}
}

void print_line(){
     int i;
    for ( i=0; i < 80; i++){
        printf("_");}
}

void help(){
        char arg;
        int count = 0;
        printf("\n:");
        scanf("%s",&arg);
        switch (arg){
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
    printf("\n:");
    //find a way to store the input
    //fgets (val, 60, stdin);
    scanf("%s", &val);
    //printf("value is", val);
       switch (val[0]){
        case 'r':
        case 'R':
            system("cls");
            main();
            break;
        case 's':
        case 'S':
            run();
            break;
        case 't':
        case 'T':
            terminate();
            break;
        default:
            system("cls");
            printf("Didn't Enter a right choice TRY AGAIN\n");
            test();
            break;
       }
}

void run(){
    int hr1,min1,hr2,min2;
    char t1, t2;
    int hour,m,m1,m2;
    int nc2000hb, nc500hb, nc103hb, nc201hb;
    char nc2000, nc500, nc103, nc201;
            printf("\n");
            printf("\nEnter the HB Settings like \"6H/6h\" for six hours interval 'm' for minute\n");
            print_line();
            printf("\n\nRouter(s)\n");
            print_shortline();
            printf("\n\nPatient Unit (NC-2000) HB Set to(Hours/Minutes):");
            scanf("%d%c", &nc2000hb,&nc2000);
            fflush(stdin);
            printf("\nBeacon(NC-201)HB Set to (Hours/Minutes):");
            scanf("%d%c",&nc201hb, &nc201);
            fflush(stdin);
            printf("\n\nEnd Device(s)\n");
            print_shortline();
            printf("\n\nPendant (NC-500) HB Set to (Hours/Minutes):");
            scanf("%d%c",&nc500hb, &nc500);
            fflush(stdin);
            printf("\nPull Station (NC-103) HB Set to (Hours/Minutes):");
            scanf("%d%c",&nc103hb, &nc103);
            fflush(stdin);
            printf("\n\nDURATION\n");
            print_shortline();
            printf("\n\nEnter the Start Time of the Test like HH:MM am/pm? ");
            int ret = scanf("%d:%d", &hr1, &min1);
            //Implement the am and pm analysis
            //Changing the data to display both the entered start time and the end time in a 12hour clock
            if(ret == 0){
                    char i[1];
                    printf("**Sorry that's not a number!!!***");
                    fflush(stdin);
                    printf("\nPress R to Restart: ");
                    gets(i);
                    if(i[0] == 'R'){
                            run();
                        }
                    else{
                        printf("Wrong Selection");
                        terminate();
                        }
                }

            else if(ret > 0){
                    printf("\nEnter the End Time of the Test using HH:MM am/pm? ");
                    scanf("%d:%d", &hr2, &min2);
                    if(min1 > min2){
                            m =  min1 - min2;
                            hour = hr2 - hr1 - 1;}
                    if(min2 > min1) {
                            hour = hr2 - hr1;
                            m1= min1;
                            m2= min2;
                                if (m1 > m2){
                                    m = m1 - 60 + m2;
                                    }
                                else {
                                    m = m2 - m1;}
                                    }
                print_line();
                printf("\nHB EXPECTED FOR EACH DEVICE \n");
                print_line();
                printf("\nThe total time is %d hours %d minutes \n", hour, m);
                if (nc2000 == 'h'||nc201 == 'h'||nc500 == 'h'||nc103 == 'h' ){
                    printf("%c %c %c %c",nc2000,nc201,nc500,nc103);
                    int total_hours = hour;
                    int val[4]={nc2000hb,nc201hb,nc500hb,nc103hb};
                    int i;
                        int HB[4];
                        for(i=0; i<4; i++){
                            HB[i]=total_hours/val[i];
                        }
                    printf("\nRouter(s)\n");
                    print_shortline();
                             if(val[0] > total_hours){printf("\n\nPatient unit (NC-2000): Sorry No HB in that duration\n");}
                             if(val[0] < total_hours) {printf("\n\nPatient unit (NC-2000): %d HB(s) Expected\n",HB[0]);}
                             if(val[1] > total_hours){printf("\nBeacon (NC-201)       : Sorry No HB in that duration\n\n");}
                             if(val[1] < total_hours){ printf("\nBeacon (NC-201)       : %d HB(s) Expected\n\n",HB[1]);}
                    printf("\nEnd Devices\n");
                    print_shortline();
                             if(val[2] > total_hours){printf("\n\nPendant (NC-500)       : Sorry No HB in that duration\n");}
                             if(val[2] < total_hours){printf("\n\nPendant (NC-500)       : %d HB(s) Expected\n",HB[2]);}
                             if(val[3] > total_hours){printf("\nPull Station (NC-103)  : Sorry No HB in that duration\n");}
                             if(val[3] < total_hours){printf("\nPull Station (NC-103)  : %d HB(s) Expected\n",HB[3]);}
                             else{

                             }
                        }
                else if (nc2000 == 'm'||nc201 == 'm'||nc500 == 'm'||nc103 == 'm' ){
                        printf("minutes");

                }
               // printf(" %d nc 2000\n %d nc 500\n %d nc 201\n %d nc 103", nc2000hb, nc500hb, nc201hb, nc103hb);
            //if(hour == )
            terminate();
        }
}

void terminate(){
        char val;
        fflush(stdin);
        printf("\nAre you sure you want to Quit? Press'y/n' or 'r' to restart>:");
        scanf("%c", &val);
        switch(val){
            case 'y':
            case 'Y':
                //printf("\nPress ENTER a 2 times to terminate the program");
                //fflush(stdout);
                // getchar(); to terminate the program
                //getchar(); to restart:
                break;
            case 'r':
            case 'R':
                system("cls");
                main();
                break;
            case 'n':
            case 'N':
                run();
                break;
            default:
                printf("Didn't Enter a right choice\n");
                terminate();
                break;
            }
}
