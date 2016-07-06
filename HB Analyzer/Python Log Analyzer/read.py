def source_file():
   #call(["./LogAnalyzer", "args", "to", "LogAnalyzer.exe"])
   count = 0
   file = input("Enter File name >")
   mac_address = []
   time = []
   try:
       if file[:7] == 'Message':
            date = file[8:]
            with open(file +'.log') as file:
               for word in file:
                   print(word[81:83])
                   if word[81:83] == 'RX':   ##Check if the messages are RX
                       time.append(word[11:16])  ##Append the time the messages were sent by the device
                       mac_address.append(word[116:139])  ##Analyze the log file and add each Source MAC address
            file.close()
       total_devices = list(set(mac_address)) ##get each of the MAC Address that were recorded in the log
       for i,j in enumerate(mac_address):  ##get the index and each MAC address with RX in the Log
            for item in total_devices:  ##Compare the item with the list of available address
               if j == item:    ##Check for the match
                   print("MAC:{} Time:{}".format(item,time[i]))
        print(date)
##        ##lines = time
       print(total_devices)
    except KeyError:

