name_actor = input()
points_from_academy = float(input())
evaluators = int(input())

points_count = points_from_academy

for points in range(1, evaluators+1):
    name_evaluator = len(input())
    points_evaluator = float(input())
    points_count += (name_evaluator * points_evaluator) / 2
    if points_count > 1250.5:
        print(f"Congratulations, {name_actor} got a nominee for leading role with {points_count:.1f}!")
        break
if points_count < 1250.5:
    diff = 1250.5 - points_count
    print(f"Sorry, {name_actor} you need {diff:.1f} more!")
