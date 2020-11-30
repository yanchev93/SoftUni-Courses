command = input()

best_name = ""
best_goals = 0
while command != "END":
    name = command
    goals = int(input())
    if goals > best_goals:
        best_name = name
        best_goals = goals
    if goals >= 10:
        break
    command = input()
print(f"{best_name} is the best player!")
if best_goals >= 3:
    print(f"He has scored {best_goals} goals and made a hat-trick !!!")
else:
    print(f"He has scored {best_goals} goals.")