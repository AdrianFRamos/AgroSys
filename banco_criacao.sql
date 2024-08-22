### CRIAÇÃO DO BANCO:
CREATE DATABASE fazenda;
USE fazenda;

begin;
### PESSOAS
## Cliente:
CREATE TABLE `cliente` (
	`id_cliente` int NOT NULL AUTO_INCREMENT,
	`nome_cliente` varchar(100) NOT NULL,
	`email_cliente` varchar(50) NOT NULL UNIQUE,
	`cnpj_cliente` varchar(25) NOT NULL UNIQUE,
	`ativo_cliente` boolean DEFAULT true,
	PRIMARY KEY (`id_cliente`)
);
CREATE TABLE `enderecocliente` (
	`logradouro_endcliente` varchar(100) NOT NULL,
	`numero_endcliente` varchar(10) NOT NULL,
	`complemento_endcliente` varchar(50) DEFAULT NULL,
	`bairro_endcliente` varchar(100) NOT NULL,
	`cidade_endcliente` varchar(100) NOT NULL,
	`uf_endcliente` varchar(10) NOT NULL,
	`cep_endcliente` varchar(25) NOT NULL,
	`ativo_endcliente` boolean DEFAULT true,
	`id_cliente` int NOT NULL,
	PRIMARY KEY (`id_cliente`),
	KEY `id_cliente` (`id_cliente`),
	CONSTRAINT `enderecocliente_ibfk_1` FOREIGN KEY (`id_cliente`) REFERENCES `cliente` (`id_cliente`)
);
CREATE TABLE `telefonecliente` (
	`ddd_telcliente` varchar(10) NOT NULL,
	`numero_telcliente` varchar(25) NOT NULL,
	`ativo_telcliente` boolean DEFAULT true,
	`id_cliente` int NOT NULL,
	PRIMARY KEY (`id_cliente`),
	KEY `id_cliente` (`id_cliente`),
	CONSTRAINT `telefonecliente_ibfk_1` FOREIGN KEY (`id_cliente`) REFERENCES `cliente` (`id_cliente`)
);

## Fornecedor:
CREATE TABLE `fornecedor` (
	`id_fornecedor` int NOT NULL AUTO_INCREMENT,
	`nome_fornecedor` varchar(100) NOT NULL,
	`email_fornecedor` varchar(50) NOT NULL UNIQUE,
	`cnpj_fornecedor` varchar(25) NOT NULL UNIQUE,
	`ativo_fornecedor` boolean DEFAULT true,
	PRIMARY KEY (`id_fornecedor`)
);
CREATE TABLE `enderecofornecedor` (
	`logradouro_endfornecedor` varchar(100) NOT NULL,
	`numero_endfornecedor` varchar(10) NOT NULL,
	`complemento_endfornecedor` varchar(50) DEFAULT NULL,
	`bairro_endfornecedor` varchar(100) NOT NULL,
	`cidade_endfornecedor` varchar(100) NOT NULL,
	`uf_endfornecedor` varchar(10) NOT NULL,
	`cep_endfornecedor` varchar(25) NOT NULL,
	`ativo_endfornecedor` boolean DEFAULT true,
	`id_fornecedor` int NOT NULL,
	PRIMARY KEY (`id_fornecedor`),
	KEY `id_fornecedor` (`id_fornecedor`),
	CONSTRAINT `enderecofornecedor_ibfk_1` FOREIGN KEY (`id_fornecedor`) REFERENCES `fornecedor` (`id_fornecedor`)
);
CREATE TABLE `telefonefornecedor` (
  `ddd_telfornecedor` varchar(10) NOT NULL,
  `numero_telfornecedor` varchar(25) NOT NULL,
  `ativo_telfornecedor` boolean DEFAULT true,
  `id_fornecedor` int NOT NULL,
  PRIMARY KEY (`id_fornecedor`),
  KEY `id_fornecedor` (`id_fornecedor`),
  CONSTRAINT `telefonefornecedor_ibfk_1` FOREIGN KEY (`id_fornecedor`) REFERENCES `fornecedor` (`id_fornecedor`)
);

