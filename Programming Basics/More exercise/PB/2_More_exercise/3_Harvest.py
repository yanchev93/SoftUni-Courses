import math

vineyard = int(input())
grapes = float(input())
wine_needed = int(input())
workers = int(input())

total_grapes = vineyard * grapes
wine_produced = (0.40 * total_grapes) / 2.5
result = abs(wine_needed - wine_produced)

result_workers_wine = abs(result / workers)

if wine_produced < wine_needed:
    print(f"It will be a tough winter! More {math.floor(result)} liters wine needed.")
else:
    print(f"Good harvest this year! Total wine: {math.floor(wine_produced)} liters.")
    print(f"{math.ceil(result)} liters left -> {math.ceil(result_workers_wine)} liters per person.")