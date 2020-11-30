pencils_packs = int(input())
markers_packs = int(input())
detergent_l = float(input())
percent_discount = int(input())

pencils = pencils_packs * 5.80
markers = markers_packs * 7.20
detergent = detergent_l * 1.20

total = pencils + markers + detergent
total_with_discount = total - ((percent_discount * total) / 100)
print(f"{total_with_discount:.3f}")