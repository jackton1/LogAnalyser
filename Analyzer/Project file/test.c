/*
 * File:	 Heart beat Log Analyzer -test.c
 * Author:   Tonye Jack (tonyejck@gmail.com)
 *
 * This project is a Log Report Analyzer which calculates the user defined data.
 * And generates a log report stored in a specified location in the local drive
 * which can be in word, excel or text format.
 */

#include<stdio.h>
#include<string.h>
#include<stdlib.h>
#include<ctype.h>
#include<time.h>
#include<sys/stat.h>
#include<sys/types.h>
#include"test.h"
#include<windows.h>

/*Output to the console*/
#define con stdout
#define OUTDIR "../../Logs/"
#define CDIR "./"
#define word ".doc"
#define text ".txt"
#define excel ".csv"
#define REPORT "MiCare Log Report "

/*Calculate the result for the log data, like the duration of the test, total individual expected heart beat
for each device*/

//Flush the standard input
void flushStdin(void)
{
    int ch;
    while(((ch=getchar()) != '\n') && (ch != EOF));
    //Do nothing
}


log_info data_get(void)
{
  flushStdin();
  log_info info;
  int noon = 12;
  char am[] = "am";
  char pm[]  = "pm";
  printf("\n");
  printf("\nEnter the HB Settings like \"6H or 6h\" for Six hours interval 'm' for minute\n");
  print_hline(con, 40);
  printf("\n\nRouter(s)\n");
  print_hline(con, 20);
  printf("\n\nPatient Unit (NC-2000) HB Set to(Hours/Minutes): ");
  scanf("%2i %1c",&(info.nc2000hb),&(info.nc2000));
  flushStdin();
  printf("\nBeacon(NC-201)HB Set to (Hours/Minutes): ");
  scanf("%2i%1c",&(info.nc201hb), &(info.nc201));
  flushStdin();
  printf("\n\nEnd Device(s)\n");
  print_hline(con, 20);
  printf("\n\nPendant (NC-500) HB Set to (Hours/Minutes): ");
  scanf("%2d%1c",&(info.nc500hb), &(info.nc500));
  flushStdin();
  printf("\nPull Station (NC-103) HB Set to (Hours/Minutes): ");
  scanf("%2d%1c",&(info.nc103hb), &(info.nc103));
  flushStdin();
  printf("\n\nDURATION\n");
  print_hline(con, 20);
  printf("\n\nEnter the Start Time of the Test using 12hour clock like HH:MM am/pm?: ");
  scanf(" %2d:%2d %2s", &(info.hr1), &(info.min1), info.t1);
  flushStdin();
  printf("\nEnter the End Time of the Test using 12hour clock like HH:MM am/pm?: ");
  scanf(" %2d:%2d %2s", &(info.hr2), &(info.min2), info.t2);
  flushStdin();
    if (strcmp(am,info.t1) == 0){
             info.hr1 = info.hr1;
        }
    if (strcmp(pm,info.t1) == 0){
             if (info.hr1 == noon ){
                info.hr1 = info.hr1;
            }else{
             info.hr1 = info.hr1 + noon;
            }
        }
    if (strcmp(am,info.t2) == 0){
             info.hr2 = info.hr2;
        }
    if (strcmp(pm, info.t2) == 0){
            if (info.hr2 == noon ){
                info.hr2 = info.hr2;
            }else{
             info.hr2 = info.hr2 + noon;
            }
        }
    if(info.min1 > info.min2){
             info.m =  (info.min2+ 60) - info.min1;
             info.hour = info.hr2 - info.hr1 - 1;
        }
    if(info.min2 >= info.min1) {
            info.hour = info.hr2 - info.hr1;
             info.m = info.min2 - info.min1;
        }

   return info;
}

void make_lower(char *array)
{
    int i = 0;
    while (array[i] != '\0' ){
             array[i] = tolower(array[i]);
            i++;
    }
}

