# created by sidhanshu monga
# 08 may, 2018

#Problem statement :  find largest number in given three numbers

echo "enter first number"
read first
echo "enter second number"
read second
echo "enter third number"
read third
if [ $first -gt $second ] ; then
if [ $first -gt $third ] ; then
echo -e " $first is greatest number "
else
echo -e " $third is greatest number "
fi
else
if [ $second -gt $third ] ; then
echo -e " $second is greatest number "
else
echo -e " $third is greatest number "
fi
fi