


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
);-- dorobic

create table competitions
(
	id serial primary key,
	idGames int references Games(id),
	time timestamp
		
);
create table EnrolledCompetitors
(
	id serial primary key,
	idGamers int references Gamers(id),
	idCompetitions int references Competitions(id)
	
);

create or replace view EnrolledCompetitorsList as
select competitions.time, Gamers.nick, Games.name
from EnrolledCompetitors join Gamers on EnrolledCompetitors.idGamers = Gamers.id
join Competitions on EnrolledCompetitors.idCompetitions = Competitions.id
join Games on Competitions.idGames = Games.id;

select * from EnrolledCompetitorsList;
-- w zglaszajacych sie competitors bedzie zglaszajacy sie zawodnik czyli id gamera i id zawodow
create or replace view GamerPlayedGameList as
select start, finish, Games.name, Gamers.nick from GamerPlayedGame 
join Games on GamerPlayedGame.idGames = Games.id
join Gamers on GamerPlayedGame.idGamers = Gamers.id;


select * from GamerPlayedGameList;
insert into GamerPlayedGame (idGamers, idGames, finish) values (1,2, '2022-01-12 20:00');



create or replace view GamersGamesList as

select Gamers.nick, Games.name from 
GamersGames join Games on GamersGames.idGames = Games.id
join Gamers on GamersGames.idGamers = Gamers.id;

select * from GamersGamesList;

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