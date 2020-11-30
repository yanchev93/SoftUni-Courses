chicken_menu = int(input())
fish_menu = int(input())
vegetarian_menu = int(input())

chicken = chicken_menu * 10.35
fish = fish_menu * 12.40
vegetarian = vegetarian_menu * 8.15

total_cost = chicken + fish +vegetarian

desert = total_cost * 0.20

total_plus_delivery = desert + total_cost + 2.50

print(f"Total: {total_plus_delivery:.2f}")
