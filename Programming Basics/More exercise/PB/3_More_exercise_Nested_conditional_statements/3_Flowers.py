chrysanthemums = int(input())
roses = int(input())
tulips = int(input())
season = input()
day_type = input()

price = 0
total_flowers = chrysanthemums + roses + tulips

if season == "Spring" or season == "Summer":
    price = chrysanthemums * 2 + roses * 4.10 + tulips * 2.50
    if day_type == "Y":
        price += price * 0.15
        if tulips > 7 and season == "Spring":
            price -= price * 0.05
    elif day_type == "N":
        price = price
        if tulips > 7 and season == "Spring":
            price -= price * 0.05
elif season == "Autumn" or season == "Winter":
    price = chrysanthemums * 3.75 + roses * 4.50 + tulips * 4.15
    if day_type == "Y":
        price += price * 0.15
        if roses >= 10 and season == "Winter":
            price -= price * 0.10
    elif day_type == "N":
        price = price
        if roses >= 10 and season == "Winter":
            price -= price * 0.10
if total_flowers > 20:
    price -= price * 0.20

price = price + 2

print(f"{price:.2f}")