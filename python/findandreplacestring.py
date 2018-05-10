# created by sidhanshu monga
# 08 may, 2018

#Problem statement :  find particular string and replace is with given string

input = "the lyrics is not that poor!"

start =  input.find("not")
end =  input.find("poor")

print input.replace(input[start:end+4],"good")