CREATE DATABASE PROJETO_RH;

USE PROJETO_RH;

CREATE TABLE PESSOAS(
	ID BIGINT PRIMARY KEY IDENTITY,
	NOME VARCHAR(300) NOT NULL ,
	DATANASCIMENTO DATE NOT NULL,
	CPF CHAR(11) UNIQUE NOT NULL ,
	TELEFONE CHAR(12) UNIQUE NOT NULL
);

CREATE TABLE AREAS(
	ID BIGINT PRIMARY KEY IDENTITY,
	NOME VARCHAR(200) UNIQUE NOT NULL
);

CREATE TABLE CARGOS(
	ID BIGINT PRIMARY KEY IDENTITY,
	NOME VARCHAR(200) UNIQUE NOT NULL,
	IDPESSOA BIGINT UNIQUE FOREIGN KEY REFERENCES AREAS(ID) NOT NULL
);

CREATE TABLE FUNCIONARIOS(
	ID BIGINT PRIMARY KEY IDENTITY,
	IDPESSOA BIGINT UNIQUE FOREIGN KEY REFERENCES PESSOAS(ID) NOT NULL,
	EMAIL VARCHAR(300) UNIQUE NOT NULL,
	IDCARGO BIGINT FOREIGN KEY REFERENCES CARGOS(ID) NOT NULL,
	SALARIO MONEY NOT NULL
);

CREATE TABLE DEPENDENTES(
	ID BIGINT PRIMARY KEY IDENTITY,
	IDPESSOA BIGINT UNIQUE FOREIGN KEY REFERENCES PESSOAS(ID) NOT NULL,
);
