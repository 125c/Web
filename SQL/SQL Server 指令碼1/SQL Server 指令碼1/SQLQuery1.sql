select �ҵ{�s��,MAX(�Ǥ�)
from [dbo].[�ҵ{]
group by �ҵ{�s��

select �Ǹ�, COUNT(�ҵ{�s��) as cur
from �Z��
group by �Ǹ�
having COUNT(�ҵ{�s��)<=2

select  *
from �Z��

select   �ҵ{�s��,COUNT(�ҵ{�s��)  as cur
from �Z��
--where COUNT(�Ǹ�)<=2
group by �ҵ{�s��
order by COUNT(�ҵ{�s��) 