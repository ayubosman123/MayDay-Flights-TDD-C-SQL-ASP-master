CREATE PROCEDURE [dbo].[sproc_tblBookings_Delete]
--this stored procedure is located in data layer (App_Data_ folder

--this stored procedure is used to delete a single record in the table tblBookings
--it accepts a single parameter @BookRef and returns no value

	--declare the parameter
	@BookRef int
AS

	--delete the record in tblBookings specified by the value @BookRef
	delete from tblBookings where BookRef = @BookRef;