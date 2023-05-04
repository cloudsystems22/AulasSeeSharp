GO
EXEC sp_rename 'dbo.products', 'Product';

CREATE TABLE Product(
    Id VARCHAR(150) NOT NULL PRIMARY KEY,
    Description VARCHAR(255),
    Price DECIMAL(18,2),
    IsActivity BIT,
    CreateAt DATETIME,
    UpdateAt DATETIME
);

DROP TABLE Product;


INSERT INTO dbo.cliente (Id, Name, LastName, EmailAddress, IsActivity, CreateAt, UpdateAt) 
VALUES ('1', 'David', 'Fico', 'davidfico22@gmail.com', 0, '2022-08-08', '2022-08-08');

SELECT * FROM Cliente;
SELECT * FROM Product;
DELETE FROM Product;

UPDATE dbo.Product SET Description = 'Notebook Dell', Price = 8 WHERE Id = '1'

DELETE FROM cliente;