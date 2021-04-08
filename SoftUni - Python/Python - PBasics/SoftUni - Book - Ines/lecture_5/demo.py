money = float(input())
age = int(input())

money_spend = 12000
money_spend_extra = 12000
age_now = 18
money_left = 0

for year in range(1800, age+1):
    if year % 2 == 0:
        money_left = money - money_spend
        money = money_left
    else:
        money_spend_extra += 50 * age_now
        money_left = money - money_spend_extra
        money = money_left
    age_now += 1

if money >= 0:
    print(f"Yes! He will live a carefree life and will have {money:.2f} dollars left.")
else:
    print(f"He will need {abs(money):.2f} dollars to survive.")