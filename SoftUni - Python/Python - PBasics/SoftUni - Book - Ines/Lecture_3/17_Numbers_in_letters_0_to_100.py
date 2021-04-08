num = int(input())

num_0 = num / 10
num_1 = num % 10

if num == 0:
    print("zero")
elif num == 1:
    print("one")
elif num == 2:
    print("two")
elif num == 3:
    print("three")
elif num == 4:
    print("four")
elif num == 5:
    print("five")
elif num == 6:
    print("six")
elif num == 7:
    print("seven")
elif num == 8:
    print("eight")
elif num == 9:
    print("nine")
    if num == 10:
        print("ten")
    elif num == 11:
        print("eleven")
    elif num == 12:
        print("twelve")
    elif num == 13:
        print("thirteen")
    elif num == 14:
        print("fourteen")
    elif num == 15:
        print("fifteen")
    elif num == 16:
        print("sixteen")
    elif num == 17:
        print("seventeen")
    elif num == 18:
        print("eighteen")
    elif num == 19:
        print("nineteen")
    elif num == 20:
        print("twenty")
if (num < 20) or (num > 30):
    print(f"{num_0}+" "+{num_1}")
    if num == 30:
        print("thirty")
    elif num == 40:
        print("forty")
    elif num == 50:
        print("fifty")
    elif num == 60:
        print("sixty")
    elif num == 70:
        print("seventy")
    elif num == 80:
     print("eighty")
    elif num == 90:
        print("ninety")
else:
    print("one hundred")

