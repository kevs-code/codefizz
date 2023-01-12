letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
# Write your unique_english_letters function here:
def unique_english_letters(word):
  count = 0
  for i in letters:
    if i in word:
      count += 1
  return count

# Uncomment these function calls to test your function:
print(unique_english_letters("mississippi"))
# should print 4
print(unique_english_letters("Apple"))
# should print 4


# Write your count_char_x function here:
def count_char_x(word, x):
  return word.count(x)
# Uncomment these function calls to test your tip function:
print(count_char_x("mississippi", "s"))
# should print 4
print(count_char_x("mississippi", "m"))
# should print 1

# function above works for multi_char so repeat
# Write your count_multi_char_x function here:
def count_multi_char_x(word, x):
  return word.count(x)
# Uncomment these function calls to test your function:
print(count_multi_char_x("mississippi", "iss"))
# should print 2
print(count_multi_char_x("apple", "pp"))
# should print 1

# Write your substring_between_letters function here:
def substring_between_letters(word, start, end):
  first = 0
  last = None
  if start in word and end in word:
    first = word.find(start) + 1
    last = word.find(end)
    return word[first:last]
  if end in word:
    last = word.find(end)
  return word[first:last]  

# Uncomment these function calls to test your function:
print(substring_between_letters("apple", "p", "e"))
# should print "pl"
print(substring_between_letters("apple", "p", "c"))
# should print "apple"

# better

# Write your substring_between_letters function here:
def substring_between_letters(word, start, end):
  first = 0
  last = None
  if start in word and end in word:
    first = word.find(start) + 1
  if end in word:
    last = word.find(end)
  return word[first:last]  

# Uncomment these function calls to test your function:
print(substring_between_letters("apple", "p", "e"))
# should print "pl"
print(substring_between_letters("apple", "p", "c"))
# should print "apple"
print(substring_between_letters("apple", "q", "e"))
# should print "appl"

# every word in sentence greater or equal length to x
# Write your x_length_words function here:
def x_length_words(sentence, x):
  y = sentence.split(' ');
  y_length_words = [i for i in y if len(i) >= x]
  if len(y_length_words) == len(y):
    return True
  return False

# Uncomment these function calls to test your tip function:
print(x_length_words("i like apples", 2))
# should print False
print(x_length_words("he likes apples", 2))
# should print True

# check name in sentence in any case
# Write your check_for_name function here:
def check_for_name(sentence, name):
  if name.lower() in sentence.lower():
    return True
  return False

# Uncomment these function calls to test your  function:
print(check_for_name("My name is Jamie", "Jamie"))
# should print True
print(check_for_name("My name is jamie", "Jamie"))
# should print True
print(check_for_name("My name is Samantha", "Jamie"))
# should print False

#every other letter

# Write your every_other_letter function here:
def every_other_letter(word):
  fill_str = ''
  for i in range(len(word)):
    if i % 2 != 0:
      continue
    fill_str += word[i]
  return fill_str
# Uncomment these function calls to test your function:
print(every_other_letter("Codecademy"))
# should print Cdcdm
print(every_other_letter("Hello world!"))
# should print Hlowrd
print(every_other_letter(""))
# should print 

# Write your reverse_string function here:
def reverse_string(word):
  rewind = word[::-1]
  return rewind
# Uncomment these function calls to test your  function:
print(reverse_string("Codecademy"))
# should print ymedacedoC
print(reverse_string("Hello world!"))
# should print !dlrow olleH
print(reverse_string(""))
# should print

#spoon word like Reanu Keeves

# Write your make_spoonerism function here:
def make_spoonerism(word1, word2):
  first = word2[0]
  second = word1[0]
  spword1 = first + word1[1:]
  spword2 = second + word2[1:]
  return '{} {}'.format(spword1, spword2)
# Uncomment these function calls to test your function:
print(make_spoonerism("Codecademy", "Learn"))
# should print Lodecademy Cearn
print(make_spoonerism("Hello", "world!"))
# should print wello Horld!
print(make_spoonerism("a", "b"))
# should print b a

#make length to 20 with !

# Write your add_exclamation function here:
def add_exclamation(word):
  if len(word) < 20:
    num = 20 - len(word)
    word = word + '!' * num
  return word
# Uncomment these function calls to test your function:
print(add_exclamation("Codecademy"))
# should print Codecademy!!!!!!!!!!
print(add_exclamation("Codecademy is the best place to learn"))
# should print Codecademy is the best place to learn
