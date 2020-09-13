import math as math

def likes(names):
    n = len(names)
    if n ==0:
        return "no one likes this"
    elif n == 1:
        return names[0] + " " + "likes this"
    elif n == 2:
        return names[0] + " " + "and " + names[1] + " " + "like this"
    elif n == 3:
        return names[0]+ ", " + names[1] + " "+ "and " + names[2] + " " + "like this"
    else:
        return names[0]+ ", " + names[1] + " "+ "and " + str(n-2) + " " + "others like this"


def main():
    answer = likes(["Peter"])
    print (answer)


if __name__ == "__main__":
    main()