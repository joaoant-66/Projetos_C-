-- SISTEMA DE CADASTRO DE CLIENTES DE SEGURO DE VIDA COM C# E BANCO DE DADOS SQL ---

Projeto realizado em 2022 para projeto acadêmico. Consiste de um programa para Desktop, com
uma interface gráfica construída com a linguagem C#, para um sistema de cadastro para uma 
empresa fictícia de Seguros de Vida. O programa realiza cadastros de clientes, com todos os
dados importantes, e salva eles em tabelas criadas para um banco de dados local em SQL. O programa também possui uma área aonde é possível realizar a atualização de campos específicos de dados de um cliente, e outra área para a visualização de todos os clientes
cadastrados, com uma barra de pesquisa(aonde ele procura os dados pela tabela de clientes do banco de dados); E na questão do usuário, para acesso ao programa é necessário a criação 
de uma conta para realização do login, e a conta será salva também em outra tabela no banco de dados.

----------------------------------------------------------------------------------

A seguir, os scripts das duas tabelas do banco de dados:

CREATE TABLE tb_cliente(

Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
status CHAR(4) NOT NULL,
nome NVARCHAR(50) NOT NULL,
sexo NVARCHAR(50) NOT NULL,
datanascimento DATE NOT NULL,
CPF NVARCHAR(50) NOT NULL,
RG NVARCHAR(50) NOT NULL,
CEP NVARCHAR(50) NOT NULL,
endereco NVARCHAR(50) NOT NULL,
condicoes_medicas NVARCHAR(50),
beneficiario_nome1 NVARCHAR(50),
CPF_beneficiario1 NVARCHAR(50),
RG_beneficiario1 NVARCHAR(50),
beneficiario_nome2 NVARCHAR(50),
CPF_beneficiario2 NVARCHAR(50),
RG_beneficiario2 NVARCHAR(50),
beneficiarionome3 NVARCHAR(50),
CPF_beneficiario3 NVARCHAR(50),
RG_beneficiario3 NVARCHAR(50),
forma_pagamento NVARCHAR(50) NOT NULL,
data_pagamento DATE NOT NULL,
valor_mensalidade DECIMAL(5,2) NOT NULL

);

CREATE TABLE tb_usuario(

Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
nome NVARCHAR(50) NOT NULL,
email NVARCHAR(50) NOT NULL,
idade NVARCHAR(50) NOT NULL,
RG NVARCHAR(50) NOT NULL,
CPF NVARCHAR(50) NOT NULL,
sexo NVARCHAR(50) NOT NULL,
senha NVARCHAR(50) NOT NULL,

);