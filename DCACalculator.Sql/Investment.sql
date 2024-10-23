CREATE TABLE [dbo].[Investment]
(
	[Id] BIGINT NOT NULL IDENTITY PRIMARY KEY, 
	[Date] DATETIME NULL, 
	[InvestmentAmount] DECIMAL NULL, 
	[CryptoCurrencyName] NVARCHAR(MAX) NULL, 
    [CryptoCurrencyAmount] FLOAT NULL
)
