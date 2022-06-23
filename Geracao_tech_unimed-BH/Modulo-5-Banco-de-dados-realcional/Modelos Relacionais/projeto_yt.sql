CREATE TABLE videos(
    id INT NULL PRIMARY KEY AUTO_INCREMENT,
    autor VARCHAR(30),
    titulo VARCHAR(30),
    likes INT,
    deslike INT,
)

INSERT INTO videos(autor, titulo, likes, deslike) VALUES('Kira', 'O livro DN', 30, 5);
INSERT INTO videos(autor, titulo, likes, deslike) VALUES('Manu', 'Pegando o osso', 310, 20);
INSERT INTO videos(autor, titulo, likes, deslike) VALUES('Romer', 'Porco aranha', 83, 1);
INSERT INTO videos(autor, titulo, likes, deslike) VALUES('Sheldon', 'A teoria do acaso', 230, 36);
INSERT INTO videos(autor, titulo, likes, deslike) VALUES('Volcan S', 'Cano JJ', 54, 1);

--************ Autores *************

CREATE TABLE autor(
    id INT NULL PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(30),
    data_nasciento DATE,
)

INSERT INTO autor(nome, born) VALUES('Kira', '1992-05-04');
INSERT INTO autor(nome, born) VALUES('Manu', '2000-10-03');
INSERT INTO autor(nome, born) VALUES('Romer', '2010-12-29');
INSERT INTO autor(nome, born) VALUES('Sheldon', '2015-02-30');
INSERT INTO autor(nome, born) VALUES('Radis', '1997-03-27');
INSERT INTO autor(nome, born) VALUES('Rafael', '1988-08-17');
INSERT INTO autor(nome, born) VALUES('Kawasaki', '2010-06-03');
INSERT INTO autor(nome, born) VALUES('Xbox', '2014-03-13');


-- ****** Criando realcionamentos *********

--  show tables;
-- +----------------------------+
-- | Tables_in_banco_modv_mysql |
-- +----------------------------+
-- | autor                      |
-- | videos                     |
-- +----------------------------+

--  select * from autor;
-- +----------+----------+------------+
-- | id_autor | nome     | born       |
-- +----------+----------+------------+
-- |        1 | Kira     | 1992-05-04 |
-- |        2 | Manu     | 2000-10-03 |
-- |        3 | Romer    | 2010-12-29 |
-- |        4 | Sheldon  | 0000-00-00 |
-- |        5 | Radis    | 1997-03-27 |
-- |        6 | Rafael   | 1988-08-17 |
-- |        7 | Kawasaki | 2010-06-03 |
-- |        8 | Xbox     | 2014-03-13 |
-- +----------+----------+------------+


--  select * from videos;
-- +----------+-------+-------------------+-------+----------+
-- | id_video | autor | titulo            | likes | dislikes |
-- +----------+-------+-------------------+-------+----------+
-- |        1 |     0 | Ricky and Morty   |   530 |        5 |
-- |        2 |     0 | Pegando o osso    |   310 |       20 |
-- |        3 |     0 | Porco aranha      |    83 |        1 |
-- |        4 |     0 | A teoria do acaso |   230 |       36 |
-- |        5 |     0 | Volcan S          |    54 |        1 |
-- |        6 |     0 | Mysql             |   148 |        2 |
-- |        7 |     0 | Cano JJ           |    54 |        1 |
-- +----------+-------+-------------------+-------+----------+

UPDATE videos SET autor=1 WHERE id_video=1;
-- select * from videos;
-- +----------+-------+-------------------+-------+----------+
-- | id_video | autor | titulo            | likes | dislikes |
-- +----------+-------+-------------------+-------+----------+
-- |        1 |     1 | Ricky and Morty   |   530 |        5 |
-- |        2 |     0 | Pegando o osso    |   310 |       20 |
-- |        3 |     0 | Porco aranha      |    83 |        1 |
-- |        4 |     0 | A teoria do acaso |   230 |       36 |
-- |        5 |     0 | Volcan S          |    54 |        1 |
-- |        6 |     0 | Mysql             |   148 |        2 |
-- |        7 |     0 | Cano JJ           |    54 |        1 |
-- +----------+-------+-------------------+-------+----------+


UPDATE videos SET autor=1 WHERE id_video=2;
UPDATE videos SET autor=1 WHERE id_video=3;

-- select * from videos;
-- +----------+-------+-------------------+-------+----------+
-- | id_video | autor | titulo            | likes | dislikes |
-- +----------+-------+-------------------+-------+----------+
-- |        1 |     1 | Ricky and Morty   |   530 |        5 |
-- |        2 |     1 | Pegando o osso    |   310 |       20 |
-- |        3 |     1 | Porco aranha      |    83 |        1 |
-- |        4 |     0 | A teoria do acaso |   230 |       36 |
-- |        5 |     0 | Volcan S          |    54 |        1 |
-- |        6 |     0 | Mysql             |   148 |        2 |
-- |        7 |     0 | Cano JJ           |    54 |        1 |
-- +----------+-------+-------------------+-------+----------+

UPDATE videos SET autor=2 WHERE id_video=4;
UPDATE videos SET autor=3 WHERE id_video=5;
UPDATE videos SET autor=4 WHERE id_video=6;
UPDATE videos SET autor=5 WHERE id_video=7;

-- select * from videos;
-- +----------+-------+-------------------+-------+----------+
-- | id_video | autor | titulo            | likes | dislikes |
-- +----------+-------+-------------------+-------+----------+
-- |        1 |     1 | Ricky and Morty   |   530 |        5 |
-- |        2 |     1 | Pegando o osso    |   310 |       20 |
-- |        3 |     1 | Porco aranha      |    83 |        1 |
-- |        4 |     2 | A teoria do acaso |   230 |       36 |
-- |        5 |     3 | Volcan S          |    54 |        1 |
-- |        6 |     4 | Mysql             |   148 |        2 |
-- |        7 |     5 | Cano JJ           |    54 |        1 |
-- +----------+-------+-------------------+-------+----------+


