x = float(input())
y = float(input())
h = float(input())

#walls
side_wall = x * y
window = 1.5 * 1.5
two_walls = 2 * side_wall - 2*window
back_wall = x * x
door = 1.2 * 2
front_back_walls = 2 * back_wall - door

down_part_house = two_walls + front_back_walls
#roof
both_squares = 2 * (x * y)
both_triangles = 2 * (x * h /2)

roof_part_house = both_squares + both_triangles

paint_down = down_part_house / 3.4
paint_roof = roof_part_house / 4.3

print(f"{paint_down:.2f}")
print(f"{paint_roof:.2f}")