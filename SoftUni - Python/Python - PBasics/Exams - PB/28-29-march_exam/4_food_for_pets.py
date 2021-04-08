days = int(input())
total_food = float(input())

biscuits = 0
dog_food = 0
cat_food = 0
for day in range(1, days+1):
    dog_eaten_food = int(input())
    cat_eaten_food = int(input())

    food_eaten_today = 0
    dog_food += dog_eaten_food
    cat_food += cat_eaten_food
    if day % 3 == 0:
        food_eaten_today = dog_eaten_food + cat_eaten_food
        biscuits += food_eaten_today * 0.10

total_eaten = (dog_food + cat_food)
total_eaten_food = (dog_food + cat_food) / total_food * 100
dog = dog_food / total_eaten * 100
cat = cat_food / total_eaten * 100


print(f"Total eaten biscuits: {round(biscuits)}gr.")
print(f"{total_eaten_food:.2f}% of the food has been eaten.")
print(f"{dog:.2f}% eaten from the dog.")
print(f"{cat:.2f}% eaten from the cat.")