declare @id nvarchar(128)
select @id=id
from AspNetUsers
where UserName='Administrador'

INSERT INTO AspNetUserRoles
([UserId]
,[RoleId])
VALUES 
(@id
,1)
