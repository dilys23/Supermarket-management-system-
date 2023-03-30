use QuanLySieuThi1
go 

create table MatHang(
      MaMH varchar(50) Primary key ,
	  TenMH nvarchar(50),
	  NhaSX nvarchar (50)
	  );
select * From MatHang

create table SanPham(
        MaSP varchar(50) primary key,
		TenSP nvarchar(50),
		Ngaynhap date,
		Tinhtrang bit,
		MaMH varchar(50),
		foreign key (MaMH) references MatHang(MaMH)
		)
 
 select * from SanPham

 insert into MatHang values('MH101','Banh Keo','Cty Orion')
 insert into MatHang values('MH102','Sua','Cty Vinamilk')
 insert into MatHang values('MH103','Cafe','Cty Nescafe')
 insert into MatHang values('MH104','Gia vi','Cty Ajnamoto')

 insert into SanPham values ('SP101', 'Chocopie', '2023-3-24', 1, 'MH101')
 insert into SanPham values ('SP102', 'SuaDau', '2023-3-23', 0, 'MH102')
 insert into SanPham values ('SP103', 'Capuchino', '2023-3-21', 1, 'MH103')
 insert into SanPham values ('SP104', 'Dau Hao', '2023-3-26', 0, 'MH104')


