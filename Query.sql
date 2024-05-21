# СОЗДАНИЕ БАЗ ДАННЫХ

DROP DATABASE Catalog;
CREATE DATABASE IF NOT EXISTS Catalog;

# СОЗДАНИЕ ТАБЛИЦЫ ПРОДУКТОВ
CREATE TABLE Product (
    id int IDENTITY(1,1) PRIMARY KEY,
    name varchar(max)
);

# СОЗДАНИЕ ТАБЛИЦЫ КАТЕГОРИЙ
CREATE TABLE Category(
    id int IDENTITY(1,1) PRIMARY KEY,
    name varchar(max)
);

# СОЗДАНИЕ СВЯЗУЮЩЕЙ ТАБЛИЦЫ
CREATE TABLE ProductCategory(
    id int IDENTITY(1,1) PRIMARY KEY,
    product_id int FOREIGN KEY REFERENCES Product(id) ON DELETE CASCADE,
    category_id int FOREIGN KEY REFERENCES Category(id) ON DELETE CASCADE,
);

# НАПОЛНЕНИЕ ТАБЛИЦ
INSERT INTO Category (name)
VALUES (N'Бытовая техника'),(N'Электроника');

INSERT INTO Product (name)
VALUES (N'Ноутбук ''Huawei'''), (N'Смартфон  ''BQ'''),
       (N'Стиральная машина'), (N'Утюг');

INSERT INTO ProductCategory (product_id, category_id)
VALUES (1, 1), (2, 1), (3, 2);

# ЗАПРОС НА ВЫВОД для выбора всех пар «Имя продукта – Имя категории» и имен всех продуктов.
﻿SELECT p.name as ProductName, c.name as CategoryName
FROM Product p
    LEFT JOIN ProductCategory pc on p.id = pc.product_id
    LEFT JOIN Category c on pc.category_id = c.id
