first= input()
second = input()


for i in range(int(first[0]), int(second[0])+1):
    for j in range(int(first[1]), int(second[1])+1):
        for k in range(int(first[2]), int(second[2])+1):
            for l in range(int(first[3]), int(second[3])+1):
                if i % 2 != 0 and j % 2 != 0 and k % 2 != 0 and l % 2 != 0:
                    print(f"{i}{j}{k}{l}", end=" ")
