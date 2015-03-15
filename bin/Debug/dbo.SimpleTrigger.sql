CREATE TRIGGER [SimpleTrigger]
	ON [dbo].[TV_Channel]
	FOR insert
	AS
	BEGIN
		insert into dbo.TV_Channel(TV_Channel.Id,TV_Channel.Name,TV_Channel.Second_Cost,TV_Channel.Viewers_MaxValue_Month) 
		values (500,'CNN', 30, 5830)
	END
