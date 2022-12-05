-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- ホスト: 127.0.0.1
-- 生成日時: 2022-12-05 08:10:45
-- サーバのバージョン： 10.4.24-MariaDB
-- PHP のバージョン: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- データベース: `unity-rpg`
--

-- --------------------------------------------------------

--
-- テーブルの構造 `enemytable`
--

CREATE TABLE `enemytable` (
  `ENEMY_ID` int(11) NOT NULL,
  `NAME` varchar(12) NOT NULL,
  `HP` int(11) NOT NULL DEFAULT 10,
  `AT` int(11) NOT NULL DEFAULT 1,
  `DEF` int(11) DEFAULT 1,
  `EXP` int(11) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- テーブルのデータのダンプ `enemytable`
--

INSERT INTO `enemytable` (`ENEMY_ID`, `NAME`, `HP`, `AT`, `DEF`, `EXP`) VALUES
(1, 'そうげんヘビ', 30, 10, 3, 50),
(2, 'くさトカゲ', 80, 15, 2, 70),
(3, 'トレント', 200, 7, 8, 100),
(4, 'アイスエッグ', 150, 30, 15, 150),
(5, 'フロストミミック', 120, 45, 10, 200),
(6, 'スノーゴーレム', 300, 25, 30, 300),
(7, 'あかおに', 300, 50, 40, 350),
(8, 'ひくいどり', 250, 40, 60, 400),
(9, 'ドラゴン', 500, 80, 80, 600);

-- --------------------------------------------------------

--
-- テーブルの構造 `itemtable`
--

CREATE TABLE `itemtable` (
  `ITEM_ID` int(11) NOT NULL,
  `NAME` varchar(12) NOT NULL,
  `HP` int(11) NOT NULL,
  `AT` int(11) NOT NULL,
  `DEF` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- テーブルの構造 `playertable`
--

CREATE TABLE `playertable` (
  `PLAYER_ID` int(11) NOT NULL,
  `NAME` varchar(12) NOT NULL,
  `LV` int(11) NOT NULL DEFAULT 1,
  `KISO_HP` int(11) NOT NULL DEFAULT 100,
  `KISO_AT` int(11) NOT NULL DEFAULT 10,
  `KISO_DEF` int(11) NOT NULL DEFAULT 10,
  `EXP` int(11) NOT NULL DEFAULT 0,
  `SOUBI_HP` int(11) NOT NULL DEFAULT 0,
  `SOUBI_AT` int(11) NOT NULL DEFAULT 0,
  `SOUBI_DEF` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- ダンプしたテーブルのインデックス
--

--
-- テーブルのインデックス `enemytable`
--
ALTER TABLE `enemytable`
  ADD PRIMARY KEY (`ENEMY_ID`);

--
-- テーブルのインデックス `itemtable`
--
ALTER TABLE `itemtable`
  ADD PRIMARY KEY (`ITEM_ID`);

--
-- テーブルのインデックス `playertable`
--
ALTER TABLE `playertable`
  ADD PRIMARY KEY (`PLAYER_ID`);

--
-- ダンプしたテーブルの AUTO_INCREMENT
--

--
-- テーブルの AUTO_INCREMENT `enemytable`
--
ALTER TABLE `enemytable`
  MODIFY `ENEMY_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- テーブルの AUTO_INCREMENT `itemtable`
--
ALTER TABLE `itemtable`
  MODIFY `ITEM_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- テーブルの AUTO_INCREMENT `playertable`
--
ALTER TABLE `playertable`
  MODIFY `PLAYER_ID` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
