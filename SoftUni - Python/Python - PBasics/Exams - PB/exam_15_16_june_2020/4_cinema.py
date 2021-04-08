capacity_hall = int(input())

count_people = 0
money = 0

command = input()
while command != "Movie time!":
    people = int(command)
    count_people += people

    if people % 3 == 0:
        money += ((people * 5) - 5)
    else:
        money += people * 5

    if capacity_hall < count_people:
        print(f"The cinema is full.")
        if people % 3 == 0:
            money -= ((people * 5) - 5)
        else:
            money -= people * 5
        break
    command = input()

if command == "Movie time!":
    diff_seats = capacity_hall - count_people
    print(f"There are {diff_seats} seats left in the cinema.")

print(f"Cinema income - {money} lv.")