#problem statement : return true if on spliting the input string we get words, exist in the given dictionary

import sys
input = ""
for line in sys.stdin:
    input = line
dict = {"i" : "1","love" : "1","indian" : "1","spicy" : "1","food" : "1"}
flag = False
check = ""

for a in input:
    check = check + a
    # print check
    if check in dict:
        flag = True
        check = ""
    else:
        flag = False

print flag