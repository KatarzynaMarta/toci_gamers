create table Gamers
(
	id serial primary key,
	nick text
);

create table Games
(
	id serial primary key,
	name text
);

create table GamersGames
(
	id serial primary key,
	idGamers int references Gamers(id),
	idGames int references Games(id)
);

create table GamerPlayedGame
(
	id serial primary key,
	idGamers int references Gamers(id),
	idGames int references Games(id),
	start timestamp default now(),
	finish timestamp
); -- dorobic 

select * from GamersGamesList;

create or replace view GamersGamesList as

select Gamers.nick, Games.name from 
GamersGames join Games on GamersGames.idGames = Games.id
join Gamers on GamersGames.idGamers = Gamers.id;

insert into Gamers (nick) values ('Mały512');
insert into Gamers (nick) values ('Patton888');

insert into Games (name) values ('Age of Empires II');
insert into Games (name) values ('Need for speed Porsche');
insert into Games (name) values ('Call of duty IV');

insert into GamersGames (idGamers, idGames) values (2, 2);
-- maly call
-- maly age
-- patton age
insert into GamersGames (idGamers, idGames) values (1, 3);
insert into GamersGames (idGamers, idGames) values (1, 1);
insert into GamersGames (idGamers, idGames) values (2, 1);

-- 1, 1, 1
-- 2, 1, 2