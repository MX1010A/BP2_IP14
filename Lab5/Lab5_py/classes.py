import abc


class Line:
    coordinatesA = []
    coordinatesB = []

    # конструктор з параметрами
    def __init__(self, coordinates_a, coordinates_b):
        self.coordinatesA = coordinates_a
        self.coordinatesB = coordinates_b

    # зведення прямої до вектора
    def vector_coordinates(self):
        vector_coords = []
        for i in range(len(self.coordinatesA)):
            vector_coords.append(self.coordinatesB[i] - self.coordinatesA[i])
        return vector_coords

    # представлення атрибутів об'єкта у вигляді рядка
    def __str__(self):
        coords_a = [str(i) for i in self.coordinatesA]
        coords_b = [str(i) for i in self.coordinatesB]
        return f"A ({'; '.join(coords_a)}), B ({'; '.join(coords_b)})"

    # перевірка паралельності двох ліній
    @abc.abstractmethod
    def is_parallel(self, line):
        pass

    # перевірка перпендикулярності двох ліній
    @abc.abstractmethod
    def is_perpendicular(self, line):
        pass

    # перевірка належності точки до прямої
    @abc.abstractmethod
    def point_belongs(self, line):
        pass


class Line2D(Line):
    def is_parallel(self, line):
        return self.vector_coordinates()[0] / line.vector_coordinates()[0] == \
               self.vector_coordinates()[1] / line.vector_coordinates()[1]

    def is_perpendicular(self, line):
        return self.vector_coordinates()[0] * line.vector_coordinates()[0] + \
               self.vector_coordinates()[1] * line.vector_coordinates()[1] == 0

    def point_belongs(self, coordinates_p):
        return self.is_parallel(Line2D(self.coordinatesA, coordinates_p))


class Line3D(Line):
    def is_parallel(self, line):
        return self.vector_coordinates()[0] / line.vector_coordinates()[0] == \
               self.vector_coordinates()[1] / line.vector_coordinates()[1] and \
               self.vector_coordinates()[0] / line.vector_coordinates()[0] == \
               self.vector_coordinates()[2] / line.vector_coordinates()[2]

    def is_perpendicular(self, line):
        return self.vector_coordinates()[0] * line.vector_coordinates()[0] + \
               self.vector_coordinates()[1] * line.vector_coordinates()[1] + \
               self.vector_coordinates()[2] * line.vector_coordinates()[2] == 0

    def point_belongs(self, coordinates_p):
        return self.is_parallel(Line3D(self.coordinatesA, coordinates_p))
