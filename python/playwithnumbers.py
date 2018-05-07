#problem statement : 
#Q. Lets start with a set of all integers.

#1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20………………..

#Now lets strike off every 2nd number resulting in

#1,3,5,7,9,11,13,15,17,19,21,23,25,27,29,31………………

#Now lets strike off every 3rd number resulting in

#1,3,7,9,13,15,19,21,25,27,31…………………….

#Now lets strike off every 4th number resulting in

#1,3,7,13,15,19,25,27,31…………………………

#Now 5th

#1,3,7,13,19,25,27,31…………………

#Now 6th

#1,3,7,13,19,27,31………….

#Now 7th………………

#1,3,7,13,19,27………………

#We can keep going like this but 1,3,7,13,19,27 would continue to stay in the series. 
#Write a program to generate this series upto as many numbers as the user passes in the function.


def getlist(g,f,list):
    if(g >= 20):
        return
    else:
        str = ""
        for a in range(0,len(list)):
            if((a+1)%f!=0):
                str = str + list[a] + ','
        newlist=filter(lambda x: len(x)>0, str.split(','))
        print newlist
        getlist(g+1,f+1,newlist)


g = 1
f = 2
input = '1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70'
i =  input.split(",")
print i
getlist(g,f,i)