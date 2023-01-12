#sum of values

# Write your sum_values function here:
def sum_values(my_dictionary):
  sum = 0
  for v in my_dictionary.values():
    sum += v
  return sum
# Uncomment these function calls to test your sum_values function:
print(sum_values({"milk":5, "eggs":2, "flour": 3}))
# should print 10
print(sum_values({10:1, 100:2, 1000:3}))
# should print 6

#sum of even key values

# Write your sum_even_keys function here:
def sum_even_keys(my_dictionary):
  sum = 0
  for k, v in my_dictionary.que_values function here:
def unique_values(my_dictionary):
  seen_values = []
  for v in my_dictionary.values():
    if v not in seen_values:
      seen_values.append(v)
  return len(seen_values)


# Uncomment these function calls to test your  function:
print(unique_values({0:3, 1:1, 4:1, 5:3}))
# should print 2
print(unique_values({0:3, 1:3, 4:3, 5:3}))
# should print 1items():
    if k % 2 == 0:
      sum += v
  return sum
# Uncomment these function calls to test your  function:
print(sum_even_keys({1:5, 2:2, 3:3}))
# should print 2
print(sum_even_keys({10:1, 100:2, 1000:3}))
# should print 6

# add 10 to values in my_dictionary

# Write your add_ten function here:
def add_ten(my_dictionary):
  for k in my_dictionary.keys():
    my_dictionary[k] += 10
  return my_dictionary
# Uncomment these function calls to test your  function:
print(add_ten({1:5, 2:2, 3:3}))
# should print {1:15, 2:12, 3:13}
print(add_ten({10:1, 100:2, 1000:3}))
# should print {10:11, 100:12, 1000:13}

# return list of keys that also values in dictionary

# Write your values_that_are_keys function here:
def values_that_are_keys(my_dictionary):
  both = []
  for v in my_dictionary.values():
    for k in my_dictionary.keys():
      if v == k:
        both.append(k)
  return both
# Uncomment these function calls to test your  function:
print(values_that_are_keys({1:100, 2:1, 3:4, 4:10}))
# should print [1, 4]
print(values_that_are_keys({"a":"apple", "b":"a", "c":100}))
# should print ["a"]

# return key with largest value

# Write your max_key function here:
def max_key(my_dictionary):
  top = max(my_dictionary.values())
  for k, v in my_dictionary.items():
    if v == top:
      return k
# Uncomment these function calls to test your  function:
print(max_key({1:100, 2:1, 3:4, 4:10}))
# should print 1
print(max_key({"a":100, "b":10, "c":1000}))
# should print "c

# words in list as key, their lengths as value of new_dict

# Write your word_length_dictionary function here:
def word_length_dictionary(words):
  counts = []
  for i in words:
    counts.append(len(i))
  new_dict = {k:v for k, v in zip(words, counts)}
  return new_dict
# Uncomment these function calls to test your  function:
print(word_length_dictionary(["apple", "dog", "cat"]))
# should print {"apple":5, "dog": 3, "cat":3}
print(word_length_dictionary(["a", ""]))
# should print {"a": 1, "": 0}

# dict of word frequency in word list

# Write your frequency_dictionary function here:
def frequency_dictionary(words):
  new_dict = {}
  for word in words:
    new_dict[word] = words.count(word)
  return new_dict
# Uncomment these function calls to test your  function:
print(frequency_dictionary(["apple", "apple", "cat", 1]))
# should print {"apple":2, "cat":1, 1:1}
print(frequency_dictionary([0,0,0,0,0]))
# should print {0:5}

# bonus gives frequency of each value in dict

# Write your unique_values function here:
def unique_values(my_dictionary):
  seen_values = []
  for van in my_dictionary.values():
    print(sum(value == van for value in my_dictionary.values()))


# Uncomment these function calls to test your  function:
print(unique_values({0:3, 1:1, 4:1, 5:3}))
# should print 2
print(unique_values({0:3, 1:3, 4:3, 5:3}))
# should print 1

# counts of first letter of key(surname) that matches a first letter of value(firstname) across dictionary

# Write your count_first_letter function here:
def count_first_letter(names):
  firsts = []
  counts = []
  for k in names.keys():
    if k[0] not in firsts:
      firsts.append(k[0])
  for letter in firsts:
    count = 0
    for k, v in names.items():
        if k[0] == letter:
          count += len(v)
    counts.append(count)
  new_names = {k:v for k, v in zip(firsts, counts)}
  return new_names
# Uncomment these function calls to test your  function:
print(count_first_letter({"Stark": ["Ned", "Robb", "Sansa"], "Snow" : ["Jon"], "Lannister": ["Jaime", "Cersei", "Tywin"]}))
# should print {"S": 4, "L": 3}
print(count_first_letter({"Stark": ["Ned", "Robb", "Sansa"], "Snow" : ["Jon"], "Sannister": ["Jaime", "Cersei", "Tywin"]}))
# should print {"S": 7} 
