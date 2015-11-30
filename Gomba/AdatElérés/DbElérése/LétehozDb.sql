-- Script Date: 2015. 11. 16. 19:18  - ErikEJ.SqlCeScripting version 3.5.2.56
-- Database information:
-- Database: C:\Users\szemu_000\Documents\Visual Studio 2015\Projects\Gomba\Gomba\bin\Debug\AdatElérés\Gomba.sqlite
-- ServerVersion: 3.8.11.1
-- DatabaseSize: 10 KB
-- Created: 2015. 11. 01. 21:11

-- User Table information:
-- Number of tables: 4
-- Beallitas: -1 row(s)
-- Dolgozo: -1 row(s)
-- Kezelo: -1 row(s)
-- Lada: -1 row(s)

SELECT 1;
PRAGMA foreign_keys=OFF;
BEGIN TRANSACTION;
CREATE TABLE [Lada] (
  [Id] bigint NOT NULL
, [Kod] nvarchar  NULL
, [Nev] nvarchar  NULL
, [Tara] decimal NOT NULL
, [Brutto] decimal NOT NULL
, [TaraTolTobb] decimal NOT NULL
, [TaraTolKevesebb] decimal NOT NULL
, [BruttoTolTobb] decimal NOT NULL
, [BruttoTolKevesebb] decimal NOT NULL
, CONSTRAINT [sqlite_master_PK_Lada] PRIMARY KEY ([Id])
);
CREATE TABLE [Kezelo] (
  [Id] bigint NOT NULL
, [Kod] nvarchar  NULL
, [Nev] nvarchar  NULL
, [UjAdat] int NOT NULL
, [Kimutatas] int NOT NULL
, [Beallitas] int NOT NULL
, [Jog1] int NOT NULL
, [Jog2] int NOT NULL
, [Jog3] int NOT NULL
, [Jog4] int NOT NULL
, [Jog5] int NOT NULL
, [Jog6] int NOT NULL
, [Jog7] int NOT NULL
, CONSTRAINT [sqlite_master_PK_Kezelo] PRIMARY KEY ([Id])
);
CREATE TABLE [Dolgozo] (
  [Id] bigint NOT NULL
, [Nev] nvarchar  NULL
, [SzuletesIdeje] datetime NOT NULL
, [Adoszam] nvarchar  NULL
, [Kod] nvarchar  NULL
, CONSTRAINT [sqlite_master_PK_Dolgozo] PRIMARY KEY ([Id])
);
CREATE TABLE [Beallitas] (
  [Id] bigint NOT NULL
, [Megnevezes] nvarchar  NULL
, [Erteke] nvarchar  NULL
, CONSTRAINT [sqlite_master_PK_Beallitas] PRIMARY KEY ([Id])
);
COMMIT;

