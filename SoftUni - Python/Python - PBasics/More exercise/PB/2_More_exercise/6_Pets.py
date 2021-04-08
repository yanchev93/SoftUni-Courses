import math
days = int(input())
food_kg = int(input())
food_kg_dog = float(input())
food_kg_cat = float(input())
food_grams_turtle = float(input())

food_kg_dog = days * food_kg_dog
food_kg_cat = days * food_kg_cat
food_kg_turtle = days * food_grams_turtle / 1000

total_food = food_kg_dog + food_kg_cat + food_kg_turtle
food = abs(total_food - food_kg)

if total_food <= food_kg:
    print(f"{math.floor(food)} kilos of food left.")
else:
    print(f"{math.ceil(food)} more kilos of food are needed.")