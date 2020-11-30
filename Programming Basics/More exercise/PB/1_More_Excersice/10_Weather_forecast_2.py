t = float(input())

if 5.00 <= t <= 11.9:
    print("Cold")
elif 12.00 <= t <= 14.9:
    print("Cool")
elif 15.00 <= t <= 20.00:
    print("Mild")
elif 20.1 <= t <= 25.9:
    print("Warm")
elif 26.00 <= t <= 35.00:
    print("Hot")
else:
    print("unknown")