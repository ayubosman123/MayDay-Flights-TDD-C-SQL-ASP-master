CREATE PROCEDURE [dbo].[Sproc_tblBookings_Insert]
--create parameters for the store procedure
	@Ammount decimal,
	@DateBooked date,
	@PaymentType Varchar(10)
AS
--insert the new record 
	Insert into tblBookings (Ammount, DateBooked, PaymentType)
	Values (@Ammount, @DateBooked, @PaymentType)

--return the primary key value of the new record
RETURN  @@Identity