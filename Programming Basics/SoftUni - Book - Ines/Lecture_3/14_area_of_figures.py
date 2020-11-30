import math

figures = input()

area = 0
a = float(input())

if figures == "square":
    area = a * a
elif figures == "rectangle":
    b = float(input())
    area = a * b
elif figures == "circle":
    area = math.pi * math.pow(a, 2)
elif figures == "triangle":
    h = float(input())
    area = (a*h)/2
print("%.3f" % area)

# "%.3f" % area - дробно число с изписване до третия знак след запетаята "%.3f" % 0.123, еxample "%.6f" % = 0.123456, %.10f % = 0.1234567890
