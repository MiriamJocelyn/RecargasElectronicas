Select *From TipoContacto

Delete From TipoContacto
where Id>=2

DBCC CHECKIDENT (TipoContacto, RESEED, 1)