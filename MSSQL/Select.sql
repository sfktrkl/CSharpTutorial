select * from First
select Name from First
select Name, Surname from First

select Name, Surname from First where Name='Charles'
select Name, Surname from First where Name='Charles' and Job=1

select * from First where Name='Jim' or Surname=null

/* Sometimes table name or column might be long, so an alias can be used */
select ft.Job from First ft

/* To merge the two table */
select ft.Name, ft.Surname, j.Name from First ft, Job j where ft.Job=j.ID
select ft.Name, ft.Surname, j.Name from First ft, Job j where ft.Job=j.ID and ft.Name='Charles'

select ft.Name, ft.Surname, j.Name as Job_Name from First ft, Job j where ft.Job=j.ID and ft.Name='Charles'
