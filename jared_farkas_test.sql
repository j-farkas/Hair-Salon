-- phpMyAdmin SQL Dump
-- version 4.7.7
-- https://www.phpmyadmin.net/
--
-- Host: localhost:8889
-- Generation Time: May 17, 2019 at 11:27 PM
-- Server version: 5.6.38
-- PHP Version: 7.2.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `jared_farkas_test`
--
CREATE DATABASE IF NOT EXISTS `jared_farkas_test` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `jared_farkas_test`;

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
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=100;

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
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=90;

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
