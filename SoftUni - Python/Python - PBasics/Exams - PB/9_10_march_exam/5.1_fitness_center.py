entered_people = int(input())


back = 0
chest = 0
legs = 0
abs = 0
shake = 0
bar = 0

for people in range(1, entered_people+1):
    activity = input()
    if activity == "Back":
        back += 1
    elif activity == "Chest":
        chest += 1
    elif activity == "Legs":
        legs += 1
    elif activity == "Abs":
        abs += 1
    elif activity == "Protein shake":
        shake += 1
    else:
        bar += 1
training = ((back + chest + legs + abs) / entered_people) * 100
product = ((shake + bar) / entered_people) * 100
print(f"{back} - back")
print(f"{chest} - chest")
print(f"{legs} - legs")
print(f"{abs} - abs")
print(f"{shake} - protein shake")
print(f"{bar} - protein bar")
print(f"{training:.2f}% - work out")
print(f"{product:.2f}% - protein")