# created by sidhanshu monga
# 08 may, 2018

#Problem statement :  remove the nth character from the given string

str = "hello how are you?"

index  = 10 #nth index
if(len(str) < index):
    print "out of bound"
else:
    print str[:index] + str[index+1:]