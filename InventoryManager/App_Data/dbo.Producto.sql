CREATE TABLE [dbo].[Product]
(
	[barcod] INT NOT NULL PRIMARY KEY IDENTITY(70534,1),
	[desc] VARCHAR(500) NOT NULL,
	[pric] DECIMAL(5,2) NOT NULL,
	[type] VARCHAR(50) NOT NULL CHECK(type IN('Camisa','Blusa','Pantalon','Accesorios','Sacos','Vestidos')),
	[stk1] INT NOT NULL DEFAULT(0),
	[stk2] INT NOT NULL DEFAULT(0),
	[devq] INT NOT NULL DEFAULT(0)
)
