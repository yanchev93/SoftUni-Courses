from math import ceil
easter_bread_count = int(input())

max_sugar = 0
max_flour = 0
sugar = 0
flour = 0

for i in range(1, easter_bread_count+1):
    sugar_gr = int(input())
    flour_gr = int(input())

    if sugar_gr > max_sugar:
        max_sugar = sugar_gr
    if flour_gr > max_flour:
        max_flour = flour_gr

    sugar += sugar_gr
    flour += flour_gr

sugar_packs = sugar / 960
flour_packs = flour / 750

print(f"Sugar: {ceil(sugar_packs)}")
print(f"Flour: {ceil(flour_packs)}")
print(f"Max used flour is {max_flour} grams, max used sugar is {max_sugar} grams.")