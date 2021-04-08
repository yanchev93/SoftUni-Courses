budget = float(input())

count_product = 0
total_price = 0
command = input()
while command != "Stop":
    name_product = command
    price_product = float(input())
    count_product += 1

    if count_product % 3 == 0:
        price_product *= 0.50

    total_price += price_product
    if budget < total_price:
        diff = abs(budget - total_price)
        print(f"You don't have enough money!")
        print(f"You need {diff:.2f} leva!")
        break
    command = input()
else:
    print(f"You bought {count_product} products for {total_price:.2f} leva.")