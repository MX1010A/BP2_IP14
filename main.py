import math


def text_input():  # запис тексту у файл
    print("\nEnter some text:\n")
    with open('file1_py.txt', 'a') as file:
        while True:
            line = input()

            if line != "" and line[0] == chr(19):  # 19 = CTRL + S
                break
            else:
                file.write(line + "\n")
        print()


def file_read(n):  # виведення вмісту файлу
    with open('file{0}_py.txt'.format(n), 'r') as file:
        print("\nText in file #{0}:\n\n".format(n) + file.read())


def file_recreate():  # створення нового файлу з форматованим текстом першого файлу
    str = ""
    with open('file1_py.txt', 'r') as file:
        sent = text_format(file.read().split('\n'))
    for i in range(len(sent) - 1):
        max = 0
        ind = 0
        word = sent[i].split(' ')
        for j in range(len(word)):
            length = len(word[j].strip(','))
            if length > max:
                max = length
                ind = j
        str += "[{0} - {1}]{2}{3}.\n".format(max, word[ind].strip(','), tab(max), sent[i])
    with open('file2_py.txt', 'w') as file:
        file.write(str + "\n")


def text_format(str):  # поділ тексту на речення
    s = ' '.join(str)
    str = s.split('.')
    for i in range(len(str)):
        str[i] = str[i].strip()
    return str


def tab(max):  # форматування табуляції
    tab = ""
    if 17 > max >= 13:
        rang = 1
    elif max <= 5:
        rang = 2
    else:
        rang = int(abs(math.floor(max / 10) - 2))
    for i in range(rang):
        tab += "\t"
    return tab


def main():
    text_input()
    file_read(1)
    file_recreate()
    file_read(2)


if __name__ == "__main__":
    main()
