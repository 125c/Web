select *
from 學生
where 生日 >='19910101'
select *
from 教授
where 職稱 like '%[cklj]%'/*[]中內任一個都可以（夾在%%中間）*/
select *
from 教授
where 職稱 like '%[^cklj]%'/*其中一個字符合「沒有cklj」的條件*/