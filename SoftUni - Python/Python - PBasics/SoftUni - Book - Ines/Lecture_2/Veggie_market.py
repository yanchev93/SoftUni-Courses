price_veggie_kg = float(input())
price_fruits_kg = float(input())
kg_veggies = int(input())
kg_fruits = int(input())

Veggies = price_veggie_kg*kg_veggies
Fruits = price_fruits_kg*kg_fruits

sum = Veggies+Fruits
sum_to_euro = sum/1.94

print(sum_to_euro)