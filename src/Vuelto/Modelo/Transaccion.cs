using System.ComponentModel.DataAnnotations;

namespace Vuelto.Modelo
{
    public class Transaccion
    {
        [Key]
        public double ImporteFactura { get; set; }
        public double Vuelto { get; set; }
#pragma warning disable CS8618
        public string VueltoEntregado { get; set; }
#pragma warning restore CS8618
    }
}

/*
# En base de datos: #

USE [Vuelto]
GO

ALTER TABLE [dbo].[Transaccion] DROP CONSTRAINT [DF__Transacci__Trans__25869641]
GO

IF EXISTS(SELECT* FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Transaccion]') AND type in (N'U'))
DROP TABLE[dbo].[Transaccion]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Transaccion] (

[TransaccionId][uniqueidentifier] NOT NULL,

[ImporteFactura] [decimal] (18, 2) NOT NULL,

[Vuelto] [decimal] (18, 2) NOT NULL,

[VueltoEntregado] [varchar] (max)NOT NULL,
PRIMARY KEY CLUSTERED 
(

    [TransaccionId] ASC
)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]
GO

ALTER TABLE [dbo].[Transaccion] ADD DEFAULT(newid()) FOR[TransaccionId]
GO
*/