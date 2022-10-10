
USE [medical]
DELETE FROM tblGender;
DELETE FROM tblSubCategory;
DELETE FROM tblBrands;
DELETE FROM tblUsers;
DELETE FROM ForgotPass;
DELETE FROM tblCart;
DELETE FROM tblCategory;
DELETE FROM tblOrderProducts;
DELETE FROM tblOrders;
DELETE FROM tblProductImages;
DELETE FROM tblProducts;
DELETE FROM tblProductSizeQuantity;
DELETE FROM tblPurchase;
DELETE FROM tblSizes;
DELETE FROM tblUsers;

DBCC CHECKIDENT(tblBrands, RESEED, 0)
DBCC CHECKIDENT(tblCategory, RESEED, 0)
DBCC CHECKIDENT(tblGender, RESEED, 0)
DBCC CHECKIDENT(tblOrderProducts, RESEED, 0)
DBCC CHECKIDENT(tblOrders, RESEED, 0)
DBCC CHECKIDENT(tblProducts, RESEED, 0)
DBCC CHECKIDENT(tblProductSizeQuantity, RESEED, 0)
DBCC CHECKIDENT(tblPurchase, RESEED, 0)
DBCC CHECKIDENT(tblSizes, RESEED, 0)
DBCC CHECKIDENT(tblSubCategory, RESEED, 0)
DBCC CHECKIDENT(tblUsers, RESEED, 0)

SELECT * FROM tblGender;
SELECT * FROM tblSubCategory;
SELECT * FROM tblBrands;
SELECT * FROM tblUsers;
SELECT * FROM ForgotPass;
SELECT * FROM tblCart;
SELECT * FROM tblCategory;
SELECT * FROM tblOrderProducts;
SELECT * FROM tblOrders;
SELECT * FROM tblProductImages;
SELECT * FROM tblProducts;
SELECT * FROM tblProductSizeQuantity;
SELECT * FROM tblPurchase;
SELECT * FROM tblSizes;
SELECT * FROM tblUsers;

INSERT INTO [dbo].[tblBrands]
           ([Name])
     VALUES
           ('Joe’s Pizza')
		   
INSERT INTO [dbo].[tblCategory]
           ([CatName])
     VALUES
           ('Pizza')
		   
INSERT INTO [dbo].[tblSubCategory]
           ([SubCatName]
           ,[MainCatID])
     VALUES
           ('Veg',1),
		   ('Non-veg',1)

INSERT INTO [dbo].[tblGender]
           ([GenderName])
     VALUES
           ('PIZZA')

USE [pizzaa]
GO

INSERT INTO [dbo].[tblUsers]
           ([Username]
           ,[Password]
           ,[Email]
           ,[Name]
           ,[Usertype])
     VALUES
           ('User'
           ,'Password'
           ,'user@xyz.com'
           ,'User'
           ,'User'),
		   ('Admin'
           ,'Admin'
           ,'admin@xyz.com'
           ,'Admin'
           ,'Admin')
GO

