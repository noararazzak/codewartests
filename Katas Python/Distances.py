from itertools import combinations


def choose_best_sum(maximum, k, lst):
    probabledistances = []
    combine = combinations(lst, k)
    for i in list(combine):
        total = 0
        ilist = list(i)
        for j in range(len(ilist)):
            total = total + ilist[j]
            j = j + 1
        if total <= maximum:
            probabledistances.append(total)

    if not probabledistances:
        return None
    else:
        probablemaximum = max(probabledistances)
    if probablemaximum <= maximum:
        return probablemaximum
    else:
        return None


def main():
    lst = [100, 76, 56, 44, 89, 73, 68, 56, 64, 123, 2333, 144, 50, 132, 123, 34, 89]
    answer = choose_best_sum(430, 8, lst)
    print(answer)


if __name__ == "__main__":
    main()