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
#include "test.h"

/*Output to the console*/
#define con stdout

/*Calculate the result for the log data, like the duration of the test, total individual expected heart beat
for each device*/

struct log_info {
             int nc2000hb;
             int nc201hb;
             int nc500hb;
             int nc103hb;
             char nc2000;
             char nc201;
             char nc500;
             char nc103;
              int hr1;
              int min1;
              char t1[20];
              int hr2;
              int min2;
              char t2[20];
              int hour;
              int m;
        };

int decode_log( struct log_info info);

int data_get(void)
{
  struct log_info info;
  int counter = 0;
  int noon = 12;
  char am[] = "am";
  char pm[]  = "pm";
  printf("\n");
  printf("\nEnter the HB Settings like \"6H or 6h\" for Six hours interval 'm' for minute\n");
  print_hline(con, 40);
  printf("\n\nRouter(s)\n");
  print_hline(con, 20);
  printf("\n\nPatient Unit (NC-2000) HB Set to(Hours/Minutes): ");
  scanf("%i %c",&(info.nc2000hb),&(info.nc2000));
  getchar();
  printf("\nBeacon(NC-201)HB Set to (Hours/Minutes): ");
  scanf("%i%c",&(info.nc201hb), &(info.nc201));
  fflush(stdin);
  printf("\n\nEnd Device(s)\n");
  print_hline(con, 20);
  printf("\n\nPendant (NC-500) HB Set to (Hours/Minutes): ");
  scanf("%d%c",&(info.nc500hb), &(info.nc500));
  fflush(stdin);
  printf("\nPull Station (NC-103) HB Set to (Hours/Minutes): ");
  scanf("%d%c",&(info.nc103hb), &(info.nc103));
  fflush(stdin);
  printf("\n\nDURATION\n");
  print_hline(con, 20);
  fflush(stdin);
  printf("\n\nEnter the Start Time of the Test using 12hour clock like HH:MM am/pm?: ");
  scanf(" %d:%d %s", &(info.hr1), &(info.min1), &(info.t1));
  fflush(stdin);
  printf("\nEnter the End Time of the Test using 12hour clock like HH:MM am/pm?: ");
  scanf(" %d:%d %s", &(info.hr2), &(info.min2), &(info.t2));
  fflush(stdin);
    if (strcmp(am,info.t1) == 0){
             info.hr1 = info.hr1;
        }
    if (strcmp(pm,info.t1) == 0){
             info.hr1 = info.hr1 + 12;
        }
    if (strcmp(am,info.t2) == 0){
             info.hr2 = info.hr2;
        }
    if (strcmp(pm, info.t2) == 0){
             info.hr2 = info.hr2 + 12;
        }
    if(info.min1 > info.min2){
             info.m =  (info.min2+ 60) - info.min1;
             info.hour = info.hr2 - info.hr1 - 1;
        }
    if(info.min2 >= info.min1) {
            info.hour = info.hr2 - info.hr1;
             info.m = info.min2 - info.min1;
        }

   decode_log(info);
}

int decode_log( struct log_info info)
{
  int i;
  time_t t;
  time(&t);
  FILE *fp;
  char location[12] = "../../Logs/";
  char date[19];
  char ext[6] = ".doc";
  char path[32];
  fflush(stdout);
  printf("\nEnter the Date of the Test Report? DD Month YYYY> ");
  fgets(date, sizeof(date), stdin);
  //Remove Trailing newline character from the string
  if(date[(strlen(date)- 1)] == '\n'){
    date[(strlen(date)- 1)] = '\0';
   }
   
  /*Creates a file in the location to write in the log information*/

  snprintf(path, sizeof(path),"%s%s%s", location, date, ext);

  fp = fopen(path ,"w");
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
        fprintf(fp,"\nStart Time: %d:%d %s \nEnd Time: %d:%d %s\n" ,info.hr1,info.min1,info.t1,info.hr2,info.min2,info.t2);
        print_hline(fp , 70);
        fprintf(fp,"\nHB EXPECTED FOR EACH DEVICE \n");
        print_hline(fp , 70);
        fprintf(fp,"\nThe total time is %d hours %d minute(s) \n", info.hour, info.m);
        fprintf(fp,"\nRouter(s)\n");
        print_hline(fp , 14);
        int total_hours = info.hour;
        /*Converts the time from hours to minutes to get the total minutes during the duration*/
        unsigned int total_min = info.hour * 60 + info.m;
        /*Gets the HB value from the user storing it in an array*/
        unsigned int val[4]={info.nc2000hb,info.nc201hb,info.nc500hb,info.nc103hb};
        unsigned int HB[4], HB2[4];
        for(i=0; i<4; i++){
              HB2[i]=total_min/val[i];
              HB[i]=total_hours/val[i];
          }
        if(info.nc2000== 'h'){
              if(val[0] > total_hours){
                  fprintf(fp,"\n\nPatient unit (NC-2000): %s HB(s) Expected\n", absent);
              }else{
                  fprintf(fp,"\n\nPatient unit (NC-2000): %d HB(s) Expected\n",HB[0]);}
          }

        if(info.nc2000 == 'm'){
              fprintf(fp,"\n\nPatient unit (NC-2000): %d HB(s) Expected\n",HB2[0]);
          }

        if(info.nc201 == 'h') {
             if(val[1]> total_hours){
                  fprintf(fp,"\nBeacon (NC-201)         : %s HB(s) Expected\n\n\nEnd Devices\n", absent);
                  print_hline(fp , 14);
            }else{
                  fprintf(fp,"\nBeacon (NC-201)         : %d HB(s) Expected\n\n\nEnd Device(s)\n",HB[1]);
                  print_hline(fp , 14);
                }
            }

        if(info.nc201 == 'm') {
             fprintf(fp,"\nBeacon (NC-201)         : %d HB(s) Expected\n\n\nEnd Device(s)\n",HB2[1]);
            }

        if(info.nc500 == 'h') {
            print_hline(fp, 20);
            if(val[2]> total_hours){
                fprintf(fp,"\n\nPendant (NC-500)      : NO HB(s) Expected\n");
            }else{
                fprintf(fp,"\n\nPendant (NC-500)      : %d HB(s) Expected\n",HB[2]);
                }
            }

        if(info.nc500 == 'm'){
            for (i=0; i < 14; i++){
                  fprintf(fp,"_");
               }
            fprintf(fp,"\n\nPendant (NC-500)      : %d HB(s) Expected\n",HB2[2]);
            }

        if(info.nc103 == 'h') {
            if(val[3]> total_hours){
               fprintf(fp,"\nPull Station (NC-103)   : NO HB(s) Expected\n");
            }else{
                  fprintf(fp,"\nPull Station (NC-103)   : %d HB(s) Expected\n",HB[3]);
                 }
            }
        if(info.nc103 == 'm') {
            fprintf(fp,"\nPull Station (NC-103)   : %d HB(s) Expected\n",HB2[3]);
          }

          fclose(fp);
          printf("\n");
          print_hline(con, 20);
          printf("\nSAVED TO FILE\n");
          print_hline(con, 20);
     }
}

int user_input(void)
{
  char buf[2];
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

int main(int argc, char **argv)
{
  char cmd;
  /* Initialize the console */
  init_console();

  /* Print a nice welcome message */
  print_welcome();

  /* Print a helpful help message */
  printf("Enter 'H' for help or 'S' to start\n");
  print_hline(con, 85);
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


  return 0;
}
