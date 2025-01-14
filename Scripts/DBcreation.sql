USE [master]
GO

/****** Object:  Database [HRDB]    Script Date: 22-12-2024 16:48:48 ******/
CREATE DATABASE [HRDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HRDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\HRDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HRDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\HRDB.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HRDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [HRDB] SET ANSI_NULL_DEFAULT ON 
GO

ALTER DATABASE [HRDB] SET ANSI_NULLS ON 
GO

ALTER DATABASE [HRDB] SET ANSI_PADDING ON 
GO

ALTER DATABASE [HRDB] SET ANSI_WARNINGS ON 
GO

ALTER DATABASE [HRDB] SET ARITHABORT ON 
GO

ALTER DATABASE [HRDB] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [HRDB] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [HRDB] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [HRDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [HRDB] SET CURSOR_DEFAULT  LOCAL 
GO

ALTER DATABASE [HRDB] SET CONCAT_NULL_YIELDS_NULL ON 
GO

ALTER DATABASE [HRDB] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [HRDB] SET QUOTED_IDENTIFIER ON 
GO

ALTER DATABASE [HRDB] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [HRDB] SET  DISABLE_BROKER 
GO

ALTER DATABASE [HRDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [HRDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [HRDB] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [HRDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [HRDB] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [HRDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [HRDB] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [HRDB] SET RECOVERY FULL 
GO

ALTER DATABASE [HRDB] SET  MULTI_USER 
GO

ALTER DATABASE [HRDB] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [HRDB] SET DB_CHAINING OFF 
GO

ALTER DATABASE [HRDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [HRDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [HRDB] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [HRDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [HRDB] SET QUERY_STORE = ON
GO

ALTER DATABASE [HRDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO

ALTER DATABASE [HRDB] SET  READ_WRITE 
GO


