# compiler
CC = gcc

#executable
CFILES = test.c
object = test.o

#compile flags:
#	-g  adds debugging information to the executable file
#	-Wall turns on most, but not all, compiler warnings
CFLAGS = -g -Wall

PATH = C:\MinGw\bin;%PATH%
#build target executable

all:  
	$(CC) -o $(object) -c $(CFILES)
	$(CC) -o LogAnalyzer.exe $(object)

clean:
	$(RM) test