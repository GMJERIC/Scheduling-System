-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 15, 2023 at 01:19 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `scheduling`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `admin_id` int(255) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`admin_id`, `username`, `password`) VALUES
(2, 'admin', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918');

-- --------------------------------------------------------

--
-- Table structure for table `course`
--

CREATE TABLE `course` (
  `course_id` int(255) NOT NULL,
  `course` varchar(255) NOT NULL,
  `course_description` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `course`
--

INSERT INTO `course` (`course_id`, `course`, `course_description`) VALUES
(2, 'BSCS', 'Bachelor of Science in Computer Science'),
(4, 'BSHM', 'Bachelor of Science in Human Resources'),
(6, 'BEED', 'Bachelor of Elementary Education '),
(11, 'BSA', 'Bachelor of Science in Accountancy'),
(12, 'BSBA', 'Bachelor of Science in Business Administration'),
(13, 'BSTM', 'Bachelor of Science in Tourism Management');

-- --------------------------------------------------------

--
-- Table structure for table `instructor`
--

CREATE TABLE `instructor` (
  `instructor_id` int(255) NOT NULL,
  `last_name` varchar(50) NOT NULL,
  `first_name` varchar(50) NOT NULL,
  `middle_name` varchar(50) NOT NULL,
  `gender` varchar(50) NOT NULL,
  `department` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `instructor`
--

INSERT INTO `instructor` (`instructor_id`, `last_name`, `first_name`, `middle_name`, `gender`, `department`) VALUES
(1, 'Reyes', 'Jober', 'Bernardo', 'Male', 'Computer Science'),
(2, 'Tolentino', 'Susana', 'Dela Cruz', 'Female', 'Computer Science'),
(3, 'Eugenio', 'Maricris', 'Ventosa', 'Female', 'Computer Science'),
(4, 'Bernardo', 'John', 'Aldrich', 'Male', 'Computer Science');

-- --------------------------------------------------------

--
-- Table structure for table `room`
--

CREATE TABLE `room` (
  `room_id` int(255) NOT NULL,
  `room` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `room`
--

INSERT INTO `room` (`room_id`, `room`) VALUES
(2, 'CB 205'),
(3, 'CB 206'),
(4, 'CB 207'),
(5, 'CB 208'),
(6, 'CB 201'),
(7, 'CB 209'),
(8, 'CB 202'),
(9, 'CB 101'),
(10, 'CB 102'),
(11, 'CB 103'),
(12, 'CB 104'),
(13, 'CB 105'),
(14, 'CB 106'),
(15, 'CB 107'),
(16, 'CB 108'),
(17, 'CB 203'),
(18, 'CB 204'),
(19, 'SHS 101');

-- --------------------------------------------------------

--
-- Table structure for table `schedule`
--

CREATE TABLE `schedule` (
  `id` int(255) NOT NULL,
  `full_Name` varchar(255) NOT NULL,
  `semester` varchar(255) NOT NULL,
  `school_year` varchar(255) NOT NULL,
  `subject_code` varchar(50) NOT NULL,
  `units` varchar(255) NOT NULL,
  `course` varchar(255) NOT NULL,
  `year_section` varchar(255) NOT NULL,
  `day` varchar(255) NOT NULL,
  `time` varchar(255) NOT NULL,
  `room` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `schedule`
--

INSERT INTO `schedule` (`id`, `full_Name`, `semester`, `school_year`, `subject_code`, `units`, `course`, `year_section`, `day`, `time`, `room`) VALUES
(1, 'Castillo Jeric', '1st Semester', '2023-2024', 'MMW - Mathematics in the Modern World', '3', 'BSCS', '1 - A', 'Friday', '8:00 - 11:00', 'CB 105'),
(2, 'Castillo Jeric', '1st Semester', '2023-2024', 'NSTP 1 - Civic Welfare Training Service', '3', 'BSCS', '1 - A', 'Thursday', '2:30 - 5:30', 'SHS 106'),
(3, 'Castillo Jeric', '1st Semester', '2023-2024', 'AccigFund - Fundamentals of Accounting', '3', 'BSCS', '2 - A', 'Wednesday', '8:00 - 11:00', 'SHS 104'),
(4, 'Castillo Jeric', '1st Semester', '2023-2024', 'DISCRETE 2 - Discrete Structures 2', '3', 'BSCS', '2 - A', 'Saturday	', '11:30 - 2:30', 'CB 205');

-- --------------------------------------------------------

--
-- Table structure for table `school_year`
--

CREATE TABLE `school_year` (
  `school_year_id` int(255) NOT NULL,
  `school_year` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `school_year`
--

INSERT INTO `school_year` (`school_year_id`, `school_year`) VALUES
(1, '2023-2024');

-- --------------------------------------------------------

--
-- Table structure for table `semester`
--

CREATE TABLE `semester` (
  `semester_id` int(255) NOT NULL,
  `semester` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `subject`
--

CREATE TABLE `subject` (
  `course` varchar(100) NOT NULL,
  `subject_id` int(255) NOT NULL,
  `subject_code` varchar(255) NOT NULL,
  `subject_description` varchar(255) NOT NULL,
  `units` varchar(255) NOT NULL,
  `academicYr` varchar(100) NOT NULL,
  `yrLvl` varchar(100) NOT NULL,
  `semester` varchar(100) NOT NULL,
  `section` varchar(100) NOT NULL,
  `day` varchar(100) NOT NULL,
  `time` varchar(100) NOT NULL,
  `room` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `subject`
--

INSERT INTO `subject` (`course`, `subject_id`, `subject_code`, `subject_description`, `units`, `academicYr`, `yrLvl`, `semester`, `section`, `day`, `time`, `room`) VALUES
('BSA', 1, 'UTS', 'Understanding the Self', '3', '2023-2024', '1', '1st Semester', 'A', 'Monday', '8:00 - 11:00', 'CB 205'),
('BSA', 2, 'PCO', 'Purposive Communication', '3', '2023-2024', '1', '1st Semester', 'A', 'Tuesday', '11:30 - 2:30', 'CB 206'),
('BSA', 3, 'MMW', 'Mathematics in the Modern World', '3', '2023-2024', '1', '1st Semester', 'A', 'Wednesday', '2:30 - 5:30', 'CB 207'),
('BSA', 4, 'BSCATG', 'Fundamentals of Accounting', '3', '2023-2024', '1', '1st Semester', 'A', 'Thurdays', '8:00 - 11:00', 'CB 208'),
('BSA', 5, 'FAR 1', 'Financial Accounting and Reporting', '3', '2023-2024', '1', '1st Semester', 'A', 'Friday', '11:30 - 2:30', 'CB 201'),
('BSA', 6, 'ECO 2', 'Economic Development', '3', '2023-2024', '1', '2nd Semester', 'A', 'Friday', '11:30 - 2:30', 'CB 101'),
('BSA', 7, ' RFBT 1', 'Law on Obligations and Contracts', '3', '2023-2024', '1', '2nd Semester', 'A', 'Saturday', '2:30 - 5:30', 'CB 107'),
('BSA', 8, 'MGTSCI ', 'Management Science', '3', '2023-2024', '1', '2nd Semester', 'A', 'Thurdays', '8:00 - 11:00', 'CB 203'),
('BSA', 9, 'FAR 2', 'Conceptual Framework', '3', '2023-2024', '1', '2nd Semester', 'A', 'Tuesday', '2:30 - 5:30', 'CB 204'),
('BSA', 10, 'FAR 3', 'Intermediate Accounting 1', '3', '2023-2024', '1', '2nd Semester', 'A', 'Monday', '11:30 - 2:30', 'CB 101'),
('BSHM', 11, 'UTS', 'Understanding the Self', '3', '2023-2024', '1', '1st Semester', 'A', 'Monday', '8:00 - 11:00', 'CB 105'),
('BSA', 12, 'RPH', 'Readings in Philippine History', '3', '2023-2024', '2', '1st Semester', 'A', 'Tuesday', '11:30 - 2:30', 'CB 104'),
('BSA', 13, 'TCW', 'The Contemporary World', '3', '2023-2024', '2', '1st Semester', 'A', 'Thurdays', '8:00 - 11:00', 'CB 202'),
('BSA', 14, 'FAR 4', 'Income Taxation', '3', '2023-2024', '2', '1st Semester', 'A', 'Friday', '2:30 - 5:30', 'CB 208'),
('BSA', 15, 'SCM ', 'Stategic Cost Management ', '3', '2023-2024', '2', '1st Semester', 'A', 'Saturday', '11:30 - 2:30', 'CB 207'),
('BSA', 16, 'RFBT 2', 'Business Laws and Regulation', '3', '2023-2024', '2', '1st Semester', 'A', 'Sunday', '2:30 - 5:30', 'CB 203'),
('BSA', 18, 'TAX 2', 'Business Taxation', '3', '2023-2024', '2', '2nd Semester', 'A', 'Wednesday', '8:00 - 11:00', 'CB 208'),
('BSA', 19, 'RFBT 3 ', 'Regulatory Framework and Lega issues in business', '3', '2023-2024', '2', '2nd Semester', 'A', 'Thurdays', '2:30 - 5:30', 'CB 201'),
('BSA', 20, 'FAR 5', 'Intermediate Accounting 3', '3', '2023-2024', '2', '2nd Semester', 'A', 'Friday', '8:00 - 11:00', 'CB 103'),
('BSA', 21, 'FMKT ', 'Financial Markets', '3', '2023-2024', '2', '2nd Semester', 'A', 'Saturday', '11:30 - 2:30', 'CB 107'),
('BSA', 22, 'AAP', 'Art Appreciation', '3', '2023-2024', '3', '1st Semester', 'A', 'Monday', '11:30 - 2:30', 'CB 201'),
('BSA', 23, 'STS', 'Science, Technology, and Society', '3', '2023-2024', '3', '1st Semester', 'A', 'Tuesday', '2:30 - 5:30', 'CB 104'),
('BSA', 24, 'SASA', 'Statistical Analysis with Software', '3', '2023-2024', '3', '1st Semester', 'A', 'Thurdays', '8:00 - 11:00', 'CB 106'),
('BSA', 25, 'Audit 1', 'Auditing and Assurance Principles', '3', '2023-2024', '3', '1st Semester', 'A', 'Tuesday', '11:30 - 2:30', 'CB 108'),
('BSA', 26, 'Audit 2', 'Auditing and Assurance Concepts and Applications 1', '3', '2023-2024', '3', '1st Semester', 'A', 'Saturday', '2:30 - 5:30', 'CB 204'),
('BSA', 27, 'ARM', 'Accounting Research Methods', '3', '2023-2024', '3', '2nd Semester', 'A', 'Tuesday', '8:00 - 11:00', 'CB 108'),
('BSA', 28, 'IBT', 'International Business and Trade', '3', '2023-2024', '3', '2nd Semester', 'A', 'Thurdays', '11:30 - 2:30', 'CB 103'),
('BSA', 29, 'AFAR 3', 'Accounting for Government ', '3', '2023-2024', '3', '2nd Semester', 'A', 'Tuesday', '2:30 - 5:30', 'CB 106'),
('BSA', 30, 'AUDIT 3', 'Auditing and Assurance ', '3', '2023-2024', '3', '2nd Semester', 'A', 'Friday', '8:00 - 11:00', 'CB 108'),
('BSA', 32, 'PRACTICUM', 'Accounting Internship', '3', '2023-2024', '4', '1st Semester', 'A', 'Wednesday', '8:00 - 11:00', 'CB 206'),
('BSA', 33, 'ACTRSH', 'Accounting Research', '3', '2023-2024', '4', '1st Semester', 'A', 'Saturday', '11:30 - 2:30', 'CB 101'),
('BSA', 34, 'MASREV', 'MAS Review', '3', '2023-2024', '4', '2nd Semester', 'A', 'Monday', '8:00 - 11:00', 'CB 209'),
('BSA', 35, 'ELEC 4 ', 'Updates in Financial Reporting Standards', '3', '2023-2024', '4', '2nd Semester', 'A', 'Tuesday', '11:30 - 2:30', 'CB 207'),
('BSA', 36, 'FARREV', 'Financial Accounting and Reporting Review', '3', '2023-2024', '4', '2nd Semester', 'A', 'Wednesday', '2:30 - 5:30', 'CB 203'),
('BSA', 37, 'AUDITREV', '', '3', '2023-2024', '4', '2nd Semester', 'A', 'Thurdays', '11:30 - 2:30', 'CB 102'),
('BSHM', 38, 'RPH', 'Reading in Philippine History with Peace Studies and Indigenous People\'s Studies', '3', '2023-2024', '1', '1st Semester', 'A', 'Tuesday', '11:30 - 2:30', 'CB 201'),
('BSHM', 39, 'FIL 1', 'Ugnayan ng Wika Kultuta at Lipunan', '3', '2023-2024', '1', '1st Semester', 'A', 'Wednesday', '2:30 - 5:30', 'CB 107'),
('BSHM', 40, 'THC 1', '', '3', '2023-2024', '1', '1st Semester', 'A', 'Thurdays', '11:30 - 2:30', 'CB 203'),
('BSHM', 41, 'FIL 2', 'Panitikan ng Pilipinas', '3', '2023-2024', '1', '2nd Semester', 'A', 'Monday', '8:00 - 11:00', 'CB 206'),
('BSHM', 42, 'STS', 'Science, Technology and Society', '3', '2023-2024', '1', '2nd Semester', 'A', 'Tuesday', '11:30 - 2:30', 'CB 102'),
('BSHM', 43, 'THC 3', 'Micro Perspective of Tourism and Hospitality', '3', '2023-2024', '1', '2nd Semester', 'A', 'Wednesday', '2:30 - 5:30', 'CB 105'),
('BSHM', 45, 'APP', 'Art Appreciation', '3', '2023-2024', '2', '1st Semester', 'A', 'Tuesday', '8:00 - 11:00', 'CB 102'),
('BSHM', 46, 'MMW', 'Mathematics in the Modern World', '3', '2023-2024', '2', '1st Semester', 'A', 'Wednesday', '2:30 - 5:30', 'CB 104'),
('BSHM', 47, 'PCO', 'Purposive Communication', '3', '2023-2024', '2', '1st Semester', 'A', 'Saturday', '11:30 - 2:30', 'CB 209'),
('BSHM', 48, 'THC 4', 'Philippine Tourism', '3', '2023-2024', '2', '1st Semester', 'A', 'Monday', '2:30 - 5:30', 'CB 206'),
('BSHM', 49, 'THC 5', 'Professional Development', '3', '2023-2024', '2', '1st Semester', 'A', 'Friday', '11:30 - 2:30', 'CB 209'),
('BSHM', 50, 'FIL 3 ', 'Malikhaing Pagsulat', '3', '2023-2024', '2', '2nd Semester', 'A', 'Tuesday', '11:30 - 2:30', 'CB 107'),
('BSHM', 51, 'RVA ', 'Reading Visual Arts', '3', '2023-2024', '2', '2nd Semester', 'A', 'Thurdays', '8:00 - 11:00', 'CB 102'),
('BSHM', 52, 'LIE', 'Living in the IT Era', '3', '2023-2024', '2', '2nd Semester', 'A', 'Friday', '11:30 - 2:30', 'CB 108'),
('BSHM', 53, 'HME 1', 'Bread and Pastry', '3', '2023-2024', '2', '2nd Semester', 'A', 'Tuesday', '2:30 - 5:30', 'CB 203'),
('BSHM', 54, 'TCW ', 'The Contemporary World', '3', '2023-2024', '3', '1st Semester', 'B', 'Tuesday', '8:00 - 11:00', 'CB 205'),
('BSHM', 55, 'BME 1', 'Operations Management ', '3', '2023-2024', '3', '1st Semester', 'B', 'Wednesday', '11:30 - 2:30', 'CB 201'),
('BSHM', 56, 'THC 6', 'Tourism and Hospitality Marketing', '3', '2023-2024', '3', '1st Semester', 'B', 'Thurdays', '2:30 - 5:30', 'CB 106'),
('BSHM', 57, 'ETH', 'Ethics ', '3', '2023-2024', '3', '2nd Semester', 'B', 'Monday', '8:00 - 11:00', 'CB 207'),
('BSHM', 58, 'RIZAL', 'Rizal\'s Life, Works and Writings', '3', '2023-2024', '3', '2nd Semester', 'B', 'Tuesday', '11:30 - 2:30', 'CB 106'),
('BSHM', 59, 'HMC 5', 'Supply Chain Management in Hospitality Industry', '3', '2023-2024', '3', '2nd Semester', 'B', 'Wednesday', '2:30 - 5:30', 'CB 103'),
('BSHM', 61, 'THC 9', 'Legal Aspects in Tourism and Hospitality', '3', '2023-2024', '4', '1st Semester', 'C', 'Saturday', '11:30 - 2:30', 'CB 201'),
('BSHM', 62, 'THC 10', 'Entrepreneurship in Tourism and Hospitality', '3', '2023-2024', '4', '1st Semester', 'C', 'Wednesday', '8:00 - 11:00', 'CB 107'),
('BSHM', 63, 'OJT 2', 'Hotel Practicum', '3', '2023-2024', '4', '2nd Semester', 'C', 'Wednesday', '8:00 - 11:00', 'CB 108'),
('BSTM', 68, 'MMW', 'Mathematics in the Modern World', '3', '2023-2024', '1', '2nd Semester', 'B', 'Wednesday', '8:00 - 11:00', 'CB 202'),
('BSTM', 69, 'PCO', 'Purposive ommunication', '3', '2023-2024', '1', '2nd Semester', 'B', 'Saturday', '2:30 - 5:30', 'CB 105'),
('BSTM', 70, 'APP', '', '3', '2023-2024', '2', '1st Semester', 'B', 'Thurdays', '8:00 - 11:00', 'CB 107'),
('BSTM', 71, 'MMW', 'Mathematics in the Modern World', '3', '2023-2024', '2', '1st Semester', 'B', 'Tuesday', '11:30 - 2:30', 'CB 204'),
('BSTM', 72, 'PCO', 'Purposive Communication', '3', '2023-2024', '2', '1st Semester', 'B', 'Friday', '2:30 - 5:30', 'CB 107'),
('BSTM', 73, 'THC 4', 'Philippine Tourism', '3', '2023-2024', '2', '1st Semester', 'B', 'Tuesday', '11:30 - 2:30', 'CB 103'),
('BSTM', 74, 'FIL 3', 'Malikhaing Pagsulat', '3', '2023-2024', '2', '2nd Semester', 'B', 'Tuesday', '8:00 - 11:00', 'CB 203'),
('BSTM', 75, 'RVA', 'Reading Visual Arts', '3', '2023-2024', '2', '2nd Semester', 'B', 'Friday', '2:30 - 5:30', 'CB 108'),
('BSTM', 76, 'LIE', 'Living in the IT Era', '3', '2023-2024', '2', '2nd Semester', 'B', 'Saturday', '11:30 - 2:30', 'CB 103'),
('BSTM', 77, 'HME 1', 'Bread and Pastry', '3', '2023-2024', '2', '2nd Semester', 'B', 'Monday', '2:30 - 5:30', 'CB 107'),
('BSTM', 79, 'BME 1', 'Operations Management', '3', '2023-2024', '3', '1st Semester', 'A', 'Tuesday', '2:30 - 5:30', 'CB 208'),
('BSTM', 81, 'ETH', 'Ethics', '3', '2023-2024', '3', '2nd Semester', 'A', 'Monday', '2:30 - 5:30', 'CB 203'),
('BSTM', 82, 'RIZAL', 'Rizal\'s Life, Works and writings', '3', '2023-2024', '3', '2nd Semester', 'A', 'Wednesday', '8:00 - 11:00', 'CB 203'),
('BSTM', 83, 'HMC 5', 'Supply Chain Management in Hospitality Industry', '3', '2023-2024', '3', '2nd Semester', 'A', 'Sunday', '11:30 - 2:30', 'CB 106'),
('BSTM', 84, 'BME 2', 'Strategic Management', '3', '2023-2024', '4', '1st Semester', 'A', 'Thurdays', '11:30 - 2:30', 'CB 107'),
('BSTM', 85, 'THC 9', 'Legal Aspects', '3', '2023-2024', '4', '1st Semester', 'A', 'Sunday', '2:30 - 5:30', 'CB 202'),
('BSTM', 86, 'THC 10', 'Entrepreneurship', '3', '2023-2024', '4', '1st Semester', 'A', 'Friday', '8:00 - 11:00', 'CB 203'),
('BSTM', 87, 'OJT 2', 'Hotel Practicum', '3', '2023-2024', '4', '2nd Semester', 'A', 'Thurdays', '2:30 - 5:30', 'CB 208'),
('BSCS', 88, 'COMP 1', 'Introduction to Computing', '3', '2023-2024', '1', '1st Semester', 'A', 'Friday', '2:30 - 5:30', 'CB 104'),
('BSCS', 89, 'PROG 1', 'Computer Programming 1', '3', '2023-2024', '1', '1st Semester', 'A', 'Wednesday', '11:30 - 2:30', 'CB 107'),
('BSCS', 90, 'UTS', 'Understanding the Self', '3', '2023-2024', '1', '1st Semester', 'A', 'Friday', '8:00 - 11:00', 'CB 204'),
('BSCS', 91, 'RPH', 'Reading in Philippine History', '3', '2023-2024', '1', '1st Semester', 'A', 'Wednesday', '11:30 - 2:30', 'CB 108'),
('BSCS', 92, 'DISCRETE 1', 'Discrete Structures 1', '3', '2023-2024', '1', '2nd Semester', 'A', 'Wednesday', '11:30 - 2:30', 'CB 101'),
('BSCS', 93, 'PROG 2', 'Computer Programming 2', '3', '2023-2024', '1', '2nd Semester', 'A', 'Thurdays', '2:30 - 5:30', 'CB 105'),
('BSCS', 94, 'DASTRUC 1', 'Data Structures and Algorithms', '3', '2023-2024', '1', '2nd Semester', 'A', 'Saturday', '11:30 - 2:30', 'CB 108'),
('BSCS', 95, 'STS', 'Science and Technology', '3', '2023-2024', '1', '2nd Semester', 'A', 'Monday', '2:30 - 5:30', 'CB 103'),
('BSCS', 97, 'DISCRETE 2', 'Discrete Structures 2', '3', '2023-2024', '2', '1st Semester', 'B', 'Wednesday', '11:30 - 2:30', 'CB 106'),
('BSCS', 98, 'HUMCOIN', 'Human Computer Interaction', '3', '2023-2024', '2', '1st Semester', 'B', 'Friday', '8:00 - 11:00', 'CB 209'),
('BSCS', 99, 'TCW', 'The Contemporary World', '3', '2023-2024', '2', '1st Semester', 'B', 'Tuesday', '2:30 - 5:30', 'CB 103'),
('BSCS', 100, 'INFOMGT', 'Information Management', '3', '2023-2024', '2', '2nd Semester', 'B', 'Sunday', '11:30 - 2:30', 'CB 101'),
('BSCS', 101, 'CSO', 'Computer Architecture Organization', '3', '2023-2024', '2', '2nd Semester', 'B', 'Monday', '8:00 - 11:00', 'CB 202'),
('BSCS', 102, 'ETHICS', 'Ethics', '3', '2023-2024', '2', '2nd Semester', 'B', 'Friday', '11:30 - 2:30', 'CB 208'),
('BSCS', 104, 'DATACOM', 'Data Communication', '3', '2023-2024', '3', '1st Semester', 'C', 'Wednesday', '11:30 - 2:30', 'CB 209'),
('BSCS', 105, 'CS ELEC 1', 'Intelligent Systems', '3', '2023-2024', '3', '1st Semester', 'C', 'Thurdays', '8:00 - 11:00', 'CB 105'),
('BSCS', 106, 'SOFTENG 1', 'Software Engineering 1', '3', '2023-2024', '3', '1st Semester', 'C', 'Tuesday', '2:30 - 5:30', 'CB 102'),
('BSCS', 107, 'PL 1', 'Programming Languages', '3', '2023-2024', '3', '2nd Semester', 'C', 'Wednesday', '8:00 - 11:00', 'CB 103'),
('BSCS', 108, 'RESEARCH 1', 'Methods of Research in Computing', '3', '2023-2024', '3', '2nd Semester', 'C', 'Tuesday', '2:30 - 5:30', 'CB 108'),
('BSCS', 109, 'CS ELEC 2', 'Graphics and Visual Computing', '3', '2023-2024', '3', '2nd Semester', 'C', 'Saturday', '8:00 - 11:00', 'CB 103'),
('BSCS', 110, 'SOFTENG 2', 'Software Engineering 2', '3', '2023-2024', '3', '2nd Semester', 'C', 'Friday', '8:00 - 11:00', 'CB 107'),
('BSCS', 111, 'NLP', 'Natural Language Processing', '3', '2023-2024', '4', '1st Semester', 'A', 'Thurdays', '2:30 - 5:30', 'CB 205'),
('BSCS', 112, 'CS THESIS 1', 'Thesis Writing 1', '3', '2023-2024', '4', '1st Semester', 'A', 'Thurdays', '8:00 - 11:00', 'CB 206'),
('BSCS', 113, 'IT REVIEW', 'Certification Exam Review', '3', '2023-2024', '4', '1st Semester', 'A', 'Saturday', '2:30 - 5:30', 'CB 103'),
('BSCS', 114, 'IAS1', 'Information Assurance and Security', '3', '2023-2024', '4', '2nd Semester', 'A', 'Wednesday', '8:00 - 11:00', 'CB 201'),
('BSCS', 115, 'CS THESIS 2', 'Thesis Writing 2', '3', '2023-2024', '4', '2nd Semester', 'A', 'Sunday', '2:30 - 5:30', 'CB 209'),
('BSBA', 116, 'UTS', '', '3', '2023-2024', '1', '1st Semester', 'A', 'Tuesday', '11:30 - 2:30', 'CB 101'),
('BSBA', 117, 'PCO', 'Purposive Communication', '3', '2023-2024', '1', '1st Semester', 'A', 'Friday', '2:30 - 5:30', 'CB 209'),
('BSBA', 119, 'MMW', 'Mathematics in the Modern World', '3', '2023-2024', '1', '1st Semester', 'A', 'Wednesday', '2:30 - 5:30', 'CB 102'),
('BSBA', 121, 'LIE', 'Living in the IT Era', '3', '2023-2024', '1', '2nd Semester', 'B', 'Saturday', '11:30 - 2:30', 'CB 203'),
('BSBA', 122, 'RVA', 'Reading in Visual Arts', '3', '2023-2024', '1', '2nd Semester', 'B', 'Tuesday', '8:00 - 11:00', 'CB 105'),
('BSBA', 123, 'PE 2', 'Rythmic Activities', '3', '2023-2024', '1', '2nd Semester', 'B', 'Saturday', '11:30 - 2:30', 'CB 202'),
('BSBA', 125, 'AAP', 'Art Apprecation', '3', '2023-2024', '2', '1st Semester', 'A', 'Friday', '8:00 - 11:00', 'CB 205'),
('BSBA', 126, 'ECO 01 ', 'Basic Microeconomics', '3', '2023-2024', '2', '1st Semester', 'A', 'Sunday', '2:30 - 5:30', 'CB 104'),
('BSBA', 127, 'RIZAL', 'Rizal\'s Life, and Works', '3', '2023-2024', '2', '2nd Semester', 'A', 'Saturday', '2:30 - 5:30', 'CB 106'),
('BSBA', 128, 'STS', 'Science, Technology, and Society', '3', '2023-2024', '2', '2nd Semester', 'A', 'Tuesday', '11:30 - 2:30', 'CB 203'),
('BSBA', 129, 'BUSLAW 01', 'Law on Obligations and Contracts', '3', '2023-2024', '2', '2nd Semester', 'A', 'Sunday', '2:30 - 5:30', 'CB 105'),
('BSBA', 130, 'STRMGT', 'Strategic Management', '3', '2023-2024', '3', '1st Semester', 'A', 'Wednesday', '2:30 - 5:30', 'CB 201'),
('BSBA', 131, 'GSR', 'Good Governance', '3', '2023-2024', '3', '1st Semester', 'A', 'Monday', '8:00 - 11:00', 'CB 104'),
('BSBA', 132, 'BUSRSH', 'Business Research', '3', '2023-2024', '3', '2nd Semester', 'A', 'Thurdays', '11:30 - 2:30', 'CB 106'),
('BSBA', 133, 'OMTQM', 'Operations Management', '3', '2023-2024', '3', '2nd Semester', 'A', 'Saturday', '11:30 - 2:30', 'CB 104'),
('BSBA', 134, 'MGNT 8', 'Facilities Management', '3', '2023-2024', '4', '1st Semester', 'B', 'Wednesday', '8:00 - 11:00', 'CB 101'),
('BSBA', 135, 'ELEC 3', 'Managerial Accounting', '3', '2023-2024', '4', '1st Semester', 'B', 'Friday', '11:30 - 2:30', 'CB 104'),
('BSBA', 136, 'ELEC 4', 'Operations Research', '3', '2023-2024', '4', '2nd Semester', 'C', 'Wednesday', '11:30 - 2:30', 'CB 105'),
('BSBA', 137, 'PRACTICUM ', 'Practicum Integrated Learning', '3', '2023-2024', '4', '2nd Semester', 'C', 'Friday', '2:30 - 5:30', 'CB 101'),
('BEED', 138, 'UTS', 'Understanding the Self', '3', '2023-2024', '1', '1st Semester', 'A', 'Monday', '2:30 - 5:30', 'CB 101'),
('BEED', 139, 'NSTP 1', 'Civic Welfare Training Sercive (CWTS)', '3', '2023-2024', '1', '1st Semester', 'A', 'Sunday', '8:00 - 11:00', 'CB 209'),
('BEED', 140, 'STS', 'Science, Technology, and Society', '3', '2023-2024', '1', '2nd Semester', 'A', 'Wednesday', '11:30 - 2:30', 'CB 103'),
('BEED', 141, 'LIE', 'Living in the IT Era', '3', '2023-2024', '1', '2nd Semester', 'A', 'Thurdays', '2:30 - 5:30', 'CB 203'),
('BEED', 142, 'EED 101', 'Teaching Science in the Elementary Grade(Biology and Chemistry', '3', '2023-2024', '2', '2nd Semester', 'A', 'Monday', '11:30 - 2:30', 'CB 106'),
('BEED', 143, 'EED 101', 'Teaching Science in the Elementary Grades(Biology and Chemistry', '3', '2023-2024', '2', '1st Semester', 'A', 'Wednesday', '8:00 - 11:00', 'CB 106'),
('BEED', 144, 'EED', 'Teaching Math in the Primary Grades', '3', '2023-2024', '2', '1st Semester', 'A', 'Monday', '2:30 - 5:30', 'CB 202'),
('BEED', 145, 'PROFED 108', 'Assessment in Learing 2', '3', '2023-2024', '2', '2nd Semester', 'A', 'Saturday', '8:00 - 11:00', 'CB 201'),
('BEED', 146, 'EED 112', 'Good Manners and Right Conduct', '3', '2023-2024', '3', '1st Semester', 'C', 'Wednesday', '2:30 - 5:30', 'CB 108'),
('BEED', 147, 'EED 109', 'Teaching Social Studies', '3', '2023-2024', '3', '1st Semester', 'C', 'Saturday', '11:30 - 2:30', 'CB 208'),
('BEED', 148, 'EED 114', 'Edukasyong Pantahanan', '3', '2023-2024', '3', '2nd Semester', 'B', 'Thurdays', '11:30 - 2:30', 'CB 104'),
('BEED', 149, 'EED 116', 'Teaching Arts', '3', '2023-2024', '3', '2nd Semester', 'B', 'Saturday', '2:30 - 5:30', 'CB 202'),
('BEED', 150, 'PROFED 111', 'Field Study', '3', '2023-2024', '4', '1st Semester', 'C', 'Friday', '11:30 - 2:30', 'CB 103'),
('BEED', 151, 'PROFED 112', 'Field Study 2', '3', '2023-2024', '4', '1st Semester', 'C', 'Saturday', '8:00 - 11:00', 'CB 204'),
('BEED', 152, 'PROFED 113', 'Teaching Internship', '3', '2023-2024', '4', '2nd Semester', 'B', 'Friday', '11:30 - 2:30', 'CB 204');

-- --------------------------------------------------------

--
-- Table structure for table `subject2`
--

CREATE TABLE `subject2` (
  `subject_id` int(11) NOT NULL,
  `course` varchar(100) NOT NULL,
  `subject_code` varchar(100) NOT NULL,
  `subject_description` varchar(100) NOT NULL,
  `units` int(100) NOT NULL,
  `academicYr` varchar(100) NOT NULL,
  `yrLvl` varchar(100) NOT NULL,
  `semester` varchar(100) NOT NULL,
  `section` varchar(100) NOT NULL,
  `day` varchar(100) NOT NULL,
  `start_time` time NOT NULL,
  `end_time` time NOT NULL,
  `room` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `subject2`
--

INSERT INTO `subject2` (`subject_id`, `course`, `subject_code`, `subject_description`, `units`, `academicYr`, `yrLvl`, `semester`, `section`, `day`, `start_time`, `end_time`, `room`) VALUES
(1, 'BEED', 'q', 'q', 3, '2023-2024', '1', '1st Semester', 'A', 'Monday', '08:00:00', '10:00:00', 'CB 205'),
(2, 'BEED', 'w', 'w', 3, '2023-2024', '1', '1st Semester', 'A', 'Monday', '10:00:00', '11:00:00', 'CB 205'),
(3, 'BEED', 'e', 'e', 3, '2023-2024', '1', '1st Semester', 'A', 'Monday', '09:00:00', '12:00:00', 'CB 205');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`admin_id`);

--
-- Indexes for table `course`
--
ALTER TABLE `course`
  ADD PRIMARY KEY (`course_id`);

--
-- Indexes for table `instructor`
--
ALTER TABLE `instructor`
  ADD PRIMARY KEY (`instructor_id`);

--
-- Indexes for table `room`
--
ALTER TABLE `room`
  ADD PRIMARY KEY (`room_id`);

--
-- Indexes for table `schedule`
--
ALTER TABLE `schedule`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `school_year`
--
ALTER TABLE `school_year`
  ADD PRIMARY KEY (`school_year_id`);

--
-- Indexes for table `semester`
--
ALTER TABLE `semester`
  ADD PRIMARY KEY (`semester_id`);

--
-- Indexes for table `subject`
--
ALTER TABLE `subject`
  ADD PRIMARY KEY (`subject_id`);

--
-- Indexes for table `subject2`
--
ALTER TABLE `subject2`
  ADD PRIMARY KEY (`subject_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `admin_id` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `course`
--
ALTER TABLE `course`
  MODIFY `course_id` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `instructor`
--
ALTER TABLE `instructor`
  MODIFY `instructor_id` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `room`
--
ALTER TABLE `room`
  MODIFY `room_id` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `schedule`
--
ALTER TABLE `schedule`
  MODIFY `id` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `school_year`
--
ALTER TABLE `school_year`
  MODIFY `school_year_id` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `semester`
--
ALTER TABLE `semester`
  MODIFY `semester_id` int(255) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `subject`
--
ALTER TABLE `subject`
  MODIFY `subject_id` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=155;

--
-- AUTO_INCREMENT for table `subject2`
--
ALTER TABLE `subject2`
  MODIFY `subject_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
