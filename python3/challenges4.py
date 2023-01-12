#Write your function here
def divisible_by_ten(nums):
  i = 0
  for num in nums
    if num % 10 == 0:
      i+=1
  return i

#Uncomment the line below when your function is done
print(divisible_by_ten([20, 25, 30, 35, 40]))

#Write your function here
def add_greetings(names):
  names = ["Hello, " + name for name in names]
  return names
#Uncomment the line below when your function is done
print(add_greetings(["Owen", "Max", "Sophie"]))

#Write your function here
def delete_starting_evens(lst):
  start = 0
  for i in range(len(lst)):
     if lst[i] % 2 == 0:
       continue
     else:
       start +=i
       break
  if start == 0 and lst[0] % 2 == 0:
    lst = []
    return lst
  return lst[start:]


#Uncomment the lines below when your function is done
print(delete_starting_evens([4, 8, 10, 11, 12, 15]))
print(delete_starting_evens([4, 8, 10]))

#odd indices
#Write your function here
def odd_indices(lst):
  new_list = [lst[i] for i in range(len(lst)) if i % 2 != 0]
  return new_list

#Uncomment the line below when your function is done
print(odd_indices([4, 3, 7, 10, 11, -2]))


#Write your function here
def exponents(bases, powers):
  exps = []
  for i in bases:
    for j in powers:
      exps.append(i ** j)
  return exps
#Uncomment the line below when your function is done
print(exponents([2, 3, 4], [1, 2, 3]))

#Write your function here
def larger_sum(lst1, lst2):
  count1 = 0
  count2 = 0
  for i in lst1:
    count1 += i
  for i in lst2:
    count2 += i
  if count1 == count2 or count1 > count2:
    return lst1
  else:
    return lst2

#Uncomment the line below when your function is done
print(larger_sum([1, 9, 5], [2, 3, 7]))

#Write your function here
def over_nine_thousand(lst):
  sum = 0
  for i in lst:
    if sum > 9000:
      break
    sum += i;
  return sum
#Uncomment the line below when your function is done
print(over_nine_thousand([8000, 900, 120, 5000]))

#max function
#Write your function here
def max_num(nums):
  x = max(nums)
  return x

#Uncomment the line below when your function is done
print(max_num([50, -10, 0, 75, 20]))

#return index list

#Write your function here
def same_values(lst1, lst2):
  lst3 = [i for i in range(len(lst1)) if lst1[i] == lst2[i]]
  return lst3

#Uncomment the line below when your function is done
print(same_values([5, 1, -10, 3, 3], [5, 10, -10, 3, 5]))


#Write your function here
def reversed_list(lst1, lst2):
  lst2.reverse()
  if lst1 == lst2:
    return True
  else:
    return False
#lst2.reverse()
#lst2[::-1]
#Uncomment the lines below when your function is done
print(reversed_list([1, 2, 3], [3, 2, 1]))
print(reversed_list([1, 5, 3], [3, 2, 1]))
