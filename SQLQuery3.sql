SELECT *
FROM [Order]
FULL OUTER JOIN [User]
ON [Order].Customer_ID = [User].Id
WHERE Product_ID='8'
ORDER BY Status ASC;

