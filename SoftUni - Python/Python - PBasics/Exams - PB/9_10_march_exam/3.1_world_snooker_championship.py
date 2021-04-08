stage_championship = input()
ticket_type = input()
tickets_count = int(input())
picture_trophy = input()

total_price = 0

if stage_championship == "Quarter final":
    if ticket_type == "Standard":
        total_price = 55.50 * tickets_count
    elif ticket_type == "Premium":
        total_price = 105.20 * tickets_count
    elif ticket_type == "VIP":
        total_price = 118.90 * tickets_count
elif stage_championship == "Semi final":
    if ticket_type == "Standard":
        total_price = 75.88 * tickets_count
    elif ticket_type == "Premium":
        total_price = 125.22 * tickets_count
    elif ticket_type == "VIP":
        total_price = 300.40 * tickets_count
elif stage_championship == "Final":
    if ticket_type == "Standard":
        total_price = 110.10 * tickets_count
    elif ticket_type == "Premium":
        total_price = 160.66 * tickets_count
    elif ticket_type == "VIP":
        total_price = 400 * tickets_count
if total_price > 4000:
    total_price = total_price * 0.75
    print(f"{total_price:.2f}")
elif total_price > 2500:
    total_price = total_price * 0.90
    if picture_trophy == "Y":
        total_price += 40 * tickets_count
        print(f"{total_price:.2f}")
    else:
        print(f"{total_price:.2f}")
else:
    if picture_trophy == "Y":
        total_price += 40 * tickets_count
        print(f"{total_price:.2f}")
    else:
        print(f"{total_price:.2f}")