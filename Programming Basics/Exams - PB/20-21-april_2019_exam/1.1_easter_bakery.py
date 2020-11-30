flour_kg = float(input())
kg_flour = float(input())
kg_sugar = float(input())
eggs = int(input())
yeast = int(input())

sugar_price = flour_kg * 0.75
eggs_price = flour_kg * 1.1
yeast_price = sugar_price * 0.20
sum_flour = flour_kg * kg_flour
sum_sugar = sugar_price * kg_sugar
sum_eggs = eggs_price * eggs
sum_yeast = yeast_price * yeast

total = sum_flour + sum_sugar + sum_eggs + sum_yeast
print(f"{total:.2f}")