## Funcionario:
CREATE TABLE `funcionario` (
	`id_funcionario` int NOT NULL AUTO_INCREMENT,
	`nome_funcionario` varchar(100) NOT NULL,
    `cpf_funcionario` varchar(25) NOT NULL UNIQUE,
	`sexo_funcionario` varchar(10) DEFAULT NULL,
	`email_funcionario` varchar(100) NOT NULL UNIQUE,
	`cargo_funcionario` varchar(50) NOT NULL,
	`usuario_funcionario` varchar(50) NOT NULL UNIQUE,
	`senha_funcionario` varchar(50) NOT NULL,
	`ativo_funcionario` boolean DEFAULT true,
	PRIMARY KEY (`id_funcionario`)
);
CREATE TABLE `enderecofuncionario` (
	`logradouro_endfuncionario` varchar(100) NOT NULL,
	`numero_endfuncionario` varchar(10) NOT NULL,
	`complemento_endfuncionario` varchar(50) DEFAULT NULL,
	`bairro_endfuncionario` varchar(100) NOT NULL,
	`cidade_endfuncionario` varchar(100) NOT NULL,
	`uf_endfuncionario` varchar(10) NOT NULL,
	`cep_endfuncionario` varchar(25) NOT NULL,
	`ativo_endfuncionario` boolean DEFAULT true,
	`id_funcionario` int NOT NULL,
	PRIMARY KEY (`id_funcionario`),
	KEY `id_funcionario` (`id_funcionario`),
	CONSTRAINT `enderecofuncionario_ibfk_1` FOREIGN KEY (`id_funcionario`) REFERENCES `funcionario` (`id_funcionario`)
);
CREATE TABLE `telefonefuncionario` (
	`ddd_telfuncionario` varchar(10) NOT NULL,
	`numero_telfuncionario` varchar(25) NOT NULL,
	`ativo_telfuncionario` boolean DEFAULT true,
	`id_funcionario` int NOT NULL,
	PRIMARY KEY (`id_funcionario`),
	KEY `id_funcionario` (`id_funcionario`),
	CONSTRAINT `telefonefuncionario_ibfk_1` FOREIGN KEY (`id_funcionario`) REFERENCES `funcionario` (`id_funcionario`)
);
commit;

### VENDAS E PRODUÇÃO
begin;
-- Criar a tabela cultivo
CREATE TABLE `cultivo` (
    `id_cultivo` int NOT NULL AUTO_INCREMENT,
    `nome_cultivo` varchar(100) NOT NULL,
    `variedade_cultivo` varchar(100) NOT NULL UNIQUE,
    `tempoprodtrad_cultivo` int DEFAULT NULL,
    `tempoprodctrl_cultivo` int DEFAULT NULL,
	`categoria_cultivo` varchar(50) NOT NULL,
	`ativo_cultivo` boolean DEFAULT true,
	PRIMARY KEY (`id_cultivo`)
);

