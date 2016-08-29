#ifndef __TEST_H__
#define __TEST_H__

//Structure to hold the User defined information
typedef struct {
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
              char t1[4];
              int hr2;
              int min2;
              char t2[4];
              int hour;
              int m;
        } log_info;


void flushStdin(void);
log_info data_get(void);
int user_input(void);
void print_stars(FILE* fp, int len);
void print_hline(FILE* f, int len);
void init_console(void);
void print_goodbye(void);
void print_help(void);
void print_welcome(void);
char get_date(void);
void make_lower(char *array);
#endif
