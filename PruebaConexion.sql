
SELECT * FROM EMPLEADO 

create table empleado
(
codId int GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
codEmpleado varchar(20),
nombreEmpleado varchar2(50)
);

/*
insert into empleado (codEmpleado, nombreEmpleado) values('PP021','WILLMER CAMEROS');
insert into empleado (codEmpleado, nombreEmpleado) values('PP022','ANDRES DE LEON');
insert into empleado (codEmpleado, nombreEmpleado) values('PP023','OSCAR GOMEZ');
*/
create table registroPersona
(
codId int GENERATED ALWAYS as IDENTITY PRIMARY KEY,
idPaciente number(20)  ,
edadPaciente number(20)  ,
nombrePaciente varchar(50) ,
fechaRegistro date 
);

/*
insert into registroPersona (idPaciente, edadPaciente, nombrePaciente, fechaRegistro)
values(001, 28, 'Willmer Cameros', '28-11-2019')
*/

SELECT * FROM EMPLEADO; 
select * from registroPersona;

SELECT CODID FROM EMPLEADO WHERE CODEMPLEADO = 'PP021' AND PASS = '3238' 

