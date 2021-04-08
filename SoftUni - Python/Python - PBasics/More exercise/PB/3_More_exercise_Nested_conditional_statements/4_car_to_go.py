budget = float(input())
season = input()

price_car = 0

if budget <= 100:
    class_car = "Economy class"
    if season == "Summer":
        price_car = budget * 0.35
        car = "Cabrio"
    elif season == "Winter":
        price_car = budget * 0.65
        car = "Jeep"
elif 100 < budget <= 500:
    class_car = "Compact class"
    if season == "Summer":
        price_car = budget * 0.45
        car = "Cabrio"
    elif season == "Winter":
        price_car = budget * 0.80
        car = "Jeep"
else:
    class_car = "Luxury class"
    if season == "Summer" or season == "Winter":
        price_car = budget * 0.90
        car = "Jeep"

print(f"{class_car}")
print(f"{car} - {price_car:.2f}")