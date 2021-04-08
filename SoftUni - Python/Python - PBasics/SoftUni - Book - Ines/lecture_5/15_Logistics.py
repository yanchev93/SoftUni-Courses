cargo = int(input())

sum = 0
bus = 0
truck = 0
train = 0

for price in range(1, cargo+1):
    current_tone = int(input())
    sum += current_tone
    if current_tone <= 3:
        bus += current_tone
    elif 3 < current_tone <= 11:
        truck += current_tone
    else:
        train += current_tone

average_price = (bus*200 + truck*175 + train*120) / sum
bus = bus / sum * 100
truck = truck / sum * 100
train = train / sum * 100

print(f"{average_price:.2f}")
print(f"{bus:.2f}%")
print(f"{truck:.2f}%")
print(f"{train:.2f}%")