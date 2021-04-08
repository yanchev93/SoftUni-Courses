name = input()
adults_tickets = int(input())
child_tickets = int(input())
net_price_adult_tickets = float(input())
tax = float(input())

net_child = (net_price_adult_tickets * 0.30)
net_adult = net_price_adult_tickets + tax
total_child = net_child + tax
total_tickets = (adults_tickets * net_adult) + (child_tickets * total_child)
profit = total_tickets * 0.20

print(f"The profit of your agency from {name} tickets is {profit:.2f} lv.")