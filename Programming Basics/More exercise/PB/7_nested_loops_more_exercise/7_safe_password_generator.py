a = int(input())
b = int(input())
max_passwords = int(input())

count = 0
for i in range(35, 55):
    for j in range(64, 96):
        for m in range(64, 96):
            for n in range( 35, 55):
                for k in range(1, a + 1):
                    for l in range(1, b + 1):
                        if max_passwords == count:
                            break
                        count += 1
                        print(f"{chr(i)}{chr(j)}{k}{l}{chr(m)}{chr(n)}", end="|")
                        i += 1
                        j += 1
                        m += 1
                        n += 1
                        if i > 55 and n > 55:
                            i = 35
                            n = 35
                        if j > 96 and m > 96:
                            j = 64
                            m = 64
                        if k == a and l == b:
                            break
                    if j > 96 and m > 96:
                        j = 64
                        m = 64
                    if k == a and l == b:
                        break
                    if max_passwords == count:
                        break
                if j > 96 and m > 96:
                    j = 64
                    m = 64
                if k == a and l == b:
                    break
                if max_passwords == count:
                    break
            if j > 96 and m > 96:
                j = 64
                m = 64
            if k == a and l == b:
                break
            if max_passwords == count:
                break
        if j > 96 and m > 96:
            j = 64
            m = 64
        if k == a and l == b:
            break
        if max_passwords == count:
            break
    if j > 96 and m > 96:
        j = 64
        m = 64
    if k == a and l == b:
        break
    if max_passwords == count:
        break