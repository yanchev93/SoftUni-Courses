age = int(input())
wash_machine = float(input())
price_toy = int(input())

toy_count = 0
sum = 0
money = 0
brother_money = 0

for year in range(1, age+1):
    if year % 2 == 0:
        money = money + 10
        sum += money
        brother_money += 1
    else:
        toy_count += 1

sum = sum + toy_count*price_toy - brother_money
diff = abs(sum - wash_machine)

if sum >= wash_machine:
    print(f"Yes! {diff:.2f}")
else:
    print(f"No! {diff:.2f}")

