﻿ALTER TABLE [Order]
ADD FOREIGN KEY (Customer_ID)
REFERENCES Customers(Id);

