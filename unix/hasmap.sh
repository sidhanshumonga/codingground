# created by sidhanshu monga
# 10 may, 2018

#Problem statement :  implement hashmap

echo -n "Enter your name : "
read myname
echo -n "Enter your company name : "
read companyname
declare -A newmap
newmap[name]=$myname
newmap[designation]=SSE
newmap[company]=$companyname

echo "My company is : ${newmap[company]}"
echo "My name is : ${newmap[name]}"
