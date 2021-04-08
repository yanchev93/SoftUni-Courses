first_letter = input()
second_letter = input()
avoid_letter = input()

count = 0
for i in range(ord(first_letter), ord(second_letter)+1):
    for j in range(ord(first_letter), ord(second_letter)+1):
        for k in range(ord(first_letter), ord(second_letter)+1):
            if i == ord(avoid_letter) or j == ord(avoid_letter) or k == ord(avoid_letter):
                pass
            else:
                count += 1
                print(f"{chr(i)}{chr(j)}{chr(k)}", end=" ")
print(f"{count}")