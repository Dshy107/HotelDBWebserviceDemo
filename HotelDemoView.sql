select h.Hotel_No, h.Name, r.Room_No, r.Types, r.Price
from hotel h
inner join room r
on h.Hotel_No = r.Hotel_No
order by r.Hotel_No, r.Room_No