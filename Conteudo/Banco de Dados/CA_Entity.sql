create database aulaentity;

create login aulaentity with password='senha1234';
create user aulaentity from login aulaentity;
exec sp_addrolemember 'DB_DATAREADER', 'aulaentity';
exec sp_addrolemember 'DB_DATAWRITER', 'aulaentity';

select * from pessoas
select * from emails