USE [TP_Guitar]
GO
/****** Object:  Table [dbo].[COMMANDE]    Script Date: 27/05/2020 18:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COMMANDE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NOMCLIENT] [char](32) NULL,
	[DATE_COMMANDE] [char](32) NULL,
	[MONTANT] [char](32) NULL,
	[TELEPHONECLIENT] [char](32) NULL,
 CONSTRAINT [PK_COMMANDE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TYPEBOIS]    Script Date: 27/05/2020 18:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TYPEBOIS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NOMTYPEBOIS] [char](32) NOT NULL,
 CONSTRAINT [PK_TYPEBOIS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VIBRATO]    Script Date: 27/05/2020 18:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VIBRATO](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NOMVIBRATO] [char](32) NOT NULL,
 CONSTRAINT [PK_VIBRATO] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GUITAR]    Script Date: 27/05/2020 18:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GUITAR](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_FONCTIONNE1] [int] NOT NULL,
	[ID_FONCTIONNE2] [int] NULL,
	[ID_FONCTIONNE3] [int] NOT NULL,
	[ID_UTILISERMANCHE] [int] NOT NULL,
	[ID_UTILISERTOUCHE] [int] NOT NULL,
	[ID_UTILISERCORPS] [int] NOT NULL,
	[ID_POSSÈDER] [int] NULL,
	[NOMGUITAR] [varchar](128) NOT NULL,
	[IDCOMMANDE] [int] NULL,
 CONSTRAINT [PK_GUITAR] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MICROS]    Script Date: 27/05/2020 18:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MICROS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CONSTRUCTEUR] [char](32) NOT NULL,
 CONSTRAINT [PK_MICROS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Vue_Guitar]    Script Date: 27/05/2020 18:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Vue_Guitar]
AS
SELECT        dbo.GUITAR.NOMGUITAR, dbo.MICROS.CONSTRUCTEUR AS M_Pos_1, MICROS_1.CONSTRUCTEUR AS M_Pos_2, MICROS_2.CONSTRUCTEUR AS M_Pos_3, TYPEBOIS_1.NOMTYPEBOIS AS Bois_Corps, 
                         TYPEBOIS_3.NOMTYPEBOIS AS Bois_Touche, TYPEBOIS_2.NOMTYPEBOIS AS Bois_Manche, dbo.VIBRATO.NOMVIBRATO, dbo.GUITAR.IDCOMMANDE
FROM            dbo.COMMANDE INNER JOIN
                         dbo.GUITAR ON dbo.COMMANDE.ID = dbo.GUITAR.IDCOMMANDE INNER JOIN
                         dbo.MICROS ON dbo.GUITAR.ID_FONCTIONNE1 = dbo.MICROS.ID INNER JOIN
                         dbo.VIBRATO ON dbo.GUITAR.ID_POSSÈDER = dbo.VIBRATO.ID INNER JOIN
                         dbo.MICROS AS MICROS_1 ON dbo.GUITAR.ID_FONCTIONNE3 = MICROS_1.ID INNER JOIN
                         dbo.MICROS AS MICROS_2 ON dbo.GUITAR.ID_FONCTIONNE2 = MICROS_2.ID INNER JOIN
                         dbo.TYPEBOIS AS TYPEBOIS_1 ON dbo.GUITAR.ID_UTILISERMANCHE = TYPEBOIS_1.ID INNER JOIN
                         dbo.TYPEBOIS AS TYPEBOIS_2 ON dbo.GUITAR.ID_UTILISERTOUCHE = TYPEBOIS_2.ID INNER JOIN
                         dbo.TYPEBOIS AS TYPEBOIS_3 ON dbo.GUITAR.ID_UTILISERTOUCHE = TYPEBOIS_3.ID
GO
/****** Object:  View [dbo].[BonCommande]    Script Date: 27/05/2020 18:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[BonCommande]
AS
SELECT        dbo.GUITAR.IDCOMMANDE AS NroCommande, dbo.COMMANDE.NOMCLIENT AS Client, dbo.COMMANDE.TELEPHONECLIENT AS Telephone, dbo.GUITAR.NOMGUITAR, dbo.MICROS.CONSTRUCTEUR AS M_Pos_1, 
                         MICROS_1.CONSTRUCTEUR AS M_Pos_2, MICROS_2.CONSTRUCTEUR AS M_Pos_3, TYPEBOIS_1.NOMTYPEBOIS AS Bois_Corps, TYPEBOIS_3.NOMTYPEBOIS AS Bois_Touche, 
                         TYPEBOIS_2.NOMTYPEBOIS AS Bois_Manche, dbo.VIBRATO.NOMVIBRATO AS Vibrato, dbo.COMMANDE.DATE_COMMANDE AS DateCommande, dbo.COMMANDE.MONTANT AS MontantCommande
FROM            dbo.COMMANDE INNER JOIN
                         dbo.GUITAR ON dbo.COMMANDE.ID = dbo.GUITAR.IDCOMMANDE INNER JOIN
                         dbo.MICROS ON dbo.GUITAR.ID_FONCTIONNE1 = dbo.MICROS.ID INNER JOIN
                         dbo.VIBRATO ON dbo.GUITAR.ID_POSSÈDER = dbo.VIBRATO.ID INNER JOIN
                         dbo.MICROS AS MICROS_1 ON dbo.GUITAR.ID_FONCTIONNE3 = MICROS_1.ID INNER JOIN
                         dbo.MICROS AS MICROS_2 ON dbo.GUITAR.ID_FONCTIONNE2 = MICROS_2.ID INNER JOIN
                         dbo.TYPEBOIS AS TYPEBOIS_1 ON dbo.GUITAR.ID_UTILISERMANCHE = TYPEBOIS_1.ID INNER JOIN
                         dbo.TYPEBOIS AS TYPEBOIS_2 ON dbo.GUITAR.ID_UTILISERTOUCHE = TYPEBOIS_2.ID INNER JOIN
                         dbo.TYPEBOIS AS TYPEBOIS_3 ON dbo.GUITAR.ID_UTILISERTOUCHE = TYPEBOIS_3.ID
GO
/****** Object:  View [dbo].[CommandeGuitar]    Script Date: 27/05/2020 18:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[CommandeGuitar]
AS
SELECT        dbo.COMMANDE.ID AS NroCommande, dbo.COMMANDE.NOMCLIENT, dbo.COMMANDE.DATE_COMMANDE, dbo.COMMANDE.MONTANT, dbo.COMMANDE.TELEPHONECLIENT, dbo.Vue_Guitar.M_Pos_1, 
                         dbo.Vue_Guitar.M_Pos_2, dbo.Vue_Guitar.M_Pos_3, dbo.Vue_Guitar.NOMGUITAR AS Expr2, dbo.Vue_Guitar.Bois_Corps, dbo.Vue_Guitar.Bois_Touche, dbo.Vue_Guitar.Bois_Manche, dbo.Vue_Guitar.NOMVIBRATO
FROM            dbo.COMMANDE INNER JOIN
                         dbo.GUITAR ON dbo.COMMANDE.ID = dbo.GUITAR.ID CROSS JOIN
                         dbo.Vue_Guitar
GO
SET IDENTITY_INSERT [dbo].[COMMANDE] ON 

INSERT [dbo].[COMMANDE] ([ID], [NOMCLIENT], [DATE_COMMANDE], [MONTANT], [TELEPHONECLIENT]) VALUES (8, N'gvjbk                           ', N'qsfdfgnh                        ', N'20                              ', N'1651651                         ')
INSERT [dbo].[COMMANDE] ([ID], [NOMCLIENT], [DATE_COMMANDE], [MONTANT], [TELEPHONECLIENT]) VALUES (9, N'zsgb                            ', N'25/05/2020                      ', N'15                              ', N'sgdg                            ')
INSERT [dbo].[COMMANDE] ([ID], [NOMCLIENT], [DATE_COMMANDE], [MONTANT], [TELEPHONECLIENT]) VALUES (11, N'jose P                          ', N'25/05/2020                      ', N'15                              ', N'25754341                        ')
INSERT [dbo].[COMMANDE] ([ID], [NOMCLIENT], [DATE_COMMANDE], [MONTANT], [TELEPHONECLIENT]) VALUES (12, N'jose                            ', N'25/05/2020                      ', N'15                              ', N'6543484                         ')
INSERT [dbo].[COMMANDE] ([ID], [NOMCLIENT], [DATE_COMMANDE], [MONTANT], [TELEPHONECLIENT]) VALUES (13, N'efefs                           ', N'25/05/2020                      ', N'15                              ', N'984561                          ')
INSERT [dbo].[COMMANDE] ([ID], [NOMCLIENT], [DATE_COMMANDE], [MONTANT], [TELEPHONECLIENT]) VALUES (14, N'azegze                          ', N'25/05/2020                      ', N'15                              ', N'zezgetha                        ')
INSERT [dbo].[COMMANDE] ([ID], [NOMCLIENT], [DATE_COMMANDE], [MONTANT], [TELEPHONECLIENT]) VALUES (15, N'xvxb                            ', N'25/05/2020                      ', N'15                              ', N'846510                          ')
INSERT [dbo].[COMMANDE] ([ID], [NOMCLIENT], [DATE_COMMANDE], [MONTANT], [TELEPHONECLIENT]) VALUES (16, N'xvxb                            ', N'25/05/2020                      ', N'15                              ', N'846510                          ')
INSERT [dbo].[COMMANDE] ([ID], [NOMCLIENT], [DATE_COMMANDE], [MONTANT], [TELEPHONECLIENT]) VALUES (17, N'jose                            ', N'ihyqisbnd,                      ', N'8654651                         ', N'89465                           ')
INSERT [dbo].[COMMANDE] ([ID], [NOMCLIENT], [DATE_COMMANDE], [MONTANT], [TELEPHONECLIENT]) VALUES (18, N'sqgsgfh<dg                      ', N'25/05/2020                      ', N'15                              ', N'ffhfgjfgh                       ')
INSERT [dbo].[COMMANDE] ([ID], [NOMCLIENT], [DATE_COMMANDE], [MONTANT], [TELEPHONECLIENT]) VALUES (19, N'qsfgqdfg                        ', N'25/05/2020                      ', N'15                              ', N'qsdfqsdf                        ')
INSERT [dbo].[COMMANDE] ([ID], [NOMCLIENT], [DATE_COMMANDE], [MONTANT], [TELEPHONECLIENT]) VALUES (20, N'qsfgqdfg                        ', N'25/05/2020                      ', N'15                              ', N'qsdfqsdf                        ')
INSERT [dbo].[COMMANDE] ([ID], [NOMCLIENT], [DATE_COMMANDE], [MONTANT], [TELEPHONECLIENT]) VALUES (21, N'                                ', N'25/05/2020                      ', N'15                              ', N'                                ')
INSERT [dbo].[COMMANDE] ([ID], [NOMCLIENT], [DATE_COMMANDE], [MONTANT], [TELEPHONECLIENT]) VALUES (22, N'<dhbfd                          ', N'25/05/2020                      ', N'15                              ', N'sdfqsdfq                        ')
INSERT [dbo].[COMMANDE] ([ID], [NOMCLIENT], [DATE_COMMANDE], [MONTANT], [TELEPHONECLIENT]) VALUES (23, N'utvgjbnl                        ', N'25/05/2020                      ', N'15                              ', N'gvujbhk ,ml                     ')
INSERT [dbo].[COMMANDE] ([ID], [NOMCLIENT], [DATE_COMMANDE], [MONTANT], [TELEPHONECLIENT]) VALUES (24, N'dgswdfg                         ', N'25/05/2020                      ', N'15                              ', N'wdfsfh                          ')
INSERT [dbo].[COMMANDE] ([ID], [NOMCLIENT], [DATE_COMMANDE], [MONTANT], [TELEPHONECLIENT]) VALUES (26, N'wcvvbwf                         ', N'25/05/2020                      ', N'15                              ', N'bfgbfg                          ')
INSERT [dbo].[COMMANDE] ([ID], [NOMCLIENT], [DATE_COMMANDE], [MONTANT], [TELEPHONECLIENT]) VALUES (27, N'qsdf                            ', N'25/05/2020                      ', N'15                              ', N'qsdfsdqf                        ')
INSERT [dbo].[COMMANDE] ([ID], [NOMCLIENT], [DATE_COMMANDE], [MONTANT], [TELEPHONECLIENT]) VALUES (28, N'sdfsdf                          ', N'25/05/2020                      ', N'15                              ', N'sdfsdf                          ')
INSERT [dbo].[COMMANDE] ([ID], [NOMCLIENT], [DATE_COMMANDE], [MONTANT], [TELEPHONECLIENT]) VALUES (29, N'rgserg                          ', N'25/05/2020                      ', N'15                              ', N'zzrfsdff                        ')
SET IDENTITY_INSERT [dbo].[COMMANDE] OFF
SET IDENTITY_INSERT [dbo].[GUITAR] ON 

INSERT [dbo].[GUITAR] ([ID], [ID_FONCTIONNE1], [ID_FONCTIONNE2], [ID_FONCTIONNE3], [ID_UTILISERMANCHE], [ID_UTILISERTOUCHE], [ID_UTILISERCORPS], [ID_POSSÈDER], [NOMGUITAR], [IDCOMMANDE]) VALUES (2, 4, 2, 1, 3, 3, 7, 4, N'Guibson                         ', 11)
INSERT [dbo].[GUITAR] ([ID], [ID_FONCTIONNE1], [ID_FONCTIONNE2], [ID_FONCTIONNE3], [ID_UTILISERMANCHE], [ID_UTILISERTOUCHE], [ID_UTILISERCORPS], [ID_POSSÈDER], [NOMGUITAR], [IDCOMMANDE]) VALUES (3, 1, 2, 4, 1, 3, 6, 4, N'gibson 3000                     ', 12)
INSERT [dbo].[GUITAR] ([ID], [ID_FONCTIONNE1], [ID_FONCTIONNE2], [ID_FONCTIONNE3], [ID_UTILISERMANCHE], [ID_UTILISERTOUCHE], [ID_UTILISERCORPS], [ID_POSSÈDER], [NOMGUITAR], [IDCOMMANDE]) VALUES (4, 3, NULL, 3, 5, 3, 3, 4, N'sdfsdf                          ', 13)
INSERT [dbo].[GUITAR] ([ID], [ID_FONCTIONNE1], [ID_FONCTIONNE2], [ID_FONCTIONNE3], [ID_UTILISERMANCHE], [ID_UTILISERTOUCHE], [ID_UTILISERCORPS], [ID_POSSÈDER], [NOMGUITAR], [IDCOMMANDE]) VALUES (5, 4, 2, 1, 4, 3, 4, 4, N'aegrth                          ', 14)
INSERT [dbo].[GUITAR] ([ID], [ID_FONCTIONNE1], [ID_FONCTIONNE2], [ID_FONCTIONNE3], [ID_UTILISERMANCHE], [ID_UTILISERTOUCHE], [ID_UTILISERCORPS], [ID_POSSÈDER], [NOMGUITAR], [IDCOMMANDE]) VALUES (6, 2, 1, 4, 3, 2, 3, 4, N'sdfsdf                          ', 15)
INSERT [dbo].[GUITAR] ([ID], [ID_FONCTIONNE1], [ID_FONCTIONNE2], [ID_FONCTIONNE3], [ID_UTILISERMANCHE], [ID_UTILISERTOUCHE], [ID_UTILISERCORPS], [ID_POSSÈDER], [NOMGUITAR], [IDCOMMANDE]) VALUES (7, 2, 1, 4, 3, 2, 3, 4, N'sdfsdf                          ', 16)
INSERT [dbo].[GUITAR] ([ID], [ID_FONCTIONNE1], [ID_FONCTIONNE2], [ID_FONCTIONNE3], [ID_UTILISERMANCHE], [ID_UTILISERTOUCHE], [ID_UTILISERCORPS], [ID_POSSÈDER], [NOMGUITAR], [IDCOMMANDE]) VALUES (8, 2, 2, 2, 1, 1, 1, 2, N'dfgfd                           ', 17)
INSERT [dbo].[GUITAR] ([ID], [ID_FONCTIONNE1], [ID_FONCTIONNE2], [ID_FONCTIONNE3], [ID_UTILISERMANCHE], [ID_UTILISERTOUCHE], [ID_UTILISERCORPS], [ID_POSSÈDER], [NOMGUITAR], [IDCOMMANDE]) VALUES (9, 4, 1, 1, 3, 5, 6, 4, N's<dgdfhsg                       ', 18)
INSERT [dbo].[GUITAR] ([ID], [ID_FONCTIONNE1], [ID_FONCTIONNE2], [ID_FONCTIONNE3], [ID_UTILISERMANCHE], [ID_UTILISERTOUCHE], [ID_UTILISERCORPS], [ID_POSSÈDER], [NOMGUITAR], [IDCOMMANDE]) VALUES (10, 3, 1, 3, 4, 2, 5, 3, N'qsdfqsdf                        ', 19)
INSERT [dbo].[GUITAR] ([ID], [ID_FONCTIONNE1], [ID_FONCTIONNE2], [ID_FONCTIONNE3], [ID_UTILISERMANCHE], [ID_UTILISERTOUCHE], [ID_UTILISERCORPS], [ID_POSSÈDER], [NOMGUITAR], [IDCOMMANDE]) VALUES (11, 3, 1, 3, 4, 2, 5, 3, N'qsdfqsdf                        ', 20)
INSERT [dbo].[GUITAR] ([ID], [ID_FONCTIONNE1], [ID_FONCTIONNE2], [ID_FONCTIONNE3], [ID_UTILISERMANCHE], [ID_UTILISERTOUCHE], [ID_UTILISERCORPS], [ID_POSSÈDER], [NOMGUITAR], [IDCOMMANDE]) VALUES (13, 4, 2, 2, 2, 4, 3, 2, N'qdQSDQSd                        ', 22)
INSERT [dbo].[GUITAR] ([ID], [ID_FONCTIONNE1], [ID_FONCTIONNE2], [ID_FONCTIONNE3], [ID_UTILISERMANCHE], [ID_UTILISERTOUCHE], [ID_UTILISERCORPS], [ID_POSSÈDER], [NOMGUITAR], [IDCOMMANDE]) VALUES (14, 3, 1, 1, 4, 2, 5, 2, N'qdfgsf                          ', 23)
INSERT [dbo].[GUITAR] ([ID], [ID_FONCTIONNE1], [ID_FONCTIONNE2], [ID_FONCTIONNE3], [ID_UTILISERMANCHE], [ID_UTILISERTOUCHE], [ID_UTILISERCORPS], [ID_POSSÈDER], [NOMGUITAR], [IDCOMMANDE]) VALUES (15, 4, 3, 1, 7, 3, 3, 3, N'dghdjhgj                        ', 24)
INSERT [dbo].[GUITAR] ([ID], [ID_FONCTIONNE1], [ID_FONCTIONNE2], [ID_FONCTIONNE3], [ID_UTILISERMANCHE], [ID_UTILISERTOUCHE], [ID_UTILISERCORPS], [ID_POSSÈDER], [NOMGUITAR], [IDCOMMANDE]) VALUES (17, 4, 1, 2, 5, 7, 4, 3, N'dfdfqdb                         ', 26)
INSERT [dbo].[GUITAR] ([ID], [ID_FONCTIONNE1], [ID_FONCTIONNE2], [ID_FONCTIONNE3], [ID_UTILISERMANCHE], [ID_UTILISERTOUCHE], [ID_UTILISERCORPS], [ID_POSSÈDER], [NOMGUITAR], [IDCOMMANDE]) VALUES (18, 4, 1, 3, 6, 3, 2, 3, N'qsdfqsdf                        ', 27)
INSERT [dbo].[GUITAR] ([ID], [ID_FONCTIONNE1], [ID_FONCTIONNE2], [ID_FONCTIONNE3], [ID_UTILISERMANCHE], [ID_UTILISERTOUCHE], [ID_UTILISERCORPS], [ID_POSSÈDER], [NOMGUITAR], [IDCOMMANDE]) VALUES (19, 3, 1, 3, 3, 3, 3, 4, N'dfgsgd                          ', 28)
INSERT [dbo].[GUITAR] ([ID], [ID_FONCTIONNE1], [ID_FONCTIONNE2], [ID_FONCTIONNE3], [ID_UTILISERMANCHE], [ID_UTILISERTOUCHE], [ID_UTILISERCORPS], [ID_POSSÈDER], [NOMGUITAR], [IDCOMMANDE]) VALUES (20, 3, 2, 1, 3, 4, 4, 4, N'sdfsdfezf                       ', 29)
SET IDENTITY_INSERT [dbo].[GUITAR] OFF
SET IDENTITY_INSERT [dbo].[MICROS] ON 

INSERT [dbo].[MICROS] ([ID], [CONSTRUCTEUR]) VALUES (1, N'Samsung                         ')
INSERT [dbo].[MICROS] ([ID], [CONSTRUCTEUR]) VALUES (2, N'LG                              ')
INSERT [dbo].[MICROS] ([ID], [CONSTRUCTEUR]) VALUES (3, N'Huawei                          ')
INSERT [dbo].[MICROS] ([ID], [CONSTRUCTEUR]) VALUES (4, N'Yamaha                          ')
SET IDENTITY_INSERT [dbo].[MICROS] OFF
SET IDENTITY_INSERT [dbo].[TYPEBOIS] ON 

INSERT [dbo].[TYPEBOIS] ([ID], [NOMTYPEBOIS]) VALUES (1, N'AULNE                           ')
INSERT [dbo].[TYPEBOIS] ([ID], [NOMTYPEBOIS]) VALUES (2, N'ACAJOU                          ')
INSERT [dbo].[TYPEBOIS] ([ID], [NOMTYPEBOIS]) VALUES (3, N'FRENE                           ')
INSERT [dbo].[TYPEBOIS] ([ID], [NOMTYPEBOIS]) VALUES (4, N'ERABLE                          ')
INSERT [dbo].[TYPEBOIS] ([ID], [NOMTYPEBOIS]) VALUES (5, N'TILLEUL                         ')
INSERT [dbo].[TYPEBOIS] ([ID], [NOMTYPEBOIS]) VALUES (6, N'PEUPLIER                        ')
INSERT [dbo].[TYPEBOIS] ([ID], [NOMTYPEBOIS]) VALUES (7, N'PALISSANDRE                     ')
INSERT [dbo].[TYPEBOIS] ([ID], [NOMTYPEBOIS]) VALUES (8, N'ZEBRANO                         ')
INSERT [dbo].[TYPEBOIS] ([ID], [NOMTYPEBOIS]) VALUES (9, N'WENGE                           ')
INSERT [dbo].[TYPEBOIS] ([ID], [NOMTYPEBOIS]) VALUES (10, N'WALNUT                          ')
INSERT [dbo].[TYPEBOIS] ([ID], [NOMTYPEBOIS]) VALUES (11, N'AGATHIS                         ')
INSERT [dbo].[TYPEBOIS] ([ID], [NOMTYPEBOIS]) VALUES (12, N'NATO                            ')
SET IDENTITY_INSERT [dbo].[TYPEBOIS] OFF
SET IDENTITY_INSERT [dbo].[VIBRATO] ON 

INSERT [dbo].[VIBRATO] ([ID], [NOMVIBRATO]) VALUES (1, N'Bigsby                          ')
INSERT [dbo].[VIBRATO] ([ID], [NOMVIBRATO]) VALUES (2, N'Jazzmaster                      ')
INSERT [dbo].[VIBRATO] ([ID], [NOMVIBRATO]) VALUES (3, N'Maestro Vibrola                 ')
INSERT [dbo].[VIBRATO] ([ID], [NOMVIBRATO]) VALUES (4, N' type Floyd Rose                ')
SET IDENTITY_INSERT [dbo].[VIBRATO] OFF
ALTER TABLE [dbo].[COMMANDE]  WITH CHECK ADD  CONSTRAINT [FK_COMMANDE_COMMANDE] FOREIGN KEY([ID])
REFERENCES [dbo].[COMMANDE] ([ID])
GO
ALTER TABLE [dbo].[COMMANDE] CHECK CONSTRAINT [FK_COMMANDE_COMMANDE]
GO
ALTER TABLE [dbo].[GUITAR]  WITH CHECK ADD  CONSTRAINT [FK_GUITAR_COMMANDE1] FOREIGN KEY([IDCOMMANDE])
REFERENCES [dbo].[COMMANDE] ([ID])
GO
ALTER TABLE [dbo].[GUITAR] CHECK CONSTRAINT [FK_GUITAR_COMMANDE1]
GO
ALTER TABLE [dbo].[GUITAR]  WITH CHECK ADD  CONSTRAINT [FK_GUITAR_MICROS] FOREIGN KEY([ID_FONCTIONNE1])
REFERENCES [dbo].[MICROS] ([ID])
GO
ALTER TABLE [dbo].[GUITAR] CHECK CONSTRAINT [FK_GUITAR_MICROS]
GO
ALTER TABLE [dbo].[GUITAR]  WITH CHECK ADD  CONSTRAINT [FK_GUITAR_MICROS1] FOREIGN KEY([ID_FONCTIONNE2])
REFERENCES [dbo].[MICROS] ([ID])
GO
ALTER TABLE [dbo].[GUITAR] CHECK CONSTRAINT [FK_GUITAR_MICROS1]
GO
ALTER TABLE [dbo].[GUITAR]  WITH CHECK ADD  CONSTRAINT [FK_GUITAR_MICROS2] FOREIGN KEY([ID_FONCTIONNE3])
REFERENCES [dbo].[MICROS] ([ID])
GO
ALTER TABLE [dbo].[GUITAR] CHECK CONSTRAINT [FK_GUITAR_MICROS2]
GO
ALTER TABLE [dbo].[GUITAR]  WITH CHECK ADD  CONSTRAINT [FK_GUITAR_TYPEBOIS] FOREIGN KEY([ID_UTILISERMANCHE])
REFERENCES [dbo].[TYPEBOIS] ([ID])
GO
ALTER TABLE [dbo].[GUITAR] CHECK CONSTRAINT [FK_GUITAR_TYPEBOIS]
GO
ALTER TABLE [dbo].[GUITAR]  WITH CHECK ADD  CONSTRAINT [FK_GUITAR_TYPEBOIS1] FOREIGN KEY([ID_UTILISERTOUCHE])
REFERENCES [dbo].[TYPEBOIS] ([ID])
GO
ALTER TABLE [dbo].[GUITAR] CHECK CONSTRAINT [FK_GUITAR_TYPEBOIS1]
GO
ALTER TABLE [dbo].[GUITAR]  WITH CHECK ADD  CONSTRAINT [FK_GUITAR_TYPEBOIS2] FOREIGN KEY([ID_UTILISERCORPS])
REFERENCES [dbo].[TYPEBOIS] ([ID])
GO
ALTER TABLE [dbo].[GUITAR] CHECK CONSTRAINT [FK_GUITAR_TYPEBOIS2]
GO
ALTER TABLE [dbo].[GUITAR]  WITH CHECK ADD  CONSTRAINT [FK_GUITAR_VIBRATO] FOREIGN KEY([ID_POSSÈDER])
REFERENCES [dbo].[VIBRATO] ([ID])
GO
ALTER TABLE [dbo].[GUITAR] CHECK CONSTRAINT [FK_GUITAR_VIBRATO]
GO
/****** Object:  StoredProcedure [dbo].[AjoutConstrucMicro]    Script Date: 27/05/2020 18:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AjoutConstrucMicro]
	@Constructeur varchar(250)
AS
BEGIN
	insert into MICROS
	values (@Constructeur);

END
GO
/****** Object:  StoredProcedure [dbo].[AjoutTypeBois]    Script Date: 27/05/2020 18:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AjoutTypeBois]
	@TypeBois varchar(250)
AS
BEGIN
	insert into TYPEBOIS
	values (@TypeBois);

END
GO
/****** Object:  StoredProcedure [dbo].[AjoutVibrato]    Script Date: 27/05/2020 18:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AjoutVibrato]
	@Vibrato varchar(250)
AS
BEGIN
	insert into VIBRATO
	values (@Vibrato);

END
GO
/****** Object:  StoredProcedure [dbo].[CreateGuitarClient]    Script Date: 27/05/2020 18:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CreateGuitarClient](
@Micro1 as char(32),
@Micro2 as char(32),
@Micro3 as char(32),
@NomGuitar as varchar(128),
@BoisCorps as char(32),
@BoisTouche as char(32),
@BoisManche as char(32),
@NomVibrato as char(32),
@idCommande as int

)
AS
BEGIN
	Insert into Vue_Guitar
	Values(@NomGuitar, @Micro1, @Micro2, @Micro3, @BoisCorps, @BoisTouche, @BoisManche, @NomVibrato, @idCommande); 
END
GO
/****** Object:  StoredProcedure [dbo].[EraseCommande]    Script Date: 27/05/2020 18:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[EraseCommande]
	@IdCommande int
AS
BEGIN
	Delete From GUITAR
	where IDCOMMANDE = @IdCommande
	Delete From COMMANDE
	where ID = @IdCommande
END
GO
/****** Object:  StoredProcedure [dbo].[EraseConstructeur]    Script Date: 27/05/2020 18:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[EraseConstructeur]
	@Construc varchar(250)
AS
BEGIN
	Delete From MICROS
	where CONSTRUCTEUR = @Construc
END
GO
/****** Object:  StoredProcedure [dbo].[EraseTypeBois]    Script Date: 27/05/2020 18:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[EraseTypeBois]
	@TypeBois varchar(250)
AS
BEGIN
	Delete From TYPEBOIS
	where NOMTYPEBOIS = @TypeBois
END
GO
/****** Object:  StoredProcedure [dbo].[EraseVibrato]    Script Date: 27/05/2020 18:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[EraseVibrato]
	@Vibrato varchar(250)
AS
BEGIN
	Delete From VIBRATO
	where NOMVIBRATO = @Vibrato
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllBons]    Script Date: 27/05/2020 18:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetAllBons]

AS
BEGIN
	select *
	from BonCommande
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllCommandes]    Script Date: 27/05/2020 18:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetAllCommandes]
AS
BEGIN
	select *
	from COMMANDE;
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllGuitars]    Script Date: 27/05/2020 18:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetAllGuitars]
AS
BEGIN
	Select *
	from Vue_Guitar;
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllTypesBois]    Script Date: 27/05/2020 18:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetAllTypesBois]
AS
BEGIN
	Select NOMTYPEBOIS
	from TYPEBOIS;
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllTypesMicro]    Script Date: 27/05/2020 18:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetAllTypesMicro]
AS
BEGIN
	Select Constructeur
	from MICROS;
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllTypesVibrato]    Script Date: 27/05/2020 18:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetAllTypesVibrato]
AS
BEGIN
	Select NOMVIBRATO
	from VIBRATO;
END
GO
/****** Object:  StoredProcedure [dbo].[GetCommandeByID]    Script Date: 27/05/2020 18:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetCommandeByID]
	@CommandeID as int
AS
BEGIN
	select *
	from BonCommande
	where @CommandeID = NroCommande;
END
GO
/****** Object:  StoredProcedure [dbo].[GetLastCommandeId]    Script Date: 27/05/2020 18:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetLastCommandeId]
AS
BEGIN
	SELECT TOP 1 id as 'id'
	FROM COMMANDE 
	ORDER BY ID DESC;
END
GO
/****** Object:  StoredProcedure [dbo].[GetLastGuitarId]    Script Date: 27/05/2020 18:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetLastGuitarId]
AS
BEGIN
	SELECT TOP 1 id
	FROM GUITAR 
	ORDER BY ID DESC;
END
GO
/****** Object:  StoredProcedure [dbo].[NouvelleCommande]    Script Date: 27/05/2020 18:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[NouvelleCommande]
 
	@NomClient char(32),
	@DateCommande char(32),
	@Montant char (32),
	@telClient char (32)

AS
BEGIN
	Insert into COMMANDE
	output INSERTED.ID
	values (@NomClient, @DateCommande, @Montant, @telClient);
END
GO
/****** Object:  StoredProcedure [dbo].[ShowAllCommandes]    Script Date: 27/05/2020 18:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ShowAllCommandes]

AS
BEGIN
	select *
	from BonCommande
END
GO
/****** Object:  Trigger [dbo].[AjoutGuitar]    Script Date: 27/05/2020 18:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[AjoutGuitar]
   ON  [dbo].[Vue_Guitar]
   instead of INSERT
AS 
BEGIN

Declare
@NomGuitar char(32),
@Micro1 char(32),
@Micro2 char(32),
@Micro3 char(32),
@BoisCorps char(32),
@BoisTouche char(32),
@BoisManche char(32),
@NomVibrato char(32),
@IdCommande int

set @NomGuitar = (select NOMGUITAR from inserted);
set @Micro1= (select id from inserted i , MICROS M where M.CONSTRUCTEUR = i.M_Pos_1);
set @Micro2 = (select id from inserted i, MICROS M where M.CONSTRUCTEUR = i.M_Pos_2);
set @Micro3 = (select id from inserted i, MICROS M where M.CONSTRUCTEUR = i.M_Pos_3);
set @BoisCorps = (select id from inserted i, TYPEBOIS TP where TP.NOMTYPEBOIS = i.Bois_Corps);
set @BoisTouche = (select id from inserted i, TYPEBOIS TP where TP.NOMTYPEBOIS = i.Bois_Touche);
set @BoisManche = (select id from inserted i, TYPEBOIS TP where TP.NOMTYPEBOIS = i.Bois_Manche);
set @NomVibrato = (select id from inserted i, VIBRATO V where V.NOMVIBRATO = i.NOMVIBRATO);
set @IdCommande = (select IDCOMMANDE from inserted);

	Insert into GUITAR(ID_FONCTIONNE1,ID_FONCTIONNE2,ID_FONCTIONNE3,ID_UTILISERMANCHE,ID_UTILISERTOUCHE,ID_UTILISERCORPS, ID_POSSÈDER, NOMGUITAR, IDCOMMANDE)
	Values (@Micro1,@Micro2,@Micro3,@BoisManche,@BoisTouche, @BoisCorps, @NomVibrato, @NomGuitar,  @IdCommande );

END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[31] 4[43] 2[11] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -96
         Left = 0
      End
      Begin Tables = 
         Begin Table = "COMMANDE"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 167
               Right = 230
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "GUITAR"
            Begin Extent = 
               Top = 6
               Left = 268
               Bottom = 136
               Right = 469
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "MICROS"
            Begin Extent = 
               Top = 6
               Left = 507
               Bottom = 102
               Right = 684
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "VIBRATO"
            Begin Extent = 
               Top = 6
               Left = 722
               Bottom = 102
               Right = 892
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "MICROS_1"
            Begin Extent = 
               Top = 6
               Left = 930
               Bottom = 102
               Right = 1107
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "MICROS_2"
            Begin Extent = 
               Top = 200
               Left = 790
               Bottom = 296
               Right = 967
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TYPEBOIS_1"
            Begin Extent = 
               Top = 247
               Left = 571
               Bottom = 343
               Right = 741
            End
            DisplayFlags = 2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'BonCommande'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'80
            TopColumn = 0
         End
         Begin Table = "TYPEBOIS_2"
            Begin Extent = 
               Top = 128
               Left = 950
               Bottom = 224
               Right = 1120
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TYPEBOIS_3"
            Begin Extent = 
               Top = 205
               Left = 38
               Bottom = 280
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 3420
         Alias = 4245
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'BonCommande'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'BonCommande'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[42] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "COMMANDE"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 230
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "GUITAR"
            Begin Extent = 
               Top = 32
               Left = 536
               Bottom = 162
               Right = 737
            End
            DisplayFlags = 280
            TopColumn = 5
         End
         Begin Table = "Vue_Guitar"
            Begin Extent = 
               Top = 108
               Left = 295
               Bottom = 238
               Right = 465
            End
            DisplayFlags = 280
            TopColumn = 4
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'CommandeGuitar'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'CommandeGuitar'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[47] 4[13] 2[23] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "COMMANDE"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 230
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "GUITAR"
            Begin Extent = 
               Top = 26
               Left = 253
               Bottom = 243
               Right = 454
            End
            DisplayFlags = 280
            TopColumn = 6
         End
         Begin Table = "MICROS"
            Begin Extent = 
               Top = 119
               Left = 846
               Bottom = 279
               Right = 1023
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "VIBRATO"
            Begin Extent = 
               Top = 447
               Left = 55
               Bottom = 543
               Right = 225
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "MICROS_1"
            Begin Extent = 
               Top = 0
               Left = 753
               Bottom = 96
               Right = 930
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "MICROS_2"
            Begin Extent = 
               Top = 6
               Left = 1041
               Bottom = 102
               Right = 1218
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TYPEBOIS_1"
            Begin Extent = 
               Top = 179
               Left = 602
               Bottom = 275
               Right = 772
            End
            DisplayFlags = ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vue_Guitar'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'280
            TopColumn = 0
         End
         Begin Table = "TYPEBOIS_2"
            Begin Extent = 
               Top = 431
               Left = 641
               Bottom = 527
               Right = 811
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TYPEBOIS_3"
            Begin Extent = 
               Top = 291
               Left = 636
               Bottom = 387
               Right = 806
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 2010
         Alias = 2565
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vue_Guitar'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vue_Guitar'
GO