-- Inserir os dados na tabela cultivo
INSERT INTO `cultivo` (
	`id_cultivo`, 
	`nome_cultivo`, 
	`variedade_cultivo`, 
	`tempoprodtrad_cultivo`, 
	`tempoprodctrl_cultivo`, 
	`categoria_cultivo`
) VALUES
(1, 'Abacaxi', 'Abacaxi Pérola', 600, 365, 'Fruta'),
(2, 'Abóbora', 'Abóbora Japonesa', 100, 60, 'Legume'),
(3, 'Abobrinha', 'Abobrinha Menina Brasileira', 50, 30, 'Legume'),
(4, 'Acelga', 'Acelga Verde de Verão', 60, 35, 'Verdura'),
(5, 'Agrião', 'Agrião de Água', 45, 25, 'Verdura'),
(6, 'Alface', 'Alface Crespa', 66, 41, 'Verdura'),
(7, 'Alface', 'Alface Americana', 70, 44, 'Verdura'),
(8, 'Algodão', 'Algodão BRS 368', 180, 120, 'Outro'),
(9, 'Alho', 'Alho Roxo', 270, 180, 'Legume'),
(10, 'Alho-poró', 'Alho-poró Porto Rico', 150, 90, 'Legume'),
(11, 'Banana', 'Banana Prata', 210, 150, 'Fruta'),
(12, 'Batata-doce', 'Batata-doce Beauregard', 105, 60, 'Legume'),
(13, 'Beterraba', 'Beterraba Detroit Dark Red', 60, 35, 'Legume'),
(14, 'Beterraba', 'Beterraba Early Wonder', 60, 35, 'Legume'),
(15, 'Berinjela', 'Berinjela Roxa', 80, 50, 'Legume'),
(16, 'Brócolis', 'Brócolis Calabrês', 70, 40, 'Legume'),
(17, 'Caju', 'Caju Anão Precoce', 210, 150, 'Fruta'),
(18, 'Cebola', 'Cebola Baia Periforme', 110, 70, 'Legume'),
(19, 'Cebolinha', 'Cebolinha Verde Todo o Ano', 50, 30, 'Verdura'),
(20, 'Cenoura', 'Cenoura Brasília', 80, 50, 'Legume'),
(21, 'Cenoura', 'Cenoura Nantes', 70, 45, 'Legume'),
(22, 'Chicória', 'Chicória Catalonha', 55, 30, 'Verdura'),
(23, 'Coentro', 'Coentro Português', 55, 30, 'Verdura'),
(24, 'Couve', 'Couve Manteiga', 58, 34, 'Verdura'),
(25, 'Couve-de-bruxelas', 'Couve-de-bruxelas Menina', 90, 55, 'Legume'),
(26, 'Couve-flor', 'Couve-flor de Inverno', 55, 30, 'Legume'),
(27, 'Cupuaçu', 'Cupuaçuzeiro', 210, 150, 'Fruta'),
(28, 'Erva-doce', 'Erva-doce de Mesa', 110, 70, 'Verdura'),
(29, 'Ervilha', 'Ervilha Douce Provence', 65, 40, 'Legume'),
(30, 'Ervilha', 'Ervilha Early Frosty', 65, 40, 'Legume'),
(31, 'Espinafre', 'Espinafre Gigante de Inverno', 50, 30, 'Verdura'),
(32, 'Fava', 'Fava Superaguadulce', 90, 55, 'Legume'),
(33, 'Feijão', 'Feijão BRS Estilo', 80, 50, 'Legume'),
(34, 'Feijão', 'Feijão Elettra', 90, 55, 'Legume'),
(35, 'Feijão', 'Feijão Carioca', 80, 50, 'Legume'),
(36, 'Feijão-vagem', 'Feijão-vagem Macarrão', 65, 40, 'Legume'),
(37, 'Girassol', 'Girassol Catissol 01', 100, 60, 'Outro'),
(38, 'Hortelã', 'Hortelã Comum', 95, 60, 'Verdura'),
(39, 'Manjericão', 'Manjericão Genovês', 65, 40, 'Verdura'),
(40, 'Mandioca', 'Mandioca Branca', 273, 180, 'Legume'),
(41, 'Maracujá', 'Maracujá Azedo', 165, 100, 'Legume'),
(42, 'Maxixe', 'Maxixe Paulista', 60, 35, 'Legume'),
(43, 'Melancia', 'Melancia Crimson Sweet', 90, 55, 'Fruta'),
(44, 'Melão', 'Melão Orange Sherbet', 90, 55, 'Fruta'),
(45, 'Milho', 'Milho Doce', 80, 50, 'Legume'),
(46, 'Morango', 'Morango Camarosa', 68, 40, 'Fruta'),
(47, 'Orégano', 'Orégano Grego', 75, 45, 'Verdura'),
(48, 'Pepino', 'Pepino Caipira', 60, 35, 'Legume'),
(49, 'Pimentão', 'Pimentão Amarelo', 80, 50, 'Legume'),
(50, 'Quiabo', 'Quiabo Cristal', 55, 30, 'Legume'),
(51, 'Rabanete', 'Rabanete Crimson Giant', 25, 20, 'Legume'),
(52, 'Repolho', 'Repolho Roxo de Inverno', 100, 60, 'Legume'),
(53, 'Rúcula', 'Rúcula Cultivada', 45, 25, 'Verdura'),
(54, 'Salsa', 'Salsa Gigante de Itália', 80, 50, 'Verdura'),
(55, 'Salsinha', 'Salsinha Crespa', 80, 50, 'Verdura'),
(56, 'Soja', 'Soja BRS 369', 150, 100, 'Legume'),
(57, 'Tomate', 'Tomate Cereja', 75, 46, 'Fruta'),
(58, 'Tomate', 'Tomate Italiano', 79, 48, 'Fruta'),
(59, 'Tomate', 'Tomate Santa Cruz Kada', 80, 48, 'Fruta'),
(60, 'Tomate', 'Tomateiro Cereja', 75, 46, 'Fruta'),
(61, 'Tomilho', 'Tomilho Limão', 85, 50, 'Verdura')
;
commit;

