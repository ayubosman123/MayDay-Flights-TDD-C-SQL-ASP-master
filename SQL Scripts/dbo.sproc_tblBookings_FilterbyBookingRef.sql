CREATE PROCEDURE [dbo].[sproc_tblBookings_FilterbyBookingRef]
	--Parameter to store the booking ref we are looking for
	@BookRef int
AS
	SELECT* from tblBookings where BookRef like @BookRef

RETURN 0