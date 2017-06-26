CREATE TABLE category (
    cat_name varchar(30) PRIMARY KEY
);

CREATE TABLE classrooms (
    classroom_id varchar(9) PRIMARY KEY
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

INSERT INTO classrooms VALUES('WN.01.017');
INSERT INTO classrooms VALUES('WN.01.022');
INSERT INTO classrooms VALUES('WN.01.023');
INSERT INTO classrooms VALUES('WN.02.007');
INSERT INTO classrooms VALUES('WN.02.017');
INSERT INTO classrooms VALUES('WN.02.022');
INSERT INTO classrooms VALUES('WN.02.026');
INSERT INTO classrooms VALUES('WN.03.007');
INSERT INTO classrooms VALUES('WN.03.017');
INSERT INTO classrooms VALUES('WN.03.022');
INSERT INTO classrooms VALUES('WN.04.007');
INSERT INTO classrooms VALUES('WN.04.017');
INSERT INTO classrooms VALUES('WN.04.022');
INSERT INTO classrooms VALUES('WN.04.023');
INSERT INTO classrooms VALUES('WD.01.003');
INSERT INTO classrooms VALUES('WD.01.016');
INSERT INTO classrooms VALUES('WD.01.019');
INSERT INTO classrooms VALUES('WD.02.002');
INSERT INTO classrooms VALUES('WD.02.016');
INSERT INTO classrooms VALUES('WD.02.019');
INSERT INTO classrooms VALUES('WD.03.005');
INSERT INTO classrooms VALUES('WD.03.033');
INSERT INTO classrooms VALUES('WD.04.002');
INSERT INTO classrooms VALUES('H.01.403');
INSERT INTO classrooms VALUES('H.01.318');
INSERT INTO classrooms VALUES('H.01.208');
INSERT INTO classrooms VALUES('H.01.206');
INSERT INTO classrooms VALUES('H.02.403');
INSERT INTO classrooms VALUES('H.02.318');
INSERT INTO classrooms VALUES('H.02.308');
INSERT INTO classrooms VALUES('H.02.204');
INSERT INTO classrooms VALUES('H.02.111');
INSERT INTO classrooms VALUES('H.02.114');
INSERT INTO classrooms VALUES('H.03.403');
INSERT INTO classrooms VALUES('H.03.312');
INSERT INTO classrooms VALUES('H.03.308');
INSERT INTO classrooms VALUES('H.03.206');
INSERT INTO classrooms VALUES('H.04.403');
INSERT INTO classrooms VALUES('H.04.318');
INSERT INTO classrooms VALUES('H.04.312');
INSERT INTO classrooms VALUES('H.04.308');
INSERT INTO classrooms VALUES('H.04.206');