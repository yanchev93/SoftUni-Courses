eggs_painted = int(input())

red = 0
orange = 0
blue = 0
green = 0
max = 0

for i in range(1, eggs_painted+1):
    egg = input()

    if egg == "red":
        red += 1
    elif egg == "orange":
        orange += 1
    elif egg == "blue":
        blue += 1
    else:
        green += 1

print(f"Red eggs: {red}")
print(f"Orange eggs: {orange}")
print(f"Blue eggs: {blue}")
print(f"Green eggs: {green}")
if red > orange and red > blue and red > green:
    print(f"Max eggs: {red} -> red")
elif orange > red and orange > blue and orange > green:
    print(f"Max eggs: {orange} -> orange")
elif blue > orange and blue > red and blue > green:
    print(f"Max eggs: {blue} -> blue")
elif green > orange and green > blue and green > red:
    print(f"Max eggs: {green} -> green")