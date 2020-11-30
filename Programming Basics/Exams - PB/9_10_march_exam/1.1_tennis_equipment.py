import math
tennis_rocket = float(input())
number_rockets = int(input())
number_sneakers = int(input())

price_rockets = tennis_rocket * number_rockets
price_sneakers = tennis_rocket / 6
price_all_sneakers = price_sneakers * number_sneakers
other_equipment = (price_all_sneakers + price_rockets) * 0.20
total_price = other_equipment + price_all_sneakers + price_rockets

djokovic = total_price / 1/8
sponsor = total_price * 7/8

print(f"Price to be paid by Djokovic {math.floor(djokovic)}")
print(f"Price to be paid by sponsors {math.ceil(sponsor)}")
