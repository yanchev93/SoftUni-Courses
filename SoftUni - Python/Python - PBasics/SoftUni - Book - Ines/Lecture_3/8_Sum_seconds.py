runner1 = int(input())
runner2 = int(input())
runner3 = int(input())

result = runner1 + runner2 + runner3

minutes = result // 60
seconds = result % 60

if seconds < 10:
    print(f"{minutes}:0{seconds}")
else:
    print(f"{minutes}:{seconds}")