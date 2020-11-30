customers = int(input())


average_price = 0

for i in range(1, customers+1):
    command = input()


    total = 0
    count = 0
    while command != "Finish":
        product = command

        if product == "basket":
            count += 1
            total += 1.50
        elif product == "wreath":
            count += 1
            total += 3.80
        else:
            count += 1
            total += 7
        command = input()

    if count % 2 == 0:
        total *= 0.80
        print(f"You purchased {count} items for {total:.2f} leva.")
    else:
        print(f"You purchased {count} items for {total:.2f} leva.")
    average_price += total
average_price = average_price / customers
print(f"Average bill per client is: {average_price:.2f} leva.")