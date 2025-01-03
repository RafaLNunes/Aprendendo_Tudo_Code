create DataBase Teste_DataBase;
use Teste_DataBase;


-- alter table Users add CFK_perfil int;
-- alter TABLE Users ADD constraint FK_perfil foreign key (CFK_perfil) references perfil(Cod_perfil);

create table fornecedor(
	Cod_fornc int primary key auto_increment,
    Nome varchar(70)
);

Create Table Produto(
	Cod_Prod int primary key auto_increment,
    nome_prod varchar(40),
    preco_prod float(5,2),
    qtd_prod int,
    CFK_fornc int,
    foto_prod varchar(120),
    constraint FK_fornc foreign key (CFK_fornc) references fornecedor(Cod_fornc)
);
create table perfil(
	Cod_perfil int primary key auto_increment,
    cargo varchar(50)
);

Create Table Users(
	Cod_User int primary key auto_increment,
    Nome varchar(30),
    idade int,
    ano datetime, -- '2024-03-11 12:34:56'
    NameUser varchar(60),
	pasword varchar(40),
    CFK_perfil int,
    Cam_FT varchar(120),
    constraint FK_perfil foreign key (CFK_perfil) references perfil(Cod_perfil)
);

Create Table juncao(
	cod_juncao int primary key auto_increment,
    CFK_prod int,
    CFK_user int,
    constraint FK_prod foreign key(CFK_prod) references Produto(Cod_Prod),
    constraint FK_user foreign key(CFK_user) references Users(Cod_User)
);
	delete from Users where Cod_User=6;
select * from Produto;
select * from Users;
select * from juncao;
select * from perfil;
select * from fornecedor;

insert into perfil (cargo) values("ADM"), ("gerente"), ("técnico"), ("Vendedor"), ("Comprador");
insert into fornecedor(Nome) values("Sysco Corporation"),("US Foods"),("Gordon Food Service"),("Performance Food Group"),("PepsiCo"),("Tyson Foods"),("Cargill");
/*
update Users set CFK_perfil = 4 where Cod_User = 3;
update Users set CFK_perfil = 5 where Cod_User = 7;
update Users set CFK_perfil = 2 where Cod_User = 8;
update Users set CFK_perfil = 2 where Cod_User = 9;
update Users set CFK_perfil = 1 where Cod_User = 10;
update Users set CFK_perfil = 4 where Cod_User = 12;
update Users set CFK_perfil = 2 where Cod_User = 13;

*/
-- create database baa;
-- use baa;