begin;
-- Criar a tabela recomendacaocultivo
CREATE TABLE `recomendacaocultivo` (
    `id_recomendacaocultivo` int NOT NULL AUTO_INCREMENT,
    `regiao` VARCHAR(25) NOT NULL,
    `estacao` VARCHAR(25) NOT NULL,
    `id_cultivo` INT NOT NULL,
    PRIMARY KEY (`id_recomendacaocultivo`, `id_cultivo`),
	KEY `id_cultivo` (`id_cultivo`),
    CONSTRAINT `recomendacaocultivo_ibfk_1` FOREIGN KEY (`id_cultivo`) REFERENCES `cultivo`(`id_cultivo`)
);

-- Inserir os dados na tabela recomendacaocultivo
-- Sul
INSERT INTO `recomendacaocultivo` (
	`regiao`, 
	`estacao`, 
	`id_cultivo`
) VALUES
('Sul', 'Inverno', 31), ('Sul', 'Inverno', 24), ('Sul', 'Inverno', 6), ('Sul', 'Inverno', 53), ('Sul', 'Inverno', 16),
('Sul', 'Inverno', 26), ('Sul', 'Inverno', 52), ('Sul', 'Inverno', 25), ('Sul', 'Inverno', 19), ('Sul', 'Inverno', 10),
('Sul', 'Inverno', 20), ('Sul', 'Inverno', 13), ('Sul', 'Inverno', 30), ('Sul', 'Inverno', 34), ('Sul', 'Inverno', 54),
('Sul', 'Inverno', 39), ('Sul', 'Inverno', 61),
('Sul', 'Verão', 60), ('Sul', 'Verão', 49), ('Sul', 'Verão', 3), ('Sul', 'Verão', 48), ('Sul', 'Verão', 15),
('Sul', 'Verão', 45), ('Sul', 'Verão', 36), ('Sul', 'Verão', 50), ('Sul', 'Verão', 21), ('Sul', 'Verão', 14),
('Sul', 'Verão', 51), ('Sul', 'Verão', 7), ('Sul', 'Verão', 31), ('Sul', 'Verão', 53), ('Sul', 'Verão', 5),
('Sul', 'Verão', 39), ('Sul', 'Verão', 23), ('Sul', 'Verão', 38), ('Sul', 'Verão', 55), ('Sul', 'Verão', 19),
('Sul', 'Outono', 2), ('Sul', 'Outono', 12), ('Sul', 'Outono', 21), ('Sul', 'Outono', 13), ('Sul', 'Outono', 51),
('Sul', 'Outono', 6), ('Sul', 'Outono', 31), ('Sul', 'Outono', 16), ('Sul', 'Outono', 26), ('Sul', 'Outono', 24),
('Sul', 'Outono', 4), ('Sul', 'Outono', 22), ('Sul', 'Outono', 5), ('Sul', 'Outono', 29), ('Sul', 'Outono', 32),
('Sul', 'Primavera', 59), ('Sul', 'Primavera', 49), ('Sul', 'Primavera', 48), ('Sul', 'Primavera', 15),
('Sul', 'Primavera', 46), ('Sul', 'Primavera', 43), ('Sul', 'Primavera', 44), ('Sul', 'Primavera', 3),
('Sul', 'Primavera', 50), ('Sul', 'Primavera', 36), ('Sul', 'Primavera', 45), ('Sul', 'Primavera', 7),
('Sul', 'Primavera', 53), ('Sul', 'Primavera', 31), ('Sul', 'Primavera', 39);

