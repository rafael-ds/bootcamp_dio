-- Criando uma nova coluna
SELECT * from cursos;

-- +----+------------+
-- | id | nome       |
-- +----+------------+
-- |  1 | MySQL      |
-- |  2 | JavaScript |
-- |  3 | TypeScript |
-- |  4 | HTML 5     |
-- +----+------------+

ALTER TABLE cursos ADD carga_horaria INT(2);
SELECT * from cursos;

-- +----+------------+---------------+
-- | id | nome       | carga_horaria |
-- +----+------------+---------------+
-- |  1 | MySQL      |          NULL |
-- |  2 | JavaScript |          NULL |
-- |  3 | TypeScript |          NULL |
-- |  4 | HTML 5     |          NULL |
-- +----+------------+---------------+