# Write your large_power function here:
def large_power(base, exponent):
  if base ** exponent > 5000:
    return True
  else:
    return False
# Uncomment these function calls to test your large_power function:
print(large_power(2, 13))
# should print True
print(large_power(2, 12))
# should print False

# Write your over_budget function here:
def over_budget(budget, food_bill, electricity_bill, internet_bill, rent):
  if budget < (food_bill + electricity_bill + internet_bill + rent):
    return True
  else:
    return False
# Uncomment these function calls to test your over_budget function:
print(over_budget(100, 20, 30, 10, 40))
# should print False
print(over_budget(80, 20, 30, 10, 30))
# should print True

# Write your twice_as_large function here:
def twice_as_large(num1, num2):
  if num1 > (num2 * 2):
    return True
  else:
    return False
# Uncomment these function calls to test your twice_as_large function:
print(twice_as_large(10, 5))
# should print False
print(twice_as_large(11, 5))
# should print True

# Write your divisible_by_ten function here:
def divisible_by_ten(num):
  if num % 10 == 0:
    return True
  else:
    return False
# Uncomment these function calls to test your divisible_by_ten function:
print(divisible_by_ten(20))
# should print True
print(divisible_by_ten(25))
# should print False


# Write your not_sum_to_ten function here:
def not_sum_to_ten(num1, num2):
  if (num1 + num2) != 10:
    return True
  else:
    return False
# Uncomment these function calls to test your not_sum_to_ten function:
print(not_sum_to_ten(9, -1))
# should print True
print(not_sum_to_ten(9, 1))
# should print False
print(not_sum_to_ten(5,5))
# should print False

# Write your in_range function here:
def in_range(num, lower, upper):
  if num >= lower and num <= upper:
    return True
  else:
    return False
# Uncomment these function calls to test your in_range function:
print(in_range(10, 10, 10))
# should print True
print(in_range(5, 10, 20))
# should print False

# Write your same_name function here:
def same_name(your_name, my_name):
  if your_name == my_name:
    return True
  else:
    return False
# Uncomment these function calls to test your same_name function:
print(same_name("Colby", "Colby"))
# should print True
print(same_name("Tina", "Amber"))
# should print False

# Write your always_false function here:
def always_false(num):
  if num > 3 and num < 3:
    return True
  else:
    return False
# Uncomment these function calls to test your always_false function:
print(always_false(0))
# should print False
print(always_false(-1))
# should print False
print(always_false(1))
# should print False

# Write your movie_review function here:
def movie_review(rating):
  if rating <= 5:
    return "Avoid at all costs!"
  if rating > 5 and rating < 9:
    return "This one was fun."
  if rating >= 9:
    return  "Outstanding!"
# Uncomment these function calls to test your movie_review function:
print(movie_review(9))
# should print "Outstanding!"
print(movie_review(4))
# should print "Avoid at all costs!"
print(movie_review(6))
# should print "This one was fun."

# Write your max_num function here:
# this is a lame way to write an answer here
# e.g., max in array then counta better

def max_num(num1, num2, num3):
  if num1 > num2 and num1 > num3:
    return num1
  if num2 > num1 and num2 > num3:
    return num2
  if num3 > num1 and num3 > num2:
    return num3
  else:
    return "It's a tie"
# Uncomment these function calls to test your max_num function:
print(max_num(-10, 0, 10))
# should print 10
print(max_num(-10, 5, -30))
# should print 5
print(max_num(-5, -10, -10))
# should print -5
print(max_num(2, 3, 3))
# should print "It's a tie!"
