import math
import pickle


def file_write(office_appliances, path, fm):  # запис даних у бінарний файл
    with open(path, fm) as file:
        for i in office_appliances:
            pickle.dump(i, file)


def file_read(path):  # читання даних з бінарного файлу
    office_appliances = []
    with open(path, "rb") as file:
        while True:
            try:
                office_appliances.append(pickle.load(file))
            except EOFError:
                break
    return office_appliances


def list_out(list, comment):  # виведення списку техніки
    print("\n", comment)
    for i in range(len(list)):
        print("{0}.".format(i + 1), list[i].string())


def list_sort(path1, path2):  # сортування техніки за гарантією
    list = file_read(path1)
    valid_list = []
    expired_list = []
    for i in range(len(list)):
        if list[i].is_warranty_expired():
            expired_list.append(list[i])
        else:
            valid_list.append(list[i])
            file_write(expired_list, path2, "wb")
    return valid_list