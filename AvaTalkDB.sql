
CREATE TABLE TB_GENDER(
	ID			UNIQUEIDENTIFIER PRIMARY KEY NOT NULL DEFAULT NEWID(),
	DS_GENDER	VARCHAR(100) NOT NULL UNIQUE,
	DT_CREATED	DATETIME DEFAULT GETDATE(),
	DT_UPDATED	DATETIME DEFAULT GETDATE(),
	ST_ACTIVE	BIT DEFAULT 1
);

CREATE TABLE TB_MIDIA_TYPE(
	ID				UNIQUEIDENTIFIER PRIMARY KEY NOT NULL DEFAULT NEWID(),
	DS_MIDIA_TYPE	VARCHAR(100) NOT NULL UNIQUE,
	DS_EXTENSIONS	VARCHAR(200) NOT NULL,
	DT_CREATED		DATETIME DEFAULT GETDATE(),
	DT_UPDATED		DATETIME DEFAULT GETDATE(),
	ST_ACTIVE		BIT DEFAULT 1
);

CREATE TABLE TB_INVITE_STATUS(
	ID					UNIQUEIDENTIFIER PRIMARY KEY NOT NULL DEFAULT NEWID(),
	DS_INVITE_STATUS	VARCHAR(100) NOT NULL UNIQUE,
	DT_CREATED			DATETIME DEFAULT GETDATE(),
	DT_UPDATED			DATETIME DEFAULT GETDATE(),
	ST_ACTIVE			BIT DEFAULT 1
);

CREATE TABLE TB_MIDIA(
	ID				UNIQUEIDENTIFIER PRIMARY KEY NOT NULL DEFAULT NEWID(),
	ID_MIDIA_TYPE	UNIQUEIDENTIFIER NOT NULL,
	DS_MIDIA		VARCHAR(4000),
	DS_FILE_PATH	VARCHAR(200) NOT NULL UNIQUE,
	DT_CREATED		DATETIME DEFAULT GETDATE(),
	DT_UPDATED		DATETIME DEFAULT GETDATE(),
	ST_ACTIVE		BIT DEFAULT 1,
	FOREIGN KEY (ID_MIDIA_TYPE) REFERENCES TB_MIDIA_TYPE(ID)
);

CREATE TABLE TB_USER(
	ID				UNIQUEIDENTIFIER PRIMARY KEY NOT NULL DEFAULT NEWID(),
	NM_USER			VARCHAR(100) NOT NULL UNIQUE,
	DS_EMAIL		VARCHAR(250) NOT NULL UNIQUE,
	DS_PASSWORD		VARCHAR(100) NOT NULL,
	DT_BIRTHDAY		DATE NOT NULL,
	ID_GENDER		UNIQUEIDENTIFIER NOT NULL,
    ID_AVATAR		UNIQUEIDENTIFIER NOT NULL,
    ID_COVER		UNIQUEIDENTIFIER NOT NULL,
	DT_CREATED		DATETIME DEFAULT GETDATE(),
	DT_UPDATED		DATETIME DEFAULT GETDATE(),
	ST_ACTIVE		BIT DEFAULT 1,
    FOREIGN KEY (ID_GENDER) REFERENCES TB_GENDER(ID),
    FOREIGN KEY (ID_AVATAR) REFERENCES TB_MIDIA(ID),
    FOREIGN KEY (ID_COVER)	REFERENCES TB_MIDIA(ID)
);

CREATE TABLE TB_INVITE(
	ID					UNIQUEIDENTIFIER PRIMARY KEY NOT NULL DEFAULT NEWID(),
	ID_SENDER			UNIQUEIDENTIFIER NOT NULL,
	ID_RECEIVER			UNIQUEIDENTIFIER NOT NULL,
	ID_INVITE_STATUS	UNIQUEIDENTIFIER NOT NULL,
	DT_CREATED			DATETIME DEFAULT GETDATE(),
	DT_UPDATED			DATETIME DEFAULT GETDATE(),
	ST_ACTIVE			BIT DEFAULT 1,
    FOREIGN KEY (ID_SENDER)			REFERENCES TB_USER(ID),
    FOREIGN KEY (ID_RECEIVER)		REFERENCES TB_USER(ID),
    FOREIGN KEY (ID_INVITE_STATUS)	REFERENCES TB_INVITE_STATUS(ID)
);


