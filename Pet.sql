/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     21/01/2021 10:55:54                          */
/*==============================================================*/


drop table if exists animal;

drop table if exists categoria;

drop table if exists cidade;

drop table if exists cliente;

drop table if exists cor;

drop table if exists departamento;

drop table if exists especie;

drop table if exists estado;

drop table if exists fabricante;

drop table if exists formapagamento;

drop table if exists fornecedor;

drop table if exists funcao;

drop table if exists itempedido;

drop table if exists pedido;

drop table if exists produto;

drop table if exists profissao;

drop table if exists raca;

drop table if exists usuario;

/*==============================================================*/
/* Table: animal                                                */
/*==============================================================*/
create table animal
(
   animalid             int not null auto_increment,
   clienteid            int,
   racaid               int,
   especieid            int,
   corid                int,
   animalnome           varchar(20),
   animaldatanascimento date,
   animalsexo           bool,
   animaldatacadastro   date,
   animaladotado        bool,
   animaltemperamento   varchar(20),
   animaltamanho        int,
   animalobservacao     varchar(255),
   animalpeso           double,
   animalfoto           varchar(30),
   primary key (animalid)
);

/*==============================================================*/
/* Table: categoria                                             */
/*==============================================================*/
create table categoria
(
   categoriaid          int not null auto_increment,
   categorianome        varchar(30),
   categoriadescricao   varchar(255),
   primary key (categoriaid)
);

/*==============================================================*/
/* Table: cidade                                                */
/*==============================================================*/
create table cidade
(
   cidadeid             int not null auto_increment,
   cidadenome           varchar(60),
   primary key (cidadeid)
);

/*==============================================================*/
/* Table: cliente                                               */
/*==============================================================*/
create table cliente
(
   clienteid            int not null auto_increment,
   cidadeid             int,
   estadoid             int,
   profissaoid          int,
   clientenome          varchar(60),
   clientecpf           varchar(15),
   clienterg            varchar(15),
   clientelogradouro    varchar(60),
   clientecep           varchar(11),
   clientebairro        varchar(50),
   clientenumero        varchar(10),
   clientecomplemento   varchar(30),
   clientetelefone      varchar(15),
   clientecelular       varchar(15),
   clientedatanascimento date,
   clientedatacadastro  date,
   clienteativo         bool,
   clientesexo          int,
   primary key (clienteid)
);

/*==============================================================*/
/* Table: cor                                                   */
/*==============================================================*/
create table cor
(
   corid                int not null auto_increment,
   cornome              varchar(20),
   primary key (corid)
);

/*==============================================================*/
/* Table: departamento                                          */
/*==============================================================*/
create table departamento
(
   departamentoid       int not null auto_increment,
   departamentonome     varchar(30),
   primary key (departamentoid)
);

/*==============================================================*/
/* Table: especie                                               */
/*==============================================================*/
create table especie
(
   especieid            int not null auto_increment,
   especienome          varchar(50),
   especiedescricao     varchar(255),
   especiefoto          varchar(50),
   primary key (especieid)
);

/*==============================================================*/
/* Table: estado                                                */
/*==============================================================*/
create table estado
(
   estadoid             int not null auto_increment,
   estadonome           varchar(50),
   estadodescricao      varchar(2),
   primary key (estadoid)
);

/*==============================================================*/
/* Table: fabricante                                            */
/*==============================================================*/
create table fabricante
(
   fabricanteid         int not null auto_increment,
   fabricantenomefantasia varchar(50),
   fabricantedescricao  varchar(255),
   fabricanterazaosocial varchar(50),
   primary key (fabricanteid)
);

/*==============================================================*/
/* Table: formapagamento                                        */
/*==============================================================*/
create table formapagamento
(
   formapagtoid         int not null auto_increment,
   formapagtonome       varchar(50),
   formapagtodescricao  varchar(255),
   formapagtocaracteristica varchar(255),
   primary key (formapagtoid)
);

/*==============================================================*/
/* Table: fornecedor                                            */
/*==============================================================*/
create table fornecedor
(
   fornecedorid         int not null auto_increment,
   cidadeid             int,
   estadoid             int,
   tipologradouroid     int,
   fornecedornome       varchar(60),
   fornecedorcpf        varchar(15),
   fornecedorrg         varchar(15),
   fornecedorlogradouro varchar(60),
   fornecedorcep        varchar(11),
   fornecedorbairro     varchar(50),
   fornecedornumero     varchar(10),
   fornecedorcomplemento varchar(30),
   fornecedortelefone   varchar(15),
   fornecedorcelular    varchar(15),
   fornecedordatacadastro date,
   fornecedorativo      bool,
   primary key (fornecedorid)
);

/*==============================================================*/
/* Table: funcao                                                */
/*==============================================================*/
create table funcao
(
   funcaoid             int not null auto_increment,
   funcaonome           varchar(50),
   funcaodescricao      varchar(255),
   primary key (funcaoid)
);

/*==============================================================*/
/* Table: itempedido                                            */
/*==============================================================*/
create table itempedido
(
   itempedidoid         int not null auto_increment,
   pedidoid             int,
   produtoid            int,
   itempedidoqtde       int,
   primary key (itempedidoid)
);

