CREATE PROCEDURE [dbo].[sproc_tblBookings_FilterbyDate]
	--Parameter to store the booking ref we are looking for
	@DateBooked date,
	@DateBooked1 date
AS
	SELECT* from tblBookings WHERE NOT (DateBooked > @DateBooked OR DateBooked < @DateBooked1)

RETURN 0