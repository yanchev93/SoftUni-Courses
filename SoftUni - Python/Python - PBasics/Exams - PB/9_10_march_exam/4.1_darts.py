name_player = input()

available_points = 301
successful_thrown = 0
unsuccessful_thrown = 0
command = input()
while command != "Retire":
    text = command
    points = int(input())

    if text == "Single":
        check_points = points
        if check_points > available_points:
            unsuccessful_thrown += 1
            command = input()
            continue
        successful_thrown += 1
        available_points -= points
    elif text == "Double":
        check_points = points * 2
        if check_points > available_points:
            unsuccessful_thrown += 1
            command = input()
            continue
        successful_thrown += 1
        available_points -= points * 2
    else:
        check_points = points * 3
        if check_points > available_points:
            unsuccessful_thrown += 1
            command = input()
            continue
        successful_thrown += 1
        available_points -= points * 3

    if available_points == 0:
        print(f"{name_player} won the leg with {successful_thrown} shots.")
        break
    command = input()
else:
    print(f"{name_player} retired after {unsuccessful_thrown} unsuccessful shots.")