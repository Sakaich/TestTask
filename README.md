### Задание №1
- Библиотека в проекте Geometry
- Юнит тесты в проекте Geometry.Tests
- Для легкости добавления фигур реализована Фабрика
- Вычислять площади фигур без знания типа фигуры в compile-time можно положив экземпляры классов фигур в тип интерфейса IHaveArea
- Проверка треугольника на прямоугольность реализована

### Задание №2
Для получения всех пар "Имя продукта" - "Имя категории" необходимо написать SQL запрос:

```
SELECT product.name, category.name
FROM product
LEFT JOIN category ON product.category_id = category.id;
```

P.S. При связях "многие ко многим" хочется реализовать промежуточную таблицу для осуществления привязки продуктов и категорий, если добавить такую промежуточную таблицу, которая состоит из двух столбцов: идентификатор продукта и идентификатор категории, то SQL запрос выглядел бы следующим образом:
```
SELECT product.name, category.name
FROM product
LEFT JOIN product_category ON product.id = product_category.product_id
LEFT JOIN category ON product_category.category_id = category.id;
```