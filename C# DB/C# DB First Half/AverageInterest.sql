SELECT DepositGroup, IsDepositExpired, AVG(DepositInterest) FROM WizzardDeposits
WHERE DepositStartDate > '1-1-1985'
GROUP BY DepositGroup, IsDepositExpired
ORDER BY DepositGroup DESC, IsDepositExpired ASC
