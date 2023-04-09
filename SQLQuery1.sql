﻿--Select
--ANSII
Select ContactName Adi, CompanyName Sirketadi,City Sehir from Customers

Select * from Customers where City = 'Berlin'

--case insensitive
sElEct * from Products where categoryId = 1 or categoryId = 3

sElEct * from Products where categoryId = 1 and  UnitPrice>=10

select * from Products where CategoryID = 1 order by UnitPrice desc --ascending --descending

select count(*) Adet from Products where CategoryID = 2


select categoryId,count(*) from Products where UnitPrice>20
group by CategoryID having count(*)<10

select Products.ProductID, Products.ProductName, products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10

--DTO Data Transformation Object

select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID

select * from Customers c left join Orders o 
on c.CustomerID = o.CustomerID
where o.CustomerID is null




