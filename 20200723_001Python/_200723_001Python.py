"""a = 123
print(type(a))
a = 100 * 100
print(a)
a, b = 9, 2
print(a*b) """

"""a = "C#이 최고다"
print(a)
print(type(a))
b = 'C# is Best'
print(b)"""

"""
a,b,c,d = 0,0,0,0
hap = 0
a = int(input("1번째 숫자 : "))
b = int(input("2번째 숫자 : "))
c = int(input("3번째 숫자 : "))
d = int(input("4번째 숫자 : "))
hap = a+b+c+d
print("합계 => %d" %hap)
"""

"""
aa = [0,0,0,0]
hap = 0
aa[0] = int(input("1번째 숫자 : "))
aa[1] = int(input("2번째 숫자 : "))
aa[2] = int(input("3번째 숫자 : "))
aa[3] = int(input("4번째 숫자 : "))
hap = aa[0] + aa[1] + aa[2] + aa[3]
print("합계2 ==> %d" %hap)
"""

"""
aa = []
aa.append(0)
aa.append(0)
aa.append(0)
aa.append(0)
print(len(aa))
print(aa)
bb = []
for i in range(0, 100):
	bb.append(i)
print(bb)
"""

#aa = [10, 20, 30, 40]    #리스트 변수 선언
#print("aa[-1]은 %d, aa[-2]는 %d" %(aa[-1], aa[-2])) 
#								# % 뒤에있는 aa[-1]은 첫 번째 %d, aa[-2]를 두번째 %d에 대입
#print(aa[0:2])	            # aa 첫번째부터 두번째 요소 값을 출력
#print(aa[2:4])
#print(aa[0:])				# aa 첫번째부터 끝까지 요소 값을 출력


"""
aa = [30, 10, 20]
print("현재의 리스트 : %s" %aa)
                            #aa 리스트 전체 출력은 문자열로 인식하므로 %s는 aa리스트의 값을 대입한다.
aa.append(40)    # 요소를 1개 추가
print("append 후의 리스트 : %s" %aa)

aa.pop()        # aa리스트의 제일 마지막 요소를 뺀다.
print("pop 후의 리스트 : %s" %aa)

aa.sort()       # 리스트 요소 값들을 오름차순으로 정렬
print("sort 후의 리스트 : %s" %aa)

aa.reverse()    # 리스트 요소 값들을 역순으로 정렬
print("reverse 후의 리스트 : %s" %aa) 

aa.insert(2, 222)    # aa리스트 세번째 위치에 222값을 추가
print("insert(2, 222) 후의 리스트 : %s" %aa)
print("20값의 위치 : %d" %aa.index(20))  # 20이라는 요소 값이 있는 위치 출력

aa.remove(222)    # 222 요소 값을 리스트에서 삭제
print("remove(222) 후의 리스트 : %s" %aa)

aa.extend([77, 88, 99, 77])    # 다른 리스트를 확장
print("extend([77, 88, 99, 77]) 후의 리스트 : %s" %aa)
print("77 값의 개수 : %d" %aa.count(77))    # aa 리스트의 77 요소 값이 몇 개 있는지 출력
"""

aa = [[1,2,3,4,], [5,6,7,8], [9,10,11,12]]
print(aa[0][0])   ## aa 리스트의 첫번째 리스트의 첫번재 요소 출력
print(aa[0])      ## aa 리스트 첫 번째 리스트 전체를 출력
print(aa[1][2])   ## aa 리스트의 두번째 리스트의 세번째 요소 출력
	  