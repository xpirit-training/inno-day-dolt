create database getting_started;

use getting_started;

create table employees (
    id int,
    last_name varchar(255),
    first_name varchar(255),
    primary key(id));

create table teams (
    id int,
    team_name varchar(255),
    primary key(id));

create table employees_teams(
    team_id int,
    employee_id int,
    primary key(team_id, employee_id),
    foreign key (team_id) references teams(id),
    foreign key (employee_id) references employees(id));

show tables;