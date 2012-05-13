/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2005                    */
/* Created on:     5/13/2012 9:15:03 PM                         */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ASSIGNMENTDETAIL') and o.name = 'FK_ASSIGNME_RELATIONS_ASSIGNME')
alter table ASSIGNMENTDETAIL
   drop constraint FK_ASSIGNME_RELATIONS_ASSIGNME
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ASSIGNMENTDETAIL') and o.name = 'FK_ASSIGNME_RELATIONS_PATIENT')
alter table ASSIGNMENTDETAIL
   drop constraint FK_ASSIGNME_RELATIONS_PATIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ASSIGNMENTDETAIL') and o.name = 'FK_ASSIGNME_RELATIONS_STAFF')
alter table ASSIGNMENTDETAIL
   drop constraint FK_ASSIGNME_RELATIONS_STAFF
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BILL') and o.name = 'FK_BILL_RELATIONS_PATIENT')
alter table BILL
   drop constraint FK_BILL_RELATIONS_PATIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BILL') and o.name = 'FK_BILL_RELATIONS_STAFF')
alter table BILL
   drop constraint FK_BILL_RELATIONS_STAFF
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BILL') and o.name = 'FK_BILL_RELATIONS_BILLTYPE')
alter table BILL
   drop constraint FK_BILL_RELATIONS_BILLTYPE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DISCHARGEDCERTIFICATE') and o.name = 'FK_DISCHARG_RELATIONS_PATIENT')
alter table DISCHARGEDCERTIFICATE
   drop constraint FK_DISCHARG_RELATIONS_PATIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DISCHARGEDCERTIFICATE') and o.name = 'FK_DISCHARG_RELATIONS_STAFF')
alter table DISCHARGEDCERTIFICATE
   drop constraint FK_DISCHARG_RELATIONS_STAFF
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EXAMINATIONCERTIFICATE') and o.name = 'FK_EXAMINAT_RELATIONS_PATIENT')
alter table EXAMINATIONCERTIFICATE
   drop constraint FK_EXAMINAT_RELATIONS_PATIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EXAMINATIONCERTIFICATE') and o.name = 'FK_EXAMINAT_RELATIONS_STAFF')
alter table EXAMINATIONCERTIFICATE
   drop constraint FK_EXAMINAT_RELATIONS_STAFF
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HEATHFILE') and o.name = 'FK_HEATHFIL_RELATIONS_PATIENT')
alter table HEATHFILE
   drop constraint FK_HEATHFIL_RELATIONS_PATIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HEATHMONITORINGNOTE') and o.name = 'FK_HEATHMON_RELATIONS_PATIENT')
alter table HEATHMONITORINGNOTE
   drop constraint FK_HEATHMON_RELATIONS_PATIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HEATHMONITORINGNOTE') and o.name = 'FK_HEATHMON_RELATIONS_STAFF')
alter table HEATHMONITORINGNOTE
   drop constraint FK_HEATHMON_RELATIONS_STAFF
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HIC') and o.name = 'FK_HIC_RELATIONS_PATIENT')
alter table HIC
   drop constraint FK_HIC_RELATIONS_PATIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HOSPITALIZATIONCERTIFICATE') and o.name = 'FK_HOSPITAL_RELATIONS_STAFF')
alter table HOSPITALIZATIONCERTIFICATE
   drop constraint FK_HOSPITAL_RELATIONS_STAFF
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HOSPITALIZATIONCERTIFICATE') and o.name = 'FK_HOSPITAL_RELATIONS_PATIENT')
alter table HOSPITALIZATIONCERTIFICATE
   drop constraint FK_HOSPITAL_RELATIONS_PATIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MEDICINEBILLDETAIL') and o.name = 'FK_MEDICINE_RELATIONS_MEDICINE')
alter table MEDICINEBILLDETAIL
   drop constraint FK_MEDICINE_RELATIONS_MEDICINE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MEDICINEBILLDETAIL') and o.name = 'FK_MEDICINE_RELATIONS_BILL')
alter table MEDICINEBILLDETAIL
   drop constraint FK_MEDICINE_RELATIONS_BILL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PRESCRIPTION') and o.name = 'FK_PRESCRIP_RELATIONS_PATIENT')
alter table PRESCRIPTION
   drop constraint FK_PRESCRIP_RELATIONS_PATIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PRESCRIPTION') and o.name = 'FK_PRESCRIP_RELATIONS_STAFF')
alter table PRESCRIPTION
   drop constraint FK_PRESCRIP_RELATIONS_STAFF
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PRESCRIPTIONDETAIL') and o.name = 'FK_PRESCRIP_RELATIONS_MEDICINE')
alter table PRESCRIPTIONDETAIL
   drop constraint FK_PRESCRIP_RELATIONS_MEDICINE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PRESCRIPTIONDETAIL') and o.name = 'FK_PRESCRIP_RELATIONS_PRESCRIP')
alter table PRESCRIPTIONDETAIL
   drop constraint FK_PRESCRIP_RELATIONS_PRESCRIP
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RENTMATERIALBILLDETAIL') and o.name = 'FK_RENTMATE_RELATIONS_BILL')
alter table RENTMATERIALBILLDETAIL
   drop constraint FK_RENTMATE_RELATIONS_BILL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RENTMATERIALBILLDETAIL') and o.name = 'FK_RENTMATE_RELATIONS_MATERIAL')
