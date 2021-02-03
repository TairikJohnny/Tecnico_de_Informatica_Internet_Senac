create database carinho_de_pet;

use carinho_de_pet;

create table pre_agendamento(
id_agendamento int primary key auto_increment,
nome varchar(50) not null,
telefone varchar(15) not null,
data_agendamento date not null,
animal varchar(30) not null,
necessidade varchar(100) not null
);

insert into pre_agendamento(nome, telefone, data_agendamento, animal, necessidade) values
("Rodrigo", "(99) 999999999", "2020/11/08", "Toto", "Vacina")

insert into pre_agendamento(nome, telefone, data_agendamento, animal, necessidade) values
("Roberta", "(88) 888888888", "2020/08/10", "Fred", "Internacao")

insert into pre_agendamento(nome, telefone, data_agendamento, animal, necessidade) values
("Ana", "(77) 777777777", "2020/02/28", "Luck", "Consulta")

select * from pre_agendamento