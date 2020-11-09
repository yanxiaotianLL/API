CREATE TABLE [dbo].[T_JC_BarcodeHistory] (
    [Id]         INT          IDENTITY (1, 1) NOT NULL,
    [BarCode]    VARCHAR (20) NULL,
    [IsDelete]   INT          NULL,
    [CreateTime] DATETIME     NULL,
    [UpdateTime] DATETIME     NULL,
    [TaskUnitId] INT          NULL,
    CONSTRAINT [PK_T_JC_BARCODEHISTORY] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_T_JC_BAR_REFERENCE_T_JC_TAS] FOREIGN KEY ([TaskUnitId]) REFERENCES [dbo].[T_JC_TaskUnit] ([Id])
);

