v = int(input())
p1 = int(input())
p2 = int(input())
h = float(input())

p1 = p1 * h
p2 = p2 * h
total_water = (p1 + p2)

percent_water = (total_water / v) * 100
p_w = percent_water * 1
p_1 = (p1 / total_water) * 100
p_2 = (p2 / total_water) * 100


if total_water <= v:
    print(f"The pool is {p_w:.2f}% full. Pipe 1: {p_1:.2f}%. Pipe 2: {p_2:.2f}%.")
else:
    print(f"For {h:.2f} hours the pool overflows with {(total_water - v):.2f} liters.")