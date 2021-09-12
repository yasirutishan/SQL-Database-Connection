/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Item_code]
      ,[Name]
      ,[qty]
      ,[price]
  FROM [SHOPPING].[dbo].[Item]