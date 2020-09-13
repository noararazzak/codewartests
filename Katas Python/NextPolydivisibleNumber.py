import math as math

def next_num_wrong(n):
    def next_num(n):
        number = 1
        num_list = []
        num_final = []
        for i in str(n):
            num_list.append(int(i))

        num_list_count = num_list.count()
        for i in range(num_list_count):
            if num_list[i] != 0:
                if num_list[i] % number ==0:
                    number = number + 1
                    num_final.append(num_list[i])
                    i = i + 1
                elif num_list[i] % number != 0 and i == num_list_count -1 :
                    num_list[i] = num_list[i] +1
                else:
                    return None
            else:
                if i == 0 and num_list_count == 1:
                    return 1
                elif i == 0 and num_list_count > 1:
                    return None
                elif i > 0 and num_list_count>1 and i == num_list_count -1:
                    num_list[i] = num_list[i] + 1
                else:
                    return None
        s = ''.join(map(str, num_final))
        return int(s)

def n_count(n):
    count = 0
    while n > 1:
        n = n/10
        count = count + 1
    return count

def n_digits (n, i):
    power= n_count(n)
    answer = n // (10 ^ (power - i - 1))
    return answer

def next_num(n):
    count = n_count(n)
    number = 1
    happened = False
    s = 0
    i = 0

    while i < count:
        if happened == False:
            s = n_digits(n, i)
            if s % number == 0:
                if i == (count - 1):
                    s = s + number
                number = number + 1
                i = i + 1
            else:
                s = s + 1
                happened = True
        else:
            s = n_digits(s, i)
            if s % number == 0:
                number = number + 1
                if i < count - 1:
                    s = s * 10
                i = i + 1
            else:
                s = s + 1

    return s

def main():
    answer = next_num(1234)
    print (answer)


if __name__ == "__main__":
    main()