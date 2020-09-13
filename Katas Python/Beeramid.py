import math as math

def function (bonus, price):
    numberofCans = math.floor (bonus/price)
    print(numberofCans)
    index = 1
    steps = 0
    if numberofCans <= 0:
      return 0
    while numberofCans > 0:
        numberofCans = (int)(numberofCans - (index**2))
        index = index + 1
        if numberofCans >= 0:
          steps = steps + 1

    return steps

