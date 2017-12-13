USE [QLDSV]
GO

/****** Object:  View [dbo].[GetSubscriptions]    Script Date: 11/29/2017 9:26:39 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[GetSubscriptions]
as
SELECT name as Name,
		sms.subscriber_server as ServerName
  FROM (SELECT name, [description], pubid FROM sysmergepublications smp WHERE [publisher_db] = 'QLDSV') smp
  INNER JOIN (SELECT subscriber_server, pubid FROM sysmergesubscriptions WHERE db_name = 'QLDSV' AND pubid != subid) sms
  ON smp.pubid = sms.pubid
GO


