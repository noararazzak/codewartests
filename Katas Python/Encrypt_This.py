def encrypt_this(text):
    lst = text.split()
    final_lst = []
    print(lst)
    for i in lst:
        print(i)
        print(len(i))
        enc = ord(i[0])
        if len(i) > 2:
            middle = i[2:-1]
            ans = str(enc) + i[len(i) - 1] + middle + i[1]
            final_lst.append(ans)
        elif len(i) == 2:
            ans = str(enc) + i[len(i) - 1]
            final_lst.append(ans)
        elif len(i) == 1:
            ans = str(enc)
            final_lst.append(ans)

    final_str = " "
    return (final_str.join(final_lst))


def main():
    answer = encrypt_this("A wise old owl lived in an oak")
    print (answer)


if __name__ == "__main__":
    main()