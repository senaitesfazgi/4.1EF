DROP TABLE IF EXISTS Car;
DROP TABLE IF EXISTS Manufacturer;

CREATE TABLE IF NOT EXISTS Manufacturer (
	ID int(10) PRIMARY KEY AUTO_INCREMENT,
	Name varchar(20) NOT NULL
);

CREATE TABLE IF NOT EXISTS Car (
	ID int(10) PRIMARY KEY AUTO_INCREMENT,
	ManufacturerID int(10) NOT NULL,
	Model varchar(20) NOT NULL,
	Colour varchar(10) NOT NULL,
	CONSTRAINT FK_Car_Manufacturer FOREIGN KEY (ManufacturerID) REFERENCES Manufacturer(ID)
);

INSERT INTO Manufacturer (Name)
VALUES ('Chevrolet'), ('Ford'), ('Dodge'), ('Jeep'), ('Toyota'), ('Nissan'), ('Honda'), ('Mitsubishi'), ('Volvo'), ('Mercedes-Benz'), ('Audi'), ('BMW'), ('Tesla'), ('Land Rover'), ('Skoda');

INSERT INTO Car (ManufacturerID, Model, Colour)
VALUES 
(1, 'Corvette', 'Red'), -- Chevrolet
(1, 'Blazer', 'Blue'), -- Chevrolet
(2, 'GT', 'Blue'), -- Ford
(2, 'Ranger', 'White'), -- Ford
(2, 'Pinto', 'Brown'), -- Ford
(3, 'Viper', 'Black'), -- Dodge
(3, 'Challenger', 'Orange'), -- Dodge
(3, 'Stealth', 'Blue'), -- Dodge
(3, 'Dart', 'Red'), -- Dodge
(4, 'Wrangler', 'Red'), -- Jeep
(4, 'Wrangler', 'Green'), -- Jeep
(5, 'Supra', 'Red'), -- Toyota
(5, 'Soarer', 'White'), -- Toyota
(6, '300ZX', 'Red'), -- Nissan
(6, '350Z', 'White'), -- Nissan
(7, 'Civic', 'Silver'), -- Honda
(7, 'NSX', 'Red'), -- Honda
(7, 'S2000', 'White'), -- Honda
(8, '3000GT', 'Burgundy'), -- Mitsubishi
(8, 'Lancer', 'White'), -- Mitsubishi
(8, 'Mighty Max', 'Green'), -- Mitsubishi
(9, 'S60', 'White'), -- Volvo
(9, 'XC60', 'Brown'), -- Volvo
(10, 'CLS', 'White'), -- Mercedes
(10, 'Gullwing', 'Silver'), -- Mercedes
(11, 'R8', 'Red'), -- Audi
(11, 'S6', 'Black'), -- Audi
(12, 'I8', 'White'), -- BMW
(12, 'X1', 'White'), -- BMW
(13, 'Model S', 'White'), -- Tesla
(13, 'Model 3', 'Black'), -- Tesla
(13, 'Model X', 'Blue'), -- Tesla
(13, 'Roadster', 'Red'), -- Tesla
(14, 'Defender', 'Black'), -- Land Rover
(14, 'Range Rover', 'White'), -- Land Rover
(15, 'R10', 'Pink'); -- Skoda


