-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 01-Out-2021 às 19:55
-- Versão do servidor: 10.4.19-MariaDB
-- versão do PHP: 8.0.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `serie`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `series`
--

CREATE TABLE `series` (
  `idSERIES` int(11) NOT NULL,
  `nomeSERIES` varchar(100) CHARACTER SET utf8 NOT NULL,
  `categoriaSERIES` varchar(50) CHARACTER SET utf8 NOT NULL,
  `descricaoSERIES` text CHARACTER SET utf8 NOT NULL,
  `AnoSERIES` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `series`
--

INSERT INTO `series` (`idSERIES`, `nomeSERIES`, `categoriaSERIES`, `descricaoSERIES`, `AnoSERIES`) VALUES
(1, 'ARROW', 'FICÇAO', 'SERIE DO ARQUEIRO VERDE', 2016),
(2, 'FLASH', 'FICÇAO', 'SERIE DO FLASH, O SUPER HEROI MAIS RAPIDO DA DC', 2017),
(4, 'THE 100', 'FICÇAO', 'SERIE SOBRE O FIM DO MUNDO', 2016),
(6, 'LA CASA DE PAPEL', 'AÇAO', 'SERIE DE ROUBO A BANCO', 2018),
(8, 'PEAKBLINDERS', 'AÇAO/AVENTURA', 'SERIE SOBRE UMA GANGUE DE LANDRES', 2015);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `series`
--
ALTER TABLE `series`
  ADD PRIMARY KEY (`idSERIES`) USING BTREE;

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `series`
--
ALTER TABLE `series`
  MODIFY `idSERIES` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