-- Sudeste
INSERT INTO `recomendacaocultivo` (
	`regiao`, 
	`estacao`, 
	`id_cultivo`
) VALUES
('Sudeste', 'Inverno', 6), ('Sudeste', 'Inverno', 31), ('Sudeste', 'Inverno', 24), ('Sudeste', 'Inverno', 53),
('Sudeste', 'Inverno', 16), ('Sudeste', 'Inverno', 26), ('Sudeste', 'Inverno', 52), ('Sudeste', 'Inverno', 19),
('Sudeste', 'Inverno', 10), ('Sudeste', 'Inverno', 20), ('Sudeste', 'Inverno', 14), ('Sudeste', 'Inverno', 30),
('Sudeste', 'Inverno', 34), ('Sudeste', 'Inverno', 54), ('Sudeste', 'Inverno', 39),
('Sudeste', 'Verão', 58), ('Sudeste', 'Verão', 49), ('Sudeste', 'Verão', 48), ('Sudeste', 'Verão', 15),
('Sudeste', 'Verão', 3), ('Sudeste', 'Verão', 50), ('Sudeste', 'Verão', 45), ('Sudeste', 'Verão', 36),
('Sudeste', 'Verão', 43), ('Sudeste', 'Verão', 44), ('Sudeste', 'Verão', 21), ('Sudeste', 'Verão', 14),
('Sudeste', 'Verão', 51), ('Sudeste', 'Verão', 7), ('Sudeste', 'Verão', 53),
('Sudeste', 'Outono', 6), ('Sudeste', 'Outono', 31), ('Sudeste', 'Outono', 24), ('Sudeste', 'Outono', 53),
('Sudeste', 'Outono', 16), ('Sudeste', 'Outono', 26), ('Sudeste', 'Outono', 52), ('Sudeste', 'Outono', 19),
('Sudeste', 'Outono', 10), ('Sudeste', 'Outono', 20), ('Sudeste', 'Outono', 14), ('Sudeste', 'Outono', 30),
('Sudeste', 'Outono', 34), ('Sudeste', 'Outono', 54), ('Sudeste', 'Outono', 39),
('Sudeste', 'Primavera', 58), ('Sudeste', 'Primavera', 49), ('Sudeste', 'Primavera', 48), ('Sudeste', 'Primavera', 15),
('Sudeste', 'Primavera', 46), ('Sudeste', 'Primavera', 3), ('Sudeste', 'Primavera', 50), ('Sudeste', 'Primavera', 36),
('Sudeste', 'Primavera', 45), ('Sudeste', 'Primavera', 20), ('Sudeste', 'Primavera', 14), ('Sudeste', 'Primavera', 51),
('Sudeste', 'Primavera', 7), ('Sudeste', 'Primavera', 53), ('Sudeste', 'Primavera', 31), ('Sudeste', 'Primavera', 39);

-- Nordeste
INSERT INTO `recomendacaocultivo` (
	`regiao`, 
	`estacao`, 
	`id_cultivo`
) VALUES
('Nordeste', 'Verão', 2), ('Nordeste', 'Verão', 43), ('Nordeste', 'Verão', 44), ('Nordeste', 'Verão', 50),
('Nordeste', 'Verão', 33), ('Nordeste', 'Verão', 42), ('Nordeste', 'Verão', 45), ('Nordeste', 'Verão', 58),
('Nordeste', 'Verão', 49), ('Nordeste', 'Verão', 48), ('Nordeste', 'Verão', 15), ('Nordeste', 'Verão', 20),
('Nordeste', 'Verão', 14), ('Nordeste', 'Verão', 6), ('Nordeste', 'Verão', 53),
('Nordeste', 'Outono', 2), ('Nordeste', 'Outono', 35), ('Nordeste', 'Outono', 45), ('Nordeste', 'Outono', 40),
('Nordeste', 'Outono', 12), ('Nordeste', 'Outono', 20), ('Nordeste', 'Outono', 13), ('Nordeste', 'Outono', 42),
('Nordeste', 'Outono', 48), ('Nordeste', 'Outono', 49), ('Nordeste', 'Outono', 59), ('Nordeste', 'Outono', 6),
('Nordeste', 'Outono', 31), ('Nordeste', 'Outono', 24), ('Nordeste', 'Outono', 53),
('Nordeste', 'Inverno', 6), ('Nordeste', 'Inverno', 24), ('Nordeste', 'Inverno', 31), ('Nordeste', 'Inverno', 51),
('Nordeste', 'Inverno', 13), ('Nordeste', 'Inverno', 20), ('Nordeste', 'Inverno', 9), ('Nordeste', 'Inverno', 18),
('Nordeste', 'Inverno', 28), ('Nordeste', 'Inverno', 23), ('Nordeste', 'Inverno', 55), ('Nordeste', 'Inverno', 39),
('Nordeste', 'Inverno', 61), ('Nordeste', 'Inverno', 38), ('Nordeste', 'Inverno', 47),
('Nordeste', 'Primavera', 45), ('Nordeste', 'Primavera', 35), ('Nordeste', 'Primavera', 40), ('Nordeste', 'Primavera', 12),
('Nordeste', 'Primavera', 20), ('Nordeste', 'Primavera', 13), ('Nordeste', 'Primavera', 48), ('Nordeste', 'Primavera', 49),
('Nordeste', 'Primavera', 59), ('Nordeste', 'Primavera', 50), ('Nordeste', 'Primavera', 2), ('Nordeste', 'Primavera', 43),
('Nordeste', 'Primavera', 44), ('Nordeste', 'Primavera', 42), ('Nordeste', 'Primavera', 6);

