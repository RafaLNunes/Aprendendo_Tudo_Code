CREATE DATABASE Biblio_Sesi;
Use Biblio_Sesi;


CREATE TABLE Table_Cargo (
	CD_Cargo int primary key auto_increment not null,
    Cargo Varchar(45)
);

CREATE TABLE Table_Ano_Escolar (
	CD_Ano_Escolar int primary key auto_increment not null,
    Ano_Escolar varchar(45) -- 1° EF, 2° EF, 3° EF, 4° EF, 5° EF, 6° EF, 7° EF, 8° EF, 9° EF, 1° EM, 2° EM, 3° EM, Diretoria
);

CREATE TABLE Table_Unidade(
	CD_Unidade int primary key auto_increment not null,
    Nome_Unidade Varchar(45),
    Local_Unidade Varchar(45),
    IMG_Unidade Varchar(45),
    Descricao_Retirada Varchar(125)
);

CREATE TABLE Table_Livro (
	CD_Livro varchar(45) not null primary key,
    Nome_Livro Varchar(45),
    QTD_estoque int,
    Numb_Paginas int,
    Edicao_Livro int,
    IMG_Livro Varchar(100),
    Descricao_Livro Varchar(500),
    CFK_Unidade int,
    CONSTRAINT FK_Unidade FOREIGN KEY (CFK_Unidade) REFERENCES Table_Unidade(CD_Unidade)
);

CREATE TABLE Table_User (
	ID_Aluno Varchar(45) primary key not null,
    NameUser Varchar(45),
    Nome_Completo Varchar(45),
    Senha Varchar(45),	
    IMG_User Varchar(45),
    CFK_Ano int,
	CFK_Cargo int,
    CFK_Unidade int,
    CONSTRAINT FK_Ano FOREIGN KEY (CFK_Ano) REFERENCES Table_Ano_Escolar(CD_Ano_Escolar),
    CONSTRAINT FK_Cargo FOREIGN KEY (CFK_Cargo) REFERENCES Table_Cargo(CD_Cargo),
    CONSTRAINT FK_Unidades FOREIGN KEY (CFK_Unidade) REFERENCES Table_Unidade(CD_Unidade)
);

CREATE TABLE Table_Historico (
	CD_Hist int primary key auto_increment not null,
    DT_reserva datetime,
    DT_devolucao datetime,
    CFK_Livro Varchar(45),
    CFK_User Varchar(45),
    CONSTRAINT FK_Livro FOREIGN KEY (CFK_Livro) REFERENCES Table_Livro(CD_Livro),
    CONSTRAINT FK_User FOREIGN KEY (CFK_User) REFERENCES Table_User(ID_Aluno)
);

CREATE TABLE Table_reservas(
	CD_Reservas int primary key auto_increment not null,
    DT_reserva datetime,
    DT_previsão_devolucao datetime,
    CFK_User varchar(45),
    CFK_Livro varchar(45),
    CONSTRAINT FK_Users foreign key (CFK_User) references Table_User(ID_Aluno), 
    CONSTRAINT FK_Livros foreign key (CFK_Livro) references Table_Livro(CD_Livro)
);



