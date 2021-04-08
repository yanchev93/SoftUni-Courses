available_eggs = int(input())

total_sold = 0
command = input()
while command != "Close":
    action = command
    eggs_action = int(input())

    if eggs_action > available_eggs and command == "Buy":
        print("Not enough eggs in store!")
        print(f"You can buy only {available_eggs}.")
        break
    if action == "Buy":
        total_sold += eggs_action
        available_eggs -= eggs_action
    else:
        available_eggs += eggs_action
    command = input()
else:
    print("Store is closed!")
    print(f"{total_sold} eggs sold.")