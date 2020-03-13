--SCRIPT INSERCION BANCO
Insert into Banco(bannit,bannombre,bantipo) values (1000,'Banco de Bogotá','nacional');
Insert into Banco(bannit,bannombre,bantipo) values (2000,'Banco Popular','nacional');
Insert into Banco(bannit,bannombre,bantipo) values (3000,'Banco BBVA','internacional');
Insert into Banco(bannit,bannombre,bantipo) values (4000,'Bancolombia','nacional');

--SCRIPT INSERCION CLIENTE

Insert into Cliente(clId,clNombre,clApellido,clFechaNacimiento) values (100,'Jorge Iván','Solano Papamija','20/09/1999');
Insert into Cliente(clId,clNombre,clApellido,clFechaNacimiento) values (200,'Jefferson Eduardo','Campo Yule','16/06/1998');
Insert into Cliente(clId,clNombre,clApellido,clFechaNacimiento) values (300,'Manuel Alejandro','Ramirez Córdoba','18/01/1990');
Insert into Cliente(clId,clNombre,clApellido,clFechaNacimiento) values (400,'Sara Manuela','Garcias Vivas','19/02/1991');

--SCRIPT INSERCION LINEA DE CREDITO

Insert into LineaDeCredito (LdcCodigo,Bannit,LdcNombre) values (10,'1000','Vivienda');
Insert into LineaDeCredito (LdcCodigo,Bannit,LdcNombre) values (20,'2000','Estudio');
Insert into LineaDeCredito (LdcCodigo,Bannit,LdcNombre) values (30,'3000','Vehiculo');
Insert into LineaDeCredito (LdcCodigo,Bannit,LdcNombre) values (40,'4000','Estudio');
Insert into LineaDeCredito (LdcCodigo,Bannit,LdcNombre) values (50,'1000','Vehiculo');
Insert into LineaDeCredito (LdcCodigo,Bannit,LdcNombre) values (60,'2000','Vehiculo');

--SCRIPT INSERCION PRESTAMO

Insert into Prestamo (codPrestamo,ClId,LdcCodigo,Bannit,FechaPrestamo,ValorPrestamo,NumCuotas) values (1,100,60,2000,'10/02/2019',30000000,24);
Insert into Prestamo (codPrestamo,ClId,LdcCodigo,Bannit,FechaPrestamo,ValorPrestamo,NumCuotas) values (2,200,10,1000,'26/03/2019',30000000,24);
Insert into Prestamo (codPrestamo,ClId,LdcCodigo,Bannit,FechaPrestamo,ValorPrestamo,NumCuotas) values (3,100,20,2000,'16/07/2019',30000000,24);
Insert into Prestamo (codPrestamo,ClId,LdcCodigo,Bannit,FechaPrestamo,ValorPrestamo,NumCuotas) values (4,300,30,3000,'10/06/2019',40000000,12);
Insert into Prestamo (codPrestamo,ClId,LdcCodigo,Bannit,FechaPrestamo,ValorPrestamo,NumCuotas) values (5,400,40,4000,'11/05/2019',5000000,12);
