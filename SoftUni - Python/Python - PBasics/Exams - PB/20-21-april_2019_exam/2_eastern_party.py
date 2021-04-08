guests = int(input())
price_per_guest = float(input())
budget_desi = float(input())

cake = budget_desi * 0.10

if 10 <= guests <= 15:
    price_per_guest *= 0.85
elif 15 < guests <= 20:
    price_per_guest *= 0.80
elif guests > 20:
    price_per_guest *= 0.75

total = guests * price_per_guest + cake
diff = abs(total - budget_desi)

if budget_desi > total:
    print(f"It is party time! {diff:.2f} leva left.")
else:
    print(f"No party! {diff:.2f} leva needed.")