CREATE TABLE videos(
    id_video INT NULL PRIMARY KEY AUTO_INCREMENT,
    autor VARCHAR(30),
    titulo VARCHAR(30),
    likes INT,
    dislike INT,
)

INSERT INTO videos(autor, titulo, likes, deslike) VALUES('Kira', 'O livro DN', 30, 5);
INSERT INTO videos(autor, titulo, likes, deslike) VALUES('Manu', 'Pegando o osso', 310, 20);
INSERT INTO videos(autor, titulo, likes, deslike) VALUES('Romer', 'Porco aranha', 83, 1);
INSERT INTO videos(autor, titulo, likes, deslike) VALUES('Sheldon', 'A teoria do acaso', 230, 36);
INSERT INTO videos(autor, titulo, likes, deslike) VALUES('Volcan S', 'Cano JJ', 54, 1);

--************ Autores *************

CREATE TABLE autor(
    id_autor INT NULL PRIMARY KEY AUTO_INCREMENT,
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


-- *********** Join ************
-- SELECT * FROM videos JOIN autor ON videos.FK_autor = autor.id_autor;
-- +----------+----------+-------------------+-------+----------+----------+---------+------------+
-- | id_video | FK_autor | titulo            | likes | dislikes | id_autor | nome    | born       |
-- +----------+----------+-------------------+-------+----------+----------+---------+------------+
-- |        1 |        1 | Ricky and Morty   |   530 |        5 |        1 | Kira    | 1992-05-04 |
-- |        2 |        1 | Pegando o osso    |   310 |       20 |        1 | Kira    | 1992-05-04 |
-- |        3 |        1 | Porco aranha      |    83 |        1 |        1 | Kira    | 1992-05-04 |
-- |        4 |        2 | A teoria do acaso |   230 |       36 |        2 | Manu    | 2000-10-03 |
-- |        5 |        3 | Volcan S          |    54 |        1 |        3 | Romer   | 2010-12-29 |
-- |        6 |        4 | Mysql             |   148 |        2 |        4 | Sheldon | 0000-00-00 |
-- |        7 |        5 | Cano JJ           |    54 |        1 |        5 | Radis   | 1997-03-27 |
-- +----------+----------+-------------------+-------+----------+----------+---------+------------+


--************ SEO *************

CREATE TABLE categoria(
    id_seo INT NULL PRIMARY KEY AUTO_INCREMENT,
    categoria VARCHAR(30)
)

-- show tables;
-- +----------------------------+
-- | Tables_in_banco_modv_mysql |
-- +----------------------------+
-- | autor                      |
-- | seo                        |
-- | videos                     |
-- +----------------------------+

INSERT INTO seo(categoria) VALUES('motos');
INSERT INTO seo(categoria) VALUES('entreterimentos');
INSERT INTO seo(categoria) VALUES('pets');
INSERT INTO seo(categoria) VALUES('programação');
INSERT INTO seo(categoria) VALUES('outros');

-- select * from seo;
-- +--------+-----------------+
-- | id_seo | categoria       |
-- +--------+-----------------+
-- |      1 | entreterimentos |
-- |      2 | motos           |
-- |      3 | pets            |
-- |      4 | programação      |
-- |      5 | outros          |
-- +--------+-----------------+

--  select * from videos;
-- +----------+----------+-------------------+--------+-------+----------+
-- | id_video | FK_autor | titulo            | FK_seo | likes | dislikes |
-- +----------+----------+-------------------+--------+-------+----------+
-- |        1 |        1 | Ricky and Morty   |      0 |   530 |        5 |
-- |        2 |        1 | Pegando o osso    |      0 |   310 |       20 |
-- |        3 |        1 | Porco aranha      |      0 |    83 |        1 |
-- |        4 |        2 | A teoria do acaso |      0 |   230 |       36 |
-- |        5 |        3 | Volcan S          |      0 |    54 |        1 |
-- |        6 |        4 | Mysql             |      0 |   148 |        2 |
-- |        7 |        5 | Cano JJ           |      0 |    54 |        1 |
-- +----------+----------+-------------------+--------+-------+----------+

UPDATE videos SET FK_seo=1 WHERE id_video=1;
UPDATE videos SET FK_seo=1 WHERE id_video=3;
UPDATE videos SET FK_seo=1 WHERE id_video=4;

--  select * from videos;
-- +----------+----------+-------------------+--------+-------+----------+
-- | id_video | FK_autor | titulo            | FK_seo | likes | dislikes |
-- +----------+----------+-------------------+--------+-------+----------+
-- |        1 |        1 | Ricky and Morty   |      1 |   530 |        5 |
-- |        2 |        1 | Pegando o osso    |      0 |   310 |       20 |
-- |        3 |        1 | Porco aranha      |      1 |    83 |        1 |
-- |        4 |        2 | A teoria do acaso |      1 |   230 |       36 |
-- |        5 |        3 | Volcan S          |      0 |    54 |        1 |
-- |        6 |        4 | Mysql             |      0 |   148 |        2 |
-- |        7 |        5 | Cano JJ           |      0 |    54 |        1 |
-- +----------+----------+-------------------+--------+-------+----------+

UPDATE videos SET FK_seo=2 WHERE id_video=5;
UPDATE videos SET FK_seo=2 WHERE id_video=7;
-- select * from videos;
-- +----------+----------+-------------------+--------+-------+----------+
-- | id_video | FK_autor | titulo            | FK_seo | likes | dislikes |
-- +----------+----------+-------------------+--------+-------+----------+
-- |        1 |        1 | Ricky and Morty   |      1 |   530 |        5 |
-- |        2 |        1 | Pegando o osso    |      0 |   310 |       20 |
-- |        3 |        1 | Porco aranha      |      1 |    83 |        1 |
-- |        4 |        2 | A teoria do acaso |      1 |   230 |       36 |
-- |        5 |        3 | Volcan S          |      2 |    54 |        1 |
-- |        6 |        4 | Mysql             |      0 |   148 |        2 |
-- |        7 |        5 | Cano JJ           |      2 |    54 |        1 |
-- +----------+----------+-------------------+--------+-------+----------+

UPDATE videos SET FK_seo=3 WHERE id_video=2;
UPDATE videos SET FK_seo=4 WHERE id_video=6;

select * from videos;
-- +----------+----------+-------------------+--------+-------+----------+
-- | id_video | FK_autor | titulo            | FK_seo | likes | dislikes |
-- +----------+----------+-------------------+--------+-------+----------+
-- |        1 |        1 | Ricky and Morty   |      1 |   530 |        5 |
-- |        2 |        1 | Pegando o osso    |      3 |   310 |       20 |
-- |        3 |        1 | Porco aranha      |      1 |    83 |        1 |
-- |        4 |        2 | A teoria do acaso |      1 |   230 |       36 |
-- |        5 |        3 | Volcan S          |      2 |    54 |        1 |
-- |        6 |        4 | Mysql             |      4 |   148 |        2 |
-- |        7 |        5 | Cano JJ           |      2 |    54 |        1 |
-- +----------+----------+-------------------+--------+-------+----------+


-- Realizando consultas com JOIN parte 2

SELECT * FROM videos JOIN seo ON videos.FK_seo = seo.id_seo;
-- +----------+----------+-------------------+--------+-------+----------+--------+-----------------+
-- | id_video | FK_autor | titulo            | FK_seo | likes | dislikes | id_seo | categoria       |
-- +----------+----------+-------------------+--------+-------+----------+--------+-----------------+
-- |        1 |        1 | Ricky and Morty   |      1 |   530 |        5 |      1 | entreterimentos |
-- |        2 |        1 | Pegando o osso    |      3 |   310 |       20 |      3 | pets            |
-- |        3 |        1 | Porco aranha      |      1 |    83 |        1 |      1 | entreterimentos |
-- |        4 |        2 | A teoria do acaso |      1 |   230 |       36 |      1 | entreterimentos |
-- |        5 |        3 | Volcan S          |      2 |    54 |        1 |      2 | motos           |
-- |        6 |        4 | Mysql             |      4 |   148 |        2 |      4 | programação     |
-- |        7 |        5 | Cano JJ           |      2 |    54 |        1 |      2 | motos           |
-- +----------+----------+-------------------+--------+-------+----------+--------+-----------------+

SELECT videos.titulo, seo.categoria FROM videos JOIN seo ON videos.FK_seo = seo.id_seo;
-- +-------------------+-----------------+
-- | titulo            | categoria       |
-- +-------------------+-----------------+
-- | Ricky and Morty   | entreterimentos |
-- | Pegando o osso    | pets            |
-- | Porco aranha      | entreterimentos |
-- | A teoria do acaso | entreterimentos |
-- | Volcan S          | motos           |
-- | Mysql             | programação     |
-- | Cano JJ           | motos           |
-- +-------------------+-----------------+

SELECT videos.titulo, autor.nome, seo.categoria FROM videos JOIN seo ON videos.FK_seo = seo.id_seo
JOIN autor ON videos.FK_autor = autor.id_autor;

-- +-------------------+---------+-----------------+
-- | titulo            | nome    | categoria       |
-- +-------------------+---------+-----------------+
-- | Ricky and Morty   | Kira    | entreterimentos |
-- | Porco aranha      | Kira    | entreterimentos |
-- | A teoria do acaso | Manu    | entreterimentos |
-- | Volcan S          | Romer   | motos           |
-- | Cano JJ           | Radis   | motos           |
-- | Pegando o osso    | Kira    | pets            |
-- | Mysql             | Sheldon | programação     |
-- +-------------------+---------+-----------------+


--************ Play List *************

CREATE TABLE playlist(
    id_playlist INT NULL PRIMARY KEY AUTO_INCREMENT,
    categoria VARCHAR(30)
)

 show tables;
-- +----------------------------+
-- | Tables_in_banco_modv_mysql |
-- +----------------------------+
-- | autor                      |
-- | playlist                   |
-- | seo                        |
-- | videos                     |
-- +----------------------------+

INSERT INTO playlist(nome) VALUES('Serie');
INSERT INTO playlist(nome) VALUES('Animação');
INSERT INTO playlist(nome) VALUES('Veiculos');
INSERT INTO playlist(nome) VALUES('Humor');
INSERT INTO playlist(nome) VALUES('Cursos');

select * from playlist;
-- +-------------+----------+
-- | id_playlist | nome     |
-- +-------------+----------+
-- |           1 | Serie    |
-- |           2 | Animação |
-- |           3 | Veiculos |
-- |           4 | Humor    |
-- |           5 | Cursos   |
-- +-------------+----------+


CREATE TABLE videos_playlist(
    id_videos_playlist INT NULL PRIMARY KEY AUTO_INCREMENT,
    categoria VARCHAR(30)
)

show tables;
-- +----------------------------+
-- | Tables_in_banco_modv_mysql |
-- +----------------------------+
-- | autor                      |
-- | playlist                   |
-- | seo                        |
-- | videos                     |
-- | videos_playlist            |
-- +----------------------------+

INSERT INTO videos_playlist(FK_videos, FK_playlist) VALUES(1, 1);
INSERT INTO videos_playlist(FK_videos, FK_playlist) VALUES(4, 1);
INSERT INTO videos_playlist(FK_videos, FK_playlist) VALUES(3, 2);
INSERT INTO videos_playlist(FK_videos, FK_playlist) VALUES(5, 3);
INSERT INTO videos_playlist(FK_videos, FK_playlist) VALUES(7, 3);
INSERT INTO videos_playlist(FK_videos, FK_playlist) VALUES(2, 4);
INSERT INTO videos_playlist(FK_videos, FK_playlist) VALUES(6, 5);

select * from videos_playlist;
-- +-------+-----------+-------------+
-- | id_vp | FK_videos | FK_playlist |
-- +-------+-----------+-------------+
-- |     1 |         1 |           1 |
-- |     2 |         4 |           1 |
-- |     3 |         3 |           2 |
-- |     4 |         5 |           3 |
-- |     5 |         7 |           3 |
-- |     6 |         2 |           4 |
-- |     7 |         6 |           5 |
-- +-------+-----------+-------------+

SELECT * FROM playlist JOIN videos_playlist ON playlist.id_playlist = videos_playlist.FK_playlist;
-- +-------------+----------+-------+-----------+-------------+
-- | id_playlist | nome     | id_vp | FK_videos | FK_playlist |
-- +-------------+----------+-------+-----------+-------------+
-- |           1 | Serie    |     1 |         1 |           1 |
-- |           1 | Serie    |     2 |         4 |           1 |
-- |           2 | Animação |     3 |         3 |           2 |
-- |           3 | Veiculos |     4 |         5 |           3 |
-- |           3 | Veiculos |     5 |         7 |           3 |
-- |           4 | Humor    |     6 |         2 |           4 |
-- |           5 | Cursos   |     7 |         6 |           5 |
-- +-------------+----------+-------+-----------+-------------+

SELECT * FROM playlist JOIN videos_playlist ON playlist.id_playlist = videos_playlist.FK_playlist
JOIN videos on videos.id_video = videos_playlist.FK_videos;

-- +-------------+----------+-------+-----------+-------------+----------+----------+-------------------+--------+-------+----------+
-- | id_playlist | nome     | id_vp | FK_videos | FK_playlist | id_video | FK_autor | titulo            | FK_seo | likes | dislikes |
-- +-------------+----------+-------+-----------+-------------+----------+----------+-------------------+--------+-------+----------+
-- |           1 | Serie    |     1 |         1 |           1 |        1 |        1 | Ricky and Morty   |      1 |   530 |        5 |
-- |           1 | Serie    |     2 |         4 |           1 |        4 |        2 | A teoria do acaso |      1 |   230 |       36 |
-- |           2 | Animação |     3 |         3 |           2 |        3 |        1 | Porco aranha      |      1 |    83 |        1 |
-- |           3 | Veiculos |     4 |         5 |           3 |        5 |        3 | Volcan S          |      2 |    54 |        1 |
-- |           3 | Veiculos |     5 |         7 |           3 |        7 |        5 | Cano JJ           |      2 |    54 |        1 |
-- |           4 | Humor    |     6 |         2 |           4 |        2 |        1 | Pegando o osso    |      3 |   310 |       20 |
-- |           5 | Cursos   |     7 |         6 |           5 |        6 |        4 | Mysql             |      4 |   148 |        2 |
-- +-------------+----------+-------+-----------+-------------+----------+----------+-------------------+--------+-------+----------+

SELECT playlist.nome, videos.titulo FROM playlist JOIN videos_playlist ON playlist.id_playlist = videos_playlist.FK_playlist
JOIN videos on videos.id_video = videos_playlist.FK_videos;
-- +----------+-------------------+
-- | nome     | titulo            |
-- +----------+-------------------+
-- | Serie    | Ricky and Morty   |
-- | Serie    | A teoria do acaso |
-- | Animação | Porco aranha      |
-- | Veiculos | Volcan S          |
-- | Veiculos | Cano JJ           |
-- | Humor    | Pegando o osso    |
-- | Cursos   | Mysql             |
-- +----------+-------------------+
