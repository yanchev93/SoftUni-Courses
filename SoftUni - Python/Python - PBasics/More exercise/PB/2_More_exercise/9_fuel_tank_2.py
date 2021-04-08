fuel = input().lower()
fuel_quantity = float(input())
club_card = input().lower()

gasoline = 2.22
diesel = 2.33
gas = 0.93

gasoline_card = gasoline - 0.18
diesel_card = diesel - 0.12
gas_card = gas - 0.08

gasoline_no_card = gasoline * fuel_quantity
diesel_no_card = diesel * fuel_quantity
gas_no_card = gas * fuel_quantity

refuel_gasoline = fuel_quantity * gasoline_card
refuel_diesel = fuel_quantity * diesel_card
refuel_gas = fuel_quantity * gas_card

result = 0

if (fuel == "gas" or fuel == "diesel" or fuel == "gasoline") and fuel_quantity < 20 and club_card == "yes":
    if fuel == "gas":
        result = refuel_gas
        print(f"{result:.2f} lv.")
    elif fuel == "diesel":
        result = refuel_diesel
        print(f"{result:.2f} lv.")
    elif fuel == "gasoline":
        result = refuel_gasoline
        print(f"{result:.2f} lv.")
elif (fuel == "gas" or fuel == "diesel" or fuel == "gasoline") and fuel_quantity < 20 and club_card == "no":
    if fuel == "gas":
        result = gas_no_card
        print(f"{result:.2f} lv.")
    elif fuel == "diesel":
        result = diesel_no_card
        print(f"{result:.2f} lv.")
    elif fuel == "gasoline":
        result = gasoline_no_card
        print(f"{result:.2f} lv.")
elif (fuel == "gas" or fuel == "diesel" or fuel == "gasoline") and 20 <= fuel_quantity <= 25 and club_card == "yes":
    if fuel == "gas":
        result = refuel_gas * 0.92
        print(f"{result:.2f} lv.")
    elif fuel == "diesel":
        result = refuel_diesel * 0.92
        print(f"{result:.2f} lv.")
    elif fuel == "gasoline":
        result = refuel_gasoline * 0.92
        print(f"{result:.2f} lv.")
elif (fuel == "gas" or fuel == "diesel" or fuel == "gasoline") and 20 <= fuel_quantity <= 25 and club_card == "no":
    if fuel == "gas":
        result = gas_no_card * 0.92
        print(f"{result:.2f} lv.")
    elif fuel == "diesel":
        result = diesel_no_card * 0.92
        print(f"{result:.2f} lv.")
    elif fuel == "gasoline":
        result = gasoline_no_card * 0.92
        print(f"{result:.2f} lv.")
elif (fuel == "gas" or fuel == "diesel" or fuel == "gasoline") and fuel_quantity > 25 and club_card == "yes":
    if fuel == "gas":
        result = refuel_gas * 0.90
        print(f"{result:.2f} lv.")
    elif fuel == "diesel":
        result = refuel_diesel * 0.90
        print(f"{result:.2f} lv.")
    elif fuel == "gasoline":
        result = refuel_gasoline * 0.90
        print(f"{result:.2f} lv.")
elif (fuel == "gas" or fuel == "diesel" or fuel == "gasoline") and fuel_quantity > 25 and club_card == "no":
    if fuel == "gas":
        result = gas_no_card * 0.90
        print(f"{result:.2f} lv.")
    elif fuel == "diesel":
        result = diesel_no_card * 0.90
        print(f"{result:.2f} lv.")
    elif fuel == "gasoline":
        result = gasoline_no_card * 0.90
        print(f"{result:.2f} lv.")