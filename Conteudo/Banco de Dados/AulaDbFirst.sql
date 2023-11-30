create database bancod;
use bancod;

create table clientes
(
	id INTEGER PRIMARY KEY IDENTITY,
	nome VARCHAR(100),
	email VARCHAR(100)
);

create table pedidos
(
	id INTEGER PRIMARY KEY IDENTITY,
	datapedido date,
	valor decimal(12,2),
	fk_cliente INTEGER,
	foreign key (fk_cliente) references clientes(id)
)

insert into clientes (nome, email) values ('Ricardo','ricardo@ufn.edu.br');
insert into clientes (nome, email) values ('Fabricio','fabricio@ufn.edu.br');
insert into clientes (nome, email) values ('Alexandre','alexz@ufn.edu.br');

insert into pedidos (datapedido, valor, fk_cliente) values ('2023-12-10', 153.50, 1);
insert into pedidos (datapedido, valor, fk_cliente) values ('2023-12-15', 179.50, 2);
insert into pedidos (datapedido, valor, fk_cliente) values ('2023-12-25', 1809.50, 3);
