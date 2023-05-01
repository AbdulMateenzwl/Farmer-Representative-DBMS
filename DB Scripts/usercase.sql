------- U - 001
-- Check User Type Q1
Select L.id
from Credentails C
join lookup L 
on C.Type = L.Id
where c.Email = '{Credentials.Email}' & C.Password = '{Credentials.Password}'


-------- U - 002
-- Create credentials Q2 
insert into Credentails 
values('{credentials.email}','{credentials.password}','{Credentials.type}')
-- Create wallet  Q3
insert into wallet 
values('{wallet.type}',0)
-- Create person Q4
insert into person values('{Person.FirstName}','{Person.Lastname}','{Person.PhoneNo}','{Person.CNIC}','{Person.RegionId}','{Person.RegDate}','{Person.Gender}','{Person.Walletid}','{Person.CredentialId}')
-- GetRegionId Q5
Select id 
from region R
where R.RegionName = '@str'
-- Get Walletid Q6
Select MAX(id)
from wallet
-- Get Credential id Q7
Select MAX(id)
from Credentails
-- Create Farmer Q8
insert into farmer values('{Farmer.id}','{Farmer.Status}','{Farmer.Address}',NULL,'{Farmer.AccountType}')
--  Create Driver Q9
insert into driver values('{Driver.id}','{Driver.Status}','{Driver.Address}','{Driver.DrivingLicense}',NULL,'{Driver.AccountType}')
-- Create Employee Q10
insert into Employee values('{Employee.id}','{Employee.Salary}','{Employee.Status}','{Employee.Salary}','{Employee.Designation}')



---------- u - 004
-- Create Field Q11
insert into Field values('{Field.Farmerid}','{Field.Regionid}','{Field.Address}','{Field.Status}',NULL)
-- Update Field's Region, location Q12
Update Field
set RegionId = '{Field.regionid}' , Address = '{Field.Address}'
where Id =  '{Field.id}'
-------- U-006
-- Alter Amount Q13
Update wallet
set TotalAmount = @Amount
where id = @id
-- Get Amount Q14
Select *
from wallet 
where wallet.Id = @id


-- U-007
 -- Q13, Q14


-- U - 008
-- Add Product Q15
Insert into Product values('{Product.Name}','{Product.Quantity}','{Product.UnitPrice}','{Product.RemainingUnits}',NULL,'{Product.Status}','{Product.Categoryid}')


---- U -009
-- Update Person Q16
Update person
set FirstName = '{person.firstname}', LastName = '{person.Lastname}' , PhoneNo = '{person.PHoneno}'
Where id = '{person.id}'
-- Change Password Q17
Update Credentails
set Password = @password
where Id = '{person.credentialid}'
----- U - 010
-- Change Delivery Status Q18
update Delivery
set CurrentStatus = @status

----- U- 011
-- Add Vehicle Q19
insert into Vehicle values('{Vehicle.RegNo}','{Vehicle.SystemRegDate}','{Vehicle.Driverid}','{Vehicle.Vehiclestatus}','{Vehicle.Managerid}')


----- U - 012
-- Update Vehicle Q20
update vehicle
set RegNo = '{Vehicle.RegNo}', VehicleStatus =  '{Vehicle.Vehiclestatus}'
where id = '{Vehicle.id}'

----- U - 013
-- Approve/ Disapprove Farmer Request Q21
update farmer
set Status = @status
where id = @id

------ U - 014
--- Approve / Disapprove field request Q22
update field
set status = @status
where id = @id

------ U - 015
-- Get Active Vehicle id from driver id Q23
select V.Id
from Vehicle V
join Lookup L
on L.Id = V.VehicleStatus
where L.Category = 'VehicleStatus' and L.Value = 'Active' and V.DriverId = @Driverid
-- Assign Product Delivery to Driver Q24
insert into Delivery values(@Vehicleid,@Deliverytype, @Sourceid, @Destinationid, @productid, @currentstatus,@managerid)
-- Get Delivery type(id) Q25
select id 
from lookup L
where L.Value = @str and L.Category = 'DeliveryType'


------ U-016
-- update Driver Status Q26
update driver
set status = @status
where id = @id

------ U - 017
-- change status of vehicle Q27
update Vehicle
set VehicleStatus = @status
where id = @id

----- U-018
--Q27

----- U - 019
-- change order status Q28
update order 
set status = @status
where id = @id


-------- U - 020
-- change organization status Q29
update Organization
set Status = @status
where id = @id

-------- U - 021
-- Q2,Q3,Q5,Q6,Q7
-- signup Organization
insert into Organization values('{Organization.OrganizationName}','{Organization.Address}','{Organization.Regionid}','{Organization.walletid}','{Organization.Credentialsid}','{Organization.Status}')


------ U-022
-- Q14









