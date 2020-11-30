fuel = input().lower()
number = int(input())

if (fuel == "diesel" or fuel == "gasoline" or fuel == "gas") and number >= 25:
    print(f"You have enough {fuel}.")
elif (fuel == "diesel" or fuel == "gasoline" or fuel == "gas") and number < 25:
    print(f"Fill your tank with {fuel}!")
else:
    print("Invalid fuel!")