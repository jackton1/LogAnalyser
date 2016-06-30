from datetime import datetime
from collections import Counter
from ast import literal_eval


##Needs to be implemented
##import sys, string, os, subprocess
##
##def c_program():
##    os.chdir( '../../HB Analyzer' )
##    os.system('./test.exe')
##
##c_program()


def source_file():
    file = input("Enter File name >")
    with open(file +'.txt') as file:
        lines = file.read().splitlines()
    file.close()
    create_file(lines)

def create_file(lines):
    date = input("Enter the Test Date of Log like DD Month YYYY>")
    data = list(lines)
    m = Counter(data)
    string = repr(m)
    try:
        f = open('../../Logs/'+ date +' Micare Report.doc', 'w')   
        length = str(len(m))
        f.write("MICARE TEST REPORT\n")
        f.write("_"* 40)
        f.write("\nTest Date: {}\n\n".format(date))
        start_time = str(input("Enter the Start time of the test am\pm >"))
        end_time = str(input("Enter the End time of the test am\pm >"))
        f.write("Test Time: {} - {}\n\n".format(start_time, end_time))
        f.write("The Total Number of Time Messages where sent is: " +length+ "\n\n\n\n")
        f.write("\nDevice under Test\n")
        f.write("_"*30)
        f.write("\nDevice Type: NC-500 (Pendant)\nMAC Address: 00:1E:71:05:00:02:34")
        f.write("\n\nThe Message count each time is :\n\n")
        string2 = list(m.items())
        string2.sort()
        for item in string2:
            stnd= str(item).strip('{[)]}')
            f.write(stnd + " Messages where sent)\n")
        f.write("\n\n\n"+"*" * 15)
        f.write("Python 3.5.1 Auto Generated Log Data Report")
        f.write("*" * 15)
        date = str("{:%d.%m.%Y}".format(datetime.now()))
        time = str("{:%H.%M.%S}".format(datetime.now()))
        f.write("\n\nDate Created: {}\tTime: {}".format(date,time))
        f.close()
        print("SAVED ")
    except PermissionError:
        print("File is open or can't be accessed !!!")
        start()
        
def start():   
    print("***Welcome to Python Log Generator***\n")
    try:
        user_input = str(input("Press [S] to start >").lower())
        if user_input[0] == 's':
            source_file()
        if user_input != 's':
           print("Didnt Enter the right String") 
    except ValueError:
        raise



start()
