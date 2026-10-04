IF NOT EXISTS (SELECT 1 FROM Users WHERE Username = 'admin')
BEGIN
    INSERT INTO Users (Username, Password, Role)
    VALUES ('admin', 'admin123', 'Admin');
END

IF NOT EXISTS (SELECT 1 FROM Users WHERE Username = 'cashier')
BEGIN
    INSERT INTO Users (Username, Password, Role)
    VALUES ('cashier', 'cashier123', 'Cashier');
END