# Вычисление корней квадратных уравнений 
<!--
:owl: Работаю над этой страницой
-->
## Цель
Тренировка принципов ООП, SOLID, паттернов проектирования на математическом проекте. Программа вычисляет корни квадратных уравнений разных типов. 

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

## Применение паттернов
### Стратегия 
- **ITypeQe**    — интерфейс. Наследники определяют как вычисляются дискриминант или корни уравнения;
- **ACalcRoots** — абстрактный класс. Наследники определяют как вычисляются корни через дискрминант;
- **ACalcQe**    — абстрактный класс. Наследники определяют как вычисляются корни уравнения. 

### Цепочка обязанностей
Наследники **ACalcQe** работают с объектами наследников этого же класса: 
- **CalcQeByD** считает корни с помощью **CalcRootsByD**; 
- **CalcIqe**   проверяет корни уравнений с помощью **CheckRootsBySubstitution**;
- **CalcQeByD** проверяет корни уравнений с помощью **CheckRootsBySubstitution** или **CheckRootsByVieta**.

### Одиночка
**DefineType** содержит единственное поле: собственный экземпляр.

### Фасад 
- **DefineType** скрывает инициализацию объектов типа **ACalcQe**: определяет тип уравнения по заданным переменным и выбирает класс для расчета уравнения;
- **CalcQeByD**  работает с объектами других классов для вычисления дискриминанта, корней уравнения и проверки решения;  
- **CalcIqe**    работает с объектами других классов для вычисления корней уравнения и проверки решения.

## Пути улучшения программы 
- Реализация ручного ввода;
- Больше тестов, в частности, класса DefineType и типов уравнений;
- Принцип открытости/закрытости в CalcRootsByD, CheckRootsBySubstitution при работе с биквадратным уравнением;
- ✅ Принцип подстановки Лисков в наследниках ACalcQe. Проблема в IsRootsCorrect;
- ✅ Проверка корней всех типов уравнений.

## Источники математической теории:
- https://izamorfix.ru/matematika/algebra/kvadratnye_uravn.html
- https://izamorfix.ru/matematika/algebra/diskriminant.html
- https://izamorfix.ru/matematika/algebra/nepolnye_kv_ur.html
- https://izamorfix.ru/matematika/algebra/teorema_vieta.html
- https://izamorfix.ru/matematika/algebra/bikvadratnye_uravn.html
