Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Imports System.IO
Imports IWshRuntimeLibrary

Public Class scrAlta_Empresa

    Private Sub tbNomEmp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNomEmp.KeyPress

        If Char.IsLower(e.KeyChar) Then
            tbNomEmp.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If

    End Sub

    Private Sub tbRFCEmp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbRFCEmp.KeyPress

        If Char.IsLower(e.KeyChar) Then
            tbRFCEmp.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If

    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click

        Dim conexion As New Class_insert
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader
        Dim datos As New Class_datos
        Dim banEm As Boolean = False
        Dim base As String

        base = tbNombreBaese.Text.Replace(" ", "_")

#Region "Condiciones"

        If tbNomEmp.Text = "" Then

            MessageBox.Show("Error, ingresa un nombre a la Nueva Empresa", "Contago Contabilidad 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbNomEmp.Focus()
            Return

        End If

        If tbRFCEmp.Text = "" Then

            MessageBox.Show("Error, ingresa un RFC a la Nueva Empresa", "Contago Contabilidad 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbRFCEmp.Focus()
            Return

        End If

        If cbRegFis.Text = "-Selecciona un Regimen-" Or cbRegFis.Text = "" Then

            MessageBox.Show("Error, selecciona un regimen para la Nueva Empresa", "Contago Contabilidad 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbRegFis.Focus()
            Return

        End If

#End Region

        For Each row As DataGridViewRow In scrConfiguracion.dgvEmpresas.Rows

            If tbNomEmp.Text = row.Cells(1).Value Then

                MessageBox.Show("Error, esta empresa ya existe", "Contago Contabilidad 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return

            End If

        Next

        If MessageBox.Show("¿Está seguro que la nueva empresa tenga el nombre de '" & tbNomEmp.Text & "' ? Esta acción no puede ser revertida", "Contago Contabilidad 2.1 2018", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then

#Region "Crea la base"


            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand("CREATE DATABASE  IF NOT EXISTS `" & base & "` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `" & base & "`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: pruebacontabilidad
-- ------------------------------------------------------
-- Server version	5.6.17

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `catalogo_contable`
--

DROP TABLE IF EXISTS `catalogo_contable`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `catalogo_contable` (
  `id_cuenta` int(11) NOT NULL AUTO_INCREMENT,
  `id_cuenta_padre` int(11) DEFAULT NULL,
  `numero_cuenta_unico` varchar(200) DEFAULT NULL,
  `numero_cuenta` varchar(200) DEFAULT NULL,
  `nombre_cuenta` varchar(200) DEFAULT NULL,
  `tipo` char(1) DEFAULT NULL,
  `naturaleza` char(1) DEFAULT NULL,
  `cuenta_sat` varchar(30) DEFAULT NULL,
  `usuario_creador` varchar(200) DEFAULT NULL,
  `fecha_creacion` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `usuario_mod` varchar(200) DEFAULT 'na',
  `fecha_mod` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id_cuenta`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `catalogo_contable`
--

LOCK TABLES `catalogo_contable` WRITE;
/*!40000 ALTER TABLE `catalogo_contable` DISABLE KEYS */;
/*!40000 ALTER TABLE `catalogo_contable` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `catalogo_cuentas_sat`
--

DROP TABLE IF EXISTS `catalogo_cuentas_sat`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `catalogo_cuentas_sat` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `cuenta_padre_sat` varchar(10) DEFAULT NULL,
  `numero_cuenta` varchar(200) DEFAULT NULL,
  `cuenta_padre` varchar(200) DEFAULT NULL,
  `cuenta_hijo` varchar(200) DEFAULT NULL,
  `naturaleza` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=926 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `catalogo_cuentas_sat`
--

LOCK TABLES `catalogo_cuentas_sat` WRITE;
/*!40000 ALTER TABLE `catalogo_cuentas_sat` DISABLE KEYS */;
INSERT INTO `catalogo_cuentas_sat` VALUES (1,'101','101.001','Caja','Caja y efectivo','D'),(2,'102','102.001','Bancos','Bancos nacionales','D'),(3,'102','102.002','Bancos','Bancos extranjeros','D'),(4,'103','103.001','Inversiones','Inversiones temporales','D'),(5,'103','103.002','Inversiones','Inversiones en fideicomisos','D'),(6,'103','103.003','Inversiones','Otras inversiones','D'),(7,'104','104.001','Otros instrumentos financieros','Otros instrumentos financieros','D'),(8,'105','105.001','Clientes','Clientes nacionales','D'),(9,'105','105.002','Clientes','Clientes extranjeros','D'),(10,'105','105.003','Clientes','Clientes nacionales parte relacionada','D'),(11,'105','105.004','Clientes','Clientes extranjeros parte relacionada','D'),(12,'106','106.001','Cuentas y documentos por cobrar a corto plazo','Cuentas y documentos por cobrar a corto plazo nacional','D'),(13,'106','106.002','Cuentas y documentos por cobrar a corto plazo','Cuentas y documentos por cobrar a corto plazo extranjero','D'),(14,'106','106.003','Cuentas y documentos por cobrar a corto plazo','Cuentas y documentos por cobrar a corto plazo nacional parte relacionada','D'),(15,'106','106.004','Cuentas y documentos por cobrar a corto plazo','Cuentas y documentos por cobrar a corto plazo extranjero parte relacionada','D'),(16,'106','106.005','Cuentas y documentos por cobrar a corto plazo','Intereses por cobrar a corto plazo nacional','D'),(17,'106','106.006','Cuentas y documentos por cobrar a corto plazo','Intereses por cobrar a corto plazo extranjero','D'),(18,'106','106.007','Cuentas y documentos por cobrar a corto plazo','Intereses por cobrar a corto plazo nacional parte relacionada','D'),(19,'106','106.008','Cuentas y documentos por cobrar a corto plazo','Intereses por cobrar a corto plazo extranjero parte relacionada','D'),(20,'106','106.009','Cuentas y documentos por cobrar a corto plazo','Otras cuentas y documentos por cobrar a corto plazo','D'),(21,'106','106.010','Cuentas y documentos por cobrar a corto plazo','Otras cuentas y documentos por cobrar a corto plazo parte relacionada','D'),(22,'107','107.001','Deudores diversos','Funcionarios y empleados','D'),(23,'107','107.002','Deudores diversos','Socios y accionistas','D'),(24,'107','107.003','Deudores diversos','Partes relacionadas nacionales','D'),(25,'107','107.004','Deudores diversos','Partes relacionadas extranjeros','D'),(26,'107','107.005','Deudores diversos','Otros deudores diversos','D'),(27,'108','108.001','Estimacion de cuentas incobrables','EstimaciÃ³n de cuentas incobrables nacional','D'),(28,'108','108.002','Estimacion de cuentas incobrables','EstimaciÃ³n de cuentas incobrables extranjero','D'),(29,'108','108.003','Estimacion de cuentas incobrables','EstimaciÃ³n de cuentas incobrables nacional parte relacionada','D'),(30,'108','108.004','Estimacion de cuentas incobrables','EstimaciÃ³n de cuentas incobrables extranjero parte relacionada','D'),(31,'109','109.001','Pagos anticipados','Seguros y fianzas pagados por anticipado nacional','D'),(32,'109','109.002','Pagos anticipados','Seguros y fianzas pagados por anticipado extranjero','D'),(33,'109','109.003','Pagos anticipados','Seguros y fianzas pagados por anticipado nacional parte relacionada','D'),(34,'109','109.004','Pagos anticipados','Seguros y fianzas pagados por anticipado extranjero parte relacionada','D'),(35,'109','109.005','Pagos anticipados','Rentas pagados por anticipado nacional','D'),(36,'109','109.006','Pagos anticipados','Rentas pagados por anticipado extranjero','D'),(37,'109','109.007','Pagos anticipados','Rentas pagados por anticipado nacional parte relacionada','D'),(38,'109','109.008','Pagos anticipados','Rentas pagados por anticipado extranjero parte relacionada','D'),(39,'109','109.009','Pagos anticipados','Intereses pagados por anticipado nacional','D'),(40,'109','109.010','Pagos anticipados','Intereses pagados por anticipado extranjero','D'),(41,'109','109.011','Pagos anticipados','Intereses pagados por anticipado nacional parte relacionada','D'),(42,'109','109.012','Pagos anticipados','Intereses pagados por anticipado extranjero parte relacionada','D'),(43,'109','109.013','Pagos anticipados','Factoraje financiero pagados por anticipado nacional','D'),(44,'109','109.014','Pagos anticipados','Factoraje financiero pagados por anticipado extranjero','D'),(45,'109','109.015','Pagos anticipados','Factoraje financiero pagados por anticipado nacional parte relacionada','D'),(46,'109','109.016','Pagos anticipados','Factoraje financiero pagados por anticipado extranjero parte relacionada','D'),(47,'109','109.017','Pagos anticipados','Arrendamiento financiero pagados por anticipado nacional','D'),(48,'109','109.018','Pagos anticipados','Arrendamiento financiero pagados por anticipado extranjero','D'),(49,'109','109.019','Pagos anticipados','Arrendamiento financiero pagados por anticipado nacional parte relacionada','D'),(50,'109','109.020','Pagos anticipados','Arrendamiento financiero pagados por anticipado extranjero parte relacionada','D'),(51,'109','109.021','Pagos anticipados','PÃ©rdida por deterioro de pagos anticipados','D'),(52,'109','109.022','Pagos anticipados','Derechos fiduciarios','D'),(53,'109','109.023','Pagos anticipados','Otros pagos anticipados','D'),(54,'110','110.001','Subsidio al empleo por aplicar','Subsidio al empleo por aplicar','D'),(55,'111','111.001','Credito al diesel por acreditar','CrÃ©dito al diesel por acreditar','D'),(56,'112','112.001','Otros estimulos','Otros estÃ­mulos','D'),(57,'113','113.001','Impuestos a favor','IVA a favor','D'),(58,'113','113.002','Impuestos a favor','ISR a favor','D'),(59,'113','113.003','Impuestos a favor','IETU a favor','D'),(60,'113','113.004','Impuestos a favor','IDE a favor','D'),(61,'113','113.005','Impuestos a favor','IA a favor','D'),(62,'113','113.006','Impuestos a favor','Subsidio al empleo','D'),(63,'113','113.007','Impuestos a favor','Pago de lo indebido','D'),(64,'113','113.008','Impuestos a favor','Otros impuestos a favor','D'),(65,'114','114.001','Pagos provisionales','Pagos provisionales de ISR','D'),(66,'115','115.001','Inventario','Inventario','D'),(67,'115','115.002','Inventario','Materia prima y materiales','D'),(68,'115','115.003','Inventario','ProducciÃ³n en proceso','D'),(69,'115','115.004','Inventario','Productos terminados','D'),(70,'115','115.005','Inventario','MercancÃ­as en trÃ¡nsito','D'),(71,'115','115.006','Inventario','MercancÃ­as en poder de terceros','D'),(72,'115','115.007','Inventario','Otros','D'),(73,'116','116.001','Estimacion de inventarios obsoletos y de lento movimiento','EstimaciÃ³n de inventarios obsoletos y de lento movimiento','D'),(74,'117','117.001','Obras en proceso de inmuebles','Obras en proceso de inmuebles','D'),(75,'118','118.001','Impuestos acreditables pagados','IVA acreditable pagado','D'),(76,'118','118.002','Impuestos acreditables pagados','IVA acreditable de importaciÃ³n pagado','D'),(77,'118','118.003','Impuestos acreditables pagados','IEPS acreditable pagado','D'),(78,'118','118.004','Impuestos acreditables pagados','IEPS pagado en importaciÃ³n','D'),(79,'119','119.001','Impuestos acreditables por pagar','IVA pendiente de pago','D'),(80,'119','119.002','Impuestos acreditables por pagar','IVA de importaciÃ³n pendiente de pago','D'),(81,'119','119.003','Impuestos acreditables por pagar','IEPS pendiente de pago','D'),(82,'119','119.004','Impuestos acreditables por pagar','IEPS pendiente de pago en importaciÃ³n','D'),(83,'120','120.001','Anticipo a proveedores','Anticipo a proveedores nacional','D'),(84,'120','120.002','Anticipo a proveedores','Anticipo a proveedores extranjero','D'),(85,'120','120.003','Anticipo a proveedores','Anticipo a proveedores nacional parte relacionada','D'),(86,'120','120.004','Anticipo a proveedores','Anticipo a proveedores extranjero parte relacionada','D'),(87,'121','121.001','Otros activos a corto plazo','Otros activos a corto plazo','D'),(88,'151','151.001','Terrenos','Terrenos','D'),(89,'152','152.001','Edificios','Edificios','D'),(90,'153','153.001','Maquinaria y equipo','Maquinaria y equipo','D'),(91,'154','154.001','Automoviles, autobuses, camiones de carga, tractocamiones, montacargas y remolques','AutomÃ³viles, autobuses, camiones de carga, tractocamiones, montacargas y remolques','D'),(92,'155','155.001','Mobiliario y equipo de oficina','Mobiliario y equipo de oficina','D'),(93,'156','156.001','Equipo de computo','Equipo de cÃ³mputo','D'),(94,'157','157.001','Equipo de comunicacion','Equipo de comunicaciÃ³n','D'),(95,'158','158.001','Activos biolÃ³gicos, vegetales y semovientes','Activos biolÃ³gicos, vegetales y semovientes','D'),(96,'159','159.001','Obras en proceso de activos fijos','Obras en proceso de activos fijos','D'),(97,'160','160.001','Otros activos fijos','Otros activos fijos','D'),(98,'161','161.001','Ferrocarriles','Ferrocarriles','D'),(99,'162','162.001','Embarcaciones','Embarcaciones','D'),(100,'163','163.001','Aviones','Aviones','D'),(101,'164','164.001','Troqueles, moldes, matrices y herramental','Troqueles, moldes, matrices y herramental','D'),(102,'165','165.001','Equipo de comunicaciones telefÃ³nicas','Equipo de comunicaciones telefÃ³nicas','D'),(103,'166','166.001','Equipo de comunicaciÃ³n satelital','Equipo de comunicaciÃ³n satelital','D'),(104,'167','167.001','Equipo de adaptaciones para personas con capacidades diferentes','Equipo de adaptaciones para personas con capacidades diferentes','D'),(105,'168','168.001','Maquinaria y equipo de generaciÃ³n de energÃ­a de fuentes renovables o de sistemas de cogeneraciÃ³n de electricidad eficiente','Maquinaria y equipo de generaciÃ³n de energÃ­a de fuentes renovables o de sistemas de cogeneraciÃ³n de electricidad eficiente','D'),(106,'169','169.001','Otra maquinaria y equipo','Otra maquinaria y equipo','D'),(107,'170','170.001','Adaptaciones y mejoras','Adaptaciones y mejoras','A'),(108,'171','171.001','DepreciaciÃ³n acumulada de activos fijos','DepreciaciÃ³n acumulada de edificios','A'),(109,'171','171.002','DepreciaciÃ³n acumulada de activos fijos','DepreciaciÃ³n acumulada de maquinaria y equipo','A'),(110,'171','171.003','DepreciaciÃ³n acumulada de activos fijos','DepreciaciÃ³n acumulada de automÃ³viles, autobuses, camiones de carga, tractocamiones, montacargas y remolques','A'),(111,'171','171.004','DepreciaciÃ³n acumulada de activos fijos','DepreciaciÃ³n acumulada de mobiliario y equipo de oficina','A'),(112,'171','171.005','DepreciaciÃ³n acumulada de activos fijos','DepreciaciÃ³n acumulada de equipo de cÃ³mputo','A'),(113,'171','171.006','DepreciaciÃ³n acumulada de activos fijos','DepreciaciÃ³n acumulada de equipo de comunicaciÃ³n','A'),(114,'171','171.007','DepreciaciÃ³n acumulada de activos fijos','DepreciaciÃ³n acumulada de activos biolÃ³gicos, vegetales y semovientes','A'),(115,'171','171.008','DepreciaciÃ³n acumulada de activos fijos','DepreciaciÃ³n acumulada de otros activos fijos','A'),(116,'171','171.009','DepreciaciÃ³n acumulada de activos fijos','DepreciaciÃ³n acumulada de ferrocarriles','A'),(117,'171','171.010','DepreciaciÃ³n acumulada de activos fijos','DepreciaciÃ³n acumulada de embarcaciones','A'),(118,'171','171.011','DepreciaciÃ³n acumulada de activos fijos','DepreciaciÃ³n acumulada de aviones','A'),(119,'171','171.012','DepreciaciÃ³n acumulada de activos fijos','DepreciaciÃ³n acumulada de troqueles, moldes, matrices y herramental','A'),(120,'171','171.013','DepreciaciÃ³n acumulada de activos fijos','DepreciaciÃ³n acumulada de equipo de comunicaciones telefÃ³nicas','A'),(121,'171','171.014','DepreciaciÃ³n acumulada de activos fijos','DepreciaciÃ³n acumulada de equipo de comunicaciÃ³n satelital','A'),(122,'171','171.015','DepreciaciÃ³n acumulada de activos fijos','DepreciaciÃ³n acumulada de equipo de adaptaciones para personas con capacidades diferentes','A'),(123,'171','171.016','DepreciaciÃ³n acumulada de activos fijos','DepreciaciÃ³n acumulada de maquinaria y equipo de generaciÃ³n de energÃ­a de fuentes renovables o de sistemas de cogeneraciÃ³n de electricidad eficiente','A'),(124,'171','171.017','DepreciaciÃ³n acumulada de activos fijos','DepreciaciÃ³n acumulada de adaptaciones y mejoras','A'),(125,'171','171.018','DepreciaciÃ³n acumulada de activos fijos','DepreciaciÃ³n acumulada de otra maquinaria y equipo','A'),(126,'172','172.001','PÃ©rdida por deterioro acumulado de activos fijos','PÃ©rdida por deterioro acumulado de edificios','A'),(127,'172','172.002','PÃ©rdida por deterioro acumulado de activos fijos','PÃ©rdida por deterioro acumulado de maquinaria y equipo','A'),(128,'172','172.003','PÃ©rdida por deterioro acumulado de activos fijos','PÃ©rdida por deterioro acumulado de automÃ³viles, autobuses, camiones de carga, tractocamiones, montacargas y remolques','A'),(129,'172','172.004','PÃ©rdida por deterioro acumulado de activos fijos','PÃ©rdida por deterioro acumulado de mobiliario y equipo de oficina','A'),(130,'172','172.005','PÃ©rdida por deterioro acumulado de activos fijos','PÃ©rdida por deterioro acumulado de equipo de cÃ³mputo','A'),(131,'172','172.006','PÃ©rdida por deterioro acumulado de activos fijos','PÃ©rdida por deterioro acumulado de equipo de comunicaciÃ³n','A'),(132,'172','172.007','PÃ©rdida por deterioro acumulado de activos fijos','PÃ©rdida por deterioro acumulado de activos biolÃ³gicos, vegetales y semovientes','A'),(133,'172','172.008','PÃ©rdida por deterioro acumulado de activos fijos','PÃ©rdida por deterioro acumulado de otros activos fijos','A'),(134,'172','172.009','PÃ©rdida por deterioro acumulado de activos fijos','PÃ©rdida por deterioro acumulado de ferrocarriles','A'),(135,'172','172.010','PÃ©rdida por deterioro acumulado de activos fijos','PÃ©rdida por deterioro acumulado de embarcaciones','A'),(136,'172','172.011','PÃ©rdida por deterioro acumulado de activos fijos','PÃ©rdida por deterioro acumulado de aviones','A'),(137,'172','172.012','PÃ©rdida por deterioro acumulado de activos fijos','PÃ©rdida por deterioro acumulado de troqueles, moldes, matrices y herramental','A'),(138,'172','172.013','PÃ©rdida por deterioro acumulado de activos fijos','PÃ©rdida por deterioro acumulado de equipo de comunicaciones telefÃ³nicas','A'),(139,'172','172.014','PÃ©rdida por deterioro acumulado de activos fijos','PÃ©rdida por deterioro acumulado de equipo de comunicaciÃ³n satelital','A'),(140,'172','172.015','PÃ©rdida por deterioro acumulado de activos fijos','PÃ©rdida por deterioro acumulado de equipo de adaptaciones para personas con capacidades diferentes','A'),(141,'172','172.016','PÃ©rdida por deterioro acumulado de activos fijos','PÃ©rdida por deterioro acumulado de maquinaria y equipo de generaciÃ³n de energÃ­a de fuentes renovables o de sistemas de cogeneraciÃ³n de electricidad eficiente','A'),(142,'172','172.017','PÃ©rdida por deterioro acumulado de activos fijos','PÃ©rdida por deterioro acumulado de adaptaciones y mejoras','A'),(143,'172','172.018','PÃ©rdida por deterioro acumulado de activos fijos','PÃ©rdida por deterioro acumulado de otra maquinaria y equipo','A'),(144,'173','173.001','Gastos diferidos','Gastos diferidos','D'),(145,'174','174.001','Gastos pre operativos','Gastos pre operativos','D'),(146,'175','175.001','RegalÃ­as, asistencia tÃ©cnica y otros gastos diferidos','RegalÃ­as, asistencia tÃ©cnica y otros gastos diferidos','D'),(147,'176','176.001','Activos intangibles','Activos intangibles','D'),(148,'177','177.001','Gastos de organizaciÃ³n','Gastos de organizaciÃ³n','D'),(149,'178','178.001','InvestigaciÃ³n y desarrollo de mercado','InvestigaciÃ³n y desarrollo de mercado','D'),(150,'179','179.001','Marcas y patentes','Marcas y patentes','D'),(151,'180','180.001','CrÃ©dito mercantil','CrÃ©dito mercantil','D'),(152,'181','181.001','Gastos de instalaciÃ³n','Gastos de instalaciÃ³n','D'),(153,'182','182.001','Otros activos diferidos','Otros activos diferidos','D'),(154,'183','183.001','AmortizaciÃ³n acumulada de activos diferidos','AmortizaciÃ³n acumulada de gastos diferidos','D'),(155,'183','183.002','AmortizaciÃ³n acumulada de activos diferidos','AmortizaciÃ³n acumulada de gastos pre operativos','D'),(156,'183','183.003','AmortizaciÃ³n acumulada de activos diferidos','AmortizaciÃ³n acumulada de regalÃ­as, asistencia tÃ©cnica y otros gastos diferidos','D'),(157,'183','183.004','AmortizaciÃ³n acumulada de activos diferidos','AmortizaciÃ³n acumulada de activos intangibles','D'),(158,'183','183.005','AmortizaciÃ³n acumulada de activos diferidos','AmortizaciÃ³n acumulada de gastos de organizaciÃ³n','D'),(159,'183','183.006','AmortizaciÃ³n acumulada de activos diferidos','AmortizaciÃ³n acumulada de investigaciÃ³n y desarrollo de mercado','D'),(160,'183','183.007','AmortizaciÃ³n acumulada de activos diferidos','AmortizaciÃ³n acumulada de marcas y patentes','D'),(161,'183','183.008','AmortizaciÃ³n acumulada de activos diferidos','AmortizaciÃ³n acumulada de crÃ©dito mercantil','D'),(162,'183','183.009','AmortizaciÃ³n acumulada de activos diferidos','AmortizaciÃ³n acumulada de gastos de instalaciÃ³n','D'),(163,'183','183.001','AmortizaciÃ³n acumulada de activos diferidos','AmortizaciÃ³n acumulada de otros activos diferidos','D'),(164,'184','184.001','DepÃ³sitos en garantÃ­a','DepÃ³sitos de fianzas','D'),(165,'184','184.002','DepÃ³sitos en garantÃ­a','DepÃ³sitos de arrendamiento de bienes inmuebles','D'),(166,'184','184.003','DepÃ³sitos en garantÃ­a','Otros depÃ³sitos en garantÃ­a','D'),(167,'185','185.001','Impuestos diferidos','Impuestos diferidos ISR','D'),(168,'186','186.001','Cuentas y documentos por cobrar a largo plazo','Cuentas y documentos por cobrar a largo plazo nacional','D'),(169,'186','186.002','Cuentas y documentos por cobrar a largo plazo','Cuentas y documentos por cobrar a largo plazo extranjero','D'),(170,'186','186.003','Cuentas y documentos por cobrar a largo plazo','Cuentas y documentos por cobrar a largo plazo nacional parte relacionada','D'),(171,'186','186.004','Cuentas y documentos por cobrar a largo plazo','Cuentas y documentos por cobrar a largo plazo extranjero parte relacionada','D'),(172,'186','186.005','Cuentas y documentos por cobrar a largo plazo','Intereses por cobrar a largo plazo nacional','D'),(173,'186','186.006','Cuentas y documentos por cobrar a largo plazo','Intereses por cobrar a largo plazo extranjero','D'),(174,'186','186.007','Cuentas y documentos por cobrar a largo plazo','Intereses por cobrar a largo plazo nacional parte relacionada','D'),(175,'186','186.008','Cuentas y documentos por cobrar a largo plazo','Intereses por cobrar a largo plazo extranjero parte relacionada','D'),(176,'186','186.009','Cuentas y documentos por cobrar a largo plazo','Otras cuentas y documentos por cobrar a largo plazo','D'),(177,'186','186.010','Cuentas y documentos por cobrar a largo plazo','Otras cuentas y documentos por cobrar a largo plazo parte relacionada','D'),(178,'187','187.001','ParticipaciÃ³n de los trabajadores en las utilidades diferidas','ParticipaciÃ³n de los trabajadores en las utilidades diferidas','D'),(179,'188','188.001','Inversiones permanentes en acciones','Inversiones a largo plazo en subsidiarias','D'),(180,'188','188.002','Inversiones permanentes en acciones','Inversiones a largo plazo en asociadas','D'),(181,'188','188.003','Inversiones permanentes en acciones','Otras inversiones permanentes en acciones','D'),(182,'189','189.001','EstimaciÃ³n por deterioro de inversiones permanentes en acciones','EstimaciÃ³n por deterioro de inversiones permanentes en acciones','D'),(183,'190','190.001','Otros instrumentos financieros','Otros instrumentos financieros','D'),(184,'191','191.001','Otros activos a largo plazo','Otros activos a largo plazo','D'),(185,'200','200.001','Pasivo','Pasivo a corto plazo','A'),(186,'201','201.001','Proveedores','Proveedores nacionales','A'),(187,'201','201.002','Proveedores','Proveedores extranjeros','A'),(188,'201','201.003','Proveedores','Proveedores nacionales parte relacionada','A'),(189,'201','201.004','Proveedores','Proveedores extranjeros parte relacionada','A'),(190,'202','202.001','Cuentas por pagar a corto plazo','Documentos por pagar bancario y financiero nacional','A'),(191,'202','202.002','Cuentas por pagar a corto plazo','Documentos por pagar bancario y financiero extranjero','A'),(192,'202','202.003','Cuentas por pagar a corto plazo','Documentos y cuentas por pagar a corto plazo nacional','A'),(193,'202','202.004','Cuentas por pagar a corto plazo','Documentos y cuentas por pagar a corto plazo extranjero','A'),(194,'202','202.005','Cuentas por pagar a corto plazo','Documentos y cuentas por pagar a corto plazo nacional parte relacionada','A'),(195,'202','202.006','Cuentas por pagar a corto plazo','Documentos y cuentas por pagar a corto plazo extranjero parte relacionada','A'),(196,'202','202.007','Cuentas por pagar a corto plazo','Intereses por pagar a corto plazo nacional','A'),(197,'202','202.008','Cuentas por pagar a corto plazo','Intereses por pagar a corto plazo extranjero','A'),(198,'202','202.009','Cuentas por pagar a corto plazo','Intereses por pagar a corto plazo nacional parte relacionada','A'),(199,'202','202.001','Cuentas por pagar a corto plazo','Intereses por pagar a corto plazo extranjero parte relacionada','A'),(200,'202','202.011','Cuentas por pagar a corto plazo','Dividendo por pagar nacional','A'),(201,'202','202.012','Cuentas por pagar a corto plazo','Dividendo por pagar extranjero','A'),(202,'203','203.001','Cobros anticipados a corto plazo','Rentas cobradas por anticipado a corto plazo nacional','A'),(203,'203','203.002','Cobros anticipados a corto plazo','Rentas cobradas por anticipado a corto plazo extranjero','A'),(204,'203','203.003','Cobros anticipados a corto plazo','Rentas cobradas por anticipado a corto plazo nacional parte relacionada','A'),(205,'203','203.004','Cobros anticipados a corto plazo','Rentas cobradas por anticipado a corto plazo extranjero parte relacionada','A'),(206,'203','203.005','Cobros anticipados a corto plazo','Intereses cobrados por anticipado a corto plazo nacional','A'),(207,'203','203.006','Cobros anticipados a corto plazo','Intereses cobrados por anticipado a corto plazo extranjero','A'),(208,'203','203.007','Cobros anticipados a corto plazo','Intereses cobrados por anticipado a corto plazo nacional parte relacionada','A'),(209,'203','203.008','Cobros anticipados a corto plazo','Intereses cobrados por anticipado a corto plazo extranjero parte relacionada','A'),(210,'203','203.009','Cobros anticipados a corto plazo','Factoraje financiero cobrados por anticipado a corto plazo nacional','A'),(211,'203','203.001','Cobros anticipados a corto plazo','Factoraje financiero cobrados por anticipado a corto plazo extranjero','A'),(212,'203','203.011','Cobros anticipados a corto plazo','Factoraje financiero cobrados por anticipado a corto plazo nacional parte relacionada','A'),(213,'203','203.012','Cobros anticipados a corto plazo','Factoraje financiero cobrados por anticipado a corto plazo extranjero parte relacionada','A'),(214,'203','203.013','Cobros anticipados a corto plazo','Arrendamiento financiero cobrados por anticipado a corto plazo nacional','A'),(215,'203','203.014','Cobros anticipados a corto plazo','Arrendamiento financiero cobrados por anticipado a corto plazo extranjero','A'),(216,'203','203.015','Cobros anticipados a corto plazo','Arrendamiento financiero cobrados por anticipado a corto plazo nacional parte relacionada','A'),(217,'203','203.016','Cobros anticipados a corto plazo','Arrendamiento financiero cobrados por anticipado a corto plazo extranjero parte relacionada','A'),(218,'203','203.017','Cobros anticipados a corto plazo','Derechos fiduciarios','A'),(219,'203','203.018','Cobros anticipados a corto plazo','Otros cobros anticipados','A'),(220,'204','204.001','Instrumentos financieros a corto plazo','Instrumentos financieros a corto plazo','A'),(221,'205','205.001','Acreedores diversos a corto plazo','Socios, accionistas o representante legal','A'),(222,'205','205.002','Acreedores diversos a corto plazo','Acreedores diversos a corto plazo nacional','A'),(223,'205','205.003','Acreedores diversos a corto plazo','Acreedores diversos a corto plazo extranjero','A'),(224,'205','205.004','Acreedores diversos a corto plazo','Acreedores diversos a corto plazo nacional parte relacionada','A'),(225,'205','205.005','Acreedores diversos a corto plazo','Acreedores diversos a corto plazo extranjero parte relacionada','A'),(226,'205','205.006','Acreedores diversos a corto plazo','Otros acreedores diversos a corto plazo','A'),(227,'206','206.001','Anticipo de cliente','Anticipo de cliente nacional','A'),(228,'206','206.002','Anticipo de cliente','Anticipo de cliente extranjero','A'),(229,'206','206.003','Anticipo de cliente','Anticipo de cliente nacional parte relacionada','A'),(230,'206','206.004','Anticipo de cliente','Anticipo de cliente extranjero parte relacionada','A'),(231,'206','206.005','Anticipo de cliente','Otros anticipos de clientes','A'),(232,'207','207.001','Impuestos trasladados','IVA trasladado','A'),(233,'207','207.002','Impuestos trasladados','IEPS trasladado','A'),(234,'208','208.001','Impuestos trasladados cobrados','IVA trasladado cobrado','A'),(235,'208','208.002','Impuestos trasladados cobrados','IEPS trasladado cobrado','A'),(236,'209','209.001','Impuestos trasladados no cobrados','IVA trasladado no cobrado','A'),(237,'209','209.002','Impuestos trasladados no cobrados','IEPS trasladado no cobrado','A'),(238,'210','210.001','ProvisiÃ³n de sueldos y salarios por pagar','ProvisiÃ³n de sueldos y salarios por pagar','A'),(239,'210','210.002','ProvisiÃ³n de sueldos y salarios por pagar','ProvisiÃ³n de vacaciones por pagar','A'),(240,'210','210.003','ProvisiÃ³n de sueldos y salarios por pagar','ProvisiÃ³n de aguinaldo por pagar','A'),(241,'210','210.004','ProvisiÃ³n de sueldos y salarios por pagar','ProvisiÃ³n de fondo de ahorro por pagar','A'),(242,'210','210.005','ProvisiÃ³n de sueldos y salarios por pagar','ProvisiÃ³n de asimilados a salarios por pagar','A'),(243,'210','210.006','ProvisiÃ³n de sueldos y salarios por pagar','ProvisiÃ³n de anticipos o remanentes por distribuir','A'),(244,'210','210.007','ProvisiÃ³n de sueldos y salarios por pagar','ProvisiÃ³n de otros sueldos y salarios por pagar','A'),(245,'211','211.001','ProvisiÃ³n de contribuciones de seguridad social por pagar','ProvisiÃ³n de IMSS patronal por pagar','A'),(246,'211','211.002','ProvisiÃ³n de contribuciones de seguridad social por pagar','ProvisiÃ³n de SAR por pagar','A'),(247,'211','211.003','ProvisiÃ³n de contribuciones de seguridad social por pagar','ProvisiÃ³n de infonavit por pagar','A'),(248,'212','212.001','ProvisiÃ³n de impuesto estatal sobre nÃ³mina por pagar','ProvisiÃ³n de impuesto estatal sobre nÃ³mina por pagar','A'),(249,'213','213.001','Impuestos y derechos por pagar','IVA por pagar','A'),(250,'213','213.002','Impuestos y derechos por pagar','IEPS por pagar','A'),(251,'213','213.003','Impuestos y derechos por pagar','ISR por pagar','A'),(252,'213','213.004','Impuestos y derechos por pagar','Impuesto estatal sobre nÃ³mina por pagar','A'),(253,'213','213.005','Impuestos y derechos por pagar','Impuesto estatal y municipal por pagar','A'),(254,'213','213.006','Impuestos y derechos por pagar','Derechos por pagar','A'),(255,'213','213.007','Impuestos y derechos por pagar','Otros impuestos por pagar','A'),(256,'214','214.001','Dividendos por pagar','Dividendos por pagar','A'),(257,'215','215.001','PTU por pagar','PTU por pagar','A'),(258,'215','215.002','PTU por pagar','PTU por pagar de ejercicios anteriores','A'),(259,'215','215.003','PTU por pagar','ProvisiÃ³n de PTU por pagar','A'),(260,'216','216.001','Impuestos retenidos','Impuestos retenidos de ISR por sueldos y salarios','A'),(261,'216','216.002','Impuestos retenidos','Impuestos retenidos de ISR por asimilados a salarios','A'),(262,'216','216.003','Impuestos retenidos','Impuestos retenidos de ISR por arrendamiento','A'),(263,'216','216.004','Impuestos retenidos','Impuestos retenidos de ISR por servicios profesionales','A'),(264,'216','216.005','Impuestos retenidos','Impuestos retenidos de ISR por dividendos','A'),(265,'216','216.006','Impuestos retenidos','Impuestos retenidos de ISR por intereses','A'),(266,'216','216.007','Impuestos retenidos','Impuestos retenidos de ISR por pagos al extranjero','A'),(267,'216','216.008','Impuestos retenidos','Impuestos retenidos de ISR por venta de acciones','A'),(268,'216','216.009','Impuestos retenidos','Impuestos retenidos de ISR por venta de partes sociales','A'),(269,'216','216.010','Impuestos retenidos','Impuestos retenidos de IVA','A'),(270,'216','216.011','Impuestos retenidos','Retenciones de IMSS a los trabajadores','A'),(271,'216','216.012','Impuestos retenidos','Otras impuestos retenidos','A'),(272,'217','217.001','Pagos realizados por cuenta de terceros','Pagos realizados por cuenta de terceros','A'),(273,'218','218.001','Otros pasivos a corto plazo','Otros pasivos a corto plazo','A'),(274,'251','251.001','Acreedores diversos a largo plazo','Socios, accionistas o representante legal','A'),(275,'251','251.002','Acreedores diversos a largo plazo','Acreedores diversos a largo plazo nacional','A'),(276,'251','251.003','Acreedores diversos a largo plazo','Acreedores diversos a largo plazo extranjero','A'),(277,'251','251.004','Acreedores diversos a largo plazo','Acreedores diversos a largo plazo nacional parte relacionada','A'),(278,'251','251.005','Acreedores diversos a largo plazo','Acreedores diversos a largo plazo extranjero parte relacionada','A'),(279,'251','251.006','Acreedores diversos a largo plazo','Otros acreedores diversos a largo plazo','A'),(280,'252','252.001','Cuentas por pagar a largo plazo','Documentos bancarios y financieros por pagar a largo plazo nacional','A'),(281,'252','252.002','Cuentas por pagar a largo plazo','Documentos bancarios y financieros por pagar a largo plazo extranjero','A'),(282,'252','252.003','Cuentas por pagar a largo plazo','Documentos y cuentas por pagar a largo plazo nacional','A'),(283,'252','252.004','Cuentas por pagar a largo plazo','Documentos y cuentas por pagar a largo plazo extranjero','A'),(284,'252','252.005','Cuentas por pagar a largo plazo','Documentos y cuentas por pagar a largo plazo nacional parte relacionada','A'),(285,'252','252.006','Cuentas por pagar a largo plazo','Documentos y cuentas por pagar a largo plazo extranjero parte relacionada','A'),(286,'252','252.007','Cuentas por pagar a largo plazo','Hipotecas por pagar a largo plazo nacional','A'),(287,'252','252.008','Cuentas por pagar a largo plazo','Hipotecas por pagar a largo plazo extranjero','A'),(288,'252','252.009','Cuentas por pagar a largo plazo','Hipotecas por pagar a largo plazo nacional parte relacionada','A'),(289,'252','252.001','Cuentas por pagar a largo plazo','Hipotecas por pagar a largo plazo extranjero parte relacionada','A'),(290,'252','252.011','Cuentas por pagar a largo plazo','Intereses por pagar a largo plazo nacional','A'),(291,'252','252.012','Cuentas por pagar a largo plazo','Intereses por pagar a largo plazo extranjero','A'),(292,'252','252.013','Cuentas por pagar a largo plazo','Intereses por pagar a largo plazo nacional parte relacionada','A'),(293,'252','252.014','Cuentas por pagar a largo plazo','Intereses por pagar a largo plazo extranjero parte relacionada','A'),(294,'252','252.015','Cuentas por pagar a largo plazo','Dividendos por pagar nacionales','A'),(295,'252','252.016','Cuentas por pagar a largo plazo','Dividendos por pagar extranjeros','A'),(296,'252','252.017','Cuentas por pagar a largo plazo','Otras cuentas y documentos por pagar a largo plazo','A'),(297,'253','253.001','Cobros anticipados a largo plazo','Rentas cobradas por anticipado a largo plazo nacional','A'),(298,'253','253.002','Cobros anticipados a largo plazo','Rentas cobradas por anticipado a largo plazo extranjero','A'),(299,'253','253.003','Cobros anticipados a largo plazo','Rentas cobradas por anticipado a largo plazo nacional parte relacionada','A'),(300,'253','253.004','Cobros anticipados a largo plazo','Rentas cobradas por anticipado a largo plazo extranjero parte relacionada','A'),(301,'253','253.005','Cobros anticipados a largo plazo','Intereses cobrados por anticipado a largo plazo nacional','A'),(302,'253','253.006','Cobros anticipados a largo plazo','Intereses cobrados por anticipado a largo plazo extranjero','A'),(303,'253','253.007','Cobros anticipados a largo plazo','Intereses cobrados por anticipado a largo plazo nacional parte relacionada','A'),(304,'253','253.008','Cobros anticipados a largo plazo','Intereses cobrados por anticipado a largo plazo extranjero parte relacionada','A'),(305,'253','253.009','Cobros anticipados a largo plazo','Factoraje financiero cobrados por anticipado a largo plazo nacional','A'),(306,'253','253.001','Cobros anticipados a largo plazo','Factoraje financiero cobrados por anticipado a largo plazo extranjero','A'),(307,'253','253.011','Cobros anticipados a largo plazo','Factoraje financiero cobrados por anticipado a largo plazo nacional parte relacionada','A'),(308,'253','253.012','Cobros anticipados a largo plazo','Factoraje financiero cobrados por anticipado a largo plazo extranjero parte relacionada','A'),(309,'253','253.013','Cobros anticipados a largo plazo','Arrendamiento financiero cobrados por anticipado a largo plazo nacional','A'),(310,'253','253.014','Cobros anticipados a largo plazo','Arrendamiento financiero cobrados por anticipado a largo plazo extranjero','A'),(311,'253','253.015','Cobros anticipados a largo plazo','Arrendamiento financiero cobrados por anticipado a largo plazo nacional parte relacionada','A'),(312,'253','253.016','Cobros anticipados a largo plazo','Arrendamiento financiero cobrados por anticipado a largo plazo extranjero parte relacionada','A'),(313,'253','253.017','Cobros anticipados a largo plazo','Derechos fiduciarios','A'),(314,'253','253.018','Cobros anticipados a largo plazo','Otros cobros anticipados','A'),(315,'254','254.001','Instrumentos financieros a largo plazo','Instrumentos financieros a largo plazo','A'),(316,'255','255.001','Pasivos por beneficios a los empleados a largo plazo','Pasivos por beneficios a los empleados a largo plazo','A'),(317,'256','256.001','Otros pasivos a largo plazo','Otros pasivos a largo plazo','A'),(318,'257','257.001','ParticipaciÃ³n de los trabajadores en las utilidades diferida','ParticipaciÃ³n de los trabajadores en las utilidades diferida','A'),(319,'258','258.001','Obligaciones contraÃ­das de fideicomisos','Obligaciones contraÃ­das de fideicomisos','A'),(320,'259','259.001','Impuestos diferidos','ISR diferido','A'),(321,'259','259.002','Impuestos diferidos','ISR por dividendo diferido','A'),(322,'259','259.003','Impuestos diferidos','Otros impuestos diferidos','A'),(323,'260','260.001','Pasivos diferidos','Pasivos diferidos','A'),(324,'301','301.001','Capital social','Capital fijo','A'),(325,'301','301.002','Capital social','Capital variable','A'),(326,'301','301.003','Capital social','Aportaciones para futuros aumentos de capital','A'),(327,'301','301.004','Capital social','Prima en suscripciÃ³n de acciones','A'),(328,'301','301.005','Capital social','Prima en suscripciÃ³n de partes sociales','A'),(329,'302','302.001','Patrimonio','Patrimonio','A'),(330,'302','302.002','Patrimonio','AportaciÃ³n patrimonial','A'),(331,'302','302.003','Patrimonio','DÃ©ficit o remanente del ejercicio','A'),(332,'303','303.001','Reserva legal','Reserva legal','A'),(333,'304','304.001','Resultado de ejercicios anteriores','Utilidad de ejercicios anteriores','A'),(334,'304','304.002','Resultado de ejercicios anteriores','PÃ©rdida de ejercicios anteriores','D'),(335,'304','304.003','Resultado de ejercicios anteriores','Resultado integral de ejercicios anteriores','A'),(336,'304','304.004','Resultado de ejercicios anteriores','DÃ©ficit o remanente de ejercicio anteriores','D'),(337,'305','305.001','Resultado del ejercicio','Utilidad del ejercicio','A'),(338,'305','305.002','Resultado del ejercicio','PÃ©rdida del ejercicio','D'),(339,'305','305.003','Resultado del ejercicio','Resultado integral','A'),(340,'306','306.001','Otras cuentas de capital','Otras cuentas de capital','A'),(341,'401','401.001','Ingresos','Ventas y/o servicios gravados a la tasa general','A'),(342,'401','401.002','Ingresos','Ventas y/o servicios gravados a la tasa general de contado','A'),(343,'401','401.003','Ingresos','Ventas y/o servicios gravados a la tasa general a crÃ©dito','A'),(344,'401','401.004','Ingresos','Ventas y/o servicios gravados al 0%','A'),(345,'401','401.005','Ingresos','Ventas y/o servicios gravados al 0% de contado','A'),(346,'401','401.006','Ingresos','Ventas y/o servicios gravados al 0% a crÃ©dito','A'),(347,'401','401.007','Ingresos','Ventas y/o servicios exentos','A'),(348,'401','401.008','Ingresos','Ventas y/o servicios exentos de contado','A'),(349,'401','401.009','Ingresos','Ventas y/o servicios exentos a crÃ©dito','A'),(350,'401','401.001','Ingresos','Ventas y/o servicios gravados a la tasa general nacionales partes relacionadas','A'),(351,'401','401.011','Ingresos','Ventas y/o servicios gravados a la tasa general extranjeros partes relacionadas','A'),(352,'401','401.012','Ingresos','Ventas y/o servicios gravados al 0% nacionales partes relacionadas','A'),(353,'401','401.013','Ingresos','Ventas y/o servicios gravados al 0% extranjeros partes relacionadas','A'),(354,'401','401.014','Ingresos','Ventas y/o servicios exentos nacionales partes relacionadas','A'),(355,'401','401.015','Ingresos','Ventas y/o servicios exentos extranjeros partes relacionadas','A'),(356,'401','401.016','Ingresos','Ingresos por servicios administrativos','A'),(357,'401','401.017','Ingresos','Ingresos por servicios administrativos nacionales partes relacionadas','A'),(358,'401','401.018','Ingresos','Ingresos por servicios administrativos extranjeros partes relacionadas','A'),(359,'401','401.019','Ingresos','Ingresos por servicios profesionales','A'),(360,'401','401.020','Ingresos','Ingresos por servicios profesionales nacionales partes relacionadas','A'),(361,'401','401.021','Ingresos','Ingresos por servicios profesionales extranjeros partes relacionadas','A'),(362,'401','401.022','Ingresos','Ingresos por arrendamiento','A'),(363,'401','401.023','Ingresos','Ingresos por arrendamiento nacionales partes relacionadas','A'),(364,'401','401.024','Ingresos','Ingresos por arrendamiento extranjeros partes relacionadas','A'),(365,'401','401.025','Ingresos','Ingresos por exportaciÃ³n','A'),(366,'401','401.026','Ingresos','Ingresos por comisiones','A'),(367,'401','401.027','Ingresos','Ingresos por maquila','A'),(368,'401','401.028','Ingresos','Ingresos por coordinados','A'),(369,'401','401.029','Ingresos','Ingresos por regalÃ­as','A'),(370,'401','401.030','Ingresos','Ingresos por asistencia tÃ©cnica','A'),(371,'401','401.031','Ingresos','Ingresos por donativos','A'),(372,'401','401.032','Ingresos','Ingresos por intereses (actividad propia)','A'),(373,'401','401.033','Ingresos','Ingresos de copropiedad','A'),(374,'401','401.034','Ingresos','Ingresos por fideicomisos','A'),(375,'401','401.035','Ingresos','Ingresos por factoraje financiero','A'),(376,'401','401.036','Ingresos','Ingresos por arrendamiento financiero','A'),(377,'401','401.037','Ingresos','Ingresos de extranjeros con establecimiento en el paÃ­s','A'),(378,'401','401.038','Ingresos','Otros ingresos propios','A'),(379,'402','402.001','Devoluciones, descuentos o bonificaciones sobre ingresos','Devoluciones, descuentos o bonificaciones sobre ventas y/o servicios a la tasa general','A'),(380,'402','402.002','Devoluciones, descuentos o bonificaciones sobre ingresos','Devoluciones, descuentos o bonificaciones sobre ventas y/o servicios al 0%','A'),(381,'402','402.003','Devoluciones, descuentos o bonificaciones sobre ingresos','Devoluciones, descuentos o bonificaciones sobre ventas y/o servicios exentos','A'),(382,'402','402.004','Devoluciones, descuentos o bonificaciones sobre ingresos','Devoluciones, descuentos o bonificaciones de otros ingresos','A'),(383,'403','403.001','Otros ingresos','Otros Ingresos','A'),(384,'403','403.002','Otros ingresos','Otros ingresos nacionales parte relacionada','A'),(385,'403','403.003','Otros ingresos','Otros ingresos extranjeros parte relacionada','A'),(386,'403','403.004','Otros ingresos','Ingresos por operaciones discontinuas','A'),(387,'403','403.005','Otros ingresos','Ingresos por condonaciÃ³n de adeudo','A'),(388,'501','501.001','Costo de venta y/o servicio','Costo de venta','D'),(389,'501','501.002','Costo de venta y/o servicio','Costo de servicios (Mano de obra)','D'),(390,'501','501.003','Costo de venta y/o servicio','Materia prima directa utilizada para la producciÃ³n','D'),(391,'501','501.004','Costo de venta y/o servicio','Materia prima consumida en el proceso productivo','D'),(392,'501','501.005','Costo de venta y/o servicio','Mano de obra directa consumida','D'),(393,'501','501.006','Costo de venta y/o servicio','Mano de obra directa','D'),(394,'501','501.007','Costo de venta y/o servicio','Cargos indirectos de producciÃ³n','D'),(395,'501','501.008','Costo de venta y/o servicio','Otros conceptos de costo','D'),(396,'502','502.001','Compras','Compras nacionales','D'),(397,'502','502.002','Compras','Compras nacionales parte relacionada','D'),(398,'502','502.003','Compras','Compras de ImportaciÃ³n','D'),(399,'502','502.004','Compras','Compras de ImportaciÃ³n partes relacionadas','D'),(400,'503','503.001','Devoluciones, descuentos o bonificaciones sobre compras','Devoluciones, descuentos o bonificaciones sobre compras','D'),(401,'504','504.001','Otras cuentas de costos','Gastos indirectos de fabricaciÃ³n','D'),(402,'504','504.002','Otras cuentas de costos','Gastos indirectos de fabricaciÃ³n de partes relacionadas nacionales','D'),(403,'504','504.003','Otras cuentas de costos','Gastos indirectos de fabricaciÃ³n de partes relacionadas extranjeras','D'),(404,'504','504.004','Otras cuentas de costos','Otras cuentas de costos incurridos','D'),(405,'504','504.005','Otras cuentas de costos','Otras cuentas de costos incurridos con partes relacionadas nacionales','D'),(406,'504','504.006','Otras cuentas de costos','Otras cuentas de costos incurridos con partes relacionadas extranjeras','D'),(407,'504','504.007','Otras cuentas de costos','DepreciaciÃ³n de edificios','D'),(408,'504','504.008','Otras cuentas de costos','DepreciaciÃ³n de maquinaria y equipo','D'),(409,'504','504.009','Otras cuentas de costos','DepreciaciÃ³n de automÃ³viles, autobuses, camiones de carga, tractocamiones, montacargas y remolques','D'),(410,'504','504.010','Otras cuentas de costos','DepreciaciÃ³n de mobiliario y equipo de oficina','D'),(411,'504','504.011','Otras cuentas de costos','DepreciaciÃ³n de equipo de cÃ³mputo','D'),(412,'504','504.012','Otras cuentas de costos','DepreciaciÃ³n de equipo de comunicaciÃ³n','D'),(413,'504','504.013','Otras cuentas de costos','DepreciaciÃ³n de activos biolÃ³gicos, vegetales y semovientes','D'),(414,'504','504.014','Otras cuentas de costos','DepreciaciÃ³n de otros activos fijos','D'),(415,'504','504.015','Otras cuentas de costos','DepreciaciÃ³n de ferrocarriles','D'),(416,'504','504.016','Otras cuentas de costos','DepreciaciÃ³n de embarcaciones','D'),(417,'504','504.017','Otras cuentas de costos','DepreciaciÃ³n de aviones','D'),(418,'504','504.018','Otras cuentas de costos','DepreciaciÃ³n de troqueles, moldes, matrices y herramental','D'),(419,'504','504.019','Otras cuentas de costos','DepreciaciÃ³n de equipo de comunicaciones telefÃ³nicas','D'),(420,'504','504.020','Otras cuentas de costos','DepreciaciÃ³n de equipo de comunicaciÃ³n satelital','D'),(421,'504','504.021','Otras cuentas de costos','DepreciaciÃ³n de equipo de adaptaciones para personas con capacidades diferentes','D'),(422,'504','504.022','Otras cuentas de costos','DepreciaciÃ³n de maquinaria y equipo de generaciÃ³n de energÃ­a de fuentes renovables o de sistemas de cogeneraciÃ³n de electricidad eficiente','D'),(423,'504','504.023','Otras cuentas de costos','DepreciaciÃ³n de adaptaciones y mejoras','D'),(424,'504','504.024','Otras cuentas de costos','DepreciaciÃ³n de otra maquinaria y equipo','D'),(425,'504','504.025','Otras cuentas de costos','Otras cuentas de costos','D'),(426,'505','505.001','Costo de activo fijo','Costo por venta de activo fijo','D'),(427,'505','505.002','Costo de activo fijo','Costo por baja de activo fijo','D'),(428,'601','601.001','Gastos generales','Sueldos y salarios','D'),(429,'601','601.002','Gastos generales','Compensaciones','D'),(430,'601','601.003','Gastos generales','Tiempos extras','D'),(431,'601','601.004','Gastos generales','Premios de asistencia','D'),(432,'601','601.005','Gastos generales','Premios de puntualidad','D'),(433,'601','601.006','Gastos generales','Vacaciones','D'),(434,'601','601.007','Gastos generales','Prima vacacional','D'),(435,'601','601.008','Gastos generales','Prima dominical','D'),(436,'601','601.009','Gastos generales','DÃ­as festivos','D'),(437,'601','601.010','Gastos generales','Gratificaciones','D'),(438,'601','601.011','Gastos generales','Primas de antigÃ¼edad','D'),(439,'601','601.012','Gastos generales','Aguinaldo','D'),(440,'601','601.013','Gastos generales','Indemnizaciones','D'),(441,'601','601.014','Gastos generales','Destajo','D'),(442,'601','601.015','Gastos generales','Despensa','D'),(443,'601','601.016','Gastos generales','Transporte','D'),(444,'601','601.017','Gastos generales','Servicio mÃ©dico','D'),(445,'601','601.018','Gastos generales','Ayuda en gastos funerarios','D'),(446,'601','601.019','Gastos generales','Fondo de ahorro','D'),(447,'601','601.020','Gastos generales','Cuotas sindicales','D'),(448,'601','601.021','Gastos generales','PTU','D'),(449,'601','601.022','Gastos generales','EstÃ­mulo al personal','D'),(450,'601','601.023','Gastos generales','PrevisiÃ³n social','D'),(451,'601','601.024','Gastos generales','Aportaciones para el plan de jubilaciÃ³n','D'),(452,'601','601.025','Gastos generales','Otras prestaciones al personal','D'),(453,'601','601.026','Gastos generales','Cuotas al IMSS','D'),(454,'601','601.027','Gastos generales','Aportaciones al infonavit','D'),(455,'601','601.028','Gastos generales','Aportaciones al SAR','D'),(456,'601','601.029','Gastos generales','Impuesto estatal sobre nÃ³minas','D'),(457,'601','601.030','Gastos generales','Otras aportaciones','D'),(458,'601','601.031','Gastos generales','Asimilados a salarios','D'),(459,'601','601.032','Gastos generales','Servicios administrativos','D'),(460,'601','601.033','Gastos generales','Servicios administrativos partes relacionadas','D'),(461,'601','601.034','Gastos generales','Honorarios a personas fÃ­sicas residentes nacionales','D'),(462,'601','601.035','Gastos generales','Honorarios a personas fÃ­sicas residentes nacionales partes relacionadas','D'),(463,'601','601.036','Gastos generales','Honorarios a personas fÃ­sicas residentes del extranjero','D'),(464,'601','601.037','Gastos generales','Honorarios a personas fÃ­sicas residentes del extranjero partes relacionadas','D'),(465,'601','601.038','Gastos generales','Honorarios a personas morales residentes nacionales','D'),(466,'601','601.039','Gastos generales','Honorarios a personas morales residentes nacionales partes relacionadas','D'),(467,'601','601.040','Gastos generales','Honorarios a personas morales residentes del extranjero','D'),(468,'601','601.041','Gastos generales','Honorarios a personas morales residentes del extranjero partes relacionadas','D'),(469,'601','601.042','Gastos generales','Honorarios aduanales personas fÃ­sicas','D'),(470,'601','601.043','Gastos generales','Honorarios aduanales personas morales','D'),(471,'601','601.044','Gastos generales','Honorarios al consejo de administraciÃ³n','D'),(472,'601','601.045','Gastos generales','Arrendamiento a personas fÃ­sicas residentes nacionales','D'),(473,'601','601.046','Gastos generales','Arrendamiento a personas morales residentes nacionales','D'),(474,'601','601.047','Gastos generales','Arrendamiento a residentes del extranjero','D'),(475,'601','601.048','Gastos generales','Combustibles y lubricantes','D'),(476,'601','601.049','Gastos generales','ViÃ¡ticos y gastos de viaje','D'),(477,'602','601.050','Gastos generales','TelÃ©fono, internet','D'),(478,'602','601.051','Gastos generales','Agua','D'),(479,'602','601.052','Gastos generales','EnergÃ­a elÃ©ctrica','D'),(480,'602','601.053','Gastos generales','Vigilancia y seguridad','D'),(481,'602','601.054','Gastos generales','Limpieza','D'),(482,'602','601.055','Gastos generales','PapelerÃ­a y artÃ­culos de oficina','D'),(483,'602','601.056','Gastos generales','Mantenimiento y conservaciÃ³n','D'),(484,'602','601.057','Gastos generales','Seguros y fianzas','D'),(485,'602','601.058','Gastos generales','Otros impuestos y derechos','D'),(486,'602','601.059','Gastos generales','Recargos fiscales','D'),(487,'602','601.060','Gastos generales','Cuotas y suscripciones','D'),(488,'602','601.061','Gastos generales','Propaganda y publicidad','D'),(489,'602','601.062','Gastos generales','CapacitaciÃ³n al personal','D'),(490,'602','601.063','Gastos generales','Donativos y ayudas','D'),(491,'602','601.064','Gastos generales','Asistencia tÃ©cnica','D'),(492,'602','601.065','Gastos generales','RegalÃ­as sujetas a otros porcentajes','D'),(493,'602','601.066','Gastos generales','RegalÃ­as sujetas al 5%','D'),(494,'602','601.067','Gastos generales','RegalÃ­as sujetas al 10%','D'),(495,'602','601.068','Gastos generales','RegalÃ­as sujetas al 15%','D'),(496,'602','601.069','Gastos generales','RegalÃ­as sujetas al 25%','D'),(497,'602','601.070','Gastos generales','RegalÃ­as sujetas al 30%','D'),(498,'602','601.071','Gastos generales','RegalÃ­as sin retenciÃ³n','D'),(499,'602','601.072','Gastos generales','Fletes y acarreos','D'),(500,'602','601.073','Gastos generales','Gastos de importaciÃ³n','D'),(501,'602','601.074','Gastos generales','Comisiones sobre ventas','D'),(502,'602','601.075','Gastos generales','Comisiones por tarjetas de crÃ©dito','D'),(503,'602','601.076','Gastos generales','Patentes y marcas','D'),(504,'602','601.077','Gastos generales','Uniformes','D'),(505,'602','601.078','Gastos generales','Prediales','D'),(506,'602','601.079','Gastos generales','Gastos generales de urbanizaciÃ³n','D'),(507,'602','601.080','Gastos generales','Gastos generales de construcciÃ³n','D'),(508,'602','601.081','Gastos generales','Fletes del extranjero','D'),(509,'602','601.082','Gastos generales','RecolecciÃ³n de bienes del sector agropecuario y/o ganadero','D'),(510,'602','601.083','Gastos generales','Gastos no deducibles (sin requisitos fiscales)','D'),(511,'602','601.084','Gastos generales','Otros gastos generales','D'),(512,'602','602.001','Gastos de venta','Sueldos y salarios','D'),(513,'602','602.002','Gastos de venta','Compensaciones','D'),(514,'602','602.003','Gastos de venta','Tiempos extras','D'),(515,'602','602.004','Gastos de venta','Premios de asistencia','D'),(516,'602','602.005','Gastos de venta','Premios de puntualidad','D'),(517,'602','602.006','Gastos de venta','Vacaciones','D'),(518,'602','602.007','Gastos de venta','Prima vacacional','D'),(519,'602','602.008','Gastos de venta','Prima dominical','D'),(520,'602','602.009','Gastos de venta','DÃ­as festivos','D'),(521,'602','602.010','Gastos de venta','Gratificaciones','D'),(522,'602','602.011','Gastos de venta','Primas de antigÃ¼edad','D'),(523,'602','602.012','Gastos de venta','Aguinaldo','D'),(524,'602','602.013','Gastos de venta','Indemnizaciones','D'),(525,'602','602.014','Gastos de venta','Destajo','D'),(526,'602','602.015','Gastos de venta','Despensa','D'),(527,'602','602.016','Gastos de venta','Transporte','D'),(528,'602','602.017','Gastos de venta','Servicio mÃ©dico','D'),(529,'602','602.018','Gastos de venta','Ayuda en gastos funerarios','D'),(530,'602','602.019','Gastos de venta','Fondo de ahorro','D'),(531,'602','602.020','Gastos de venta','Cuotas sindicales','D'),(532,'602','602.021','Gastos de venta','PTU','D'),(533,'602','602.022','Gastos de venta','EstÃ­mulo al personal','D'),(534,'602','602.023','Gastos de venta','PrevisiÃ³n social','D'),(535,'602','602.024','Gastos de venta','Aportaciones para el plan de jubilaciÃ³n','D'),(536,'602','602.025','Gastos de venta','Otras prestaciones al personal','D'),(537,'602','602.026','Gastos de venta','Cuotas al IMSS','D'),(538,'602','602.027','Gastos de venta','Aportaciones al infonavit','D'),(539,'602','602.028','Gastos de venta','Aportaciones al SAR','D'),(540,'602','602.029','Gastos de venta','Impuesto estatal sobre nÃ³minas','D'),(541,'602','602.030','Gastos de venta','Otras aportaciones','D'),(542,'602','602.031','Gastos de venta','Asimilados a salarios','D'),(543,'602','602.032','Gastos de venta','Servicios administrativos','D'),(544,'602','602.033','Gastos de venta','Servicios administrativos partes relacionadas','D'),(545,'602','602.034','Gastos de venta','Honorarios a personas fÃ­sicas residentes nacionales','D'),(546,'602','602.035','Gastos de venta','Honorarios a personas fÃ­sicas residentes nacionales partes relacionadas','D'),(547,'602','602.036','Gastos de venta','Honorarios a personas fÃ­sicas residentes del extranjero','D'),(548,'602','602.037','Gastos de venta','Honorarios a personas fÃ­sicas residentes del extranjero partes relacionadas','D'),(549,'602','602.038','Gastos de venta','Honorarios a personas morales residentes nacionales','D'),(550,'602','602.039','Gastos de venta','Honorarios a personas morales residentes nacionales partes relacionadas','D'),(551,'602','602.040','Gastos de venta','Honorarios a personas morales residentes del extranjero','D'),(552,'602','602.041','Gastos de venta','Honorarios a personas morales residentes del extranjero partes relacionadas','D'),(553,'602','602.042','Gastos de venta','Honorarios aduanales personas fÃ­sicas','D'),(554,'602','602.043','Gastos de venta','Honorarios aduanales personas morales','D'),(555,'602','602.044','Gastos de venta','Honorarios al consejo de administraciÃ³n','D'),(556,'602','602.045','Gastos de venta','Arrendamiento a personas fÃ­sicas residentes nacionales','D'),(557,'602','602.046','Gastos de venta','Arrendamiento a personas morales residentes nacionales','D'),(558,'602','602.047','Gastos de venta','Arrendamiento a residentes del extranjero','D'),(559,'602','602.048','Gastos de venta','Combustibles y lubricantes','D'),(560,'602','602.049','Gastos de venta','ViÃ¡ticos y gastos de viaje','D'),(561,'603','602.050','Gastos de venta','TelÃ©fono, internet','D'),(562,'603','602.051','Gastos de venta','Agua','D'),(563,'603','602.052','Gastos de venta','EnergÃ­a elÃ©ctrica','D'),(564,'603','602.053','Gastos de venta','Vigilancia y seguridad','D'),(565,'603','602.054','Gastos de venta','Limpieza','D'),(566,'603','602.055','Gastos de venta','PapelerÃ­a y artÃ­culos de oficina','D'),(567,'603','602.056','Gastos de venta','Mantenimiento y conservaciÃ³n','D'),(568,'603','602.057','Gastos de venta','Seguros y fianzas','D'),(569,'603','602.058','Gastos de venta','Otros impuestos y derechos','D'),(570,'603','602.059','Gastos de venta','Recargos fiscales','D'),(571,'603','602.060','Gastos de venta','Cuotas y suscripciones','D'),(572,'603','602.061','Gastos de venta','Propaganda y publicidad','D'),(573,'603','602.062','Gastos de venta','CapacitaciÃ³n al personal','D'),(574,'603','602.063','Gastos de venta','Donativos y ayudas','D'),(575,'603','602.064','Gastos de venta','Asistencia tÃ©cnica','D'),(576,'603','602.065','Gastos de venta','RegalÃ­as sujetas a otros porcentajes','D'),(577,'603','602.066','Gastos de venta','RegalÃ­as sujetas al 5%','D'),(578,'603','602.067','Gastos de venta','RegalÃ­as sujetas al 10%','D'),(579,'603','602.068','Gastos de venta','RegalÃ­as sujetas al 15%','D'),(580,'603','602.069','Gastos de venta','RegalÃ­as sujetas al 25%','D'),(581,'603','602.070','Gastos de venta','RegalÃ­as sujetas al 30%','D'),(582,'603','602.071','Gastos de venta','RegalÃ­as sin retenciÃ³n','D'),(583,'603','602.072','Gastos de venta','Fletes y acarreos','D'),(584,'603','602.073','Gastos de venta','Gastos de importaciÃ³n','D'),(585,'603','602.074','Gastos de venta','Comisiones sobre ventas','D'),(586,'603','602.075','Gastos de venta','Comisiones por tarjetas de crÃ©dito','D'),(587,'603','602.076','Gastos de venta','Patentes y marcas','D'),(588,'603','602.077','Gastos de venta','Uniformes','D'),(589,'603','602.078','Gastos de venta','Prediales','D'),(590,'603','602.079','Gastos de venta','Gastos de venta de urbanizaciÃ³n','D'),(591,'603','602.080','Gastos de venta','Gastos de venta de construcciÃ³n','D'),(592,'603','602.081','Gastos de venta','Fletes del extranjero','D'),(593,'603','602.082','Gastos de venta','RecolecciÃ³n de bienes del sector agropecuario y/o ganadero','D'),(594,'603','602.083','Gastos de venta','Gastos no deducibles (sin requisitos fiscales)','D'),(595,'603','602.084','Gastos de venta','Otros gastos de venta','D'),(596,'603','603.001','Gastos de administraciÃ³n','Sueldos y salarios','D'),(597,'603','603.002','Gastos de administraciÃ³n','Compensaciones','D'),(598,'603','603.003','Gastos de administraciÃ³n','Tiempos extras','D'),(599,'603','603.004','Gastos de administraciÃ³n','Premios de asistencia','D'),(600,'603','603.005','Gastos de administraciÃ³n','Premios de puntualidad','D'),(601,'603','603.006','Gastos de administraciÃ³n','Vacaciones','D'),(602,'603','603.007','Gastos de administraciÃ³n','Prima vacacional','D'),(603,'603','603.008','Gastos de administraciÃ³n','Prima dominical','D'),(604,'603','603.009','Gastos de administraciÃ³n','DÃ­as festivos','D'),(605,'603','603.010','Gastos de administraciÃ³n','Gratificaciones','D'),(606,'603','603.011','Gastos de administraciÃ³n','Primas de antigÃ¼edad','D'),(607,'603','603.012','Gastos de administraciÃ³n','Aguinaldo','D'),(608,'603','603.013','Gastos de administraciÃ³n','Indemnizaciones','D'),(609,'603','603.014','Gastos de administraciÃ³n','Destajo','D'),(610,'603','603.015','Gastos de administraciÃ³n','Despensa','D'),(611,'603','603.016','Gastos de administraciÃ³n','Transporte','D'),(612,'603','603.017','Gastos de administraciÃ³n','Servicio mÃ©dico','D'),(613,'603','603.018','Gastos de administraciÃ³n','Ayuda en gastos funerarios','D'),(614,'603','603.019','Gastos de administraciÃ³n','Fondo de ahorro','D'),(615,'603','603.020','Gastos de administraciÃ³n','Cuotas sindicales','D'),(616,'603','603.021','Gastos de administraciÃ³n','PTU','D'),(617,'603','603.022','Gastos de administraciÃ³n','EstÃ­mulo al personal','D'),(618,'603','603.023','Gastos de administraciÃ³n','PrevisiÃ³n social','D'),(619,'603','603.024','Gastos de administraciÃ³n','Aportaciones para el plan de jubilaciÃ³n','D'),(620,'603','603.025','Gastos de administraciÃ³n','Otras prestaciones al personal','D'),(621,'603','603.026','Gastos de administraciÃ³n','Cuotas al IMSS','D'),(622,'603','603.027','Gastos de administraciÃ³n','Aportaciones al infonavit','D'),(623,'603','603.028','Gastos de administraciÃ³n','Aportaciones al SAR','D'),(624,'603','603.029','Gastos de administraciÃ³n','Impuesto estatal sobre nÃ³minas','D'),(625,'603','603.030','Gastos de administraciÃ³n','Otras aportaciones','D'),(626,'603','603.031','Gastos de administraciÃ³n','Asimilados a salarios','D'),(627,'603','603.032','Gastos de administraciÃ³n','Servicios administrativos','D'),(628,'603','603.033','Gastos de administraciÃ³n','Servicios administrativos partes relacionadas','D'),(629,'603','603.034','Gastos de administraciÃ³n','Honorarios a personas fÃ­sicas residentes nacionales','D'),(630,'603','603.035','Gastos de administraciÃ³n','Honorarios a personas fÃ­sicas residentes nacionales partes relacionadas','D'),(631,'603','603.036','Gastos de administraciÃ³n','Honorarios a personas fÃ­sicas residentes del extranjero','D'),(632,'603','603.037','Gastos de administraciÃ³n','Honorarios a personas fÃ­sicas residentes del extranjero partes relacionadas','D'),(633,'603','603.038','Gastos de administraciÃ³n','Honorarios a personas morales residentes nacionales','D'),(634,'603','603.039','Gastos de administraciÃ³n','Honorarios a personas morales residentes nacionales partes relacionadas','D'),(635,'603','603.040','Gastos de administraciÃ³n','Honorarios a personas morales residentes del extranjero','D'),(636,'603','603.041','Gastos de administraciÃ³n','Honorarios a personas morales residentes del extranjero partes relacionadas','D'),(637,'603','603.042','Gastos de administraciÃ³n','Honorarios aduanales personas fÃ­sicas','D'),(638,'603','603.043','Gastos de administraciÃ³n','Honorarios aduanales personas morales','D'),(639,'603','603.044','Gastos de administraciÃ³n','Honorarios al consejo de administraciÃ³n','D'),(640,'603','603.045','Gastos de administraciÃ³n','Arrendamiento a personas fÃ­sicas residentes nacionales','D'),(641,'603','603.046','Gastos de administraciÃ³n','Arrendamiento a personas morales residentes nacionales','D'),(642,'603','603.047','Gastos de administraciÃ³n','Arrendamiento a residentes del extranjero','D'),(643,'603','603.048','Gastos de administraciÃ³n','Combustibles y lubricantes','D'),(644,'603','603.049','Gastos de administraciÃ³n','ViÃ¡ticos y gastos de viaje','D'),(645,'604','603.050','Gastos de administraciÃ³n','TelÃ©fono, internet','D'),(646,'604','603.051','Gastos de administraciÃ³n','Agua','D'),(647,'604','603.052','Gastos de administraciÃ³n','EnergÃ­a elÃ©ctrica','D'),(648,'604','603.053','Gastos de administraciÃ³n','Vigilancia y seguridad','D'),(649,'604','603.054','Gastos de administraciÃ³n','Limpieza','D'),(650,'604','603.055','Gastos de administraciÃ³n','PapelerÃ­a y artÃ­culos de oficina','D'),(651,'604','603.056','Gastos de administraciÃ³n','Mantenimiento y conservaciÃ³n','D'),(652,'604','603.057','Gastos de administraciÃ³n','Seguros y fianzas','D'),(653,'604','603.058','Gastos de administraciÃ³n','Otros impuestos y derechos','D'),(654,'604','603.059','Gastos de administraciÃ³n','Recargos fiscales','D'),(655,'604','603.060','Gastos de administraciÃ³n','Cuotas y suscripciones','D'),(656,'604','603.061','Gastos de administraciÃ³n','Propaganda y publicidad','D'),(657,'604','603.062','Gastos de administraciÃ³n','CapacitaciÃ³n al personal','D'),(658,'604','603.063','Gastos de administraciÃ³n','Donativos y ayudas','D'),(659,'604','603.064','Gastos de administraciÃ³n','Asistencia tÃ©cnica','D'),(660,'604','603.065','Gastos de administraciÃ³n','RegalÃ­as sujetas a otros porcentajes','D'),(661,'604','603.066','Gastos de administraciÃ³n','RegalÃ­as sujetas al 5%','D'),(662,'604','603.067','Gastos de administraciÃ³n','RegalÃ­as sujetas al 10%','D'),(663,'604','603.068','Gastos de administraciÃ³n','RegalÃ­as sujetas al 15%','D'),(664,'604','603.069','Gastos de administraciÃ³n','RegalÃ­as sujetas al 25%','D'),(665,'604','603.070','Gastos de administraciÃ³n','RegalÃ­as sujetas al 30%','D'),(666,'604','603.071','Gastos de administraciÃ³n','RegalÃ­as sin retenciÃ³n','D'),(667,'604','603.072','Gastos de administraciÃ³n','Fletes y acarreos','D'),(668,'604','603.073','Gastos de administraciÃ³n','Gastos de importaciÃ³n','D'),(669,'604','603.074','Gastos de administraciÃ³n','Patentes y marcas','D'),(670,'604','603.075','Gastos de administraciÃ³n','Uniformes','D'),(671,'604','603.076','Gastos de administraciÃ³n','Prediales','D'),(672,'604','603.077','Gastos de administraciÃ³n','Gastos de administraciÃ³n de urbanizaciÃ³n','D'),(673,'604','603.078','Gastos de administraciÃ³n','Gastos de administraciÃ³n de construcciÃ³n','D'),(674,'604','603.079','Gastos de administraciÃ³n','Fletes del extranjero','D'),(675,'604','603.080','Gastos de administraciÃ³n','RecolecciÃ³n de bienes del sector agropecuario y/o ganadero','D'),(676,'604','603.081','Gastos de administraciÃ³n','Gastos no deducibles (sin requisitos fiscales)','D'),(677,'604','603.082','Gastos de administraciÃ³n','Otros gastos de administraciÃ³n','D'),(678,'604','604.001','Gastos de fabricacion','Sueldos y salarios','D'),(679,'604','604.002','Gastos de fabricacion','Compensaciones','D'),(680,'604','604.003','Gastos de fabricacion','Tiempos extras','D'),(681,'604','604.004','Gastos de fabricacion','Premios de asistencia','D'),(682,'604','604.005','Gastos de fabricacion','Premios de puntualidad','D'),(683,'604','604.006','Gastos de fabricacion','Vacaciones','D'),(684,'604','604.007','Gastos de fabricacion','Prima vacacional','D'),(685,'604','604.008','Gastos de fabricacion','Prima dominical','D'),(686,'604','604.009','Gastos de fabricacion','DÃ­as festivos','D'),(687,'604','604.010','Gastos de fabricacion','Gratificaciones','D'),(688,'604','604.011','Gastos de fabricacion','Primas de antigÃ¼edad','D'),(689,'604','604.012','Gastos de fabricacion','Aguinaldo','D'),(690,'604','604.013','Gastos de fabricacion','Indemnizaciones','D'),(691,'604','604.014','Gastos de fabricacion','Destajo','D'),(692,'604','604.015','Gastos de fabricacion','Despensa','D'),(693,'604','604.016','Gastos de fabricacion','Transporte','D'),(694,'604','604.017','Gastos de fabricacion','Servicio mÃ©dico','D'),(695,'604','604.018','Gastos de fabricacion','Ayuda en gastos funerarios','D'),(696,'604','604.019','Gastos de fabricacion','Fondo de ahorro','D'),(697,'604','604.020','Gastos de fabricacion','Cuotas sindicales','D'),(698,'604','604.021','Gastos de fabricacion','PTU','D'),(699,'604','604.022','Gastos de fabricacion','EstÃ­mulo al personal','D'),(700,'604','604.023','Gastos de fabricacion','PrevisiÃ³n social','D'),(701,'604','604.024','Gastos de fabricacion','Aportaciones para el plan de jubilaciÃ³n','D'),(702,'604','604.025','Gastos de fabricacion','Otras prestaciones al personal','D'),(703,'604','604.026','Gastos de fabricacion','Cuotas al IMSS','D'),(704,'604','604.027','Gastos de fabricacion','Aportaciones al infonavit','D'),(705,'604','604.028','Gastos de fabricacion','Aportaciones al SAR','D'),(706,'604','604.029','Gastos de fabricacion','Impuesto estatal sobre nÃ³minas','D'),(707,'604','604.030','Gastos de fabricacion','Otras aportaciones','D'),(708,'604','604.031','Gastos de fabricacion','Asimilados a salarios','D'),(709,'604','604.032','Gastos de fabricacion','Servicios administrativos','D'),(710,'604','604.033','Gastos de fabricacion','Servicios administrativos partes relacionadas','D'),(711,'604','604.034','Gastos de fabricacion','Honorarios a personas fÃ­sicas residentes nacionales','D'),(712,'604','604.035','Gastos de fabricacion','Honorarios a personas fÃ­sicas residentes nacionales partes relacionadas','D'),(713,'604','604.036','Gastos de fabricacion','Honorarios a personas fÃ­sicas residentes del extranjero','D'),(714,'604','604.037','Gastos de fabricacion','Honorarios a personas fÃ­sicas residentes del extranjero partes relacionadas','D'),(715,'604','604.038','Gastos de fabricacion','Honorarios a personas morales residentes nacionales','D'),(716,'604','604.039','Gastos de fabricacion','Honorarios a personas morales residentes nacionales partes relacionadas','D'),(717,'604','604.040','Gastos de fabricacion','Honorarios a personas morales residentes del extranjero','D'),(718,'604','604.041','Gastos de fabricacion','Honorarios a personas morales residentes del extranjero partes relacionadas','D'),(719,'604','604.042','Gastos de fabricacion','Honorarios aduanales personas fÃ­sicas','D'),(720,'604','604.043','Gastos de fabricacion','Honorarios aduanales personas morales','D'),(721,'604','604.044','Gastos de fabricacion','Honorarios al consejo de administraciÃ³n','D'),(722,'604','604.045','Gastos de fabricacion','Arrendamiento a personas fÃ­sicas residentes nacionales','D'),(723,'604','604.046','Gastos de fabricacion','Arrendamiento a personas morales residentes nacionales','D'),(724,'604','604.047','Gastos de fabricacion','Arrendamiento a residentes del extranjero','D'),(725,'604','604.048','Gastos de fabricacion','Combustibles y lubricantes','D'),(726,'604','604.049','Gastos de fabricacion','ViÃ¡ticos y gastos de viaje','D'),(727,'605','604.050','Gastos de fabricacion','TelÃ©fono, internet','D'),(728,'605','604.051','Gastos de fabricacion','Agua','D'),(729,'605','604.052','Gastos de fabricacion','EnergÃ­a elÃ©ctrica','D'),(730,'605','604.053','Gastos de fabricacion','Vigilancia y seguridad','D'),(731,'605','604.054','Gastos de fabricacion','Limpieza','D'),(732,'605','604.055','Gastos de fabricacion','PapelerÃ­a y artÃ­culos de oficina','D'),(733,'605','604.056','Gastos de fabricacion','Mantenimiento y conservaciÃ³n','D'),(734,'605','604.057','Gastos de fabricacion','Seguros y fianzas','D'),(735,'605','604.058','Gastos de fabricacion','Otros impuestos y derechos','D'),(736,'605','604.059','Gastos de fabricacion','Recargos fiscales','D'),(737,'605','604.060','Gastos de fabricacion','Cuotas y suscripciones','D'),(738,'605','604.061','Gastos de fabricacion','Propaganda y publicidad','D'),(739,'605','604.062','Gastos de fabricacion','CapacitaciÃ³n al personal','D'),(740,'605','604.063','Gastos de fabricacion','Donativos y ayudas','D'),(741,'605','604.064','Gastos de fabricacion','Asistencia tÃ©cnica','D'),(742,'605','604.065','Gastos de fabricacion','RegalÃ­as sujetas a otros porcentajes','D'),(743,'605','604.066','Gastos de fabricacion','RegalÃ­as sujetas al 5%','D'),(744,'605','604.067','Gastos de fabricacion','RegalÃ­as sujetas al 10%','D'),(745,'605','604.068','Gastos de fabricacion','RegalÃ­as sujetas al 15%','D'),(746,'605','604.069','Gastos de fabricacion','RegalÃ­as sujetas al 25%','D'),(747,'605','604.070','Gastos de fabricacion','RegalÃ­as sujetas al 30%','D'),(748,'605','604.071','Gastos de fabricacion','RegalÃ­as sin retenciÃ³n','D'),(749,'605','604.072','Gastos de fabricacion','Fletes y acarreos','D'),(750,'605','604.073','Gastos de fabricacion','Gastos de importaciÃ³n','D'),(751,'605','604.074','Gastos de fabricacion','Patentes y marcas','D'),(752,'605','604.075','Gastos de fabricacion','Uniformes','D'),(753,'605','604.076','Gastos de fabricacion','Prediales','D'),(754,'605','604.077','Gastos de fabricacion','Gastos de fabricaciÃ³n de urbanizaciÃ³n','D'),(755,'605','604.078','Gastos de fabricacion','Gastos de fabricaciÃ³n de construcciÃ³n','D'),(756,'605','604.079','Gastos de fabricacion','Fletes del extranjero','D'),(757,'605','604.080','Gastos de fabricacion','RecolecciÃ³n de bienes del sector agropecuario y/o ganadero','D'),(758,'605','604.081','Gastos de fabricacion','Gastos no deducibles (sin requisitos fiscales)','D'),(759,'605','604.082','Gastos de fabricacion','Otros gastos de fabricaciÃ³n','D'),(760,'605','605.001','Mano de obra directa','Mano de obra','D'),(761,'605','605.002','Mano de obra directa','Sueldos y Salarios','D'),(762,'605','605.003','Mano de obra directa','Compensaciones','D'),(763,'605','605.004','Mano de obra directa','Tiempos extras','D'),(764,'605','605.005','Mano de obra directa','Premios de asistencia','D'),(765,'605','605.006','Mano de obra directa','Premios de puntualidad','D'),(766,'605','605.007','Mano de obra directa','Vacaciones','D'),(767,'605','605.008','Mano de obra directa','Prima vacacional','D'),(768,'605','605.009','Mano de obra directa','Prima dominical','D'),(769,'605','605.010','Mano de obra directa','DÃ­as festivos','D'),(770,'605','605.011','Mano de obra directa','Gratificaciones','D'),(771,'605','605.012','Mano de obra directa','Primas de antigÃ¼edad','D'),(772,'605','605.013','Mano de obra directa','Aguinaldo','D'),(773,'605','605.014','Mano de obra directa','Indemnizaciones','D'),(774,'605','605.015','Mano de obra directa','Destajo','D'),(775,'605','605.016','Mano de obra directa','Despensa','D'),(776,'605','605.017','Mano de obra directa','Transporte','D'),(777,'605','605.018','Mano de obra directa','Servicio mÃ©dico','D'),(778,'605','605.019','Mano de obra directa','Ayuda en gastos funerarios','D'),(779,'605','605.020','Mano de obra directa','Fondo de ahorro','D'),(780,'605','605.021','Mano de obra directa','Cuotas sindicales','D'),(781,'605','605.022','Mano de obra directa','PTU','D'),(782,'605','605.023','Mano de obra directa','EstÃ­mulo al personal','D'),(783,'605','605.024','Mano de obra directa','PrevisiÃ³n social','D'),(784,'605','605.025','Mano de obra directa','Aportaciones para el plan de jubilaciÃ³n','D'),(785,'605','605.026','Mano de obra directa','Otras prestaciones al personal','D'),(786,'605','605.027','Mano de obra directa','Asimilados a salarios','D'),(787,'605','605.028','Mano de obra directa','Cuotas al IMSS','D'),(788,'605','605.029','Mano de obra directa','Aportaciones al infonavit','D'),(789,'605','605.030','Mano de obra directa','Aportaciones al SAR','D'),(790,'605','605.031','Mano de obra directa','Otros costos de mano de obra directa','D'),(791,'606','606.001','Facilidades administrativas fiscales','Facilidades administrativas fiscales','D'),(792,'607','607.001','ParticipaciÃ³n de los trabajadores en las utilidades','ParticipaciÃ³n de los trabajadores en las utilidades','D'),(793,'608','608.001','ParticipaciÃ³n en resultados de subsidiarias','ParticipaciÃ³n en resultados de subsidiarias','D'),(794,'609','609.001','ParticipaciÃ³n en resultados de asociadas','ParticipaciÃ³n en resultados de asociadas','D'),(795,'610','610.001','ParticipaciÃ³n de los trabajadores en las utilidades diferida','ParticipaciÃ³n de los trabajadores en las utilidades diferida','D'),(796,'611','611.001','Impuesto Sobre la renta','Impuesto Sobre la renta','D'),(797,'611','611.002','Impuesto Sobre la renta','Impuesto Sobre la renta por remanente distribuible','D'),(798,'612','612.001','Gastos no deducibles para CUFIN','Gastos no deducibles para CUFIN','D'),(799,'613','613.001','DepreciaciÃ³n contable','DepreciaciÃ³n de edificios','D'),(800,'613','613.002','DepreciaciÃ³n contable','DepreciaciÃ³n de maquinaria y equipo','D'),(801,'613','613.003','DepreciaciÃ³n contable','DepreciaciÃ³n de automÃ³viles, autobuses, camiones de carga, tractocamiones, montacargas y remolques','D'),(802,'613','613.004','DepreciaciÃ³n contable','DepreciaciÃ³n de mobiliario y equipo de oficina','D'),(803,'613','613.005','DepreciaciÃ³n contable','DepreciaciÃ³n de equipo de cÃ³mputo','D'),(804,'613','613.006','DepreciaciÃ³n contable','DepreciaciÃ³n de equipo de comunicaciÃ³n','D'),(805,'613','613.007','DepreciaciÃ³n contable','DepreciaciÃ³n de activos biolÃ³gicos, vegetales y semovientes','D'),(806,'613','613.008','DepreciaciÃ³n contable','DepreciaciÃ³n de otros activos fijos','D'),(807,'613','613.009','DepreciaciÃ³n contable','DepreciaciÃ³n de ferrocarriles','D'),(808,'613','613.010','DepreciaciÃ³n contable','DepreciaciÃ³n de embarcaciones','D'),(809,'613','613.011','DepreciaciÃ³n contable','DepreciaciÃ³n de aviones','D'),(810,'613','613.012','DepreciaciÃ³n contable','DepreciaciÃ³n de troqueles, moldes, matrices y herramental','D'),(811,'613','613.013','DepreciaciÃ³n contable','DepreciaciÃ³n de equipo de comunicaciones telefÃ³nicas','D'),(812,'613','613.014','DepreciaciÃ³n contable','DepreciaciÃ³n de equipo de comunicaciÃ³n satelital','D'),(813,'613','613.015','DepreciaciÃ³n contable','DepreciaciÃ³n de equipo de adaptaciones para personas con capacidades diferentes','D'),(814,'613','613.016','DepreciaciÃ³n contable','DepreciaciÃ³n de maquinaria y equipo de generaciÃ³n de energÃ­a de fuentes renovables o de sistemas de cogeneraciÃ³n de electricidad eficiente','D'),(815,'613','613.017','DepreciaciÃ³n contable','DepreciaciÃ³n de adaptaciones y mejoras','D'),(816,'613','613.018','DepreciaciÃ³n contable','DepreciaciÃ³n de otra maquinaria y equipo','D'),(817,'614','614.001','AmortizaciÃ³n contable','AmortizaciÃ³n de gastos diferidos','D'),(818,'614','614.002','AmortizaciÃ³n contable','AmortizaciÃ³n de gastos pre operativos','D'),(819,'614','614.003','AmortizaciÃ³n contable','AmortizaciÃ³n de regalÃ­as, asistencia tÃ©cnica y otros gastos diferidos','D'),(820,'614','614.004','AmortizaciÃ³n contable','AmortizaciÃ³n de activos intangibles','D'),(821,'614','614.005','AmortizaciÃ³n contable','AmortizaciÃ³n de gastos de organizaciÃ³n','D'),(822,'614','614.006','AmortizaciÃ³n contable','AmortizaciÃ³n de investigaciÃ³n y desarrollo de mercado','D'),(823,'614','614.007','AmortizaciÃ³n contable','AmortizaciÃ³n de marcas y patentes','D'),(824,'614','614.008','AmortizaciÃ³n contable','AmortizaciÃ³n de crÃ©dito mercantil','D'),(825,'614','614.009','AmortizaciÃ³n contable','AmortizaciÃ³n de gastos de instalaciÃ³n','D'),(826,'614','614.010','AmortizaciÃ³n contable','AmortizaciÃ³n de otros activos diferidos','D'),(827,'701','701.001','Gastos financieros','PÃ©rdida cambiaria','D'),(828,'701','701.002','Gastos financieros','PÃ©rdida cambiaria nacional parte relacionada','D'),(829,'701','701.003','Gastos financieros','PÃ©rdida cambiaria extranjero parte relacionada','D'),(830,'701','701.004','Gastos financieros','Intereses a cargo bancario nacional','D'),(831,'701','701.005','Gastos financieros','Intereses a cargo bancario extranjero','D'),(832,'701','701.006','Gastos financieros','Intereses a cargo de personas fÃ­sicas nacional','D'),(833,'701','701.007','Gastos financieros','Intereses a cargo de personas fÃ­sicas extranjero','D'),(834,'701','701.008','Gastos financieros','Intereses a cargo de personas morales nacional','D'),(835,'701','701.009','Gastos financieros','Intereses a cargo de personas morales extranjero','D'),(836,'701','701.010','Gastos financieros','Comisiones bancarias','D'),(837,'701','701.011','Gastos financieros','Otros gastos financieros','D'),(838,'702','702.001','Productos financieros','Utilidad cambiaria','A'),(839,'702','702.002','Productos financieros','Utilidad cambiaria nacional parte relacionada','A'),(840,'702','702.003','Productos financieros','Utilidad cambiaria extranjero parte relacionada','A'),(841,'702','702.004','Productos financieros','Intereses a favor bancarios nacional','A'),(842,'702','702.005','Productos financieros','Intereses a favor bancarios extranjero','A'),(843,'702','702.006','Productos financieros','Intereses a favor de personas fÃ­sicas nacional','A'),(844,'702','702.007','Productos financieros','Intereses a favor de personas fÃ­sicas extranjero','A'),(845,'702','702.008','Productos financieros','Intereses a favor de personas morales nacional','A'),(846,'702','702.009','Productos financieros','Intereses a favor de personas morales extranjero','A'),(847,'702','702.010','Productos financieros','Otros productos financieros','A'),(848,'703','703.001','Otros gastos','PÃ©rdida en venta y/o baja de terrenos','D'),(849,'703','703.002','Otros gastos','PÃ©rdida en venta y/o baja de edificios','D'),(850,'703','703.003','Otros gastos','PÃ©rdida en venta y/o baja de maquinaria y equipo','D'),(851,'703','703.004','Otros gastos','PÃ©rdida en venta y/o baja de automÃ³viles, autobuses, camiones de carga, tractocamiones, montacargas y remolques','D'),(852,'703','703.005','Otros gastos','PÃ©rdida en venta y/o baja de mobiliario y equipo de oficina','D'),(853,'703','703.006','Otros gastos','PÃ©rdida en venta y/o baja de equipo de cÃ³mputo','D'),(854,'703','703.007','Otros gastos','PÃ©rdida en venta y/o baja de equipo de comunicaciÃ³n','D'),(855,'703','703.008','Otros gastos','PÃ©rdida en venta y/o baja de activos biolÃ³gicos, vegetales y semovientes','D'),(856,'703','703.009','Otros gastos','PÃ©rdida en venta y/o baja de otros activos fijos','D'),(857,'703','703.010','Otros gastos','PÃ©rdida en venta y/o baja de ferrocarriles','D'),(858,'703','703.011','Otros gastos','PÃ©rdida en venta y/o baja de embarcaciones','D'),(859,'703','703.012','Otros gastos','PÃ©rdida en venta y/o baja de aviones','D'),(860,'703','703.013','Otros gastos','PÃ©rdida en venta y/o baja de troqueles, moldes, matrices y herramental','D'),(861,'703','703.014','Otros gastos','PÃ©rdida en venta y/o baja de equipo de comunicaciones telefÃ³nicas','D'),(862,'703','703.015','Otros gastos','PÃ©rdida en venta y/o baja de equipo de comunicaciÃ³n satelital','D'),(863,'703','703.016','Otros gastos','PÃ©rdida en venta y/o baja de equipo de adaptaciones para personas con capacidades diferentes','D'),(864,'703','703.017','Otros gastos','PÃ©rdida en venta y/o baja de maquinaria y equipo de generaciÃ³n de energÃ­a de fuentes renovables o de sistemas de cogeneraciÃ³n de electricidad eficiente','D'),(865,'703','703.018','Otros gastos','PÃ©rdida en venta y/o baja de otra maquinaria y equipo','D'),(866,'703','703.019','Otros gastos','PÃ©rdida por enajenaciÃ³n de acciones','D'),(867,'703','703.020','Otros gastos','PÃ©rdida por enajenaciÃ³n de partes sociales','D'),(868,'703','703.021','Otros gastos','Otros gastos','D'),(869,'704','704.001','Otros productos','Ganancia en venta y/o baja de terrenos','A'),(870,'704','704.002','Otros productos','Ganancia en venta y/o baja de edificios','A'),(871,'704','704.003','Otros productos','Ganancia en venta y/o baja de maquinaria y equipo','A'),(872,'704','704.004','Otros productos','Ganancia en venta y/o baja de automÃ³viles, autobuses, camiones de carga, tractocamiones, montacargas y remolques','A'),(873,'704','704.005','Otros productos','Ganancia en venta y/o baja de mobiliario y equipo de oficina','A'),(874,'704','704.006','Otros productos','Ganancia en venta y/o baja de equipo de cÃ³mputo','A'),(875,'704','704.007','Otros productos','Ganancia en venta y/o baja de equipo de comunicaciÃ³n','A'),(876,'704','704.008','Otros productos','Ganancia en venta y/o baja de activos biolÃ³gicos, vegetales y semovientes','A'),(877,'704','704.009','Otros productos','Ganancia en venta y/o baja de otros activos fijos','A'),(878,'704','704.010','Otros productos','Ganancia en venta y/o baja de ferrocarriles','A'),(879,'704','704.011','Otros productos','Ganancia en venta y/o baja de embarcaciones','A'),(880,'704','704.012','Otros productos','Ganancia en venta y/o baja de aviones','A'),(881,'704','704.013','Otros productos','Ganancia en venta y/o baja de troqueles, moldes, matrices y herramental','A'),(882,'704','704.014','Otros productos','Ganancia en venta y/o baja de equipo de comunicaciones telefÃ³nicas','A'),(883,'704','704.015','Otros productos','Ganancia en venta y/o baja de equipo de comunicaciÃ³n satelital','A'),(884,'704','704.016','Otros productos','Ganancia en venta y/o baja de equipo de adaptaciones para personas con capacidades diferentes','A'),(885,'704','704.017','Otros productos','Ganancia en venta de maquinaria y equipo de generaciÃ³n de energÃ­a de fuentes renovables o de sistemas de cogeneraciÃ³n de electricidad eficiente','A'),(886,'704','704.018','Otros productos','Ganancia en venta y/o baja de otra maquinaria y equipo','A'),(887,'704','704.019','Otros productos','Ganancia por enajenaciÃ³n de acciones','A'),(888,'704','704.020','Otros productos','Ganancia por enajenaciÃ³n de partes sociales','A'),(889,'704','704.021','Otros productos','Ingresos por estÃ­mulos fiscales','A'),(890,'704','704.022','Otros productos','Ingresos por condonaciÃ³n de adeudo','A'),(891,'704','704.023','Otros productos','Otros productos','A'),(892,'801','801.001','UFIN del ejercicio','UFIN','A'),(893,'801','801.002','UFIN del ejercicio','Contra cuenta UFIN','A'),(894,'802','802.001','CUFIN del ejercicio','CUFIN','A'),(895,'802','802.002','CUFIN del ejercicio','Contra cuenta CUFIN','A'),(896,'803','803.001','CUFIN de ejercicios anteriores','CUFIN de ejercicios anteriores','A'),(897,'803','803.002','CUFIN de ejercicios anteriores','Contra cuenta CUFIN de ejercicios anteriores','A'),(898,'804','804.001','CUFINRE del ejercicio','CUFINRE','A'),(899,'804','804.002','CUFINRE del ejercicio','Contra cuenta CUFINRE','A'),(900,'805','805.001','CUFINRE de ejercicios anteriores','CUFINRE de ejercicios anteriores','A'),(901,'805','805.002','CUFINRE de ejercicios anteriores','Contra cuenta CUFINRE de ejercicios anteriores','A'),(902,'806','806.001','CUCA del ejercicio','CUCA','A'),(903,'806','806.002','CUCA del ejercicio','Contra cuenta CUCA','A'),(904,'807','807.001','CUCA de ejercicios anteriores','CUCA de ejercicios anteriores','A'),(905,'807','807.002','CUCA de ejercicios anteriores','Contra cuenta CUCA de ejercicios anteriores','A'),(906,'808','808.001','Ajuste anual por inflaciÃ³n acumulable','Ajuste anual por inflaciÃ³n acumulable','A'),(907,'808','808.002','Ajuste anual por inflaciÃ³n acumulable','AcumulaciÃ³n del ajuste anual inflacionario','A'),(908,'809','809.001','Ajuste anual por inflaciÃ³n deducible','Ajuste anual por inflaciÃ³n deducible','A'),(909,'809','809.002','Ajuste anual por inflaciÃ³n deducible','DeducciÃ³n del ajuste anual inflacionario','A'),(910,'810','810.001','DeducciÃ³n de inversiÃ³n','DeducciÃ³n de inversiÃ³n','D'),(911,'810','810.002','DeducciÃ³n de inversiÃ³n','Contra cuenta deducciÃ³n de inversiones','A'),(912,'811','811.001','Utilidad o pÃ©rdida fiscal en venta y/o baja de activo fijo','Utilidad o pÃ©rdida fiscal en venta y/o baja de activo fijo','D'),(913,'811','811.002','Utilidad o pÃ©rdida fiscal en venta y/o baja de activo fijo','Contra cuenta utilidad o pÃ©rdida fiscal en venta y/o baja de activo fijo','A'),(914,'812','812.001','Utilidad o pÃ©rdida fiscal en venta acciones o partes sociales','Utilidad o pÃ©rdida fiscal en venta acciones o partes sociales','D'),(915,'812','812.002','Utilidad o pÃ©rdida fiscal en venta acciones o partes sociales','Contra cuenta utilidad o pÃ©rdida fiscal en venta acciones o partes sociales','A'),(916,'813','813.001','PÃ©rdidas fiscales pendientes de amortizar actualizadas de ejercicios anteriores','PÃ©rdidas fiscales pendientes de amortizar actualizadas de ejercicios anteriores','D'),(917,'813','813.002','PÃ©rdidas fiscales pendientes de amortizar actualizadas de ejercicios anteriores','ActualizaciÃ³n de pÃ©rdidas fiscales pendientes de amortizar de ejercicios anteriores','A'),(918,'814','814.001','MercancÃ­as recibidas en consignaciÃ³n','MercancÃ­as recibidas en consignaciÃ³n','D'),(919,'814','814.002','MercancÃ­as recibidas en consignaciÃ³n','ConsignaciÃ³n de mercancÃ­as recibidas','A'),(920,'815','815.001','CrÃ©dito fiscal de IVA e IEPS por la importaciÃ³n de mercancÃ­as para empresas certificadas','CrÃ©dito fiscal de IVA e IEPS por la importaciÃ³n de mercancÃ­as','D'),(921,'815','815.002','CrÃ©dito fiscal de IVA e IEPS por la importaciÃ³n de mercancÃ­as para empresas certificadas','ImportaciÃ³n de mercancÃ­as con aplicaciÃ³n de crÃ©dito fiscal de IVA e IEPS','A'),(922,'816','816.001','CrÃ©dito fiscal de IVA e IEPS por la importaciÃ³n de activos fijos para empresas certificadas','CrÃ©dito fiscal de IVA e IEPS por la importaciÃ³n de activo fijo','D'),(923,'816','816.002','CrÃ©dito fiscal de IVA e IEPS por la importaciÃ³n de activos fijos para empresas certificadas','ImportaciÃ³n de activo fijo con aplicaciÃ³n de crÃ©dito fiscal de IVA e IEPS','A'),(924,'899','899.001','Otras cuentas de orden','Otras cuentas de orden','D'),(925,'899','899.002','Otras cuentas de orden','Contra cuenta otras cuentas de orden','A');
/*!40000 ALTER TABLE `catalogo_cuentas_sat` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cuentas_reportes`
--

DROP TABLE IF EXISTS `cuentas_reportes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cuentas_reportes` (
  `id_cr` int(11) NOT NULL AUTO_INCREMENT,
  `id_cuenta` int(11) DEFAULT '0',
  `tipo` varchar(200) DEFAULT '',
  PRIMARY KEY (`id_cr`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cuentas_reportes`
--

LOCK TABLES `cuentas_reportes` WRITE;
/*!40000 ALTER TABLE `cuentas_reportes` DISABLE KEYS */;
/*!40000 ALTER TABLE `cuentas_reportes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `factura`
--

DROP TABLE IF EXISTS `factura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `factura` (
  `id_timbrados` int(11) NOT NULL AUTO_INCREMENT,
  `serie_t` varchar(50) DEFAULT NULL,
  `folio_t` varchar(50) DEFAULT NULL,
  `fecha_t` date DEFAULT '2017-01-01',
  `rfc_r` varchar(50) DEFAULT '',
  `nombre_r` varchar(200) DEFAULT '',
  `rfc_e` varchar(50) DEFAULT NULL,
  `nombre_e` varchar(200) DEFAULT NULL,
  `tipo_cambio` decimal(15,2) DEFAULT '0.00',
  `moneda` varchar(50) DEFAULT '',
  `uso_cfdi` varchar(200) DEFAULT '',
  `sub_t` decimal(15,2) DEFAULT '0.00',
  `total_t` decimal(15,2) DEFAULT '0.00',
  `descuento_g` decimal(15,2) DEFAULT '0.00',
  `uuid` varchar(500) DEFAULT '',
  `cert` varchar(500) DEFAULT '',
  `certsat` varchar(500) DEFAULT '',
  `fechacert` varchar(50) DEFAULT '',
  `cfdi` varchar(500) DEFAULT '',
  `sellosat` varchar(500) DEFAULT '',
  `cadena` varchar(1000) DEFAULT '',
  `elaboro` varchar(500) DEFAULT '',
  `fecha_creacion` datetime DEFAULT CURRENT_TIMESTAMP,
  `estatus` varchar(50) DEFAULT 'Sin Timbrar',
  `condicion` varchar(200) DEFAULT '',
  `forma` varchar(200) DEFAULT '',
  `oc` varchar(200) DEFAULT '',
  `fecha_oc` datetime DEFAULT CURRENT_TIMESTAMP,
  `num_pagos` int(11) DEFAULT '0',
  `pagos` int(11) DEFAULT '0',
  `decimales` int(11) DEFAULT '2',
  `tipo` varchar(10) DEFAULT 'I',
  `modifico` varchar(500) DEFAULT '',
  `fecha_modificacion` datetime DEFAULT CURRENT_TIMESTAMP,
  `notas` varchar(1000) DEFAULT '',
  PRIMARY KEY (`id_timbrados`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `factura`
--

LOCK TABLES `factura` WRITE;
/*!40000 ALTER TABLE `factura` DISABLE KEYS */;
/*!40000 ALTER TABLE `factura` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `factura_det`
--

DROP TABLE IF EXISTS `factura_det`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `factura_det` (
  `id_factura_det` int(11) NOT NULL AUTO_INCREMENT,
  `id_factura` int(11) DEFAULT '0',
  `clave` varchar(200) DEFAULT ' ',
  `descripcion` varchar(200) DEFAULT '',
  `item` int(11) DEFAULT '0',
  `cantidad` decimal(15,6) DEFAULT '0.000000',
  `importe_unit` decimal(15,6) DEFAULT '0.000000',
  `precio_unit` decimal(15,6) DEFAULT '0.000000',
  `importe_tot` decimal(15,6) DEFAULT '0.000000',
  `precio_tot` decimal(15,6) DEFAULT '0.000000',
  `iva` varchar(50) DEFAULT '-',
  `impuesto_iva` varchar(50) DEFAULT '-',
  `tipo_iva` varchar(50) DEFAULT '-',
  `tasa_iva` varchar(50) DEFAULT '-',
  `ieps` varchar(50) DEFAULT '-',
  `impuesto_ieps` varchar(50) DEFAULT '-',
  `tipo_ieps` varchar(50) DEFAULT '-',
  `tasa_ieps` varchar(50) DEFAULT '-',
  `isr` varchar(50) DEFAULT '-',
  `impuesto_isr` varchar(50) DEFAULT '-',
  `tipo_isr` varchar(50) DEFAULT '-',
  `tasa_isr` varchar(50) DEFAULT '-',
  `iva_ret` varchar(50) DEFAULT '-',
  `impuesto_iva_ret` varchar(50) DEFAULT '-',
  `tipo_iva_ret` varchar(50) DEFAULT '-',
  `tasa_iva_ret` varchar(50) DEFAULT '-',
  `almacenable` varchar(50) DEFAULT '-',
  `descuento` decimal(15,6) DEFAULT '0.000000',
  `importe_ieps` decimal(15,6) DEFAULT '0.000000',
  `notas` varchar(1000) DEFAULT '',
  `notas_f` varchar(1000) DEFAULT '',
  PRIMARY KEY (`id_factura_det`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `factura_det`
--

LOCK TABLES `factura_det` WRITE;
/*!40000 ALTER TABLE `factura_det` DISABLE KEYS */;
/*!40000 ALTER TABLE `factura_det` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `factura_impuestos`
--

DROP TABLE IF EXISTS `factura_impuestos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `factura_impuestos` (
  `id_factura_imp` int(11) NOT NULL AUTO_INCREMENT,
  `id_factura` int(11) DEFAULT NULL,
  `impuesto` varchar(200) DEFAULT '',
  `tipo` varchar(200) DEFAULT '',
  `calculo` varchar(100) DEFAULT '',
  `tasa` decimal(15,2) DEFAULT '0.00',
  `unidades` decimal(15,2) DEFAULT '0.00',
  `tipo_iva` varchar(200) DEFAULT '',
  `total` decimal(15,2) DEFAULT '0.00',
  `importe` decimal(15,2) DEFAULT NULL,
  `tabla` varchar(200) DEFAULT '',
  PRIMARY KEY (`id_factura_imp`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `factura_impuestos`
--

LOCK TABLES `factura_impuestos` WRITE;
/*!40000 ALTER TABLE `factura_impuestos` DISABLE KEYS */;
/*!40000 ALTER TABLE `factura_impuestos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `polizas`
--

DROP TABLE IF EXISTS `polizas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `polizas` (
  `id_poliza` int(11) NOT NULL AUTO_INCREMENT,
  `tipo_poliza` varchar(50) DEFAULT NULL,
  `numero_poliza` int(11) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `descripcion` varchar(100) DEFAULT NULL,
  `total` decimal(15,2) DEFAULT NULL,
  `mes` varchar(20) DEFAULT NULL,
  `anio` varchar(4) DEFAULT NULL,
  `usuariocreador` int(11) DEFAULT NULL,
  `fechacreacion` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `usuariomodificador` varchar(50) DEFAULT NULL,
  `fechamodificacion` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `origen` varchar(30) DEFAULT 'CONTABILIDAD',
  `estado` varchar(30) DEFAULT 'activo',
  `eliminada` varchar(10) DEFAULT 'NO',
  PRIMARY KEY (`id_poliza`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `polizas`
--

LOCK TABLES `polizas` WRITE;
/*!40000 ALTER TABLE `polizas` DISABLE KEYS */;
/*!40000 ALTER TABLE `polizas` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_ENGINE_SUBSTITUTION' */ ;

/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `polizas_det`
--

DROP TABLE IF EXISTS `polizas_det`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `polizas_det` (
  `id_polizas_det` int(11) NOT NULL AUTO_INCREMENT,
  `id_poliza` int(11) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `id_cuenta` int(11) DEFAULT NULL,
  `cargo` decimal(15,2) DEFAULT NULL,
  `abono` decimal(15,2) DEFAULT NULL,
  `desc_asiento` varchar(200) DEFAULT NULL,
  `estado` varchar(15) DEFAULT 'activo',
  PRIMARY KEY (`id_polizas_det`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `polizas_det`
--

LOCK TABLES `polizas_det` WRITE;
/*!40000 ALTER TABLE `polizas_det` DISABLE KEYS */;
/*!40000 ALTER TABLE `polizas_det` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `regimen_fiscal`
--

DROP TABLE IF EXISTS `regimen_fiscal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `regimen_fiscal` (
  `id_regimen` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(200) DEFAULT NULL,
  `clave` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`id_regimen`)
) ENGINE=InnoDB AUTO_INCREMENT=85 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `regimen_fiscal`
--

LOCK TABLES `regimen_fiscal` WRITE;
/*!40000 ALTER TABLE `regimen_fiscal` DISABLE KEYS */;
INSERT INTO `regimen_fiscal` VALUES (64,'General de Ley Personas Morales','601'),(65,'Personas Morales con Fines no Lucrativos','603'),(66,'Sueldos y Salarios e Ingresos Asimilados a Salarios','605'),(67,'Arrendamiento','606'),(68,'Demás ingresos','608'),(69,'Consolidación','609'),(70,'Residentes en el Extranjero sin Establecimiento Permanente en México','610'),(71,'Ingresos por Dividendos (socios y accionistas)','611'),(72,'Personas Físicas con Actividades Empresariales y Profesionales','612'),(73,'Ingresos por intereses','614'),(74,'Sin obligaciones fiscales','616'),(75,'Sociedades Cooperativas de Producción que optan por diferir sus ingresos','620'),(76,'Incorporación Fiscal','621'),(77,'Actividades Agrícolas, Ganaderas, Silvícolas y Pesqueras','622'),(78,'Opcional para Grupos de Sociedades','623'),(79,'Coordinados','624'),(80,'Hidrocarburos','628'),(81,'Régimen de Enajenación o Adquisición de Bienes','607'),(82,'De los Regímenes Fiscales Preferentes y de las Empresas Multinacionales','629'),(83,'Enajenación de acciones en bolsa de valores','630'),(84,'Régimen de los ingresos por obtención de premios','615');
/*!40000 ALTER TABLE `regimen_fiscal` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_pol`
--

DROP TABLE IF EXISTS `tipo_pol`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipo_pol` (
  `id_tip_pol` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_tip_pol` varchar(200) DEFAULT NULL,
  `tipo_pol` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_tip_pol`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_pol`
--

LOCK TABLES `tipo_pol` WRITE;
/*!40000 ALTER TABLE `tipo_pol` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipo_pol` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `xmlguardados`
--

DROP TABLE IF EXISTS `xmlguardados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `xmlguardados` (
  `id_xml` int(11) NOT NULL AUTO_INCREMENT,
  `modalidad_facturacion` varchar(10) DEFAULT NULL,
  `uuid` varchar(100) DEFAULT NULL,
  `naturaleza` char(1) DEFAULT NULL,
  `tipo_comprobante` char(1) DEFAULT NULL,
  `tipo_doct_msp` varchar(50) DEFAULT NULL,
  `folio` varchar(50) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `rfc` varchar(15) DEFAULT NULL,
  `taxid` varchar(30) DEFAULT NULL,
  `nombre` varchar(200) DEFAULT NULL,
  `importe` decimal(15,2) DEFAULT NULL,
  `moneda` varchar(200) DEFAULT NULL,
  `tipo_cambio` decimal(18,2) DEFAULT NULL,
  PRIMARY KEY (`id_xml`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `xmlguardados`
--

LOCK TABLES `xmlguardados` WRITE;
/*!40000 ALTER TABLE `xmlguardados` DISABLE KEYS */;
/*!40000 ALTER TABLE `xmlguardados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `xmlusados`
--

DROP TABLE IF EXISTS `xmlusados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `xmlusados` (
  `id_xmlusados` int(11) NOT NULL AUTO_INCREMENT,
  `id_poliza` int(11) DEFAULT NULL,
  `id_xml` int(11) DEFAULT NULL,
  `id_factura` int(11) DEFAULT '0',
  PRIMARY KEY (`id_xmlusados`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `xmlusados`
--

LOCK TABLES `xmlusados` WRITE;
/*!40000 ALTER TABLE `xmlusados` DISABLE KEYS */;
/*!40000 ALTER TABLE `xmlusados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'pruebacontabilidad'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-09-14 11:54:20
", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                End While
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Contago Contabilidad 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()

            MessageBox.Show("Empresa creada correctamente", "Contago Contabilidad 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Information)

#End Region

            datos.base = base
            datos.nombre_emp = tbNomEmp.Text
            datos.rfc_emp = tbRFCEmp.Text
            datos.regimen_emp = cbRegFis.Text

            If conexion.inserta_Base(datos) Then

            End If

            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand("select * from config_contabilidad.bases", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    banEm = True
                End While
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()

            If banEm = True Then

                scrConfiguracion.dgvEmpresas.Rows.Clear()

                Try
                    Conexion_Global()
                    _conexion.Open()
                    comandoSql = New MySqlCommand("select * from config_contabilidad.bases order by base asc", _conexion)
                    resultado = comandoSql.ExecuteReader
                    While resultado.Read
                        scrConfiguracion.dgvEmpresas.Rows.Add(resultado.GetInt64("id_base"), resultado.GetString("nombre_emp"), resultado.GetString("rfc_emp"), resultado.GetString("base"))
                    End While
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrar()
                End Try
                _conexion.Close()

            End If

        End If

        Me.Close()

    End Sub

    Private Sub scrEmpresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        cbRegFis.Items.Clear()
        cbRegFis.Items.Add("-Selecciona un Regimen-")
        cbRegFis.SelectedIndex = 0

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from pruebacontabilidad.regimen_fiscal order by descripcion asc", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                cbRegFis.Items.Add(resultado.GetString("descripcion"))
            End While
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

    End Sub

End Class