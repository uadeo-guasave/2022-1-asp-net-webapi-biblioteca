-- SQLite
select * from autores;

-- show tables; (mysql)
pragma table_list;

-- desc libros; (mysql)
PRAGMA table_info('Libros');

select * from libros;

-- select join libros autores
select * from libros
join autores
on libros.AutorId = Autores.Id;

select * from autores
left join libros
on Autores.id = Libros.AutorId;