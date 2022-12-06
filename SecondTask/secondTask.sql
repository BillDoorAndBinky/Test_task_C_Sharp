create table secondTask.category
(
    id   int          not null
        constraint category_pk
            primary key,
    name varchar(100) not null
)
go

create table secondTask.product
(
    id   int          not null
        constraint product_pk
            primary key nonclustered,
    name varchar(100) not null
)
go

create table secondTask.product_category
(
    id          int not null
        constraint product_category_pk
            primary key nonclustered,
    product_id  int not null
        constraint product_category_product_null_fk
            references secondTask.product,
    category_id int not null
        constraint product_category_category_null_fk
            references secondTask.category
)
go

create index product_category_category_id_index
    on secondTask.product_category (category_id)
go

create index product_category_product_id_index
    on secondTask.product_category (product_id)
go

INSERT INTO secondTask.product (id, name) VALUES (1, N'Apple');
INSERT INTO secondTask.product (id, name) VALUES (2, N'Carrot');
INSERT INTO secondTask.product (id, name) VALUES (3, N'Board');
INSERT INTO secondTask.product (id, name) VALUES (4, N'Carrot board');
INSERT INTO secondTask.product (id, name) VALUES (5, N'Apple board');
INSERT INTO secondTask.product (id, name) VALUES (6, N'New Year Carrot board');
INSERT INTO secondTask.product (id, name) VALUES (7, N'New Year Board');
INSERT INTO secondTask.product (id, name) VALUES (8, N'Engine');
INSERT INTO secondTask.product (id, name) VALUES (9, N'New Year Carrot Apple Board');
INSERT INTO secondTask.product (id, name) VALUES (10, N'Notebook');

INSERT INTO secondTask.category (id, name) VALUES (1, N'Vegetable');
INSERT INTO secondTask.category (id, name) VALUES (2, N'Fruit');
INSERT INTO secondTask.category (id, name) VALUES (3, N'Construction materials');
INSERT INTO secondTask.category (id, name) VALUES (4, N'Christmas products');

INSERT INTO secondTask.product_category (id, product_id, category_id) VALUES (1, 1, 2);
INSERT INTO secondTask.product_category (id, product_id, category_id) VALUES (2, 2, 1);
INSERT INTO secondTask.product_category (id, product_id, category_id) VALUES (3, 3, 3);
INSERT INTO secondTask.product_category (id, product_id, category_id) VALUES (4, 4, 1);
INSERT INTO secondTask.product_category (id, product_id, category_id) VALUES (5, 4, 3);
INSERT INTO secondTask.product_category (id, product_id, category_id) VALUES (6, 5, 2);
INSERT INTO secondTask.product_category (id, product_id, category_id) VALUES (7, 5, 3);
INSERT INTO secondTask.product_category (id, product_id, category_id) VALUES (8, 6, 1);
INSERT INTO secondTask.product_category (id, product_id, category_id) VALUES (9, 6, 3);
INSERT INTO secondTask.product_category (id, product_id, category_id) VALUES (10, 6, 4);
INSERT INTO secondTask.product_category (id, product_id, category_id) VALUES (11, 7, 3);
INSERT INTO secondTask.product_category (id, product_id, category_id) VALUES (12, 7, 4);
INSERT INTO secondTask.product_category (id, product_id, category_id) VALUES (13, 9, 1);
INSERT INTO secondTask.product_category (id, product_id, category_id) VALUES (14, 9, 2);
INSERT INTO secondTask.product_category (id, product_id, category_id) VALUES (15, 9, 3);
INSERT INTO secondTask.product_category (id, product_id, category_id) VALUES (16, 9, 4);



select p.name, c.name
from secondTask.product p
         left join secondTask.product_category pc on p.id = pc.product_id
         left join secondTask.category c on c.id = pc.category_id