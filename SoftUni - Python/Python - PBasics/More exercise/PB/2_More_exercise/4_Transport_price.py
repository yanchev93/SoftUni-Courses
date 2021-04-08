km = int(input())
day_night = input()

taxi_start = 0.70
taxi_day = 0.79
taxi_night = 0.90
taxi_day = taxi_start + (km * taxi_day)
taxi_night = taxi_start + (km * taxi_night)

bus = 0.09
bus_trip = km * bus

train = 0.06
train_trip = km * train

if km < 20 and day_night == "day":
    print(f"{taxi_day:.2f}")
elif km < 20 and day_night == "night":
    print(f"{taxi_night:.2f}")
elif 20 <= km < 100:
    print(f"{bus_trip:.2f}")
else:
    print(f"{train_trip:.2f}")