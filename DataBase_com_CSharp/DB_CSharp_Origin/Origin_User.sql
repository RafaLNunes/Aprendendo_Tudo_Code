create database Origin_User;
use Origin_User;

create table perfil(
	Cod_perfil int primary key auto_increment,
    Cargo varchar(70) -- ADM, Vendedor, Comprador, Cliente, Gerente, Diretor, Time Maneger, ... 
);

create table tipo(
	Cod_tipo int primary key auto_increment,
    Tipo_prod varchar(70)
);

create table fornecedor(
	Cod_fornc int primary key auto_increment,
    Forneced varchar(70)
);

create table produto(
	Cod_prod int primary key auto_increment,
    Nome varchar(70),
    CFK_fornc int,
    CFK_tipo int,
    constraint FK_fornc foreign key (CFK_fornc) references fornecedor (Cod_fornc),
    constraint FK_tipo foreign key (CFK_tipo) references tipo (Cod_tipo)
);

create table users(
	Cod_user int primary key auto_increment,
    Nome varchar(70),
    Idade int, -- ano atual menos ano escolhido
    Data_nasc date,
    hora_registro time,
    UserName varchar(70),
    Passwords varchar(80),
    CFK_perfil int,
    constraint FK_perfil foreign key (CFK_perfil) references perfil (Cod_perfil)
);


insert into perfil(Cargo) values('ADM'), ('Vendedor'), ('Comprador'), ('Cliente'), ('Gerente'), ('Diretor'), ('Time Maneger');

insert into tipo(Tipo_prod) values('Alimentícios'), ('Limpeza'), ('Eletrodomésticos'), ('Roupas'), ('Acessórios');

select Users.Cod_User as 'Código', Users.Nome as 'Nome', Users.idade as 'Idade', Users.Data_nasc as 'Ano de cadastro', Users.UserName as 'Name User',  Users.Passwords as 'PassWord', perfil.Cargo as 'Perfil do Usuário' from users inner join perfil on users.CFK_perfil = perfil.Cod_perfil;



select * from users;
select * from perfil;
select * from tipo;
select * from fornecedor;