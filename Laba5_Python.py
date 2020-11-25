import math

#Variant 22

res = int(0)
tmp = int(0)
for i in range(1000000, 10000000):
     res = 0
     tmp = i
     while tmp != 0:
         res = (res * 10) + (tmp % 10)
         tmp = int(tmp/10)
     if res == i:
          print(i)
