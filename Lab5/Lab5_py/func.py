
# перевірка прямих списку на першу вказану властивість
def point_check(lines, point):
    for i in range(len(lines)):
        if lines[i].is_perpendicular(lines[0]):
            if lines[i].point_belongs(point):
                index = i
                return True, index
    return False, 0


# перевірка прямих списку на другу вказану властивість
def line_check(lines):
    for i in range(len(lines)):
        exists = False
        for line in lines:
            if lines[i] == line:
                continue
            exists = lines[i].is_perpendicular(line)
        if exists:
            index = i
            return True, index
    return False, 0


# виведення масиву прямих
def lines_out(lines, comment):
    print(comment)
    for i in range(len(lines)):
        print(f"Line #{i + 1}:\t{lines[i]}")
    print()


# перетворення координат точки у рядок
def point_string(point):
    point_str = [str(i) for i in point]
    return f"({'; '.join(point_str)})"
