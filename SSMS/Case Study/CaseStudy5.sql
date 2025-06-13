CREATE TABLE Orders ( 

    OrderID INT IDENTITY(1,1) PRIMARY KEY, 

    CustomerName VARCHAR(100), 

    OrderDate DATETIME DEFAULT GETDATE() 

); 

CREATE TABLE OrderItems ( 

    OrderItemID INT IDENTITY(1,1) PRIMARY KEY, 

    OrderID INT FOREIGN KEY REFERENCES Orders(OrderID), 

    ProductName VARCHAR(100), 

    Quantity INT, 

    UnitPrice DECIMAL(10,2) 

); 


BEGIN TRY
    BEGIN TRANSACTION;

    -- Insert into Orders table
    INSERT INTO Orders (CustomerName)
    VALUES ('John Doe');

    -- Get the generated OrderID
    DECLARE @OrderID INT = SCOPE_IDENTITY();

    -- Insert into OrderItems table
    INSERT INTO OrderItems (OrderID, ProductName, Quantity, UnitPrice)
    VALUES 
        (@OrderID, 'Keyboard', 2.5, 1500.00),
        (@OrderID, 'Mouse', 1, 800.00),
        (@OrderID, 'Monitor', 1, 7000.00);

    -- Commit if all inserts are successful
    COMMIT TRANSACTION;
    PRINT 'Order and items inserted successfully.';
END TRY
BEGIN CATCH
    -- Rollback if there's any error
    ROLLBACK TRANSACTION;
    PRINT 'Transaction failed. Rolled back.';
    PRINT ERROR_MESSAGE();
END CATCH;

-- View Orders
SELECT * FROM Orders;

-- View OrderItems
SELECT * FROM OrderItems;


