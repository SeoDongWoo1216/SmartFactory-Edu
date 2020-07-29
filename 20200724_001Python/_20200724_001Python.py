#리스트의 다양한 함수 예제
#aa = [30, 10, 20]
#print("현재의 리스트 : %s" %aa)
#                            #aa 리스트 전체 출력은 문자열로 인식하므로 %s는 aa리스트의 값을 대입한다.
#aa.append(40)    # 요소를 1개 추가
#print("append 후의 리스트 : %s" %aa)

#aa.pop()        # aa리스트의 제일 마지막 요소를 뺀다.
#print("pop 후의 리스트 : %s" %aa)

#aa.sort()       # 리스트 요소 값들을 오름차순으로 정렬
#print("sort 후의 리스트 : %s" %aa)

#aa.reverse()    # 리스트 요소 값들을 역순으로 정렬
#print("reverse 후의 리스트 : %s" %aa) 

#aa.insert(2, 222)    # aa리스트 세번째 위치에 222값을 추가
#print("insert(2, 222) 후의 리스트 : %s" %aa)
#print("20값의 위치 : %d" %aa.index(20))  # 20이라는 요소 값이 있는 위치 출력

#aa.remove(222)    # 222 요소 값을 리스트에서 삭제
#print("remove(222) 후의 리스트 : %s" %aa)

#aa.extend([77, 88, 99, 77])    # 다른 리스트를 확장
#print("extend([77, 88, 99, 77]) 후의 리스트 : %s" %aa)
#print("77 값의 개수 : %d" %aa.count(77))    # aa 리스트의 77 요소 값이 몇 개 있는지 출력




#다차원 리스트 예제
#aa = [[1,2,3,4,], [5,6,7,8], [9,10,11,12]]
#print(aa[0][0])   ## aa 리스트의 첫번째 리스트의 첫번재 요소 출력
#print(aa[0])      ## aa 리스트 첫 번째 리스트 전체를 출력
#print(aa[1][2])   ## aa 리스트의 두번째 리스트의 세번째 요소 출력




##문자열와 튜플 타입 관계를 보여주는 예제
#str = "파이썬 문자열"             # 문자열 변수 선언
#print(str[0])                     # 첫번째 자리 문자 출력
#print(str[-1])                    # 뒤에서 첫번째 자리의 문자 출력
##str[-1] = '렬'                   # 뒤에서 첫번째 자리의 문자값 수정(오류)
#card = 'red', 4, 'python', True   # card 튜플을 선언
#print(card)                       # card 튜플 전체 출력
#print(card[1])                    # card 튜블의 첫번째 요소 출력 
##card[0] = 'blue'                 # card 튜블 첫번째 요소값 수정(오류)

#aaaa = [1, "apple"]
#print(aaaa)




##문자열과 튜플의 관계를 설명하는 예제
#one = '하나'
#print(type(one))

#one = '원'
#print(one)

#two = '둘'
#print(type(two))

##two[0] = '투'
#print(two[0])




##튜플 변수로 선언된 각각의 요소 값들을 하나의 변수로 리턴받는 예제
#card = 'red', 4, 'python', True
#a, b, c, d = card
#print(a)
#print(b)
#print(c)
#d = False
#print(d)




##딕셔너리 예제
#dict = {'번호':10, '성명':'장동건', '나이':23, '사는곳':'서울'}
#                           # 딕셔너리 타입 변수 선언
#print(dict)                
#print(type(dict))          # dic 변수의 타입을 출력
#print(dict['나이'])        # 나이 key값으로 value값 출력
#dict['나이'] = 24          # 나이 키 값 항목 변경
#print(dict['나이'])
#dict['직업'] = '배우'      # 직업이라는 키 값과 배우라는 value라는 항목 추가
#print(dict)
#print(dict.keys())         # 키 값 전체 반환
#print(dict.values())        # 값 전체 반환
#print('사는곳' in dict)    # 키 값 존재 여부
#del dict['사는곳']         # 키 값 삭제
#print('사는곳' in dict)    # dict에 사는곳이라는 키 값 존재 여부 출력
#print(dict)




##if문 예제
#a = 23
#if a < 50:
#	print('50보다 작군요')

##if else문
#if a < 20:
#	print('20보다 작군요')
#else:
#	print('20보다 크군요')

##elif문
#age = int(input('현재 나이를 입력합니다. '))   # 사용자가 입력한 값을 정수로 리턴
#if age < 10:
#	print('유년층 입니다.')
#elif age < 20:
#	print('10대 입니다.')
#elif age < 30:
#	print('20대 입니다.')
#elif age < 40:
#	print('30대 입니다.')
#else:
#	print('장년층입니다.')



##for문 예제
#for i in range(0, 5, 1):
#    print(i)
#print("-----------")
#for j in[1,3,5,7,9]:
#    print(j)
#print("-----------")
#for k in range(0,3,1):
#    print("꿈은 이루어 진다.")



##for문 활용
#sum = 0
#for i in range(1, 11, 1):    # 초기값은 1, 증감값은 1, 조건값은 11로 for문 선언
#	sum+=i
#print("sum : %d" %sum)
#print("-----------------")

##for문을 이용하여 1에서 10까지 식과 합을 구하시오.
#sum = 0
#for j in range(1, 11, 1): 
#	if j < 10:
#		print("%d + " % j, end = "")  # end = "" : 줄을 못바꾸도록해주는(엔터 안쳐지도록) 코드 
#	elif j == 10:
#		print("%d = " % j, end = "")
#	sum+=j
#print("%d" % sum)



##while문
#str = "취업은 꼭 이루어진다."
#i = 0
#while i < 3:
#	print(str)
#	i = i+1
#print("-------------------------------")

##while문으로 입력한 숫자만큼 str을 반복 출력
#i = int(input("위 글자를 반복할 횟수를 입력합니다. : "))      #사용자가 입력한 값을 정수로 리턴
#j = 1
#flag = True
#while flag:
#	j = j + 1              # j값을 1씩 증가
#	if i < j:              #만약 j가 i보다 크다는 조건의 if문 선언   
#		flag = False       #flag변수에 False값 대입
#	print(str)



##break문
#sum, i = 0, 0
#for i in range(1, 20, 1):
#	sum+=i
#	if sum>100:
#		break;
#sum-=i
#print("%d" %sum)
#print("---------------------------")

##while문과 break문을 이용하여 입력한 1에서 숫자만큼 합을 구하시오
#sum, i = 0, 0
#j = int(input("숫자를 입력합니다."))
#while True:
#	if i < j:
#		i = i+1
#		sum+=i;
#	elif i == j:
#		break
#print("1에서 %d까지의 합은 %d입니다." %(j,sum))





##Continue문
#i = 0
#while i < 100:    # i가 100보다 작을 때 반복. 0부터 99까지 증가하면서 100번 반복
#  i += 1    # i를 1씩 증가시킴
#  if i % 2 == 0:  # i를 2로 나누었을 때 나머지가 0이면 짝수
#    continue  # 아래 코드를 실행하지 않고 건너뜀
#  print("%d " %i,  end = "")



##구구단 4단~7단까지
#for i in range(4, 8, 1):
#    for j in range(1, 10, 1):
#        k=i*j
#        #print("%d"%i + "*" +"%d"%j + "=%d"%k)
#        print("%d * %d = %d"%(i,j,i*j))
#    print()
