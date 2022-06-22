-- Atulizando as cargas horarias
SELECT * from cursos;
-- +----+------------+---------------+
-- | id | nome       | carga_horaria |
-- +----+------------+---------------+
-- |  1 | MySQL      |          NULL |
-- |  2 | JavaScript |          NULL |
-- |  3 | TypeScript |          NULL |
-- |  4 | HTML 5     |          NULL |
-- +----+------------+---------------+


UPDATE cursos SET carga_horaria='8' WHERE nome='mysql';
SELECT * from cursos;
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

-- +----+------------+---------------+
-- | id | nome       | carga_horaria |
-- +----+------------+---------------+
-- |  1 | MySQL      |             8 |
-- |  2 | JavaScript |            48 |
-- |  3 | TypeScript |            24 |
-- |  4 | HTML 5     |            12 |
-- +----+------------+---------------+