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




