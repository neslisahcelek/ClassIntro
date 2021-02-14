Select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers  
       --customerstaki kolonların ismini kendin belirlemek istersen

sElect * from Customers where City = 'London' -- * = tüm kolonlar
--case insensitive
select * from Products where CategoryID=1 or CategoryID=3

select * from Products where CategoryID=1 and UnitPrice>=10

select * from Products order by  CategoryID,ProductName

select * from Products where CategoryID=1 order by  UnitPrice asc --ascending:artan-->default. desc: azalan

select count(*) Adet from Products where CategoryID=2 --product sayısı --adet: kolonun ismi


select categoryID, count(*) Adet from Products group by CategoryID having count(*)<10

select categoryID, count(*) Adet from Products where UnitPrice>20 group by CategoryID having count(*)<10


select * from Products inner join Categories on Products.CategoryID = Categories.CategoryID
--DTO-> Data transformation object
select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName from Products inner join Categories on Products.CategoryID = Categories.CategoryID

select * from Products p left join [Order Details] od on p.ProductID = od.ProductID
--left:productsta var orderda yok  --boşluk olduğu için parantez

select * from Customers c left join Orders o on c.CustomerID = o.CustomerID where o.CustomerID is null
--hiç sipariş vermeyen müşterileri bulur