-- Norte
INSERT INTO `recomendacaocultivo` (
	`regiao`, 
	`estacao`, 
	`id_cultivo`
) VALUES
('Norte', 'Verão', 40), ('Norte', 'Verão', 45), ('Norte', 'Verão', 1), ('Norte', 'Verão', 11), ('Norte', 'Verão', 41),
('Norte', 'Verão', 43), ('Norte', 'Verão', 44), ('Norte', 'Verão', 17), ('Norte', 'Verão', 27), ('Norte', 'Verão', 29),
('Norte', 'Outono', 1), ('Norte', 'Outono', 40), ('Norte', 'Outono', 45), ('Norte', 'Outono', 11), ('Norte', 'Outono', 41),
('Norte', 'Outono', 17), ('Norte', 'Outono', 27), ('Norte', 'Outono', 29),
('Norte', 'Inverno', 1), ('Norte', 'Inverno', 17), ('Norte', 'Inverno', 27), ('Norte', 'Inverno', 29),
('Norte', 'Primavera', 40), ('Norte', 'Primavera', 45), ('Norte', 'Primavera', 1), ('Norte', 'Primavera', 11),
('Norte', 'Primavera', 41), ('Norte', 'Primavera', 43), ('Norte', 'Primavera', 44), ('Norte', 'Primavera', 17),
('Norte', 'Primavera', 27), ('Norte', 'Primavera', 29);

-- Centro-Oeste
INSERT INTO `recomendacaocultivo` (
	`regiao`, 
	`estacao`, 
	`id_cultivo`
) VALUES
('Centro-Oeste', 'Verão', 45), ('Centro-Oeste', 'Verão', 56), ('Centro-Oeste', 'Verão', 37), ('Centro-Oeste', 'Verão', 8),
('Centro-Oeste', 'Verão', 34), ('Centro-Oeste', 'Verão', 59), ('Centro-Oeste', 'Verão', 49), ('Centro-Oeste', 'Verão', 2),
('Centro-Oeste', 'Verão', 43), ('Centro-Oeste', 'Verão', 48), ('Centro-Oeste', 'Verão', 15), ('Centro-Oeste', 'Verão', 50),
('Centro-Oeste', 'Verão', 20), ('Centro-Oeste', 'Verão', 14), ('Centro-Oeste', 'Verão', 3),
('Centro-Oeste', 'Outono', 45), ('Centro-Oeste', 'Outono', 56), ('Centro-Oeste', 'Outono', 34), ('Centro-Oeste', 'Outono', 37),
('Centro-Oeste', 'Outono', 8), ('Centro-Oeste', 'Outono', 59), ('Centro-Oeste', 'Outono', 49), ('Centro-Oeste', 'Outono', 2),
('Centro-Oeste', 'Outono', 48), ('Centro-Oeste', 'Outono', 15), ('Centro-Oeste', 'Outono', 50), ('Centro-Oeste', 'Outono', 20),
('Centro-Oeste', 'Outono', 14), ('Centro-Oeste', 'Outono', 3), ('Centro-Oeste', 'Outono', 43),
('Centro-Oeste', 'Inverno', 6), ('Centro-Oeste', 'Inverno', 31), ('Centro-Oeste', 'Inverno', 24), ('Centro-Oeste', 'Inverno', 53),
('Centro-Oeste', 'Inverno', 16), ('Centro-Oeste', 'Inverno', 26), ('Centro-Oeste', 'Inverno', 52), ('Centro-Oeste', 'Inverno', 19),
('Centro-Oeste', 'Inverno', 10), ('Centro-Oeste', 'Inverno', 20), ('Centro-Oeste', 'Inverno', 14), ('Centro-Oeste', 'Inverno', 30),
('Centro-Oeste', 'Inverno', 34), ('Centro-Oeste', 'Inverno', 54), ('Centro-Oeste', 'Inverno', 39),
('Centro-Oeste', 'Primavera', 45), ('Centro-Oeste', 'Primavera', 56), ('Centro-Oeste', 'Primavera', 37),
('Centro-Oeste', 'Primavera', 8), ('Centro-Oeste', 'Primavera', 34), ('Centro-Oeste', 'Primavera', 59),
('Centro-Oeste', 'Primavera', 49), ('Centro-Oeste', 'Primavera', 2), ('Centro-Oeste', 'Primavera', 48),
('Centro-Oeste', 'Primavera', 15), ('Centro-Oeste', 'Primavera', 50), ('Centro-Oeste', 'Primavera', 20),
('Centro-Oeste', 'Primavera', 14), ('Centro-Oeste', 'Primavera', 3), ('Centro-Oeste', 'Primavera', 43);
commit;

