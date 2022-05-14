import random as rand
from classes import Line2D, Line3D
import func

'''
n = 4
lines2D = []
for i in range(n - 1):
    lines2D.append(Line2D([rand.randint(0, 10), rand.randint(0, 10)], [rand.randint(0, 10), rand.randint(0, 10)]))
'''

lines2D = [
    Line2D([4, 5], [3, 2]),
    Line2D([1, 6], [5, 7]),
    Line2D([8, 5], [5, 6]),
    Line2D([1, 8], [2, 3])
]
func.lines_out(lines2D, "\nGenerated 2D lines:")
point2D = [2, 7]
result = func.point_check(lines2D, point2D)
if result[0]:
    print(f"Point M {func.point_string(point2D)} belongs to line #{result[1] + 1}: {lines2D[result[1]]}, "
          f"which is perpendicular to line #1: {lines2D[0]}")

'''
lines3D = []
for i in range(n - 1):
    lines3D.append(Line3D([rand.randint(0, 10), rand.randint(0, 10), rand.randint(0, 10)],
                          [rand.randint(0, 10), rand.randint(0, 10), rand.randint(0, 10)]))
'''

lines3D = [
    Line3D([4, 5, 2], [3, 2, 3]),
    Line3D([8, 5, 2], [5, 6, 2]),
    Line3D([4, 7, 2], [3, 4, 3]),
    Line3D([4, 3, 2], [3, 0, 3]),
]
func.lines_out(lines3D, "\nGenerated 3D lines:")
result = func.line_check(lines3D)
if result[0]:
    print(f"Line #{result[1] + 1}: {lines3D[result[1]]} is perpendicular to all other lines")
