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

-- eliminar registros de la tabla libros para realizar las modificaiones
-- de la estructura desde la migración 20221025135225_CreateTableEditorial
delete from libros;