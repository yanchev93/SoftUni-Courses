#•	Магнолии – 3.25 лева
#•	Зюмбюли – 4 лева
#•	Рози – 3.50 лева
#•	Кактуси – 8 лева
import math
magnolias = int(input()) * 3.25
hyacinth = int(input()) * 4
roses = int(input()) * 3.50
cacti = int(input()) * 8
price_present = float(input())

result_flowers_sold = (magnolias + hyacinth + roses + cacti) * 0.95
result = abs(result_flowers_sold - price_present)
if result_flowers_sold >= price_present:
    print(f"She is left with {math.floor(result)} leva.")
else:
    print(f"She will have to borrow {math.ceil(result)} leva.")