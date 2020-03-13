--Consulta Punto 5

select * 
from prestamo inner join cliente
on prestamo.clid = cliente.clid
inner join lineadecredito
on prestamo.ldccodigo = lineadecredito.ldccodigo 

--Consulta Punto 6

select cliente.clid Identificacion,clnombre Nombre,clapellido Apellido,clfechanacimiento FechaNacimiento,ldcnombre NombreLDC,bannombre Banco
from prestamo inner join cliente
on prestamo.clid = cliente.clid
inner join lineadecredito
on prestamo.ldccodigo = lineadecredito.ldccodigo
inner join banco
on prestamo.bannit = banco.bannit
where fechaprestamo ='16/07/2019'

--CONSULTA VIVIENDA

select ldcnombre LineaDeCredito, count(clid) as "Cantidad Prestamos en 2019"
from prestamo inner join lineadecredito
on prestamo.ldccodigo = lineadecredito.ldccodigo
where to_char(fechaPrestamo,'yyyy') = '2019'
group by ldcnombre
having ldcnombre = 'Vivienda'
