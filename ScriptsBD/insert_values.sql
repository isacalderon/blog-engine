insert roles (name, active) values ('ADMIN', true);
insert roles (name, active) values ('EDITOR', true);
insert roles (name, active) values ('WRITER', true);
insert roles (name, active) values ('PUBLIC', true);

insert users (name, lastname, email, role, password) values ('luis', 'garcia', 'l.garcia@email.com', 2, '1456');
insert users (name, lastname, email, role, password) values ('admin', 'admin', 'admin@email,com', 1, '123');
insert users (name, lastname, email, role, password) values('Maria', 'Perez', 'm.perez@email.com', 3, '123');
insert users (name, lastname, email, role, password) values('Juan', 'Gomez', 'j.gomez@email.com', 4, '123');

insert status (name) values ('DRAFT');
insert status (name) values ('SUBMITTED');
insert status (name) values ('PENDING');
insert status (name) values ('REJECTED');
insert status (name) values ('APPROVED');

insert posts (title, content, author, created_at, updated_at) values ('Post 1', 'Content 1', 3, now(), now());

insert comments (content, author, post) values ('Comment 1', 4, 1);
insert comments (content, author, post) values ('Comment 2', 3, 1);

insert post_status (post, comment_editor, created_at, status) values (1, 'Comment 1', now(), 1);
insert post_status (post, comment_editor, created_at, status) values (1, '', now(), 3);
insert post_status (post, comment_editor, created_at, status) values (1, '', now(), 4);