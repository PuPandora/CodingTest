## 아이스 아메리카노 | 120819
[*문제 링크*](https://school.programmers.co.kr/learn/courses/30/lessons/120819 "아이스 아메리카노 문제 링크")
___

### 문제 설명
정수가 들어 있는 배열 `num_list`가 매개변수로 주어집니다.
<br>
`num_list`의 원소의 순서를 거꾸로 뒤집은 배열을 return하도록 solution 함수를 완성해주세요.
___

### 제한사항
* 1 ≤ `num_list`의 길이 ≤ 1,000
* 0 ≤ `num_list`의 원소 ≤ 1,000
___

### 입출력 예
num_list|result
---|---
[1, 2, 3, 4, 5]|[5, 4, 3, 2, 1]
[1, 1, 1, 1, 1, 2]|[2, 1, 1, 1, 1, 1]
[1, 0, 1, 1, 1, 3, 5]|[5, 3, 1, 1, 1, 0, 1]
___

### 입출력 예 설명
입출력 예 #1
<br>
*  `num_list`가 [1, 2, 3, 4, 5]이므로 순서를 거꾸로 뒤집은 배열 [5, 4, 3, 2, 1]을 return합니다.

<br>

입출력 예 #2
<br>
*  `num_list`가 [1, 1, 1, 1, 1, 2]이므로 순서를 거꾸로 뒤집은 배열 [2, 1, 1, 1, 1, 1]을 return합니다.

<br>

입출력 예 #3
<br>
*  `num_list`가 [1, 0, 1, 1, 1, 3, 5]이므로 순서를 거꾸로 뒤집은 배열 [5, 3, 1, 1, 1, 0, 1]을 return합니다.