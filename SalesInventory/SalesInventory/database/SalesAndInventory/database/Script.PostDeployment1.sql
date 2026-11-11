-- 1. Insert Default Users
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

-- 2. Insert Initial Categories
IF NOT EXISTS (SELECT 1 FROM Categories)
BEGIN
    INSERT INTO Categories (CategoryName, Description, Status) VALUES 
    ('Beverages', 'Softdrinks, juices, and water', 'Active'),
    ('Snacks', 'Chips, biscuits, and chocolates', 'Active'),
    ('Canned Goods', 'Sardines, tuna, and meat loaf', 'Active'),
    ('Personal Care', 'Soap, shampoo, and toothpaste', 'Active'),
    ('Household', 'Detergents and cleaning materials', 'Active');
END

-- 3. Insert Initial Suppliers
IF NOT EXISTS (SELECT 1 FROM Suppliers)
BEGIN
    INSERT INTO Suppliers (SupplierName, ContactPerson, PhoneNumber, EmailAddress, PhysicalAddress, Status) VALUES 
    ('ABC Distribution', 'Juan Dela Cruz', '09123456789', 'abc@email.com', 'Manila', 'Active'),
    ('Global Trade Inc.', 'Maria Santos', '09987654321', 'global@email.com', 'Quezon City', 'Active'),
    ('Prime Wholesale', 'Pedro Penduko', '09112223344', 'prime@email.com', 'Makati', 'Active');
END

-- 4. Insert 50 Products
IF NOT EXISTS (SELECT 1 FROM Products)
BEGIN
    INSERT INTO Products (ProductName, CategoryID, SupplierID, UnitPrice, StockQuantity, ReorderLevel, Status) VALUES
    ('Coke 1.5L', 1, 1, 65.00, 100, 10, 'Active'),
    ('Sprite 1.5L', 1, 1, 65.00, 80, 10, 'Active'),
    ('Royal 1.5L', 1, 1, 65.00, 75, 10, 'Active'),
    ('Bottled Water 500ml', 1, 2, 15.00, 200, 20, 'Active'),
    ('San Mig Light Can', 1, 3, 55.00, 120, 15, 'Active'),
    ('Coke Zero 330ml', 1, 1, 35.00, 90, 15, 'Active'),
    ('Pepsi 1.5L', 1, 1, 60.00, 85, 10, 'Active'),
    ('Mountain Dew Can', 1, 1, 35.00, 110, 15, 'Active'),
    ('Gatorade Blue 500ml', 1, 2, 45.00, 70, 10, 'Active'),
    ('C2 Green Tea 500ml', 1, 2, 25.00, 150, 20, 'Active'),
    ('Nova Cheddar 50g', 2, 2, 20.00, 150, 20, 'Active'),
    ('Piattos Cheese 50g', 2, 2, 20.00, 140, 20, 'Active'),
    ('Chippy BBQ 100g', 2, 2, 35.00, 90, 15, 'Active'),
    ('Skyflakes Crackers', 2, 1, 8.00, 300, 30, 'Active'),
    ('Fita Biscuits', 2, 1, 8.00, 250, 30, 'Active'),
    ('Oreo Chocolate 133g', 2, 2, 45.00, 100, 15, 'Active'),
    ('Vcut Potato Chips 60g', 2, 2, 38.00, 80, 12, 'Active'),
    ('Roller Coaster Cheese', 2, 2, 18.00, 120, 20, 'Active'),
    ('Nissin Butter Coconut', 2, 1, 15.00, 160, 25, 'Active'),
    ('Hansel Mocha Sandwich', 2, 1, 9.00, 220, 30, 'Active'),
    ('Century Tuna Flakes 155g', 3, 3, 38.00, 110, 15, 'Active'),
    ('Ligo Sardines Tomato 155g', 3, 3, 22.00, 200, 25, 'Active'),
    ('Argentina Corned Beef 150g', 3, 1, 32.00, 130, 20, 'Active'),
    ('Mega Sardines Chili', 3, 3, 23.00, 180, 20, 'Active'),
    ('San Marino Tuna Roast', 3, 3, 42.00, 95, 15, 'Active'),
    ('Spam Regular 340g', 3, 1, 210.00, 40, 5, 'Active'),
    ('Prem Meatloaf 340g', 3, 1, 165.00, 50, 8, 'Active'),
    ('CDO Carne Norte 150g', 3, 1, 28.00, 140, 20, 'Active'),
    ('555 Tuna Afritada 155g', 3, 3, 35.00, 105, 15, 'Active'),
    ('Purefoods Corned Beef 210g', 3, 1, 98.00, 60, 10, 'Active'),
    ('Safeguard Soap White', 4, 2, 48.00, 85, 15, 'Active'),
    ('Colgate Toothpaste 150ml', 4, 2, 85.00, 60, 10, 'Active'),
    ('Palmolive Shampoo 180ml', 4, 1, 95.00, 70, 10, 'Active'),
    ('Cream Silk Conditioner', 4, 1, 105.00, 65, 10, 'Active'),
    ('Sunsilk Shampoo 180ml', 4, 2, 90.00, 80, 10, 'Active'),
    ('CloseUp Toothpaste 120g', 4, 2, 75.00, 65, 10, 'Active'),
    ('Lactacyd Pro Sensitive 150ml', 4, 1, 145.00, 40, 5, 'Active'),
    ('Rexona Deodorant Roll-on', 4, 2, 89.00, 55, 10, 'Active'),
    ('Nivea Body Lotion 200ml', 4, 2, 195.00, 35, 5, 'Active'),
    ('Gillette Mach 3 Razor', 4, 3, 180.00, 30, 5, 'Active'),
    ('Surf Powder Detergent 1kg', 5, 3, 98.00, 50, 10, 'Active'),
    ('Pride Detergent Bar', 5, 3, 24.00, 120, 20, 'Active'),
    ('Zonrox Bleach 500ml', 5, 1, 35.00, 70, 15, 'Active'),
    ('Joy Dishwashing Liquid 250ml', 5, 2, 60.00, 110, 15, 'Active'),
    ('Downy Fabric Softener 200ml', 5, 2, 28.00, 140, 20, 'Active'),
    ('Breeze Liquid Detergent 980ml', 5, 3, 168.00, 45, 8, 'Active'),
    ('Domex Toilet Cleaner 500ml', 5, 1, 92.00, 50, 10, 'Active'),
    ('Scotch Brite Sponge 3s', 5, 2, 55.00, 85, 15, 'Active'),
    ('Lysol Disinfectant Spray 170g', 5, 3, 280.00, 25, 5, 'Active'),
    ('Pledge Furniture Polish 330ml', 5, 1, 230.00, 20, 5, 'Active');
END