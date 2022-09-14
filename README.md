# Итоговая проверочная работа первой четверти

## Задача:

 Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Решение:
 1. Создаем массив со строками различной длины.
 2. Объявляем функцию PrintArray, которая печатает элементы массива. Функция принимает в качестве аргумента массив со строками.
 3. Объявляем функцию GetArrayFromStringLessThreeChar, которя возвращает новый массив со строками, которые содержат 3 и менее символов. Функция принимающет в качестве аргументов:
    - Массив со строками
    - Размер нового массива
4. Объявляем функцию CheckForThreCharInStringArray, которая считает колличество элементов, строки которых содержат 3 и менее символов. Функция принимает в качестве аргумента массив со строками. Если в принимаемом в качестве аргумента массиве нет подходящих элементов, то функции выводит сообщение "В массиве нет подходящих элементов". В противном случае вызывает функцию GetArrayFromStringLessThreeChar и передает в нее следующие аргументы:
    - Принятый ранее массив со строкам.
    - Колличество подходящих под условие элементов массива. 
5. Вызываем функцию PrintArray и передаем массив в нее созданый в первом пункте массив (для последующего сравненя).
6. Вызываем функцию CheckForThreCharInStringArray и так же передаем в нее созданый в первом пункте массив.
7. Смотрим результат работы программы в терминале.