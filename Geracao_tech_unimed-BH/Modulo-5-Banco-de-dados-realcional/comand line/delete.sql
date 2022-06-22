-- Excluindo dados tabela
SELECT * from cursos;
INSERT INTO cursos(nome) VALUES('economia');
SELECT * from cursos;
DELETE from cursos WHERE nome='economia'
SELECT * from cursos;