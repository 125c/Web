select 課程編號,MAX(學分)
from [dbo].[課程]
group by 課程編號

select 學號, COUNT(課程編號) as cur
from 班級
group by 學號
having COUNT(課程編號)<=2

select  *
from 班級

select   課程編號,COUNT(課程編號)  as cur
from 班級
--where COUNT(學號)<=2
group by 課程編號
order by COUNT(課程編號) 