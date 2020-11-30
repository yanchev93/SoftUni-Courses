budget = float(input())
season = input()

price = 0

if budget <= 1000:
    place = "Camp"
    if season == "Summer":
        price = budget * 0.65
    elif season == "Winter":
        price = budget * 0.45
elif 1000 < budget <= 3000:
    place = "Hut"
    if season == "Summer":
        price = budget * 0.80
    elif season == "Winter":
        price = budget * 0.60
else:
    place = "Hotel"
    if season == "Summer" or season == "Winter":
        price = budget * 0.90

if season == "Summer":
    print(f"Alaska - {place} - {price:.2f}")
else:
    print(f"Morocco - {place} - {price:.2f}")