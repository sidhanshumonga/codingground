input = "12:25:26AM"

if(input[8]=="P"):
    if(input[:2]=="12"):
        print str(int(input[:2])) + input[2:8]
    else:
        print str(int(input[:2])+12) + input[2:8]
else:
    if(input[:2]=="12"):
        print str(int(input[:2])-12) + "0" + input[2:8]
    else:
        print input[:8]