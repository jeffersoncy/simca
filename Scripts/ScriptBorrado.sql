--Script De borrado


alter table LINEADECREDITO
   drop constraint FK_LINEADEC_OFRECE_BANCO;

alter table PRESTAMO
   drop constraint FK_PRESTAMO_PRESTAMO_CLIENTE;

alter table PRESTAMO
   drop constraint FK_PRESTAMO_PRESTAMO2_LINEADEC;

drop table BANCO cascade constraints;

drop table CLIENTE cascade constraints;

drop table LINEADECREDITO cascade constraints;

drop table PRESTAMO cascade constraints;