begin;
## EstoqueInsumo
CREATE TABLE `estoqueinsumo` (
	`id_insumo` int NOT NULL AUTO_INCREMENT,
	`nome_insumo` varchar(100) NOT NULL,
	`categoria_insumo` varchar(50) NOT NULL,
    `qtd_insumo` int DEFAULT 0,
    `unidqtd_insumo` varchar(10) DEFAULT 'kg',
	`ativo_insumo` boolean DEFAULT true,
	PRIMARY KEY (`id_insumo`)
);

## PedidoCompra
CREATE TABLE `pedidocompra` (
	`id_pedidocompra` int NOT NULL AUTO_INCREMENT,
	`data_pedidocompra` timestamp DEFAULT CURRENT_TIMESTAMP,
	`id_fornecedor` int NOT NULL,
	PRIMARY KEY (`id_pedidocompra`),
	KEY `id_fornecedor` (`id_fornecedor`),
	CONSTRAINT `pedidocompra_ibfk_1` FOREIGN KEY (`id_fornecedor`) REFERENCES `fornecedor` (`id_fornecedor`)
);

## CompraItem
CREATE TABLE `compraitem` (
	`id_compraitem` int NOT NULL AUTO_INCREMENT,
	`qtd_compraitem` int DEFAULT 0,
	`unidqtd_compraitem` varchar(10) DEFAULT 'kg',
    `valor_compraitem` decimal(9,3) NOT NULL,
	`id_pedidocompra` int NOT NULL,
	`id_insumo` int NOT NULL,
	PRIMARY KEY (`id_compraitem`, `id_pedidocompra`),
	KEY `id_pedidocompra` (`id_pedidocompra`),
	CONSTRAINT `compraitem_ibfk_1` FOREIGN KEY (`id_pedidocompra`) REFERENCES `pedidocompra` (`id_pedidocompra`),
	KEY `id_insumo` (`id_insumo`),
	CONSTRAINT `compraitem_ibfk_2` FOREIGN KEY (`id_insumo`) REFERENCES `estoqueinsumo` (`id_insumo`)
);

-- Criar Trigger para atualizar qtd_insumo após inserir em compraitem
DELIMITER //
CREATE TRIGGER after_insert_compraitem
AFTER INSERT ON compraitem
FOR EACH ROW
BEGIN
    UPDATE estoqueinsumo
    SET qtd_insumo = qtd_insumo + NEW.qtd_compraitem
    WHERE id_insumo = NEW.id_insumo;
END //
DELIMITER ;

## SaidaInsumo
CREATE TABLE `saidainsumo` (
	`id_saidainsumo` int NOT NULL AUTO_INCREMENT,
	`qtd_saidainsumo` int DEFAULT 0,
	`unidqtd_saidainsumo` varchar(10) DEFAULT 'kg',
	`data_saidainsumo` timestamp DEFAULT CURRENT_TIMESTAMP,
	`id_insumo` int NOT NULL,
	PRIMARY KEY (`id_saidainsumo`, `id_insumo`),
	KEY `id_insumo` (`id_insumo`),
	CONSTRAINT `saidainsumo_ibfk_1` FOREIGN KEY (`id_insumo`) REFERENCES `estoqueinsumo` (`id_insumo`)
);

