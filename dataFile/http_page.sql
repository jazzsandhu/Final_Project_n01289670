-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Dec 04, 2019 at 01:45 AM
-- Server version: 5.7.24
-- PHP Version: 7.3.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `cms`
--

-- --------------------------------------------------------

--
-- Table structure for table `http_page`
--

CREATE TABLE `http_page` (
  `PAGE_ID` int(11) NOT NULL,
  `TITLE` varchar(255) DEFAULT NULL,
  `BODY` varchar(255) DEFAULT NULL,
  `AUTHOR_ID` int(11) DEFAULT NULL,
  `CREATED_DATE` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `http_page`
--

INSERT INTO `http_page` (`PAGE_ID`, `TITLE`, `BODY`, `AUTHOR_ID`, `CREATED_DATE`) VALUES
(1, 'MATH', 'ITS ABOUT MATHEMATICAL EXPRESSIONS ', 2, '2015-10-12'),
(2, 'SCIENCE', 'ITS ABOUT SCIENCE PAGE', 3, '2002-10-12'),
(3, 'CSS', 'ITS ABOUT CSS TRICKS ', 1, '2001-08-21'),
(4, 'HTML', 'ITS ABOUT HTML CODING', 2, '2001-04-25'),
(11, 'N', 'N', 2, '2019-08-28');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `http_page`
--
ALTER TABLE `http_page`
  ADD PRIMARY KEY (`PAGE_ID`),
  ADD KEY `AUTHOR_ID` (`AUTHOR_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `http_page`
--
ALTER TABLE `http_page`
  MODIFY `PAGE_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `http_page`
--
ALTER TABLE `http_page`
  ADD CONSTRAINT `http_page_ibfk_1` FOREIGN KEY (`AUTHOR_ID`) REFERENCES `author` (`AUTHOR_ID`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
