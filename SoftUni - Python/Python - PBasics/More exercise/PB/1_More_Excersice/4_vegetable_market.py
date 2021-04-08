price_kg_vegetables = float(input())
price_kg_fruits = float(input())
kg_vegetables = int(input())
kg_fruits = int(input())

vegetable = price_kg_vegetables * kg_vegetables
fruits = price_kg_fruits * kg_fruits
total_price = vegetable + fruits
euro =total_price / 1.94

print(f"{euro:.2f}")