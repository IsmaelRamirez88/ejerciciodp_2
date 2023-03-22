USE practica_dp;

-- Volcando estructura para procedimiento practica_dp.GUARDAR_DISTRIBUIDOR
DROP PROCEDURE IF EXISTS practica_dp.GUARDAR_DISTRIBUIDOR;
DELIMITER //
CREATE PROCEDURE practica_dp.GUARDAR_DISTRIBUIDOR(
	IN `BAN` INT,
	IN `ID_I` VARCHAR(25),
	IN `NOMBRE_I` VARCHAR(120),
	IN `APELLIDOP_I` VARCHAR(120),
	IN `APELLIDOM_I` VARCHAR(120),
	IN `CALLE_I` VARCHAR(120),
	IN `NUMERO_I` VARCHAR(120),
	IN `COLONIA_I` VARCHAR(120)
)
BEGIN

	-- 1. Guarda un registro y guarda cambios
	DECLARE hasError BOOLEAN DEFAULT 0;
	DECLARE CONTINUE HANDLER FOR sqlexception SET hasError = 1;
	
	CASE
		WHEN BAN = 1 THEN
			
			START TRANSACTION;
			
				INSERT INTO distributors 
					(
						Id,
						Fecha_Registro
					) 
					VALUES 
					(
						ID_I,
						NOW()
					);
					
				INSERT INTO persons 
				(
					Id_Distribuidor,
					Nombre,
					Apellido_Paterno,
					Apellido_Materno
				) 
				VALUES 
				(
					ID_I,
					NOMBRE_I,
					APELLIDOP_I, 
					APELLIDOM_I
				);
					
				INSERT INTO addresses 
				(
					Id_Distribuidor,
					Calle,
					Numero_Casa,
					Colonia
				) 
				VALUES 
				(
					ID_I,
					CALLE_I,
					NUMERO_I, 
					COLONIA_I
				);
					
			IF hasError THEN
		
				ROLLBACK;
				SELECT 'error';
				
			ELSE
		 
				COMMIT;
				
			END IF;
		WHEN BAN = 2 THEN 
		# 2-- CONSULTAR DISTRIBUIDOR
			SELECT D.Id, CONCAT(P.Nombre, " ", P.Apellido_Paterno, " ", P.Apellido_Materno) Nombre, A.Calle, A.Numero_Casa, A.Colonia
			FROM practica_dp.distributors D 
			INNER JOIN practica_dp.persons P ON D.Id = P.Id_Distribuidor
			INNER JOIN practica_dp.addresses A ON D.Id = A.Id_Distribuidor
			WHERE D.Id = ID_I;
	END CASE;

END//
DELIMITER ;