import os

def line_count(file):
    with open(file, 'r',encoding="utf8") as fp:
        count = len(fp.readlines())
    return count


def comment_count(file):
    fp = open(file, 'r',encoding="utf8")
    data = fp.read()
    occurrences = data.count("NOTE:")
    return occurrences


def main():
    files = []
    dir_path = "C:\\Users\\eraye\\OneDrive\\Masaüstü\\cmpe\\code conversion\\gen2java\\ort\\yyy.gensrc"
    for path in os.listdir(dir_path):
        if os.path.isfile(os.path.join(dir_path, path)):
            files.append(path)
    print("File Lines Comments")
    for file in files:
        print(file, line_count(os.path.join(dir_path, file)), comment_count(os.path.join(dir_path, file)))

if __name__ == '__main__':
    main()