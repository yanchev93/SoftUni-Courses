junior_cyclists = int(input())
senior_cyclists = int(input())
trace = input()

tax = 0
total_cyclists = junior_cyclists + senior_cyclists
costs = 0

if trace == "trail":
    tax = junior_cyclists * 5.5 + senior_cyclists * 7
    costs = tax - (tax * 0.05)
elif trace == "cross-country":
    tax = junior_cyclists * 8 + senior_cyclists * 9.5
    costs = tax - (tax * 0.05)
    if total_cyclists >= 50:
        costs -= costs * 0.25
elif trace == "downhill":
    tax = junior_cyclists * 12.25 + senior_cyclists * 13.75
    costs = tax - (tax * 0.05)
elif trace == "road":
    tax = junior_cyclists * 20 + senior_cyclists * 21.5
    costs = tax - (tax * 0.05)

print(f"{costs:.2f}")
