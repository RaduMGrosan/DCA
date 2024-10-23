CREATE TABLE [dbo].[Plan]
(
	[Id] BIGINT NOT NULL IDENTITY PRIMARY KEY, 
    [StartDate] DATETIME NULL, 
    [Investment] DECIMAL NULL,
    [Period] NVARCHAR(MAX) NULL,
    [CryptoCurrencyName] NVARCHAR(MAX) NULL
)
