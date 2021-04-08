price_20kg = float(input())
kg_luggage = float(input())
days_until_trip = int(input())
count_luggage = int(input())

price_luggage = 0
if kg_luggage < 10:
    price_luggage = price_20kg * 0.20
elif 10 <= kg_luggage <= 20:
    price_luggage = price_20kg / 2
else:
    price_luggage = price_20kg

if days_until_trip < 7:
    price_luggage = price_luggage + (price_luggage*0.40)
elif 7 <= days_until_trip <= 30:
    price_luggage = price_luggage + (price_luggage*0.15)
else:
    price_luggage = price_luggage + (price_luggage*0.10)

total = price_luggage * count_luggage
print(f"The total price of bags is: {total:.2f} lv. ")


