-- phpMyAdmin SQL Dump
-- version 4.7.7
-- https://www.phpmyadmin.net/
--
-- Host: localhost:8889
-- Generation Time: May 17, 2019 at 11:00 PM
-- Server version: 5.6.38
-- PHP Version: 7.2.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `jared_farkas`
--
CREATE DATABASE IF NOT EXISTS `jared_farkas` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `jared_farkas`;

-- --------------------------------------------------------

--
-- Table structure for table `client`
--

CREATE TABLE `client` (
  `id` int(11) NOT NULL,
  `name` text,
  `stylist` int(11) NOT NULL,
  `hair` int(11) NOT NULL,
  `haircut` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `join`
--

CREATE TABLE `join` (
  `id` int(11) NOT NULL,
  `scissors_id` int(11) NOT NULL,
  `client_id` int(11) NOT NULL,
  `stylist_id` int(11) NOT NULL,
  `prefix_id` int(11) NOT NULL,
  `suffix_id` int(11) NOT NULL,
  `specialty_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `join`
--

INSERT INTO `join` (`id`, `scissors_id`, `client_id`, `stylist_id`, `prefix_id`, `suffix_id`, `specialty_id`) VALUES
(1, 0, 0, 2, 0, 0, 0),
(2, 0, 0, 2, 0, 0, 0),
(3, 0, 0, 2, 0, 0, 0),
(4, 0, 0, 2, 0, 0, 0),
(5, 0, 0, 2, 0, 0, 0),
(6, 0, 0, 2, 0, 0, 0),
(7, 0, 0, 2, 0, 0, 1),
(8, 0, 0, 1, 0, 0, 1);

-- --------------------------------------------------------

--
-- Table structure for table `prefix`
--

CREATE TABLE `prefix` (
  `id` int(11) NOT NULL,
  `name` text,
  `max_value` int(11) NOT NULL,
  `min_value` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `prefix`
--

INSERT INTO `prefix` (`id`, `name`, `max_value`, `min_value`) VALUES
(1, 'Sturdy', 3, 2),
(2, 'Strong', 5, 3),
(3, 'Sharp', 10, 5),
(4, 'Steel', 15, 8),
(5, 'Silver', 20, 10),
(6, 'Gold', 25, 13),
(7, 'Diamond', 35, 18),
(8, 'Magic', 50, 25);

-- --------------------------------------------------------

--
-- Table structure for table `scissors`
--

CREATE TABLE `scissors` (
  `id` int(11) NOT NULL,
  `name` text,
  `prefix_1` int(11) NOT NULL,
  `prefix_1_value` int(11) NOT NULL,
  `prefix_2` int(11) NOT NULL,
  `prefix_2_value` int(11) NOT NULL,
  `suffix_1` int(11) NOT NULL,
  `suffix_1_value` int(11) NOT NULL,
  `suffix_2` int(11) NOT NULL,
  `suffix_2_value` int(11) NOT NULL,
  `quality` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `scissors`
--

INSERT INTO `scissors` (`id`, `name`, `prefix_1`, `prefix_1_value`, `prefix_2`, `prefix_2_value`, `suffix_1`, `suffix_1_value`, `suffix_2`, `suffix_2_value`, `quality`) VALUES
(0, 'Scissors', 0, 0, 0, 0, 0, 0, 0, 0, 0),
(2, 'Scissors', 0, 0, 0, 0, 0, 0, 0, 0, 0),
(3, 'GoldScissors', 6, 46, 0, 0, 0, 0, 0, 0, 0),
(4, 'SteelScissors', 4, 22, 0, 0, 0, 0, 0, 0, 0),
(5, 'SteelScissors', 4, 27, 0, 0, 0, 0, 0, 0, 0),
(6, 'Scissors Of Chance and Chance', 0, 0, 0, 0, 7, 1, 7, 1, 0),
(7, 'Steel, Strong Scissors Of Fortune', 4, 24, 2, 8, 9, 5, 0, 0, 0),
(8, 'Strong Scissors', 2, 7, 0, 0, 0, 0, 0, 0, 0),
(9, 'Steel Scissors Of Safety', 4, 27, 0, 0, 5, 17, 0, 0, 0),
(10, ' Scissors', 0, 0, 0, 0, 0, 0, 0, 0, 0),
(11, 'Magic Scissors', 8, 100, 0, 0, 0, 0, 0, 0, 0),
(12, ' Scissors Of Cutting', 0, 0, 0, 0, 3, 7, 0, 0, 0),
(13, ' Scissors Of Fortune', 0, 0, 0, 0, 9, 5, 0, 0, 0),
(14, ' Scissors Of Weakness and Chance', 0, 0, 0, 0, 1, 2, 7, 1, 0),
(15, 'Strong Scissors', 2, 6, 0, 0, 0, 0, 0, 0, 0),
(16, 'Steel, Magic Scissors Of Fortune and Safety', 4, 29, 8, 100, 9, 5, 5, 15, 0),
(17, ' Scissors Of Fragility', 0, 0, 0, 0, 3, 6, 0, 0, 0),
(18, 'Gold Scissors Of Fortune', 6, 48, 0, 0, 9, 5, 0, 0, 0),
(19, 'Magic, Steel Scissors Of Weakness', 8, 100, 4, 26, 1, 3, 0, 0, 0),
(20, ' Scissors', 0, 0, 0, 0, 0, 0, 0, 0, 0),
(21, ' Scissors Of Weakness', 0, 0, 0, 0, 1, 4, 0, 0, 0),
(22, 'Steel Scissors', 4, 25, 0, 0, 0, 0, 0, 0, 0),
(23, ' Scissors Of Fragility', 0, 0, 0, 0, 3, 8, 0, 0, 0),
(24, ' Scissors', 0, 0, 0, 0, 0, 0, 0, 0, 0),
(25, 'Gold Scissors Of Safety and Weakness', 6, 42, 0, 0, 5, 12, 1, 1, 0),
(26, 'Steel, Strong Scissors', 4, 22, 2, 8, 0, 0, 0, 0, 0),
(27, ' Scissors Of Chance and Fortune', 0, 0, 0, 0, 7, 1, 9, 5, 0),
(28, 'Magic Scissors Of Safety', 8, 100, 0, 0, 5, 18, 0, 0, 0),
(29, 'Strong Scissors', 2, 7, 0, 0, 0, 0, 0, 0, 0),
(30, ' Scissors Of Chance', 0, 0, 0, 0, 7, 1, 0, 0, 0),
(31, 'Strong Scissors', 2, 9, 0, 0, 0, 0, 0, 0, 0),
(32, ' Scissors Of Weakness', 0, 0, 0, 0, 1, 4, 0, 0, 0),
(33, ' Scissors Of Chance', 0, 0, 0, 0, 7, 1, 0, 0, 0),
(34, ' Scissors Of Fortune', 0, 0, 0, 0, 9, 5, 0, 0, 0),
(35, ' Scissors', 0, 0, 0, 0, 0, 0, 0, 0, 0),
(36, 'Strong Scissors Of Fortune and Safety', 2, 9, 0, 0, 9, 5, 5, 11, 0),
(37, 'Gold, Magic Scissors Of Fragility and Fortune', 6, 45, 8, 100, 3, 8, 9, 5, 0),
(38, 'Steel, Magic Scissors Of Fragility', 4, 28, 8, 100, 3, 9, 0, 0, 0),
(39, 'Strong Scissors', 2, 8, 0, 0, 0, 0, 0, 0, 0),
(40, ' Scissors', 0, 0, 0, 0, 0, 0, 0, 0, 0),
(41, 'Gold Scissors', 6, 43, 0, 0, 0, 0, 0, 0, 0),
(42, ' Scissors', 0, 0, 0, 0, 0, 0, 0, 0, 0),
(43, 'Steel Scissors', 4, 26, 0, 0, 0, 0, 0, 0, 0),
(44, ' Scissors Of Chance', 0, 0, 0, 0, 7, 1, 0, 0, 0),
(45, ' Scissors', 0, 0, 0, 0, 0, 0, 0, 0, 0),
(46, ' Scissors Of Chance', 0, 0, 0, 0, 7, 1, 0, 0, 0),
(47, ' Scissors Of Chance and Fragility', 0, 0, 0, 0, 7, 1, 3, 6, 0),
(48, 'Gold Scissors', 6, 45, 0, 0, 0, 0, 0, 0, 0),
(49, ' Scissors', 0, 0, 0, 0, 0, 0, 0, 0, 0),
(50, 'Gold Scissors Of Weakness', 6, 44, 0, 0, 1, 2, 0, 0, 0),
(51, ' Scissors Of Fragility', 0, 0, 0, 0, 3, 8, 0, 0, 0),
(52, ' Scissors Of Chance', 0, 0, 0, 0, 7, 1, 0, 0, 0),
(53, 'Magic, Gold Scissors', 8, 100, 6, 48, 0, 0, 0, 0, 0),
(54, 'Gold Scissors', 6, 48, 0, 0, 0, 0, 0, 0, 0),
(55, 'Strong Scissors', 2, 8, 0, 0, 0, 0, 0, 0, 0),
(56, 'Steel Scissors', 4, 26, 0, 0, 0, 0, 0, 0, 0),
(57, 'Magic Scissors Of Fragility', 8, 100, 0, 0, 3, 8, 0, 0, 0),
(58, 'Gold Scissors', 6, 49, 0, 0, 0, 0, 0, 0, 0),
(59, 'Strong, Steel Scissors', 2, 7, 4, 23, 0, 0, 0, 0, 0),
(60, 'Magic Scissors', 8, 100, 0, 0, 0, 0, 0, 0, 0),
(61, ' Scissors Of Fortune', 0, 0, 0, 0, 9, 5, 0, 0, 0),
(62, ' Scissors', 0, 0, 0, 0, 0, 0, 0, 0, 0),
(63, ' Scissors', 0, 0, 0, 0, 0, 0, 0, 0, 0),
(64, 'Strong Scissors Of Weakness', 2, 4, 0, 0, 1, 3, 0, 0, 0),
(65, 'Steel Scissors', 4, 12, 0, 0, 0, 0, 0, 0, 0),
(66, 'Steel Scissors', 4, 10, 0, 0, 0, 0, 0, 0, 0),
(67, ' Scissors Of Safety and Fragility', 0, 0, 0, 0, 5, 13, 3, 6, 0),
(68, ' Scissors Of Weakness', 0, 0, 0, 0, 1, 4, 0, 0, 0),
(69, 'Gold Scissors Of Fortune and Chance', 6, 23, 0, 0, 9, 5, 7, 1, 0),
(70, 'Gold Scissors Of Fragility', 6, 13, 0, 0, 3, 6, 0, 0, 0),
(71, 'Gold Scissors', 6, 17, 0, 0, 0, 0, 0, 0, 0),
(72, 'Strong, Gold Scissors', 2, 4, 6, 13, 0, 0, 0, 0, 0),
(73, 'Strong Scissors Of Safety and Weakness', 2, 3, 0, 0, 5, 17, 1, 4, 0),
(74, ' Scissors Of Weakness', 0, 0, 0, 0, 1, 4, 0, 0, 0),
(75, 'Strong Scissors Of Safety', 2, 4, 0, 0, 5, 15, 0, 0, 0),
(76, 'Gold Scissors', 6, 16, 0, 0, 0, 0, 0, 0, 0),
(77, 'Steel, Magic Scissors Of Safety', 4, 10, 8, 27, 5, 15, 0, 0, 0),
(78, ' Scissors Of Weakness', 0, 0, 0, 0, 1, 1, 0, 0, 0),
(79, ' Scissors', 0, 0, 0, 0, 0, 0, 0, 0, 0),
(80, 'Gold Scissors Of Weakness', 6, 22, 0, 0, 1, 3, 0, 0, 0),
(81, ' Scissors', 0, 0, 0, 0, 0, 0, 0, 0, 0),
(82, ' Scissors', 0, 0, 0, 0, 0, 0, 0, 0, 0),
(83, ' Scissors Of Fortune', 0, 0, 0, 0, 9, 5, 0, 0, 0),
(84, 'Magic, Strong Scissors Of Weakness', 8, 44, 2, 3, 1, 2, 0, 0, 0),
(85, ' Scissors Of Weakness', 0, 0, 0, 0, 1, 3, 0, 0, 0),
(86, ' Scissors', 0, 0, 0, 0, 0, 0, 0, 0, 0),
(87, ' Scissors Of Chance', 0, 0, 0, 0, 7, 1, 0, 0, 0),
(88, ' Scissors Of Safety', 0, 0, 0, 0, 5, 18, 0, 0, 0),
(89, 'Strong, Gold Scissors', 2, 4, 6, 13, 0, 0, 0, 0, 0),
(90, 'Strong Scissors', 2, 4, 0, 0, 0, 0, 0, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `specialty`
--

CREATE TABLE `specialty` (
  `id` int(11) NOT NULL,
  `name` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `specialty`
--

INSERT INTO `specialty` (`id`, `name`) VALUES
(1, 'Drink Rum');

-- --------------------------------------------------------

--
-- Table structure for table `stylist`
--

CREATE TABLE `stylist` (
  `id` int(11) NOT NULL,
  `name` text,
  `description` text,
  `level` int(11) NOT NULL,
  `hair` int(11) NOT NULL,
  `scissors` int(11) NOT NULL,
  `drop` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `stylist`
--

INSERT INTO `stylist` (`id`, `name`, `description`, `level`, `hair`, `scissors`, `drop`) VALUES
(1, 'Flashbeard', 'Beard changes colors', 9, 383, 89, 0),
(2, 'YARHAR', 'Wants a Bottle of Rum', 1, 5, 24, 0);

-- --------------------------------------------------------

--
-- Table structure for table `suffix`
--

CREATE TABLE `suffix` (
  `id` int(11) NOT NULL,
  `name` text,
  `max_value` int(11) NOT NULL,
  `min_value` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `suffix`
--

INSERT INTO `suffix` (`id`, `name`, `max_value`, `min_value`) VALUES
(1, 'Weakness', 5, 1),
(2, 'Strength', 5, 1),
(3, 'Fragility', 10, 6),
(4, 'Cutting', 10, 6),
(5, 'Safety', 20, 11),
(6, 'Shaving', 20, 11),
(7, 'Chance', 2, 1),
(8, 'Luck', 4, 3),
(9, 'Fortune', 6, 5),
(10, 'Riches', 10, 10);

-- --------------------------------------------------------

--
-- Table structure for table `__EFMigrationsHistory`
--

CREATE TABLE `__EFMigrationsHistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `__EFMigrationsHistory`
--

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`) VALUES
('20190517182221_initialcreate', '2.2.4-servicing-10062');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `client`
--
ALTER TABLE `client`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `join`
--
ALTER TABLE `join`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `prefix`
--
ALTER TABLE `prefix`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `scissors`
--
ALTER TABLE `scissors`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `specialty`
--
ALTER TABLE `specialty`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `stylist`
--
ALTER TABLE `stylist`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `suffix`
--
ALTER TABLE `suffix`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `__EFMigrationsHistory`
--
ALTER TABLE `__EFMigrationsHistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `client`
--
ALTER TABLE `client`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=101;

--
-- AUTO_INCREMENT for table `join`
--
ALTER TABLE `join`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `prefix`
--
ALTER TABLE `prefix`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `scissors`
--
ALTER TABLE `scissors`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=91;

--
-- AUTO_INCREMENT for table `specialty`
--
ALTER TABLE `specialty`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `stylist`
--
ALTER TABLE `stylist`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `suffix`
--
ALTER TABLE `suffix`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
