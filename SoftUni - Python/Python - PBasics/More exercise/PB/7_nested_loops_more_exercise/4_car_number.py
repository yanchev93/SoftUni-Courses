start = int(input())
final = int(input())

for i in range(start, final+1):
    for j in range(start, final+1):
        for k in range(start, final+1):
            for l in range(start, final+1):
                sum = j + k
                if i % 2 == 0 and l % 2 != 0:
                    pass
                    if i > l:
                        pass
                        if sum % 2 == 0:
                            print(f"{i}{j}{k}{l}", end=" ")
                else:
                    if i % 2 != 0 and l % 2 == 0:
                        pass
                        if i > l:
                            pass
                            if sum % 2 == 0:
                                print(f"{i}{j}{k}{l}", end=" ")
