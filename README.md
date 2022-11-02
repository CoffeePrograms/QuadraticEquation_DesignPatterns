:owl: Работаю над этой страницой

# Цель
Тренировка принципов ООП, SOLID, паттернов проектирования на простом математическом проекте. Программа вычисляет корни квадратных уравнений нескольких типов. 
<!--
  Стратегия, цепочка обязанностей, синглтон, фасад, интверсия управления и внедрение зависимостей.
  Проверка следования принципам ООП, СОЛИД
-->
## Математическая часть
Программа решает следующие типы квадратных уравнений:
- полные;
- неполные;
- биквадратные.

## Шаблоны проектирования
- стратегия;
- цепочка обяазнностей;
- одиночка;
- фасад.

## Основные абстракции
Проект содержит комментарии для каждой абстракции и диаграмму классов.

### Абстрактные классы
- **ACalcQe**;
- **ACalcRoots**.
### Интерфейсы
- **ITypeIqe**;
- **ITypeQeCalcByD**.
### Реализации
Классы для 7 подтипов квадратных уравнений. 
Классы для поиска одного, двух корней уравнения. 
Классы для простого решения, с помощью дискриминанта, проверка решения через теорему Виета.
Класс для определения типа уравнения на основании заданных переменных.

## Применение паттернов
### Одиночка. Фасад 
**DefineType** реализован как **Одиночка** и **Фасад**. Определяет тип уравнения по заданным переменным, скрывает инициализацию объектов.
### Стратегия
- **ITypeQeCalcByD** — интерфейс. Наследники первого определяют как вычисляется дискриминант. 
- **ITypeIqe** — интерфейс. Наследники первого определяют как вычисляются корни уравнения.
- **ACalcRoots** — абстрактный класс. Наследники определяют как вычисляются корни через дискрминант.
- **ACalcQe** — абстрактный класс. Наследники определяют как вычисляются корни уравнения. 
### Цепочка обязанностей
Наследники **ACalcQe** работают с объектами наследников этого же класса. **CalcQeByD** содержит **CalcRootsByD** и в некоторых случаях создает объект класса **CheckRootsByVieta**.


## Пути улучшения программы 
- Принцип Лисков в наследниках ACalcQe
- Уменьшение связанности

## Источники математической теории:
https://izamorfix.ru/matematika/algebra/kvadratnye_uravn.html
https://izamorfix.ru/matematika/algebra/diskriminant.html
https://izamorfix.ru/matematika/algebra/nepolnye_kv_ur.html
https://izamorfix.ru/matematika/algebra/teorema_vieta.html
https://izamorfix.ru/matematika/algebra/bikvadratnye_uravn.html
