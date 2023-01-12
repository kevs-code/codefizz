with open('welcome.txt') as text_file:
  text_data = text_file.read()
print(text_data)

# lines loop

with open('how_many_lines.txt') as lines_doc:
  for line in lines_doc.readlines():
    print(line)

# firstline using readline instead of readlines

with open('just_the_first.txt') as first_line_doc:
  first_line = first_line_doc.readline()
  print(first_line)

# write

with open('bad_bands.txt', 'w') as bad_bands_doc:
  bad_bands_doc.write("Five")

# append

with open('cool_dogs.txt', 'a') as cool_dogs_file:
  cool_dogs_file.write("Air Buddy")

# aye matey refactor after ...

with open('fun_file.txt') as close_this_file:
  setup = close_this_file.readline()
  punchline = close_this_file.readline()

print(setup)
print(punchline)

# What did the pirate say when he turned 80?
# Aye Matey

# read all e.g,. csv file

with open('logger.csv') as log_csv_file:
  print(log_csv_file.read())

# csv module to read logger.csv 'Cool Fact' column

import csv

with open('cool_csv.csv') as cool_csv_file:
  cool_csv_dict = csv.DictReader(cool_csv_file)
  for row in cool_csv_dict:
    print(row['Cool Fact'])

# demo

import csv

with open('addresses.csv', newline='') as addresses_csv:
  address_reader = csv.DictReader(addresses_csv, delimiter=';')
  for row in address_reader:
    print(row['Address'])

#exercise

import csv
# , newline=''
with open('books.csv') as books_csv:
  books_reader = csv.DictReader(books_csv, delimiter='@')
  isbn_list = []
  for row in books_reader:
    isbn_list.append(row['ISBN'])


# csv logwriter

access_log = [{'time': '08:39:37', 'limit': 844404, 'address': '1.227.124.181'}, {'time': '13:13:35', 'limit': 543871, 'address': '198.51.139.193'}, {'time': '19:40:45', 'limit': 3021, 'address': '172.1.254.208'}, {'time': '18:57:16', 'limit': 67031769, 'address': '172.58.247.219'}, {'time': '21:17:13', 'limit': 9083, 'address': '124.144.20.113'}, {'time': '23:34:17', 'limit': 65913, 'address': '203.236.149.220'}, {'time': '13:58:05', 'limit': 1541474, 'address': '192.52.206.76'}, {'time': '10:52:00', 'limit': 11465607, 'address': '104.47.149.93'}, {'time': '14:56:12', 'limit': 109, 'address': '192.31.185.7'}, {'time': '18:56:35', 'limit': 6207, 'address': '2.228.164.197'}]
fields = ['time', 'address', 'limit']

import csv

with open('logger.csv', 'w') as logger_csv:
  # fields = ['time', 'limit', 'address']
  log_writer = csv.DictWriter(logger_csv, fieldnames=fields)
  log_writer.writeheader()
  for row in access_log:
    log_writer.writerow(row)

# read json with json module

import json

with open('message.json') as message_json:
  message = json.load(message_json)

print(message['text'])

# write json with json module

data_payload = [
  {'interesting message': 'What is JSON? A web application\'s little pile of secrets.',
   'follow up': 'But enough talk!'}
]

import json

with open('data.json', 'w') as data_json:
  json.dump(data_payload, data_json)