/*==============================================================*/
/* Table: pedido                                                */
/*==============================================================*/
create table pedido
(
   pedidoid             int not null auto_increment,
   clienteid            int,
   usuarioid            int,
   animalid             int,
   formapagtoid         int,
   peditodata           date,
   peditovalor          double,
   pedidoconcluido      bool,
   primary key (pedidoid)
);

/*==============================================================*/
/* Table: produto                                               */
/*==============================================================*/
create table produto
(
   produtoid            int not null auto_increment,
   fabricanteid         int,
   fornecedorid         int,
   categoriaid          int,
   departamentoid       int,
   produtonome          varchar(50),
   produtodescricao     varchar(255),
   produtocodigobarra   varchar(30),
   produtovolume        double,
   produtocorredor      varchar(5),
   produtopateleira     varchar(10),
   primary key (produtoid)
);

/*==============================================================*/
/* Table: profissao                                             */
/*==============================================================*/
create table profissao
(
   profissaoid          int not null auto_increment,
   profissaonome        varchar(30),
   profissaodescricao   varchar(255),
   primary key (profissaoid)
);

/*==============================================================*/
/* Table: raca                                                  */
/*==============================================================*/
create table raca
(
   racaid               int not null auto_increment,
   especieid            int,
   racanome             varchar(50),
   racadescricao        varchar(255),
   primary key (racaid)
);

/*==============================================================*/
/* Table: usuario                                               */
/*==============================================================*/
create table usuario
(
   usuarioid            int not null auto_increment,
   cidadeid             int,
   estadoid             int,
   departamentoid       int,
   funcaoid             int,
   usuarionome          varchar(60),
   usuariologradouro    varchar(60),
   usuarionumero        varchar(10),
   usuariocep           varchar(11),
   usuariocomplemento   varchar(30),
   usuariocpf           varchar(15),
   usuariodatanascimento date,
   usuariologin         varchar(20),
   usuariosenha         varchar(20),
   usuariobairro        varchar(50),
   usuariodatacadastro  date,
   usuariosalario       double,
   usuarioparticipacao  double,
   usuariocargahoraria  double,
   primary key (usuarioid)
);

alter table animal add constraint fk_reference_14 foreign key (clienteid)
      references cliente (clienteid) on delete restrict on update restrict;

alter table animal add constraint fk_reference_15 foreign key (racaid)
      references raca (racaid) on delete restrict on update restrict;

alter table animal add constraint fk_reference_16 foreign key (especieid)
      references especie (especieid) on delete restrict on update restrict;

alter table animal add constraint fk_reference_17 foreign key (corid)
      references cor (corid) on delete restrict on update restrict;

alter table cliente add constraint fk_reference_10 foreign key (profissaoid)
      references profissao (profissaoid) on delete restrict on update restrict;

alter table cliente add constraint fk_reference_7 foreign key (cidadeid)
      references cidade (cidadeid) on delete restrict on update restrict;

alter table cliente add constraint fk_reference_8 foreign key (estadoid)
      references estado (estadoid) on delete restrict on update restrict;

alter table itempedido add constraint fk_reference_21 foreign key (pedidoid)
      references pedido (pedidoid) on delete restrict on update restrict;

alter table itempedido add constraint fk_reference_22 foreign key (produtoid)
      references produto (produtoid) on delete restrict on update restrict;

alter table pedido add constraint fk_reference_19 foreign key (clienteid)
      references cliente (clienteid) on delete restrict on update restrict;

alter table pedido add constraint fk_reference_20 foreign key (usuarioid)
      references usuario (usuarioid) on delete restrict on update restrict;

alter table pedido add constraint fk_reference_23 foreign key (animalid)
      references animal (animalid) on delete restrict on update restrict;

alter table pedido add constraint fk_reference_24 foreign key (formapagtoid)
      references formapagamento (formapagtoid) on delete restrict on update restrict;

alter table produto add constraint fk_reference_11 foreign key (fabricanteid)
      references fabricante (fabricanteid) on delete restrict on update restrict;

alter table produto add constraint fk_reference_12 foreign key (fornecedorid)
      references fornecedor (fornecedorid) on delete restrict on update restrict;

alter table produto add constraint fk_reference_13 foreign key (categoriaid)
      references categoria (categoriaid) on delete restrict on update restrict;

alter table produto add constraint fk_reference_18 foreign key (departamentoid)
      references departamento (departamentoid) on delete restrict on update restrict;

alter table raca add constraint fk_reference_1 foreign key (especieid)
      references especie (especieid) on delete restrict on update restrict;

alter table usuario add constraint fk_reference_2 foreign key (cidadeid)
      references cidade (cidadeid) on delete restrict on update restrict;

alter table usuario add constraint fk_reference_3 foreign key (estadoid)
      references estado (estadoid) on delete restrict on update restrict;

alter table usuario add constraint fk_reference_5 foreign key (departamentoid)
      references departamento (departamentoid) on delete restrict on update restrict;

alter table usuario add constraint fk_reference_6 foreign key (funcaoid)
      references funcao (funcaoid) on delete restrict on update restrict;