alter table RENTMATERIALBILLDETAIL
   drop constraint FK_RENTMATE_RELATIONS_MATERIAL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ROLEDETAIL') and o.name = 'FK_ROLEDETA_RELATIONS_ROLE')
alter table ROLEDETAIL
   drop constraint FK_ROLEDETA_RELATIONS_ROLE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ROLEDETAIL') and o.name = 'FK_ROLEDETA_RELATIONS_ROLEFUNC')
alter table ROLEDETAIL
   drop constraint FK_ROLEDETA_RELATIONS_ROLEFUNC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SERVICEBILLDETAIL') and o.name = 'FK_SERVICEB_RELATIONS_SERVICE')
alter table SERVICEBILLDETAIL
   drop constraint FK_SERVICEB_RELATIONS_SERVICE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SERVICEBILLDETAIL') and o.name = 'FK_SERVICEB_RELATIONS_BILL')
alter table SERVICEBILLDETAIL
   drop constraint FK_SERVICEB_RELATIONS_BILL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('STAFF') and o.name = 'FK_STAFF_RELATIONS_DEPARTME')
alter table STAFF
   drop constraint FK_STAFF_RELATIONS_DEPARTME
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('STAFF') and o.name = 'FK_STAFF_RELATIONS_MAJOR')
alter table STAFF
   drop constraint FK_STAFF_RELATIONS_MAJOR
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('STAFF') and o.name = 'FK_STAFF_RELATIONS_ROLE')
alter table STAFF
   drop constraint FK_STAFF_RELATIONS_ROLE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SURGICAL') and o.name = 'FK_SURGICAL_RELATIONS_PATIENT')
alter table SURGICAL
   drop constraint FK_SURGICAL_RELATIONS_PATIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SURGICALDETAIL') and o.name = 'FK_SURGICAL_RELATIONS_SURGICAL')
alter table SURGICALDETAIL
   drop constraint FK_SURGICAL_RELATIONS_SURGICAL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SURGICALDETAIL') and o.name = 'FK_SURGICAL_RELATIONS_STAFF')
alter table SURGICALDETAIL
   drop constraint FK_SURGICAL_RELATIONS_STAFF
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TESTCERTIFICATE') and o.name = 'FK_TESTCERT_RELATIONS_STAFF')
alter table TESTCERTIFICATE
   drop constraint FK_TESTCERT_RELATIONS_STAFF
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TESTCERTIFICATE') and o.name = 'FK_TESTCERT_RELATIONS_PATIENT')
alter table TESTCERTIFICATE
   drop constraint FK_TESTCERT_RELATIONS_PATIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TESTDETAIL') and o.name = 'FK_TESTDETA_RELATIONS_TESTCERT')
alter table TESTDETAIL
   drop constraint FK_TESTDETA_RELATIONS_TESTCERT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TESTDETAIL') and o.name = 'FK_TESTDETA_RELATIONS_TESTTYPE')
