str = "hello how are you?"

index  = 10 #nth index
if(len(str) < index):
    print "out of bound"
else:
    print str[:index] + str[index+1:]