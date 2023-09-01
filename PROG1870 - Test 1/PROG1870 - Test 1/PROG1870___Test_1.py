#PROG1870 - TEST 1
#DATE 01/28/2022
#BY: JACKSON PIPE

import sys

def diffLargestAndSmallestDigits(input):
    ascending = "".join(sorted(str(input)))
    descending = "".join(sorted(str(input), reverse = True))
    try:
        result = (int(descending) - int(ascending))
        return result
    except:
        print("error: ", sys.exc_info()[0])


print('Enter a number: ')
user_input = input()

output = {
    "user_num" : user_input,
    "outcome" : diffLargestAndSmallestDigits(user_input)
}

print(output)
