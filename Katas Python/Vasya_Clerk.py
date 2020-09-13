import math as math

def tickets (people):
    totalPeople = len(people)
    totalMoneyEarned = 0
    for i in range(totalPeople):
        print(people[i])
    for i in range(totalPeople):
        totalMoneyEarned = totalMoneyEarned + people[i]
        i = i + 1

    totalMoneyNeeded = 25* (totalPeople)
    totalChangeLeft = totalMoneyEarned - totalMoneyNeeded
    if totalChangeLeft <= 25:
        return "YES"
    else:
        return "NO"


def tickets2 (people):
    totalPeople = len(people)
    twentyfivedollars = 0
    fiftydollars = 0
    hundreddollars = 0

    for i in range(totalPeople):
        print(people[i])

    if people[0] == 25:
        for i in range(totalPeople):
            if people[i] == 25:
                twentyfivedollars = 1 + twentyfivedollars
                i = i + 1
            elif people[i] == 50:
                fiftydollars = fiftydollars + 1
                if twentyfivedollars >= 1:
                    twentyfivedollars = twentyfivedollars - 1
                    i = i + 1
                else:
                    return "NO"
            else:
                hundreddollars = hundreddollars + 1
                if twentyfivedollars >= 1 and fiftydollars >= 1:
                    twentyfivedollars = twentyfivedollars - 1
                    fiftydollars = fiftydollars - 1
                    i = i + 1
                elif twentyfivedollars >= 3:
                    twentyfivedollars = twentyfivedollars - 3
                    i = i + 1
                else:
                    return "NO"
        return "YES"
    elif people[0] == 50:
            return "NO"
    elif people[0] == 100:
            return "NO"


def main():
    people = [25, 100]
    answer = tickets2(people)
    print (answer)

if __name__ == "__main__":
    main()