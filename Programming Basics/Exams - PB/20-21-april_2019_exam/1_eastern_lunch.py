kozunak = int(input())
eggs = int(input())
kurabii = int(input())

kozunaci_price = kozunak * 3.20
qica_price = eggs * 4.35
kurabii_price = kurabii * 5.40
paint_eggs_price = eggs * 12 * 0.15

total = kozunaci_price + qica_price + kurabii_price + paint_eggs_price

print(f"{total:.2f}")