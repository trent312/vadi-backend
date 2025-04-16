/*****************************/
/* Obtiene todos los estados */
/*****************************/
create or alter procedure usp_estado_get
as
begin
	select IdEstado, Estado as NombreEstado from Estados
end
go

/*************************/
/* Elimina una solicitud */
/*************************/
create or alter procedure usp_solicitud_delete
(
	@Id int
)
as
begin
	delete from Solicitudes where Id = @Id
end
go

/***********************************************/
/* Obtiene todas las solicitudes con su estado */
/***********************************************/
create or alter procedure usp_solicitud_get
as
begin
	select		s.*, e.Estado
	from		Solicitudes	s
	inner join	Estados		e	on	s.IdEstado	=	e.IdEstado
end
go

/*************************/
/* Inserta una solicitud */
/*************************/
create or alter procedure usp_solicitud_insert
(
	@FechaSolicitud date,
	@Solicitante nvarchar(100),
	@IdEstado int
)
as
begin
	declare @Id int = (select max(Id) + 1 from Solicitudes)
	insert into Solicitudes
		(Id, FechaSolicitud, Solicitante, IdEstado)
	values
		(@Id, @FechaSolicitud, @Solicitante, @IdEstado)
end
go

/***************************/
/* Actualiza una solicitud */
/***************************/
create or alter procedure usp_solicitud_update
(
	@Id int,
	@FechaSolicitud date,
	@Solicitante nvarchar(100),
	@IdEstado int
)
as
begin
	update	Solicitudes
	set		FechaSolicitud = @FechaSolicitud,
			Solicitante = @Solicitante,
			IdEstado = @IdEstado
	where	Id = @Id
end
go

/******************************************/
/* Obtiene las solicitudes entre 2 fechas */
/******************************************/
create or alter procedure usp_solicitud_get_by_dates
(
	@startDate datetime,
	@endDate datetime
)
as
begin
	select		s.*, e.Estado
	from		Solicitudes	s
	inner join	Estados		e	on	s.IdEstado	= e.IdEstado
	where		FechaSolicitud between @startDate and @endDate
end
go

/*************************************/
/* Obtiene las últimas 5 solicitudes */
/*************************************/
create or alter procedure usp_solicitud_get_last_five
as
begin
	select		top 5 s.*, e.Estado
	from		Solicitudes	s
	inner join	Estados		e	on	s.IdEstado	= e.IdEstado
	order by	s.FechaSolicitud desc
end