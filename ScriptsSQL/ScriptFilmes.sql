-- 1 - Buscar o nome e ano dos filmes
SELECT NOME, ANO FROM FILMES

-- 2 - Buscar o nome e ano dos filmes, ordenados por ordem crescente pelo ano
SELECT NOME, ANO FROM FILMES ORDER BY ANO 

-- 3 - Buscar pelo filme de volta para o futuro, trazendo o nome, ano e a duração
SELECT NOME, ANO, DURACAO FROM FILMES WHERE NOME = 'De volta para o futuro'

-- 4 - Buscar os filmes lançados em 1997
SELECT NOME, ANO, DURACAO FROM FILMES WHERE ANO = 1997

-- 5 - Buscar os filmes lançados APÓS o ano 2000
SELECT NOME, ANO, DURACAO FROM FILMES WHERE ANO > 2000

-- 6 - Buscar os filmes com a duracao maior que 100 e menor que 150, ordenando pela duracao em ordem crescente
SELECT NOME, ANO, DURACAO FROM FILMES WHERE DURACAO > 100 AND DURACAO < 150 ORDER BY DURACAO

-- 7 - Buscar a quantidade de filmes lançadas no ano, agrupando por ano, ordenando pela duracao em ordem decrescente
SELECT COUNT(ANO) QUANTIDADE FROM FILMES WHERE COUNT(ANO) ORDER BY DURACAO ASC

-- 8 - Buscar os Atores do gênero masculino, retornando o PrimeiroNome, UltimoNome
SELECT * FROM ATORES WHERE GENERO = 'M'

-- 9 - Buscar os Atores do gênero feminino, retornando o PrimeiroNome, UltimoNome, e ordenando pelo PrimeiroNome
SELECT * FROM ATORES WHERE GENERO = 'F' ORDER BY PrimeiroNome

-- 10 - Buscar o nome do filme e o gênero
SELECT NOME, GENERO FROM FILMES F INNER JOIN GENEROS G ON F.Id = G.Id

-- 11 - Buscar o nome do filme e o gênero do tipo "Mistério"
SELECT NOME, GENERO FROM FILMES F INNER JOIN GENEROS G ON F.Id = G.Id WHERE GENERO = 'Mistério'

-- 12 - Buscar o nome do filme e os atores, trazendo o PrimeiroNome, UltimoNome e seu Papel
SELECT NOME, PRIMEIRONOME, ULTIMONOME, PAPEL FROM FILMES F INNER JOIN ATORES A ON F.ID = A.ID INNER JOIN ELENCOFILME E ON F.ID = E.ID