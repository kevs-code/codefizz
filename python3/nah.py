##awful solution

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
