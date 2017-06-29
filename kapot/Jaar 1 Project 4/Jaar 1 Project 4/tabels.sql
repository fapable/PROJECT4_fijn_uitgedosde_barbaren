CREATE TABLE category (
    cat_name varchar(30) PRIMARY KEY
);

CREATE TABLE classrooms (
    classroom_id varchar(9) PRIMARY KEY,
    id_description text
);

CREATE TABLE questions (
    question_id int PRIMARY KEY,
    cat_name varchar(30),
    email varchar(100),
    name varchar(100),
    question text,
    FOREIGN KEY (cat_name) REFERENCES category(cat_name)
);

CREATE TABLE teachers (
    teacher_id varchar(5) PRIMARY KEY,
    cat_name varchar(30),
    password text,
    name varchar(100),
    FOREIGN KEY (cat_name) REFERENCES category(cat_name)
);

CREATE TABLE answer (
    question_id int,
    cat_name varchar(30),
    teacher_id varchar(5),
    answer text,
    FOREIGN KEY (question_id) REFERENCES questions(question_id),
    FOREIGN KEY (cat_name) REFERENCES category(cat_name),
    FOREIGN KEY (teacher_id) REFERENCES teachers(teacher_id)
);

CREATE TABLE events (
    event_id int PRIMARY KEY,
    classroom_id VARCHAR(9),
    cat_name VARCHAR(30),
    description text,
    duration int,
    start_time time,
    end_time time,
    event_name VARCHAR(100),
    FOREIGN KEY (classroom_id) REFERENCES classrooms(classroom_id),
    FOREIGN KEY (cat_name) REFERENCES category(cat_name)
);