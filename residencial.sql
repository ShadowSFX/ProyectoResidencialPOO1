/*
Navicat MySQL Data Transfer

Source Server         : MySQL
Source Server Version : 50720
Source Host           : localhost:3306
Source Database       : residencial

Target Server Type    : MYSQL
Target Server Version : 50720
File Encoding         : 65001

Date: 2019-06-08 01:15:12
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for asesores
-- ----------------------------
DROP TABLE IF EXISTS `asesores`;
CREATE TABLE `asesores` (
  `idasesor` int(11) NOT NULL AUTO_INCREMENT,
  `codasesor` char(5) NOT NULL,
  `nombres` char(30) NOT NULL,
  `apellidos` char(25) NOT NULL,
  `direccion` char(80) NOT NULL,
  `telefono` char(9) NOT NULL,
  `dui` char(10) NOT NULL,
  `nit` char(17) NOT NULL,
  PRIMARY KEY (`idasesor`),
  UNIQUE KEY `dui` (`dui`) USING BTREE,
  UNIQUE KEY `nit` (`nit`) USING BTREE,
  UNIQUE KEY `codasesor` (`codasesor`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of asesores
-- ----------------------------
INSERT INTO `asesores` VALUES ('1', '1', 'GLENDA', 'GONZALEZ', 'santa ana', '5555-5555', '04007921-9', '2013-051188-203-3');

-- ----------------------------
-- Table structure for clientes
-- ----------------------------
DROP TABLE IF EXISTS `clientes`;
CREATE TABLE `clientes` (
  `idcliente` int(11) NOT NULL AUTO_INCREMENT,
  `codcliente` char(5) NOT NULL,
  `nombres` char(30) NOT NULL,
  `apellidos` char(25) NOT NULL,
  `fecnac` date NOT NULL,
  `direccion` char(80) NOT NULL,
  `telefono` char(9) NOT NULL,
  `dui` char(10) NOT NULL,
  `nrc` char(10) DEFAULT NULL,
  `nit` char(17) NOT NULL,
  `codempresa` char(4) NOT NULL,
  `cargo` char(20) NOT NULL,
  `salario` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`idcliente`),
  UNIQUE KEY `codcliente` (`codcliente`) USING BTREE,
  KEY `fk_codempresa` (`codempresa`),
  CONSTRAINT `fk_codempresa` FOREIGN KEY (`codempresa`) REFERENCES `empresas` (`codempresa`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of clientes
-- ----------------------------
INSERT INTO `clientes` VALUES ('1', '1', 'MAURICIO ALEXANDER', 'RAMIREZ ROSALES', '1988-11-05', 'ALGUN LUGAR', '5555-5555', '04001585-9', '543543-1', '0210-051188-354-5', '1', 'PROGRAMADOR', '2500.00');

-- ----------------------------
-- Table structure for empresas
-- ----------------------------
DROP TABLE IF EXISTS `empresas`;
CREATE TABLE `empresas` (
  `idempresa` int(11) NOT NULL AUTO_INCREMENT,
  `codempresa` char(4) NOT NULL,
  `nombre` char(60) NOT NULL,
  `direccion` char(80) NOT NULL,
  `telefono` char(9) NOT NULL,
  `nrc` char(10) NOT NULL,
  `nit` char(17) NOT NULL,
  PRIMARY KEY (`idempresa`),
  UNIQUE KEY `codempresa` (`codempresa`) USING BTREE,
  UNIQUE KEY `nrc` (`nrc`) USING BTREE,
  UNIQUE KEY `nit` (`nit`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of empresas
-- ----------------------------
INSERT INTO `empresas` VALUES ('1', '1', 'BANCO AGRICOLA, SA. DE CV.', 'LKASJDLAKJSDKLAJD', '1111-1111', '1234567-9', '2222-222222-222-1');

-- ----------------------------
-- Table structure for estados_viviendas
-- ----------------------------
DROP TABLE IF EXISTS `estados_viviendas`;
CREATE TABLE `estados_viviendas` (
  `idestado_vivienda` int(11) NOT NULL AUTO_INCREMENT,
  `codestado_vivienda` char(2) NOT NULL,
  `descripcion` char(15) NOT NULL,
  PRIMARY KEY (`idestado_vivienda`),
  UNIQUE KEY `codestado_vivienda` (`codestado_vivienda`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of estados_viviendas
-- ----------------------------
INSERT INTO `estados_viviendas` VALUES ('1', '1', 'En Venta');
INSERT INTO `estados_viviendas` VALUES ('2', '2', 'Vendida');
INSERT INTO `estados_viviendas` VALUES ('3', '3', 'Alquilada');
INSERT INTO `estados_viviendas` VALUES ('4', '4', 'Hipotecada');

-- ----------------------------
-- Table structure for modelos_viviendas
-- ----------------------------
DROP TABLE IF EXISTS `modelos_viviendas`;
CREATE TABLE `modelos_viviendas` (
  `idmodelo_vivienda` int(11) NOT NULL AUTO_INCREMENT,
  `codmodelo_vivienda` char(2) NOT NULL,
  `descripcion` char(20) NOT NULL,
  PRIMARY KEY (`idmodelo_vivienda`),
  UNIQUE KEY `codmodelo_vivienda` (`codmodelo_vivienda`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of modelos_viviendas
-- ----------------------------
INSERT INTO `modelos_viviendas` VALUES ('1', '1', 'Contemporanea');
INSERT INTO `modelos_viviendas` VALUES ('2', '2', 'Doble Planta');
INSERT INTO `modelos_viviendas` VALUES ('3', '3', 'Apartamento');

-- ----------------------------
-- Table structure for tipostransacciones
-- ----------------------------
DROP TABLE IF EXISTS `tipostransacciones`;
CREATE TABLE `tipostransacciones` (
  `idtipotransaccion` int(11) NOT NULL AUTO_INCREMENT,
  `codtipotransaccion` char(2) NOT NULL,
  `descripcion` varchar(15) NOT NULL,
  PRIMARY KEY (`idtipotransaccion`),
  UNIQUE KEY `codtipotransaccion` (`codtipotransaccion`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tipostransacciones
-- ----------------------------
INSERT INTO `tipostransacciones` VALUES ('1', '1', 'Venta');
INSERT INTO `tipostransacciones` VALUES ('2', '2', 'Alquiler');
INSERT INTO `tipostransacciones` VALUES ('3', '3', 'Hipoteca');

-- ----------------------------
-- Table structure for transacciones
-- ----------------------------
DROP TABLE IF EXISTS `transacciones`;
CREATE TABLE `transacciones` (
  `idtransaccion` int(11) NOT NULL AUTO_INCREMENT,
  `codtipotransaccion` char(2) NOT NULL,
  `codasesor` char(5) NOT NULL,
  `codcliente` char(5) NOT NULL,
  `codvivienda` char(5) NOT NULL,
  `fecha` date NOT NULL,
  `serie` char(10) NOT NULL,
  `numdocumento` char(20) NOT NULL,
  `valor` decimal(10,2) DEFAULT '0.00',
  PRIMARY KEY (`idtransaccion`),
  KEY `asesor_fk` (`codasesor`),
  KEY `vivienda_fk` (`codvivienda`),
  KEY `cliente_fk` (`codcliente`),
  KEY `transac_fk` (`codtipotransaccion`),
  CONSTRAINT `asesor_fk` FOREIGN KEY (`codasesor`) REFERENCES `asesores` (`codasesor`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `cliente_fk` FOREIGN KEY (`codcliente`) REFERENCES `clientes` (`codcliente`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `transac_fk` FOREIGN KEY (`codtipotransaccion`) REFERENCES `tipostransacciones` (`codtipotransaccion`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `vivienda_fk` FOREIGN KEY (`codvivienda`) REFERENCES `viviendas` (`codvivienda`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of transacciones
-- ----------------------------
INSERT INTO `transacciones` VALUES ('1', '3', '1', '1', '1', '2019-06-07', '1', '1', '50000.00');
INSERT INTO `transacciones` VALUES ('2', '1', '1', '1', '1', '2015-01-01', '1', '2', '15000.00');

-- ----------------------------
-- Table structure for viviendas
-- ----------------------------
DROP TABLE IF EXISTS `viviendas`;
CREATE TABLE `viviendas` (
  `idvivienda` int(11) NOT NULL AUTO_INCREMENT,
  `codvivienda` char(5) NOT NULL,
  `codmodelo_vivienda` char(2) NOT NULL,
  `codestado_vivienda` char(2) NOT NULL,
  `precio` decimal(10,2) NOT NULL DEFAULT '0.00',
  PRIMARY KEY (`idvivienda`),
  UNIQUE KEY `codvivienda` (`codvivienda`) USING BTREE,
  KEY `modelo_vivienda_fk` (`codmodelo_vivienda`),
  KEY `estado_vivienda_fk` (`codestado_vivienda`),
  CONSTRAINT `estado_vivienda_fk` FOREIGN KEY (`codestado_vivienda`) REFERENCES `estados_viviendas` (`codestado_vivienda`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `modelo_vivienda_fk` FOREIGN KEY (`codmodelo_vivienda`) REFERENCES `modelos_viviendas` (`codmodelo_vivienda`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of viviendas
-- ----------------------------
INSERT INTO `viviendas` VALUES ('1', '1', '1', '2', '50000.00');
INSERT INTO `viviendas` VALUES ('2', '2', '2', '1', '77777.77');
