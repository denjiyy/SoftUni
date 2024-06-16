UPDATE Contacts
SET Website = 'www.' + LOWER(REPLACE(a.Name, ' ', '')) + '.com'
FROM Authors a
JOIN Contacts c ON a.ContactId = c.Id
WHERE c.Website IS NULL
