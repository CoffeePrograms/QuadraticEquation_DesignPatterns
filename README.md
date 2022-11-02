:owl: Работаю над этой страницой

# Цель
Тренировка принципов ООП, SOLID, паттернов проектирования на простом математическом проекте. Программа вычисляет корни квадратных уравнений разных типов. 
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

## Применение паттернов
### Стратегия 
- **ITypeQe** — интерфейс. Наследники первого определяют как вычисляются дискриминант или корни уравнения.
- **ACalcRoots** — абстрактный класс. Наследники определяют как вычисляются корни через дискрминант.
- **ACalcQe** — абстрактный класс. Наследники определяют как вычисляются корни уравнения. 

### Цепочка обязанностей
Наследники **ACalcQe** работают с объектами наследников этого же класса: 
- **CalcQeByD** считает корни с помощью **CalcRootsByD**; 
- **CalcIqe** и **CalcQeByD** проверяют корни уравнений с помощью **CheckRootsByVieta** или **CheckRootsBySubstitution**.

### Одиночка. Фасад 
**DefineType** реализован как **Одиночка** и **Фасад**. Определяет тип уравнения по заданным переменным и выбирает класс для расчета уравнения, скрывает инициализацию объектов типа **ACalcQe**.

## Пути улучшения программы 
- Уменьшение связанности
- Раелизация ручного ввода
- ✅ Принцип Лисков в наследниках ACalcQe
- ✅ Проверка корней всех типов уравнений

## Источники математической теории:
- https://izamorfix.ru/matematika/algebra/kvadratnye_uravn.html
- https://izamorfix.ru/matematika/algebra/diskriminant.html
- https://izamorfix.ru/matematika/algebra/nepolnye_kv_ur.html
- https://izamorfix.ru/matematika/algebra/teorema_vieta.html
- https://izamorfix.ru/matematika/algebra/bikvadratnye_uravn.html
