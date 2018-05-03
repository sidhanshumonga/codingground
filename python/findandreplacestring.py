input = "the lyrics is not that poor!"

start =  input.find("not")
end =  input.find("poor")

print input.replace(input[start:end+4],"good")