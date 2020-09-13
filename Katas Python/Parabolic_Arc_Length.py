import math as math

def len_curve(n):
    x_squared = (1/n)**2
    y_squared_list = []
    z_squared_list = []
    i = 0
    k = 1
    sum = 0
    for i in range(n):
        y_squared = (k/(n**2))**2
        y_squared_list.append(y_squared)
        k = k + 2

    for x in y_squared_list:
        z_squared = math.sqrt(x + x_squared)
        z_squared_list.append(z_squared)

    for z in z_squared_list:
        sum = sum + z

    sum = round(sum, 9)
    return sum

def main():
    answer = len_curve(1)
    print (answer)


if __name__ == "__main__":
    main()