my_name = 'MR.MY_NAME'
first_initial = my_name[0]
#M
first_name = "Rodrigo"
last_name = "Villanueva"
#first five letters
new_account = last_name[:5]
#third to six letters
temp_password = last_name [2:6]

first_name = "Julie"
last_name = "Blevins"

def account_generator(first_name, last_name):
  new = first_name[:3] + last_name[:3]
  return new

new_account = account_generator(first_name, last_name)

first_name = "Reiko"
last_name = "Matsuki"

def password_generator(first_name, last_name):
  new = first_name[-3:] + last_name[-3:]
  return new
temp_password = password_generator(first_name, last_name)

company_motto = "Copeland's Corporate Company helps you capably cope with the constant cacophony of daily life"
second_to_last = company_motto[-2]
final_word = company_motto[-4:]

first_name = "Bob"
last_name = "Daily"

# first_name[0] = "R" won't work as string are immutable
fixed_first_name = "R" + first_name[1:]

# escape characters \

password = "theycallme\"crazy\"91"

#cycle string length without calling len()
def get_length(str):
  length = 0
  for i in str:
    length += 1
  return length

##meh

def letter_check(word, letter):
  for i in word:
    if i == letter:
      return True
  return False
# else not needed as only one return

def contains(big_string, little_string):
  if little_string in big_string:
    return True
  return False

def common_letters(string_one, string_two):
  common = []
  for i in string_one:
    if i in string_two and i not in common:
      common.append(i)
  return common

def username_generator(first_name, last_name):
  if len(first_name) < 3 or len(last_name) < 4:
    username = first_name + last_name
  else:
    username = first_name[:3] + last_name[:4]
  return username

# shift word letter right using -1 si AbeSimp == pAbeSim
def password_generator(username):
  password = ''
  for i in range(len(username)):
    password += username[i-1]
  return password