## Producao
CREATE TABLE `producao` (
	`id_producao` int NOT NULL AUTO_INCREMENT,
	`qtd_producao` int NOT NULL,
	`unidqtd_producao` varchar(10) DEFAULT 'kg',
	`data_producao` timestamp DEFAULT CURRENT_TIMESTAMP,
    `datacolheita_producao` timestamp,
    `ambientectrl_producao` boolean DEFAULT true,
    `finalizado_producao` boolean DEFAULT false,
	`id_cultivo` int NOT NULL,
	PRIMARY KEY (`id_producao`),
	KEY `id_cultivo` (`id_cultivo`),
	CONSTRAINT `producao_ibfk_1` FOREIGN KEY (`id_cultivo`) REFERENCES `cultivo` (`id_cultivo`)
);

## EstoqueProduto
CREATE TABLE `estoqueproduto` (
	`id_estoqueproduto` int NOT NULL AUTO_INCREMENT,
	`qtd_estoqueproduto` int NOT NULL,
	`unidqtd_estoqueproduto` varchar(10) DEFAULT 'kg',
	`dataentrada_estoqueproduto` timestamp DEFAULT CURRENT_TIMESTAMP,
	`ativo_estoqueproduto` boolean DEFAULT true,
	`id_producao` int NOT NULL,
	PRIMARY KEY (`id_estoqueproduto`),
	KEY `id_producao` (`id_producao`),
	CONSTRAINT `estoqueproduto_ibfk_1` FOREIGN KEY (`id_producao`) REFERENCES `producao` (`id_producao`)
);

-- Criar Trigger para atualizar estoqueproduto após finalizar produção
DELIMITER //
CREATE TRIGGER after_update_producao
AFTER UPDATE ON producao
FOR EACH ROW
BEGIN
    IF NEW.finalizado_producao = true AND OLD.finalizado_producao = false THEN
        INSERT INTO estoqueproduto (qtd_estoqueproduto, unidqtd_estoqueproduto, id_producao)
        VALUES (NEW.qtd_producao, NEW.unidqtd_producao, NEW.id_producao);
    END IF;
END //
DELIMITER ;

## PedidoVenda
CREATE TABLE `pedidovenda` (
	`id_pedidovenda` int NOT NULL AUTO_INCREMENT,
	`data_pedidovenda` timestamp DEFAULT CURRENT_TIMESTAMP,
	`id_cliente` int NOT NULL,
	PRIMARY KEY (`id_pedidovenda`),
	KEY `id_cliente` (`id_cliente`),
	CONSTRAINT `pedidovenda_ibfk_1` FOREIGN KEY (`id_cliente`) REFERENCES `cliente` (`id_cliente`)
);

## VendaItem
CREATE TABLE `vendaitem` (
	`id_vendaitem` int NOT NULL AUTO_INCREMENT,
	`qtd_vendaitem` int NOT NULL,
	`unidqtd_vendaitem` varchar(10) DEFAULT 'kg',
    `valor_vendaitem` decimal(9,3) NOT NULL,
    `desconto_vendaitem` decimal(9,3),
	`id_pedidovenda` int NOT NULL,
	`id_estoqueproduto` int NOT NULL,
	PRIMARY KEY (`id_vendaitem`, `id_pedidovenda`),
	KEY `id_pedidovenda` (`id_pedidovenda`),
	CONSTRAINT `vendaitem_ibfk_1` FOREIGN KEY (`id_pedidovenda`) REFERENCES `pedidovenda` (`id_pedidovenda`),
	KEY `id_estoqueproduto` (`id_estoqueproduto`),
	CONSTRAINT `vendaitem_ibfk_2` FOREIGN KEY (`id_estoqueproduto`) REFERENCES `estoqueproduto` (`id_estoqueproduto`)
);

-- Criar Trigger para atualizar estoqueproduto após cadastrar venda
DELIMITER //
CREATE TRIGGER after_insert_vendaitem
AFTER INSERT ON vendaitem
FOR EACH ROW
BEGIN
    UPDATE estoqueproduto
    SET qtd_estoqueproduto = qtd_estoqueproduto - NEW.qtd_vendaitem
    WHERE id_estoqueproduto = NEW.id_estoqueproduto;
END //
DELIMITER ;

commit;

