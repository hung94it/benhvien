/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2005                    */
/* Created on:     06/05/2012 9:33:12 AM                        */
/*==============================================================*/


/*==============================================================*/
/* Table: ASSIGNMENT                                            */
/*==============================================================*/
create table ASSIGNMENT (
   ASSIGNID             numeric(8)   identity(10000000,1)        not null,
   DATE                 smalldatetime             null,
   DISCHARGEDDATE       smalldatetime             null,
   HOPITALIZATEDATE     smalldatetime             null,
   constraint PK_ASSIGNMENT primary key nonclustered (ASSIGNID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_1_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_1_FK on ASSIGNMENT (
ASSIGNID ASC
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
/* Index: RELATIONSHIP_34_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_34_FK on ASSIGNMENTDETAIL (
STAFFID ASC
)
go
go

/*==============================================================*/
/* Table: BILL                                                  */
/*==============================================================*/
create table BILL (
   BILLID               numeric(8)    identity(10000000,1)      not null,
   BILLTYPEID           numeric(3)           null,
   PATIENTID            numeric(8)           null,
   STAFFID              numeric(8)           null,
   DATE                 smalldatetime             null,
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
   BILLTYPEID           numeric(3)      identity(100,1)     not null,
   TYPENAME             nvarchar(100)         null,
   constraint PK_BILLTYPE primary key nonclustered (BILLTYPEID)
)
go

/*==============================================================*/
/* Table: ROLE                                      */
/*==============================================================*/
create table ROLE (
   ROLEID   numeric(3)     identity(100,1)      not null,
   ROLENAME nvarchar(100)         null,
   constraint PK_ROLE primary key nonclustered (ROLEID)
)
go


/*==============================================================*/
/* Table: ROLEDETAIL                                */
/*==============================================================*/
create table ROLEDETAIL (
   ROLEID   numeric(3)           not null,
   FUNCTIONID           numeric(3)           not null
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
FUNCTIONID ASC
)
go

/*==============================================================*/
/* Table: DEPARTMENT                                            */
/*==============================================================*/
create table DEPARTMENT (
   DEPARTMENTID         numeric(3)      identity(100,1)     not null,
   DEPARTMENTNAME       nvarchar(100)         null,
   constraint PK_DEPARTMENT primary key nonclustered (DEPARTMENTID)
)
go

/*==============================================================*/
/* Table: DISCHARGEDCERTIFICATE                                 */
/*==============================================================*/
create table DISCHARGEDCERTIFICATE (
   DCID                 numeric(8)      identity(10000000,1)     not null,
   STAFFID              numeric(8)           null,
   PATIENTID            numeric(8)           null,
   DATE                 smalldatetime             null,
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
   DISEASEID            numeric(3)      identity(100,1)     not null,
   DISEASENAME          nvarchar(100)                 null,
   SYMPTOM              nvarchar(1000)                 null,
   constraint PK_DISEASE primary key nonclustered (DISEASEID)
)
go

/*==============================================================*/
/* Table: EXAMINATIONCERTIFICATE                                */
/*==============================================================*/
create table EXAMINATIONCERTIFICATE (
   ECID                 numeric(8)      identity(10000000,1)     not null,
   PATIENTID            numeric(8)           null,
   STAFFID              numeric(8)           null,
   DATE                 smalldatetime             null,
   RESULT               nvarchar(1000)        null,
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
/* Table: "FUNCTION"                                            */
/*==============================================================*/
create table ROLEFUNCTION (
   FUNCTIONID           numeric(3)      identity(100,1)     not null,
   FUNCTIONNAME         nvarchar(100)         null,
   BUTTON               nvarchar(50)          null,
   constraint PK_FUNCTION primary key nonclustered (FUNCTIONID)
)
go

/*==============================================================*/
/* Table: HEATHFILE                                             */
/*==============================================================*/
create table HEATHFILE (
   HEATHFILEID          numeric(8)    identity(10000000,1)       not null,
   PATIENTID            numeric(8)           null,
   DATE                 smalldatetime             null,
   PATIENTSTATE         nvarchar(1000)        null,
   PREHISTORY           nvarchar(1000)        null,
   DISEASE              nvarchar(1000)        null,
   TREATMENT            nvarchar(1000)        null,
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
   HNID                 numeric(8)     identity(10000000,1)      not null,
   PATIENTID            numeric(8)           null,
   STAFFID              numeric(8)           null,
   DATE                 smalldatetime             null,
   WEIGHT               nvarchar(100)         null,
   BLOODPRESSURE        nvarchar(100)         null,
   PATIENTSTATE         nvarchar(1000)        null,
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
   EXPIREDATE           smalldatetime             null,
   ISSUEDATE            smalldatetime             null,
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
   BEDID                numeric(3)     identity(1,1)      not null,
   PATIENT              numeric(8)           null,
   STATE                int                  null,
   constraint PK_HOSPITALBED primary key nonclustered (BEDID)
)
go

/*==============================================================*/
/* Table: HOSPITALIZATIONCERTIFICATE                            */
/*==============================================================*/
create table HOSPITALIZATIONCERTIFICATE (
   HCID                 numeric(8)     identity(10000000,1)      not null,
   PATIENTID            numeric(8)           null,
   STAFFID              numeric(8)           null,
   REASON               nvarchar(1000)        null,
   DATE                 smalldatetime             null,
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
   MAJORID              numeric(3)     identity(100,1)      not null,
   MAJORNAME            nvarchar(100)         null,
   constraint PK_MAJOR primary key nonclustered (MAJORID)
)
go

/*==============================================================*/
/* Table: MATERIAL                                              */
/*==============================================================*/
create table MATERIAL (
   MATERIALID           numeric(3)       identity(100,1)    not null,
   MATERIALNAME         nvarchar(100)                 null,
   QUANTITY             int                  null,
   PRICE                money                null,
   constraint PK_MATERIAL primary key nonclustered (MATERIALID)
)
go

/*==============================================================*/
/* Table: MEDICINE                                              */
/*==============================================================*/
create table MEDICINE (
   MEDICINEID           numeric(6)      identity(100000,1)     not null,
   MEDICINENAME         nvarchar(100)         null,
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
   PATIENTID            numeric(8)     identity(10000000,1)      not null,
   FIRSTNAME            nvarchar(100)         null,
   LASTNAME             nvarchar(100)         null,
   BIRTHDAY             smalldatetime             null,
   GENDER               int                  null,
   ICN                  numeric(9)           null,
   PROFESSION           nvarchar(100)         null,
   ADDRESS              nvarchar(100)         null,
   DEPOSIT              money                null,
   STATE                int                  null,
   constraint PK_PATIENT primary key nonclustered (PATIENTID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_12_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_12_FK on PATIENT (
PATIENTID ASC
)
go

/*==============================================================*/
/* Table: PRESCRIPTION                                          */
/*==============================================================*/
create table PRESCRIPTION (
   PRESCRIPTIONID       numeric(8)     identity(10000000,1)      not null,
   STAFFID              numeric(8)           null,
   PATIENTID            numeric(8)           null,
   DATE                 smalldatetime             null,
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
   INSTRUCTION          nvarchar(100)         null
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
/* Table: SERVICE                                               */
/*==============================================================*/
create table SERVICE (
   SERVICEID            numeric(3)       identity(100,1)    not null,
   SERVICENAME          nvarchar(100)         null,
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
   STAFFID              numeric(8)      identity(10000000,1)     not null,
   DEPARTMENTID         numeric(3)           null,
   MAJORID              numeric(3)           null,
   ROLEID   numeric(3)           null,
   PASSWORD             char(100)            null,
   FIRSTNAME            nvarchar(100)         null,
   LASTNAME             nvarchar(100)         null,
   BIRTHDAY             smalldatetime             null,
   GENDER               int                  null,
   ICN                  numeric(9)           null,
   ADDRESS              nvarchar(100)         null,
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
   SURGICALID           numeric(8)      identity(10000000,1)     not null,
   PATIENTID            numeric(8)           null,
   DATE                 smalldatetime             null,
   DESCRIPTION          nvarchar(1000)        null,
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
   TCID                 numeric(8)      identity(10000000,1)     not null,
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
   RESULT               nvarchar(1000)        null
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
   TESTTYPEID           numeric(3)     identity(100,1)      not null,
   TYPENAME             nvarchar(100)         null,
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

alter table ROLEDETAIL
   add constraint FK_ROLEDETAIL_RELATIONS_ROLE foreign key (ROLEID)
      references ROLE (ROLEID)
go

alter table ROLEDETAIL
   add constraint FK_ROLEDETAIL_RELATIONS_ROLEFUNCTION foreign key (FUNCTIONID)
      references ROLEFUNCTION (FUNCTIONID)
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

