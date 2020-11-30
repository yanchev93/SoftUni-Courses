minutes = int(input())
walks_per_day = int(input())
calories_taken_per_day = int(input())

walks = minutes * walks_per_day
calories = walks * 5
percent = calories_taken_per_day * 0.50
if calories >= percent:
    print(f"Yes, the walk for your cat is enough. Burned calories per day: {calories}.")
else:
    print(f"No, the walk for your cat is not enough. Burned calories per day: {calories}.")
