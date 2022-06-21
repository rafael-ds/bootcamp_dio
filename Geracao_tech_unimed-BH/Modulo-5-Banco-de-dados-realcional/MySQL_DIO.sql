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