number = float(input())
in_range = (number >= 100 and number <= 200) or number == 0

if not in_range:
    print("invalid")
