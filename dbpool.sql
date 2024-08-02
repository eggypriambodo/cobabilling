-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 02, 2024 at 08:58 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbpool`
--

-- --------------------------------------------------------

--
-- Table structure for table `tb_daftarpaket`
--

CREATE TABLE `tb_daftarpaket` (
  `id` int(11) NOT NULL,
  `nama_paket` varchar(255) NOT NULL,
  `jenis_paket` varchar(50) NOT NULL,
  `harga_paket` int(11) NOT NULL,
  `harga_siang` int(11) NOT NULL,
  `harga_malam` int(11) NOT NULL,
  `akhir_siang` time NOT NULL,
  `akhir_malam` time NOT NULL,
  `disc_table` float NOT NULL,
  `disc_fnb` float NOT NULL,
  `durasi` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tb_daftarpaket`
--

INSERT INTO `tb_daftarpaket` (`id`, `nama_paket`, `jenis_paket`, `harga_paket`, `harga_siang`, `harga_malam`, `akhir_siang`, `akhir_malam`, `disc_table`, `disc_fnb`, `durasi`) VALUES
(1, 'PAKET LOSTIME', 'LOSTIME', 0, 35000, 40000, '16:30:00', '00:00:00', 0, 0, 0),
(2, 'PAKET WEEKDAY 2 JAM', 'PAKET', 60000, 0, 0, '00:00:00', '00:00:00', 0, 0, 2),
(3, 'PAKET DURASI', 'DURASI', 0, 35000, 40000, '16:30:00', '00:00:00', 0, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `tb_detailbilling`
--

CREATE TABLE `tb_detailbilling` (
  `no_order` varchar(15) NOT NULL,
  `nama_tamu` varchar(50) NOT NULL,
  `paket` varchar(50) NOT NULL,
  `no_meja` int(11) NOT NULL,
  `mulai` varchar(50) NOT NULL,
  `selesai` varchar(50) NOT NULL,
  `durasi` int(11) NOT NULL,
  `harga` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tb_detailfnb`
--

CREATE TABLE `tb_detailfnb` (
  `no_order` varchar(15) NOT NULL,
  `nama_fnb` varchar(50) NOT NULL,
  `harga_fnb` int(11) NOT NULL,
  `qty_fnb` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tb_fnb`
--

CREATE TABLE `tb_fnb` (
  `id` int(11) NOT NULL,
  `nama_fnb` varchar(255) NOT NULL,
  `kategori_fnb` varchar(255) NOT NULL,
  `harga_fnb` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tb_fnb`
--

INSERT INTO `tb_fnb` (`id`, `nama_fnb`, `kategori_fnb`, `harga_fnb`) VALUES
(1, 'Es Jeruk', 'Minuman', 5000),
(2, 'Es Teh', 'Minuman', 4000),
(3, 'Teh Panas', 'Minuman', 4000),
(4, 'Jeruk Panas', 'Minuman', 5000),
(5, 'Nasi Telur', 'Makanan', 10000);

-- --------------------------------------------------------

--
-- Table structure for table `tb_meja`
--

CREATE TABLE `tb_meja` (
  `id` int(11) NOT NULL,
  `nama_meja` varchar(255) NOT NULL,
  `status` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tb_meja`
--

INSERT INTO `tb_meja` (`id`, `nama_meja`, `status`) VALUES
(1, 'Meja 1', 'kosong'),
(2, 'Meja 2', 'kosong'),
(3, 'Meja 3', 'kosong'),
(4, 'Meja 4', 'kosong'),
(5, 'Meja 5', 'kosong'),
(6, 'Meja 6', 'kosong'),
(7, 'Meja 7', 'kosong'),
(8, 'Meja 8', 'kosong');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_daftarpaket`
--
ALTER TABLE `tb_daftarpaket`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tb_detailbilling`
--
ALTER TABLE `tb_detailbilling`
  ADD PRIMARY KEY (`no_order`);

--
-- Indexes for table `tb_detailfnb`
--
ALTER TABLE `tb_detailfnb`
  ADD PRIMARY KEY (`no_order`);

--
-- Indexes for table `tb_fnb`
--
ALTER TABLE `tb_fnb`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tb_meja`
--
ALTER TABLE `tb_meja`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tb_daftarpaket`
--
ALTER TABLE `tb_daftarpaket`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `tb_fnb`
--
ALTER TABLE `tb_fnb`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tb_meja`
--
ALTER TABLE `tb_meja`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
