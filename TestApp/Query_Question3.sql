CREATE database Test;
GO

USE Test;

CREATE TABLE Products
(
	id INT PRIMARY KEY,
	productname VARCHAR(50)
);

CREATE TABLE Categories
(
	id INT PRIMARY KEY,
	categoryname VARCHAR(50)
);

CREATE TABLE Products_Categories
(
	product_id INT,
	category_id INT,
	PRIMARY KEY(product_id, category_id),
	FOREIGN KEY (product_id) REFERENCES Products(id),
	FOREIGN KEY (category_id) REFERENCES Categories(id)	
);
GO

INSERT INTO Products
VALUES
(1,'Телефон'),(2,'Компьютер'),(3,'Планшет'),(4,'Яблоко'),(5,'Груша'),(6,'Тренажер'),(7,'Кот')

INSERT INTO Categories
VALUES
(1,'Техника'),(2,'Еда'),(3,'Съедобное'),(4,'Несъедобное')
GO

INSERT INTO Products_Categories
VALUES
(1,1),(1,4),(2,1),(2,4),(3,1),(3,4),(4,2),(4,3),(5,2),(5,3),(6,4)

SELECT P.productname as 'Имя продукта', 
(SELECT Categories.categoryname FROM Categories WHERE Categories.id = PC.category_id) as 'Имя категории'
FROM Products as P LEFT JOIN Products_Categories as PC ON P.id = PC.product_id