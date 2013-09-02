-- phpMyAdmin SQL Dump
-- version 3.5.2.2
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Aug 29, 2013 at 04:47 AM
-- Server version: 5.5.27
-- PHP Version: 5.4.7

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `music_video_store_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `album_music_table`
--

CREATE TABLE IF NOT EXISTS `album_music_table` (
  `albumID` int(5) NOT NULL AUTO_INCREMENT,
  `productCode` varchar(8) NOT NULL,
  `albumName` varchar(200) NOT NULL,
  `contribArtist` varchar(200) DEFAULT NULL,
  `musicGenre` varchar(100) DEFAULT NULL,
  `numTracks` int(4) DEFAULT NULL,
  `price` float NOT NULL,
  PRIMARY KEY (`productCode`),
  UNIQUE KEY `albumID` (`albumID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Dumping data for table `album_music_table`
--

INSERT INTO `album_music_table` (`albumID`, `productCode`, `albumName`, `contribArtist`, `musicGenre`, `numTracks`, `price`) VALUES
(1, 'AM-00001', 'Love&Girls', 'Girls Generation', '', 0, 499),
(2, 'AM-00002', 'I Got A Boy', 'Girls Generation', 'KPop', 9, 399.99),
(3, 'AM-00003', 'RED', 'Taylor Swift', 'Country', 0, 350);

-- --------------------------------------------------------

--
-- Table structure for table `movie_video_table`
--

CREATE TABLE IF NOT EXISTS `movie_video_table` (
  `movieID` int(5) NOT NULL AUTO_INCREMENT,
  `productCode` varchar(8) NOT NULL,
  `movieName` varchar(400) NOT NULL,
  `starringArtist` varchar(400) DEFAULT NULL,
  `movieGenre` varchar(100) DEFAULT NULL,
  `movieDescription` varchar(4000) DEFAULT NULL,
  `price` float NOT NULL,
  PRIMARY KEY (`productCode`),
  UNIQUE KEY `movieID` (`movieID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `movie_video_table`
--

INSERT INTO `movie_video_table` (`movieID`, `productCode`, `movieName`, `starringArtist`, `movieGenre`, `movieDescription`, `price`) VALUES
(1, 'MV-00001', 'Despicable Me', 'Steve Carell', 'Animated', '', 300),
(2, 'MV-00002', 'Harry Potter and the Order of the Phoenix', 'Daniel Radcliffe', 'Wizardry', '', 449.99);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
