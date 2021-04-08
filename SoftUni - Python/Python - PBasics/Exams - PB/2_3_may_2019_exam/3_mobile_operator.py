contract = input()
contract_type = input()
internet = input()
months_to_pay = int(input())

price = 0

if contract == "one":
    if contract_type == "Small":
        if internet == "yes":
            price = 9.98 + 5.50
            price *= months_to_pay
        else:
            price = months_to_pay * 9.98
    elif contract_type == "Middle":
        if internet == "yes":
            price = 18.99 + 4.35
            price *= months_to_pay
        else:
            price = months_to_pay * 18.99
    elif contract_type == "Large":
        if internet == "yes":
            price = 25.98 + 4.35
            price *= months_to_pay
        else:
            price = months_to_pay * 25.98
    else:
        if internet == "yes":
            price = 35.99 + 3.85
            price *= months_to_pay
        else:
            price = months_to_pay * 35.99
elif contract == "two":
    if contract_type == "Small":
        if internet == "yes":
            price = 8.58 + 5.50
            price *= months_to_pay
        else:
            price = months_to_pay * 8.58
    elif contract_type == "Middle":
        if internet == "yes":
            price = 17.09 + 4.35
            price *= months_to_pay
        else:
            price = months_to_pay * 17.09
    elif contract_type == "Large":
        if internet == "yes":
            price = 23.59 + 4.35
            price *= months_to_pay
        else:
            price = months_to_pay * 23.59
    else:
        if internet == "yes":
            price = 31.79 + 3.85
            price *= months_to_pay
        else:
            price = months_to_pay * 31.79
    price = price - price * 0.0375
print(f"{price:.2f} lv.")