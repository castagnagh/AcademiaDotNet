CREATE DATABASE biblioteca;
DROP DATABASE biblioteca;

CREATE TABLE nacionalidades
(
	id INTEGER PRIMARY KEY NOT NULL IDENTITY,
	pais VARCHAR(20) NOT NULL
)

CREATE TABLE categorias
(
	id INTEGER PRIMARY KEY NOT NULL IDENTITY,
	nome VARCHAR(30) NOT NULL
)

CREATE TABLE editoras
(
	id INTEGER NOT NULL PRIMARY KEY IDENTITY,
	nome VARCHAR(60) NOT NULL
)

CREATE TABLE autores
(
	id INTEGER PRIMARY KEY NOT NULL IDENTITY,
	nome VARCHAR(50) NOT NULL,
	fk_nacionalidade INTEGER NOT NULL,
	FOREIGN KEY (fk_nacionalidade) REFERENCES nacionalidades(id)
)

CREATE TABLE livros
(
	id INTEGER PRIMARY KEY NOT NULL IDENTITY,
	titulo VARCHAR(40) NOT NULL,
	ano INTEGER NOT NULL,
	fk_editora INTEGER NOT NULL,
	fk_categoria INTEGER NOT NULL,
	FOREIGN KEY (fk_categoria) REFERENCES categorias(id),
	FOREIGN KEY (fk_editora) REFERENCES editoras(id)
)

CREATE TABLE livros_autores
(
	id INTEGER NOT NULL PRIMARY KEY IDENTITY,
	fk_autor INTEGER NOT NULL,
	fk_livro INTEGER NOT NULL,
	FOREIGN KEY (fk_autor) REFERENCES autores(id),
	FOREIGN KEY (fk_livro) REFERENCES livros(id),
)

INSERT INTO editoras (nome) VALUES ('Rocco');
INSERT INTO editoras (nome) VALUES ('WMF Martins Fontes');
INSERT INTO editoras (nome) VALUES ('Casa das Palavras');
INSERT INTO editoras (nome) VALUES ('Belas Letras');
INSERT INTO editoras (nome) VALUES ('Matrix');


INSERT INTO nacionalidades (pais) VALUES ('Inglaterra');
INSERT INTO nacionalidades (pais) VALUES ('Brasil');

INSERT INTO autores (nome, fk_nacionalidade) VALUES ('J.K Rowling', 1);
INSERT INTO autores (nome, fk_nacionalidade) VALUES ('Clive Staples Lewis', 1);
INSERT INTO autores (nome, fk_nacionalidade) VALUES ('Affonso Solano', 2);
INSERT INTO autores (nome, fk_nacionalidade) VALUES ('Marcos Piangers', 2);
INSERT INTO autores (nome, fk_nacionalidade) VALUES ('Ciro Botelho - Tiririca', 2);
INSERT INTO autores (nome, fk_nacionalidade) VALUES ('Bianca Mól', 2);

INSERT INTO categorias VALUES ('Literatura Juvenil');
INSERT INTO categorias VALUES ('Ficção Científica');
INSERT INTO categorias VALUES ('Humor');

INSERT INTO livros (titulo, ano, fk_editora, fk_categoria) VALUES ('Harry Potter e A Pedra Filosofal', 2000, 1, 1);
INSERT INTO livros (titulo, ano, fk_editora, fk_categoria) VALUES ('As crônicas de Nárnia', 2009, 2, 1);
INSERT INTO livros (titulo, ano, fk_editora, fk_categoria) VALUES ('O Espadachim de Carvão', 2013, 3, 2);
INSERT INTO livros (titulo, ano, fk_editora, fk_categoria) VALUES ('O Papai é Pop', 2015, 4, 3);
INSERT INTO livros (titulo, ano, fk_editora, fk_categoria) VALUES ('Pior Que Ta Não Fica', 2015, 5, 3);
INSERT INTO livros (titulo, ano, fk_editora, fk_categoria) VALUES ('Garota Desdobrável', 2015, 3, 1);
INSERT INTO livros (titulo, ano, fk_editora, fk_categoria) VALUES ('Harry Potter e o Prisioneiro de Azkaban', 2000, 1, 1);

