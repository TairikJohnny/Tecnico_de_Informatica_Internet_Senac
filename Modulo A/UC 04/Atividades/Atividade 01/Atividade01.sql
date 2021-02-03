create database Super;

use Super;

CREATE TABLE Produtos( 
idProduto INT AUTO_INCREMENT PRIMARY KEY, 
nomeProduto VARCHAR(200), 
valorProduto DOUBLE(9,2), 
quantidadeProduto INT 
);

insert into Produtos(nomeProduto, valorProduto, quantidadeProduto) values ("Leite integral", 2.10, 100);
insert into Produtos(nomeProduto, valorProduto, quantidadeProduto) values ("Pão de manteiga", 3.5, 125);
insert into Produtos(nomeProduto, valorProduto, quantidadeProduto) values ("Manteiga", 5.99, 60);
insert into Produtos(nomeProduto, valorProduto, quantidadeProduto) values ("Doce de morango", 2.9, 50);
insert into Produtos(nomeProduto, valorProduto, quantidadeProduto) values ("Queijo fatiado", 18.9, 60);

# Fase 3
create table Funcionarios( 
idFuncionario int auto_increment primary key, 
nomeFuncionario varchar(200), 
setorFuncionario varchar(80) 
);

insert into Funcionarios (nomeFuncionario, setorFuncionario) values ("João Paulo", "Atendente de padaria");
insert into Funcionarios (nomeFuncionario, setorFuncionario) values ("Adamastor Júnior", "Repositor");
insert into Funcionarios (nomeFuncionario, setorFuncionario) values ("Ana Cláudia", "Atendente de caixa");

select * from Funcionarios;

# Fase 4

alter table Funcionarios add column CPF int(11);

UPDATE Funcionarios SET CPF = 1234567899 WHERE idFuncionario = 1;
UPDATE Funcionarios SET CPF = 22566936987 WHERE idFuncionario = 2;
UPDATE Funcionarios SET CPF = 99885563591 WHERE idFuncionario = 3;

# fase 5

create table Consumidor( 
idConsumidor int auto_increment primary key, 
tipoConsumidor varchar(80)
);

create table Venda( 
idVenda int auto_increment primary key, 
idConsumidor int,
valorTotalVenda double(9,2),
constraint Venda_Consumidor_fk foreign key (idConsumidor) references Consumidor (idConsumidor)
);

select * from Venda;

create table Itens_Vendidos( 
idVenda int, 
idProduto int, 
quantidadeVendida int,
valorProduto double(9,2),
valorTotalProduto double(9,2),
constraint idVenda_idProduto_pk primary key (idVenda, idProduto)
);

insert into Consumidor (tipoConsumidor) values ("Frequente");
insert into Consumidor (tipoConsumidor) values ("Casual");
insert into Consumidor (tipoConsumidor) values ("Frequente");

select * from Consumidor;

insert into Venda (idConsumidor, valorTotalVenda) values (1, 100.00);
insert into Venda (idConsumidor, valorTotalVenda) values (2, 200.00);
insert into Venda (idConsumidor, valorTotalVenda) values (3, 300.00);
# Testando a integridade das tabelas tenatndo inserir um idConsumidor que não existe
# insert into Venda (idConsumidor, valorTotalVenda) values (4, 300.00);

select * from Venda;

select * from Produtos;

# venda 1
insert into Itens_Vendidos (idVenda, idProduto, quantidadeVendida, valorProduto, valorTotalProduto) values (1, 1, 10, 2.10, 2.4);
insert into Itens_Vendidos (idVenda, idProduto, quantidadeVendida, valorProduto, valorTotalProduto) values (1, 2, 5, 3.5, 4.2);
insert into Itens_Vendidos (idVenda, idProduto, quantidadeVendida, valorProduto, valorTotalProduto) values (1, 3, 2, 5.99, 7.18);
# venda 2
insert into Itens_Vendidos (idVenda, idProduto, quantidadeVendida, valorProduto, valorTotalProduto) values (2, 4, 3, 2.9, 3.48);
insert into Itens_Vendidos (idVenda, idProduto, quantidadeVendida, valorProduto, valorTotalProduto) values (2, 5, 1, 18.9, 22.68);
insert into Itens_Vendidos (idVenda, idProduto, quantidadeVendida, valorProduto, valorTotalProduto) values (2, 1, 2, 2.10, 2.4);

select * from Itens_Vendidos;

# valor total da venda 1
SELECT SUM(valorTotalProduto * quantidadeVendida) FROM Itens_Vendidos where idVenda = 1;

# valor total da venda 2
SELECT SUM(valorTotalProduto * quantidadeVendida) FROM Itens_Vendidos where idVenda = 2;
