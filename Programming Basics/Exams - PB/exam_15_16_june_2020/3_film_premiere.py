name_movie = input()
product_name = input()
tickets = int(input())

bill = 0

if name_movie == "John Wick":
    if product_name == "Drink":
        bill = tickets * 12
    elif product_name == "Popcorn":
        bill = tickets * 15
    elif product_name == "Menu":
        bill = tickets * 19
elif name_movie == "Star Wars":
    if product_name == "Drink":
        bill = tickets * 18
    elif product_name == "Popcorn":
        bill = tickets * 25
    elif product_name == "Menu":
        bill = tickets * 30
    if tickets >= 4:
        bill -= (bill * 0.30)
else:
    if product_name == "Drink":
        bill = tickets * 9
    elif product_name == "Popcorn":
        bill = tickets * 11
    elif product_name == "Menu":
        bill = tickets * 14
    if tickets == 2:
        bill -= (bill * 0.15)
print(f"Your bill is {bill:.2f} leva.")