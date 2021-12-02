INSERT INTO people (lastname, firstname, phoneNumber, email, password, roles_id)
VALUES ('Volery','Sven','079 847 49 10','Sven.VOLERY@cpnv.ch','Pa$$w0rd', 3);

USE ticketing;
UPDATE people
SET phoneNumber = '079 847 49 10'
WHERE id = 1;