-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 31-Dez-2020 às 14:31
-- Versão do servidor: 10.4.16-MariaDB
-- versão do PHP: 7.4.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `exemplo_crud`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `pacotes`
--

CREATE TABLE `pacotes` (
  `IdPacotes` int(11) NOT NULL,
  `NomePacote` varchar(80) DEFAULT NULL,
  `OrigemPacote` varchar(80) DEFAULT NULL,
  `DestinoPacote` varchar(80) DEFAULT NULL,
  `AtrativosPacote` varchar(80) DEFAULT NULL,
  `Saida` varchar(80) DEFAULT NULL,
  `Retorno` varchar(80) DEFAULT NULL,
  `Id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `pacotes`
--

INSERT INTO `pacotes` (`IdPacotes`, `NomePacote`, `OrigemPacote`, `DestinoPacote`, `AtrativosPacote`, `Saida`, `Retorno`, `Id`) VALUES
(1, 'Disney', 'Brasil', 'EUA', 'Parque tematico', '12/01/2020', '20/01/2020', 1),
(7, 'Teste', 'Teste', 'Teste', 'Teste', 'Teste', 'Teste', 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `produto`
--

CREATE TABLE `produto` (
  `IdProduto` int(11) NOT NULL,
  `NomeProduto` varchar(50) DEFAULT NULL,
  `MarcaProduto` varchar(50) DEFAULT NULL,
  `CorProduto` varchar(30) DEFAULT NULL,
  `TamanhoProduto` varchar(15) DEFAULT NULL,
  `QuantidadeEstoque` int(11) DEFAULT NULL,
  `Preco` double(10,2) DEFAULT NULL,
  `DataCadastro` varchar(10) DEFAULT NULL,
  `Id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `produto`
--

INSERT INTO `produto` (`IdProduto`, `NomeProduto`, `MarcaProduto`, `CorProduto`, `TamanhoProduto`, `QuantidadeEstoque`, `Preco`, `DataCadastro`, `Id`) VALUES
(2, 'Camiseta', 'Daora', 'Azul', 'GG', 123, 19.99, '22/12/2020', 4),
(3, 'Vestido', 'Marca', 'Roxo', 'M', 26, 26.99, '22/12/2020', 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuario`
--

CREATE TABLE `usuario` (
  `Id` int(11) NOT NULL,
  `Nome` varchar(80) DEFAULT NULL,
  `DataNascimento` varchar(10) DEFAULT NULL,
  `Login` varchar(30) DEFAULT NULL,
  `Senha` varchar(30) DEFAULT NULL,
  `Conta` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `usuario`
--

INSERT INTO `usuario` (`Id`, `Nome`, `DataNascimento`, `Login`, `Senha`, `Conta`) VALUES
(1, 'Tairik', '17/04/2000', 'Tairik', 'Tairik', 'administrador'),
(2, 'Teste', '10/10/1800', 'Teste', 'Teste', 'usuario'),
(4, 'Ana', '22/12/1998', 'Ana', 'Ana', 'colaborador');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `pacotes`
--
ALTER TABLE `pacotes`
  ADD PRIMARY KEY (`IdPacotes`),
  ADD KEY `Usuario_Pacote_fk` (`Id`);

--
-- Índices para tabela `produto`
--
ALTER TABLE `produto`
  ADD PRIMARY KEY (`IdProduto`);

--
-- Índices para tabela `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `pacotes`
--
ALTER TABLE `pacotes`
  MODIFY `IdPacotes` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de tabela `produto`
--
ALTER TABLE `produto`
  MODIFY `IdProduto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de tabela `usuario`
--
ALTER TABLE `usuario`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `pacotes`
--
ALTER TABLE `pacotes`
  ADD CONSTRAINT `Usuario_Pacote_fk` FOREIGN KEY (`Id`) REFERENCES `usuario` (`Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
