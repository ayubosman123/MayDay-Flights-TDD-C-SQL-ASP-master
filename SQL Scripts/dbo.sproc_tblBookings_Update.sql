CREATE PROCEDURE sproc_tblBookings_Update
--create the parameters for the stored procedure
	@BookRef int,
	@Ammount decimal(18,2),
	@DateBooked date,
	@PaymentType varchar(10)
AS
--update the records as specificied by @BookRef value
update tblBookings
	
set 
	Ammount=@Ammount,
	DateBooked=@DateBooked,
	PaymentType=@PaymentType

	where BookRef=@BookRef