/*
 * File:	 Heart beat Log Analyzer -test.c
 * Author:   Tonye Jack (tonyejck@gmail.com)
 * 
 * This project is a Log Report Analyzer which calculates the user defined data. 
 * And generates a log report stored in a specified location in the local drive 
 * which can be in doc or txt format.
 */

#include<stdio.h>
#include<string.h>
#include<stdlib.h>
#include<ctype.h>
#include<time.h>

/*Ouput to the console*/
#define con stdout

/*Calculate the result for the log data, like the duration of the test, total individual expected heart beat
for each device*/

int decode_log();
int data_get(void);
int user_input(void);
void print_stars(FILE* fp, int len);
void print_hline(FILE* f, int len);
void init_console(void);
void print_goodbye(void);
void print_help(void);
void print_welcome(void);
int get_date(void);


int decode_log(nc2000hb,nc2000,nc201hb,nc201,nc500hb,nc500,nc103hb,nc103,hr1,min1,t1,hr2,min2,t2,hour,m)
{
  int i;
  time_t t;
  time(&t);
  FILE *fp;
  /*Creates a file in the location to write in the log information*/
  fp = fopen("../Logs/30th May 2016 Micare Report.doc","w");
    if (fp == NULL){
        /*Displays an error message on the console when file cant be open or written into*/
        perror("\nError Opening File");
    }
    if (fp != NULL){
        /*Writes the log data in the file*/
        char absent[2] = "No";
        /*Prints the Date and time the file was generated*/
        fprintf(fp,"\t\tCreated: %s \n\n",ctime(&t));

        /*Writing the Log data to the file with the information from the user */
        fprintf(fp,"\n\nMICARE TEST REPORT\n");
        print_hline(fp , 70);
        fprintf(fp,"\nStart Time: %d:%d %s \nEnd Time: %d:%d %s\n" ,hr1,min1,t1,hr2,min2,t2);
        print_hline(fp , 70);
        fprintf(fp,"\nHB EXPECTED FOR EACH DEVICE \n");
        print_hline(fp , 70);
        fprintf(fp,"\nThe total time is %d hours %d minute(s) \n", hour, m);
        fprintf(fp,"\nRouter(s)\n");
        print_hline(fp , 14);
        int total_hours = hour;
        /*Converts the time from hours to minutes to get the total minutes during the duration*/
        unsigned int total_min = hour * 60 + m;
        /*Gets the HB value from the user storing it in an array*/
        unsigned int val[4]={nc2000hb,nc201hb,nc500hb,nc103hb};
        unsigned int HB[4], HB2[4];
        for(i=0; i<4; i++){
              HB2[i]=total_min/val[i];
              HB[i]=total_hours/val[i];
          }
        if(nc2000== 'h'){
              if(val[0] > total_hours){
                  fprintf(fp,"\n\nPatient unit (NC-2000): %s HB(s) Expected\n", absent);
              }else{
                  fprintf(fp,"\n\nPatient unit (NC-2000): %d HB(s) Expected\n",HB[0]);}
          }

        if(nc2000 == 'm'){
              fprintf(fp,"\n\nPatient unit (NC-2000): %d HB(s) Expected\n",HB2[0]);
          }

        if(nc201 == 'h') {
             if(val[1]> total_hours){
                  fprintf(fp,"\nBeacon (NC-201)         : %s HB(s) Expected\n\n\nEnd Devices\n", absent);
                  print_hline(fp , 14);
            }else{
                  fprintf(fp,"\nBeacon (NC-201)         : %d HB(s) Expected\n\n\nEnd Device(s)\n",HB[1]);
                  print_hline(fp , 14);
                }
            }

        if(nc201 == 'm') {
             fprintf(fp,"\nBeacon (NC-201)         : %d HB(s) Expected\n\n\nEnd Device(s)\n",HB2[1]);
            }

        if(nc500 == 'h') {
            print_hline(fp, 20);
            if(val[2]> total_hours){
                fprintf(fp,"\n\nPendant (NC-500)      : NO HB(s) Expected\n");
            }else{
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
            }else{
                  fprintf(fp,"\nPull Station (NC-103)   : %d HB(s) Expected\n",HB[3]);
                 }
            }
        if(nc103 == 'm') {
            fprintf(fp,"\nPull Station (NC-103)   : %d HB(s) Expected\n",HB2[3]);
          }

          fclose(fp);
          printf("\n");
          print_hline(con, 20);
          printf("\nSAVED TO FILE\n");
          print_hline(con, 20);
     }
}

