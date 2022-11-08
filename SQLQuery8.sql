select AL.Alert,P.Pname,AL.AlertID,A.Aid,A.Apname +' '+A.Alname AS fullName from Properties AS P
inner join Alerts AS AL
On AL.Pid=P.Pid
inner join Agents AS A
On A.Aid = AL.Aid
Order By AlertID DESC  OFFSET 0 ROWS FETCH FIRST 5 ROWS ONLY


select * from Properties  
where Pagent_id = 2107
Order By Pid DESC  OFFSET 0 ROWS FETCH FIRST 1 ROWS ONLY

Update Properties set Deleted='Deleted' where Pid = 2032

Alter Table Properties 
Add Deleted nvarchar(10)

UPDATE Properties Set Pname ='Hgvora netivot',Prooms=4,Pfloor = 10,Padress = 'Hagvora 13                                        ',Pcity = '24',Psize = 24,Pprice = 9,Pagent_id=2107 ,Deleted = '' Where Pid = 2035



