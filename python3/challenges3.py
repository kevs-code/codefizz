#Write your function here 3 fibonacci steps
def append_sum(lst):
  for i in range(3):
    fibonacci_step = lst[-1] + lst[-2]
    lst.append(fibonacci_step)
  return lst

#Uncomment the line below when your function is done
print(append_sum([1, 1, 2]))
#[1, 1, 2, 3, 5, 8]

#return last element of longer list or lst1 if both same length

#Write your function here
def larger_list(lst1, lst2):
  if len(lst1) == len(lst2) or len(lst1) > len(lst2):
    return lst1[-1]
  else:
    return lst2[-1]

#Uncomment the line below when your function is done
print(larger_list([4, 10, 2, 5], [-10, 2, 5, 10]))

#if item appears in list more than n times return true
#Write your function here
def more_than_n(lst, item, n):
  if lst.count(item) > n:
    return True
  else:
    return False
#Uncomment the line below when your function is done
print(more_than_n([2, 4, 6, 2, 3, 2, 1, 2], 2, 3))

#append current length of list to list

#Write your function here
def append_size(lst):
 lst.append(len(lst))
 return lst

#Uncomment the line below when your function is done
print(append_size([23, 42, 108]))

#combine 2 lists and sort them

#Write your function here
def combine_sort(lst1, lst2):
  lst3 = sorted(lst1 + lst2)
  return lst3

#Uncomment the line below when your function is done
print(combine_sort([4, 10, 2, 5], [-10, 2, 5, 10]))

#every 3 numbers from start to 100 included

#Write your function here
def every_three_nums(start):
  lst = list(range(start, 101, 3))
  return lst

#Uncomment the line below when your function is done
print(every_three_nums(91))


#remove middle of list from start to end index included

#Write your function here
def remove_middle(lst, start, end):
  new_lst = lst[0:start] + lst[end+1:]
  return new_lst

#Uncomment the line below when your function is done
print(remove_middle([4, 8, 15, 16, 23, 42], 1, 3))

#which item appears most frequently in list if same return item1

def more_frequent_item(lst, item1, item2):
  if lst.count(item1) == lst.count(item2) or lst.count(item1) > lst.count(item2):
    return item1
  else:
    return item2
#Uncomment the line below when your function is done
print(more_frequent_item([2, 3, 3, 2, 3, 2, 3, 2, 3], 2, 3))

#double number at list index unless index out of range, return list

#Write your function here
def double_index(lst, index):
  if index < len(lst):
    lst[index] = lst[index] * 2
  return lst
  

#Uncomment the line below when your function is done
print(double_index([3, 8, -10, 12], 2))

#return median value if odd and avg of middle two if even

#Write your function here
def middle_element(lst):
  if len(lst) % 2 != 0:
    ind = round(len(lst)/2)
    return lst[ind]
  else:
    up = int(len(lst)/2 + 0.5)
    low = int(len(lst)/2 - 0.5)
    avg = (lst[up] + lst[low])/2
    return avg


#Uncomment the line below when your function is done
print(middle_element([5, 2, -10, -4, 4, 5]))
print(middle_element([5, 2, -4, 4, 5]))
