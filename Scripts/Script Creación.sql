/*==============================================================*/
/* DBMS name:      ORACLE Version 11g                           */
/* Created on:     1/08/2019 11:33:52 a.m.                      */
/*==============================================================*/



/*==============================================================*/
/* Table: BANCO                                                 */
/*==============================================================*/
create table BANCO 
(
   BANNIT               NUMBER              not null,
   BANNOMBRE            VARCHAR2(50)         not null,
   BANTIPO              VARCHAR2(20)         not null,
      constraint CKC_BANTIPO_BANCO check (BANTIPO in ('nacional','internacional')),
   constraint PK_BANCO primary key (BANNIT),
constraint CKC_BANNIT_BANCO check (BANNIT > 0),
constraint UQ_BANNOMBRE_BANCO UNIQUE (BANNOMBRE)
);

/*==============================================================*/
/* Table: CLIENTE                                               */
/*==============================================================*/
create table CLIENTE 
(
   CLID                 NUMBER             not null,
   CLNOMBRE             VARCHAR2(20)         not null,
   CLAPELLIDO           VARCHAR2(20)         not null,
   CLFECHANACIMIENTO    DATE                 not null,
   constraint PK_CLIENTE primary key (CLID),
constraint CKC_CLID_CLIENTE check (CLID > 0)

);

/*==============================================================*/
/* Table: LINEADECREDITO                                        */
/*==============================================================*/
create table LINEADECREDITO 
(
   LDCCODIGO            INTEGER              not null,
   BANNIT               NUMBER              not null,
   LDCNOMBRE            VARCHAR2(50)         not null,
      constraint CKC_LDCNOMBRE_LINEADEC check (LDCNOMBRE in ('Estudio','Vehiculo','Vivienda')),
   constraint PK_LINEADECREDITO primary key (LDCCODIGO, BANNIT),
 constraint FK_LINEADEC_OFRECE_BANCO foreign key (BANNIT) references BANCO (BANNIT),
constraint CKC_LDCCODIGO_LINEADECREDITO check (LDCCODIGO > 0),
constraint CKC_BANNIT_LINEADECREDITO check (BANNIT > 0)
);


/*==============================================================*/
/* Table: PRESTAMO                                              */
/*==============================================================*/
create table PRESTAMO 
(
   CODPRESTAMO          INTEGER              not null,
   CLID                 NUMBER              not null,
   LDCCODIGO            INTEGER              not null,
   BANNIT               NUMBER             not null,
   FECHAPRESTAMO        DATE                 not null,
   VALORPRESTAMO        INTEGER              not null,
   NUMCUOTAS            INTEGER              not null,
   constraint PK_PRESTAMO primary key (CODPRESTAMO),
   constraint FK_PRESTAMO_PRESTAMO_CLIENTE foreign key (CLID) references CLIENTE (CLID),
   constraint FK_PRESTAMO_PRESTAMO2_LINEADEC foreign key (LDCCODIGO, BANNIT) references LINEADECREDITO (LDCCODIGO, BANNIT),
constraint CKC_BANNIT_PRESTAMO check (BANNIT > 0),
constraint CKC_CLID_CLIENTE_PREST check (CLID > 0),
constraint CKC_LDCCODIGO_LDC_PREST check (BANNIT > 0),
constraint CKC_CODPRESTAMO_PRESTAMO check (CODPRESTAMO > 0)
);
