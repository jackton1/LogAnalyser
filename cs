[33mcommit 1db2c9c568d2be92c208be75b101a1f98881d2c6[m
Author: jackton1 <jtonye@mircomgroup.com>
Date:   Thu Jul 14 23:08:12 2016 -0400

    Redesign the program to write file

[1mdiff --git a/HB Analyzer/C Log Analyzer/12 Jun 2016.doc b/HB Analyzer/C Log Analyzer/12 Jun 2016.doc[m
[1mdeleted file mode 100644[m
[1mindex e69de29..0000000[m
[1mdiff --git a/HB Analyzer/C Log Analyzer/Log Analyzer.cbp b/HB Analyzer/C Log Analyzer/Log Analyzer.cbp[m
[1mdeleted file mode 100644[m
[1mindex 483dab4..0000000[m
[1m--- a/HB Analyzer/C Log Analyzer/Log Analyzer.cbp[m	
[1m+++ /dev/null[m
[36m@@ -1,57 +0,0 @@[m
[31m-<?xml version="1.0" encoding="UTF-8" standalone="yes" ?>[m
[31m-<CodeBlocks_project_file>[m
[31m-	<FileVersion major="1" minor="6" />[m
[31m-	<Project>[m
[31m-		<Option title="Log Analyzer" />[m
[31m-		<Option pch_mode="2" />[m
[31m-		<Option compiler="gcc" />[m
[31m-		<Build>[m
[31m-			<Target title="Debug">[m
[31m-				<Option output="bin/Debug/Log Analyzer" prefix_auto="1" extension_auto="1" />[m
[31m-				<Option object_output="obj/Debug/" />[m
[31m-				<Option type="1" />[m
[31m-				<Option compiler="gcc" />[m
[31m-				<Compiler>[m
[31m-					<Add option="-g" />[m
[31m-				</Compiler>[m
[31m-			</Target>[m
[31m-			<Target title="Release">[m
[31m-				<Option output="bin/Release/Log Analyzer" prefix_auto="1" extension_auto="1" />[m
[31m-				<Option object_output="obj/Release/" />[m
[31m-				<Option type="1" />[m
[31m-				<Option compiler="gcc" />[m
[31m-				<Compiler>[m
[31m-					<Add option="-O2" />[m
[31m-				</Compiler>[m
[31m-				<Linker>[m
[31m-					<Add option="-s" />[m
[31m-				</Linker>[m
[31m-			</Target>[m
[31m-		</Build>[m
[31m-		<Compiler>[m
[31m-			<Add option="-Wall" />[m
[31m-		</Compiler>[m
[31m-		<Unit filename="Makefile">[m
[31m-			<Option target="Debug" />[m
[31m-		</Unit>[m
[31m-		<Unit filename="resource/logimg.ico">[m
[31m-			<Option target="Debug" />[m
[31m-		</Unit>[m
[31m-		<Unit filename="resource/resource.rc">[m
[31m-			<Option compilerVar="WINDRES" />[m
[31m-			<Option target="Debug" />[m
[31m-		</Unit>[m
[31m-		<Unit filename="test.c">[m
[31m-			<Option compilerVar="CC" />[m
[31m-			<Option target="Debug" />[m
[31m-		</Unit>[m
[31m-		<Unit filename="test.h">[m
[31m-			<Option target="Debug" />[m
[31m-		</Unit>[m
[31m-		<Extensions>[m
[31m-			<code_completion />[m
[31m-			<envvars />[m
[31m-			<debugger />[m
[31m-		</Extensions>[m
[31m-	</Project>[m
[31m-</CodeBlocks_project_file>[m
[1mdiff --git a/HB Analyzer/C Log Analyzer/Log Analyzer.depend b/HB Analyzer/C Log Analyzer/Log Analyzer.depend[m
[1mdeleted file mode 100644[m
[1mindex d7b7de4..0000000[m
[1m--- a/HB Analyzer/C Log Analyzer/Log Analyzer.depend[m	
[1m+++ /dev/null[m
[36m@@ -1,23 +0,0 @@[m
[31m-# depslib dependency file v1.0[m
[31m-1467318269 source:c:\users\jtonye\desktop\loganalyzer\log analyzer\test.c[m
[31m-	<stdio.h>[m
[31m-	<string.h>[m
[31m-	<stdlib.h>[m
[31m-	<ctype.h>[m
[31m-	<time.h>[m
[31m-	"test.h"[m
[31m-[m
[31m-1467249219 c:\users\jtonye\desktop\loganalyzer\log analyzer\test.h[m
[31m-[m
[31m-1467320929 source:c:\users\jtonye\desktop\loganalyzer\hb analyzer\c log analyzer\test.c[m
[31m-	<stdio.h>[m
[31m-	<string.h>[m
[31m-	<stdlib.h>[m
[31m-	<ctype.h>[m
[31m-	<time.h>[m
[31m-	"test.h"[m
[31m-[m
[31m-1467249219 c:\users\jtonye\desktop\loganalyzer\hb analyzer\c log analyzer\test.h[m
[31m-[m
[31m-1467320638 source:c:\users\jtonye\desktop\loganalyzer\hb analyzer\c log analyzer\resource.rc[m
[31m-[m
[1mdiff --git a/HB Analyzer/C Log Analyzer/Log Analyzer.layout b/HB Analyzer/C Log Analyzer/Log Analyzer.layout[m
[1mdeleted file mode 100644[m
[1mindex 50846ae..0000000[m
[1m--- a/HB Analyzer/C Log Analyzer/Log Analyzer.layout[m	
[1m+++ /dev/null[m
[36m@@ -1,20 +0,0 @@[m
[31m-<?xml version="1.0" encoding="UTF-8" standalone="yes" ?>[m
[31m-<CodeBlocks_layout_file>[m
[31m-	<FileVersion major="1" minor="0" />[m
[31m-	<ActiveTarget name="Debug" />[m
[31m-	<File name="Makefile" open="1" top="0" tabpos="2" split="0" active="1" splitpos="0" zoom_1="0" zoom_2="0">[m
[31m-		<Cursor>[m
[31m-			<Cursor1 position="0" topLine="0" />[m
[31m-		</Cursor>[m
[31m-	</File>[m
[31m-	<File name="test.c" open="1" top="1" tabpos="1" split="0" active="1" splitpos="0" zoom_1="0" zoom_2="0">[m
[31m-		<Cursor>[m
[31m-			<Cursor1 position="4022" topLine="127" />[m
[31m-		</Cursor>[m
[31m-	</File>[m
[31m-	<File name="test.h" open="1" top="0" tabpos="3" split="0" active="1" splitpos="0" zoom_1="0" zoom_2="0">[m
[31m-		<Cursor>[m
[31m-			<Cursor1 position="0" topLine="0" />[m
[31m-		</Cursor>[m
[31m-	</File>[m
[31m-</CodeBlocks_layout_file>[m
[1mdiff --git a/HB Analyzer/C Log Analyzer/LogAnalyzer.exe b/HB Analyzer/C Log Analyzer/LogAnalyzer.exe[m
[1mdeleted file mode 100644[m
[1mindex 8f20013..0000000[m
Binary files a/HB Analyzer/C Log Analyzer/LogAnalyzer.exe and /dev/null differ
[1mdiff --git a/HB Analyzer/C Log Analyzer/Makefile b/HB Analyzer/C Log Analyzer/Makefile[m
[1mdeleted file mode 100644[m
[1mindex 6d42752..0000000[m
[1m--- a/HB Analyzer/C Log Analyzer/Makefile[m	
[1m+++ /dev/null[m
[36m@@ -1,26 +0,0 @@[m
[31m-# compiler[m
[31m-CC = gcc[m
[31m-[m
[31m-#executable[m
[31m-CFILES = test.c[m
[31m-OBJECT = test.o[m
[31m-[m
[31m-#compile flags:[m
[31m-#	-g  adds debugging information to the executable file[m
[31m-#	-Wall turns on most, but not all, compiler warnings[m
[31m-CFLAGS = -g -Wall[m
[31m-[m
[31m-PATH = C:\MinGw\bin;%PATH%[m
[31m-#build target executable[m
[31m-[m
[31m-LogAnalyzer.exe: $(OBJECT)[m
[31m-	$(CC) $(CFLAGS) $(OBJECT) -o LogAnalyzer.exe[m
[31m-[m
[31m-%.o : %.c[m
[31m-		$(CC) $(CFLAGS) -c $<[m
[31m-# all:  [m
[31m-# 	$(CC) -o $(object) -c $(CFILES)[m
[31m-# 	$(CC) -o LogAnalyzer.exe $(object)[m
[31m-[m
[31m-clean:[m
[31m-	$(RM) test[m
\ No newline at end of file[m
[1mdiff --git a/HB Analyzer/C Log Analyzer/bin/Debug/Log Analyzer.exe b/HB Analyzer/C Log Analyzer/bin/Debug/Log Analyzer.exe[m
[1mdeleted file mode 100644[m
[1mindex 889f7af..0000000[m
Binary files a/HB Analyzer/C Log Analyzer/bin/Debug/Log Analyzer.exe and /dev/null differ
[1mdiff --git a/HB Analyzer/C Log Analyzer/obj/Debug/resource.res b/HB Analyzer/C Log Analyzer/obj/Debug/resource.res[m
[1mdeleted file mode 100644[m
[1mindex 5ca96f8..0000000[m
Binary files a/HB Analyzer/C Log Analyzer/obj/Debug/resource.res and /dev/null differ
[1mdiff --git a/HB Analyzer/C Log Analyzer/obj/Debug/test.o b/HB Analyzer/C Log Analyzer/obj/Debug/test.o[m
[1mdeleted file mode 100644[m
[1mindex efd1793..0000000[m
Binary files a/HB Analyzer/C Log Analyzer/obj/Debug/test.o and /dev/null differ
[1mdiff --git a/HB Analyzer/C Log Analyzer/resource/logimg.ico b/HB Analyzer/C Log Analyzer/resource/logimg.ico[m
[1mdeleted file mode 100644[m
[1mindex 6ca2a80..0000000[m
Binary files a/HB Analyzer/C Log Analyzer/resource/logimg.ico and /dev/null differ
[1mdiff --git a/HB Analyzer/C Log Analyzer/resource/resource.rc b/HB Analyzer/C Log Analyzer/resource/resource.rc[m
[1mdeleted file mode 100644[m
[1mindex 0e86d93..0000000[m
[1m--- a/HB Analyzer/C Log Analyzer/resource/resource.rc[m	
[1m+++ /dev/null[m
[36m@@ -1 +0,0 @@[m
[31m-MAINICON ICON "logimg.ico"[m
\ No newline at end of file[m
[1mdiff --git a/HB Analyzer/C Log Analyzer/test.c b/HB Analyzer/C Log Analyzer/test.c[m
[1mdeleted file mode 100644[m
[1mindex b5ac3b5..0000000[m
[1m--- a/HB Analyzer/C Log Analyzer/test.c[m	
[1m+++ /dev/null[m
[36m@@ -1,358 +0,0 @@[m
[31m-/*[m
[31m- * File:	 Heart beat Log Analyzer -test.c[m
[31m- * Author:   Tonye Jack (tonyejck@gmail.com)[m
[31m- *[m
[31m- * This project is a Log Report Analyzer which calculates the user defined data.[m
[31m- * And generates a log report stored in a specified location in the local drive[m
[31m- * which can be in doc or txt format.[m
[31m- */[m
[31m-[m
[31m-#include<stdio.h>[m
[31m-#include<string.h>[m
[31m-#include<stdlib.h>[m
[31m-#include<ctype.h>[m
[31m-#include<time.h>[m
[31m-#include <sys/stat.h>[m
[31m-#include <sys/types.h>[m
[31m-#include "test.h"[m
[31m-[m
[31m-/*Output to the console*/[m
[31m-#define con stdout[m
[31m-[m
[31m-/*Calculate the result for the log data, like the duration of the test, total individual expected heart beat[m
[31m-for each device*/[m
[31m-[m
[31m-struct log_info {[m
[31m-             int nc2000hb;[m
[31m-             int nc201hb;[m
[31m-             int nc500hb;[m
[31m-             int nc103hb;[m
[31m-             char nc2000;[m
[31m-             char nc201;[m
[31m-             char nc500;[m
[31m-             char nc103;[m
[31m-              int hr1;[m
[31m-              int min1;[m
[31m-              char t1[4];[m
[31m-              int hr2;[m
[31m-              int min2;[m
[31m-              char t2[4];[m
[31m-              int hour;[m
[31m-              int m;[m
[31m-        };[m
[31m-[m
[31m-int decode_log( struct log_info info);[m
[31m-[m
[31m-int data_get(void)[m
[31m-{[m
[31m-  struct log_info info;[m
[31m-  int noon = 12;[m
[31m-  char am[] = "am";[m
[31m-  char pm[]  = "pm";[m
[31m-  printf("\n");[m
[31m-  printf("\nEnter the HB Settings like \"6H or 6h\" for Six hours interval 'm' for minute\n");[m
[31m-  print_hline(con, 40);[m
[31m-  printf("\n\nRouter(s)\n");[m
[31m-  print_hline(con, 20);[m
[31m-  printf("\n\nPatient Unit (NC-2000) HB Set to(Hours/Minutes): ");[m
[31m-  scanf("%2i %1c",&(info.nc2000hb),&(info.nc2000));[m
[31m-  getchar();[m
[31m-  printf("\nBeacon(NC-201)HB Set to (Hours/Minutes): ");[m
[31m-  scanf("%2i%1c",&(info.nc201hb), &(info.nc201));[m
[31m-  fflush(stdin);[m
[31m-  printf("\n\nEnd Device(s)\n");[m
[31m-  print_hline(con, 20);[m
[31m-  printf("\n\nPendant (NC-500) HB Set to (Hours/Minutes): ");[m
[31m-  scanf("%2d%1c",&(info.nc500hb), &(info.nc500));[m
[31m-  fflush(stdin);[m
[31m-  printf("\nPull Station (NC-103) HB Set to (Hours/Minutes): ");[m
[31m-  scanf("%2d%1c",&(info.nc103hb), &(info.nc103));[m
[31m-  fflush(stdin);[m
[31m-  printf("\n\nDURATION\n");[m
[31m-  print_hline(con, 20);[m
[31m-  fflush(stdin);[m
[31m-  printf("\n\nEnter the Start Time of the Test using 12hour clock like HH:MM am/pm?: ");[m
[31m-  scanf(" %2d:%2d %2s", &(info.hr1), &(info.min1), info.t1);[m
[31m-  fflush(stdin);[m
[31m-  printf("\nEnter the End Time of the Test using 12hour clock like HH:MM am/pm?: ");[m
[31m-  scanf(" %2d:%2d %2s", &(info.hr2), &(info.min2), info.t2);[m
[31m-  fflush(stdin);[m
[31m-    if (strcmp(am,info.t1) == 0){[m
[31m-             info.hr1 = info.hr1;[m
[31m-        }[m
[31m-    if (strcmp(pm,info.t1) == 0){[m
[31m-             info.hr1 = info.hr1 + noon;[m
[31m-        }[m
[31m-    if (strcmp(am,info.t2) == 0){[m
[31m-             info.hr2 = info.hr2;[m
[31m-        }[m
[31m-    if (strcmp(pm, info.t2) == 0){[m
[31m-            if (info.hr2 == noon){[m
[31m-                info.hr2 = info.hr2;[m
[31m-            }else{[m
[31m-             info.hr2 = info.hr2 + noon;[m
[31m-            }[m
[31m-        }[m
[31m-    if(info.min1 > info.min2){[m
[31m-             info.m =  (info.min2+ 60) - info.min1;[m
[31m-             info.hour = info.hr2 - info.hr1 - 1;[m
[31m-        }[m
[31m-    if(info.min2 >= info.min1) {[m
[31m-            info.hour = info.hr2 - info.hr1;[m
[31m-             info.m = info.min2 - info.min1;[m
[31m-        }[m
[31m-[m
[31m-   decode_log(info);[m
[31m-   return 0;[m
[31m-}[m
[31m-[m
[31m-int decode_log( struct log_info info)[m
[31m-{[m
[31m-  int i;[m
[31m-  time_t t;[m
[31m-  time(&t);[m
[31m-  FILE *fp;[m
[31m-  const char location[12] = "../../Logs/";[m
[31m-  char date[19];[m
[31m-  const char ext[6] = ".doc";[m
[31m-  char path[33];[m
[31m-  fflush(stdout);[m
[31m-  printf("\nEnter the Date of the Test Report? DD Month YYYY> ");[m
[31m-  fgets(date, sizeof(date), stdin);[m
[31m-  //Remove Trailing newline character from the string[m
[31m-  if(date[(strlen(date)- 1)] == '\n'){[m
[31m-        date[(strlen(date)- 1)] = '\0';[m
[31m-    }[m
[31m-[m
[31m-  /*Creates a file in the location to write in the log information*/[m
[31m-[m
[31m-  snprintf(path, sizeof(path),"%s%s%s", location, date, ext);[m
[31m-[m
[31m-  fp = fopen(path ,"rb+");[m
[31m-  [m
[31m-  if (fp == NULL){[m
[31m-        /*if file does not exist, create it*/[m
[31m-        char full_path[25];[m
[31m-	      char *new_path = "./Logs";[m
[31m-        printf(new_path);[m
[31m-        int e;[m
[31m-        struct stat sb;[m
[31m-        e = stat(new_path, &sb);[m
[31m-        //printf("e=%d errno=%d\n",e,errno);[m
[31m-        if (e == 0)[m
[31m-        {[m
[31m-        if (sb.st_mode & S_IFDIR)[m
[31m-        printf("%s is a directory.\n",new_path);[m
[31m-        if (sb.st_mode & S_IFREG)[m
[31m-        printf("%s is a regular file.\n",new_path);[m
[31m-        // etc.[m
[31m-        }[m
[31m-        else[m
[31m-        {[m
[31m-        printf("The directory does not exist. Creating new directory...\n");[m
[31m-        // Add more flags to the mode if necessary.[m
[31m-        e = mkdir(new_path, S_IRWXU);[m
[31m-        }[m
[31m-        snprintf(full_path, sizeof(full_path),"%s%s%s",new_path,date,ext);[m
[31m-        fp = fopen(new_path ,"w");[m
[31m-	    [m
[31m-	      if (fp == NULL){[m
[31m-	   	       perror("No permission creating file/ Disk Full");[m
[31m-             exit(1);[m
[31m-			     } else{[m
[31m-                  printf("\nCreated File in Current DIRECTORY (%s)",new_path);[m
[31m-                  /*Writes the log data in the file*/[m
[31m-[m
[31m-                  /*Prints the Date and time the file was generated*/[m
[31m-                  fprintf(fp,"\t\tCreated: %s \n\n",ctime(&t));[m
[31m-[m
[31m-                  /*Writing the Log data to the file with the information from the user */[m
[31m-                  fprintf(fp,"\n\nMICARE TEST REPORT\n");[m
[31m-                  print_hline(fp , 70);[m
[31m-                  fprintf(fp,"\nStart Time: %d:%d %s \nEnd Time: %d:%d %s\n" ,info.hr1,info.min1,info.t1,info.hr2,info.min2,info.t2);[m
[31m-                  print_hline(fp , 70);[m
[31m-                  fprintf(fp,"\nHB EXPECTED FOR EACH DEVICE \n");[m
[31m-                  print_hline(fp , 70);[m
[31m-                  fprintf(fp,"\nThe total time is %d hours %d minute(s) \n", info.hour, info.m);[m
[31m-                  fprintf(fp,"\nRouter(s)\n");[m
[31m-                  print_hline(fp , 14);[m
[31m-                  int total_hours = info.hour;[m
[31m-                  /*Converts the time from hours to minutes to get the total minutes during the duration*/[m
[31m-                  unsigned int total_min = info.hour * 60 + info.m;[m
[31m-                  /*Gets the HB value from the user storing it in an array*/[m
[31m-                  unsigned int val[4]={info.nc2000hb,info.nc201hb,info.nc500hb,info.nc103hb};[m
[31m-                  unsigned int HB[4], HB2[4];[m
[31m-                  for(i=0; i<4; i++){[m
[31m-                        HB2[i]=total_min/val[i];[m
[31m-                        HB[i]=total_hours/val[i];[m
[31m-                    }[m
[31m-                  if(info.nc2000== 'h'){[m
[31m-                        if(val[0] > total_hours || val[0] <= 0){[m
[31m-                            fprintf(fp,"\n\nPatient unit (NC-2000): NO HB(s) Expected\n");[m
[31m-                        }else{[m
[31m-                            fprintf(fp,"\n\nPatient unit (NC-2000): %d HB(s) Expected\n",HB[0]);}[m
[31m-                    }[m
[31m-[m
[31m-                  if(info.nc2000 == 'm'){[m
[31m-                        fprintf(fp,"\n\nPatient unit (NC-2000): %d HB(s) Expected\n",HB2[0]);[m
[31m-                    }[m
[31m-[m
[31m-                  if(info.nc201 == 'h') {[m
[31m-                       if(val[1]> total_hours || val[1] <= 0){[m
[31m-                            fprintf(fp,"\nBeacon (NC-201)         : NO HB(s) Expected\n\n\nEnd Devices\n");[m
[31m-                            print_hline(fp , 14);[m
[31m-                      }else{[m
[31m-                            fprintf(fp,"\nBeacon (NC-201)         : %d HB(s) Expected\n\n\nEnd Device(s)\n",HB[1]);[m
[31m-                            print_hline(fp , 14);[m
[31m-                          }[m
[31m-                      }[m
[31m-[m
[31m-                  if(info.nc201 == 'm') {[m
[31m-                       fprintf(fp,"\nBeacon (NC-201)         : %d HB(s) Expected\n\n\nEnd Device(s)\n",HB2[1]);[m
[31m-                      }[m
[31m-[m
[31m-                  if(info.nc500 == 'h') {[m
[31m-                      print_hline(fp, 20);[m
[31m-                      if(val[2]> total_hours || val[2] <= 0){[m
[31m-                          fprintf(fp,"\n\nPendant (NC-500)      : NO HB(s) Expected\n");[m
[31m-                      }else{[m
[31m-                          fprintf(fp,"\n\nPendant (NC-500)      : %d HB(s) Expected\n",HB[2]);[m
[31m-                          }[m
[31m-                      }[m
[31m-[m
[31m-                  if(info.nc500 == 'm'){[m
[31m-                      print_hline(fp, 14);[m
[31m-                      fprintf(fp,"\n\nPendant (NC-500)      : %d HB(s) Expected\n",HB2[2]);[m
[31m-                      }[m
[31m-[m
[31m-                  if(info.nc103 == 'h') {[m
[31m-                      if(val[3]> total_hours || val[3] <= 0){[m
[31m-                         fprintf(fp,"\nPull Station (NC-103)   : NO HB(s) Expected\n");[m
[31m-                      }else{[m
[31m-                            fprintf(fp,"\nPull Station (NC-103)   : %d HB(s) Expected\n",HB[3]);[m
[31m-                           }[m
[31m-                      }[m
[31m-                  if(info.nc103 == 'm') {[m
[31m-                      fprintf(fp,"\nPull Station (NC-103)   : %d HB(s) Expected\n",HB2[3]);[m
[31m-                    }[m
[31m-[m
[31m-                    fclose(fp);[m
[31m-                    printf("\n");[m
[31m-                    print_hline(con, 20);[m
[31m-                    printf("\nSAVED TO FILE\n");[m
[31m-                    print_hline(con, 20);[m
[31m-                  }[m
[31m-            }[m
[31m-    else{[m
[31m-        print_hline(con,10);[m
[31m-        printf("\n WARNING FILE ALREADY EXIST IN DIRECTORY!!!\n");[m
[31m-        print_hline(con,10);[m
[31m-        }[m
[31m-  return 0;    [m
[31m-}[m
[31m-[m
[31m-int user_input(void)[m
[31m-{[m
[31m-  char buf[2];[m
[31m-  int c;[m
[31m-  /* Print a prompt indicating we are waiting for user input */[m
[31m-  printf("\n> ");[m
[31m-  /* Make sure the user sees the prompt */[m
[31m-  fflush(stdout);[m
[31m-  /* Get a character from the console */[m
[31m-  fgets(buf, 2, stdin);[m
[31m-  c = buf[0];[m
[31m-  /* Convert to lower case */[m
[31m-  return tolower(c);[m
[31m-}[m
[31m-[m
[31m-void print_hline(FILE* f, int len)[m
[31m-{[m
[31m-    int i;[m
[31m-       for(i = 0; i < len; i++)[m
[31m-              fprintf(f, "_");[m
[31m-}[m
[31m-[m
[31m-void print_stars(FILE* fp, int len)[m
[31m-{[m
[31m-    int i;[m
[31m-[m
[31m-       for(i = 0; i < len; i++)[m
[31m-              fprintf(fp, "*");[m
[31m-       fprintf(fp, "\n");[m
[31m-}[m
[31m-[m
[31m-/* Print a nice welcome message */[m
[31m-void print_welcome(void)[m
[31m-{[m
[31m-    print_stars(con, 85);[m
[31m-    printf("\t\t\tWELCOME TO MICARE LOG ANALYZER\n\n");[m
[31m-    print_stars(con, 85);[m
[31m-}[m
[31m-[m
[31m-/* Print a helpful help message */[m
[31m-void print_help(void)[m
[31m-{[m
[31m-  print_hline(con, 50);[m
[31m-  printf("\nTheses are the list of available commands\n");[m
[31m-  print_hline(con, 50);[m
[31m-  printf("\nPlease enter an option:\n");[m
[31m-  printf("   'H' print this help\n");[m
[31m-  printf("   'S' to start logging analyzer\n");[m
[31m-  printf("   'T' to terminate\n");[m
[31m-}[m
[31m-[m
[31m-/* Print a friendly farewell message */[m
[31m-void print_goodbye(void)[m
[31m-{[m
[31m-  printf("Exiting Program. Goodbye !!!");[m
[31m-}[m
[31m-[m
[31m-[m
[31m-/* Initialize the console window */[m
[31m-void init_console(void)[m
[31m-{[m
[31m-    system("COLOR F1");[m
[31m-    system("mode CON: COLS=85 LINES=50");[m
[31m-}[m
[31m-[m
[31m-int main(int argc, char **argv)[m
[31m-{[m
[31m-  char cmd;[m
[31m-  /* Initialize the console */[m
[31m-  init_console();[m
[31m-[m
[31m-  /* Print a nice welcome message */[m
[31m-  print_welcome();[m
[31m-[m
[31m-  /* Print a helpful help message */[m
[31m-  printf("Enter 'H' for help or 'S' to start\n");[m
[31m-  print_hline(con, 85);[m
[31m-  /* Main loop: receive input from the user and process it[m
[31m-   * decides to terminate the application... */[m
[31m-  while ((cmd = user_input()) != 't') {[m
[31m-[m
[31m-    switch (cmd) {[m
[31m-    case 's':[m
[31m-      /* Get user data... */[m
[31m-      data_get();[m
[31m-      break;[m
[31m-[m
[31m-    case 'h':[m
[31m-      print_help();[m
[31m-      getchar();[m
[31m-      break;[m
[31m-[m
[31m-    default:[m
[31m-      /* Invalid entry, inform the user */[m
[31m-      printf("Error: Invalid command!\n");[m
[31m-      getchar();[m
[31m-      continue;[m
[31m-    }[m
[31m-[m
[31m-  }[m
[31m-  print_goodbye();[m
[31m-[m
[31m-[m
[31m-  return 0;[m
[31m-}[m
[1mdiff --git a/HB Analyzer/C Log Analyzer/test.h b/HB Analyzer/C Log Analyzer/test.h[m
[1mdeleted file mode 100644[m
[1mindex 66476d2..0000000[m
[1m--- a/HB Analyzer/C Log Analyzer/test.h[m	
[1m+++ /dev/null[m
[36m@@ -1,15 +0,0 @@[m
[31m-#ifndef __TEST_H__[m
[31m-#define __TEST_H__[m
[31m-[m
[31m-[m
[31m-int data_get(void);[m
[31m-int user_input(void);[m
[31m-void print_stars(FILE* fp, int len);[m
[31m-void print_hline(FILE* f, int len);[m
[31m-void init_console(void);[m
[31m-void print_goodbye(void);[m
[31m-void print_help(void);[m
[31m-void print_welcome(void);[m
[31m-char get_date(void);[m
[31m-[m
[31m-#endif[m
[1mdiff --git a/HB Analyzer/C Log Analyzer/test.o b/HB Analyzer/C Log Analyzer/test.o[m
[1mdeleted file mode 100644[m
[1mindex 86360a9..0000000[m
Binary files a/HB Analyzer/C Log Analyzer/test.o and /dev/null differ
[1mdiff --git a/HB Analyzer/C Log Analyzer/~$ Jun 2016.doc b/HB Analyzer/C Log Analyzer/~$ Jun 2016.doc[m
[1mdeleted file mode 100644[m
[1mindex 389bfb4..0000000[m
[1m--- a/HB Analyzer/C Log Analyzer/~$ Jun 2016.doc[m	
[1m+++ /dev/null[m
[36m@@ -1,3 +0,0 @@[m
[31m-[m
[31m-Jack Tonye                                           [m
[31m- J a c k   T o n y e                                                                              [m
\ No newline at end of file[m
[1mdiff --git a/HB Analyzer/Python Log Analyzer/06-06-2016.txt b/HB Analyzer/Python Log Analyzer/06-06-2016.txt[m
[1mdeleted file mode 100644[m
[1mindex 4ef5b22..0000000[m
[1m--- a/HB Analyzer/Python Log Analyzer/06-06-2016.txt[m	
[1m+++ /dev/null[m
[36m@@ -1,239 +0,0 @@[m
[31m-10:13[m
[31m-10:13[m
[31m-10:13[m
[31m-10:22[m
[31m-10:22[m
[31m-10:22[m
[31m-10:32[m
[31m-10:32[m
[31m-10:32[m
[31m-10:41[m
[31m-10:41[m
[31m-10:41[m
[31m-10:50[m
[31m-10:50[m
[31m-10:50[m
[31m-11:00[m
[31m-11:00[m
[31m-11:00[m
[31m-11:09[m
[31m-11:09[m
[31m-11:18[m
[31m-11:18[m
[31m-11:18[m
[31m-11:28[m
[31m-11:28[m
[31m-11:28[m
[31m-11:37[m
[31m-11:37[m
[31m-11:37[m
[31m-11:46[m
[31m-11:46[m
[31m-11:46[m
[31m-11:56[m
[31m-11:56[m
[31m-11:56[m
[31m-12:05[m
[31m-12:05[m
[31m-12:14[m
[31m-12:14[m
[31m-12:14[m
[31m-12:24[m
[31m-12:24[m
[31m-12:33[m
[31m-12:33[m
[31m-12:42[m
[31m-12:42[m
[31m-12:52[m
[31m-12:52[m
[31m-12:52[m
[31m-13:01[m
[31m-13:01[m
[31m-13:01[m
[31m-13:10[m
[31m-13:10[m
[31m-13:20[m
[31m-13:20[m
[31m-13:29[m
[31m-13:29[m
[31m-13:29[m
[31m-13:39[m
[31m-13:39[m
[31m-13:39[m
[31m-13:48[m
[31m-13:48[m
[31m-13:57[m
[31m-13:57[m
[31m-13:57[m
[31m-14:07[m
[31m-14:07[m
[31m-14:07[m
[31m-14:16[m
[31m-14:16[m
[31m-14:16[m
[31m-14:25[m
[31m-14:25[m
[31m-14:25[m
[31m-14:35[m
[31m-14:35[m
[31m-14:44[m
[31m-14:44[m
[31m-14:44[m
[31m-14:53[m
[31m-14:53[m
[31m-14:53[m
[31m-15:03[m
[31m-15:03[m
[31m-15:12[m
[31m-15:12[m
[31m-15:12[m
[31m-15:21[m
[31m-15:21[m
[31m-15:21[m
[31m-15:31[m
[31m-15:31[m
[31m-15:40[m
[31m-15:40[m
[31m-15:49[m
[31m-15:49[m
[31m-15:49[m
[31m-15:59[m
[31m-15:59[m
[31m-15:59[m
[31m-16:08[m
[31m-16:08[m
[31m-16:08[m
[31m-16:17[m
[31m-16:17[m
[31m-16:17[m
[31m-16:27[m
[31m-16:27[m
[31m-16:27[m
[31m-16:36[m
[31m-16:36[m
[31m-16:36[m
[31m-16:45[m
[31m-16:45[m
[31m-16:45[m
[31m-16:55[m
[31m-16:55[m
[31m-17:04[m
[31m-17:04[m
[31m-17:04[m
[31m-17:13[m
[31m-17:13[m
[31m-17:13[m
[31m-17:23[m
[31m-17:23[m
[31m-17:32[m
[31m-17:32[m
[31m-17:41[m
[31m-17:41[m
[31m-17:41[m
[31m-17:51[m
[31m-17:51[m
[31m-17:51[m
[31m-18:00[m
[31m-18:00[m
[31m-18:00[m
[31m-18:09[m
[31m-18:09[m
[31m-18:09[m
[31m-18:19[m
[31m-18:19[m
[31m-18:19[m
[31m-18:28[m
[31m-18:28[m
[31m-18:28[m
[31m-18:37[m
[31m-18:37[m
[31m-18:47[m
[31m-18:47[m
[31m-18:47[m
[31m-18:56[m
[31m-18:56[m
[31m-19:05[m
[31m-19:05[m
[31m-19:05[m
[31m-19:15[m
[31m-19:15[m
[31m-19:15[m
[31m-19:24[m
[31m-19:24[m
[31m-19:24[m
[31m-19:33[m
[31m-19:33[m
[31m-19:33[m
[31m-19:43[m
[31m-19:43[m
[31m-19:43[m
[31m-19:52[m
[31m-19:52[m
[31m-20:01[m
[31m-20:01[m
[31m-20:11[m
[31m-20:11[m
[31m-20:20[m
[31m-20:20[m
[31m-20:29[m
[31m-20:29[m
[31m-20:29[m
[31m-20:39[m
[31m-20:39[m
[31m-20:39[m
[31m-20:48[m
[31m-20:48[m
[31m-20:48[m
[31m-20:57[m
[31m-20:57[m
[31m-20:57[m
[31m-21:07[m
[31m-21:07[m
[31m-21:16[m
[31m-21:16[m
[31m-21:16[m
[31m-21:25[m
[31m-21:25[m
[31m-21:25[m
[31m-21:35[m
[31m-21:35[m
[31m-21:44[m
[31m-21:44[m
[31m-21:44[m
[31m-21:53[m
[31m-21:53[m
[31m-22:03[m
[31m-22:03[m
[31m-22:03[m
[31m-22:12[m
[31m-22:12[m
[31m-22:12[m
[31m-22:21[m
[31m-22:21[m
[31m-22:21[m
[31m-22:31[m
[31m-22:31[m
[31m-22:31[m
[31m-22:40[m
[31m-22:40[m
[31m-22:40[m
[31m-22:49[m
[31m-22:49[m
[31m-22:58[m
[31m-22:58[m
[31m-22:58[m
[31m-23:08[m
[31m-23:08[m
[31m-23:17[m
[31m-23:17[m
[31m-23:26[m
[31m-23:26[m
[31m-23:26[m
[31m-23:36[m
[31m-23:36[m
[31m-23:36[m
[31m-23:45[m
[31m-23:45[m
[31m-23:54[m
[31m-23:54[m
[31m-23:54[m
\ No newline at end of file[m
[1mdiff --git a/HB Analyzer/Python Log Analyzer/07-06-2016.txt b/HB Analyzer/Python Log Analyzer/07-06-2016.txt[m
[1mdeleted file mode 100644[m
[1mindex 495d69d..0000000[m
[1m--- a/HB Analyzer/Python Log Analyzer/07-06-2016.txt[m	
[1m+++ /dev/null[m
[36m@@ -1,399 +0,0 @@[m
[31m-0:04[m
[31m-0:04[m
[31m-0:04[m
[31m-0:13[m
[31m-0:13[m
[31m-0:13[m
[31m-0:22[m
[31m-0:22[m
[31m-0:22[m
[31m-0:32[m
[31m-0:32[m
[31m-0:32[m
[31m-0:41[m
[31m-0:41[m
[31m-0:41[m
[31m-0:51[m
[31m-0:51[m
[31m-0:51[m
[31m-1:00[m
[31m-1:00[m
[31m-1:00[m
[31m-1:09[m
[31m-1:09[m
[31m-1:09[m
[31m-1:19[m
[31m-1:19[m
[31m-1:28[m
[31m-1:28[m
[31m-1:28[m
[31m-1:37[m
[31m-1:37[m
[31m-1:37[m
[31m-1:46[m
[31m-1:46[m
[31m-1:56[m
[31m-1:56[m
[31m-2:05[m
[31m-2:05[m
[31m-2:05[m
[31m-2:14[m
[31m-2:14[m
[31m-2:24[m
[31m-2:24[m
[31m-2:24[m
[31m-2:33[m
[31m-2:33[m
[31m-2:33[m
[31m-2:42[m
[31m-2:42[m
[31m-2:52[m
[31m-2:52[m
[31m-2:52[m
[31m-3:01[m
[31m-3:01[m
[31m-3:01[m
[31m-3:11[m
[31m-3:11[m
[31m-3:11[m
[31m-3:20[m
[31m-3:20[m
[31m-3:29[m
[31m-3:29[m
[31m-3:39[m
[31m-3:39[m
[31m-3:48[m
[31m-3:48[m
[31m-3:48[m
[31m-3:57[m
[31m-3:57[m
[31m-3:57[m
[31m-4:07[m
[31m-4:07[m
[31m-4:07[m
[31m-4:16[m
[31m-4:16[m
[31m-4:25[m
[31m-4:25[m
[31m-4:25[m
[31m-4:34[m
[31m-4:34[m
[31m-4:34[m
[31m-4:44[m
[31m-4:44[m
[31m-4:53[m
[31m-4:53[m
[31m-4:53[m
[31m-5:03[m
[31m-5:03[m
[31m-5:03[m
[31m-5:12[m
[31m-5:12[m
[31m-5:21[m
[31m-5:21[m
[31m-5:21[m
[31m-5:32[m
[31m-5:32[m
[31m-5:32[m
[31m-5:41[m
[31m-5:41[m
[31m-5:50[m
[31m-5:50[m
[31m-5:50[m
[31m-5:59[m
[31m-5:59[m
[31m-5:59[m
[31m-6:08[m
[31m-6:08[m
[31m-6:18[m
[31m-6:18[m
[31m-6:18[m
[31m-6:27[m
[31m-6:27[m
[31m-6:36[m
[31m-6:36[m
[31m-6:36[m
[31m-6:45[m
[31m-6:45[m
[31m-6:54[m
[31m-6:54[m
[31m-7:04[m
[31m-7:04[m
[31m-7:04[m
[31m-7:13[m
[31m-7:13[m
[31m-7:13[m
[31m-7:22[m
[31m-7:22[m
[31m-7:31[m
[31m-7:31[m
[31m-7:31[m
[31m-7:40[m
[31m-7:40[m
[31m-7:50[m
[31m-7:50[m
[31m-7:50[m
[31m-7:59[m
[31m-7:59[m
[31m-8:08[m
[31m-8:08[m
[31m-8:17[m
[31m-8:17[m
[31m-8:17[m
[31m-8:26[m
[31m-8:26[m
[31m-8:36[m
[31m-8:36[m
[31m-8:45[m
[31m-8:45[m
[31m-8:45[m
[31m-8:54[m
[31m-8:54[m
[31m-9:03[m
[31m-9:03[m
[31m-9:12[m
[31m-9:12[m
[31m-9:22[m
[31m-9:22[m
[31m-9:31[m
[31m-9:31[m
[31m-9:40[m
[31m-9:40[m
[31m-9:49[m
[31m-9:49[m
[31m-9:58[m
[31m-9:58[m
[31m-10:08[m
[31m-10:08[m
[31m-10:17[m
[31m-10:17[m
[31m-10:26[m
[31m-10:26[m
[31m-10:35[m
[31m-10:35[m
[31m-10:45[m
[31m-10:45[m
[31m-10:45[m
[31m-10:54[m
[31m-10:54[m
[31m-11:03[m
[31m-11:03[m
[31m-11:03[m
[31m-11:12[m
[31m-11:12[m
[31m-11:12[m
[31m-11:21[m
[31m-11:21[m
[31m-11:21[m
[31m-11:31[m
[31m-11:31[m
[31m-11:31[m
[31m-11:40[m
[31m-11:40[m
[31m-11:40[m
[31m-11:49[m
[31m-11:49[m
[31m-11:49[m
[31m-11:58[m
[31m-11:58[m
[31m-11:58[m
[31m-12:08[m
[31m-12:08[m
[31m-12:17[m
[31m-12:17[m
[31m-12:26[m
[31m-12:26[m
[31m-12:35[m
[31m-12:35[m
[31m-12:35[m
[31m-12:44[m
[31m-12:44[m
[31m-12:44[m
[31m-12:54[m
[31m-12:54[m
[31m-13:04[m
[31m-13:04[m
[31m-13:04[m
[31m-13:13[m
[31m-13:13[m
[31m-13:13[m
[31m-13:22[m
[31m-13:22[m
[31m-13:31[m
[31m-13:31[m
[31m-13:31[m
[31m-13:41[m
[31m-13:41[m
[31m-13:50[m
[31m-13:50[m
[31m-13:50[m
[31m-13:59[m
[31m-13:59[m
[31m-13:59[m
[31m-14:08[m
[31m-14:08[m
[31m-14:08[m
[31m-14:18[m
[31m-14:18[m
[31m-14:18[m
[31m-14:27[m
[31m-14:27[m
[31m-14:27[m
[31m-14:36[m
[31m-14:36[m
[31m-14:45[m
[31m-14:45[m
[31m-14:54[m
[31m-14:54[m
[31m-15:04[m
[31m-15:04[m
[31m-15:13[m
[31m-15:13[m
[31m-15:22[m
[31m-15:22[m
[31m-15:22[m
[31m-15:31[m
[31m-15:31[m
[31m-15:31[m
[31m-15:41[m
[31m-15:41[m
[31m-15:41[m
[31m-15:50[m
[31m-15:50[m
[31m-15:59[m
[31m-15:59[m
[31m-16:08[m
[31m-16:08[m
[31m-16:08[m
[31m-16:17[m
[31m-16:17[m
[31m-16:17[m
[31m-16:27[m
[31m-16:27[m
[31m-16:27[m
[31m-16:36[m
[31m-16:36[m
[31m-16:36[m
[31m-16:45[m
[31m-16:45[m
[31m-16:45[m
[31m-16:54[m
[31m-16:54[m
[31m-17:04[m
[31m-17:04[m
[31m-17:04[m
[31m-17:13[m
[31m-17:13[m
[31m-17:22[m
[31m-17:22[m
[31m-17:31[m
[31m-17:31[m
[31m-17:31[m
[31m-17:40[m
[31m-17:40[m
[31m-17:50[m
[31m-17:50[m
[31m-17:50[m
[31m-17:59[m
[31m-17:59[m
[31m-18:08[m
[31m-18:08[m
[31m-18:08[m
[31m-18:17[m
[31m-18:17[m
[31m-18:17[m
[31m-18:27[m
[31m-18:27[m
[31m-18:27[m
[31m-18:36[m
[31m-18:36[m
[31m-18:36[m
[31m-18:45[m
[31m-18:45[m
[31m-18:45[m
[31m-18:54[m
[31m-18:54[m
[31m-19:04[m
[31m-19:04[m
[31m-19:04[m
[31m-19:13[m
[31m-19:13[m
[31m-19:22[m
[31m-19:22[m
[31m-19:22[m
[31m-19:31[m
[31m-19:31[m
[31m-19:40[m
[31m-19:40[m
[31m-19:50[m
[31m-19:50[m
[31m-19:59[m
[31m-19:59[m
[31m-20:08[m
[31m-20:08[m
[31m-20:08[m
[31m-20:17[m
[31m-20:17[m
[31m-20:17[m
[31m-20:27[m
[31m-20:27[m
[31m-20:27[m
[31m-20:36[m
[31m-20:36[m
[31m-20:36[m
[31m-20:45[m
[31m-20:45[m
[31m-20:54[m
[31m-20:54[m
[31m-20:54[m
[31m-21:03[m
[31m-21:03[m
[31m-21:13[m
[31m-21:13[m
[31m-21:22[m
[31m-21:22[m
[31m-21:31[m
[31m-21:31[m
[31m-21:31[m
[31m-21:40[m
[31m-21:40[m
[31m-21:40[m
[31m-21:50[m
[31m-21:50[m
[31m-21:59[m
[31m-21:59[m
[31m-21:59[m
[31m-22:08[m
[31m-22:08[m
[31m-22:08[m
[31m-22:17[m
[31m-22:17[m
[31m-22:26[m
[31m-22:26[m
[31m-22:36[m
[31m-22:36[m
[31m-22:45[m
[31m-22:45[m
[31m-22:45[m
[31m-22:54[m
[31m-22:54[m
[31m-22:54[m
[31m-23:03[m
[31m-23:03[m
[31m-23:03[m
[31m-23:12[m
[31m-23:12[m
[31m-23:12[m
[31m-23:22[m
[31m-23:22[m
[31m-23:31[m
[31m-23:31[m
[31m-23:31[m
[31m-23:40[m
[31m-23:40[m
[31m-23:49[m
[31m-23:49[m
[31m-23:49[m
[31m-23:58[m
[31m-23:58[m
[31m-23:58[m
\ No newline at end of file[m
[1mdiff --git a/HB Analyzer/Python Log Analyzer/20160420_Messages.log b/HB Analyzer/Python Log Analyzer/20160420_Messages.log[m
[1mdeleted file mode 100644[m
[1mindex 30111a4..0000000[m
[1m--- a/HB Analyzer/Python Log Analyzer/20160420_Messages.log[m	
[1m+++ /dev/null[m
[36m@@ -1,29836 +0,0 @@[m
[31m-[2016-04-20 16:36:07.888] :  : Application initialized...[m
[31m-[2016-04-20 16:37:02.565] :  : Get Status : Init[m
[31m-[2016-04-20 16:37:02.580] :  : Get Status : SendRequest[m
[31m-[2016-04-20 16:37:02.580] :  : TX : 02-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-E6-03 [m
[31m-[2016-04-20 16:37:02.596] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:02.611] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:02.627] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:02.643] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:02.658] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:02.674] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:02.689] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:02.705] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:02.721] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:02.736] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:02.752] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:02.767] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:02.783] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:02.799] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:02.814] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:02.830] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:02.845] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:02.861] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:02.877] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:02.892] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:02.908] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:02.923] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:02.939] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:02.955] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:02.970] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:02.986] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.001] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.017] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.033] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.048] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.064] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.079] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.095] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.111] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.126] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.142] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.157] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.173] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.189] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.204] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.220] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.235] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.251] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.267] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.282] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.298] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.313] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.329] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.345] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.360] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.376] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.392] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.407] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.423] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.438] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.454] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.470] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.485] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.501] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.516] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.532] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.548] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.563] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.579] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.594] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.610] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.626] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.641] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.657] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.672] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.688] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.704] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.719] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.735] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.750] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.766] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.782] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.797] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.813] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.828] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.844] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.860] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.875] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.891] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.906] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.922] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.938] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.953] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.969] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:03.984] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:04.000] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:04.016] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:04.031] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:04.047] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:04.062] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:04.078] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:04.094] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:04.109] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:04.125] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:04.140] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:04.156] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:04.172] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:04.187] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:04.203] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:04.218] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:04.234] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:04.250] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:04.265] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:04.281] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:04.297] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:04.312] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:04.328] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:04.343] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:04.359] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:04.375] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:04.390] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:04.406] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:04.421] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:04.437] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:04.453] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:04.468] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:04.484] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:04.499] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:04.515] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:04.531] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:04.546] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:04.562] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:04.577] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:04.593] :  : Get Status : WaitReply[m
[31m-[2016-04-20 16:37:04.609] :  : Get Status : Done[m
[31m-[2016-04-20 16:37:50.954] : A90432BC : Enable Settings : Init[m
[31m-[2016-04-20 16:37:50.969] : A90432BC : Enable Settings : SendEnable[m
[31m-[2016-04-20 16:37:50.969] : A90432BC : TX : 02-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-A0-03 [m
[31m-[2016-04-20 16:37:50.985] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.000] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.016] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.032] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.047] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.063] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.078] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.094] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.110] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.125] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.141] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.156] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.172] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.188] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.203] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.219] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.234] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.250] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.266] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.281] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.297] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.312] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.328] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.344] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.359] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.375] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.390] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.406] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.422] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.437] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.453] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.468] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.484] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.500] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.515] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.531] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.546] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.562] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.578] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.593] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.609] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.624] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.640] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.656] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.671] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.687] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.702] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.718] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.734] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.749] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.765] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.780] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.796] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.812] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.827] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.843] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.858] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.874] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.890] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.905] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.921] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.936] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.952] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.968] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.983] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:51.999] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.014] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.030] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.046] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.061] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.077] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.092] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.108] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.124] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.139] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.155] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.170] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.186] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.202] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.217] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.233] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.249] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.264] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.280] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.295] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.311] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.327] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.342] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.358] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.373] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.389] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.405] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.420] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.436] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.451] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.467] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.483] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.498] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.514] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.529] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.545] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.561] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.576] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.592] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.607] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.623] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.639] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.654] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.670] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.685] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.701] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.717] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.732] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.748] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.763] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.779] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.795] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.810] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.826] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.841] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.857] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.873] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.888] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.904] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.919] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.935] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.951] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.966] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.982] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:52.997] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.013] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.029] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.044] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.060] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.075] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.091] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.107] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.122] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.138] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.153] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.169] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.185] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.200] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.216] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.231] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.247] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.263] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.278] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.294] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.309] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.325] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.341] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.356] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.372] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.387] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.403] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.419] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.434] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.450] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.465] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.481] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.497] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.512] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.528] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.543] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.559] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.575] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.590] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.606] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.622] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.637] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.653] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.668] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.684] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.700] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.715] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.731] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.746] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.762] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.778] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.793] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.809] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.824] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.840] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.856] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.871] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.887] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.888] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.903] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.935] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.950] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.966] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.981] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:53.997] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.013] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.028] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.044] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.059] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.075] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.091] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.106] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.122] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.137] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.153] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.169] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.184] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.200] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.215] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.231] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.247] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.262] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.278] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.293] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.309] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.325] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.340] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.356] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.371] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.387] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.403] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.418] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.434] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.449] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.465] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.481] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.496] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.512] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.527] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.543] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.559] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.574] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.590] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.605] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.621] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.637] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.668] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.683] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.699] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.715] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.730] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.746] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.761] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.777] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.793] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.824] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.839] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.855] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.871] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.886] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.902] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.918] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.933] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.949] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.964] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.980] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:54.996] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.011] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.027] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.042] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.058] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.074] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.089] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.105] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.120] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.136] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.152] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.167] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.183] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.198] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.214] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.230] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.245] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.261] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.276] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.292] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.308] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.323] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.339] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.354] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.370] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.386] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.401] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.417] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.432] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.448] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.464] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.479] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.495] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.510] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.526] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.542] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.557] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.573] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.588] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.604] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.620] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.635] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.651] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.666] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.682] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.698] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.713] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.729] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.744] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.760] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.776] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.791] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.807] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.822] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.838] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.854] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.869] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.885] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.900] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.916] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.932] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.947] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.963] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.978] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:55.994] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.010] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.025] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.041] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.056] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.072] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.088] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.103] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.119] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.134] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.150] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.166] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.181] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.197] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.212] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.228] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.244] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.259] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.275] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.291] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.306] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.322] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.337] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.353] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.369] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.384] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.400] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.415] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.431] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.447] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.462] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.478] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.493] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.509] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.525] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.540] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.556] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.571] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.587] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.603] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.618] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.634] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.649] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.665] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.681] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.696] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.712] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.727] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.743] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.759] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.774] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.790] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.805] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.821] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.837] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.852] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.868] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.883] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.899] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.915] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.930] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.946] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.961] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.977] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:56.993] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.008] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.024] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.039] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.055] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.071] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.086] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.102] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.117] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.133] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.149] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.164] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.180] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.195] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.211] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.227] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.242] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.258] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.273] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.289] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.305] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.320] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.336] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.351] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.367] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.383] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.384] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.399] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.430] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.446] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.462] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.477] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.493] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.508] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.524] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.540] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.555] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.571] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.586] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.602] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.618] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.633] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.649] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.665] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.680] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.696] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.711] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.727] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.743] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.758] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.774] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.789] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.805] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.821] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.836] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.852] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.867] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.883] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.899] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.914] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.930] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.945] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.961] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.977] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:57.992] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.008] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.023] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.039] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.055] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.070] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.086] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.101] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.117] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.133] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.148] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.164] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.179] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.195] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.211] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.226] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.242] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.257] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.273] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.289] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.304] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.320] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.335] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.351] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.367] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.382] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.398] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.413] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.429] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.445] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.460] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.476] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.491] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.507] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.523] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.538] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.554] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.569] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.585] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.601] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.616] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.632] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.647] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.663] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.679] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.694] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.710] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.725] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.741] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.757] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.772] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.788] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.803] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.819] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.835] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.850] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.866] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.881] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.897] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.913] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.928] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.944] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.959] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.975] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:58.991] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.006] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.022] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.038] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.053] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.069] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.084] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.100] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.116] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.131] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.147] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.162] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.178] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.194] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.209] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.225] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.240] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.256] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.272] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.287] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.303] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.318] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.334] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.350] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.365] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.381] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.396] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.412] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.428] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.443] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.459] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.474] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.490] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.506] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.521] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.537] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.552] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.568] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.584] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.599] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.615] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.630] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.646] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.662] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.677] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.693] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.708] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.724] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.755] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.771] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.786] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.802] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.818] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.833] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.849] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.864] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.880] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.896] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.911] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.927] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.942] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.958] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.974] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:37:59.989] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.005] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.020] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.036] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.052] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.067] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.083] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.098] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.114] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.130] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.145] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.161] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.176] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.192] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.208] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.223] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.239] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.254] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.270] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.286] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.301] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.317] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.332] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.348] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.364] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.379] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.395] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.411] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.426] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.442] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.457] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.473] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.489] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.504] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.520] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.535] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.551] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.567] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.582] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.598] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.613] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.629] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.645] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.660] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.676] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.691] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.707] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.723] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.738] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.754] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.769] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.785] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.801] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.816] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.832] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.847] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.863] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.879] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.894] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.910] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.925] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.941] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.957] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.972] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 16:38:00.988] : A90432BC : Enable Settings : Done[m
[31m-[2016-04-20 16:38:01.066] : A90432BC : Read Zigbee Settings : Init[m
[31m-[2016-04-20 16:38:01.081] : A90432BC : Read Zigbee Settings : SendRequest[m
[31m-[2016-04-20 16:38:01.081] : A90432BC : TX : 02-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-E1-03 [m
[31m-[2016-04-20 16:38:01.097] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.113] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.128] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.144] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.159] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.175] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.191] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.206] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.222] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.237] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.253] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.269] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.284] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.300] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.315] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.331] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.347] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.362] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.378] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.393] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.409] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.425] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.440] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.456] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.471] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.487] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.503] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.518] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.534] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.549] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.565] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.581] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.596] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.612] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.627] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.643] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.659] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.674] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.690] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.706] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.721] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.737] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.752] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.768] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.784] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.799] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.815] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.830] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.846] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.862] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.877] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.893] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.908] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.924] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.940] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.955] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.971] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:01.986] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.002] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.018] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.033] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.049] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.064] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.080] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.096] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.111] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.127] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.142] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.158] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.174] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.189] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.205] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.220] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.236] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.252] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.267] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.283] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.298] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.314] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.330] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.345] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.361] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.376] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.392] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.408] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.423] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.439] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.454] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.470] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.486] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.501] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.517] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.532] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.548] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.564] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.579] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.595] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.610] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.626] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.642] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.657] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.673] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.688] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.704] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.720] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.735] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.751] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.766] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.782] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.798] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.813] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.829] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.844] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.860] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.876] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.891] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.907] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.922] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.938] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.954] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.969] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:02.985] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.000] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.016] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.032] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.047] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.063] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.079] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.094] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.110] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.125] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.141] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.157] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.172] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.188] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.203] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.219] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.235] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.250] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.266] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.281] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.297] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.313] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.328] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.344] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.359] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.375] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.391] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.406] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.422] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.437] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.453] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.469] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.484] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.500] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.515] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.531] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.547] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.562] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.578] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.593] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.609] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.625] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.640] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.656] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.671] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.687] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.703] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.718] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.734] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.749] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.765] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.781] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.796] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.812] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.827] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.843] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.859] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.874] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.875] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.891] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.922] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.938] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.953] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.969] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:03.984] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.000] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.016] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.031] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.047] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.062] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.078] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.094] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.109] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.125] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.140] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.156] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.172] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.187] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.203] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.218] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.234] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.250] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.265] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.281] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.296] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.312] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.328] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.343] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.359] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.374] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.390] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.406] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.421] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.437] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.453] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.468] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.484] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.499] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.515] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.531] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.546] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.562] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.577] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.593] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.609] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.624] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.640] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.655] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.671] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.687] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.702] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.718] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.733] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.749] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.765] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.780] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.796] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.811] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.827] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.843] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.858] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.874] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.889] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.905] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.921] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.936] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.952] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.967] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.983] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:04.999] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.014] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.030] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.045] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.061] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.077] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.092] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.108] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.123] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.139] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.155] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.170] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.186] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.201] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.217] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.233] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.248] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.264] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.279] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.295] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.311] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.326] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.342] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.357] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.373] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.389] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.404] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.420] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.435] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.451] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.467] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.482] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.498] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.513] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.529] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.545] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.560] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.576] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.591] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.607] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.623] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.638] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.654] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.669] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.685] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.701] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.716] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.732] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.747] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.763] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.779] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.794] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.810] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.826] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.841] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.857] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.872] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.888] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.904] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.919] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.935] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.950] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.966] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.982] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:05.997] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.013] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.028] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.044] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.060] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.075] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.091] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.106] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.122] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.138] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.153] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.169] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.184] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.200] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.216] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.231] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.247] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.262] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.278] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.294] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.309] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.325] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.340] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.356] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.372] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.387] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.403] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.404] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.419] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.451] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.466] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.482] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.497] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.513] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.529] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.544] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.560] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.575] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.591] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.607] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.622] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.638] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.653] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.669] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.685] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.700] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.716] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.731] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.747] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.763] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.778] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.794] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.809] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.825] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.841] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.856] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.872] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.887] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.903] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.919] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.934] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.950] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.965] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.981] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:06.997] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.012] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.028] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.043] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.059] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.075] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.090] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.106] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.122] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.137] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.153] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.168] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.184] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.200] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.215] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.231] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.246] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.262] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.278] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.293] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.309] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.324] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.340] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.356] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.371] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.387] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.402] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.418] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.434] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.449] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.465] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.480] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.496] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.512] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.527] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.543] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.558] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.574] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.590] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.605] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.621] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.636] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.652] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.668] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.683] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.699] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.714] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.730] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.746] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.761] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.777] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.792] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.808] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.824] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.839] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.855] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.870] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.886] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.902] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.917] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.933] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.948] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.964] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.980] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:07.995] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.011] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.026] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.042] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.058] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.073] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.089] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.104] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.120] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.136] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.151] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.167] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.182] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.198] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.214] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.229] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.245] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.260] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.276] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.292] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.307] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.323] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.354] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.370] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.385] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.401] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.416] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.432] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.448] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.463] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.479] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.495] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.510] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.526] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.541] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.557] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.573] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.588] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.604] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.619] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.635] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.651] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.666] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.682] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.697] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.713] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.729] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.744] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.760] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.775] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.791] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.807] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.822] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.838] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.853] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.869] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.885] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.900] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.916] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.931] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.947] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.963] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.978] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:08.994] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.009] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.025] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.041] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.056] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.072] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.087] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.103] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.119] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.134] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.150] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.165] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.181] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.197] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.212] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.228] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.243] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.259] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.275] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.290] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.306] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.321] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.337] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.353] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.368] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.384] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.399] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.415] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.431] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.446] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.462] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.477] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.493] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.509] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.524] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.540] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.555] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.571] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.587] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.602] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.618] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.633] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.649] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.665] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.680] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.696] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.711] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.727] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.743] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.758] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.774] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.789] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.805] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.821] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.836] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.852] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.868] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.883] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.899] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.914] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.930] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.946] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.961] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.977] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:09.992] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.008] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.024] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.039] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.055] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.070] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.086] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.102] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.117] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.133] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.148] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.164] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.180] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.195] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.211] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.226] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.242] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.258] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.273] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.289] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.304] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.320] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.336] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.351] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.367] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.382] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.398] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.414] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.429] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.445] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.460] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.476] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.492] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.507] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.523] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.538] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.554] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.570] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.585] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.601] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.616] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.632] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.648] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.663] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.679] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.694] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.710] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.726] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.741] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.757] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.772] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.788] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.804] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.819] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.835] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.850] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.866] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.882] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.897] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.913] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.928] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.944] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.960] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.975] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:10.991] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:11.006] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:11.022] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:11.038] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:11.053] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:11.069] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:11.084] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 16:38:11.100] : A90432BC : Read Zigbee Settings : Done[m
[31m-[2016-04-20 17:31:37.102] : A90432BC : Get Status : Init[m
[31m-[2016-04-20 17:31:37.118] : A90432BC : Get Status : SendRequest[m
[31m-[2016-04-20 17:31:37.118] : A90432BC : TX : 02-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-E6-03 [m
[31m-[2016-04-20 17:31:37.133] : A90432BC : Get Status : WaitReply[m
[31m-[2016-04-20 17:31:37.149] : A90432BC : Get Status : WaitReply[m
[31m-[2016-04-20 17:31:37.165] : A90432BC : Get Status : WaitReply[m
[31m-[2016-04-20 17:31:37.180] : A90432BC : Get Status : WaitReply[m
[31m-[2016-04-20 17:31:37.196] : A90432BC : Get Status : WaitReply[m
[31m-[2016-04-20 17:31:37.211] : A90432BC : Get Status : WaitReply[m
[31m-[2016-04-20 17:31:37.227] : A90432BC : Get Status : WaitReply[m
[31m-[2016-04-20 17:31:37.243] : A90432BC : Get Status : WaitReply[m
[31m-[2016-04-20 17:31:37.243] : A90432BC : RX : 02-FF-00-1E-71-01-00-00-00-00-00-1E-71-01-00-00-00-00-E6-81-00-E1-08-F6-09-89-05-26-01-00-00-00-0C-00-08-00-00-00-00-0F-7C-0F-7E-13-03[m
[31m-[2016-04-20 17:31:37.258] : A90432BC : Get Status : WaitReply[m
[31m-[2016-04-20 17:31:37.274] : A90432BC : Get Status : SendResponse[m
[31m-[2016-04-20 17:31:37.274] : A90432BC : TX : 02-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-E6-06-00-03 [m
[31m-[2016-04-20 17:31:37.289] : A90432BC : Get Status : Done[m
[31m-[2016-04-20 17:31:43.949] : A90432BC : Incomplete Message Received : RX : F[m
[31m-[2016-04-20 17:31:43.981] : A90432BC : Found 56 Extra bytes to Message: RX : F001E7100000000A2001E710100000139A3D0D08110000000000000[m
[31m-[2016-04-20 17:31:43.981] : A90432BC : RX : 02-FF-00-1E-71-00-00-00-00-A2-00-1E-71-01-00-00-01-39-A3-D0-D0-81-10-00-00-00-00-00-00-03[m
[31m-[2016-04-20 17:31:51.284] : A90432BC : RX : 02-FF-00-1E-71-00-00-00-00-A2-00-1E-71-01-00-00-01-39-A3-D0-D0-81-10-00-00-00-00-00-00-03[m
[31m-[2016-04-20 17:32:06.069] : A90432BC : RX : 02-FF-00-1E-71-00-00-00-00-A2-00-1E-71-01-00-00-01-39-A3-D0-D0-81-10-00-00-00-00-00-00-03[m
[31m-[2016-04-20 17:33:14.056] : A90432BC : Enable Settings : Init[m
[31m-[2016-04-20 17:33:14.072] : A90432BC : Enable Settings : SendEnable[m
[31m-[2016-04-20 17:33:14.072] : A90432BC : TX : 02-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-A0-03 [m
[31m-[2016-04-20 17:33:14.087] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 17:33:14.103] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 17:33:14.118] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 17:33:14.134] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 17:33:14.150] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 17:33:14.165] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 17:33:14.181] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 17:33:14.196] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 17:33:14.196] : A90432BC : RX : 02-FF-00-1E-71-01-00-00-00-00-00-1E-71-01-00-00-00-00-A0-06-00-03[m
[31m-[2016-04-20 17:33:14.212] : A90432BC : Enable Settings : WaitReply[m
[31m-[2016-04-20 17:33:14.243] : A90432BC : Enable Settings : Done[m
[31m-[2016-04-20 17:33:14.306] : A90432BC : Read Zigbee Settings : Init[m
[31m-[2016-04-20 17:33:14.321] : A90432BC : Read Zigbee Settings : SendRequest[m
[31m-[2016-04-20 17:33:14.321] : A90432BC : TX : 02-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-E1-03 [m
[31m-[2016-04-20 17:33:14.337] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 17:33:14.352] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 17:33:14.368] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 17:33:14.384] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 17:33:14.399] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 17:33:14.415] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 17:33:14.430] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 17:33:14.446] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 17:33:14.446] : A90432BC : RX : 02-FF-00-1E-71-01-00-00-00-00-00-1E-71-01-00-00-00-00-E1-81-00-1E-71-01-00-00-00-00-99-19-11-4C-00-80-10-06-00-00-00-00-00-00-00-00-03[m
[31m-[2016-04-20 17:33:14.462] : A90432BC : Read Zigbee Settings : WaitReply[m
[31m-[2016-04-20 17:33:14.477] : A90432BC : Read Zigbee Settings : SendResponse[m
[31m-[2016-04-20 17:33:14.477] : A90432BC : TX : 02-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-E1-06-00-03 [m
[31m-[2016-04-20 17:33:14.493] : A90432BC : Read Zigbee Settings : Done[m
[31m-[2016-04-20 17:33:20.356] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:33:20.372] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:33:20.372] : A90432BC : TX : 02-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-F2-81-00-03 [m
[31m-[2016-04-20 17:33:20.388] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:33:20.403] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:33:20.419] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:33:20.434] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:33:20.450] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:33:20.466] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:33:20.481] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:33:20.497] : A90432BC : RX : 02-FF-00-1E-71-01-00-00-00-00-00-1E-71-01-00-00-00-00-F2-06-00-03[m
[31m-[2016-04-20 17:33:20.497] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:33:20.512] : A90432BC : Write Outputs : Done[m
[31m-[2016-04-20 17:33:21.261] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:33:21.277] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:33:21.277] : A90432BC : TX : 02-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-F2-83-00-03 [m
[31m-[2016-04-20 17:33:21.292] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:33:21.308] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:33:21.324] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:33:21.339] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:33:21.355] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:33:21.370] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:33:21.386] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:33:21.402] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:33:21.402] : A90432BC : RX : 02-FF-00-1E-71-01-00-00-00-00-00-1E-71-01-00-00-00-00-F2-06-00-03[m
[31m-[2016-04-20 17:33:21.417] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:33:21.433] : A90432BC : Write Outputs : Done[m
[31m-[2016-04-20 17:33:21.965] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:33:21.981] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:33:21.981] : A90432BC : TX : 02-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-F2-87-00-03 [m
[31m-[2016-04-20 17:33:21.997] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:33:22.012] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:33:22.028] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:33:22.043] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:33:22.059] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:33:22.075] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:33:22.090] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:33:22.106] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:33:22.106] : A90432BC : RX : 02-FF-00-1E-71-01-00-00-00-00-00-1E-71-01-00-00-00-00-F2-06-00-03[m
[31m-[2016-04-20 17:33:22.121] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:33:22.137] : A90432BC : Write Outputs : Done[m
[31m-[2016-04-20 17:33:22.652] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:33:22.667] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:33:22.667] : A90432BC : TX : 02-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-F2-8F-00-03 [m
[31m-[2016-04-20 17:33:22.683] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:33:22.699] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:33:22.714] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:33:22.730] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:33:22.745] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:33:22.761] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:33:22.777] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:33:22.792] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:33:22.792] : A90432BC : RX : 02-FF-00-1E-71-01-00-00-00-00-00-1E-71-01-00-00-00-00-F2-06-00-03[m
[31m-[2016-04-20 17:33:22.808] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:33:22.823] : A90432BC : Write Outputs : Done[m
[31m-[2016-04-20 17:36:02.065] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:36:02.080] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:36:02.080] : A90432BC : TX : 02-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-F2-8E-00-03 [m
[31m-[2016-04-20 17:36:02.096] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.112] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.127] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.143] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.158] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.174] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.190] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.205] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.221] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.236] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.252] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.268] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.283] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.284] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.300] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.331] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.347] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.362] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.378] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.393] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.409] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.425] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.440] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.456] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.471] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.487] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.503] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.518] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.534] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.549] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.565] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.581] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.596] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.612] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.627] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.643] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.659] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.674] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.690] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.705] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.721] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.737] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.752] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.768] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.783] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.799] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.815] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.830] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.846] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.861] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.877] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.893] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.908] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.924] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.939] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.955] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.971] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:02.986] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.002] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.017] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.033] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.049] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.064] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.080] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.095] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.111] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.127] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.142] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.158] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.173] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.189] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.205] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.220] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.236] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.251] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.267] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.283] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.298] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.314] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.329] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.345] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.361] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.376] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.392] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.407] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.423] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.439] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.470] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:36:03.485] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:36:03.501] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.517] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.532] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.548] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.563] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.579] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.595] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.610] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.626] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.641] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.657] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.673] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.688] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.704] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.720] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.735] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.751] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.766] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.782] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.798] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.813] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.829] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.844] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.860] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.876] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.891] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.907] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.922] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.938] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.954] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.969] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:03.985] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.000] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.016] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.032] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.047] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.063] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.078] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.094] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.110] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.125] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.141] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.156] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.172] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.188] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.203] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.219] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.234] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.250] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.266] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.281] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.312] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:36:04.328] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:36:04.344] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.359] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.375] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.390] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.406] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.422] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.437] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.453] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.468] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.484] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.500] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.515] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.531] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.546] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.562] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.578] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.593] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.609] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.624] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.640] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.656] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.671] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.687] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.702] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.718] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.734] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.749] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.765] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.780] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.796] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.812] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.827] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.843] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.858] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.874] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.890] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.905] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.921] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.936] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.952] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.968] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.983] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:04.999] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.014] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.030] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.046] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.061] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.077] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.092] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.108] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.124] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.139] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.155] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.170] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.186] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.202] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.217] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.233] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.248] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.264] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.280] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.295] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.311] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.326] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.342] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.358] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.373] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.389] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.405] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.420] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.436] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.451] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.467] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.483] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.498] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.514] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.529] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.545] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.561] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.592] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:36:05.623] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:36:05.639] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.654] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.670] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.685] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.701] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.717] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.732] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.748] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.763] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.779] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.795] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.810] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.826] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.841] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.857] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.873] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.888] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.904] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.919] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.935] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.951] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.966] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.982] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:05.997] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.013] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.014] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.015] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.062] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.077] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.093] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.109] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.124] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.140] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.155] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.171] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.187] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.202] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.218] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.233] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.249] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.265] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.280] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.296] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.311] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.327] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.343] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.358] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.374] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.389] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.405] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.421] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.436] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.452] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.467] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.483] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.499] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.514] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.530] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.531] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.546] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.578] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.593] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.594] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.610] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.641] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.657] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.672] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.688] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.703] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.719] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.735] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.750] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.766] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.781] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.813] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:36:06.828] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:36:06.844] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.859] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.875] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.891] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.906] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.922] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.937] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.953] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.969] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:06.984] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.000] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.016] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.031] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.047] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.062] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.078] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.094] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.109] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.125] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.140] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.156] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.172] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.187] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.203] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.218] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.234] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.250] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.265] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.281] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.296] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.312] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.328] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.343] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.359] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.374] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.390] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.406] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.421] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.437] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.452] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.468] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.484] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.499] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.515] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.530] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.546] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.562] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.577] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.593] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.608] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.624] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.640] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.655] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.671] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.686] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.702] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.718] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.733] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.749] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.764] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.780] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.796] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.811] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.827] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.842] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.858] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.874] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.889] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.905] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.920] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.936] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.952] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.967] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.983] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:07.998] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.014] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.030] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.045] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.061] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.076] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.092] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.108] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.123] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.139] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.154] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.170] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.186] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.201] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.217] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.232] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.248] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.264] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.279] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.295] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.310] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.326] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.342] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.357] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.373] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.388] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.404] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.420] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.435] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.451] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.466] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.482] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.498] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.513] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.529] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.544] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.560] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.576] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.591] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.607] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.622] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.638] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.654] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.669] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.685] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.701] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.716] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.732] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.747] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.763] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.779] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.794] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.810] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.825] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.841] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.857] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.872] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.888] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.903] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.919] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.935] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.950] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.966] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.981] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:08.997] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.013] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.028] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.044] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.059] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.075] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.091] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.106] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.122] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.137] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.153] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.169] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.184] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.200] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.215] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.231] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.247] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.262] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.278] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.293] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.309] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.325] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.340] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.356] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.371] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.387] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.403] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.418] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.449] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:36:09.465] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:36:09.481] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.496] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.512] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.527] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.543] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.559] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.574] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.590] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.605] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.621] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.637] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.652] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.668] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.683] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.699] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.715] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.730] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.746] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.761] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.777] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.793] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.808] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.824] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.839] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.855] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.871] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.886] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.902] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.917] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.933] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.949] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.964] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.980] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:09.995] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.011] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.027] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.042] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.058] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.073] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.089] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.105] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.120] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.136] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.151] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.167] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.183] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.198] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.214] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.229] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.245] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.261] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.276] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.292] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.308] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.323] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.339] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.354] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.370] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.386] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.401] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.417] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.432] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.448] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.464] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.479] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.495] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.510] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.526] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.542] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.557] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.573] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.588] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.604] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.620] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.635] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.651] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.666] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.682] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.698] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.713] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.729] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.744] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.760] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.776] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.791] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.807] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.822] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.838] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.854] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.869] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.885] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.900] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.916] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.932] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.947] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.963] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.978] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:10.994] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.010] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.025] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.041] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.056] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.072] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.088] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.103] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.119] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.134] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.150] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.166] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.181] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.197] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.212] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.228] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.244] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.259] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.275] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.290] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.306] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.337] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:36:11.353] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:36:11.368] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.384] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.400] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.415] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.431] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.446] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.462] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.478] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.493] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.509] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.524] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.540] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.556] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.571] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.587] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.602] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.618] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.634] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.649] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.665] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.666] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.667] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.714] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.729] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.745] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.760] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.776] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.792] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.807] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.823] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.838] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.854] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.870] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.885] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.901] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.916] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.932] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.948] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.963] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.979] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:11.995] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.010] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.026] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.041] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.057] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.073] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.088] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.104] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.119] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.135] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.151] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.166] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.182] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.197] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.213] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.229] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.244] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.260] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.275] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.291] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.307] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.322] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.338] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.353] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.369] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.385] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.400] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.416] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.431] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.447] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.463] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.478] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.494] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.509] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.525] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.541] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.556] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.572] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.587] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.603] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.619] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.634] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.650] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.665] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.681] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.697] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.712] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.728] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.743] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.759] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.775] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.790] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.806] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.821] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.837] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.853] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.868] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.884] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.899] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.915] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.931] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.946] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.962] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.977] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:12.993] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.009] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.024] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.040] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.055] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.071] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.087] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.102] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.118] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.133] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.149] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.165] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.180] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.196] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.211] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.227] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.243] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.258] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.274] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.289] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.305] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.321] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.336] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.352] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.367] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.383] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.399] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.414] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.430] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.445] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.461] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.477] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.492] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.508] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.523] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.539] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.555] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.570] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.586] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.602] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.617] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.633] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.648] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.664] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.680] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.695] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.711] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.726] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.742] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.758] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.773] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.789] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.804] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.820] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.836] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.851] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.867] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.882] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.898] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.914] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.929] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.945] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.960] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.976] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:13.992] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.007] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.023] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.038] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.054] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.070] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.085] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.101] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.116] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.132] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.148] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.163] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.179] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.194] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.210] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.226] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.241] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.257] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.272] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.288] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.304] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.319] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.335] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.350] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.366] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.382] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.397] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.413] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.428] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.444] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.460] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.475] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.491] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.506] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.538] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:36:14.553] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:36:14.569] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.584] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.600] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.616] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.631] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.647] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.662] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.678] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.694] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.709] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.725] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.740] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.756] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.772] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.787] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.803] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.818] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.834] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.850] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.865] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.881] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.896] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.912] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.928] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.943] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.959] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.974] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:14.990] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.006] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.021] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.037] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.052] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.068] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.084] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.099] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.115] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.130] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.146] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.162] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.177] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.193] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.209] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.224] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.240] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.255] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.271] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.287] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.302] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.318] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.333] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.349] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.365] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.380] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.396] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.411] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.427] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.443] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.458] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.474] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.489] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.505] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.521] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.536] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.552] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.567] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.583] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.584] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.600] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.631] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.646] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.662] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.678] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.693] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.709] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.724] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.740] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.756] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.771] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.787] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.802] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.818] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.834] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.849] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.865] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.880] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.896] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.912] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.927] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.943] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.958] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.974] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:15.990] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.005] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.021] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.036] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.052] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.068] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.083] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.099] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.114] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.130] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.146] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.161] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.177] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.192] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.208] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.224] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.239] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.255] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.270] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.286] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.302] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.317] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.333] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.348] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.364] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.380] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.395] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.411] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.426] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.442] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.458] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.473] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.489] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.504] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.520] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.536] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.551] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.567] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.582] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.598] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.614] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.629] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.645] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.660] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.676] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.692] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.707] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.723] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.738] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.754] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.770] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.785] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.801] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.816] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.832] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.848] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.863] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.879] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.895] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.910] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.926] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.941] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.957] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.973] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:16.988] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.004] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.019] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.035] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.051] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.066] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.082] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.097] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.113] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.129] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.144] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.160] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.175] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.191] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.207] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.222] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.238] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.253] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.269] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.285] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.286] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.287] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.333] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.349] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.365] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.380] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.396] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.411] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.427] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.443] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.458] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.474] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.489] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.505] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.521] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.536] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.552] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.567] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.583] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.599] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.614] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.630] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.645] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.661] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.677] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.692] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.708] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.723] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.739] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.755] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.770] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.786] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.801] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.817] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.833] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.848] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.864] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.879] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.895] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.911] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.926] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:17.957] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:36:17.973] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:36:17.989] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.004] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.020] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.035] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.051] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.067] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.082] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.098] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.113] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.129] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.145] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.160] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.176] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.191] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.207] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.223] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.238] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.254] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.269] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.285] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.301] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.316] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.332] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.347] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.363] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.379] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.394] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.410] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.425] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.441] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.457] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.472] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.488] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.504] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.519] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.535] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.550] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.566] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.582] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.597] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.613] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.628] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.644] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.660] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.675] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.691] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.706] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.722] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.738] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.753] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.769] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.784] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.800] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.816] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.831] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.847] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.862] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.878] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.894] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.909] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.925] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.926] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.927] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.974] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:18.989] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.005] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.020] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.036] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.052] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.067] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.083] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.098] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.114] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.130] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.145] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.161] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.176] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.192] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.208] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.223] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.239] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.254] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.270] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.286] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.301] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.317] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.332] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.348] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.364] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.379] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.395] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.410] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.426] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.442] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.457] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.473] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.488] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.504] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.520] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.535] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.551] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.566] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.582] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.598] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.613] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.629] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.644] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.660] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.676] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.691] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.707] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.722] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.738] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.754] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.769] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.785] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.800] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.816] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.832] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.847] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.863] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.878] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.894] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.910] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.925] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.941] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.956] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.972] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:19.988] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.003] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.019] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.034] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.050] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.066] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.081] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.097] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.112] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.128] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.144] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.159] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.175] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.191] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.206] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.222] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.237] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.253] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.269] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.284] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.300] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.315] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.331] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.347] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.362] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.378] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.393] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.409] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.425] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.440] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.456] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.471] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.487] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.503] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.518] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.519] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.520] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.531] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.541] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.551] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.561] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.600] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.616] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.632] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.647] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.663] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.678] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.679] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.680] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.691] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.743] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.759] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.774] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.790] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.806] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.821] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.837] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.852] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.868] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.884] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.899] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.915] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.930] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.946] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.947] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.948] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:20.958] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.008] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.023] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.039] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.055] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.070] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.086] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.101] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.117] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.133] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.148] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.164] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.179] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.195] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.211] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.226] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.242] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.257] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.273] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.289] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.304] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.320] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.335] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.351] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.367] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.382] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.398] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.413] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.429] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.445] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.460] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.476] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.491] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.507] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.538] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:36:21.554] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:36:21.569] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.585] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.601] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.616] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.632] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.647] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.663] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.679] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.694] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.710] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.726] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.741] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.757] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.772] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.788] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.804] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.819] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.835] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.850] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.866] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.882] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.897] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.913] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.928] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.944] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.960] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.975] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:21.991] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.006] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.022] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.038] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.053] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.069] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.084] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.100] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.116] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.131] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.147] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.162] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.178] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.194] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.209] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.225] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.240] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.256] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.272] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.287] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.303] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.318] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.334] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.350] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.365] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.381] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.396] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.412] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.428] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.443] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.459] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.474] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.490] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.506] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.521] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.537] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.552] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.568] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.584] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.599] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.615] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.630] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.646] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.662] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.677] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.693] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.708] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.724] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.740] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.755] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.771] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.786] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.802] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.818] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.833] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.849] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.864] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.880] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.896] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.911] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.927] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.942] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.958] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.974] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:22.989] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.005] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.020] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.036] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.052] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.067] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.083] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.098] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.114] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.130] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.145] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.161] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.176] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.192] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.208] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.223] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.239] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.254] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.270] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.286] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.301] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.317] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.332] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.348] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.364] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.379] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.395] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.411] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.426] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.442] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.457] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.473] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.489] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.504] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.520] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.535] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.551] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.567] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.582] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.598] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.613] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.629] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.645] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.660] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.676] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.691] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.707] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.723] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.738] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.754] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.769] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.785] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.801] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.816] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.832] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.847] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.863] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.879] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.894] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.910] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.925] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.941] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.957] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.972] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:23.988] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.003] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.019] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.035] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.050] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.066] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.081] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.097] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.113] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.128] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.144] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.159] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.175] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.191] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.206] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.222] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.237] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.253] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.269] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.284] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.300] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.315] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.331] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.347] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.362] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.378] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.393] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.409] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.425] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.440] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.456] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.471] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.487] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.503] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.518] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.534] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.565] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.581] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.596] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.612] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.627] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.643] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.659] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.674] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.690] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.705] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.721] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.737] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.752] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.768] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.783] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.799] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.815] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.830] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.846] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.861] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.877] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.893] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.908] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.924] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.939] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.955] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.971] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:24.986] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.002] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.018] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.033] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.049] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.064] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.080] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.096] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.111] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.127] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.142] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.158] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.174] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.189] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.205] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.220] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.236] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.252] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.267] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.283] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.298] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.314] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.330] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.345] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.361] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.376] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.392] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.408] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.423] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.439] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.454] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.470] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.486] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.517] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:36:25.532] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:36:25.548] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.564] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.579] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.595] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.596] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.597] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.608] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.618] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.670] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.685] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.701] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.716] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.732] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.748] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.763] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.779] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.794] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.810] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.826] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.841] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.857] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.872] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.888] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.904] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.919] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.935] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.950] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.966] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.982] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:25.997] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.013] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.028] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.044] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.060] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.075] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.091] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.106] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.122] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.138] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.153] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.169] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.184] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.200] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.216] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.231] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.247] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.262] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.278] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.294] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.309] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.325] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.340] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.356] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.372] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.387] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.403] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.418] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.434] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.450] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.465] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.481] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.496] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.512] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.528] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.543] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.559] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.574] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.590] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.606] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.621] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.637] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.653] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.668] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.684] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.699] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.715] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.731] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.746] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.762] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.777] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.793] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.809] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.824] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.840] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.855] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.871] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.887] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.902] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.918] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.933] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.949] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.965] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.980] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:26.996] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.011] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.027] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.043] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.058] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.074] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.089] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.105] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.121] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.136] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.152] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.167] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.183] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.199] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.214] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.230] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.245] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.261] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.277] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.292] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.308] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.323] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.339] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.355] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.370] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.386] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.401] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.417] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.433] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.448] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.464] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.479] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.495] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.511] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.526] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.542] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.557] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.573] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.589] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.604] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.620] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.635] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.651] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.667] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.682] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.698] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.713] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.729] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.745] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.760] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.776] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.791] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.807] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.823] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.838] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.854] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.869] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.885] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.901] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.916] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.932] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.947] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.963] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.979] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:27.994] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.010] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.025] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.041] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.042] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.058] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.089] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.104] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.120] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.136] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.151] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.167] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.182] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.198] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.214] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.229] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.245] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.260] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.276] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.292] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.307] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.323] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.339] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.354] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.370] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.385] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.401] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.417] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.432] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.448] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.463] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.479] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.495] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.510] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.526] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.541] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.557] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.573] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.588] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.604] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.619] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.635] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.651] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.666] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.682] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.697] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.713] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.729] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.744] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.760] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.775] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.791] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.807] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.822] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.838] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.853] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.869] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.885] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.900] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.916] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.931] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.947] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.963] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.978] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:28.994] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.009] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.025] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.041] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.056] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.072] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.087] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.103] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.119] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.134] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.150] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.165] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.181] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.197] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.212] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.228] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.243] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.259] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.275] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.290] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.306] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.321] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.337] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.353] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.368] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.384] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.399] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.415] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.431] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.446] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.462] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.477] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.493] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.509] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.524] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.540] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.555] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.571] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.587] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.602] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.618] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.633] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.649] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.665] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.680] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.696] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.711] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.727] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.743] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.758] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.774] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.789] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.805] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.821] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.836] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.852] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.867] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.883] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.899] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.914] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.930] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.946] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.961] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.977] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:29.992] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.008] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.024] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.039] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.055] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.070] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.086] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.102] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.117] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.133] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.148] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.164] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.180] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.195] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.211] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.226] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.242] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.258] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.273] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.289] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.304] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.320] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.336] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.351] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.367] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.382] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.398] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.414] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.429] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.445] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.460] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.476] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.492] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.507] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.523] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.538] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.554] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.570] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.585] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.601] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.616] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.632] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.648] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.663] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.679] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.694] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.710] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.726] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.741] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.757] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.772] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.788] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.804] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.819] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.835] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.850] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.866] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.882] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.897] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.913] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.928] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.944] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.960] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.975] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:30.991] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.006] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.022] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.038] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.053] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.069] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.084] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.100] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.116] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.131] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.147] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.162] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.178] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.194] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.209] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.225] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.240] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.256] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.272] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.287] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.303] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.318] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.334] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.350] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.365] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.381] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.396] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.412] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.428] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.429] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.430] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.477] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.493] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.509] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.524] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.540] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.556] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.571] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.587] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.602] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.618] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.634] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.649] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.665] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.680] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.696] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.712] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.727] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.743] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.758] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.774] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.790] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.805] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.821] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.836] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.852] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.868] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.883] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.899] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.914] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.930] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.946] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.961] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.977] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:31.992] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.008] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.024] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.039] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.055] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.070] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.086] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.102] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.117] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.133] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.148] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.164] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.180] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.195] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.211] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.226] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.242] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.258] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.273] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.289] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.304] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.320] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.336] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.351] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.367] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.382] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.398] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.414] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.429] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.445] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.460] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.476] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.492] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.507] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.523] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.538] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.554] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.570] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.585] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.601] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.616] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.632] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.648] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.663] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.679] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.694] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.710] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.726] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.741] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.757] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.772] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.788] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.804] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.819] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.835] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.850] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.866] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.882] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.897] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.913] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.928] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.944] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.960] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.975] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:32.991] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.006] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.022] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.038] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.053] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.069] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.084] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.100] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.116] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.131] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.147] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.162] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.178] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.194] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.209] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.225] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.241] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.256] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.272] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.287] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.303] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.319] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.334] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.350] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.365] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.381] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.397] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.412] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.428] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.443] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.459] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.475] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.490] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.506] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.521] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.537] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.553] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.568] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.584] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.599] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.615] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.631] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.646] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.662] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.677] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.693] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.709] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.724] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.740] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.755] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.771] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.787] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.802] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.818] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.833] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.849] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.865] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.880] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.896] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.911] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.927] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.943] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.958] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.974] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:33.989] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.005] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.021] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.036] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.052] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.067] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.083] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.099] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.114] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.130] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.145] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.161] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.177] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.192] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.208] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.223] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.239] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.255] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.270] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.286] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.301] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.317] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.333] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.348] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.364] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.379] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.395] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.411] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.426] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.442] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.457] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.473] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.489] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.504] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.520] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.535] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.551] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.567] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.582] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.598] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.613] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.629] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.645] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.660] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.676] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.691] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.707] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.723] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.738] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.754] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.769] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.785] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.801] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.816] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.832] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.848] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.863] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.879] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.894] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.910] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.926] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.941] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.957] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.972] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:34.988] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.004] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.019] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.035] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.050] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.066] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.082] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.097] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.113] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.128] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.144] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.160] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.175] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.191] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.206] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.222] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.238] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.253] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.269] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.284] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.300] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.316] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.331] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.347] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.362] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.378] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.394] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.409] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.425] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.440] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.456] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.472] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.487] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.503] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.518] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.534] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.550] : A90432BC : Write Outputs : Done[m
[31m-[2016-04-20 17:36:35.565] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.581] : A90432BC : Write Outputs : Done[m
[31m-[2016-04-20 17:36:35.581] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.596] : A90432BC : Write Outputs : Done[m
[31m-[2016-04-20 17:36:35.596] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.612] : A90432BC : Write Outputs : Done[m
[31m-[2016-04-20 17:36:35.612] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.628] : A90432BC : Write Outputs : Done[m
[31m-[2016-04-20 17:36:35.628] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.643] : A90432BC : Write Outputs : Done[m
[31m-[2016-04-20 17:36:35.643] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.644] : A90432BC : Write Outputs : Done[m
[31m-[2016-04-20 17:36:35.644] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.675] : A90432BC : Write Outputs : Done[m
[31m-[2016-04-20 17:36:35.675] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.691] : A90432BC : Write Outputs : Done[m
[31m-[2016-04-20 17:36:35.691] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.707] : A90432BC : Write Outputs : Done[m
[31m-[2016-04-20 17:36:35.707] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:35.722] : A90432BC : Write Outputs : Done[m
[31m-[2016-04-20 17:36:37.924] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:36:37.940] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:36:37.955] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:37.971] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:37.986] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.002] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.018] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.033] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.049] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.064] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.080] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.096] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.111] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.127] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.143] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.158] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.174] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.189] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.205] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.221] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.236] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.252] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.267] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.283] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.299] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.314] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.330] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.345] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.361] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.377] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.392] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.408] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.423] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.439] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.455] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.470] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.486] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.501] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.517] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.533] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.548] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.564] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.579] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.595] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.611] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.626] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.642] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.657] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.673] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.689] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.704] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.720] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.735] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.751] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.767] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.782] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.798] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.813] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.829] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.845] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.860] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.876] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.891] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.907] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.923] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.938] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.954] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.969] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:38.985] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.001] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.016] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.032] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.047] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.063] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.079] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.094] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.110] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.125] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.141] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.157] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.172] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.188] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.203] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.219] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.235] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.250] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.266] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.281] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.297] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.313] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.328] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.344] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.359] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.375] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.391] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.406] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.422] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.437] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.453] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.469] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.484] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.500] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.515] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.531] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.547] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.562] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.578] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.593] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.609] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.625] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.640] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.656] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.671] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.687] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.703] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.718] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.734] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.749] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.765] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.781] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.796] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.812] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.828] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.843] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.859] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.874] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.890] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.906] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.921] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.937] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.952] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.968] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.984] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:39.999] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.015] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.030] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.046] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.062] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.077] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.093] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.108] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.124] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.140] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.155] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.171] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.186] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.202] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.218] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.233] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.249] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.264] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.280] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.296] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.311] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.327] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.342] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.358] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.374] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.389] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.405] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.420] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.436] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.452] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.467] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.483] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.498] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.514] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.530] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.545] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.561] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.576] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.592] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.608] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.623] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.639] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.654] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.670] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.686] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.701] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.717] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.732] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.748] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.764] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.779] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.795] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.810] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.826] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.842] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.857] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.873] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.888] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.904] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.920] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.935] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.951] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.966] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.982] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:40.998] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.013] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.029] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.044] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.060] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.076] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.091] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.107] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.122] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.138] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.154] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.169] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.185] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.200] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.216] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.232] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.247] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.263] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.278] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.294] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.310] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.325] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.341] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.356] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.372] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.388] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.403] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.419] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.435] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.450] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.466] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.481] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.497] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.513] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.528] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.544] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.559] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.575] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.591] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.606] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.622] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.637] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.653] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.669] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.684] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.700] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.715] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.731] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.747] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.762] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.778] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.793] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.809] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.825] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.840] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.856] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.871] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.887] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.903] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.918] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.934] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.949] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.965] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.981] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:41.996] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.012] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.027] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.043] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.059] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.074] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.090] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.105] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.121] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.137] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.152] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.168] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.183] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.199] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.215] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.230] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.246] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.261] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.277] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.293] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.308] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.324] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.339] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.355] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.371] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.386] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.402] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.417] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.433] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.449] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.464] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.465] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.466] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.513] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.529] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.544] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.560] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.575] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.591] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.607] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.622] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.638] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.653] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.669] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.685] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.700] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.716] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.731] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.747] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.763] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.778] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.794] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.809] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.825] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.841] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.856] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.872] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.887] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.903] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.919] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.934] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.950] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.965] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.981] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:42.997] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.012] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.028] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.043] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.059] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.075] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.090] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.106] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.122] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.137] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.153] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.168] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.184] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.200] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.215] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.231] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.246] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.262] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.278] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.293] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.309] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.324] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.340] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.356] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.371] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.387] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.402] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.418] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.434] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.449] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.465] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.480] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.496] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.512] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.527] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.543] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.558] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.574] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.590] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.605] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.621] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.636] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.652] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.668] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.683] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.699] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.714] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.730] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.746] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.761] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.777] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.792] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.808] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.824] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.839] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.855] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.870] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.886] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.902] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.917] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.933] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.948] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.964] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.980] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:43.995] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.011] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.026] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.042] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.058] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.073] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.089] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.104] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.120] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.136] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.151] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.167] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.182] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.198] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.214] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.229] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.245] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.260] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.276] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.292] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.307] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.323] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.338] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.354] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.370] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.385] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.401] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.416] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.432] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.448] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.463] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.479] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.494] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.510] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.526] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.541] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.557] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.572] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.588] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.604] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.605] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.620] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.651] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.667] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.683] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.698] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.714] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.730] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.745] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.761] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.776] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.792] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.808] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.823] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.839] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.854] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.870] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.886] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.901] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.917] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.932] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.948] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.964] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.979] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:44.995] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.010] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.026] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.042] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.057] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.073] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.088] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.104] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.120] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.135] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.151] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.166] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.182] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.198] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.213] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.229] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.244] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.260] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.276] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.291] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.307] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.322] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.338] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.354] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.369] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.385] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.400] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.416] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.432] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.447] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.463] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.478] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.494] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.510] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.525] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.541] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.556] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.572] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.588] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.603] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.619] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.634] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.650] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.666] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.681] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.697] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.712] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.728] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.744] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.759] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.775] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.790] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.806] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.822] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.837] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.853] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.868] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.884] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.900] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.915] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.931] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.946] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.962] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.978] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:45.993] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.009] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.024] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.025] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.041] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.072] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.088] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.103] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.119] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.135] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.150] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.166] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.181] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.197] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.213] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.228] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.244] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.259] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.275] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.291] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.306] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.322] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.338] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.353] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.369] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.384] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.400] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.416] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.431] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.447] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.462] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.478] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.494] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.509] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.525] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.540] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.556] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.572] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.587] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.603] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.618] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.634] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.650] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.665] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.681] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.696] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.712] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.728] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.759] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:36:46.774] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:36:46.790] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.806] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.821] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.837] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.852] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.868] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.884] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.899] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.915] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.930] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.946] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.962] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.977] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:46.993] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.008] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.024] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.040] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.055] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.071] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.086] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.102] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.118] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.133] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.149] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.164] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.180] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.196] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.211] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.227] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.242] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.258] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.274] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.289] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.305] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.320] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.336] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.352] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.367] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.383] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.398] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.414] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.430] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.445] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.461] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.476] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.492] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.508] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.523] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.539] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.554] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.570] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.586] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.601] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.617] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.632] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.648] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.664] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.679] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.695] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.710] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.726] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.742] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.757] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.773] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.788] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.804] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.820] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.835] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.851] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.866] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.882] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.898] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.913] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.929] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.944] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.960] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.976] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:47.991] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.007] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.023] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.038] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.054] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.069] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.085] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.086] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.087] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.134] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.149] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.165] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.181] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.196] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.212] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.227] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.243] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.259] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.274] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.290] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.305] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.321] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.337] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.352] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.368] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.383] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.399] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.415] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.430] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.446] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.461] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.477] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.493] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.508] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.524] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.539] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.555] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.571] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.586] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.602] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.617] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.633] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.649] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.664] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.680] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.695] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.711] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.727] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.742] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.758] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.773] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.789] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.805] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.820] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.836] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.851] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.867] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.883] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.898] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.914] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.929] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.945] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.961] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.976] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:48.992] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.007] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.023] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.039] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.054] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.070] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.085] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.101] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.117] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.132] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.148] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.163] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.179] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.195] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.210] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.226] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.241] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.257] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.273] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.288] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.304] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.319] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.335] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.351] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.366] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.382] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.397] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.413] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.429] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.444] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.460] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.475] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.491] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.507] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.522] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.538] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.553] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.569] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.585] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.600] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.616] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.632] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.647] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.663] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.678] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.694] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.710] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.725] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.726] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.727] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.774] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.790] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.805] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.821] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.836] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.852] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.868] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.883] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.899] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.914] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.930] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.946] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.961] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.977] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:49.992] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.008] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.024] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.039] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.055] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.070] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.086] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.117] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:36:50.133] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:36:50.148] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.164] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.180] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.195] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.211] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.226] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.242] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.258] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.273] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.289] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.304] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.320] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.336] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.351] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.367] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.382] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.398] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.414] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.429] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.445] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.460] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.476] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.492] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.507] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.523] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.538] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.554] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.570] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.585] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.601] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.616] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.632] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.648] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.663] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.679] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.694] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.710] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.726] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.741] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.757] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.772] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.788] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.804] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.819] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.835] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.850] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.866] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.882] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.897] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.913] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.928] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.944] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.960] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.975] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:50.991] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.006] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.022] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.038] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.053] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.069] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.084] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.100] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.116] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.131] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.147] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.162] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.178] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.194] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.209] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.225] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.240] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.256] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.272] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.287] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.303] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.319] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.334] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.350] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.365] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.381] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.397] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.412] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.428] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.443] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.459] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.475] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.476] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.477] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.523] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.539] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.555] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.570] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.586] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.601] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.617] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.633] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.648] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.664] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.679] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.695] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.711] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.726] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.742] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.757] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.773] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.789] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.804] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.820] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.835] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.851] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.867] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.882] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.898] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.913] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.929] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.945] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.960] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.976] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:51.991] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.007] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.023] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.038] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.054] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.069] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.085] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.101] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.116] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.132] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.147] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.163] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.179] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.194] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.210] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.225] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.241] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.257] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.272] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.288] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.303] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.319] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.335] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.350] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.366] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.381] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.397] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.413] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.428] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.444] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.459] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.475] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.491] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.506] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.522] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.537] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.553] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.569] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.584] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.600] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.615] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.631] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.647] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.662] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.678] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.693] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.709] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.725] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.740] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.756] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.771] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.787] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.803] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.818] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.834] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.849] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.865] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.881] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.896] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.912] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.928] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.943] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.959] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.974] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:52.990] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.006] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.021] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.037] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.052] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.068] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.084] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.099] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.115] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.130] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.146] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.162] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.177] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.193] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.208] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.224] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.240] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.255] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.271] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.286] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.302] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.318] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.333] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.349] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.364] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.380] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.396] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.411] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.427] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.442] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.458] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.474] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.489] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.505] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.520] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.536] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.552] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.567] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.583] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.598] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.614] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.630] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.645] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.661] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.676] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.692] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.708] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.723] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.739] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.754] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.770] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.786] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.801] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.817] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.832] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.848] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.864] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.879] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.895] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.910] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.926] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.942] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.957] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.973] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:53.988] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.004] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.020] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.035] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.051] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.066] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.082] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.098] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.113] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.129] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.144] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.160] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.176] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.191] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.207] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.222] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.238] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.254] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.269] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.285] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.300] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.316] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.332] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.347] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.363] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.378] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.394] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.410] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.425] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.441] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.472] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:36:54.488] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:36:54.503] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.519] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.534] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.550] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.566] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.581] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.597] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.613] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.628] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.644] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.659] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.660] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.676] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.707] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.723] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.738] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.754] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.770] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.785] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.801] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.816] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.832] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.848] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.863] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.879] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.894] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.910] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.926] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.941] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.957] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.972] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:54.988] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.004] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.019] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.035] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.050] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.066] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.082] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.097] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.113] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.128] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.144] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.160] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.175] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.191] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.206] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.222] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.238] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.253] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.269] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.284] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.300] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.316] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.331] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.347] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.362] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.378] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.394] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.409] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.425] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.440] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.456] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.472] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.487] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.503] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.518] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.534] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.550] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.565] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.581] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.596] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.612] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.628] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.643] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.659] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.674] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.690] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.706] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.721] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.737] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.752] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.768] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.784] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.799] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.815] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.830] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.846] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.862] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.877] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.893] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.908] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.924] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.940] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.955] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.971] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:55.986] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.002] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.018] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.033] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.049] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.064] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.080] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.096] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.111] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.127] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.142] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.158] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.174] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.189] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.205] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.221] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.236] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.252] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.267] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.283] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.299] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.314] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.330] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.345] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.361] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.377] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.392] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.408] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.423] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.439] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.455] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.470] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.486] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.501] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.517] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.533] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.548] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.564] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.579] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.595] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.611] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.626] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.642] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.657] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.673] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.689] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.704] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.720] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.735] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.751] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.767] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.782] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.798] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.813] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.829] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.845] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.860] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.876] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.891] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.907] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.923] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.938] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.954] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.969] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:56.985] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.001] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.016] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.032] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.047] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.063] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.079] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.094] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.110] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.125] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.141] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.157] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.172] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.188] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.203] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.219] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.235] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.250] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.266] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.281] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.297] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.313] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.328] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.344] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.359] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.375] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.391] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.406] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.422] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.437] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.453] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.469] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.484] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.500] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.515] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.531] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.547] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.562] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.578] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.593] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.609] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.625] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.640] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.656] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.671] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.687] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.703] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.718] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.734] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.749] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.765] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.781] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.796] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.812] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.828] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.843] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.859] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.874] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.890] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.906] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.921] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.937] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.952] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.968] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.984] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:57.999] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.015] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.030] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.046] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.062] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.077] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.093] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.108] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.124] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.140] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.155] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.171] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.186] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.202] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.218] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.233] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.249] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.264] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.280] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.296] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.311] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.327] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.342] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.358] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.374] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.389] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.405] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.420] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.436] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.452] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.467] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.483] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.498] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.514] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.530] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.545] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.561] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.576] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.592] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.608] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.623] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.639] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.654] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.670] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.686] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.701] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.717] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.732] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.748] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.764] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.779] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.795] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.810] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.826] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.842] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.857] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.873] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.888] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.904] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.920] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.935] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.951] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.966] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.982] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:58.998] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.013] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.029] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.044] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.060] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.076] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.091] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.107] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.122] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.138] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.154] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.169] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.185] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.200] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.216] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.232] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.247] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.263] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.278] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.294] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.310] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.325] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.341] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.356] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.372] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.388] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.403] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.419] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.434] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.450] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.466] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.481] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.497] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.513] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.528] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.544] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.559] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.575] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.591] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.606] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.622] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.637] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.653] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.669] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.684] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.700] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.715] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.731] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.747] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.762] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.778] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.809] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:36:59.825] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:36:59.840] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.856] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.871] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.887] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.903] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.918] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.934] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.949] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.965] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.981] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:36:59.996] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.012] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.027] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.043] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.059] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.074] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.090] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.105] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.121] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.137] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.152] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.168] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.183] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.199] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.215] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.230] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.246] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.261] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.277] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.293] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.308] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.324] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.339] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.355] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.371] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.386] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.402] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.417] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.433] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.449] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.464] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.480] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.495] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.511] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.527] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.542] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.558] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.573] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.589] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.605] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.620] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.636] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.651] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.667] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.683] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.698] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.714] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.729] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.745] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.761] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.776] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.792] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.807] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.823] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.839] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.854] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.870] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.885] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.901] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.917] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.932] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.948] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.963] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.979] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:00.995] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.010] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.026] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.041] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.057] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.073] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.088] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.104] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.120] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.135] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.151] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.166] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.182] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.198] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.213] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.229] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.244] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.260] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.276] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.291] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.307] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.322] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.338] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.354] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.369] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.385] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.400] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.416] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.432] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.447] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.463] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.478] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.494] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.510] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.525] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.541] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.556] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.572] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.588] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.603] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.619] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.634] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.650] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.666] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.681] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.697] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.712] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.728] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.744] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.759] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.775] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.790] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.806] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.822] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.837] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.853] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.868] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.884] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.900] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.915] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.931] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.946] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.962] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.978] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:01.993] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.009] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.024] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.040] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.056] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.071] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.087] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.102] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.118] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.134] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.149] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.165] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.180] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.196] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.212] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.227] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.243] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.258] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.274] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.290] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.305] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.321] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.336] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.352] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.368] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.383] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.399] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.414] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.430] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.446] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.461] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.477] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.492] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.508] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.524] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.539] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.555] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.570] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.586] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.602] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.617] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.633] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.648] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.664] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.680] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.695] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.711] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.726] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.742] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.758] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.773] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.789] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.805] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.820] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.851] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:37:02.867] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:37:02.883] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.898] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.914] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.929] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.945] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.961] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.976] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:02.992] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.007] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.023] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.039] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.054] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.070] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.085] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.101] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.117] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.132] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.148] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.163] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.179] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.195] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.210] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.226] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.241] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.257] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.273] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.288] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.304] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.319] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.335] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.351] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.366] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.382] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.397] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.413] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.429] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.444] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.460] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.475] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.491] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.507] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.522] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.538] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.553] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.569] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.585] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.600] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.616] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.631] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.647] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.663] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.678] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.694] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.709] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.725] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.741] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.756] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.772] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.787] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.803] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.819] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.834] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.850] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.865] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.881] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.897] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.912] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.928] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.943] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.959] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.975] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:03.990] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.006] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.021] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.037] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.053] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.068] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.084] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.099] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.115] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.131] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.146] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.162] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.177] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.193] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.209] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.224] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.240] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.255] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.271] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.287] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.302] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.318] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.333] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.349] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.365] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.380] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.396] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.412] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.427] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.443] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.458] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.474] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.490] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.505] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.521] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.536] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.552] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.568] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.583] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.599] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.614] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.630] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.631] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.647] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.678] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.693] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.709] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.725] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.740] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.756] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.771] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.787] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.803] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.818] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.834] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.849] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.865] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.881] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.896] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.912] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.927] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.943] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.959] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.974] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:04.990] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.005] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.021] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.037] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.052] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.068] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.083] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.099] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.115] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.130] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.146] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.161] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.177] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.193] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.208] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.224] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.239] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.255] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.271] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.286] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.302] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.317] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.333] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.349] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.364] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.380] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.395] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.411] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.427] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.442] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.458] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.473] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.489] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.505] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.520] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.536] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.551] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.567] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.583] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.598] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.614] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.629] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.645] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.661] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.676] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.692] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.707] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.723] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.739] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.754] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.770] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.785] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.786] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.787] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.834] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.850] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.865] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.881] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.897] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.912] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.928] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.943] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.959] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.975] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:05.990] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.006] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.021] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.037] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.053] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.068] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.084] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.100] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.115] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.131] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.146] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.162] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.178] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.193] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.209] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.224] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.240] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.256] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.271] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.287] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.302] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.318] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.334] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.349] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.365] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.380] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.396] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.412] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.427] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.443] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.458] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.474] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.490] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.505] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.521] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.536] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.552] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.568] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.583] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.599] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.614] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.630] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.646] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.661] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.677] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.692] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.708] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.724] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.739] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.755] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.770] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.786] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.802] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.817] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.833] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.848] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.864] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.880] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.895] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.911] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.926] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.942] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.958] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.973] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:06.989] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.004] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.020] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.036] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.051] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.067] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.082] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.098] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.114] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.129] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.145] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.160] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.176] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.192] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.207] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.223] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.238] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.254] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.270] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.285] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.301] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.316] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.332] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.348] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.363] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.379] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.394] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.410] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.426] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.441] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.457] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.472] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.488] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.504] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.519] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.535] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.550] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.566] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.582] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.597] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.613] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.628] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.644] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.645] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.646] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.695] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.711] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.726] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.742] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.757] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.773] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.789] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.804] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.820] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.835] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.851] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.867] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.882] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.898] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.913] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.929] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.945] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.960] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.976] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:07.991] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.007] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.023] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.038] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.054] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.069] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.085] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.101] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.116] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.132] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.147] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.163] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.179] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.194] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.210] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.241] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:37:08.257] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:37:08.272] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.288] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.303] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.319] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.335] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.350] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.366] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.381] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.397] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.413] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.428] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.444] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.459] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.475] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.491] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.506] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.537] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:37:08.553] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:37:08.569] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.584] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.600] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.615] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.631] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.647] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.662] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.678] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.693] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.709] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.725] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.740] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.756] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.771] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.787] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.803] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.818] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.834] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.849] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.865] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.881] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.896] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.912] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.927] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.943] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.959] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.974] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:08.990] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.005] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.021] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.037] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.052] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.068] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.083] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.099] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.115] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.130] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.146] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.161] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.177] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.193] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.208] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.224] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.239] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.255] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.271] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.286] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.318] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:37:09.333] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:37:09.349] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.364] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.380] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.396] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.411] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.427] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.442] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.458] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.474] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.489] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.505] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.520] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.536] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.552] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.567] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.583] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.598] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.614] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.630] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.645] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.661] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.676] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.692] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.708] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.723] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.739] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.754] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.770] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.786] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.801] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.817] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.832] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.848] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.864] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.879] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.895] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.910] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.926] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:09.957] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:37:09.973] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:37:09.988] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.004] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.020] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.035] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.051] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.066] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.082] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.098] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.113] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.129] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.144] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.160] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.176] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.191] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.207] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.222] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.238] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.254] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.269] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.285] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.300] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.316] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.332] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.347] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.363] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.378] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.394] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.410] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.425] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.441] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.456] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.472] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.488] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.503] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.519] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.534] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.550] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.566] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.581] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.597] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.612] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.628] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.644] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.659] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.675] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.690] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.706] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.722] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.737] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.753] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.768] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.784] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.800] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.815] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.831] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.846] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.862] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.878] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.893] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.924] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:37:10.940] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:37:10.956] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.971] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:10.987] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.003] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.018] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.034] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.049] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.065] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.081] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.096] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.112] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.127] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.143] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.159] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.174] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.190] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.205] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.221] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.237] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.252] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.268] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.283] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.299] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.315] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.330] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.346] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.361] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.377] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.393] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.408] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.424] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.439] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.455] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.471] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.486] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.502] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.517] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.533] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.549] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.564] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.580] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.595] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.611] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.627] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.642] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.658] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.673] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.689] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.705] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.720] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.736] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.751] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.767] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.783] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.798] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.814] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.829] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.845] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.861] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.876] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.892] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.907] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.923] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.939] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.954] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.970] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:11.985] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.001] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.017] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.032] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.048] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.063] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.079] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.095] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.110] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.126] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.141] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.157] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.173] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.188] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.204] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.219] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.235] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.251] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.266] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.282] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.297] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.313] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.329] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.344] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.360] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.375] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.391] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.407] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.422] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.438] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.453] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.469] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.485] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.500] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.516] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.531] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.547] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.563] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.578] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.594] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.610] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.625] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.641] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.656] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.672] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.688] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.703] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.719] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.734] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.750] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.766] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.781] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.797] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.812] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.828] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.844] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.859] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.875] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.890] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.906] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.922] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.937] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.953] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.968] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:12.984] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.000] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.015] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.031] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.046] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.062] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.078] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.093] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.109] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.124] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.140] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.156] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.171] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.187] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.202] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.218] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.234] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.249] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.265] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.280] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.296] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.297] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.298] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.345] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.360] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.376] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.392] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.407] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.423] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.438] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.454] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.470] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.485] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.501] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.516] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.532] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.548] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.563] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.579] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.594] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.610] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.626] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.641] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.657] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.672] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.688] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.689] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.705] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.736] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.751] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.767] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.783] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.798] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.814] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.829] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.845] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.861] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.876] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.892] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.907] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.923] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.939] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.954] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.970] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:13.985] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.001] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.017] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.048] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:37:14.063] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:37:14.079] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.095] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.110] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.126] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.141] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.157] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.173] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.188] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.204] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.219] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.235] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.251] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.266] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.282] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.298] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.313] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.329] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.344] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.360] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.376] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.391] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.407] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.422] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.438] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.454] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.469] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.485] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.500] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.516] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.532] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.547] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.563] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.578] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.594] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.610] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.611] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.612] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.674] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:37:14.690] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:37:14.705] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.721] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.736] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.752] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.768] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.783] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.799] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.814] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.830] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.846] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.861] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.892] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:37:14.908] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:37:14.924] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.939] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.955] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.970] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:14.986] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.002] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.017] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.033] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.048] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.064] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.080] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.095] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.111] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.126] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.142] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.158] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.173] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.189] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.204] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.220] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.236] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.251] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.267] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.282] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.298] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.314] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.329] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.345] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.360] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.376] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.407] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:37:15.423] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:37:15.438] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.454] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.470] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.485] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.501] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.516] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.532] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.548] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.563] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.579] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.594] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.610] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.626] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.641] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.657] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.672] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.688] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.704] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.719] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.735] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.750] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.766] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.782] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.797] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.813] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.828] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.844] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.860] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.875] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.891] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.907] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.922] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.938] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.953] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.969] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:15.985] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.000] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.016] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.031] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.047] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.063] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.078] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.094] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.109] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.125] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.141] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.156] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.172] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.187] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.203] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.219] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.234] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.250] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.265] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.281] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.297] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.312] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.328] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.343] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.359] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.375] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.390] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.406] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.421] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.437] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.453] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.468] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.484] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.499] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.515] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.531] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.546] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.562] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.577] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.593] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.609] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.624] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.640] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.655] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.671] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.702] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.718] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.733] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.749] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.765] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.780] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.796] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.811] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.827] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.843] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.858] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.874] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.889] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.905] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.921] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.936] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.952] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.967] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.983] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:16.999] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.014] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.030] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.045] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.061] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.077] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.092] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.108] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.123] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.139] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.155] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.170] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.186] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.201] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.217] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.233] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.248] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.264] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.279] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.295] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.311] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.326] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.342] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.357] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.373] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.389] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.404] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.420] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.435] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.451] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.467] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.482] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.498] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.513] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.529] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.545] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.560] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.576] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.592] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.607] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.623] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.638] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.654] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.670] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.685] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.701] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.716] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.732] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.748] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.763] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.779] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.794] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.810] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.826] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.841] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.857] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.872] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.888] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.904] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.919] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.920] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.936] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.967] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.983] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:17.998] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.014] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.029] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.045] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.061] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.076] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.092] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.107] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.123] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.139] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.154] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.170] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.185] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.201] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.217] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.232] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.248] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.263] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.279] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.295] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.310] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.326] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.341] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.357] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.373] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.388] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.404] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.419] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.435] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.451] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.466] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.482] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.497] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.513] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.529] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.544] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.560] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.575] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.591] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.607] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.622] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.638] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.653] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.669] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.685] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.700] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.716] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.731] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.747] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.763] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.778] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.794] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.809] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.825] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.841] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.856] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.872] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.887] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.903] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.919] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.920] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.921] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.967] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.983] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:18.999] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.014] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.030] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.045] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.061] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.077] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.092] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.108] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.123] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.139] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.155] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.170] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.186] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.202] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.217] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.233] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.248] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.264] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.280] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.295] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.311] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.326] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.342] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.358] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.373] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.389] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.404] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.420] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.436] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.451] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.467] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.482] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.498] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.499] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.500] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.510] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.557] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.572] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.588] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.604] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.619] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.635] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.650] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.666] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.682] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.697] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.713] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.728] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.744] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.760] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.775] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.791] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.806] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.822] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.838] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.853] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.869] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.884] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.900] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.916] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.931] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.947] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.962] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.978] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:19.994] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.009] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.025] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.040] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.056] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.072] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.087] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.103] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.118] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.134] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.150] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.165] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.181] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.196] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.212] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.228] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.243] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.259] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.274] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.290] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.306] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.321] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.337] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.352] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.368] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.384] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.399] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.415] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.430] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.446] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.462] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.477] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.493] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.508] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.524] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.540] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.555] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.556] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.557] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.604] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.620] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.635] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.651] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.666] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.682] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.698] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.713] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.729] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.744] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.760] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.776] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.791] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.807] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.823] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.838] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.854] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.869] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.885] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.901] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.916] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.932] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.947] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.963] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.979] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:20.994] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.010] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.025] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.041] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.057] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.072] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.088] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.103] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.119] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.135] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.150] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.166] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.181] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.197] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.213] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.228] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.244] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.259] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.275] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.291] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.306] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.322] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.337] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.353] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.369] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.384] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.400] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.415] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.431] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.447] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.462] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.478] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.493] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.509] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.525] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.540] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.556] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.571] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.587] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.603] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.618] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.634] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.649] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.665] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.681] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.696] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.712] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.727] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.743] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.759] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.774] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.790] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.805] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.821] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.837] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.852] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.868] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.883] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.899] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.915] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.930] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.946] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.961] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.977] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:21.993] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.008] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.024] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.039] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.055] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.071] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.086] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.102] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.117] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.133] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.149] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.164] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.180] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.195] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.211] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.227] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.242] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.258] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.273] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.289] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.305] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.306] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.307] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.353] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.369] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.385] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.400] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.416] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.431] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.447] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.463] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.478] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.494] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.510] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.525] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.541] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.556] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.572] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.588] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.603] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.619] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.634] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.650] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.666] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.681] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.697] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.712] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.728] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.744] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.759] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.775] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.790] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.806] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.822] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.837] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.853] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.868] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.884] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.900] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.915] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.931] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.946] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.962] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.978] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:22.993] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.009] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.024] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.040] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.056] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.071] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.087] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.102] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.118] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.134] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.149] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.165] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.180] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.196] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.212] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.227] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.243] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.258] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.274] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.305] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:37:23.321] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:37:23.336] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.352] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.368] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.383] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.399] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.414] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.430] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.446] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.461] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.477] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.492] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.508] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.524] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.539] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.555] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.570] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.586] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.602] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.617] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.633] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.648] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.664] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.680] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.695] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.711] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.726] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.742] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.758] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.773] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.789] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.804] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.820] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.836] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.851] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.867] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.882] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.898] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.914] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.929] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.945] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.960] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.976] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:23.992] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.007] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.023] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.038] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.054] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.070] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.085] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.101] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.117] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.132] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.148] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.163] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.179] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.195] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.210] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.226] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.241] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.257] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.273] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.288] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.304] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.319] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.335] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.351] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.366] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.397] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:37:24.413] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:37:24.429] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.444] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.460] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.475] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.491] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.507] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.522] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.538] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.553] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.569] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.585] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.600] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.616] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.617] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.632] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.664] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.679] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.695] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.710] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.726] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.742] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.757] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.773] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.788] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.804] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.820] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.835] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.851] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.866] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.882] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.898] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.913] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.929] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.944] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.960] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.976] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:24.991] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.007] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.022] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.038] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.054] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.069] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.085] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.100] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.116] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.132] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.147] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.163] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.178] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.194] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.210] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.225] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.241] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.256] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.272] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.288] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.303] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.319] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.334] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.350] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.366] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.381] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.397] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.412] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.428] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.444] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.459] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.475] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.490] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.506] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.522] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.537] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.553] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.568] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.584] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.600] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.615] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.631] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.646] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.662] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.678] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.693] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.709] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.725] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.740] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.756] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.771] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.787] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.803] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.818] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.834] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.849] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.865] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.881] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.896] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.912] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.927] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.943] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.959] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.974] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:25.990] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.005] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.021] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.037] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.052] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.068] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.083] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.099] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.115] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.130] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.146] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.161] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.177] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.193] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.208] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.224] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.239] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.255] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.271] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.286] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.302] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.317] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.333] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.349] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.364] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.380] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.395] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.411] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.427] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.442] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.458] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.473] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.489] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.505] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.520] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.536] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.551] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.567] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.583] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.598] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.614] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.629] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.645] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.661] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.676] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.692] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.707] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.723] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.739] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.754] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.770] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.785] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.801] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.817] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.832] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.848] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.863] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.879] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.895] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.910] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.926] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.941] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.957] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.973] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:26.988] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.004] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.019] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.035] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.051] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.066] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.082] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.097] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.113] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.129] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.144] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.160] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.175] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.191] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.207] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.222] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.238] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.253] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.269] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.285] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.300] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.316] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.331] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.347] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.363] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.378] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.394] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.410] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.425] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.441] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.456] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.472] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.488] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.503] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.519] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.534] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.550] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.566] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.581] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.597] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.612] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.628] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.644] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.659] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.675] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.690] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.706] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.722] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.737] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.753] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.768] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.784] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.800] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.815] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.831] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.846] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.862] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.878] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.893] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.909] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.924] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.940] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.956] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.971] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:27.987] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.002] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.018] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.034] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.049] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.065] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.080] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.096] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.112] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.127] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.143] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.158] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.174] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.190] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.205] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.221] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.236] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.252] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.268] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.283] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.299] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.314] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.330] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.346] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.361] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.377] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.392] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.408] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.424] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.439] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.455] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.470] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.486] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.502] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.517] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.533] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.564] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.580] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.595] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.611] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.626] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.642] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.658] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.673] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.689] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.704] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.720] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.736] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.751] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.767] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.782] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.798] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.814] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.829] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.845] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.860] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.876] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.892] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.907] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.923] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.938] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.954] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.970] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:28.985] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.001] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.017] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.032] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.048] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.063] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.079] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.095] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.110] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.126] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.141] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.157] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.173] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.188] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.204] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.219] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.235] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.251] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.266] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.282] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.297] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.313] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.329] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.344] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.360] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.375] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.391] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.407] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.422] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.438] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.453] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.469] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.485] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.500] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.516] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.531] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.547] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.563] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.578] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.594] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.609] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.625] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.641] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.656] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.672] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.687] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.703] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.719] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.734] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.750] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.765] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.781] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.782] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.798] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.829] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.844] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.860] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.876] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.891] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.907] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.922] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.938] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.954] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.969] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:29.985] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.000] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.016] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.032] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.047] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.063] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.078] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.094] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.110] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.125] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.141] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.156] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.172] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.188] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.203] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.219] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.234] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.250] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.266] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.281] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.297] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.312] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.328] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.344] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.359] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.375] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.390] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.406] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.422] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.437] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.453] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.468] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.484] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.500] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.515] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.531] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.546] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.562] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.578] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.593] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.609] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.624] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.640] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.656] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.671] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.687] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.703] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.718] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.734] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.749] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.765] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.781] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.796] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.812] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.827] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.843] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.859] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.874] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.890] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.905] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.921] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.937] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.952] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.968] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.983] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:30.999] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.015] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.030] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.046] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.061] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.077] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.093] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.108] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.124] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.139] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.155] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.171] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.186] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.202] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.217] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.233] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.249] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.264] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.280] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.295] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.311] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.327] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.342] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.358] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.373] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.389] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.405] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.420] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.436] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.451] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.467] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.483] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.498] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.514] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.529] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.545] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.561] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.576] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.592] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.607] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.623] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.639] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.654] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.670] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.685] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.701] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.717] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.732] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.748] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.763] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.779] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.795] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.810] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.826] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.841] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.857] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.873] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.888] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.904] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.919] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.935] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.951] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.966] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.982] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:31.997] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.013] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.029] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.044] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.060] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.075] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.091] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.107] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.122] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.138] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.153] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.169] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.185] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.200] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.216] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.231] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.247] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.263] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.278] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.294] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.310] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.325] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.341] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.356] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.372] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.388] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.403] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.419] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.434] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.450] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.466] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.481] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.497] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.512] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.528] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.544] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.559] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.575] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.590] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.606] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.622] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.637] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.653] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.668] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.684] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.700] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.715] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.731] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.746] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.762] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.778] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.793] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.809] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.824] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.840] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.856] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.871] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.887] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.902] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.918] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.934] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.949] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.965] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.980] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:32.996] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.012] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.027] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.043] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.058] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.074] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.090] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.105] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.121] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.136] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.152] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.168] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.183] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.199] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.214] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.230] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.246] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.261] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.277] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.292] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.308] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.324] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.339] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.355] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.370] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.386] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.402] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.417] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.433] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.448] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.464] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.480] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.495] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.511] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.526] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.542] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.558] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.573] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.589] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.604] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.620] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.636] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.651] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.667] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.682] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.698] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.714] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.729] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.745] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.760] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.776] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.792] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.807] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.823] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.838] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.854] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.870] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.885] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.901] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.916] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.932] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.948] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.963] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.979] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:33.995] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.010] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.026] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.041] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.057] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.073] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.088] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.104] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.119] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.135] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.151] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.166] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.182] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.197] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.213] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.229] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.244] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.260] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.275] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.291] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.307] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.322] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.338] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.353] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.369] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.385] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.400] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.416] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.431] : A90432BC : Write Outputs : Done[m
[31m-[2016-04-20 17:37:34.478] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.494] : A90432BC : Write Outputs : Done[m
[31m-[2016-04-20 17:37:34.494] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.509] : A90432BC : Write Outputs : Done[m
[31m-[2016-04-20 17:37:34.509] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.541] : A90432BC : Write Outputs : Done[m
[31m-[2016-04-20 17:37:34.541] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.556] : A90432BC : Write Outputs : Done[m
[31m-[2016-04-20 17:37:34.556] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.572] : A90432BC : Write Outputs : Done[m
[31m-[2016-04-20 17:37:34.572] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.587] : A90432BC : Write Outputs : Done[m
[31m-[2016-04-20 17:37:34.587] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.603] : A90432BC : Write Outputs : Done[m
[31m-[2016-04-20 17:37:34.603] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.604] : A90432BC : Write Outputs : Done[m
[31m-[2016-04-20 17:37:34.604] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.635] : A90432BC : Write Outputs : Done[m
[31m-[2016-04-20 17:37:34.635] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.651] : A90432BC : Write Outputs : Done[m
[31m-[2016-04-20 17:37:34.651] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.666] : A90432BC : Write Outputs : Done[m
[31m-[2016-04-20 17:37:34.666] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.682] : A90432BC : Write Outputs : Done[m
[31m-[2016-04-20 17:37:34.682] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.698] : A90432BC : Write Outputs : Done[m
[31m-[2016-04-20 17:37:34.698] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.713] : A90432BC : Write Outputs : Done[m
[31m-[2016-04-20 17:37:34.713] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.729] : A90432BC : Write Outputs : Done[m
[31m-[2016-04-20 17:37:34.729] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:37:34.744] : A90432BC : Write Outputs : Done[m
[31m-[2016-04-20 17:38:07.434] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:38:07.449] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:38:07.465] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:07.481] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:07.496] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:07.512] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:07.527] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:07.543] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:07.559] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:07.574] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:07.590] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:07.605] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:07.621] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:07.637] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:07.652] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:07.668] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:07.683] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:07.699] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:07.715] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:07.730] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:07.746] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:07.761] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:07.777] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:07.793] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:07.808] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:07.824] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:07.839] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:07.855] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:07.871] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:07.886] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:07.902] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:07.917] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:07.933] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:07.949] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:07.964] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:07.980] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:07.995] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.011] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.027] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.042] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.058] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.073] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.089] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.105] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.120] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.136] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.151] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.167] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.183] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.198] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.214] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.229] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.245] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.261] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.276] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.292] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.307] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.323] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.339] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.354] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.370] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.385] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.401] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.417] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.432] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.448] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.464] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.479] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.495] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.510] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.526] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.542] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.557] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.573] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.588] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.604] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.620] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.635] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.651] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.666] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.682] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.698] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.713] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.729] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.744] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.760] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.776] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.791] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.807] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.822] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.838] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.854] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.869] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.885] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.900] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.916] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.932] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.947] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.963] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.978] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:08.994] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.010] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.025] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.041] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.056] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.072] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.088] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.103] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.119] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.134] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.150] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.166] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.181] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.197] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.212] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.228] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.244] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.259] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.275] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.290] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.306] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.322] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.337] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.353] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.368] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.384] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.400] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.401] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.402] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.449] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.465] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.481] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.496] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.512] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.527] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.543] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.559] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.574] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.590] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.605] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.621] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.637] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.652] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.668] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.683] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.699] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.715] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.730] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.746] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.761] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.777] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.793] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.808] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.824] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.839] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.855] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.871] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.886] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.902] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.917] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.933] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.949] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.964] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.980] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:09.995] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.011] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.027] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.042] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.058] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.074] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.089] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.105] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.120] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.136] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.152] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.167] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.183] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.198] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.214] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.230] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.245] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.261] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.276] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.292] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.308] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.323] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.339] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.354] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.370] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.386] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.401] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.417] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.432] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.448] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.464] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.479] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.495] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.510] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.526] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.542] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.557] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.573] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.588] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.604] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.620] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.635] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.651] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.666] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.682] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.698] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.713] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.729] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.744] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.760] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.776] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.791] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.807] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.822] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.838] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.854] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.869] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.885] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.900] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.916] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.932] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.947] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.963] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.978] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:10.994] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.010] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.025] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.041] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.056] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.072] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.088] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.103] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.119] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.134] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.150] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.166] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.181] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.197] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.212] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.228] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.244] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.259] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.275] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.290] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.306] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.322] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.337] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.353] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.368] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.384] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.400] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.415] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.431] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.446] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.462] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.478] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.493] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.509] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.524] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.540] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.556] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.571] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.587] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.618] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:38:11.634] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:38:11.649] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.665] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.680] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.696] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.712] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.727] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.743] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.759] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.774] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.790] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.805] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.821] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.837] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.852] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.868] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.883] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.899] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.915] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.930] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.946] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.961] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.977] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:11.993] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.008] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.024] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.039] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.055] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.071] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.086] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.102] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.117] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.133] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.149] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.164] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.180] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.195] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.211] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.227] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.242] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.258] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.273] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.289] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.305] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.320] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.336] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.351] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.367] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.383] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.398] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.414] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.429] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.445] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.461] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.476] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.492] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.507] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.523] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.539] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.554] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.570] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.585] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.601] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.617] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.632] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.648] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.663] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.679] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.695] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.710] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.726] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.741] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.757] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.773] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.788] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.804] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.819] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.835] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.851] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.866] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.882] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.897] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.913] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.929] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.944] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.960] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.975] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:12.991] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.007] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.022] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.038] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.053] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.069] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.085] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.100] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.116] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.131] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.147] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.163] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.178] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.194] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.209] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.225] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.241] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.256] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.272] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.287] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.303] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.319] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.334] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.350] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.366] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.381] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.397] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.412] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.428] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.444] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.459] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.475] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.490] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.506] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.522] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.537] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.553] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.568] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.584] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.600] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.615] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.616] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.617] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.664] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.680] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.695] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.711] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.726] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.742] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.758] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.773] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.789] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.804] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.820] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.836] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.851] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.867] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.882] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.898] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.914] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.929] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.945] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.960] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.976] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:13.992] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.007] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.023] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.038] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.054] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.070] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.085] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.101] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.116] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.132] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.148] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.163] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.179] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.194] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.210] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.226] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.241] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.257] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.272] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.288] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.304] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.319] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.335] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.350] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.366] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.382] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.397] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.413] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.428] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.444] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.460] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.475] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.491] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.506] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.522] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.538] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.553] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.569] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.584] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.600] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.616] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.631] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.647] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.662] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.678] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.694] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.709] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.725] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.740] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.756] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.772] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.787] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.803] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.818] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.834] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.850] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.865] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.881] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.896] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.912] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.928] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.943] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.959] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.975] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:14.990] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.006] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.021] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.037] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.053] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.054] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.055] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.101] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.133] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:38:15.148] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:38:15.164] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.179] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.195] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.211] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.226] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.242] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.257] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.273] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.289] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.304] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.320] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.335] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.351] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.367] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.382] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.398] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.413] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.429] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.445] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.460] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.476] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.491] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.507] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.523] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.538] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.554] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.569] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.585] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.601] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.616] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.632] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.647] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.663] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.679] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.694] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.710] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.725] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.741] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.757] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.772] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.788] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.819] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:38:15.835] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:38:15.850] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.866] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.881] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.897] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.913] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.928] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.944] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.959] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.975] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:15.991] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.006] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.022] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.037] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.053] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.069] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.084] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.100] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.115] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.131] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.147] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.162] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.178] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.193] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.209] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.225] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.240] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.256] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.271] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.287] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.318] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:38:16.334] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:38:16.349] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.365] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.381] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.396] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.412] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.427] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.443] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.459] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.474] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.490] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.505] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.521] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.537] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.552] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.568] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.583] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.599] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.615] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.630] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.646] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.662] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.677] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.693] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.708] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.724] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.740] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.755] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.771] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.786] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.802] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.818] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.833] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.849] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.864] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.880] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.896] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.911] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.927] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.942] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.958] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.974] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:16.989] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.005] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.020] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.036] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.052] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.067] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.083] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.098] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.114] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.130] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.145] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.161] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.176] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.192] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.208] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.223] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.239] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.254] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.270] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.286] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.301] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.317] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.332] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.348] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.364] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.379] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.395] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.410] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.426] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.442] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.457] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.473] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.488] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.504] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.520] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.535] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.551] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.566] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.582] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.598] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.613] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.629] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.644] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.660] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.676] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.691] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.707] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.722] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.738] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.754] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.769] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.785] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.800] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.816] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.832] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.847] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.863] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.878] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.894] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.910] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.925] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.941] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.956] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.972] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:17.988] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.003] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.019] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.034] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.050] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.066] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.081] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.097] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.112] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.128] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.144] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.159] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.175] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.190] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.206] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.222] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.237] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.253] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.269] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.284] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.300] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.315] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.331] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.347] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.362] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.378] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.393] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.409] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.425] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.440] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.456] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.471] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.487] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.503] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.518] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.534] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.549] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.565] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.581] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.596] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.612] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.627] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.643] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.659] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.674] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.690] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.705] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.721] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.737] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.752] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.768] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.783] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.799] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.815] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.830] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.846] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.861] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.877] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.893] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.908] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.924] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.939] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.955] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.971] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:18.986] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.002] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.017] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.033] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.049] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.064] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.080] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.095] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.111] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.127] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.142] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.173] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:38:19.189] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:38:19.205] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.220] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.236] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.251] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.267] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.283] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.298] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.314] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.329] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.345] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.361] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.376] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.392] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.407] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.423] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.439] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.454] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.470] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.485] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.501] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.517] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.532] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.548] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.563] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.579] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.595] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.610] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.626] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.641] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.657] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.673] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.688] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.704] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.719] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.735] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.751] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.766] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.782] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.797] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.813] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.829] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.844] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.860] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.875] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.891] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.907] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.922] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.938] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.954] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.969] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:19.985] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.000] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.016] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.032] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.047] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.063] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.078] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.094] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.110] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.125] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.141] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.156] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.172] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.188] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.203] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.219] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.234] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.250] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.266] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.281] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.297] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.312] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.328] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.344] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.359] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.375] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.390] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.406] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.422] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.437] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.453] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.468] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.484] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.500] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.515] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.531] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.546] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.562] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.578] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.593] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.609] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.624] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.640] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.656] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.671] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.672] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.673] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.720] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.736] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.751] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.767] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.782] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.798] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.814] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.829] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.845] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.860] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.876] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.892] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.907] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.923] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.938] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.954] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.970] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:20.985] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.001] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.016] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.032] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.048] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.063] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.079] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.094] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.110] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.126] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.141] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.157] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.172] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.188] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.204] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.219] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.235] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.250] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.266] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.282] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.297] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.313] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.328] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.344] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.360] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.375] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.391] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.406] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.422] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.438] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.453] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.469] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.484] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.500] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.516] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.531] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.547] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.563] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.578] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.594] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.609] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.625] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.641] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.656] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.672] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.687] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.703] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.719] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.734] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.750] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.765] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.781] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.797] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.812] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.828] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.843] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.859] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.875] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.890] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.906] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.921] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.937] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.953] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.968] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.984] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:21.999] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.015] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.031] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.046] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.062] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.077] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.093] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.109] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.124] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.140] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.155] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.171] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.187] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.202] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.218] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.233] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.249] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.265] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.280] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.296] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.311] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.312] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.314] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.363] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.379] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.394] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.410] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.426] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.441] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.457] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.472] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.488] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.504] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.519] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.535] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.550] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.566] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.582] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.597] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.613] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.628] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.644] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.660] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.675] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.691] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.706] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.722] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.738] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.753] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.769] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.784] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.800] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.816] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.831] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.847] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.862] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.878] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.894] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.909] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.925] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.940] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.956] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.972] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:22.987] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.003] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.018] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.034] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.050] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.065] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.081] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.096] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.112] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.128] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.143] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.159] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.174] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.190] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.206] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.221] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.237] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.253] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.268] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.284] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.299] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.315] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.331] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.346] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.362] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.377] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.393] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.409] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.424] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.440] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.455] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.471] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.487] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.502] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.518] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.533] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.549] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.565] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.580] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.596] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.611] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.612] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.628] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.659] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.675] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.690] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.706] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.722] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.737] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.753] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.768] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.784] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.800] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.815] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.831] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.846] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.862] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.878] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.893] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.909] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.924] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.940] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.956] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.971] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:23.987] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.002] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.018] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.034] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.049] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.065] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.066] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.081] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.113] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.128] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.144] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.159] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.175] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.191] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.206] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.222] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.237] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.253] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.269] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.284] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.300] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.315] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.331] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.347] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.362] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.378] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.393] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.409] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.425] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.440] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.456] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.471] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.487] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.503] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.518] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.534] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.549] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.565] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.581] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.596] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.612] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.627] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.643] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.659] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.674] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.690] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.705] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.721] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.737] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.752] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.768] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.783] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.799] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.815] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.830] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.846] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.862] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.877] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.893] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.908] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.924] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.940] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.955] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.971] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:24.986] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.002] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.018] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.033] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.049] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.064] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.080] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.096] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.111] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.127] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.142] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.158] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.174] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.189] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.205] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.220] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.236] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.252] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.267] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.283] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.298] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.314] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.330] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.345] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.361] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.376] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.392] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.408] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.423] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.439] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.454] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.470] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.486] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.501] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.517] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.532] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.548] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.564] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.579] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.595] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.610] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.626] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.642] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.657] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.673] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.688] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.704] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.720] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.735] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.751] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.766] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.782] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.798] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.813] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.829] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.844] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.860] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.876] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.891] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.907] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.922] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.938] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.954] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.969] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:25.985] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.000] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.016] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.032] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.047] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.063] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.078] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.094] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.110] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.125] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.141] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.156] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.172] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.188] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.203] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.219] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.234] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.250] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.266] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.281] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.297] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.312] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.328] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.344] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.359] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.375] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.390] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.406] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.422] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.437] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.453] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.469] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.484] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.500] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.515] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.531] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.547] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.562] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.578] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.593] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.609] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.625] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.640] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.656] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.671] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.687] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.703] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.718] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.734] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.749] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.765] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.781] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.796] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.812] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.827] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.843] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.859] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.874] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.890] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.905] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.921] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.937] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.952] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.968] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.983] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:26.999] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.015] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.030] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.046] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.061] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.077] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.093] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.108] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.124] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.139] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.155] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.171] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.186] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.202] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.217] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.233] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.249] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.264] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.280] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.295] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.311] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.327] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.342] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.358] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.373] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.389] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.405] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.420] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.436] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.451] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.467] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.483] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.498] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.514] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.529] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.545] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.561] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.576] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.592] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.607] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.623] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.639] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.654] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.670] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.685] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.701] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.717] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.732] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.748] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.763] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.779] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.795] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.810] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.826] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.841] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.857] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.873] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.888] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.904] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.919] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.935] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.951] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.966] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.982] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:27.997] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.013] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.029] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.044] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.060] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.075] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.091] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.107] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.122] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.138] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.154] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.169] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.185] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.200] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.216] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.232] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.247] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.263] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.278] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.294] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.310] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.325] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.341] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.356] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.372] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.388] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.403] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.419] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.434] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.450] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.466] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.481] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.497] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.512] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.528] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.544] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.559] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.575] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.590] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.606] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.622] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.637] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.653] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.668] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.684] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.700] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.715] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.731] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.746] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.762] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.778] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.793] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.824] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:38:28.840] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:38:28.856] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.871] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.887] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.902] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.918] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.934] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.949] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.965] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.980] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:28.996] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.012] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.027] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.043] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.058] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.074] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.090] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.105] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.121] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.136] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.152] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.168] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.183] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.199] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.214] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.230] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.246] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.261] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.277] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.292] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.308] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.324] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.339] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.355] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.370] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.386] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.402] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.417] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.433] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.448] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.464] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.480] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.495] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.511] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.526] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.542] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.558] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.573] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.589] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.604] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.620] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.636] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.651] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.667] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.682] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.698] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.714] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.729] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.745] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.761] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.776] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.792] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.807] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.823] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.839] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.854] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.870] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.885] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.901] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.917] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.932] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.948] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.963] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.979] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:29.995] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.010] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.026] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.041] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.057] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.073] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.088] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.104] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.119] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.135] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.151] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.166] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.182] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.197] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.213] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.229] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.244] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.260] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.275] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.291] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.307] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.322] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.338] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.353] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.369] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.385] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.400] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.416] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.431] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.447] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.463] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.478] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.494] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.509] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.525] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.541] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.556] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.572] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.587] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.603] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.619] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.634] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.650] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.665] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.681] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.697] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.712] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.728] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.743] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.759] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.775] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.790] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.806] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.821] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.837] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.853] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.868] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.884] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.899] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.915] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.931] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.946] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.962] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.977] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:30.993] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.009] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.024] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.040] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.055] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.071] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.087] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.102] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.118] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.133] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.149] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.165] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.180] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.196] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.211] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.227] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.243] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.258] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.274] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.289] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.305] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.321] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.336] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.352] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.367] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.383] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.399] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.414] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.446] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:38:31.461] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:38:31.477] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.492] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.508] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.524] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.539] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.555] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.570] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.586] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.602] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.617] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.633] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.648] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.664] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.680] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.695] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.711] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.726] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.742] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.758] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.773] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.789] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.804] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.820] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.836] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.851] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.867] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.882] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.898] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.914] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.929] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.945] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.960] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.976] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:31.992] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.007] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.023] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.038] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.054] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.070] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.085] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.101] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.116] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.132] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.148] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.163] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.179] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.194] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.210] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.226] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.241] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.257] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.272] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.288] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.304] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.319] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.335] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.350] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.366] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.382] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.397] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.413] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.428] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.444] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.460] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.475] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.491] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.506] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.522] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.538] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.553] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.569] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.584] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.600] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.601] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.617] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.648] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.663] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.679] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.695] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.710] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.726] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.741] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.757] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.773] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.788] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.804] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.819] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.835] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.851] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.866] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.882] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.897] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.913] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.929] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.944] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.960] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.975] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:32.991] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.007] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.022] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.038] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.054] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.069] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.085] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.100] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.116] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.132] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.147] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.163] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.178] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.210] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:38:33.225] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:38:33.241] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.256] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.272] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.288] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.303] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.319] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.334] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.350] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.366] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.381] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.397] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.412] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.428] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.444] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.459] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.475] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.490] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.506] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.522] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.537] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.538] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.539] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.586] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.602] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.617] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.633] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.648] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.664] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.680] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.695] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.711] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.726] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.742] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.758] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.773] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.789] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.804] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.820] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.836] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.851] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.867] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.882] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.898] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.914] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.929] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.945] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.960] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.976] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:33.992] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.007] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.023] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.038] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.054] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.070] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.085] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.101] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.116] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.132] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.148] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.163] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.179] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.194] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.210] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.226] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.241] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.257] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.272] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.288] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.304] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.319] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.335] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.350] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.366] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.382] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.397] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.413] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.428] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.444] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.460] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.475] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.491] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.506] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.522] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.538] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.553] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.569] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.584] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.600] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.616] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.631] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.647] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.662] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.678] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.694] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.709] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.725] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.741] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.756] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.772] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.787] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.803] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.819] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.834] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.850] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.865] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.881] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.897] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.912] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.928] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.943] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.959] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:34.975] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.006] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:38:35.021] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:38:35.037] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.053] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.068] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.084] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.099] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.115] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.131] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.146] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.162] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.177] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.193] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.209] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.224] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.240] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.255] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.271] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.287] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.302] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.318] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.333] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.349] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.365] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.380] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.396] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.411] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.427] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.443] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.458] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.474] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.489] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.505] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.521] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.522] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.523] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.569] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.585] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.601] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.616] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.632] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.647] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.663] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.679] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.694] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.710] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.725] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.741] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.757] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.772] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.788] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.803] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.819] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.835] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.850] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.866] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.881] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.897] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.913] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.928] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.944] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.959] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.975] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:35.991] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.006] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.022] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.037] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.053] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.069] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.084] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.100] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.115] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.131] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.147] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.162] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.178] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.193] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.209] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.225] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.240] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.256] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.271] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.287] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.303] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.318] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.334] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.350] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.365] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.381] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.396] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.412] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.428] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.443] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.459] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.474] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.490] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.506] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.521] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.537] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.552] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.568] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.584] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.599] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.615] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.630] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.646] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.662] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.677] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.693] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.708] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.724] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.740] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.755] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.771] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.786] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.802] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.818] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.833] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.849] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.864] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.880] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.896] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.911] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.927] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.942] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.958] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.974] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:36.989] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.005] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.020] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.036] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.052] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.067] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.083] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.098] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.114] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.130] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.145] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.161] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.176] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.192] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.208] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.223] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.239] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.254] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.270] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.286] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.301] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.317] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.332] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.348] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.364] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.379] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.395] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.410] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.426] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.442] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.457] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.473] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.488] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.504] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.520] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.535] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.551] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.566] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.582] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.598] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.613] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.629] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.644] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.660] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.676] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.691] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.707] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.722] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.738] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.754] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.769] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.785] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.800] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.816] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.832] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.847] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.863] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.878] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.894] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.910] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.925] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.941] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.957] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.972] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:37.988] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.003] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.019] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.035] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.050] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.066] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.081] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.097] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.113] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.128] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.144] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.159] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.175] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.191] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.206] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.222] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.237] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.253] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.269] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.284] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.300] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.315] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.331] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.347] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.362] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.378] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.393] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.409] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.425] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.440] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.456] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.471] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.487] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.503] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.518] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.534] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.549] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.565] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.581] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.596] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.612] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.627] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.643] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.659] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.674] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.690] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.705] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.721] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.737] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.752] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.768] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.783] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.799] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.815] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.830] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.846] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.861] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.877] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.893] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.908] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.924] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.939] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.955] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.971] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:38.986] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.002] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.017] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.033] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.049] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.064] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.080] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.095] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.111] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.127] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.142] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.158] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.173] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.189] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.205] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.220] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.236] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.251] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.267] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.283] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.298] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.314] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.329] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.345] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.361] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.376] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.392] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.407] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.423] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.439] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.454] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.470] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.485] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.501] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.517] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.532] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.548] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.563] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.579] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.595] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.610] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.626] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.642] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.657] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.673] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.688] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.704] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.720] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.735] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.751] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.766] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.782] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.798] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.813] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.829] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.844] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.860] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.876] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.891] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.907] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.922] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.938] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.954] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.969] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:39.985] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.000] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.016] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.032] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.047] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.063] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.078] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.094] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.110] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.125] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.141] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.156] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.172] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.188] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.203] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.219] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.234] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.250] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.266] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.281] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.297] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.312] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.328] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.329] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.330] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.377] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.392] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.408] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.424] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.439] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.455] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.470] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.486] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.502] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.517] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.533] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.548] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.564] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.580] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.595] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.611] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.626] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.642] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.658] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.673] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.689] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.704] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.720] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.736] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.751] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.767] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.782] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.798] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.814] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.829] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.845] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.860] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.876] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.892] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.907] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.923] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.938] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.954] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.970] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:40.985] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.001] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.016] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.032] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.048] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.063] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.079] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.094] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.110] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.126] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.141] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.157] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.172] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.188] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.204] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.219] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.235] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.251] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.266] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.282] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.297] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.313] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.329] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.344] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.360] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.375] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.391] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.407] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.422] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.438] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.453] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.469] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.485] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.500] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.516] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.531] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.547] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.563] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.578] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.594] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.595] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.610] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.642] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.657] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.673] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.688] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.704] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.720] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.735] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.751] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.766] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.782] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.798] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.813] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.829] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.844] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.860] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.876] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.891] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.907] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.922] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.938] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.954] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.969] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:41.985] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.000] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.016] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.032] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.047] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.063] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.078] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.094] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.110] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.125] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.141] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.156] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.172] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.188] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.203] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.219] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.234] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.250] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.266] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.281] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.297] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.312] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.328] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.344] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.359] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.375] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.390] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.406] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.422] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.437] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.453] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.468] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.484] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.500] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.515] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.531] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.546] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.562] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.578] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.593] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.609] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.624] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.640] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.656] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.671] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.687] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.702] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.718] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.734] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.749] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.765] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.780] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.796] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.812] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.827] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.843] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.858] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.874] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.890] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.905] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.921] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.937] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.952] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.968] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.983] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:42.999] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.015] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.030] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.046] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.061] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.077] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.093] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.108] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.124] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.139] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.155] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.171] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.186] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.202] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.217] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.233] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.249] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.264] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.280] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.295] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.311] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.327] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.342] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.358] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.373] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.389] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.405] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.420] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.436] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.451] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.467] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.483] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.498] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.514] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.529] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.545] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.561] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.576] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.592] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.607] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.623] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.639] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.654] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.670] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.685] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.701] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.717] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.732] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.748] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.763] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.779] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.795] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.810] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.826] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.841] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.857] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.873] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.888] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.904] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.919] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.935] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.951] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.966] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.982] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:43.997] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.013] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.029] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.044] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.060] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.075] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.091] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.107] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.122] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.138] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.153] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.169] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.185] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.200] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.216] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.231] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.247] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.263] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.278] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.294] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.309] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.325] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.341] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.356] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.372] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.387] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.403] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.419] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.434] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.450] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.465] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.481] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.497] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.512] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.528] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.544] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.559] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.575] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.590] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.606] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.622] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.637] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.653] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.668] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.684] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.700] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.715] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.731] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.746] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.762] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.778] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.793] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.809] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.824] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.840] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.856] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.871] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.887] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.902] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.918] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.934] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.949] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.965] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.980] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:44.996] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:45.012] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:45.027] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:45.043] : A90432BC : Write Outputs : Done[m
[31m-[2016-04-20 17:38:45.090] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:45.105] : A90432BC : Write Outputs : Done[m
[31m-[2016-04-20 17:38:45.105] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:45.121] : A90432BC : Write Outputs : Done[m
[31m-[2016-04-20 17:38:45.121] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:45.136] : A90432BC : Write Outputs : Done[m
[31m-[2016-04-20 17:38:45.136] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:45.152] : A90432BC : Write Outputs : Done[m
[31m-[2016-04-20 17:38:45.152] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:45.168] : A90432BC : Write Outputs : Done[m
[31m-[2016-04-20 17:38:45.168] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:45.183] : A90432BC : Write Outputs : Done[m
[31m-[2016-04-20 17:38:45.183] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:45.199] : A90432BC : Write Outputs : Done[m
[31m-[2016-04-20 17:38:45.199] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:45.214] : A90432BC : Write Outputs : Done[m
[31m-[2016-04-20 17:38:45.214] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:45.230] : A90432BC : Write Outputs : Done[m
[31m-[2016-04-20 17:38:49.288] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:38:49.304] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:38:49.320] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:49.335] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:49.351] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:49.366] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:49.382] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:49.398] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:49.413] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:49.429] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:49.444] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:49.460] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:49.476] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:49.491] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:49.507] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:49.523] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:49.538] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:49.554] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:49.569] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:49.585] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:49.601] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:49.616] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:49.632] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:49.647] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:49.663] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:49.679] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:49.694] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:49.710] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:49.725] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:49.741] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:49.757] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:49.772] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:49.788] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:49.803] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:49.819] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:49.835] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:49.850] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:49.866] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:49.881] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:49.897] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:49.913] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:49.928] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:49.944] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:49.959] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:49.975] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:49.991] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.006] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.022] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.037] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.053] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.069] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.084] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.100] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.115] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.131] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.147] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.162] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.178] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.193] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.209] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.225] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.240] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.256] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.271] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.287] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.303] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.318] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.334] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.349] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.365] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.381] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.396] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.412] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.427] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.443] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.459] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.474] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.490] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.505] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.521] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.537] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.552] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.568] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.583] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.599] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.615] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.630] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.646] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.661] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.677] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.693] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.708] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.724] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.739] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.755] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.771] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.786] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.802] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.817] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.833] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.849] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.864] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.880] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.895] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.911] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.927] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.928] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.930] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.983] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:50.999] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.015] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.030] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.046] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.061] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.077] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.093] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.108] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.124] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.140] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.155] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.171] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.186] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.202] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.218] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.233] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.249] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.264] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.280] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.296] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.311] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.327] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.342] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.358] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.374] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.389] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.405] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.420] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.436] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.452] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.467] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.483] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.498] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.514] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.530] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.545] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.561] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.576] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.592] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.593] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.594] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.626] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.642] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.673] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.689] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.704] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.720] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.735] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.751] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.767] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.782] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.798] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.813] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.829] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.845] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.860] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.876] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.891] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.907] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.923] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.938] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.954] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.969] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:51.985] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.001] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.016] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.032] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.047] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.063] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.079] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.094] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.110] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.125] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.141] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.157] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.172] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.188] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.203] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.219] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.235] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.250] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.266] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.281] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.297] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.313] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.328] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.344] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.359] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.375] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.391] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.406] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.422] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.437] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.453] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.469] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.484] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.500] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.515] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.531] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.547] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.562] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.578] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.593] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.609] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.625] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.640] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.656] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.671] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.687] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.703] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.718] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.734] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.750] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.765] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.781] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.796] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.812] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.828] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.843] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.859] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.874] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.890] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.906] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.921] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.937] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.952] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.968] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.984] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:52.999] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.015] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.030] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.046] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.062] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.077] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.093] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.108] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.124] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.140] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.155] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.171] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.186] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.202] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.218] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.233] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.234] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.235] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.282] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.298] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.313] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.329] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.344] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.360] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.376] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.391] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.407] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.422] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.438] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.454] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.469] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.485] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.500] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.516] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.532] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.547] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.563] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.578] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.594] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.610] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.625] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.641] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.656] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.672] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.688] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.703] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.719] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.734] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.750] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.766] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.781] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.797] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.812] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.828] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.844] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.859] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.875] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.890] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.906] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.922] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.937] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.953] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.968] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:53.984] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.000] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.015] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.031] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.046] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.062] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.078] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.093] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.109] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.124] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.140] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.156] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.171] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.187] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.202] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.218] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.234] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.249] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.265] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.280] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.296] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.312] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.327] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.343] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.358] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.374] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.390] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.421] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:38:54.437] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:38:54.452] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.468] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.483] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.499] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.515] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.530] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.546] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.561] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.577] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.593] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.608] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.624] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.639] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.655] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.671] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.686] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.702] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.717] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.733] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.749] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.764] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.780] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.795] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.811] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.827] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.842] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.858] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.873] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.889] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.905] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.920] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.936] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.951] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.967] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.968] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:54.969] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.016] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.031] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.047] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.063] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.078] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.094] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.109] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.125] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.141] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.156] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.172] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.187] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.203] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.234] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:38:55.250] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:38:55.265] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.281] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.297] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.312] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.328] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.343] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.359] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.375] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.390] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.406] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.421] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.437] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.453] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.468] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.484] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.499] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.515] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.531] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.546] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.562] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.577] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.593] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.609] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.624] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.640] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.655] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.671] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.687] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.702] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.718] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.733] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.749] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.765] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.780] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.796] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.811] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.827] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.843] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.858] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.874] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.889] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.905] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.921] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.936] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.952] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.967] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.983] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:55.999] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.014] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.030] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.046] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.061] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.077] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.092] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.108] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.124] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.139] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.155] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.170] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.186] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.202] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.217] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.233] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.248] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.264] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.280] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.295] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.311] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.326] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.342] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.358] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.373] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.389] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.404] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.420] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.436] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.451] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.467] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.482] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.498] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.514] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.529] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.545] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.560] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.576] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.592] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.607] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.623] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.638] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.654] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.670] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.685] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.701] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.716] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.732] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.748] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.763] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.779] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.794] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.810] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.826] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.841] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.857] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.872] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.888] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.904] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.919] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.935] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.950] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.966] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.982] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:56.997] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.013] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.028] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.044] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.060] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.075] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.091] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.106] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.122] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.138] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.153] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.184] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:38:57.200] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:38:57.216] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.231] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.247] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.262] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.278] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.294] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.309] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.325] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.340] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.356] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.372] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.387] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.403] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.404] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.419] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.451] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.466] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.482] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.497] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.513] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.529] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.544] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.560] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.575] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.591] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.607] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.622] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.638] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.654] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.685] : A90432BC : Write Outputs : Init[m
[31m-[2016-04-20 17:38:57.700] : A90432BC : Write Outputs : SendSettings[m
[31m-[2016-04-20 17:38:57.716] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.732] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.747] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.763] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.778] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.794] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.810] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.825] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.841] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.856] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.872] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.888] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.903] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.919] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.934] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.950] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.966] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.981] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:57.997] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.012] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.028] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.044] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.059] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.075] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.090] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.106] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.122] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.137] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.153] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.168] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.184] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.200] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.215] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.231] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.246] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.262] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.278] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.293] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.309] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.324] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.340] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.356] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.371] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.387] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.402] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.418] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.434] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.449] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.465] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.480] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.496] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.512] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.527] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.543] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.558] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.574] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.590] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.605] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.621] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.636] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.652] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.668] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.683] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.699] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.714] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.730] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.746] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.761] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.777] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.792] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.808] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.824] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.839] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.855] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.870] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.886] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.902] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.917] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.933] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.948] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.964] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.980] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:58.995] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.011] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.026] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.042] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.058] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.073] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.089] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.104] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.120] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.136] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.151] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.167] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.182] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.198] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.214] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.229] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.245] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.260] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.276] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.292] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.307] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.323] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.339] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.354] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.370] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.385] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.401] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.417] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.432] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.448] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.463] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.479] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.495] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.510] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.526] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.541] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.557] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.573] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.588] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.604] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.619] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.635] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.651] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.666] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.682] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.697] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.713] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.729] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.744] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.760] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.775] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.791] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.807] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.822] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.838] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.853] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.869] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.885] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.900] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.916] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.931] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.947] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.963] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.978] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:38:59.994] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.009] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.025] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.041] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.056] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.072] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.087] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.103] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.119] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.134] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.150] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.165] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.181] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.197] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.212] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.228] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.243] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.259] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.275] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.290] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.306] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.321] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.337] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.353] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.368] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.384] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.399] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.415] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.431] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.446] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.462] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.477] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.493] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.509] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.524] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.540] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.555] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.571] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.587] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.602] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.618] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.633] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.649] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.665] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.680] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.696] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.711] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.727] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.743] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.758] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.774] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.789] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.805] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.821] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.836] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.852] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.867] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.883] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.899] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.914] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.930] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.946] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.961] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.977] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:00.992] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.008] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.024] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.039] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.055] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.070] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.086] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.102] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.117] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.133] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.148] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.164] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.180] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.195] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.211] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.226] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.242] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.258] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.273] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.289] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.304] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.320] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.336] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.351] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.367] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.382] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.398] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.414] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.429] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.445] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.460] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.476] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.492] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.507] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.523] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.538] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.554] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.570] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.585] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.601] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.616] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.617] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.618] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.667] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.683] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.698] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.714] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.730] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.745] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.761] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.776] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.792] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.808] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.823] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.839] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.854] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.870] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.886] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.901] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.917] : A90432BC : Write Outputs : WaitReply[m
[31m-[2016-04-20 17:39:01.932] : A90432BC : Write Outputs : WaitReply[m