CREATE TABLE TB_POST(
	ID			UNIQUEIDENTIFIER PRIMARY KEY NOT NULL DEFAULT NEWID(),
	ID_PARENT   UNIQUEIDENTIFIER NOT NULL,
	ID_USER		UNIQUEIDENTIFIER NOT NULL,
	DS_TEXT		VARCHAR(4000),
	DT_CREATED	DATETIME DEFAULT GETDATE(),
	DT_UPDATED	DATETIME DEFAULT GETDATE(),
	ST_ACTIVE	BIT DEFAULT 1
	FOREIGN KEY (ID_PARENT) REFERENCES TB_POST(ID),
	FOREIGN KEY (ID_USER)	REFERENCES TB_USER(ID),
);


CREATE TABLE TB_LIKE(
	ID			UNIQUEIDENTIFIER PRIMARY KEY NOT NULL DEFAULT NEWID(),
	ID_POST		UNIQUEIDENTIFIER NOT NULL,
	ID_USER		UNIQUEIDENTIFIER NOT NULL,
	DT_CREATED	DATETIME DEFAULT GETDATE(),
	DT_UPDATED	DATETIME DEFAULT GETDATE(),
	ST_ACTIVE	BIT DEFAULT 1,
	FOREIGN KEY (ID_POST) REFERENCES TB_POST(ID),
	FOREIGN KEY (ID_USER) REFERENCES TB_USER(ID)
);

CREATE TABLE TB_GALLERY(
	ID			UNIQUEIDENTIFIER PRIMARY KEY NOT NULL DEFAULT NEWID(),
	ID_USER		UNIQUEIDENTIFIER NOT NULL,
	NM_GALLERY	VARCHAR(100),
	DT_CREATED	DATETIME DEFAULT GETDATE(),
	DT_UPDATED	DATETIME DEFAULT GETDATE(),
	ST_ACTIVE	BIT DEFAULT 1,
	FOREIGN KEY (ID_USER) REFERENCES TB_USER(ID),
);

CREATE TABLE TB_MIDIA_GALLERY(
	ID_GALLERY	UNIQUEIDENTIFIER NOT NULL,
	ID_MIDIA	UNIQUEIDENTIFIER NOT NULL,
	FOREIGN KEY (ID_GALLERY) REFERENCES TB_GALLERY(ID),
	FOREIGN KEY (ID_MIDIA) 	 REFERENCES TB_MIDIA(ID),
);

-- DADOS INICIAS

INSERT INTO TB_GENDER (DS_GENDER) VALUES 
('Indefinido'),('Masculino'),('Feminino'),('Outros');

INSERT INTO TB_MIDIA_TYPE (DS_MIDIA_TYPE, DS_EXTENSIONS) VALUES 
('Photo', 'jpeg,jpg,gif,png' ), ('Video', 'mkv,mp4,mpeg' )

INSERT INTO TB_MIDIA (DS_MIDIA, DS_FILE_PATH, ID_MIDIA_TYPE) VALUES 
('Foto na praia', '/photos/file.jpg', (select top 1 ID FROM TB_MIDIA_TYPE)),
('Foto na paris', '/photos/file2.jpg', (select top 1 ID FROM TB_MIDIA_TYPE)),
('Foto na praia2', '/photos/midia3.jpg', (select top 1 ID FROM TB_MIDIA_TYPE)),
('Foto na paris3', '/photos/midia5.jpg', (select top 1 ID FROM TB_MIDIA_TYPE)),
('Foto na bangu', '/photos/midia90.jpg', (select top 1 ID FROM TB_MIDIA_TYPE))
('Foto em londres', '/photos/midia91.jpg', (select top 1 ID FROM TB_MIDIA_TYPE)),
('Foto na india', '/photos/midia34.jpg', (select top 1 ID FROM TB_MIDIA_TYPE)),
('Foto na casa do amigo', '/photos/sdfsd.jpg', (select top 1 ID FROM TB_MIDIA_TYPE)),
('baladenha top', '/photos/sdfgtg.jpg', (select top 1 ID FROM TB_MIDIA_TYPE)),
('barzinho', '/photos/asfgajn.jpg', (select top 1 ID FROM TB_MIDIA_TYPE)),
('vamo la', '/photos/tundthst.jpg', (select top 1 ID FROM TB_MIDIA_TYPE)),
('peha nois', '/photos/sbsdtgdf.jpg', (select top 1 ID FROM TB_MIDIA_TYPE)),
('viagem mara', '/photos/setdtg.jpg', (select top 1 ID FROM TB_MIDIA_TYPE)),
('rango top', '/photos/fughdf.jpg', (select top 1 ID FROM TB_MIDIA_TYPE))

