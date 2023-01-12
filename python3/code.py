def greater_than(x, y):
  if x == y:
    return "These numbers are the same"
  if x > y:
    return x
  else:
    return y

def graduation_reqs(credits):
  if credits >= 120:
    return "You have enough credits to graduate!"

print(graduation_reqs(120))

# returns once so ...
statement_one = False

statement_two = True

def graduation_reqs(gpa, credits):
  if (gpa >= 2.0) and (credits >= 120):
    return "You meet the requirements to graduate!"
  if (gpa >= 2.0) and (credits < 120):
    return "You do not have enough credits to graduate."
  if (gpa < 2.0) and (credits >= 120):
    return "Your GPA is not high enough to graduate."
  return "You do not meet either requirement to graduate!"

#for the same reason you could use else and the end plus refactored with not

def graduation_reqs(gpa, credits):
  if (gpa >= 2.0) and (credits >= 120):
    return "You meet the requirements to graduate!"
  if (gpa >= 2.0) and not (credits >= 120):
    return "You do not have enough credits to graduate."
  if not (gpa >= 2.0) and (credits >= 120):
    return "Your GPA is not high enough to graduate."
  else:
    return "You do not meet the GPA or the credit requirement for graduation."

#meh
def grade_converter(gpa):
  if gpa >= 4:
    return 'A'
  elif gpa >= 3:
    return 'B'
  elif gpa >= 2:
    return 'C'
  elif gpa >= 1:
    return 'D'
  else:
    return 'F'

def raises_value_error():
  raise ValueError

raises_value_error()


try:
  raises_value_error()
except ValueError:
  print ("You raised a ValueError!")


def divides(a,b):
  try:
    result = a / b
    print (result)
  except ZeroDivisionError:
    print ("Can't divide by zero!")

