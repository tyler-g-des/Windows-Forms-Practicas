CREATE DATABASE blog
USE blog

CREATE TABLE usuario(
nombre varchar(100),
apellido varchar(100),
correo varchar(100),
nombreUsuario varchar(100),
clave varchar(100)
)


CREATE TABLE publicacion(
titulo varchar(100),
contenido varchar(200),
fecharCreacion datetime,
usuario varchar(100)
)


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spAccesoSistema]
(
@prmUser VARCHAR(100),
@prmPass VARCHAR(100)
)
AS
BEGIN 
SELECT E.nombreUsuario, E.clave
FROM usuario E
WHERE E.nombreUsuario = @prmUser AND E.clave = @prmPass
END





SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spRegistrarUsuario]
(
@prmNombre VARCHAR(100),
@prmApellido VARCHAR(100),
@prmCorreo VARCHAR(100),
@prmUsuario VARCHAR(100),
@prmClave VARCHAR(100)
)
AS
BEGIN 
INSERT INTO usuario 
VALUES 
(@prmNombre,
@prmApellido,
@prmCorreo,
@prmUsuario,
@prmClave)
END





SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spEliminarPublicacion]
(
@prmTitulo VARCHAR(100)
)
AS
BEGIN 
ALTER FROM publicacion 
WHERE titulo = @prmTitulo;
END




SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spEditarPublicacion]
(
@prmTitulo VARCHAR(100),
@prmContenido VARCHAR(100),
@prmEditar VARCHAR(100),
@prmUsuario VARCHAR(100)
)
AS
BEGIN 
UPDATE publicacion
SET 
titulo = @prmTitulo,
contenido = @prmContenido
WHERE titulo = @prmEditar AND usuario = @prmUsuario
END


GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spRegistrarPublicidad]
(
@prmTitulo VARCHAR(100),
@prmContenido VARCHAR(100),
@prmFecha VARCHAR(100),
@prmUsuario VARCHAR(100)
)
AS
BEGIN 
INSERT INTO publicacion( 
titulo,
contenido,
fecharCreacion,
usuario)
 VALUES 
(
 @prmTitulo,
 @prmContenido,
 @prmFecha,
 @prmUsuario
 )
END