alter table TESTDETAIL
   drop constraint FK_TESTDETA_RELATIONS_TESTTYPE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ASSIGNMENT')
            and   type = 'U')
   drop table ASSIGNMENT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ASSIGNMENTDETAIL')
            and   name  = 'RELATIONSHIP_34_FK'
            and   indid > 0
            and   indid < 255)
   drop index ASSIGNMENTDETAIL.RELATIONSHIP_34_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ASSIGNMENTDETAIL')
            and   name  = 'RELATIONSHIP_12_FK'
            and   indid > 0
            and   indid < 255)
   drop index ASSIGNMENTDETAIL.RELATIONSHIP_12_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ASSIGNMENTDETAIL')
            and   name  = 'RELATIONSHIP_1_FK'
            and   indid > 0
            and   indid < 255)
   drop index ASSIGNMENTDETAIL.RELATIONSHIP_1_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ASSIGNMENTDETAIL')
            and   type = 'U')
   drop table ASSIGNMENTDETAIL
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BILL')
            and   name  = 'RELATIONSHIP_43_FK'
            and   indid > 0
            and   indid < 255)
   drop index BILL.RELATIONSHIP_43_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BILL')
            and   name  = 'RELATIONSHIP_31_FK'
            and   indid > 0
            and   indid < 255)
   drop index BILL.RELATIONSHIP_31_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BILL')
            and   name  = 'RELATIONSHIP_14_FK'
            and   indid > 0
            and   indid < 255)
   drop index BILL.RELATIONSHIP_14_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BILL')
            and   type = 'U')
   drop table BILL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BILLTYPE')
            and   type = 'U')
   drop table BILLTYPE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DEPARTMENT')
            and   type = 'U')
   drop table DEPARTMENT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DISCHARGEDCERTIFICATE')
            and   name  = 'RELATIONSHIP_35_FK'
            and   indid > 0
            and   indid < 255)
   drop index DISCHARGEDCERTIFICATE.RELATIONSHIP_35_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DISCHARGEDCERTIFICATE')
            and   name  = 'RELATIONSHIP_19_FK'
            and   indid > 0
            and   indid < 255)
   drop index DISCHARGEDCERTIFICATE.RELATIONSHIP_19_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DISCHARGEDCERTIFICATE')
            and   type = 'U')
   drop table DISCHARGEDCERTIFICATE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DISEASE')
            and   type = 'U')
   drop table DISEASE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('EXAMINATIONCERTIFICATE')
            and   name  = 'RELATIONSHIP_36_FK'
            and   indid > 0
            and   indid < 255)
   drop index EXAMINATIONCERTIFICATE.RELATIONSHIP_36_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('EXAMINATIONCERTIFICATE')
            and   name  = 'RELATIONSHIP_18_FK'
            and   indid > 0
            and   indid < 255)
   drop index EXAMINATIONCERTIFICATE.RELATIONSHIP_18_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EXAMINATIONCERTIFICATE')
            and   type = 'U')
   drop table EXAMINATIONCERTIFICATE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HEATHFILE')
            and   name  = 'RELATIONSHIP_16_FK'
            and   indid > 0
            and   indid < 255)
   drop index HEATHFILE.RELATIONSHIP_16_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HEATHFILE')
            and   type = 'U')
   drop table HEATHFILE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HEATHMONITORINGNOTE')
            and   name  = 'RELATIONSHIP_37_FK'
            and   indid > 0
            and   indid < 255)
   drop index HEATHMONITORINGNOTE.RELATIONSHIP_37_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HEATHMONITORINGNOTE')
            and   name  = 'RELATIONSHIP_17_FK'
            and   indid > 0
            and   indid < 255)
   drop index HEATHMONITORINGNOTE.RELATIONSHIP_17_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HEATHMONITORINGNOTE')
            and   type = 'U')
   drop table HEATHMONITORINGNOTE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HIC')
            and   name  = 'RELATIONSHIP_45_FK'
            and   indid > 0
            and   indid < 255)
   drop index HIC.RELATIONSHIP_45_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HIC')
            and   type = 'U')
   drop table HIC
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HOSPITALBED')
            and   type = 'U')
   drop table HOSPITALBED
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HOSPITALIZATIONCERTIFICATE')
            and   name  = 'RELATIONSHIP_49_FK'
            and   indid > 0
            and   indid < 255)
   drop index HOSPITALIZATIONCERTIFICATE.RELATIONSHIP_49_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HOSPITALIZATIONCERTIFICATE')
            and   name  = 'RELATIONSHIP_48_FK'
            and   indid > 0
            and   indid < 255)
   drop index HOSPITALIZATIONCERTIFICATE.RELATIONSHIP_48_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HOSPITALIZATIONCERTIFICATE')
            and   type = 'U')
   drop table HOSPITALIZATIONCERTIFICATE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MAJOR')
            and   type = 'U')
   drop table MAJOR
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MATERIAL')
            and   type = 'U')
   drop table MATERIAL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MEDICINE')
            and   type = 'U')
   drop table MEDICINE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MEDICINEBILLDETAIL')
            and   name  = 'RELATIONSHIP_44_FK'
            and   indid > 0
            and   indid < 255)
   drop index MEDICINEBILLDETAIL.RELATIONSHIP_44_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MEDICINEBILLDETAIL')
            and   name  = 'RELATIONSHIP_10_FK'
            and   indid > 0
            and   indid < 255)
   drop index MEDICINEBILLDETAIL.RELATIONSHIP_10_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MEDICINEBILLDETAIL')
            and   type = 'U')
   drop table MEDICINEBILLDETAIL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PATIENT')
            and   type = 'U')
   drop table PATIENT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PRESCRIPTION')
            and   name  = 'RELATIONSHIP_29_FK'
            and   indid > 0
            and   indid < 255)
   drop index PRESCRIPTION.RELATIONSHIP_29_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PRESCRIPTION')
            and   name  = 'RELATIONSHIP_20_FK'
            and   indid > 0
            and   indid < 255)
   drop index PRESCRIPTION.RELATIONSHIP_20_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PRESCRIPTION')
            and   type = 'U')
   drop table PRESCRIPTION
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PRESCRIPTIONDETAIL')
            and   name  = 'RELATIONSHIP_22_FK'
            and   indid > 0
            and   indid < 255)
   drop index PRESCRIPTIONDETAIL.RELATIONSHIP_22_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PRESCRIPTIONDETAIL')
            and   name  = 'RELATIONSHIP_21_FK'
            and   indid > 0
            and   indid < 255)
   drop index PRESCRIPTIONDETAIL.RELATIONSHIP_21_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PRESCRIPTIONDETAIL')
            and   type = 'U')
   drop table PRESCRIPTIONDETAIL
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RENTMATERIALBILLDETAIL')
            and   name  = 'RELATIONSHIP_47_FK'
            and   indid > 0
            and   indid < 255)
   drop index RENTMATERIALBILLDETAIL.RELATIONSHIP_47_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RENTMATERIALBILLDETAIL')
            and   name  = 'RELATIONSHIP_7_FK'
            and   indid > 0
            and   indid < 255)
   drop index RENTMATERIALBILLDETAIL.RELATIONSHIP_7_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RENTMATERIALBILLDETAIL')
            and   type = 'U')
   drop table RENTMATERIALBILLDETAIL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ROLE')
            and   type = 'U')
   drop table ROLE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ROLEDETAIL')
            and   name  = 'RELATIONSHIP_4_FK'
            and   indid > 0
            and   indid < 255)
   drop index ROLEDETAIL.RELATIONSHIP_4_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ROLEDETAIL')
            and   name  = 'RELATIONSHIP_3_FK'
            and   indid > 0
            and   indid < 255)
   drop index ROLEDETAIL.RELATIONSHIP_3_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ROLEDETAIL')
            and   type = 'U')
   drop table ROLEDETAIL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ROLEFUNCTION')
            and   type = 'U')
   drop table ROLEFUNCTION
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SERVICE')
            and   type = 'U')
   drop table SERVICE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SERVICEBILLDETAIL')
            and   name  = 'RELATIONSHIP_46_FK'
            and   indid > 0
            and   indid < 255)
   drop index SERVICEBILLDETAIL.RELATIONSHIP_46_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SERVICEBILLDETAIL')
            and   name  = 'RELATIONSHIP_25_FK'
            and   indid > 0
            and   indid < 255)
   drop index SERVICEBILLDETAIL.RELATIONSHIP_25_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SERVICEBILLDETAIL')
            and   type = 'U')
   drop table SERVICEBILLDETAIL
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('STAFF')
            and   name  = 'RELATIONSHIP_28_FK'
            and   indid > 0
            and   indid < 255)
   drop index STAFF.RELATIONSHIP_28_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('STAFF')
            and   name  = 'RELATIONSHIP_27_FK'
            and   indid > 0
            and   indid < 255)
   drop index STAFF.RELATIONSHIP_27_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('STAFF')
            and   name  = 'RELATIONSHIP_26_FK'
            and   indid > 0
            and   indid < 255)
   drop index STAFF.RELATIONSHIP_26_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('STAFF')
            and   type = 'U')
   drop table STAFF
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SURGICAL')
            and   name  = 'RELATIONSHIP_38_FK'
            and   indid > 0
            and   indid < 255)
   drop index SURGICAL.RELATIONSHIP_38_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SURGICAL')
            and   type = 'U')
   drop table SURGICAL
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SURGICALDETAIL')
            and   name  = 'RELATIONSHIP_40_FK'
            and   indid > 0
            and   indid < 255)
   drop index SURGICALDETAIL.RELATIONSHIP_40_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SURGICALDETAIL')
            and   name  = 'RELATIONSHIP_39_FK'
            and   indid > 0
            and   indid < 255)
   drop index SURGICALDETAIL.RELATIONSHIP_39_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SURGICALDETAIL')
            and   type = 'U')
   drop table SURGICALDETAIL
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TESTCERTIFICATE')
            and   name  = 'RELATIONSHIP_42_FK'
            and   indid > 0
            and   indid < 255)
   drop index TESTCERTIFICATE.RELATIONSHIP_42_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TESTCERTIFICATE')
            and   name  = 'RELATIONSHIP_41_FK'
            and   indid > 0
            and   indid < 255)
   drop index TESTCERTIFICATE.RELATIONSHIP_41_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TESTCERTIFICATE')
            and   type = 'U')
   drop table TESTCERTIFICATE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TESTDETAIL')
            and   name  = 'RELATIONSHIP_33_FK'
            and   indid > 0
            and   indid < 255)
   drop index TESTDETAIL.RELATIONSHIP_33_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TESTDETAIL')
            and   name  = 'RELATIONSHIP_32_FK'
            and   indid > 0
            and   indid < 255)
   drop index TESTDETAIL.RELATIONSHIP_32_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TESTDETAIL')
            and   type = 'U')
   drop table TESTDETAIL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TESTTYPE')
            and   type = 'U')
   drop table TESTTYPE
