create DataBase Teste_DataBase;
use Teste_DataBase;

Create Table Users(
	Cod_User int primary key auto_increment,
    Nome varchar(30),
    idade int,
    NameUser varchar(60),
	pasword varchar(40)
);

Create Table Produto(
	Cod_Prod int primary key auto_increment,
    nome_prod varchar(40),
    preco_prod float(5,2),
    qtd_prod int
);

Create Table juncao(
	cod_juncao int primary key auto_increment,
    CFK_prod int,
    CFK_user int,
    constraint FK_prod foreign key(CFK_prod) references Produto(Cod_Prod),
    constraint FK_user foreign key(CFK_user) references Users(Cod_User)
);
	
select * from Produto;
select * from Users;
select * from juncao;