int get_date(void)
{
  //FIX ISSUES WITH DATE ALLOCATION
 
  //typedef struct {
  // char date[20];
  // } Date;


  char date[11];
  char *ch;
  printf("Enter the Date of Test DD/MM/YY >");
  fgets(date, 11 ,stdin);
  ch = strtok(date, "/");
    // while(ch != NULL) {
    //       printf("%s\n", ch);
    //       ch = strtok(NULL,"/");  
    //}
    //return date;
}


int data_get(void)
{
  unsigned int hr1,min1,hr2,min2;
  int counter = 0;
  char t1[20], t2[20];
  int noon = 12;
  char am[] = "am";
  char pm[]  = "pm";
  unsigned int hour,m,m1,m2;
  unsigned int nc2000hb, nc500hb, nc103hb, nc201hb;
  char nc2000, nc500, nc103, nc201;
  char date[11] = get_date();
  printf("\n");
  printf("\nEnter the HB Settings like \"6H or 6h\" for Six hours interval 'm' for minute\n");
  print_hline(con, 40);
  printf("\n\nRouter(s)\n");
  print_hline(con, 20);
  printf("\n\nPatient Unit (NC-2000) HB Set to(Hours/Minutes): ");
  scanf("%d%c", &nc2000hb,&nc2000);
  fflush(stdin);
  printf("\nBeacon(NC-201)HB Set to (Hours/Minutes): ");
  scanf("%d%c",&nc201hb, &nc201);
  fflush(stdin);
  printf("\n\nEnd Device(s)\n");
  print_hline(con, 20);
  printf("\n\nPendant (NC-500) HB Set to (Hours/Minutes): ");
  scanf("%d%c",&nc500hb, &nc500);
  fflush(stdin);
  printf("\nPull Station (NC-103) HB Set to (Hours/Minutes): ");
  scanf("%d%c",&nc103hb, &nc103);
  fflush(stdin);
  printf("\n\nDURATION\n");
  print_hline(con, 20);
  fflush(stdin);
  printf("\n\nEnter the Start Time of the Test using 12hour clock like HH:MM am/pm?: ");
  scanf(" %d:%d %s", &hr1, &min1, t1);
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
             hour = hr2 - hr1 - 1;
        }
    if(min2 >= min1) {
            hour = hr2 - hr1;
             m = min2 - min1;
        }
  decode_log(nc2000hb,nc2000,nc201hb,nc201,nc500hb,nc500,nc103hb,nc103,hr1,min1,t1,hr2,min2,t2, hour, m);
}

int user_input(void)
{
  char buf[2];
  fflush(stdin);
  int c;
  /* Print a prompt indicating we are waiting for user input */
  printf("\n> ");
  /* Make sure the user sees the prompt */
  fflush(stdout);
  /* Get a character from the console */
  fgets(buf, 2, stdin);
  c = buf[0];
  /* Convert to lower case */
  return tolower(c);
}

void print_hline(FILE* f, int len)
{
    int i;
       for(i = 0; i < len; i++)
              fprintf(f, "_");
}

void print_stars(FILE* fp, int len)
{
    int i;

       for(i = 0; i < len; i++)
              fprintf(fp, "*");
       fprintf(fp, "\n");
}

/* Print a nice welcome message */
void print_welcome(void)
{
    print_stars(con, 85);
    printf("\t\t\tWELCOME TO MICARE LOG ANALYZER\n\n");
    print_stars(con, 85);
}

/* Print a helpful help message */
void print_help(void)
{
  print_hline(con, 50);
  printf("\nTheses are the list of available commands\n");
  print_hline(con, 50);
  printf("\nPlease enter an option:\n");
  printf("   'H' print this help\n");
  printf("   'S' to start logging analyzer\n");
  printf("   'T' to terminate\n");
}

/* Print a friendly farewell message */
void print_goodbye(void)
{
  printf("Exiting Program. Goodbye !!!");
}


/* Initialize the console window */
void init_console(void)
{
    system("COLOR F1");
    system("mode CON: COLS=85 LINES=50");
}

void main(void)
{
  char cmd;

  /* Initialize the console */
  init_console();

  /* Print a nice welcome message */
  print_welcome();

  /* Print a helpful help message */
  printf("Enter 'H' for help or 'S' to start\n");
  print_hline(con, 85);

  /*Get the Date for the Test Report*/
  test_date();

  /* Main loop: receive input from the user and process it
   * decides to terminate the application... */

  while ((cmd = user_input()) != 't') {

    switch (cmd) {
    case 's':
      /* Get user data... */
      data_get();
      break;

    case 'h':
      print_help();
      break;

    default:
      /* Invalid entry, inform the user */
      printf("Error: Invalid command!\n");
      continue;
    }

  }

  print_goodbye();
}
