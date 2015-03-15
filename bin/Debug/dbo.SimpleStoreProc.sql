CREATE PROCEDURE [dbo].[SimpleStoredProc]
(
	@name nchar(50),
	@dura int
)
AS
	insert into dbo.Adv_Segment(Adv_Segment.Name,Adv_Segment.Duration,Adv_Segment.OneDay_Count,Adv_Segment.Days_Count) 
	values (@name,@dura,5,12)
RETURN 