INSERT INTO livros_autores VALUES (1,1);
INSERT INTO livros_autores VALUES (2,2);
INSERT INTO livros_autores VALUES (3,3);
INSERT INTO livros_autores VALUES (4,4);
INSERT INTO livros_autores VALUES (5,5);
INSERT INTO livros_autores VALUES (6,6);
INSERT INTO livros_autores VALUES (1,7);

SELECT * FROM nacionalidades;
SELECT * FROM categorias;
SELECT * FROM editoras;
SELECT * FROM autores;
SELECT * FROM livros;
SELECT * FROM livros_autores;

--7
SELECT livros.titulo, livros.ano, editoras.nome, categorias.nome
from livros, editoras, categorias
where livros.fk_editora = editoras.id and
livros.fk_categoria = categorias.id
order by livros.titulo, livros.ano asc

--8
SELECT livros.titulo, livros.ano, autores.nome, editoras.nome, categorias.nome
from livros, editoras, categorias, livros_autores, autores
where livros.fk_editora = editoras.id and
livros.fk_categoria = categorias.id and
livros_autores.fk_livro = livros.id and
livros_autores.fk_autor = autores.id
order by autores.nome

--9
SELECT livros.titulo, livros.ano, autores.nome, editoras.nome, categorias.nome
from livros, editoras, categorias, livros_autores, autores
where livros.fk_editora = editoras.id and
livros.fk_categoria = categorias.id and
livros_autores.fk_livro = livros.id and
livros_autores.fk_autor = autores.id and
categorias.nome = 'Literatura Juvenil'
order by livros.ano

--10
SELECT livros.titulo, livros.ano, autores.nome, editoras.nome, categorias.nome
from livros, editoras, categorias, livros_autores, autores
where livros.fk_editora = editoras.id and
livros.fk_categoria = categorias.id and
livros_autores.fk_livro = livros.id and
livros_autores.fk_autor = autores.id and
livros.ano between 2000 AND 2010 and
(categorias.nome = 'Humor' or
categorias.nome = 'Ficção Científica')
ORDER BY livros.titulo

--Com INNER JOIN - 7
SELECT livros.titulo, livros.ano, editoras.nome, categorias.nome
from livros
inner join editoras on livros.fk_editora = editoras.id
inner join categorias on livros.fk_categoria = categorias.id
order by livros.titulo, livros.ano asc

--Com INNER JOIN - 8
SELECT livros.titulo, livros.ano, autores.nome, editoras.nome, categorias.nome
from livros
inner join editoras on livros.fk_editora = editoras.id
inner join categorias on livros.fk_categoria = categorias.id
inner join livros_autores on livros_autores.fk_livro = livros.id
inner join autores on livros_autores.fk_autor = autores.id
order by autores.nome

-- Com INNER JOIN - 9
SELECT livros.titulo, livros.ano, autores.nome, editoras.nome, categorias.nome
from livros
INNER JOIN editoras ON livros.fk_editora = editoras.id
inner join categorias on livros.fk_categoria = categorias.id
inner join livros_autores on livros_autores.fk_livro = livros.id
inner join autores on livros_autores.fk_autor = autores.id where
categorias.nome = 'Literatura Juvenil'
order by livros.ano

--Com INNER JOIN - 10
SELECT livros.titulo, livros.ano, autores.nome, editoras.nome, categorias.nome
from livros
INNER JOIN editoras ON livros.fk_editora = editoras.id
inner join categorias on livros.fk_categoria = categorias.id
inner join livros_autores on livros_autores.fk_livro = livros.id
inner join autores on livros_autores.fk_autor = autores.id
where livros.ano between 2000 AND 2010 and
(categorias.nome = 'Humor' or
categorias.nome = 'Ficção Científica')
ORDER BY livros.titulo