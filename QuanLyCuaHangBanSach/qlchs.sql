-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 22, 2023 at 11:23 AM
-- Server version: 8.0.31
-- PHP Version: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `qlchs`
--

-- --------------------------------------------------------

--
-- Table structure for table `chitietphieuban`
--

CREATE TABLE `chitietphieuban` (
  `maPhieuBan` int NOT NULL,
  `maSach` int NOT NULL,
  `soLuong` int NOT NULL,
  `donGia` bigint NOT NULL,
  `hienThi` tinyint DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `chitietphieuban`
--

INSERT INTO `chitietphieuban` (`maPhieuBan`, `maSach`, `soLuong`, `donGia`, `hienThi`) VALUES
(1, 1, 500, 20000, 1),
(2, 2, 1000, 45000, 1),
(3, 2, 5, 45000, 1),
(3, 3, 5, 19000, 1),
(4, 2, 12, 45000, 1),
(4, 3, 12, 19000, 1),
(4, 4, 12, 50000, 1),
(4, 5, 12, 60000, 1),
(4, 6, 12, 15000, 1),
(4, 7, 12, 100000, 1),
(5, 2, 12, 45000, 1),
(5, 3, 12, 19000, 1),
(5, 4, 12, 50000, 1),
(5, 5, 12, 60000, 1),
(5, 6, 12, 15000, 1),
(5, 7, 12, 100000, 1),
(6, 2, 1, 45000, 1),
(7, 2, 1, 45000, 1),
(7, 3, 1, 19000, 1),
(7, 4, 1, 50000, 1),
(7, 5, 2, 60000, 1),
(7, 6, 1, 15000, 1),
(7, 7, 2, 100000, 1),
(7, 8, 1, 300000, 1),
(7, 9, 2, 123, 1),
(8, 9, 1, 123, 1),
(9, 1, 12, 20000, 1),
(9, 2, 12, 45000, 1),
(9, 3, 12, 19000, 1),
(9, 4, 12, 50000, 1);

-- --------------------------------------------------------

--
-- Table structure for table `chitietphieunhap`
--

CREATE TABLE `chitietphieunhap` (
  `maPhieuNhap` int NOT NULL,
  `maSach` int NOT NULL,
  `soLuong` int NOT NULL,
  `donGia` bigint NOT NULL,
  `hienThi` tinyint DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `chitietphieunhap`
--

INSERT INTO `chitietphieunhap` (`maPhieuNhap`, `maSach`, `soLuong`, `donGia`, `hienThi`) VALUES
(1, 1, 500, 10000, 1),
(2, 1, 100, 10000, 1),
(3, 9, 100, 12, 1),
(4, 7, 213, 50000, 1),
(5, 1, 100, 10000, 1),
(6, 1, 12, 10000, 1),
(6, 2, 12, 42000, 1),
(6, 3, 12, 10000, 1);

-- --------------------------------------------------------

--
-- Table structure for table `khachhang`
--

CREATE TABLE `khachhang` (
  `maKhachHang` int NOT NULL,
  `tenKhachHang` varchar(512) COLLATE utf8mb4_general_ci NOT NULL,
  `soDienThoai` varchar(11) COLLATE utf8mb4_general_ci NOT NULL,
  `gioiTinh` varchar(10) COLLATE utf8mb4_general_ci NOT NULL,
  `namSinh` int NOT NULL,
  `hienThi` tinyint DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `khachhang`
--

INSERT INTO `khachhang` (`maKhachHang`, `tenKhachHang`, `soDienThoai`, `gioiTinh`, `namSinh`, `hienThi`) VALUES
(1, 'Tân', '0811111111', 'Nam', 2000, 1),
(2, 'Lan', '0822222222', 'Nữ', 2001, 1),
(3, 'Hiếu', '0706092403', 'Nam', 2003, 1),
(4, 'Vy', '0844444444', 'Nữ', 1999, 1),
(5, 'Trúc', '0855555555', 'Nam', 1998, 1),
(6, 'Phong', '0866666666', 'Nam', 2005, 1),
(7, 'giau', '0708090909', 'Nam', 2003, 1),
(8, 'ádasd', '0708090908', 'Nam', 1234, 1);

-- --------------------------------------------------------

--
-- Table structure for table `khuyenmai`
--

CREATE TABLE `khuyenmai` (
  `maKhuyenMai` int NOT NULL,
  `tenKhuyenMai` varchar(256) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `phanTram` int DEFAULT NULL,
  `ngayBatDau` date DEFAULT NULL,
  `ngayKetThuc` date DEFAULT NULL,
  `hienThi` tinyint DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `khuyenmai`
--

INSERT INTO `khuyenmai` (`maKhuyenMai`, `tenKhuyenMai`, `phanTram`, `ngayBatDau`, `ngayKetThuc`, `hienThi`) VALUES
(1, 'Ưu đãi 1', 10, '2023-01-01', '2023-03-31', 1),
(2, 'Ưu đãi 2', 20, '2023-04-01', '2023-05-05', 1),
(3, 'Ưu đãi 3', 30, '2023-04-04', '2023-04-14', 1),
(4, 'Ưu đãi 4', 10, '2023-04-25', '2023-04-30', 1),
(5, 'Ưu đãi 5', 1, '2023-04-26', '2023-05-31', 1),
(6, '123', 12, '2023-05-02', '2023-05-31', 1);

-- --------------------------------------------------------

--
-- Table structure for table `nhacungcap`
--

CREATE TABLE `nhacungcap` (
  `maNhaCungCap` int NOT NULL,
  `tenNhaCungCap` varchar(256) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `diaChi` varchar(256) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `soDienThoai` varchar(256) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `hienThi` tinyint DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `nhacungcap`
--

INSERT INTO `nhacungcap` (`maNhaCungCap`, `tenNhaCungCap`, `diaChi`, `soDienThoai`, `hienThi`) VALUES
(1, 'ACB', '25 An Dương Vương', '0900000000', 1),
(2, 'Ánh Kim', '12 Hoàng Sa', '0911111111', 1),
(3, 'Văn Lang', '31 Võ Thị Sáu', '0922222222', 1),
(4, 'Phú Mỹ', '21 Lê Thị Hà', '0933333333', 1),
(5, 'Nhật Hạ', '11 Điện Biên Phủ', '0944444444', 1);

-- --------------------------------------------------------

--
-- Table structure for table `nhanvien`
--

CREATE TABLE `nhanvien` (
  `maNhanVien` int NOT NULL,
  `tenNhanVien` varchar(512) COLLATE utf8mb4_general_ci NOT NULL,
  `namSinh` int NOT NULL,
  `gioiTinh` varchar(10) COLLATE utf8mb4_general_ci NOT NULL,
  `soDienThoai` varchar(11) COLLATE utf8mb4_general_ci NOT NULL,
  `luong` bigint NOT NULL,
  `soNgayNghi` int NOT NULL,
  `vaiTro` varchar(256) COLLATE utf8mb4_general_ci NOT NULL,
  `hienThi` tinyint DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `nhanvien`
--

INSERT INTO `nhanvien` (`maNhanVien`, `tenNhanVien`, `namSinh`, `gioiTinh`, `soDienThoai`, `luong`, `soNgayNghi`, `vaiTro`, `hienThi`) VALUES
(1, 'Hưng', 2003, 'Nam', '0911111111', 6000000, 3, 'Quản lý', 1),
(2, 'Nhân', 1999, 'Nam', '0922222222', 4000000, 1, 'Nhân viên bán hàng', 1),
(3, 'Đào', 2002, 'Nữ', '0933333333', 3500000, 0, 'Nhân viên nhập hàng', 1),
(4, 'Duy', 1999, 'Nam', '0944444444', 3700000, 2, 'Nhân viên bán hàng', 1),
(5, 'Vy', 2004, 'Nữ', '0955555555', 3500000, 1, 'Nhân viên nhập hàng', 1),
(6, '123', 1233, 'Nam', '0723123123', 123, 1232, 'Nhân viên bán hàng', 1);

-- --------------------------------------------------------

--
-- Table structure for table `nhaxuatban`
--

CREATE TABLE `nhaxuatban` (
  `maNhaXuatBan` int NOT NULL,
  `tenNhaXuatBan` varchar(512) COLLATE utf8mb4_general_ci NOT NULL,
  `diaChi` varchar(512) COLLATE utf8mb4_general_ci NOT NULL,
  `soDienThoai` varchar(11) COLLATE utf8mb4_general_ci NOT NULL,
  `hienThi` tinyint DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `nhaxuatban`
--

INSERT INTO `nhaxuatban` (`maNhaXuatBan`, `tenNhaXuatBan`, `diaChi`, `soDienThoai`, `hienThi`) VALUES
(1, 'Kim Đồng', '10 Hồng Bàng', '0800000000', 1),
(2, 'Ánh Sao', '11 Xuân Diệu', '0811111111', 1),
(3, 'Hoài Nam', '12 CMT8', '0822222222', 1),
(4, 'Quang Dương', '13 Trường Chinh', '0833333333', 1),
(5, 'Kim Thành', '14 Cộng Hòa', '0844444444', 1);

-- --------------------------------------------------------

--
-- Table structure for table `phieuban`
--

CREATE TABLE `phieuban` (
  `maPhieuBan` int NOT NULL,
  `maKhachHang` int DEFAULT NULL,
  `maNhanVien` int DEFAULT NULL,
  `ngayLap` date NOT NULL,
  `tongTien` double DEFAULT NULL,
  `maKhuyenMai` int DEFAULT NULL,
  `hienThi` tinyint DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `phieuban`
--

INSERT INTO `phieuban` (`maPhieuBan`, `maKhachHang`, `maNhanVien`, `ngayLap`, `tongTien`, `maKhuyenMai`, `hienThi`) VALUES
(1, 1, 3, '2023-04-27', 9800000, 2, 1),
(2, 1, 4, '2023-04-27', 36000000, 2, 1),
(3, 7, 4, '2023-04-27', 316800, 5, 1),
(4, 3, 4, '2023-05-14', 3468000, 0, 1),
(5, 3, 4, '2023-05-14', 3433320, 5, 1),
(6, 3, 4, '2023-05-14', 44550, 5, 1),
(7, 1, 4, '2023-05-14', 659336.48, 6, 1),
(8, 1, 4, '2023-05-14', 123, 0, 1),
(9, 3, 4, '2023-05-15', 1591920, 5, 1);

-- --------------------------------------------------------

--
-- Table structure for table `phieunhap`
--

CREATE TABLE `phieunhap` (
  `maPhieuNhap` int NOT NULL,
  `maNhanVien` int NOT NULL,
  `maNhaCungCap` int DEFAULT NULL,
  `ngayLap` datetime NOT NULL,
  `tongTien` double NOT NULL,
  `hienThi` tinyint DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `phieunhap`
--

INSERT INTO `phieunhap` (`maPhieuNhap`, `maNhanVien`, `maNhaCungCap`, `ngayLap`, `tongTien`, `hienThi`) VALUES
(1, 3, 1, '2023-04-27 00:00:00', 5000000, 1),
(2, 3, 1, '2023-05-14 00:00:00', 1000000, 1),
(3, 3, 4, '2023-05-14 00:00:00', 1200, 1),
(4, 3, 2, '2023-05-14 00:00:00', 10650000, 1),
(5, 3, 1, '2023-05-14 00:00:00', 1000000, 1),
(6, 3, 1, '2023-05-15 00:00:00', 744000, 1);

-- --------------------------------------------------------

--
-- Table structure for table `sach`
--

CREATE TABLE `sach` (
  `maSach` int NOT NULL,
  `tenSach` varchar(512) COLLATE utf8mb4_general_ci NOT NULL,
  `maTheLoai` int DEFAULT NULL,
  `maTacGia` int DEFAULT NULL,
  `maNhaXuatBan` int DEFAULT NULL,
  `soLuongConLai` int NOT NULL,
  `giaBan` bigint NOT NULL,
  `giaNhap` bigint NOT NULL,
  `namXuatBan` int NOT NULL,
  `hienThi` tinyint DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `sach`
--

INSERT INTO `sach` (`maSach`, `tenSach`, `maTheLoai`, `maTacGia`, `maNhaXuatBan`, `soLuongConLai`, `giaBan`, `giaNhap`, `namXuatBan`, `hienThi`) VALUES
(1, 'Conan', 4, 1, 1, 200, 20000, 10000, 2022, 1),
(2, 'Những giấc mơ', 6, 3, 3, 1969, 45000, 42000, 1996, 1),
(3, 'Gió thu', 8, 2, 4, 370, 19000, 10000, 1979, 1),
(4, 'Dậu', 7, 5, 3, 6963, 50000, 31000, 1989, 1),
(5, 'Sớm mai', 7, 4, 2, 2974, 60000, 36000, 1988, 1),
(6, 'Mẹ và bé', 8, 1, 4, 575, 15000, 8000, 2012, 1),
(7, 'Đắc Nhân Tâm', 4, 1, 1, 139, 100000, 50000, 1936, 1),
(8, 'qew', 4, 1, 1, 6, 300000, 10000, 1999, 1),
(9, '123', 4, 1, 1, 20, 123, 12, 1233, 1),
(10, 'abc', 4, 1, 1, 12, 200000, 10000, 1234, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tacgia`
--

CREATE TABLE `tacgia` (
  `maTacGia` int NOT NULL,
  `tenTacGia` varchar(512) COLLATE utf8mb4_general_ci NOT NULL,
  `gioiTinh` varchar(10) COLLATE utf8mb4_general_ci NOT NULL,
  `namSinh` int NOT NULL,
  `hienThi` tinyint DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tacgia`
--

INSERT INTO `tacgia` (`maTacGia`, `tenTacGia`, `gioiTinh`, `namSinh`, `hienThi`) VALUES
(1, 'Gosho Aoyama', 'Nam', 1963, 1),
(2, 'Nguyễn Nhật', 'Nam', 1965, 1),
(3, 'Xuân Anh', 'Nữ', 1986, 1),
(4, 'Phi Vũ', 'Nữ', 1977, 1),
(5, 'Đông Phương', 'Nữ', 1996, 1),
(6, 'Tony', 'Nam', 1990, 1),
(7, 'Dale Carnegie', 'Nam', 1888, 1),
(8, '12', 'Nam', 1234, 1),
(9, '123', 'Nam', 1223, 1),
(10, 'adb', 'Nam', 1234, 1);

-- --------------------------------------------------------

--
-- Table structure for table `taikhoan`
--

CREATE TABLE `taikhoan` (
  `maNhanVien` int NOT NULL,
  `email` varchar(45) COLLATE utf8mb4_general_ci NOT NULL,
  `matKhau` varchar(20) COLLATE utf8mb4_general_ci NOT NULL,
  `hienThi` tinyint DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `taikhoan`
--

INSERT INTO `taikhoan` (`maNhanVien`, `email`, `matKhau`, `hienThi`) VALUES
(3, 'dao@gmail.com', '321', 1),
(4, 'duy@gmail.com', '123', 1),
(1, 'hung@gmail.com', '123', 1),
(6, 'hungbienthanh@gmail.com', '123123', 1),
(2, 'nhan@gmail.com', '123', 1),
(5, 'vy@gmail.com', '321', 1);

-- --------------------------------------------------------

--
-- Table structure for table `theloai`
--

CREATE TABLE `theloai` (
  `maTheLoai` int NOT NULL,
  `tenTheLoai` varchar(512) COLLATE utf8mb4_general_ci NOT NULL,
  `hienThi` tinyint DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `theloai`
--

INSERT INTO `theloai` (`maTheLoai`, `tenTheLoai`, `hienThi`) VALUES
(4, 'Truyện tranh', 1),
(5, 'Tiểu thuyết', 1),
(6, 'Khoa học', 1),
(7, 'Tâm lý', 1),
(8, 'Thiếu nhi', 1),
(9, 'ấdsad', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `chitietphieuban`
--
ALTER TABLE `chitietphieuban`
  ADD PRIMARY KEY (`maPhieuBan`,`maSach`);

--
-- Indexes for table `chitietphieunhap`
--
ALTER TABLE `chitietphieunhap`
  ADD PRIMARY KEY (`maPhieuNhap`,`maSach`);

--
-- Indexes for table `khachhang`
--
ALTER TABLE `khachhang`
  ADD PRIMARY KEY (`maKhachHang`,`soDienThoai`);

--
-- Indexes for table `khuyenmai`
--
ALTER TABLE `khuyenmai`
  ADD PRIMARY KEY (`maKhuyenMai`);

--
-- Indexes for table `nhacungcap`
--
ALTER TABLE `nhacungcap`
  ADD PRIMARY KEY (`maNhaCungCap`);

--
-- Indexes for table `nhanvien`
--
ALTER TABLE `nhanvien`
  ADD PRIMARY KEY (`maNhanVien`);

--
-- Indexes for table `nhaxuatban`
--
ALTER TABLE `nhaxuatban`
  ADD PRIMARY KEY (`maNhaXuatBan`);

--
-- Indexes for table `phieuban`
--
ALTER TABLE `phieuban`
  ADD PRIMARY KEY (`maPhieuBan`);

--
-- Indexes for table `phieunhap`
--
ALTER TABLE `phieunhap`
  ADD PRIMARY KEY (`maPhieuNhap`),
  ADD KEY `maNhanVien_idx` (`maNhanVien`);

--
-- Indexes for table `sach`
--
ALTER TABLE `sach`
  ADD PRIMARY KEY (`maSach`),
  ADD KEY `maTheLoai_idx` (`maTheLoai`);

--
-- Indexes for table `tacgia`
--
ALTER TABLE `tacgia`
  ADD PRIMARY KEY (`maTacGia`);

--
-- Indexes for table `taikhoan`
--
ALTER TABLE `taikhoan`
  ADD PRIMARY KEY (`email`),
  ADD KEY `maNhanVien_taikhoan_idx` (`maNhanVien`);

--
-- Indexes for table `theloai`
--
ALTER TABLE `theloai`
  ADD PRIMARY KEY (`maTheLoai`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `chitietphieuban`
--
ALTER TABLE `chitietphieuban`
  MODIFY `maPhieuBan` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `chitietphieunhap`
--
ALTER TABLE `chitietphieunhap`
  MODIFY `maPhieuNhap` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `khachhang`
--
ALTER TABLE `khachhang`
  MODIFY `maKhachHang` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `khuyenmai`
--
ALTER TABLE `khuyenmai`
  MODIFY `maKhuyenMai` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `nhacungcap`
--
ALTER TABLE `nhacungcap`
  MODIFY `maNhaCungCap` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `nhanvien`
--
ALTER TABLE `nhanvien`
  MODIFY `maNhanVien` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `nhaxuatban`
--
ALTER TABLE `nhaxuatban`
  MODIFY `maNhaXuatBan` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `phieuban`
--
ALTER TABLE `phieuban`
  MODIFY `maPhieuBan` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `phieunhap`
--
ALTER TABLE `phieunhap`
  MODIFY `maPhieuNhap` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `sach`
--
ALTER TABLE `sach`
  MODIFY `maSach` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `tacgia`
--
ALTER TABLE `tacgia`
  MODIFY `maTacGia` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `theloai`
--
ALTER TABLE `theloai`
  MODIFY `maTheLoai` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `sach`
--
ALTER TABLE `sach`
  ADD CONSTRAINT `pk_sach_tl` FOREIGN KEY (`maTheLoai`) REFERENCES `theloai` (`maTheLoai`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
