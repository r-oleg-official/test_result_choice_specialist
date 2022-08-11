<h2 align="center">Практическое задание. Выбор специализации.</h2>
<h3 align="center">Программа поиска элементов массива состоящих не более трех символов.</h3>


**Задача**. Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Для решения задачи необходимо:

1. Составить блок-схему алгоритма;
2. Написать программный код на языке С#.

На [рисунке](https://github.com/r-oleg-official/test_result_choice_specialist/blob/main/task001_choice_el-t_less_3_symb/pic/test_find_el-t_string_array.drawio.png) представлена блок-схема одного варианта алгоритма решения данной задачи в случае, 
когда известны значения элементов массива.

### Алгоритм решения.
Исходный массив предполагается оставить неизменным, поэтому для создания результирующего массива 
необходимо узнать его будущий размер.

1. Задать исходный заполненный массив.
2. Задать переменную-счетчик для подсчета нужных элементов. Выбрать индекс первого элемента массива равен нулю.
3. Цикл. Выбрать элемент массива с заданным индексом.
4. Посчитать количество символов элемента. Проверить количество меньше, или равно 3-м? Если "да", шаг 5.
5. Счетчик и индекс увеличить на 1-цу.
6. Если индекс меньше размера массива - перейти на шаг 3. Иначе, шаг 7.
7. Создать массив размером, равным счетчику.
8. Задать два индекса исходного массива "IndexS" и результирующего "IndexE", равные нулю.
9. Цикл. Выбрать элемент массива с заданным индексом.
10. Посчитать количество символов элемента. Проверить количество меньше, или равно 3-м? 
Если "да", шаг 11, если нет шаг 12.
11. Присвоить значение элемента исходного массива с индексом "IndexS" значению элемента результирующего массива
с индексом "IndexE". Увеличить "IndexS" и "IndexE" на 1-цу.
12. Увеличить "IndexS" на 1-цу.
13. Если "IndexS" меньше размера исходного массива - перейти на шаг 9. Иначе, шаг 14.
14. Вывести на экран/печать оба массива.

