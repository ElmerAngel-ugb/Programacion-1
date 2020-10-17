CREATE TABLE [dbo].[registrodepersonal]
(
	[Idregistrodepersonal] INT NOT NULL PRIMARY KEY IDENTITY(0, 1), 
    [codigo] CHAR(10) NOT NULL, 
    [nombre] CHAR(65) NOT NULL, 
    [direccion] CHAR(100) NOT NULL, 
    [telefono ] CHAR(10) NOT NULL, 
    [email] CHAR(65) NULL, 
    [cargo] CHAR(35) NOT NULL, 
    [horario] CHAR(70) NOT NULL
)
