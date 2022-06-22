CREATE TABLE pessoas (
    id INT NOT NULL PRIMARY KEY AUTOINCREMENT,
    nome VARCHAR(30) NOT NULL,
    sobrenome VARCHAR(30) NOT NULL,
    nascimento DATE
)

INSERT INTO pessoa(nome, nascimento) VALUE('Rafael Diego', 'da Silva', '1923-08-19')
INSERT INTO pessoa(nome, nascimento) VALUE('Raquel', 'Oliveira', '1963-03-09')

-- Select
SELECT * FROM pessoa
SELECT nome FROM pessoa
SELECT sobrenome FROM pessoa


-- Update
UPDATE pessoa SET nome='Rafael' WHERE id=1 

-- Delete
SELECT * from pessoa WHERE id=1; -- Verifica o dado

DELETE from pessoa WHERE id=1 -- Deleta o dado

-- Ordenando
SELECT * FROM pessoa ORDER BY nome -- ordem crescente
SELECT * FROM pessoa ORDER BY nome DESC-- ordem decrescente

-- Criando nova coluna
UPDATE pessoa SET genero='M' WHERE id=2; -- Depois da criação da coluna

-- Agrupando e contado elementos
SELECT COUNT(id), genero FROM pessoa GROUP BY genero


-- *********** Introdução ao comand line ***********
-- Criando uma nova tabela
CREATE TABLE cursos(
    id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(10)
);

SHOW TABLES;

INSERT INTO cursos(nome) VALUES('MySQL');
INSERT INTO cursos(nome) VALUES('JavaScript');

SELECT * from cursos;

INSERT INTO cursos(nome) VALUES('HTML');

SELECT * from cursos;
UPDATE cursos SET nome='HTML 5' WHERE id=4;
SELECT * from cursos;

-- Excluindo dados tabela
SELECT * from cursos;
INSERT INTO cursos(nome) VALUES('economia');
SELECT * from cursos;
DELETE from cursos WHERE nome='economia'
SELECT * from cursos;

-- Criando uma nova coluna
ALTER TABLE cursos ADD carga_horaria INT(2);
SELECT * from cursos;

-- Atulizando as cargas horarias
SELECT * from cursos;
UPDATE cursos SET carga_horaria='8' WHERE nome='mysql';
SELECT * from cursos;

-- mysql> SELECT * from cursos;
-- +----+------------+---------------+
-- | id | nome       | carga_horaria |
-- +----+------------+---------------+
-- |  1 | MySQL      |             8 |
-- |  2 | JavaScript |          NULL |
-- |  3 | TypeScript |          NULL |
-- |  4 | HTML 5     |          NULL |
-- +----+------------+---------------+

SELECT * from cursos;
UPDATE cursos SET carga_horaria='48' WHERE nome='JavaScript';
UPDATE cursos SET carga_horaria='24' WHERE nome='TypeScript';
UPDATE cursos SET carga_horaria='12' WHERE nome='HTML 5';
SELECT * from cursos;

-- mysql> SELECT * from cursos;
-- +----+------------+---------------+
-- | id | nome       | carga_horaria |
-- +----+------------+---------------+
-- |  1 | MySQL      |             8 |
-- |  2 | JavaScript |            48 |
-- |  3 | TypeScript |            24 |
-- |  4 | HTML 5     |            12 |
-- +----+------------+---------------+

-- Deletando uma tabela

SHOW TABLES;
-- +----------------------------+
-- | Tables_in_banco_modv_mysql |
-- +----------------------------+
-- | cursos                     |
-- | pessoa                     |
-- | pessoas                    |
-- +----------------------------+

DROP TABLE pessoas;
SHOW TABLES;
-- +----------------------------+
-- | Tables_in_banco_modv_mysql |
-- +----------------------------+
-- | cursos                     |
-- | pessoa                     |
-- +----------------------------+

-- Deletando um Data Base
SHOW DATABASES;
-- +--------------------+
-- | Database           |
-- +--------------------+
-- | banco_modv_mysql   |
-- | information_schema |
-- | mysql              |
-- | performance_schema |
-- | phpmyadmin         |
-- | test               |
-- +--------------------+

CREATE DATABASE bd_teste;
-- +--------------------+
-- | Database           |
-- +--------------------+
-- | banco_modv_mysql   |
-- | bd_teste <--       |
-- | information_schema |
-- | mysql              |
-- | performance_schema |
-- | phpmyadmin         |
-- | test               |
-- +--------------------+

DROP DATABASE bd_teste;
-- +--------------------+
-- | Database           |
-- +--------------------+
-- | banco_modv_mysql   |
-- | information_schema |
-- | mysql              |
-- | performance_schema |
-- | phpmyadmin         |
-- | test               |
-- +--------------------+