INSERT INTO TB_INVITE_STATUS (DS_INVITE_STATUS) VALUES
('Aguardando'),('Aceito'),('Recusado')

INSERT INTO TB_USER (NM_USER, DS_EMAIL, DS_PASSWORD, DT_BIRTHDAY, ID_GENDER, ID_COVER, ID_AVATAR) VALUES
(
	'Isadora de Souza',
	'isadora@gmail.com',
	'12345678',
	DATEFROMPARTS(1990,08,08), 
	(select ID FROM TB_GENDER ORDER BY ID OFFSET 0 ROWS FETCH NEXT 1 ROWS ONLY),
	(select ID FROM TB_MIDIA ORDER BY ID OFFSET 0 ROWS FETCH NEXT 1 ROWS ONLY),
	(select ID FROM TB_MIDIA ORDER BY ID OFFSET 0 ROWS FETCH NEXT 1 ROWS ONLY)
),
(
	'Joana Bras',
	'joana@gmail.com',
	'987654321',
	DATEFROMPARTS(1985,03,25), 
	(select ID FROM TB_GENDER ORDER BY ID OFFSET 1 ROWS FETCH NEXT 1 ROWS ONLY),
	(select ID FROM TB_MIDIA ORDER BY ID OFFSET 1 ROWS FETCH NEXT 1 ROWS ONLY),
	(select ID FROM TB_MIDIA ORDER BY ID OFFSET 1 ROWS FETCH NEXT 1 ROWS ONLY)
),
(
	'Andreia Costa',
	'andreia@gmail.com',
	'987654321',
	DATEFROMPARTS(1982,06,20), 
	(select ID FROM TB_GENDER ORDER BY ID OFFSET 1 ROWS FETCH NEXT 1 ROWS ONLY),
	(select ID FROM TB_MIDIA ORDER BY ID OFFSET 2 ROWS FETCH NEXT 1 ROWS ONLY),
	(select ID FROM TB_MIDIA ORDER BY ID OFFSET 2 ROWS FETCH NEXT 1 ROWS ONLY)
),
(
	'Rebeca Fiorelli',
	'rebeca@gmail.com',
	'987654321',
	DATEFROMPARTS(1982,06,20), 
	(select ID FROM TB_GENDER ORDER BY ID OFFSET 1 ROWS FETCH NEXT 1 ROWS ONLY),
	(select ID FROM TB_MIDIA ORDER BY ID OFFSET 3 ROWS FETCH NEXT 1 ROWS ONLY),
	(select ID FROM TB_MIDIA ORDER BY ID OFFSET 3 ROWS FETCH NEXT 1 ROWS ONLY)
)

INSERT INTO TB_GALLERY(NM_GALLERY, ID_USER) VALUES
('Feed', (select ID FROM TB_USER ORDER BY ID OFFSET 0 ROWS FETCH NEXT 1 ROWS ONLY)),
('Feed', (select ID FROM TB_USER ORDER BY ID OFFSET 1 ROWS FETCH NEXT 1 ROWS ONLY)),
('Feed', (select ID FROM TB_USER ORDER BY ID OFFSET 2 ROWS FETCH NEXT 1 ROWS ONLY)),
('Feed', (select ID FROM TB_USER ORDER BY ID OFFSET 3 ROWS FETCH NEXT 1 ROWS ONLY))
