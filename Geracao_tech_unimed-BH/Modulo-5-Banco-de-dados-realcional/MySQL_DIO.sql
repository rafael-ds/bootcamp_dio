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