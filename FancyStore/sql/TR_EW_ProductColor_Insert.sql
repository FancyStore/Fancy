USE [Fancy]
GO

/****** Object:  Trigger [dbo].[TR_EW_ProductColor_Insert]    Script Date: 2019/5/25 �U�� 03:42:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



Create TRIGGER [dbo].[TR_EW_ProductColor_Insert]
   ON [dbo].[ProductColor]
   after Insert
AS
	declare @countTemp int; --�p�ⵧ��
	declare @prodID int
	declare @prodSizeID int
	declare @prodColorID int

	--�إ�temp Table
	create table #tempProducutStock
	(ProductID int,
	ProductSizeID int,
	ProductColorID int
	);
	
	select @countTemp = count(*) from [dbo].[ProductColor] as pc
									join [dbo].[ProductSize] as ps
									on pc.ProductID = ps.ProductID
									join inserted as i
									on ps.ProductID = i.ProductID;
    if (@countTemp > 0)
	begin
			--�NInsert�إߪ�ProductID������color�MSize�g�Jtemptable��
			insert into #tempProducutStock
			select pc.ProductID,ps.ProductSizeID,pc.ProductColorID
			from [dbo].[ProductColor] as pc
			join [dbo].[ProductSize] as ps
			on pc.ProductID = ps.ProductID
			join inserted as i
			on ps.ProductID = i.ProductID;

			select @countTemp = count(*) from #tempProducutStock;
   
			while(@countTemp > 0)
			begin
					set rowcount 1
					select @prodID = tps.ProductID,
							@prodSizeID = tps.ProductSizeID,
							@prodColorID = tps.ProductColorID
						from #tempProducutStock tps;

					--To Something
					if not exists(select ProductID from [dbo].[ProductStock] as ps 
									where ps.ProductID = @prodID 
									and ps.ProductSizeID = @prodSizeID
									and ps.ProductColorID = @prodColorID )
					begin
							insert into [dbo].[ProductStock]
							values (@prodID,@prodSizeID, @prodColorID,0,10);
					end

					--�]��set rowcount 1�����Y�A�ҥH�@���u�|�R�@��
					delete from #tempProducutStock

					--�p���ٳѴX���A@countTemp > 0 �~��
					select @countTemp = count(*) from #tempProducutStock
			end
	end

	--##tempProducutStock�\�����h�A�A�i�H���F
	drop table #tempProducutStock   
GO

ALTER TABLE [dbo].[ProductColor] ENABLE TRIGGER [TR_EW_ProductColor_Insert]
GO

