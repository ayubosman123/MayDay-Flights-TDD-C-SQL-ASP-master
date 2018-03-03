CREATE PROCEDURE [dbo].[sproc_tblBookings_FilterbyPK]
--this function uses the luke function to find booking references that match the value
--stored in the parameter @BookRef
--this stored procedure does not return a value

	--declare the parameter as int
	@BookRef int
AS

	--select all fields from any records that match or like the BookRef
	select * from tblBookings where BookRef like @BookRef;