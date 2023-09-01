#PROG1870 - Pythonic Coding Challenge #3
#DATE: 01/21/2022
#BY: Jackson Pipe

#PART A
def power(x, y):
    if y == 0: return 1
    if y % 2 == 0: 
        return power(x, y // 2) * power(x, y // 2)
    return x * power(x, y // 2) * power(x, y // 2)

def order (x):
    z = 0
    while(x != 0):
        z = z + 1
        x = x // 10
    return z

def isArmstrong(x):
    z = order(x)
    temp = x
    sum = 0

    while(temp != 0):
        r = temp % 10
        sum = sum + power(r, z)
        temp = temp // 10
    return (sum == x)

print(isArmstrong(153))
print(isArmstrong(1634))
print(isArmstrong(150))
print(isArmstrong(1635))




