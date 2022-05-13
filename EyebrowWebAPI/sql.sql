create database Eyebrow;

create table Announcement
(
	Id int auto_increment primary key,
    Title varchar(255),
    Content varchar(1500),
    Statu bool,
    Create_Time datetime
);

create table Sys_Setting
(
    Id int auto_increment primary key,
	SS_Key varchar(255) primary key,
	SS_Type varchar(255),
    SS_Value varchar(1500),
    SS_Dese varchar(255),
    SS_Order int
);

create table Sys_Code
(
	Id int auto_increment primary key,
	SC_Type varchar(255),
    SC_Code varchar(255),
    SC_Desc varchar(255),
    SC_Order int
);