int start_log(void)
{
  log_info info;
  info = data_get();
  int i;
  time_t t;
  time(&t);
  FILE *fp;
  char date[19];
  char ext[7];
  char doc[7] = "word";
  char txt[7] = "text";
  char csv[7] = "excel";
  char path[53];
  fflush(stdout);
  printf("\nEnter the Date of the Test Report? DD Month YYYY: ");
  fgets(date, sizeof(date), stdin);
  //Remove Trailing newline character from the string
  if(date[(strlen(date)- 1)] == '\n'){
        date[(strlen(date)- 1)] = '\0';
    }
  printf("\nSave Report File Fomat (Word, Text, Excel): ");
  fgets(ext, sizeof(ext), stdin);
  make_lower(ext);
  ext[(strlen(ext)- 1)] = '\0';
  if(strcmp(doc,ext)== 0){
        strcpy(ext,word);
  }
  if(strcmp(txt,ext)== 0){
        strcpy(ext,text);
  }
  if(strcmp(csv,ext)== 0){
        strcpy(ext,excel);
  }

  /*Creates a file in the location to write in the log information*/
  snprintf(path, sizeof(path),"%s%s%s%s",OUTDIR,REPORT,date, ext);
  fp = fopen(path ,"w+");
  if (fp != NULL){
                printf("\n");
                print_hline(con,58 );
                printf("\n\nLocation: %s \n", path);
            }
  if (fp == NULL){
        printf("\n Origin Log Directory Doesn't exist\n");
        /*if file does not exist, create it*/
        char full_path[46];
        snprintf(full_path, sizeof(full_path),"%s%s%s%s",CDIR,REPORT,date,ext);
        fp = fopen(full_path ,"w+");
        /*Rewrite the file if already created in the current directory*/
        rewind(fp);
            if (fp == NULL){
	   	        perror("\nNo permission creating file / Disk Full");
                fprintf(stderr, "Could not open file");
                return(1);
                exit(1);
                } else{
                  printf("\n\n Created File in Current DIRECTORY (%s)",full_path);
                  /*Writes the log data in the file*/
                }
        }
          /*Prints the Date and time the file was generated*/
          fprintf(fp,"\t\tCreated: %s \n",ctime(&t));

          /*Writing the Log data to the file with the information from the user */
          fprintf(fp,"\nMICARE TEST REPORT\n");
          print_hline(fp , 70);
          fprintf(fp,"\n\nStart Time: %d:%d %s \nEnd Time: %d:%d %s\n" ,info.hr1,info.min1,info.t1,info.hr2,info.min2,info.t2);
          print_hline(fp , 70);
          fprintf(fp,"\n\n\n\tHB EXPECTED FOR EACH DEVICE \n");
          print_hline(fp , 70);
          fprintf(fp,"\nThe Duration of test is %d hour(s) %d minute(s) \n", info.hour, info.m);
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
          fprintf(fp,"\n\nHeart Beat (HB) Set Time for Devices \n" );
          print_hline(fp , 30);
          fprintf(fp,"\n\nPatient Unit (NC-2000): %2d%1c",info.nc2000hb,info.nc2000);
          fprintf(fp,"\nBeacon (NC-201):%2d%1c\n ",info.nc201hb,info.nc201);
          fprintf(fp,"\nEnd Devices\n");
          print_hline(fp , 14);
          fprintf(fp,"\n\nPendant (NC-500): %2d%1c\n ",info.nc500hb,info.nc500);
          fprintf(fp,"\nPull Station (NC-103): %2d%1c\n",info.nc103hb,info.nc103);
          fprintf(fp,"\n\nRouter(s)\n");
          print_hline(fp , 14);
          if(info.nc2000== 'h' || info.nc2000== 'H'){
                if(val[0] > total_hours || val[0] <= 0){
                    fprintf(fp,"\n\nPatient unit (NC-2000): NO HB(s) Expected\n");
                }else{
                    fprintf(fp,"\n\nPatient unit (NC-2000): %d HB(s) Expected\n",HB[0]);
                    }
            }

          if(info.nc2000 == 'm' || info.nc2000== 'M'){
                fprintf(fp,"\n\nPatient unit (NC-2000): %d HB(s) Expected\n",HB2[0]);
            }

          if(info.nc201 == 'h'||info.nc201 == 'H') {
               if(val[1]> total_hours || val[1] <= 0){
                    fprintf(fp,"\nBeacon (NC-201)         : NO HB(s) Expected\n\n\nEnd Devices\n");
                    print_hline(fp , 14);
              }else{
                    fprintf(fp,"\nBeacon (NC-201)         : %d HB(s) Expected\n\n\nEnd Device(s)\n",HB[1]);
                    print_hline(fp , 14);
                  }
              }

          if(info.nc201 == 'm'||info.nc201 == 'M') {
               fprintf(fp,"\nBeacon (NC-201)         : %d HB(s) Expected\n\n\nEnd Device(s)\n",HB2[1]);
              }

          if(info.nc500 == 'h'||info.nc500 == 'H') {
              print_hline(fp, 20);
              if(val[2]> total_hours || val[2] <= 0){
                  fprintf(fp,"\n\nPendant (NC-500)      : NO HB(s) Expected\n");
              }else{
                  fprintf(fp,"\n\nPendant (NC-500)      : %d HB(s) Expected\n",HB[2]);
                  }
              }

          if(info.nc500 == 'm'||info.nc500 == 'M'){
              print_hline(fp, 14);
              fprintf(fp,"\n\nPendant (NC-500)      : %d HB(s) Expected\n",HB2[2]);
              }

          if(info.nc103 == 'h'||info.nc103 == 'H') {
              if(val[3]> total_hours || val[3] <= 0){
                 fprintf(fp,"\nPull Station (NC-103)   : NO HB(s) Expected\n");
              }else{
                    fprintf(fp,"\nPull Station (NC-103)   : %d HB(s) Expected\n",HB[3]);
                   }
              }
          if(info.nc103 == 'm'||info.nc103 == 'M') {
              fprintf(fp,"\nPull Station (NC-103)   : %d HB(s) Expected\n",HB2[3]);
            }

            fclose(fp);
            printf("\n");
            print_hline(con, 30);
            printf("\n\n LOG DATA SAVED TO FILE\n");
            print_hline(con, 30);
    return 0;
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
  fgets(buf,2,stdin);

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
  flushStdin();
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
    SetConsoleTitle( TEXT("Log Analyzer"));
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
      start_log();
      break;

    case 'h':
      print_help();
      break;

    default:
      getchar();
      /* Invalid entry, inform the user */
      printf("Error: Invalid command!\n");
      getchar();
      continue;
    }

  }
  print_goodbye();


  return 0;
}
