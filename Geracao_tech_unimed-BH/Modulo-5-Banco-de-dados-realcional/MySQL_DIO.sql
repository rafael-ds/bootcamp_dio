CREATE TABLE pessoas (
    id INT NOT NULL PRIMARY KEY AUTOINCREMENT,
    nome VARCHAR(30) NOT NULL,
    sobrenome VARCHAR(30) NOT NULL,
    nascimento DATE
)

INSERT INTO pessoas(nome, nascimento) VALUE('Rafael Diego', 'da Silva', '1923-08-19')
INSERT INTO pessoas(nome, nascimento) VALUE('Raquel', 'Oliveira', '1963-03-09')