go

/*==============================================================*/
/* Table: ASSIGNMENT                                            */
/*==============================================================*/
create table ASSIGNMENT (
   ASSIGNID             numeric(8)           not null,
   DATE                 datetime             null,
   DISCHARGEDDATE       datetime             null,
   HOPITALIZATEDATE     datetime             null,
   constraint PK_ASSIGNMENT primary key nonclustered (ASSIGNID)
)
go

/*==============================================================*/
/* Table: ASSIGNMENTDETAIL                                      */
/*==============================================================*/
create table ASSIGNMENTDETAIL (
   PATIENTID            numeric(8)           null,
   ASSIGNID             numeric(8)           null,
   STAFFID              numeric(8)           null
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_1_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_1_FK on ASSIGNMENTDETAIL (
ASSIGNID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_12_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_12_FK on ASSIGNMENTDETAIL (
PATIENTID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_34_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_34_FK on ASSIGNMENTDETAIL (
STAFFID ASC
)
go

/*==============================================================*/
/* Table: BILL                                                  */
/*==============================================================*/
create table BILL (
   BILLID               numeric(8)           not null,
   BILLTYPEID           numeric(3)           null,
   PATIENTID            numeric(8)           null,
   STAFFID              numeric(8)           null,
   DATE                 datetime             null,
   TOTALPRICE           money                null,
   STATE                int                  null,
   constraint PK_BILL primary key nonclustered (BILLID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_14_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_14_FK on BILL (
PATIENTID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_31_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_31_FK on BILL (
STAFFID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_43_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_43_FK on BILL (
BILLTYPEID ASC
)
go

/*==============================================================*/
/* Table: BILLTYPE                                              */
/*==============================================================*/
create table BILLTYPE (
   BILLTYPEID           numeric(3)           not null,
   TYPENAME             varchar(100)         null,
   constraint PK_BILLTYPE primary key nonclustered (BILLTYPEID)
)
go

/*==============================================================*/
/* Table: DEPARTMENT                                            */
/*==============================================================*/
create table DEPARTMENT (
   DEPARTMENTID         numeric(3)           not null,
   DEPARTMENTNAME       varchar(100)         null,
   constraint PK_DEPARTMENT primary key nonclustered (DEPARTMENTID)
)
go

/*==============================================================*/
/* Table: DISCHARGEDCERTIFICATE                                 */
/*==============================================================*/
create table DISCHARGEDCERTIFICATE (
   DCID                 numeric(8)           not null,
   STAFFID              numeric(8)           null,
   PATIENTID            numeric(8)           null,
   DATE                 datetime             null,
   STATE                int                  null,
   constraint PK_DISCHARGEDCERTIFICATE primary key nonclustered (DCID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_19_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_19_FK on DISCHARGEDCERTIFICATE (
PATIENTID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_35_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_35_FK on DISCHARGEDCERTIFICATE (
STAFFID ASC
)
go

/*==============================================================*/
/* Table: DISEASE                                               */
/*==============================================================*/
create table DISEASE (
   DISEASEID            int                  not null,
   DISEASENAME          varchar(100)         null,
   SYMPTOM              varchar(1000)        null,
   constraint PK_DISEASE primary key nonclustered (DISEASEID)
)
go

/*==============================================================*/
/* Table: EXAMINATIONCERTIFICATE                                */
/*==============================================================*/
create table EXAMINATIONCERTIFICATE (
   ECID                 numeric(8)           not null,
   PATIENTID            numeric(8)           null,
   STAFFID              numeric(8)           null,
   DATE                 datetime             null,
   RESULT               varchar(1000)        null,
   STATE                int                  null,
   constraint PK_EXAMINATIONCERTIFICATE primary key nonclustered (ECID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_18_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_18_FK on EXAMINATIONCERTIFICATE (
PATIENTID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_36_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_36_FK on EXAMINATIONCERTIFICATE (
STAFFID ASC
)
go

/*==============================================================*/
/* Table: HEATHFILE                                             */
/*==============================================================*/
create table HEATHFILE (
   HEATHFILEID          numeric(8)           not null,
   PATIENTID            numeric(8)           null,
   DATE                 datetime             null,
   PATIENTSTATE         varchar(1000)        null,
   PREHISTORY           varchar(1000)        null,
   DISEASE              varchar(1000)        null,
   TREATMENT            varchar(1000)        null,
   constraint PK_HEATHFILE primary key nonclustered (HEATHFILEID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_16_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_16_FK on HEATHFILE (
PATIENTID ASC
)
go

/*==============================================================*/
/* Table: HEATHMONITORINGNOTE                                   */
/*==============================================================*/
create table HEATHMONITORINGNOTE (
   HNID                 numeric(8)           not null,
   PATIENTID            numeric(8)           null,
   STAFFID              numeric(8)           null,
   DATE                 datetime             null,
   WEIGHT               varchar(100)         null,
   BLOODPRESSURE        varchar(100)         null,
   PATIENTSTATE         varchar(1000)        null,
   constraint PK_HEATHMONITORINGNOTE primary key nonclustered (HNID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_17_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_17_FK on HEATHMONITORINGNOTE (
PATIENTID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_37_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_37_FK on HEATHMONITORINGNOTE (
STAFFID ASC
)
go

/*==============================================================*/
/* Table: HIC                                                   */
/*==============================================================*/
create table HIC (
   HICID                numeric(9)           not null,
   PATIENTID            numeric(8)           not null,
   EXPIREDATE           datetime             null,
   ISSUEDATE            datetime             null,
   constraint PK_HIC primary key nonclustered (HICID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_45_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_45_FK on HIC (
PATIENTID ASC
)
go

/*==============================================================*/
/* Table: HOSPITALBED                                           */
/*==============================================================*/
create table HOSPITALBED (
   BEDID                numeric(3)           not null,
   PATIENT              numeric(8)           null,
   STATE                int                  null,
   constraint PK_HOSPITALBED primary key nonclustered (BEDID)
)
go

/*==============================================================*/
/* Table: HOSPITALIZATIONCERTIFICATE                            */
/*==============================================================*/
create table HOSPITALIZATIONCERTIFICATE (
   HCID                 numeric(8)           not null,
   PATIENTID            numeric(8)           null,
   STAFFID              numeric(8)           null,
   REASON               varchar(1000)        null,
   DATE                 datetime             null,
   STATE                int                  null,
   constraint PK_HOSPITALIZATIONCERTIFICATE primary key nonclustered (HCID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_48_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_48_FK on HOSPITALIZATIONCERTIFICATE (
STAFFID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_49_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_49_FK on HOSPITALIZATIONCERTIFICATE (
PATIENTID ASC
)
go

/*==============================================================*/
/* Table: MAJOR                                                 */
/*==============================================================*/
create table MAJOR (
   MAJORID              numeric(3)           not null,
   MAJORNAME            varchar(100)         null,
   constraint PK_MAJOR primary key nonclustered (MAJORID)
)
go

/*==============================================================*/
/* Table: MATERIAL                                              */
/*==============================================================*/
create table MATERIAL (
   MATERIALID           numeric(3)           not null,
   MATERIALNAME         text                 null,
   QUANTITY             int                  null,
   PRICE                money                null,
   constraint PK_MATERIAL primary key nonclustered (MATERIALID)
)
go

/*==============================================================*/
/* Table: MEDICINE                                              */
/*==============================================================*/
create table MEDICINE (
   MEDICINEID           numeric(6)           not null,
   MEDICINENAME         varchar(100)         null,
   QUANTITY             int                  null,
   PRICE                money                null,
   constraint PK_MEDICINE primary key nonclustered (MEDICINEID)
)
go

/*==============================================================*/
/* Table: MEDICINEBILLDETAIL                                    */
/*==============================================================*/
create table MEDICINEBILLDETAIL (
   MEDICINEID           numeric(6)           not null,
   BILLID               numeric(8)           null,
   QUANTITY             int                  null,
   PRICE                money                null
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_10_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_10_FK on MEDICINEBILLDETAIL (
MEDICINEID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_44_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_44_FK on MEDICINEBILLDETAIL (
BILLID ASC
)
go

/*==============================================================*/
/* Table: PATIENT                                               */
/*==============================================================*/
create table PATIENT (
   PATIENTID            numeric(8)           not null,
   FIRSTNAME            varchar(100)         null,
   LASTNAME             varchar(100)         null,
   BIRTHDAY             datetime             null,
   GENDER               int                  null,
   ICN                  numeric(9)           null,
   PROFESSION           varchar(100)         null,
   ADDRESS              varchar(100)         null,
   DEPOSIT              money                null,
   STATE                int                  null,
   constraint PK_PATIENT primary key nonclustered (PATIENTID)
)
go

/*==============================================================*/
/* Table: PRESCRIPTION                                          */
/*==============================================================*/
create table PRESCRIPTION (
   PRESCRIPTIONID       numeric(8)           not null,
   STAFFID              numeric(8)           null,
   PATIENTID            numeric(8)           null,
   DATE                 datetime             null,
   constraint PK_PRESCRIPTION primary key nonclustered (PRESCRIPTIONID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_20_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_20_FK on PRESCRIPTION (
PATIENTID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_29_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_29_FK on PRESCRIPTION (
STAFFID ASC
)
go

/*==============================================================*/
/* Table: PRESCRIPTIONDETAIL                                    */
/*==============================================================*/
create table PRESCRIPTIONDETAIL (
   MEDICINEID           numeric(6)           null,
   PRESCRIPTIONID       numeric(8)           null,
   QUANTITY             int                  null,
   INSTRUCTION          varchar(100)         null
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_21_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_21_FK on PRESCRIPTIONDETAIL (
MEDICINEID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_22_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_22_FK on PRESCRIPTIONDETAIL (
PRESCRIPTIONID ASC
)
go

/*==============================================================*/
/* Table: RENTMATERIALBILLDETAIL                                */
/*==============================================================*/
create table RENTMATERIALBILLDETAIL (
   BILLID               numeric(8)           null,
   MATERIALID           numeric(3)           not null,
   QUANTITY             int                  null,
   PRICE                money                null
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_7_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_7_FK on RENTMATERIALBILLDETAIL (
MATERIALID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_47_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_47_FK on RENTMATERIALBILLDETAIL (
BILLID ASC
)
go

/*==============================================================*/
/* Table: ROLE                                                  */
/*==============================================================*/
create table ROLE (
   ROLEID               numeric(3)           not null,
   ROLENAME             varchar(100)         null,
   constraint PK_ROLE primary key nonclustered (ROLEID)
)
go

/*==============================================================*/
/* Table: ROLEDETAIL                                            */
/*==============================================================*/
create table ROLEDETAIL (
   ROLEID               numeric(3)           not null,
   ROLEFUNCTIONID       numeric(3)           not null
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_3_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_3_FK on ROLEDETAIL (
ROLEID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_4_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_4_FK on ROLEDETAIL (
ROLEFUNCTIONID ASC
)
go

/*==============================================================*/
/* Table: ROLEFUNCTION                                          */
/*==============================================================*/
create table ROLEFUNCTION (
   ROLEFUNCTIONID       numeric(3)           not null,
   ROLEFUNCTIONNAME     varchar(100)         null,
   "FUNCTION"           varchar(50)          null,
   constraint PK_ROLEFUNCTION primary key nonclustered (ROLEFUNCTIONID)
)
go

/*==============================================================*/
/* Table: SERVICE                                               */
/*==============================================================*/
create table SERVICE (
   SERVICEID            numeric(3)           not null,
   SERVICENAME          varchar(100)         null,
   PRICE                money                null,
   constraint PK_SERVICE primary key nonclustered (SERVICEID)
)
go

/*==============================================================*/
/* Table: SERVICEBILLDETAIL                                     */
/*==============================================================*/
create table SERVICEBILLDETAIL (
   BILLID               numeric(8)           null,
   SERVICEID            numeric(3)           null,
   QUANTITY             int                  null,
   PRICE                money                null
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_25_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_25_FK on SERVICEBILLDETAIL (
SERVICEID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_46_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_46_FK on SERVICEBILLDETAIL (
BILLID ASC
)
go

/*==============================================================*/
/* Table: STAFF                                                 */
/*==============================================================*/
create table STAFF (
   STAFFID              numeric(8)           not null,
   DEPARTMENTID         numeric(3)           null,
   MAJORID              numeric(3)           null,
   ROLEID               numeric(3)           null,
   PASSWORD             char(100)            null,
   FIRSTNAME            varchar(100)         null,
   LASTNAME             varchar(100)         null,
   BIRTHDAY             datetime             null,
   GENDER               int                  null,
   ICN                  numeric(9)           null,
   ADDRESS              varchar(100)         null,
   STATE                int                  null,
   constraint PK_STAFF primary key nonclustered (STAFFID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_26_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_26_FK on STAFF (
DEPARTMENTID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_27_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_27_FK on STAFF (
MAJORID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_28_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_28_FK on STAFF (
ROLEID ASC
)
go

/*==============================================================*/
/* Table: SURGICAL                                              */
/*==============================================================*/
create table SURGICAL (
   SURGICALID           numeric(8)           not null,
   PATIENTID            numeric(8)           null,
   DATE                 datetime             null,
   DESCRIPTION          varchar(1000)        null,
   STATE                int                  null,
   constraint PK_SURGICAL primary key nonclustered (SURGICALID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_38_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_38_FK on SURGICAL (
PATIENTID ASC
)
go

/*==============================================================*/
/* Table: SURGICALDETAIL                                        */
/*==============================================================*/
create table SURGICALDETAIL (
   SURGICALID           numeric(8)           null,
   STAFFID              numeric(8)           null
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_39_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_39_FK on SURGICALDETAIL (
SURGICALID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_40_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_40_FK on SURGICALDETAIL (
STAFFID ASC
)
go

/*==============================================================*/
/* Table: TESTCERTIFICATE                                       */
/*==============================================================*/
create table TESTCERTIFICATE (
   TCID                 numeric(8)           not null,
   PATIENTID            numeric(8)           null,
   STAFFID              numeric(8)           null,
   DATE                 datetime             null,
   STATE                int                  null,
   constraint PK_TESTCERTIFICATE primary key nonclustered (TCID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_41_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_41_FK on TESTCERTIFICATE (
STAFFID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_42_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_42_FK on TESTCERTIFICATE (
PATIENTID ASC
)
go

/*==============================================================*/
/* Table: TESTDETAIL                                            */
/*==============================================================*/
create table TESTDETAIL (
   TESTTYPEID           numeric(3)           null,
   TCID                 numeric(8)           null,
   RESULT               varchar(1000)        null
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_32_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_32_FK on TESTDETAIL (
TCID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_33_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_33_FK on TESTDETAIL (
TESTTYPEID ASC
)
go

/*==============================================================*/
/* Table: TESTTYPE                                              */
/*==============================================================*/
create table TESTTYPE (
   TESTTYPEID           numeric(3)           not null,
   TYPENAME             varchar(100)         null,
   constraint PK_TESTTYPE primary key nonclustered (TESTTYPEID)
)
go

alter table ASSIGNMENTDETAIL
   add constraint FK_ASSIGNME_RELATIONS_ASSIGNME foreign key (ASSIGNID)
      references ASSIGNMENT (ASSIGNID)
go

alter table ASSIGNMENTDETAIL
   add constraint FK_ASSIGNME_RELATIONS_PATIENT foreign key (PATIENTID)
      references PATIENT (PATIENTID)
go

alter table ASSIGNMENTDETAIL
   add constraint FK_ASSIGNME_RELATIONS_STAFF foreign key (STAFFID)
      references STAFF (STAFFID)
go

alter table BILL
   add constraint FK_BILL_RELATIONS_PATIENT foreign key (PATIENTID)
      references PATIENT (PATIENTID)
go

alter table BILL
   add constraint FK_BILL_RELATIONS_STAFF foreign key (STAFFID)
      references STAFF (STAFFID)
go

alter table BILL
   add constraint FK_BILL_RELATIONS_BILLTYPE foreign key (BILLTYPEID)
      references BILLTYPE (BILLTYPEID)
go

alter table DISCHARGEDCERTIFICATE
   add constraint FK_DISCHARG_RELATIONS_PATIENT foreign key (PATIENTID)
      references PATIENT (PATIENTID)
go

alter table DISCHARGEDCERTIFICATE
   add constraint FK_DISCHARG_RELATIONS_STAFF foreign key (STAFFID)
      references STAFF (STAFFID)
go

alter table EXAMINATIONCERTIFICATE
   add constraint FK_EXAMINAT_RELATIONS_PATIENT foreign key (PATIENTID)
      references PATIENT (PATIENTID)
go

alter table EXAMINATIONCERTIFICATE
   add constraint FK_EXAMINAT_RELATIONS_STAFF foreign key (STAFFID)
      references STAFF (STAFFID)
go

alter table HEATHFILE
   add constraint FK_HEATHFIL_RELATIONS_PATIENT foreign key (PATIENTID)
      references PATIENT (PATIENTID)
go

alter table HEATHMONITORINGNOTE
   add constraint FK_HEATHMON_RELATIONS_PATIENT foreign key (PATIENTID)
      references PATIENT (PATIENTID)
go

alter table HEATHMONITORINGNOTE
   add constraint FK_HEATHMON_RELATIONS_STAFF foreign key (STAFFID)
      references STAFF (STAFFID)
go

alter table HIC
   add constraint FK_HIC_RELATIONS_PATIENT foreign key (PATIENTID)
      references PATIENT (PATIENTID)
go

alter table HOSPITALIZATIONCERTIFICATE
   add constraint FK_HOSPITAL_RELATIONS_STAFF foreign key (STAFFID)
      references STAFF (STAFFID)
go

alter table HOSPITALIZATIONCERTIFICATE
   add constraint FK_HOSPITAL_RELATIONS_PATIENT foreign key (PATIENTID)
      references PATIENT (PATIENTID)
go

alter table MEDICINEBILLDETAIL
   add constraint FK_MEDICINE_RELATIONS_MEDICINE foreign key (MEDICINEID)
      references MEDICINE (MEDICINEID)
go

alter table MEDICINEBILLDETAIL
   add constraint FK_MEDICINE_RELATIONS_BILL foreign key (BILLID)
      references BILL (BILLID)
go

alter table PRESCRIPTION
   add constraint FK_PRESCRIP_RELATIONS_PATIENT foreign key (PATIENTID)
      references PATIENT (PATIENTID)
go

alter table PRESCRIPTION
   add constraint FK_PRESCRIP_RELATIONS_STAFF foreign key (STAFFID)
      references STAFF (STAFFID)
go

alter table PRESCRIPTIONDETAIL
   add constraint FK_PRESCRIP_RELATIONS_MEDICINE foreign key (MEDICINEID)
      references MEDICINE (MEDICINEID)
go

alter table PRESCRIPTIONDETAIL
   add constraint FK_PRESCRIP_RELATIONS_PRESCRIP foreign key (PRESCRIPTIONID)
      references PRESCRIPTION (PRESCRIPTIONID)
go

alter table RENTMATERIALBILLDETAIL
   add constraint FK_RENTMATE_RELATIONS_BILL foreign key (BILLID)
      references BILL (BILLID)
go

alter table RENTMATERIALBILLDETAIL
   add constraint FK_RENTMATE_RELATIONS_MATERIAL foreign key (MATERIALID)
      references MATERIAL (MATERIALID)
go

alter table ROLEDETAIL
   add constraint FK_ROLEDETA_RELATIONS_ROLE foreign key (ROLEID)
      references ROLE (ROLEID)
go

alter table ROLEDETAIL
   add constraint FK_ROLEDETA_RELATIONS_ROLEFUNC foreign key (ROLEFUNCTIONID)
      references ROLEFUNCTION (ROLEFUNCTIONID)
go

alter table SERVICEBILLDETAIL
   add constraint FK_SERVICEB_RELATIONS_SERVICE foreign key (SERVICEID)
      references SERVICE (SERVICEID)
go

alter table SERVICEBILLDETAIL
   add constraint FK_SERVICEB_RELATIONS_BILL foreign key (BILLID)
      references BILL (BILLID)
go

alter table STAFF
   add constraint FK_STAFF_RELATIONS_DEPARTME foreign key (DEPARTMENTID)
      references DEPARTMENT (DEPARTMENTID)
go

alter table STAFF
   add constraint FK_STAFF_RELATIONS_MAJOR foreign key (MAJORID)
      references MAJOR (MAJORID)
go

alter table STAFF
   add constraint FK_STAFF_RELATIONS_ROLE foreign key (ROLEID)
      references ROLE (ROLEID)
go

alter table SURGICAL
   add constraint FK_SURGICAL_RELATIONS_PATIENT foreign key (PATIENTID)
      references PATIENT (PATIENTID)
go

alter table SURGICALDETAIL
   add constraint FK_SURGICAL_RELATIONS_SURGICAL foreign key (SURGICALID)
      references SURGICAL (SURGICALID)
go

alter table SURGICALDETAIL
   add constraint FK_SURGICAL_RELATIONS_STAFF foreign key (STAFFID)
      references STAFF (STAFFID)
go

alter table TESTCERTIFICATE
   add constraint FK_TESTCERT_RELATIONS_STAFF foreign key (STAFFID)
      references STAFF (STAFFID)
go

alter table TESTCERTIFICATE
   add constraint FK_TESTCERT_RELATIONS_PATIENT foreign key (PATIENTID)
      references PATIENT (PATIENTID)
go

alter table TESTDETAIL
   add constraint FK_TESTDETA_RELATIONS_TESTCERT foreign key (TCID)
      references TESTCERTIFICATE (TCID)
go

alter table TESTDETAIL
   add constraint FK_TESTDETA_RELATIONS_TESTTYPE foreign key (TESTTYPEID)
      references TESTTYPE (TESTTYPEID)
go

