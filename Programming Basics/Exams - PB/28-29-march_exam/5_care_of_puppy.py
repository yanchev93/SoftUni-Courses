bought_food_in_kg = int(input()) * 1000

eaten = 0
command = input()
while command != "Adopted":
    grams = int(command)

    eaten += grams

    command = input()
diff = abs(bought_food_in_kg - eaten)
if bought_food_in_kg < eaten:
    print(f"Food is not enough. You need {diff} grams more.")
else:
    print(f"Food is enough! Leftovers: {diff} grams.")
