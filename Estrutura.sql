drop TAble alunos
CREATE TABLE alunos(
		id INT IDENTITY(1,1),
        nome VARCHAR(100),
        matricula VARCHAR(100),
        nota01 FLOAT,
        nota02 FLOAT,
        nota03 FLOAT,
        frequencia TINYINT,
);

SELECT * FROM alunos