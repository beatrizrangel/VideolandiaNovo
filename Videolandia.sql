CREATE DATABASE Videolandia;


CREATE TABLE TFuncionarios (
    fun_cod int PRIMARY key IDENTITY,
    fun_usuario varchar(100),
    fun_senha varchar(100)
)

CREATE TABLE TMensagens (
cod_mensagem int primary key identity,
nome varchar(50),
email varchar(100),
assunto  varchar(100),
mensagem varchar(255)  
    )


CREATE TABLE TGeneros (
    gen_cod int primary key identity,
    gen_nome varchar (255) not null

)


CREATE TABLE TArtistas (
    art_cod int primary key identity,
    art_nome varchar(255) not null,
    art_paisnascimento varchar(255),
    art_dtnascimento date,
)


DROP DATABASE Videolandia

select * from TArtistas


DELETE FROM TArtistas


CREATE TABLE TFilmes (
    flm_cod int primary key identity,
    flm_codigobarras int not null,
    flm_nome varchar(255) not null,
    flm_cod_dir int FOREIGN key REFERENCES TArtistas (art_cod),
    flm_gen_cod1 int FOREIGN key REFERENCES TGeneros (gen_cod),
        flm_gen_cod2 int FOREIGN key REFERENCES TGeneros (gen_cod),
    flm_ano int not null,
    flm_tipo bit,
    flm_preco decimal (18,2) not null,
    flm_dtadquirido datetime not null,
    flm_custo decimal (18,2),
    flm_situacao bit,
    flm_foto varchar(255)
)






CREATE TABLE TFilmesGeneros (
flg_cod int primary key identity,
flg_flm_cod int foreign key references TFilmes(flm_cod),
flm_gen_cod int foreign key references TGeneros(gen_cod)
)



CREATE TABLE TFilmesArtistas (
    far_cod int primary key identity,
    far_flm_cod int FOREIGN key REFERENCES TFilmes (flm_cod),
    far_art_cod int FOREIGN key references TArtistas (art_cod),
    far_personagem varchar (255)

)








select * from TGeneros


