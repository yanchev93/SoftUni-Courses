sum_sells = int(input())

cash = 0
card = 0
cs = 0
cc = 0
count = 0

command = input()
while command != "End":
    command = int(command)
    count += 1

    if count % 2 == 0:
        if command < 10:
            print("Error in transaction!")
        else:
            print("Product sold!")
            card += command
            cc += 1
            sum_sells -= command
    else:
        if command > 100:
            print("Error in transaction!")
        else:
            print("Product sold!")
            cash += command
            cs += 1
            sum_sells -= command
    if sum_sells <= 0:
        average_cash = cash / cs
        average_card = card / cc
        print(f"Average CS: {average_cash:.2f}")
        print(f"Average CC: {average_card:.2f}")
        break
    command = input()

if command == "End":
    print("Failed to collect required money for charity.")
