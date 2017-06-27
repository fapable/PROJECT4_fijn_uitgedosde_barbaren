CREATE TABLE opleiding(
    opleiding_naam varchar(100) PRIMARY KEY,
    description text,
    duration int,
    diploma_type varchar(100),
    jobs text
);

CREATE TABLE classrooms (
    classroom_id varchar(9) PRIMARY KEY
);

CREATE TABLE questions (
    question_id int PRIMARY KEY,
    opleiding_naam varchar(100),
    email varchar(100),
    name varchar(100),
    question text,
    FOREIGN KEY (opleiding_naam) REFERENCES opleiding(opleiding_naam)
);

CREATE TABLE teachers (
    teacher_id varchar(5) PRIMARY KEY,
    opleiding_naam varchar(100),
    teacher_code varchar(20),
    name varchar(100),
    FOREIGN KEY (opleiding_naam) REFERENCES opleiding(opleiding_naam)
);

CREATE TABLE answer (
    question_id int,
    opleiding_naam varchar(100),
    teacher_id varchar(5),
    answer text,
    FOREIGN KEY (question_id) REFERENCES questions(question_id),
    FOREIGN KEY (opleiding_naam) REFERENCES opleiding(opleiding_naam),
    FOREIGN KEY (teacher_id) REFERENCES teachers(teacher_id)
);

CREATE TABLE events (
    even,t_id int PRIMARY KEY,
    classroom_id VARCHAR(9),
    opleiding_naam VARCHAR(100),
    description text,
    duration int,
    start_time time,
    end_time time,
    event_name VARCHAR(100),
    FOREIGN KEY (classroom_id) REFERENCES classrooms(classroom_id),
    FOREIGN KEY (opleiding_naam) REFERENCES opleiding(opleiding_naam)
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
INSERT INTO classrooms VALUES('WD.02.216');
INSERT INTO classrooms VALUES('WD.02.308');

INSERT INTO opleiding VALUES('Communicatie','The Communication program is innovative and practical and leads you to a "smart connector". A smart connector is a professional that connects people with the use of, for example, social tools, big data and co-creation.',4,'Bachelor of Arts (BA)','Communications adviser, Communicatie manager');
INSERT INTO opleiding VALUES('Informatica','As an IT technician you will be able to analyze, design, implement and implement complex ICT systems, taking into account the wishes of the client or user of the system.',4,'Bachelor of Science (BSc)','Software engineer, Software analist');
INSERT INTO opleiding VALUES('Technical Informatica','During the course of the study you will be familiar with the technical aspects of ICT. You learn to program in various programming languages, which teaches you to develop solutions for different devices, robots and systems.',4,'Bachelor of Science (BSc)','Embedded systems engineer, Network security engineer');
INSERT INTO opleiding VALUES('Communication and multimedia design','u investigate who wants to use such interactive products and services, why and in what situation. You develop ideas that make the product unique and experiment with it.',4,'Bachelor of Science (BSc)','Interaction designer, Visual designer');
INSERT INTO opleiding VALUES('Creative Media and Game Technologies','As a CMGTer, you are a developer (programmer) of interactive digital products: you develop web and mobile applications and you know the basis of game development.',4,'Bachelor of Science (BSc)','Game developer, Mobile developer');
INSERT INTO opleiding VALUES('Leisure Management','A leisure manager designs and produces innovative and exciting experiences in a (large) urban environment.',4,'Bachelor of Arts (BA)','Leisure managemer');

INSERT INTO teachers VALUES ('test1','Communicatie','test1','testacc1');
INSERT INTO teachers VALUES ('test2','Informatica','test2','testacc2');
INSERT INTO teachers VALUES ('test3','Technical Informatica','test3','testacc3');
INSERT INTO teachers VALUES ('test4','Communication and multimedia design','test4','testacc4');
INSERT INTO teachers VALUES ('test5','Creative Media and Game Technologies','test5','testacc5');
INSERT INTO teachers VALUES ('test6','Leisure Management','test6','testacc6');

INSERT INTO events VALUES(01,'H.02.403','Communicatie','Students will use their creativity to improve the imago of a non existing company',120,TIME '13:00:00', TIME '15:00:00','Super imago me');
INSERT INTO events VALUES(02,'H.02.318','Communicatie','Students will try to think about social media strategies to improve the social media of a non existing company',60,TIME '13:30:00', TIME '14:30:00','Social media freak');
INSERT INTO events VALUES(03,'H.02.204','Communicatie','Students will plan and create a commercial for a non existing radio station.',120,TIME '13:00:00', TIME '15:00:00','Commercial city');
INSERT INTO events VALUES(04,'H.04.403','Informatica','Students will use programming code to fight an enemy in a game.',180,TIME '13:00:00', TIME '16:00:00','Stop the big enemy');
INSERT INTO events VALUES(05,'H.04.318','Informatica','Students will repair a broken down car in a game with the use of code',180,TIME '13:00:00', TIME '16:00:00','Fix the car');
INSERT INTO events VALUES(06,'H.04.312','Informatica','Students will replicate the snake game with the use of code',180,TIME '13:00:00', TIME '16:00:00','Snake game');
INSERT INTO events VALUES(07,'WN.04.007','Technical Informatica','Students will make a mini robot that can walk and crouch',180,TIME '13:00:00', TIME '16:00:00','Robot inventor');
INSERT INTO events VALUES(08,'H.04.308','Technical Informatica','Students will add functions to an real ATM machine.',180,TIME '13:00:00', TIME '16:00:00','ATM machine designer');
INSERT INTO events VALUES(09,'H.04.206','Technical Informatica','Students will program a train to drive',180,TIME '13:00:00', TIME '16:00:00','Train ride');
INSERT INTO events VALUES(10,'H.03.403','Communication and multimedia design','Students will use their creativity to make a prototype for a product.',120,TIME '13:00:00', TIME '15:00:00','Concept maker');
INSERT INTO events VALUES(11,'H.03.312','Communication and multimedia design','Students will use their analytical skills to review a couple designs.',120,TIME '13:00:00', TIME '15:00:00','Design chooser');
INSERT INTO events VALUES(12,'H.03.308','Communication and multimedia design','Students will have clients explain to them what their product vision is, the students will then create concepts for that vision.',120,TIME '13:00:00', TIME '15:00:00','From vision to design');
INSERT INTO events VALUES(13,'WN.03.007','Creative Media and Game Technologies','Students will add elements to an indie game',180,TIME '13:00:00', TIME '16:00:00','Game maker');
INSERT INTO events VALUES(14,'WD.03.005','Creative Media and Game Technologies','Students will review a website and test it on many levels.',180,TIME '13:00:00', TIME '16:00:00','Test my website');
INSERT INTO events VALUES(15,'H.03.206','Creative Media and Game Technologies','Student will make an website for a non existing company',120,TIME '13:00:00', TIME '15:00:00','Website builder');
INSERT INTO events VALUES(16,'WD.02.216','Leisure Management','Student will plan a rock music festival.',120,TIME '13:00:00', TIME '15:00:00','Create me a festival');
INSERT INTO events VALUES(17,'WD.02.308','Leisure Management','Student will solve problems that are in a non existing jazz music festival',120,TIME '13:00:00', TIME '15:00:00','Festival problems');
INSERT INTO events VALUES(18,'WN.02.007','Leisure Management','Student will plan a party for a non existing neighbourhood.',120,TIME '13:00:00', TIME '15:00:00','Neighbour party');


