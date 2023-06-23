using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class SISContext : DbContext
    {
        public SISContext()
        {
        }

        public SISContext(DbContextOptions<SISContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AcademicSemester> AcademicSemesters { get; set; }
        public virtual DbSet<Academicgroup> Academicgroups { get; set; }
        public virtual DbSet<Academiclevel> Academiclevels { get; set; }
        public virtual DbSet<Academicrecord> Academicrecords { get; set; }
        public virtual DbSet<Academicrecord20220218> Academicrecord20220218s { get; set; }
        public virtual DbSet<AcademicrecordCamark> AcademicrecordCamarks { get; set; }
        public virtual DbSet<AcademicrecordCredit> AcademicrecordCredits { get; set; }
        public virtual DbSet<AcademicrecordEndsemmark> AcademicrecordEndsemmarks { get; set; }
        public virtual DbSet<AcademicrecordRef> AcademicrecordRefs { get; set; }
        public virtual DbSet<AcademicrecordRegisteredwithoutpaying> AcademicrecordRegisteredwithoutpayings { get; set; }
        public virtual DbSet<AcademicrecordRegisteredwithoutpaying2> AcademicrecordRegisteredwithoutpaying2s { get; set; }
        public virtual DbSet<AcademicrecordRegisteredwithoutpaying3> AcademicrecordRegisteredwithoutpaying3s { get; set; }
        public virtual DbSet<Academicrecordonline> Academicrecordonlines { get; set; }
        public virtual DbSet<Academicrecordresit> Academicrecordresits { get; set; }
        public virtual DbSet<Academicrecorduploadfile> Academicrecorduploadfiles { get; set; }
        public virtual DbSet<Adt> Adts { get; set; }
        public virtual DbSet<Alumnidetail> Alumnidetails { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual DbSet<Awardclass> Awardclasses { get; set; }
        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<Bankaccount> Bankaccounts { get; set; }
        public virtual DbSet<Billactivitylog> Billactivitylogs { get; set; }
        public virtual DbSet<Building> Buildings { get; set; }
        public virtual DbSet<Building1> Buildings1 { get; set; }
        public virtual DbSet<BuildingLevel> BuildingLevels { get; set; }
        public virtual DbSet<Calendar> Calendars { get; set; }
        public virtual DbSet<Calendardetail> Calendardetails { get; set; }
        public virtual DbSet<Campus> Campuses { get; set; }
        public virtual DbSet<Campus2> Campus2s { get; set; }
        public virtual DbSet<Certificatetype> Certificatetypes { get; set; }
        public virtual DbSet<Classparameter> Classparameters { get; set; }
        public virtual DbSet<ClassparameterBk> ClassparameterBks { get; set; }
        public virtual DbSet<Classroom> Classrooms { get; set; }
        public virtual DbSet<Collection> Collections { get; set; }
        public virtual DbSet<Collectionprogrammestream> Collectionprogrammestreams { get; set; }
        public virtual DbSet<College> Colleges { get; set; }
        public virtual DbSet<College1> Colleges1 { get; set; }
        public virtual DbSet<Connecteddevice> Connecteddevices { get; set; }
        public virtual DbSet<Control> Controls { get; set; }
        public virtual DbSet<Controlrole> Controlroles { get; set; }
        public virtual DbSet<Controlstate> Controlstates { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseLecturer1> CourseLecturers1 { get; set; }
        public virtual DbSet<CourseSchedule> CourseSchedules { get; set; }
        public virtual DbSet<CourseScheduleLecturer> CourseScheduleLecturers { get; set; }
        public virtual DbSet<Courselecturer> Courselecturers { get; set; }
        public virtual DbSet<Courseregistrationexception> Courseregistrationexceptions { get; set; }
        public virtual DbSet<Coursesetting> Coursesettings { get; set; }
        public virtual DbSet<Coursestatus> Coursestatuses { get; set; }
        public virtual DbSet<Coursetype> Coursetypes { get; set; }
        public virtual DbSet<Covidvaccinetype> Covidvaccinetypes { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<Datasource> Datasources { get; set; }
        public virtual DbSet<Dayofweek> Dayofweeks { get; set; }
        public virtual DbSet<Daysession> Daysessions { get; set; }
        public virtual DbSet<Dddd> Dddds { get; set; }
        public virtual DbSet<Degree> Degrees { get; set; }
        public virtual DbSet<Degreetype> Degreetypes { get; set; }
        public virtual DbSet<Del2studentsWithtrails20212> Del2studentsWithtrails20212s { get; set; }
        public virtual DbSet<Del2studentsWithtrails20212Greaterthan2> Del2studentsWithtrails20212Greaterthan2s { get; set; }
        public virtual DbSet<Del2studentsWithtrails20212Greaterthan2Registered> Del2studentsWithtrails20212Greaterthan2Registereds { get; set; }
        public virtual DbSet<DelCurrent> DelCurrents { get; set; }
        public virtual DbSet<DelCurrentx> DelCurrentxes { get; set; }
        public virtual DbSet<DelCwaFinalyear> DelCwaFinalyears { get; set; }
        public virtual DbSet<DelIdlarmisreconciled> DelIdlarmisreconcileds { get; set; }
        public virtual DbSet<DelResidencemove> DelResidencemoves { get; set; }
        public virtual DbSet<DelStudentregistered2All> DelStudentregistered2Alls { get; set; }
        public virtual DbSet<DelStudentregisteredWhileowing> DelStudentregisteredWhileowings { get; set; }
        public virtual DbSet<DelStudentregisteredWhileowing2> DelStudentregisteredWhileowing2s { get; set; }
        public virtual DbSet<DelStudentregisteredWhileowingAcadrecord> DelStudentregisteredWhileowingAcadrecords { get; set; }
        public virtual DbSet<DelStudentregisteredWhileowingAcadrecords2> DelStudentregisteredWhileowingAcadrecords2s { get; set; }
        public virtual DbSet<DelStudentregisteredWhileowingMsg> DelStudentregisteredWhileowingMsgs { get; set; }
        public virtual DbSet<DelStudentregisteredWhileowingMsg2> DelStudentregisteredWhileowingMsg2s { get; set; }
        public virtual DbSet<DelStudentregisteredWhileowingMsgBelow10> DelStudentregisteredWhileowingMsgBelow10s { get; set; }
        public virtual DbSet<DelStudentregisteredWhileowingMsgWithcheck> DelStudentregisteredWhileowingMsgWithchecks { get; set; }
        public virtual DbSet<DeleteTempSpecialgraduation> DeleteTempSpecialgraduations { get; set; }
        public virtual DbSet<Deleteme> Deletemes { get; set; }
        public virtual DbSet<Deleteme2> Deleteme2s { get; set; }
        public virtual DbSet<Delmary> Delmaries { get; set; }
        public virtual DbSet<Delmary2> Delmary2s { get; set; }
        public virtual DbSet<Delmastercard> Delmastercards { get; set; }
        public virtual DbSet<Delme> Delmes { get; set; }
        public virtual DbSet<Delmegrad> Delmegrads { get; set; }
        public virtual DbSet<DelstudentsWithcwa20212> DelstudentsWithcwa20212s { get; set; }
        public virtual DbSet<DelstudentsWithtrails20212> DelstudentsWithtrails20212s { get; set; }
        public virtual DbSet<DelstudentsWithtrails20212Cwa> DelstudentsWithtrails20212Cwas { get; set; }
        public virtual DbSet<DelstudentsWithtrails20212CwaLessthan3> DelstudentsWithtrails20212CwaLessthan3s { get; set; }
        public virtual DbSet<DelstudentsWithtrails20212CwaLessthan3CwaBelowMin> DelstudentsWithtrails20212CwaLessthan3CwaBelowMins { get; set; }
        public virtual DbSet<DelstudentsWithtrails20212CwaLessthan3CwaBelowMinRegistered> DelstudentsWithtrails20212CwaLessthan3CwaBelowMinRegistereds { get; set; }
        public virtual DbSet<DelstudentsWithtrails20212Greaterthan2> DelstudentsWithtrails20212Greaterthan2s { get; set; }
        public virtual DbSet<DelstudentsWithtrails20212Greaterthan2Registered> DelstudentsWithtrails20212Greaterthan2Registereds { get; set; }
        public virtual DbSet<Denomination> Denominations { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Department1> Departments1 { get; set; }
        public virtual DbSet<Disability> Disabilities { get; set; }
        public virtual DbSet<Duration> Durations { get; set; }
        public virtual DbSet<Ebhr> Ebhrs { get; set; }
        public virtual DbSet<Ebolaassessment> Ebolaassessments { get; set; }
        public virtual DbSet<Electiveset> Electivesets { get; set; }
        public virtual DbSet<Examcentre> Examcentres { get; set; }
        public virtual DbSet<Examinvigilator> Examinvigilators { get; set; }
        public virtual DbSet<Examperiod> Examperiods { get; set; }
        public virtual DbSet<Examtimetable> Examtimetables { get; set; }
        public virtual DbSet<Examtimetabledetail> Examtimetabledetails { get; set; }
        public virtual DbSet<Examverification> Examverifications { get; set; }
        public virtual DbSet<ExamverificationDel> ExamverificationDels { get; set; }
        public virtual DbSet<ExamverificationbackupDelete> ExamverificationbackupDeletes { get; set; }
        public virtual DbSet<Examverificationerror> Examverificationerrors { get; set; }
        public virtual DbSet<Exchangerate> Exchangerates { get; set; }
        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<Faculty1> Faculties1 { get; set; }
        public virtual DbSet<Feature> Features { get; set; }
        public virtual DbSet<Feecategory> Feecategories { get; set; }
        public virtual DbSet<Feecategorymap> Feecategorymaps { get; set; }
        public virtual DbSet<Feeclassification> Feeclassifications { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Feegroup> Feegroups { get; set; }
        public virtual DbSet<Feeitem> Feeitems { get; set; }
        public virtual DbSet<Feeitembank> Feeitembanks { get; set; }
        public virtual DbSet<Feeitembankaccount> Feeitembankaccounts { get; set; }
        public virtual DbSet<Feeitembankaccountresidence> Feeitembankaccountresidences { get; set; }
        public virtual DbSet<Feeitemschedule> Feeitemschedules { get; set; }
        public virtual DbSet<Feelog> Feelogs { get; set; }
        public virtual DbSet<Feerequirement> Feerequirements { get; set; }
        public virtual DbSet<Feeschedule> Feeschedules { get; set; }
        public virtual DbSet<Feethreshold> Feethresholds { get; set; }
        public virtual DbSet<Feethresholdprogrammestream> Feethresholdprogrammestreams { get; set; }
        public virtual DbSet<Feetype> Feetypes { get; set; }
        public virtual DbSet<Fff> Fffs { get; set; }
        public virtual DbSet<FloorType> FloorTypes { get; set; }
        public virtual DbSet<Gcmuser> Gcmusers { get; set; }
        public virtual DbSet<Gradingsystem> Gradingsystems { get; set; }
        public virtual DbSet<Gradingsystemclass> Gradingsystemclasses { get; set; }
        public virtual DbSet<Gradingsystemnonscoringcourse> Gradingsystemnonscoringcourses { get; set; }
        public virtual DbSet<Gradingsystemscoring> Gradingsystemscorings { get; set; }
        public virtual DbSet<Gradingsystemscoringexception> Gradingsystemscoringexceptions { get; set; }
        public virtual DbSet<Gradingsystemtype> Gradingsystemtypes { get; set; }
        public virtual DbSet<Graduate> Graduates { get; set; }
        public virtual DbSet<Graduatelog> Graduatelogs { get; set; }
        public virtual DbSet<Graduatetype> Graduatetypes { get; set; }
        public virtual DbSet<GraduationdataJune2016> GraduationdataJune2016s { get; set; }
        public virtual DbSet<GraduationdataJune2017> GraduationdataJune2017s { get; set; }
        public virtual DbSet<Graduationfeeschedule> Graduationfeeschedules { get; set; }
        public virtual DbSet<Graduationpaymentexception> Graduationpaymentexceptions { get; set; }
        public virtual DbSet<GraduationpaymentexceptionOld> GraduationpaymentexceptionOlds { get; set; }
        public virtual DbSet<Graduationpictureauthorizer> Graduationpictureauthorizers { get; set; }
        public virtual DbSet<Graduationpictureauthorizertype> Graduationpictureauthorizertypes { get; set; }
        public virtual DbSet<GraduationregisterTempAfterDeadline> GraduationregisterTempAfterDeadlines { get; set; }
        public virtual DbSet<Graduationstream> Graduationstreams { get; set; }
        public virtual DbSet<Graduationstreameffectivedate> Graduationstreameffectivedates { get; set; }
        public virtual DbSet<Graduationstreamsetting> Graduationstreamsettings { get; set; }
        public virtual DbSet<Graduationstreamstatus> Graduationstreamstatuses { get; set; }
        public virtual DbSet<Graduationtype> Graduationtypes { get; set; }
        public virtual DbSet<Graduationuser> Graduationusers { get; set; }
        public virtual DbSet<Idcardapiclientupdate> Idcardapiclientupdates { get; set; }
        public virtual DbSet<Idcardapidatastaff> Idcardapidatastaffs { get; set; }
        public virtual DbSet<Idcardapidatastudent> Idcardapidatastudents { get; set; }
        public virtual DbSet<Idcardapierrorlog> Idcardapierrorlogs { get; set; }
        public virtual DbSet<Idcardapirequestlog> Idcardapirequestlogs { get; set; }
        public virtual DbSet<Idcardapitestuser> Idcardapitestusers { get; set; }
        public virtual DbSet<Idcardapiuser> Idcardapiusers { get; set; }
        public virtual DbSet<Institution> Institutions { get; set; }
        public virtual DbSet<Institutiontype> Institutiontypes { get; set; }
        public virtual DbSet<Invigilator> Invigilators { get; set; }
        public virtual DbSet<Lect> Lects { get; set; }
        public virtual DbSet<Lectureperiod> Lectureperiods { get; set; }
        public virtual DbSet<Lecturer> Lecturers { get; set; }
        public virtual DbSet<Lecturer1> Lecturers1 { get; set; }
        public virtual DbSet<Lecturerpreference> Lecturerpreferences { get; set; }
        public virtual DbSet<Lecturetimetable> Lecturetimetables { get; set; }
        public virtual DbSet<Level> Levels { get; set; }
        public virtual DbSet<Mainfmisaccount> Mainfmisaccounts { get; set; }
        public virtual DbSet<Manillaemailrecipient> Manillaemailrecipients { get; set; }
        public virtual DbSet<Maritalstatus> Maritalstatuses { get; set; }
        public virtual DbSet<Mastercourse> Mastercourses { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }
        public virtual DbSet<Mismatchpayment> Mismatchpayments { get; set; }
        public virtual DbSet<Mobileappsetting> Mobileappsettings { get; set; }
        public virtual DbSet<Mobilenetworkcode> Mobilenetworkcodes { get; set; }
        public virtual DbSet<Netsetting> Netsettings { get; set; }
        public virtual DbSet<NursingstudentsTemppwdDel> NursingstudentsTemppwdDels { get; set; }
        public virtual DbSet<Onlineadmin> Onlineadmins { get; set; }
        public virtual DbSet<Onlinelog> Onlinelogs { get; set; }
        public virtual DbSet<Organizationalunit> Organizationalunits { get; set; }
        public virtual DbSet<Paymentchannel> Paymentchannels { get; set; }
        public virtual DbSet<Paymentlocation> Paymentlocations { get; set; }
        public virtual DbSet<Paymenttype> Paymenttypes { get; set; }
        public virtual DbSet<Pgstudentthesistopic> Pgstudentthesistopics { get; set; }
        public virtual DbSet<Placeofresidence> Placeofresidences { get; set; }
        public virtual DbSet<Programme> Programmes { get; set; }
        public virtual DbSet<ProgrammeStream1> ProgrammeStreams1 { get; set; }
        public virtual DbSet<Programmecourse> Programmecourses { get; set; }
        public virtual DbSet<Programmeoption> Programmeoptions { get; set; }
        public virtual DbSet<Programmeoptioncourse> Programmeoptioncourses { get; set; }
        public virtual DbSet<Programmeoptioncoursecampuslecturer> Programmeoptioncoursecampuslecturers { get; set; }
        public virtual DbSet<Programmeoptioncourselecturer> Programmeoptioncourselecturers { get; set; }
        public virtual DbSet<Programmeoptionuser> Programmeoptionusers { get; set; }
        public virtual DbSet<Programmesemester> Programmesemesters { get; set; }
        public virtual DbSet<Programmestream> Programmestreams { get; set; }
        public virtual DbSet<Programmestreamgroup> Programmestreamgroups { get; set; }
        public virtual DbSet<Programmestreamgroupdetail> Programmestreamgroupdetails { get; set; }
        public virtual DbSet<Programmestreamgroupfeecategory> Programmestreamgroupfeecategories { get; set; }
        public virtual DbSet<Programmestreamgroupuser> Programmestreamgroupusers { get; set; }
        public virtual DbSet<Programmestreampaymentblock> Programmestreampaymentblocks { get; set; }
        public virtual DbSet<Programmestreamwithsecondtieradmission> Programmestreamwithsecondtieradmissions { get; set; }
        public virtual DbSet<Receiptsetting> Receiptsettings { get; set; }
        public virtual DbSet<Refundtype> Refundtypes { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Registeredcoursesview> Registeredcoursesviews { get; set; }
        public virtual DbSet<Religion> Religions { get; set; }
        public virtual DbSet<Reportviewlog> Reportviewlogs { get; set; }
        public virtual DbSet<Residence> Residences { get; set; }
        public virtual DbSet<Residencebooking> Residencebookings { get; set; }
        public virtual DbSet<ResidencebookingBackup> ResidencebookingBackups { get; set; }
        public virtual DbSet<Residencebookingexception> Residencebookingexceptions { get; set; }
        public virtual DbSet<Residencebookinglog> Residencebookinglogs { get; set; }
        public virtual DbSet<Residencebookingtype> Residencebookingtypes { get; set; }
        public virtual DbSet<Residenceprogrammestream> Residenceprogrammestreams { get; set; }
        public virtual DbSet<Residencequotalog> Residencequotalogs { get; set; }
        public virtual DbSet<Residencequotum> Residencequota { get; set; }
        public virtual DbSet<Residencesetting> Residencesettings { get; set; }
        public virtual DbSet<Residentialbilllog> Residentialbilllogs { get; set; }
        public virtual DbSet<Residentialcountlog> Residentialcountlogs { get; set; }
        public virtual DbSet<Residentialloginlog> Residentialloginlogs { get; set; }
        public virtual DbSet<Resit2020> Resit2020s { get; set; }
        public virtual DbSet<Resit2020rev1> Resit2020rev1s { get; set; }
        public virtual DbSet<Resit2020rev2> Resit2020rev2s { get; set; }
        public virtual DbSet<Resit2020rev3> Resit2020rev3s { get; set; }
        public virtual DbSet<Resitcategory> Resitcategories { get; set; }
        public virtual DbSet<Resitfeecategorymapping> Resitfeecategorymappings { get; set; }
        public virtual DbSet<Resittemplate> Resittemplates { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Roombookingstore> Roombookingstores { get; set; }
        public virtual DbSet<Roombookingstore2> Roombookingstore2s { get; set; }
        public virtual DbSet<Roombookingstore3> Roombookingstore3s { get; set; }
        public virtual DbSet<RoompaymentDel> RoompaymentDels { get; set; }
        public virtual DbSet<RoomreservationDel> RoomreservationDels { get; set; }
        public virtual DbSet<Scholarshiptype> Scholarshiptypes { get; set; }
        public virtual DbSet<Semester> Semesters { get; set; }
        public virtual DbSet<Semester1> Semesters1 { get; set; }
        public virtual DbSet<Semestertype> Semestertypes { get; set; }
        public virtual DbSet<Sheet1> Sheet1s { get; set; }
        public virtual DbSet<Shssurvey> Shssurveys { get; set; }
        public virtual DbSet<Smsbroadcastlist> Smsbroadcastlists { get; set; }
        public virtual DbSet<Smsbroadcastmessage> Smsbroadcastmessages { get; set; }
        public virtual DbSet<Smscategoryid> Smscategoryids { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Student20220218> Student20220218s { get; set; }
        public virtual DbSet<StudentAt> StudentAts { get; set; }
        public virtual DbSet<StudentBirthdate> StudentBirthdates { get; set; }
        public virtual DbSet<StudentBk> StudentBks { get; set; }
        public virtual DbSet<StudentCredit> StudentCredits { get; set; }
        public virtual DbSet<StudentDebit> StudentDebits { get; set; }
        public virtual DbSet<StudentGraduationDate> StudentGraduationDates { get; set; }
        public virtual DbSet<Studentacadyear> Studentacadyears { get; set; }
        public virtual DbSet<Studentacadyear20220218> Studentacadyear20220218s { get; set; }
        public virtual DbSet<Studentbill> Studentbills { get; set; }
        public virtual DbSet<StudentbiometricInclusion> StudentbiometricInclusions { get; set; }
        public virtual DbSet<Studentbiometricverification> Studentbiometricverifications { get; set; }
        public virtual DbSet<StudentbiometricverificationFirsthalf> StudentbiometricverificationFirsthalves { get; set; }
        public virtual DbSet<Studentblocked> Studentblockeds { get; set; }
        public virtual DbSet<Studentcategory> Studentcategories { get; set; }
        public virtual DbSet<Studentcheckin> Studentcheckins { get; set; }
        public virtual DbSet<Studentcovidassessment> Studentcovidassessments { get; set; }
        public virtual DbSet<Studentcredit1> Studentcredits1 { get; set; }
        public virtual DbSet<Studentdebit1> Studentdebits1 { get; set; }
        public virtual DbSet<Studentemailverification> Studentemailverifications { get; set; }
        public virtual DbSet<Studentexamcentre> Studentexamcentres { get; set; }
        public virtual DbSet<Studentfeecategory> Studentfeecategories { get; set; }
        public virtual DbSet<Studentfeeclearance> Studentfeeclearances { get; set; }
        public virtual DbSet<Studentfeeclearancelog> Studentfeeclearancelogs { get; set; }
        public virtual DbSet<Studentfeeexemption> Studentfeeexemptions { get; set; }
        public virtual DbSet<Studentgraduationregister> Studentgraduationregisters { get; set; }
        public virtual DbSet<Studentgraduationregisterlog> Studentgraduationregisterlogs { get; set; }
        public virtual DbSet<Studentidgenerator> Studentidgenerators { get; set; }
        public virtual DbSet<Studentledger> Studentledgers { get; set; }
        public virtual DbSet<Studentloginerror> Studentloginerrors { get; set; }
        public virtual DbSet<Studentloginlog> Studentloginlogs { get; set; }
        public virtual DbSet<Studentmedicalexam> Studentmedicalexams { get; set; }
        public virtual DbSet<Studentoncampusverification> Studentoncampusverifications { get; set; }
        public virtual DbSet<Studentpassreset> Studentpassresets { get; set; }
        public virtual DbSet<Studentpayment> Studentpayments { get; set; }
        public virtual DbSet<Studentpaymentdeadlinefreshman> Studentpaymentdeadlinefreshmen { get; set; }
        public virtual DbSet<Studentpaymentdeadlinefreshman1> Studentpaymentdeadlinefreshmen1 { get; set; }
        public virtual DbSet<Studentphoto> Studentphotos { get; set; }
        public virtual DbSet<Studentphotodownloaded> Studentphotodownloadeds { get; set; }
        public virtual DbSet<StudentphotodownloadedIdcard> StudentphotodownloadedIdcards { get; set; }
        public virtual DbSet<Studentphotoprocessed> Studentphotoprocesseds { get; set; }
        public virtual DbSet<Studentphotoupload> Studentphotouploads { get; set; }
        public virtual DbSet<StudentphotouploadUpdate> StudentphotouploadUpdates { get; set; }
        public virtual DbSet<StudentpicExportError> StudentpicExportErrors { get; set; }
        public virtual DbSet<StudentpicExported> StudentpicExporteds { get; set; }
        public virtual DbSet<Studentprogramme> Studentprogrammes { get; set; }
        public virtual DbSet<Studentprogramme20220218> Studentprogramme20220218s { get; set; }
        public virtual DbSet<StudentprogrammeCampusBk> StudentprogrammeCampusBks { get; set; }
        public virtual DbSet<Studentprogrammelog> Studentprogrammelogs { get; set; }
        public virtual DbSet<Studentrefund> Studentrefunds { get; set; }
        public virtual DbSet<Studentrequiringcredential> Studentrequiringcredentials { get; set; }
        public virtual DbSet<Studentresidence> Studentresidences { get; set; }
        public virtual DbSet<Studentresidence1> Studentresidences1 { get; set; }
        public virtual DbSet<Studentscholarship> Studentscholarships { get; set; }
        public virtual DbSet<Studentscholarshippayment> Studentscholarshippayments { get; set; }
        public virtual DbSet<Studentsemester> Studentsemesters { get; set; }
        public virtual DbSet<Studentsemester20220218> Studentsemester20220218s { get; set; }
        public virtual DbSet<Studentsm> Studentsms { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<Taggedstudent> Taggedstudents { get; set; }
        public virtual DbSet<Taggedstudentlog> Taggedstudentlogs { get; set; }
        public virtual DbSet<TemdelfeesPolicy20220420> TemdelfeesPolicy20220420s { get; set; }
        public virtual DbSet<TempBackupUser> TempBackupUsers { get; set; }
        public virtual DbSet<TempBursaryKen> TempBursaryKens { get; set; }
        public virtual DbSet<TempCollege> TempColleges { get; set; }
        public virtual DbSet<TempContinuingDoesnotmeetPolicy> TempContinuingDoesnotmeetPolicies { get; set; }
        public virtual DbSet<TempContinuingMeetPolicy> TempContinuingMeetPolicies { get; set; }
        public virtual DbSet<TempContinuingMeetPolicyDeleted> TempContinuingMeetPolicyDeleteds { get; set; }
        public virtual DbSet<TempFreshmenPostgraduateWronglyTagged> TempFreshmenPostgraduateWronglyTaggeds { get; set; }
        public virtual DbSet<TempFreshmenPostgraduateWronglyTaggedDeleted> TempFreshmenPostgraduateWronglyTaggedDeleteds { get; set; }
        public virtual DbSet<TempIdl> TempIdls { get; set; }
        public virtual DbSet<TempJune15> TempJune15s { get; set; }
        public virtual DbSet<TempJune28> TempJune28s { get; set; }
        public virtual DbSet<TempKenCtm> TempKenCtms { get; set; }
        public virtual DbSet<TempKenDo> TempKenDos { get; set; }
        public virtual DbSet<TempKenDuplicate> TempKenDuplicates { get; set; }
        public virtual DbSet<TempKenVodaDistinct> TempKenVodaDistincts { get; set; }
        public virtual DbSet<TempKenVodaFound2> TempKenVodaFound2s { get; set; }
        public virtual DbSet<TempKenVodum> TempKenVoda { get; set; }
        public virtual DbSet<TempOccupant> TempOccupants { get; set; }
        public virtual DbSet<TempOccupants2> TempOccupants2s { get; set; }
        public virtual DbSet<TempResidencebooking20211231> TempResidencebooking20211231s { get; set; }
        public virtual DbSet<TempResidentialBillImport> TempResidentialBillImports { get; set; }
        public virtual DbSet<TempReversalData20200121> TempReversalData20200121s { get; set; }
        public virtual DbSet<TempReversedTagContinuingMeetPolicy> TempReversedTagContinuingMeetPolicies { get; set; }
        public virtual DbSet<TempReversedTagFreshmenPostgraduate> TempReversedTagFreshmenPostgraduates { get; set; }
        public virtual DbSet<TempReversedTagMeetPolicyDeferred> TempReversedTagMeetPolicyDeferreds { get; set; }
        public virtual DbSet<TempReversedTagMeetPolicyDeferred10> TempReversedTagMeetPolicyDeferred10s { get; set; }
        public virtual DbSet<TempReversedTagMeetPolicyDeferred2> TempReversedTagMeetPolicyDeferred2s { get; set; }
        public virtual DbSet<TempReversedTagMeetPolicyDeferred3> TempReversedTagMeetPolicyDeferred3s { get; set; }
        public virtual DbSet<TempReversedTagMeetPolicyDeferred4> TempReversedTagMeetPolicyDeferred4s { get; set; }
        public virtual DbSet<TempReversedTagMeetPolicyDeferred5> TempReversedTagMeetPolicyDeferred5s { get; set; }
        public virtual DbSet<TempReversedTagMeetPolicyDeferred6> TempReversedTagMeetPolicyDeferred6s { get; set; }
        public virtual DbSet<TempReversedTagMeetPolicyDeferred7> TempReversedTagMeetPolicyDeferred7s { get; set; }
        public virtual DbSet<TempReversedTagMeetPolicyDeferred8> TempReversedTagMeetPolicyDeferred8s { get; set; }
        public virtual DbSet<TempReversedTagMeetPolicyDeferred9> TempReversedTagMeetPolicyDeferred9s { get; set; }
        public virtual DbSet<TempReversedTagMeetPolicyPermanentlyRemoved> TempReversedTagMeetPolicyPermanentlyRemoveds { get; set; }
        public virtual DbSet<TempReversedTagMeetPolicyPermanentlyRemoved2> TempReversedTagMeetPolicyPermanentlyRemoved2s { get; set; }
        public virtual DbSet<TempReversedTagMeetPolicyPermanentlyRemovedPg10> TempReversedTagMeetPolicyPermanentlyRemovedPg10s { get; set; }
        public virtual DbSet<TempReversedTagMeetPolicyPermanentlyRemovedPg3> TempReversedTagMeetPolicyPermanentlyRemovedPg3s { get; set; }
        public virtual DbSet<TempReversedTagMeetPolicyPermanentlyRemovedPg4> TempReversedTagMeetPolicyPermanentlyRemovedPg4s { get; set; }
        public virtual DbSet<TempReversedTagMeetPolicyPermanentlyRemovedPg5> TempReversedTagMeetPolicyPermanentlyRemovedPg5s { get; set; }
        public virtual DbSet<TempReversedTagMeetPolicyPermanentlyRemovedPg6> TempReversedTagMeetPolicyPermanentlyRemovedPg6s { get; set; }
        public virtual DbSet<TempReversedTagMeetPolicyPermanentlyRemovedPg7> TempReversedTagMeetPolicyPermanentlyRemovedPg7s { get; set; }
        public virtual DbSet<TempReversedTagMeetPolicyPermanentlyRemovedPg8> TempReversedTagMeetPolicyPermanentlyRemovedPg8s { get; set; }
        public virtual DbSet<TempReversedTagMeetPolicyPermanentlyRemovedPg9> TempReversedTagMeetPolicyPermanentlyRemovedPg9s { get; set; }
        public virtual DbSet<TempReversedTagMeetPolicyPermanentlyRemovedUg10> TempReversedTagMeetPolicyPermanentlyRemovedUg10s { get; set; }
        public virtual DbSet<TempReversedTagMeetPolicyPermanentlyRemovedUg3> TempReversedTagMeetPolicyPermanentlyRemovedUg3s { get; set; }
        public virtual DbSet<TempReversedTagMeetPolicyPermanentlyRemovedUg4> TempReversedTagMeetPolicyPermanentlyRemovedUg4s { get; set; }
        public virtual DbSet<TempReversedTagMeetPolicyPermanentlyRemovedUg5> TempReversedTagMeetPolicyPermanentlyRemovedUg5s { get; set; }
        public virtual DbSet<TempReversedTagMeetPolicyPermanentlyRemovedUg9> TempReversedTagMeetPolicyPermanentlyRemovedUg9s { get; set; }
        public virtual DbSet<TempReversedTagScholarship5> TempReversedTagScholarship5s { get; set; }
        public virtual DbSet<TempReversedTagScholarshipFresher5> TempReversedTagScholarshipFresher5s { get; set; }
        public virtual DbSet<TempScholarship> TempScholarships { get; set; }
        public virtual DbSet<TempStudent> TempStudents { get; set; }
        public virtual DbSet<TempStudentprogrammeduration> TempStudentprogrammedurations { get; set; }
        public virtual DbSet<TempStudentsupport> TempStudentsupports { get; set; }
        public virtual DbSet<TempTagstdfee> TempTagstdfees { get; set; }
        public virtual DbSet<TempVodadata1> TempVodadata1s { get; set; }
        public virtual DbSet<TempVodadatum> TempVodadata { get; set; }
        public virtual DbSet<TempVodadistribution> TempVodadistributions { get; set; }
        public virtual DbSet<TempVodafonevalidno> TempVodafonevalidnos { get; set; }
        public virtual DbSet<TempVodaserv> TempVodaservs { get; set; }
        public virtual DbSet<Temparmisreconciled> Temparmisreconcileds { get; set; }
        public virtual DbSet<Temparmisx> Temparmisxes { get; set; }
        public virtual DbSet<Tempcredential> Tempcredentials { get; set; }
        public virtual DbSet<Tempdel> Tempdels { get; set; }
        public virtual DbSet<Tempdel2> Tempdel2s { get; set; }
        public virtual DbSet<TempdelBoampongdelete> TempdelBoampongdeletes { get; set; }
        public virtual DbSet<Tempdelfee> Tempdelfees { get; set; }
        public virtual DbSet<Tempdelfees2> Tempdelfees2s { get; set; }
        public virtual DbSet<TempdelfeesPolicy> TempdelfeesPolicies { get; set; }
        public virtual DbSet<TempdelfeesPolicy20220422> TempdelfeesPolicy20220422s { get; set; }
        public virtual DbSet<TempdelfeesPolicy20220425> TempdelfeesPolicy20220425s { get; set; }
        public virtual DbSet<TempdelfeesPolicy20220428> TempdelfeesPolicy20220428s { get; set; }
        public virtual DbSet<TempdelfeesPolicy20220511> TempdelfeesPolicy20220511s { get; set; }
        public virtual DbSet<TempdelfeesPolicy20220515> TempdelfeesPolicy20220515s { get; set; }
        public virtual DbSet<TempdelfeesPolicy20220518> TempdelfeesPolicy20220518s { get; set; }
        public virtual DbSet<TempdelfeesPolicy20220519> TempdelfeesPolicy20220519s { get; set; }
        public virtual DbSet<TempdelfeesPolicySem1> TempdelfeesPolicySem1s { get; set; }
        public virtual DbSet<Teststudent> Teststudents { get; set; }
        public virtual DbSet<TimeSlot> TimeSlots { get; set; }
        public virtual DbSet<Timestream> Timestreams { get; set; }
        public virtual DbSet<TimetableUnit> TimetableUnits { get; set; }
        public virtual DbSet<TimetableUser> TimetableUsers { get; set; }
        public virtual DbSet<Title> Titles { get; set; }
        public virtual DbSet<Transcriptrequest> Transcriptrequests { get; set; }
        public virtual DbSet<Transcriptrequestdetail> Transcriptrequestdetails { get; set; }
        public virtual DbSet<Transcriptrequeststatus> Transcriptrequeststatuses { get; set; }
        public virtual DbSet<Tt> Tts { get; set; }
        public virtual DbSet<Ttcl> Ttcls { get; set; }
        public virtual DbSet<Ttclassroomlectureperiod> Ttclassroomlectureperiods { get; set; }
        public virtual DbSet<Ttcourselecturerprogrammestreamgroup> Ttcourselecturerprogrammestreamgroups { get; set; }
        public virtual DbSet<Ttxp> Ttxps { get; set; }
        public virtual DbSet<UgProgramme45> UgProgramme45s { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<UnitBuilding> UnitBuildings { get; set; }
        public virtual DbSet<UnitProgrammeStream> UnitProgrammeStreams { get; set; }
        public virtual DbSet<UserUnit> UserUnits { get; set; }
        public virtual DbSet<Userloginlog> Userloginlogs { get; set; }
        public virtual DbSet<Usermanillaemailrecipient> Usermanillaemailrecipients { get; set; }
        public virtual DbSet<ViewAcademicrecord> ViewAcademicrecords { get; set; }
        public virtual DbSet<ViewAcademicrecordD> ViewAcademicrecordDs { get; set; }
        public virtual DbSet<ViewAccountSystemReceiptId> ViewAccountSystemReceiptIds { get; set; }
        public virtual DbSet<ViewAdmissioncampus> ViewAdmissioncampuses { get; set; }
        public virtual DbSet<ViewAdmissioncountry> ViewAdmissioncountries { get; set; }
        public virtual DbSet<ViewAdmissiongroup> ViewAdmissiongroups { get; set; }
        public virtual DbSet<ViewAdmissionoffercategory> ViewAdmissionoffercategories { get; set; }
        public virtual DbSet<ViewAdmissionprogrammeoption> ViewAdmissionprogrammeoptions { get; set; }
        public virtual DbSet<ViewAdmissionreligion> ViewAdmissionreligions { get; set; }
        public virtual DbSet<ViewAdmissionresidence> ViewAdmissionresidences { get; set; }
        public virtual DbSet<ViewAdmissiontitle> ViewAdmissiontitles { get; set; }
        public virtual DbSet<ViewAlumniDetail> ViewAlumniDetails { get; set; }
        public virtual DbSet<ViewApplicant> ViewApplicants { get; set; }
        public virtual DbSet<ViewApplicantadmitted> ViewApplicantadmitteds { get; set; }
        public virtual DbSet<ViewApplicantadmittedqueue> ViewApplicantadmittedqueues { get; set; }
        public virtual DbSet<ViewApplicantdisability> ViewApplicantdisabilities { get; set; }
        public virtual DbSet<ViewApplicantlgn> ViewApplicantlgns { get; set; }
        public virtual DbSet<ViewApplicantpicture> ViewApplicantpictures { get; set; }
        public virtual DbSet<ViewCombinedAcademicFee> ViewCombinedAcademicFees { get; set; }
        public virtual DbSet<ViewCredit> ViewCredits { get; set; }
        public virtual DbSet<ViewDebit> ViewDebits { get; set; }
        public virtual DbSet<ViewFresher> ViewFreshers { get; set; }
        public virtual DbSet<ViewFresher1> ViewFreshers1 { get; set; }
        public virtual DbSet<ViewFresher2> ViewFresher2s { get; set; }
        public virtual DbSet<ViewFresherphoto> ViewFresherphotos { get; set; }
        public virtual DbSet<ViewFreshman> ViewFreshmen { get; set; }
        public virtual DbSet<ViewGraduate> ViewGraduates { get; set; }
        public virtual DbSet<ViewGraduateCurrent> ViewGraduateCurrents { get; set; }
        public virtual DbSet<ViewGraduationAllowPayment> ViewGraduationAllowPayments { get; set; }
        public virtual DbSet<ViewLecturer> ViewLecturers { get; set; }
        public virtual DbSet<ViewLecturerCourse> ViewLecturerCourses { get; set; }
        public virtual DbSet<ViewMissingprogrammestream> ViewMissingprogrammestreams { get; set; }
        public virtual DbSet<ViewOfflinePayment> ViewOfflinePayments { get; set; }
        public virtual DbSet<ViewOnlinePaymentTransaction> ViewOnlinePaymentTransactions { get; set; }
        public virtual DbSet<ViewOnlineWebPayment> ViewOnlineWebPayments { get; set; }
        public virtual DbSet<ViewOnlinepayment> ViewOnlinepayments { get; set; }
        public virtual DbSet<ViewPayment> ViewPayments { get; set; }
        public virtual DbSet<ViewPaymentsGraduation> ViewPaymentsGraduations { get; set; }
        public virtual DbSet<ViewPaymentsOffline> ViewPaymentsOfflines { get; set; }
        public virtual DbSet<ViewPaymentsOnline> ViewPaymentsOnlines { get; set; }
        public virtual DbSet<ViewPaymentsOnlineFee> ViewPaymentsOnlineFees { get; set; }
        public virtual DbSet<ViewPaymentsOnlineResidential> ViewPaymentsOnlineResidentials { get; set; }
        public virtual DbSet<ViewProgrammestream> ViewProgrammestreams { get; set; }
        public virtual DbSet<ViewReceipt> ViewReceipts { get; set; }
        public virtual DbSet<ViewResidencebooking> ViewResidencebookings { get; set; }
        public virtual DbSet<ViewResidencebookingBlockedroom> ViewResidencebookingBlockedrooms { get; set; }
        public virtual DbSet<ViewResidencebookingOnline> ViewResidencebookingOnlines { get; set; }
        public virtual DbSet<ViewResidencebookingTemp> ViewResidencebookingTemps { get; set; }
        public virtual DbSet<ViewResidencepayment> ViewResidencepayments { get; set; }
        public virtual DbSet<ViewResidentialbill> ViewResidentialbills { get; set; }
        public virtual DbSet<ViewResidentialpaymentDel> ViewResidentialpaymentDels { get; set; }
        public virtual DbSet<ViewResidentialquotum> ViewResidentialquota { get; set; }
        public virtual DbSet<ViewResidentialquotum1> ViewResidentialquota1 { get; set; }
        public virtual DbSet<ViewRoomreservation> ViewRoomreservations { get; set; }
        public virtual DbSet<ViewStudent> ViewStudents { get; set; }
        public virtual DbSet<ViewStudent1> ViewStudents1 { get; set; }
        public virtual DbSet<ViewStudentCredential> ViewStudentCredentials { get; set; }
        public virtual DbSet<ViewStudentbiometricverification> ViewStudentbiometricverifications { get; set; }
        public virtual DbSet<ViewStudentblocked> ViewStudentblockeds { get; set; }
        public virtual DbSet<ViewStudentcourse> ViewStudentcourses { get; set; }
        public virtual DbSet<ViewStudentcoursePostgraduate> ViewStudentcoursePostgraduates { get; set; }
        public virtual DbSet<ViewStudentmedicalexam> ViewStudentmedicalexams { get; set; }
        public virtual DbSet<ViewStudentpayment> ViewStudentpayments { get; set; }
        public virtual DbSet<ViewStudentphoto> ViewStudentphotos { get; set; }
        public virtual DbSet<ViewStudentresidence> ViewStudentresidences { get; set; }
        public virtual DbSet<ViewStudenttranscript> ViewStudenttranscripts { get; set; }
        public virtual DbSet<ViewStudentunbilled> ViewStudentunbilleds { get; set; }
        public virtual DbSet<ViewTaggedstudent> ViewTaggedstudents { get; set; }
        public virtual DbSet<ViewTestpayment> ViewTestpayments { get; set; }
        public virtual DbSet<ViewUnconfirmedTransaction> ViewUnconfirmedTransactions { get; set; }
        public virtual DbSet<ViewUnconfirmedWebPaymentOrder> ViewUnconfirmedWebPaymentOrders { get; set; }
        public virtual DbSet<ViewUserpayment> ViewUserpayments { get; set; }
        public virtual DbSet<ViewValidresidencebooking> ViewValidresidencebookings { get; set; }
        public virtual DbSet<ViewValidresidencebooking2> ViewValidresidencebooking2s { get; set; }
        public virtual DbSet<ViewWebPaymentOrder> ViewWebPaymentOrders { get; set; }
        public virtual DbSet<ViewWspayment> ViewWspayments { get; set; }
        public virtual DbSet<ViewWspaymentAll> ViewWspaymentAlls { get; set; }
        public virtual DbSet<Viewacademicrecordactualreg> Viewacademicrecordactualregs { get; set; }
        public virtual DbSet<Viewacademicrecordactualresult> Viewacademicrecordactualresults { get; set; }
        public virtual DbSet<Viewacademicrecordonlinereg> Viewacademicrecordonlineregs { get; set; }
        public virtual DbSet<Viewcombinedpayment> Viewcombinedpayments { get; set; }
        public virtual DbSet<Viewcourse> Viewcourses { get; set; }
        public virtual DbSet<Viewcoursesassessedon> Viewcoursesassessedons { get; set; }
        public virtual DbSet<Viewdistinctprogrammecoursecodelecturer> Viewdistinctprogrammecoursecodelecturers { get; set; }
        public virtual DbSet<Viewdistinctprogrammecourselecturer> Viewdistinctprogrammecourselecturers { get; set; }
        public virtual DbSet<Viewdistinctprogrammeyrlecturer> Viewdistinctprogrammeyrlecturers { get; set; }
        public virtual DbSet<Viewinstitution> Viewinstitutions { get; set; }
        public virtual DbSet<Viewlectureracadrecord> Viewlectureracadrecords { get; set; }
        public virtual DbSet<Viewprogrammecourselecturer> Viewprogrammecourselecturers { get; set; }
        public virtual DbSet<Viewpustudentphoto> Viewpustudentphotos { get; set; }
        public virtual DbSet<Viewstaffappsgetcoursedetail> Viewstaffappsgetcoursedetails { get; set; }
        public virtual DbSet<Viewstudentbill> Viewstudentbills { get; set; }
        public virtual DbSet<Viewstudentprogramme> Viewstudentprogrammes { get; set; }
        public virtual DbSet<Viewstudidentity> Viewstudidentities { get; set; }
        public virtual DbSet<Viewupdateacademicrecordactual> Viewupdateacademicrecordactuals { get; set; }
        public virtual DbSet<Viewupdateacademicrecordonline> Viewupdateacademicrecordonlines { get; set; }
        public virtual DbSet<Viewupdateacadrecordlecturer> Viewupdateacadrecordlecturers { get; set; }
        public virtual DbSet<VodafoneTimeMatch> VodafoneTimeMatches { get; set; }
        public virtual DbSet<VodafoneTimeUnmatch> VodafoneTimeUnmatches { get; set; }
        public virtual DbSet<Vodafonesurvey> Vodafonesurveys { get; set; }
        public virtual DbSet<WeekDay> WeekDays { get; set; }
        public virtual DbSet<Wsitem> Wsitems { get; set; }
        public virtual DbSet<Wsitemfeecategory> Wsitemfeecategories { get; set; }
        public virtual DbSet<Wsitemfeecategorybankaccount> Wsitemfeecategorybankaccounts { get; set; }
        public virtual DbSet<Wsorderidseed> Wsorderidseeds { get; set; }
        public virtual DbSet<Wspayment> Wspayments { get; set; }
        public virtual DbSet<Wspaymentaccepttransaction> Wspaymentaccepttransactions { get; set; }
        public virtual DbSet<Wspaymentsplit> Wspaymentsplits { get; set; }
        public virtual DbSet<Wsresponse> Wsresponses { get; set; }
        public virtual DbSet<Wsuser> Wsusers { get; set; }
        public virtual DbSet<Wsuserbank> Wsuserbanks { get; set; }
        public virtual DbSet<Xresit> Xresits { get; set; }
        public virtual DbSet<YearLevel> YearLevels { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AcademicSemester>(entity =>
            {
                entity.HasKey(e => e.AcademicSemesterId)
                    .IsClustered(false);

                entity.ToTable("AcademicSemester", "tt");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.AcademicSemesters)
                    .HasForeignKey(d => d.SemesterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcademicSemester_Semester");
            });

            modelBuilder.Entity<Academicgroup>(entity =>
            {
                entity.HasKey(e => e.Academicgroupid)
                    .IsClustered(false);

                entity.ToTable("ACADEMICGROUP");

                entity.Property(e => e.Academicgroupid).HasColumnName("ACADEMICGROUPID");

                entity.Property(e => e.Academicgroupcode)
                    .HasMaxLength(10)
                    .HasColumnName("ACADEMICGROUPCODE");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<Academiclevel>(entity =>
            {
                entity.HasKey(e => e.Acadlevelid);

                entity.ToTable("ACADEMICLEVEL");

                entity.Property(e => e.Acadlevelid)
                    .ValueGeneratedNever()
                    .HasColumnName("ACADLEVELID");

                entity.Property(e => e.Altname)
                    .HasMaxLength(50)
                    .HasColumnName("ALTNAME");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("NAME");

                entity.Property(e => e.Sort).HasColumnName("SORT");
            });

            modelBuilder.Entity<Academicrecord>(entity =>
            {
                entity.HasKey(e => new { e.Studentid, e.Programmestreamid, e.Acadyear, e.Sem, e.Coursecode })
                    .IsClustered(false);

                entity.ToTable("ACADEMICRECORD");

                entity.HasIndex(e => new { e.Programmestreamid, e.Acadyear, e.Sem }, "IX_ACADEMICRECORD1");

                entity.HasIndex(e => new { e.Studentid, e.Programmestreamid }, "IX_ACADEMICRECORD2");

                entity.HasIndex(e => new { e.Programmestreamid, e.Acadyear, e.Sem, e.Acadlevelid }, "IX_ACADEMICRECORD3");

                entity.HasIndex(e => new { e.Studentid, e.Programmestreamid, e.Coursecode, e.Grade }, "IX_ACADEMICRECORD4");

                entity.HasIndex(e => e.Acadyear, "IX_ACADEMICRECORD_ACADYEAR");

                entity.HasIndex(e => e.Acadyear, "IX_ACADEMICRECORD_ACADYEAR2");

                entity.HasIndex(e => e.Id, "IX_ACADEMICRECORD_ID2");

                entity.HasIndex(e => new { e.Studentid, e.Programmestreamid, e.Istrail, e.Iscalc }, "missing_index_19");

                entity.HasIndex(e => e.Acadyear, "missing_index_20");

                entity.HasIndex(e => new { e.Studentid, e.Programmestreamid, e.Acadyear, e.Sem, e.Acadlevelid }, "missing_index_344");

                entity.HasIndex(e => new { e.Studentid, e.Acadyear, e.Sem }, "missing_index_5");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Coursecode)
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadrank).HasColumnName("ACADRANK");

                entity.Property(e => e.App)
                    .HasMaxLength(25)
                    .HasColumnName("APP");

                entity.Property(e => e.Appversion).HasColumnName("APPVERSION");

                entity.Property(e => e.Camark).HasColumnName("CAMARK");

                entity.Property(e => e.Coursecode2)
                    .HasMaxLength(50)
                    .HasColumnName("COURSECODE2");

                entity.Property(e => e.Coursename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Coursestatusid).HasColumnName("COURSESTATUSID");

                entity.Property(e => e.Coursetypeid).HasColumnName("COURSETYPEID");

                entity.Property(e => e.Credit).HasColumnName("CREDIT");

                entity.Property(e => e.Electivesetid).HasColumnName("ELECTIVESETID");

                entity.Property(e => e.Endsemmark).HasColumnName("ENDSEMMARK");

                entity.Property(e => e.Examcentreid).HasColumnName("EXAMCENTREID");

                entity.Property(e => e.Grade)
                    .HasMaxLength(2)
                    .HasColumnName("GRADE");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.Isapproved).HasColumnName("ISAPPROVED");

                entity.Property(e => e.Iscalc).HasColumnName("ISCALC");

                entity.Property(e => e.Isprevioustrail).HasColumnName("ISPREVIOUSTRAIL");

                entity.Property(e => e.Istrail).HasColumnName("ISTRAIL");

                entity.Property(e => e.Numeq).HasColumnName("NUMEQ");

                entity.Property(e => e.Registeredonline).HasColumnName("REGISTEREDONLINE");

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Sourcerowid).HasColumnName("SOURCEROWID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Timeupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEUPDATED");

                entity.Property(e => e.Totalmark).HasColumnName("TOTALMARK");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(100)
                    .HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.Acadlevel)
                    .WithMany(p => p.Academicrecords)
                    .HasForeignKey(d => d.Acadlevelid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACADEMICRECORD_ACADEMICLEVEL");

                entity.HasOne(d => d.CoursecodeNavigation)
                    .WithMany(p => p.Academicrecords)
                    .HasForeignKey(d => d.Coursecode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACADEMICRECORD_MASTERCOURSE");

                entity.HasOne(d => d.Coursestatus)
                    .WithMany(p => p.Academicrecords)
                    .HasForeignKey(d => d.Coursestatusid)
                    .HasConstraintName("FK_ACADEMICRECORD_COURSESTATUS");

                entity.HasOne(d => d.Examcentre)
                    .WithMany(p => p.Academicrecords)
                    .HasForeignKey(d => d.Examcentreid)
                    .HasConstraintName("FK_ACADEMICRECORD_EXAMCENTER");

                entity.HasOne(d => d.Studentsemester)
                    .WithMany(p => p.Academicrecords)
                    .HasPrincipalKey(p => new { p.Studentid, p.Programmestreamid, p.Acadyear, p.Sem, p.Acadlevelid })
                    .HasForeignKey(d => new { d.Studentid, d.Programmestreamid, d.Acadyear, d.Sem, d.Acadlevelid })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACADEMICRECORD_STUDENTSEMESTER");
            });

            modelBuilder.Entity<Academicrecord20220218>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ACADEMICRECORD_20220218");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadrank).HasColumnName("ACADRANK");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.App)
                    .HasMaxLength(25)
                    .HasColumnName("APP");

                entity.Property(e => e.Appversion).HasColumnName("APPVERSION");

                entity.Property(e => e.Camark).HasColumnName("CAMARK");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursecode2)
                    .HasMaxLength(50)
                    .HasColumnName("COURSECODE2");

                entity.Property(e => e.Coursename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Coursestatusid).HasColumnName("COURSESTATUSID");

                entity.Property(e => e.Coursetypeid).HasColumnName("COURSETYPEID");

                entity.Property(e => e.Credit).HasColumnName("CREDIT");

                entity.Property(e => e.Electivesetid).HasColumnName("ELECTIVESETID");

                entity.Property(e => e.Endsemmark).HasColumnName("ENDSEMMARK");

                entity.Property(e => e.Examcentreid).HasColumnName("EXAMCENTREID");

                entity.Property(e => e.Grade)
                    .HasMaxLength(2)
                    .HasColumnName("GRADE");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Isapproved).HasColumnName("ISAPPROVED");

                entity.Property(e => e.Iscalc).HasColumnName("ISCALC");

                entity.Property(e => e.Isprevioustrail).HasColumnName("ISPREVIOUSTRAIL");

                entity.Property(e => e.Istrail).HasColumnName("ISTRAIL");

                entity.Property(e => e.Numeq).HasColumnName("NUMEQ");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Registeredonline).HasColumnName("REGISTEREDONLINE");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Sourcerowid).HasColumnName("SOURCEROWID");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Timeupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEUPDATED");

                entity.Property(e => e.Totalmark).HasColumnName("TOTALMARK");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(100)
                    .HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<AcademicrecordCamark>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ACADEMICRECORD_CAMARK");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadrank).HasColumnName("ACADRANK");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.App)
                    .HasMaxLength(25)
                    .HasColumnName("APP");

                entity.Property(e => e.Appversion).HasColumnName("APPVERSION");

                entity.Property(e => e.Camark).HasColumnName("CAMARK");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Coursestatusid).HasColumnName("COURSESTATUSID");

                entity.Property(e => e.Coursetypeid).HasColumnName("COURSETYPEID");

                entity.Property(e => e.Credit).HasColumnName("CREDIT");

                entity.Property(e => e.Electivesetid).HasColumnName("ELECTIVESETID");

                entity.Property(e => e.Endsemmark).HasColumnName("ENDSEMMARK");

                entity.Property(e => e.Examcentreid).HasColumnName("EXAMCENTREID");

                entity.Property(e => e.Grade)
                    .HasMaxLength(2)
                    .HasColumnName("GRADE");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Iscalc).HasColumnName("ISCALC");

                entity.Property(e => e.Isprevioustrail).HasColumnName("ISPREVIOUSTRAIL");

                entity.Property(e => e.Istrail).HasColumnName("ISTRAIL");

                entity.Property(e => e.Numeq).HasColumnName("NUMEQ");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Registeredonline).HasColumnName("REGISTEREDONLINE");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Sourcerowid).HasColumnName("SOURCEROWID");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Timeupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEUPDATED");

                entity.Property(e => e.Totalmark).HasColumnName("TOTALMARK");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(100)
                    .HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<AcademicrecordCredit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ACADEMICRECORD_CREDIT");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadrank).HasColumnName("ACADRANK");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.App)
                    .HasMaxLength(25)
                    .HasColumnName("APP");

                entity.Property(e => e.Appversion).HasColumnName("APPVERSION");

                entity.Property(e => e.Camark).HasColumnName("CAMARK");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Coursestatusid).HasColumnName("COURSESTATUSID");

                entity.Property(e => e.Coursetypeid).HasColumnName("COURSETYPEID");

                entity.Property(e => e.Credit).HasColumnName("CREDIT");

                entity.Property(e => e.Electivesetid).HasColumnName("ELECTIVESETID");

                entity.Property(e => e.Endsemmark).HasColumnName("ENDSEMMARK");

                entity.Property(e => e.Examcentreid).HasColumnName("EXAMCENTREID");

                entity.Property(e => e.Grade)
                    .HasMaxLength(2)
                    .HasColumnName("GRADE");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Iscalc).HasColumnName("ISCALC");

                entity.Property(e => e.Isprevioustrail).HasColumnName("ISPREVIOUSTRAIL");

                entity.Property(e => e.Istrail).HasColumnName("ISTRAIL");

                entity.Property(e => e.Numeq).HasColumnName("NUMEQ");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Registeredonline).HasColumnName("REGISTEREDONLINE");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Sourcerowid).HasColumnName("SOURCEROWID");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Timeupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEUPDATED");

                entity.Property(e => e.Totalmark).HasColumnName("TOTALMARK");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(100)
                    .HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<AcademicrecordEndsemmark>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ACADEMICRECORD_ENDSEMMARK");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadrank).HasColumnName("ACADRANK");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.App)
                    .HasMaxLength(25)
                    .HasColumnName("APP");

                entity.Property(e => e.Appversion).HasColumnName("APPVERSION");

                entity.Property(e => e.Camark).HasColumnName("CAMARK");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Coursestatusid).HasColumnName("COURSESTATUSID");

                entity.Property(e => e.Coursetypeid).HasColumnName("COURSETYPEID");

                entity.Property(e => e.Credit).HasColumnName("CREDIT");

                entity.Property(e => e.Electivesetid).HasColumnName("ELECTIVESETID");

                entity.Property(e => e.Endsemmark).HasColumnName("ENDSEMMARK");

                entity.Property(e => e.Examcentreid).HasColumnName("EXAMCENTREID");

                entity.Property(e => e.Grade)
                    .HasMaxLength(2)
                    .HasColumnName("GRADE");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Iscalc).HasColumnName("ISCALC");

                entity.Property(e => e.Isprevioustrail).HasColumnName("ISPREVIOUSTRAIL");

                entity.Property(e => e.Istrail).HasColumnName("ISTRAIL");

                entity.Property(e => e.Numeq).HasColumnName("NUMEQ");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Registeredonline).HasColumnName("REGISTEREDONLINE");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Sourcerowid).HasColumnName("SOURCEROWID");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Timeupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEUPDATED");

                entity.Property(e => e.Totalmark).HasColumnName("TOTALMARK");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(100)
                    .HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<AcademicrecordRef>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ACADEMICRECORD_REF");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadrank).HasColumnName("ACADRANK");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.App)
                    .HasMaxLength(25)
                    .HasColumnName("APP");

                entity.Property(e => e.Appversion).HasColumnName("APPVERSION");

                entity.Property(e => e.Camark).HasColumnName("CAMARK");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursecode2)
                    .HasMaxLength(50)
                    .HasColumnName("COURSECODE2");

                entity.Property(e => e.Coursename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Coursestatusid).HasColumnName("COURSESTATUSID");

                entity.Property(e => e.Coursetypeid).HasColumnName("COURSETYPEID");

                entity.Property(e => e.Credit).HasColumnName("CREDIT");

                entity.Property(e => e.Electivesetid).HasColumnName("ELECTIVESETID");

                entity.Property(e => e.Endsemmark).HasColumnName("ENDSEMMARK");

                entity.Property(e => e.Examcentreid).HasColumnName("EXAMCENTREID");

                entity.Property(e => e.Grade)
                    .HasMaxLength(2)
                    .HasColumnName("GRADE");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Iscalc).HasColumnName("ISCALC");

                entity.Property(e => e.Isprevioustrail).HasColumnName("ISPREVIOUSTRAIL");

                entity.Property(e => e.Istrail).HasColumnName("ISTRAIL");

                entity.Property(e => e.Numeq).HasColumnName("NUMEQ");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Registeredonline).HasColumnName("REGISTEREDONLINE");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Sourcerowid).HasColumnName("SOURCEROWID");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Timeupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEUPDATED");

                entity.Property(e => e.Totalmark).HasColumnName("TOTALMARK");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(100)
                    .HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<AcademicrecordRegisteredwithoutpaying>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ACADEMICRECORD_REGISTEREDWITHOUTPAYING");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadrank).HasColumnName("ACADRANK");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.App)
                    .HasMaxLength(25)
                    .HasColumnName("APP");

                entity.Property(e => e.Appversion).HasColumnName("APPVERSION");

                entity.Property(e => e.Camark).HasColumnName("CAMARK");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursecode2)
                    .HasMaxLength(50)
                    .HasColumnName("COURSECODE2");

                entity.Property(e => e.Coursename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Coursestatusid).HasColumnName("COURSESTATUSID");

                entity.Property(e => e.Coursetypeid).HasColumnName("COURSETYPEID");

                entity.Property(e => e.Credit).HasColumnName("CREDIT");

                entity.Property(e => e.Electivesetid).HasColumnName("ELECTIVESETID");

                entity.Property(e => e.Endsemmark).HasColumnName("ENDSEMMARK");

                entity.Property(e => e.Examcentreid).HasColumnName("EXAMCENTREID");

                entity.Property(e => e.Grade)
                    .HasMaxLength(2)
                    .HasColumnName("GRADE");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Iscalc).HasColumnName("ISCALC");

                entity.Property(e => e.Isprevioustrail).HasColumnName("ISPREVIOUSTRAIL");

                entity.Property(e => e.Istrail).HasColumnName("ISTRAIL");

                entity.Property(e => e.Numeq).HasColumnName("NUMEQ");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Registeredonline).HasColumnName("REGISTEREDONLINE");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Sourcerowid).HasColumnName("SOURCEROWID");

                entity.Property(e => e.Statuscode).HasColumnName("STATUSCODE");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Timeupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEUPDATED");

                entity.Property(e => e.Totalmark).HasColumnName("TOTALMARK");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(100)
                    .HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<AcademicrecordRegisteredwithoutpaying2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ACADEMICRECORD_REGISTEREDWITHOUTPAYING2");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadrank).HasColumnName("ACADRANK");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.App)
                    .HasMaxLength(25)
                    .HasColumnName("APP");

                entity.Property(e => e.Appversion).HasColumnName("APPVERSION");

                entity.Property(e => e.Camark).HasColumnName("CAMARK");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursecode2)
                    .HasMaxLength(50)
                    .HasColumnName("COURSECODE2");

                entity.Property(e => e.Coursename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Coursestatusid).HasColumnName("COURSESTATUSID");

                entity.Property(e => e.Coursetypeid).HasColumnName("COURSETYPEID");

                entity.Property(e => e.Credit).HasColumnName("CREDIT");

                entity.Property(e => e.Electivesetid).HasColumnName("ELECTIVESETID");

                entity.Property(e => e.Endsemmark).HasColumnName("ENDSEMMARK");

                entity.Property(e => e.Examcentreid).HasColumnName("EXAMCENTREID");

                entity.Property(e => e.Grade)
                    .HasMaxLength(2)
                    .HasColumnName("GRADE");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Iscalc).HasColumnName("ISCALC");

                entity.Property(e => e.Isprevioustrail).HasColumnName("ISPREVIOUSTRAIL");

                entity.Property(e => e.Istrail).HasColumnName("ISTRAIL");

                entity.Property(e => e.Numeq).HasColumnName("NUMEQ");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Registeredonline).HasColumnName("REGISTEREDONLINE");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Sourcerowid).HasColumnName("SOURCEROWID");

                entity.Property(e => e.Statuscode).HasColumnName("STATUSCODE");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Timeupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEUPDATED");

                entity.Property(e => e.Totalmark).HasColumnName("TOTALMARK");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(100)
                    .HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<AcademicrecordRegisteredwithoutpaying3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ACADEMICRECORD_REGISTEREDWITHOUTPAYING3");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadrank).HasColumnName("ACADRANK");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.App)
                    .HasMaxLength(25)
                    .HasColumnName("APP");

                entity.Property(e => e.Appversion).HasColumnName("APPVERSION");

                entity.Property(e => e.Camark).HasColumnName("CAMARK");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursecode2)
                    .HasMaxLength(50)
                    .HasColumnName("COURSECODE2");

                entity.Property(e => e.Coursename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Coursestatusid).HasColumnName("COURSESTATUSID");

                entity.Property(e => e.Coursetypeid).HasColumnName("COURSETYPEID");

                entity.Property(e => e.Credit).HasColumnName("CREDIT");

                entity.Property(e => e.Electivesetid).HasColumnName("ELECTIVESETID");

                entity.Property(e => e.Endsemmark).HasColumnName("ENDSEMMARK");

                entity.Property(e => e.Examcentreid).HasColumnName("EXAMCENTREID");

                entity.Property(e => e.Grade)
                    .HasMaxLength(2)
                    .HasColumnName("GRADE");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Iscalc).HasColumnName("ISCALC");

                entity.Property(e => e.Isprevioustrail).HasColumnName("ISPREVIOUSTRAIL");

                entity.Property(e => e.Istrail).HasColumnName("ISTRAIL");

                entity.Property(e => e.Numeq).HasColumnName("NUMEQ");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Registeredonline).HasColumnName("REGISTEREDONLINE");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Sourcerowid).HasColumnName("SOURCEROWID");

                entity.Property(e => e.Statuscode).HasColumnName("STATUSCODE");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Timeupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEUPDATED");

                entity.Property(e => e.Totalmark).HasColumnName("TOTALMARK");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(100)
                    .HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Academicrecordonline>(entity =>
            {
                entity.HasKey(e => new { e.Studentid, e.Programmestreamid, e.Acadyear, e.Sem, e.Coursecode })
                    .IsClustered(false);

                entity.ToTable("ACADEMICRECORDONLINE");

                entity.HasIndex(e => new { e.Programmestreamid, e.Acadyear, e.Sem, e.Acadlevelid, e.Studentid }, "_dta_index_ACADEMICRECORDONLINE_c_28_1466644468__K2_K3_K4_K27_K1")
                    .IsClustered();

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Coursecode)
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.App)
                    .HasMaxLength(25)
                    .HasColumnName("APP");

                entity.Property(e => e.Appversion).HasColumnName("APPVERSION");

                entity.Property(e => e.Camark).HasColumnName("CAMARK");

                entity.Property(e => e.Coursename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Coursestatusid).HasColumnName("COURSESTATUSID");

                entity.Property(e => e.Coursetypeid).HasColumnName("COURSETYPEID");

                entity.Property(e => e.Credit).HasColumnName("CREDIT");

                entity.Property(e => e.Electivesetid).HasColumnName("ELECTIVESETID");

                entity.Property(e => e.Endsemmark).HasColumnName("ENDSEMMARK");

                entity.Property(e => e.Grade)
                    .HasMaxLength(2)
                    .HasColumnName("GRADE");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Iscalc).HasColumnName("ISCALC");

                entity.Property(e => e.Isprevioustrail).HasColumnName("ISPREVIOUSTRAIL");

                entity.Property(e => e.Istrail).HasColumnName("ISTRAIL");

                entity.Property(e => e.Numeq).HasColumnName("NUMEQ");

                entity.Property(e => e.Registeredonline).HasColumnName("REGISTEREDONLINE");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Timeupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEUPDATED");

                entity.Property(e => e.Totalmark).HasColumnName("TOTALMARK");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEDBY");

                entity.Property(e => e.Yr).HasColumnName("YR");

                entity.HasOne(d => d.Acadlevel)
                    .WithMany(p => p.Academicrecordonlines)
                    .HasForeignKey(d => d.Acadlevelid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACADEMICRECORDONLINE_ACADLEVEL");
            });

            modelBuilder.Entity<Academicrecordresit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ACADEMICRECORDRESIT");

                entity.Property(e => e.Acadrank).HasColumnName("ACADRANK");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Coursestatusid).HasColumnName("COURSESTATUSID");

                entity.Property(e => e.Credit).HasColumnName("CREDIT");

                entity.Property(e => e.Grade)
                    .HasMaxLength(2)
                    .HasColumnName("GRADE");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Iscalc).HasColumnName("ISCALC");

                entity.Property(e => e.Istrail).HasColumnName("ISTRAIL");

                entity.Property(e => e.Numeq).HasColumnName("NUMEQ");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Timeupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEUPDATED");

                entity.Property(e => e.Totalmark).HasColumnName("TOTALMARK");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEDBY");

                entity.Property(e => e.Yr).HasColumnName("YR");
            });

            modelBuilder.Entity<Academicrecorduploadfile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ACADEMICRECORDUPLOADFILE");

                entity.Property(e => e.Contenttype)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("CONTENTTYPE");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Datetimeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("DATETIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Filedata)
                    .IsRequired()
                    .HasColumnName("FILEDATA");

                entity.Property(e => e.Fileid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("FILEID");

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("FILENAME");

                entity.Property(e => e.Filesize).HasColumnName("FILESIZE");

                entity.Property(e => e.Insertedby)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Lecturerid).HasColumnName("LECTURERID");

                entity.Property(e => e.Paramlist)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("PARAMLIST");
            });

            modelBuilder.Entity<Adt>(entity =>
            {
                entity.ToTable("ADT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Actiontaken)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("ACTIONTAKEN")
                    .IsFixedLength(true);

                entity.Property(e => e.Actiontime)
                    .HasColumnType("datetime")
                    .HasColumnName("ACTIONTIME");

                entity.Property(e => e.Appusername)
                    .HasMaxLength(100)
                    .HasColumnName("APPUSERNAME");

                entity.Property(e => e.Clientnetaddress)
                    .HasMaxLength(255)
                    .HasColumnName("CLIENTNETADDRESS");

                entity.Property(e => e.Dbusername)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("DBUSERNAME");

                entity.Property(e => e.Fieldaffected)
                    .HasMaxLength(100)
                    .HasColumnName("FIELDAFFECTED");

                entity.Property(e => e.Fielddescription)
                    .HasMaxLength(100)
                    .HasColumnName("FIELDDESCRIPTION");

                entity.Property(e => e.Hostid).HasColumnName("HOSTID");

                entity.Property(e => e.Hostname)
                    .HasMaxLength(100)
                    .HasColumnName("HOSTNAME");

                entity.Property(e => e.Newvalue)
                    .HasMaxLength(500)
                    .HasColumnName("NEWVALUE");

                entity.Property(e => e.Oldvalue)
                    .HasMaxLength(500)
                    .HasColumnName("OLDVALUE");

                entity.Property(e => e.Programmestreamid)
                    .HasMaxLength(10)
                    .HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Recorddata)
                    .HasMaxLength(500)
                    .HasColumnName("RECORDDATA");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Tableaffected)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("TABLEAFFECTED");
            });

            modelBuilder.Entity<Alumnidetail>(entity =>
            {
                entity.ToTable("ALUMNIDETAILS");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.FacebookUrl)
                    .HasMaxLength(200)
                    .HasColumnName("FacebookURL");

                entity.Property(e => e.FirstName).HasMaxLength(150);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Inserted).HasColumnType("datetime");

                entity.Property(e => e.InsertedBy)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.NationalServiceInstitution).HasMaxLength(200);

                entity.Property(e => e.OtherNames)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.ServicePostingLocation).HasMaxLength(200);

                entity.Property(e => e.StudentId).HasMaxLength(20);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.TelegramNumber).HasMaxLength(20);

                entity.Property(e => e.TwitterHandle).HasMaxLength(200);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(150);

                entity.Property(e => e.WhatsappNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.College)
                    .WithMany(p => p.Alumnidetails)
                    .HasForeignKey(d => d.CollegeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ALUMNIDETAILS_COLLEGE");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Alumnidetails)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_ALUMNIDETAILS_DEPARTMENT");

                entity.HasOne(d => d.HallOfAffiliationNavigation)
                    .WithMany(p => p.Alumnidetails)
                    .HasForeignKey(d => d.HallOfAffiliation)
                    .HasConstraintName("FK_ALUMNIDETAILS_HALLOFAFFILIATION");

                entity.HasOne(d => d.ProgrammeStream)
                    .WithMany(p => p.Alumnidetails)
                    .HasForeignKey(d => d.ProgrammeStreamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ALUMNIDETAILS_PROGRAMMESTREAM");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Alumnidetails)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_ALUMNIDETAILS_STUDENT");
            });

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.UserName, "missing_index_1");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.FullName).HasMaxLength(150);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.LastPasswordChangeDate).HasColumnType("datetime");

                entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.PasswordExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.UserDescription).HasMaxLength(100);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId })
                    .HasName("PK_dbo.AspNetUserLogins");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK_dbo.AspNetUserRoles");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.Property(e => e.RoleId).HasMaxLength(128);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<Awardclass>(entity =>
            {
                entity.HasKey(e => e.Awardclassid)
                    .IsClustered(false);

                entity.ToTable("AWARDCLASS");

                entity.Property(e => e.Awardclassid)
                    .ValueGeneratedNever()
                    .HasColumnName("AWARDCLASSID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.Weightvalue).HasColumnName("WEIGHTVALUE");
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.HasKey(e => e.Bankid)
                    .IsClustered(false);

                entity.ToTable("BANK");

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Accountnumber)
                    .HasMaxLength(20)
                    .HasColumnName("ACCOUNTNUMBER");

                entity.Property(e => e.Add1)
                    .HasMaxLength(100)
                    .HasColumnName("ADD1");

                entity.Property(e => e.Add2)
                    .HasMaxLength(100)
                    .HasColumnName("ADD2");

                entity.Property(e => e.Add3)
                    .HasMaxLength(100)
                    .HasColumnName("ADD3");

                entity.Property(e => e.Add4)
                    .HasMaxLength(100)
                    .HasColumnName("ADD4");

                entity.Property(e => e.Add5)
                    .HasMaxLength(100)
                    .HasColumnName("ADD5");

                entity.Property(e => e.Gid)
                    .HasMaxLength(50)
                    .HasColumnName("GID");

                entity.Property(e => e.Gid2)
                    .HasMaxLength(50)
                    .HasColumnName("GID2");

                entity.Property(e => e.Isaccountnumberrequired)
                    .IsRequired()
                    .HasColumnName("ISACCOUNTNUMBERREQUIRED")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Isactive)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Isactiveoffline)
                    .IsRequired()
                    .HasColumnName("ISACTIVEOFFLINE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Logo).HasColumnName("LOGO");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.Shortname)
                    .HasMaxLength(20)
                    .HasColumnName("SHORTNAME");
            });

            modelBuilder.Entity<Bankaccount>(entity =>
            {
                entity.HasKey(e => e.Bankaccountid)
                    .IsClustered(false);

                entity.ToTable("BANKACCOUNT");

                entity.Property(e => e.Bankaccountid).HasColumnName("BANKACCOUNTID");

                entity.Property(e => e.Accountgroupid).HasColumnName("ACCOUNTGROUPID");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(20)
                    .HasColumnName("ACCOUNTNO");

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.Currencyid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Glaccountid).HasColumnName("GLACCOUNTID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.Bankaccounts)
                    .HasForeignKey(d => d.Bankid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("BANKBANKACCOUNT");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Bankaccounts)
                    .HasForeignKey(d => d.Currencyid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RefCURRENCY5591");
            });

            modelBuilder.Entity<Billactivitylog>(entity =>
            {
                entity.ToTable("BILLACTIVITYLOG");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Deletecount).HasColumnName("DELETECOUNT");

                entity.Property(e => e.Insertcount).HasColumnName("INSERTCOUNT");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Building>(entity =>
            {
                entity.HasKey(e => e.Buildingid)
                    .IsClustered(false);

                entity.ToTable("BUILDING");

                entity.Property(e => e.Buildingid)
                    .ValueGeneratedNever()
                    .HasColumnName("BUILDINGID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<Building1>(entity =>
            {
                entity.HasKey(e => e.BuildingId)
                    .IsClustered(false);

                entity.ToTable("Building", "tt");

                entity.Property(e => e.BuildingCode).HasMaxLength(10);

                entity.Property(e => e.BuildingLocation).HasMaxLength(100);

                entity.Property(e => e.BuildingName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.BuildingNotes).HasMaxLength(200);
            });

            modelBuilder.Entity<BuildingLevel>(entity =>
            {
                entity.HasKey(e => e.BuildingFloorId)
                    .IsClustered(false);

                entity.ToTable("BuildingLevel", "tt");

                entity.Property(e => e.FloorName).HasMaxLength(100);

                entity.HasOne(d => d.Building)
                    .WithMany(p => p.BuildingLevels)
                    .HasForeignKey(d => d.BuildingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BuildingLevel_Building");

                entity.HasOne(d => d.Level)
                    .WithMany(p => p.BuildingLevels)
                    .HasForeignKey(d => d.LevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BuildingLevel_Level");
            });

            modelBuilder.Entity<Calendar>(entity =>
            {
                entity.HasKey(e => e.Calendarid)
                    .IsClustered(false);

                entity.ToTable("CALENDAR");

                entity.HasIndex(e => e.Calendarid, "ClusteredIndex-20180516-085020")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Calendarid).HasColumnName("CALENDARID");

                entity.Property(e => e.Isdefault).HasColumnName("ISDEFAULT");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<Calendardetail>(entity =>
            {
                entity.HasKey(e => new { e.Calendarid, e.Acadyear, e.Sem })
                    .IsClustered(false);

                entity.ToTable("CALENDARDETAIL");

                entity.HasIndex(e => new { e.Acadyear, e.Calendarid, e.Sem }, "ClusteredIndex-20200226-110456")
                    .IsClustered();

                entity.Property(e => e.Calendarid).HasColumnName("CALENDARID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Billdate)
                    .HasColumnType("date")
                    .HasColumnName("BILLDATE");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Enddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ENDDATE");

                entity.Property(e => e.Examenddate)
                    .HasColumnType("datetime")
                    .HasColumnName("EXAMENDDATE");

                entity.Property(e => e.Examstartdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EXAMSTARTDATE");

                entity.Property(e => e.Feepaymentstartdate)
                    .HasColumnType("date")
                    .HasColumnName("FEEPAYMENTSTARTDATE");

                entity.Property(e => e.Isdefault).HasColumnName("ISDEFAULT");

                entity.Property(e => e.Registrationenddate)
                    .HasColumnType("datetime")
                    .HasColumnName("REGISTRATIONENDDATE");

                entity.Property(e => e.Registrationstartdate)
                    .HasColumnType("datetime")
                    .HasColumnName("REGISTRATIONSTARTDATE");

                entity.Property(e => e.Startdate)
                    .HasColumnType("datetime")
                    .HasColumnName("STARTDATE");

                entity.HasOne(d => d.Calendar)
                    .WithMany(p => p.Calendardetails)
                    .HasForeignKey(d => d.Calendarid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CALENDARCALENDARDETAIL");
            });

            modelBuilder.Entity<Campus>(entity =>
            {
                entity.HasKey(e => e.Campusid)
                    .IsClustered(false);

                entity.ToTable("CAMPUS");

                entity.HasIndex(e => e.Name, "AK_CAMPUS")
                    .IsUnique();

                entity.Property(e => e.Campusid).HasColumnName("CAMPUSID");

                entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");

                entity.Property(e => e.Isdefault).HasColumnName("ISDEFAULT");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.Regionid).HasColumnName("REGIONID");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Campuses)
                    .HasForeignKey(d => d.Regionid)
                    .HasConstraintName("REGIONCAMPUS");
            });

            modelBuilder.Entity<Campus2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CAMPUS2");

                entity.Property(e => e.Campusid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CAMPUSID");

                entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");

                entity.Property(e => e.Isdefault).HasColumnName("ISDEFAULT");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.Regionid).HasColumnName("REGIONID");
            });

            modelBuilder.Entity<Certificatetype>(entity =>
            {
                entity.HasKey(e => e.Certificatetypeid)
                    .IsClustered(false);

                entity.ToTable("CERTIFICATETYPE");

                entity.Property(e => e.Certificatetypeid).HasColumnName("CERTIFICATETYPEID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<Classparameter>(entity =>
            {
                entity.HasKey(e => new { e.Classid, e.Programmestreamid })
                    .IsClustered(false);

                entity.ToTable("CLASSPARAMETER");

                entity.HasIndex(e => new { e.Programmestreamid, e.Currentclass }, "IX_CLASSPARAMETER");

                entity.Property(e => e.Classid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CLASSID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Currentclass).HasColumnName("CURRENTCLASS");

                entity.Property(e => e.Finalsem).HasColumnName("FINALSEM");

                entity.Property(e => e.Finalyear).HasColumnName("FINALYEAR");

                entity.Property(e => e.Gradingid).HasColumnName("GRADINGID");

                entity.Property(e => e.Mincredits).HasColumnName("MINCREDITS");

                entity.HasOne(d => d.Grading)
                    .WithMany(p => p.Classparameters)
                    .HasForeignKey(d => d.Gradingid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("GRADINGSYSTEMCLASSPARAMETER");

                entity.HasOne(d => d.Programmestream)
                    .WithMany(p => p.Classparameters)
                    .HasForeignKey(d => d.Programmestreamid)
                    .HasConstraintName("PROGRAMMESTREAMCLASSPARAMETER");
            });

            modelBuilder.Entity<ClassparameterBk>(entity =>
            {
                entity.HasKey(e => new { e.Classid, e.Programmestreamid })
                    .IsClustered(false);

                entity.ToTable("CLASSPARAMETER_BK");

                entity.Property(e => e.Classid).HasColumnName("CLASSID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Currentclass).HasColumnName("CURRENTCLASS");

                entity.Property(e => e.Finalsem).HasColumnName("FINALSEM");

                entity.Property(e => e.Finalyear).HasColumnName("FINALYEAR");

                entity.Property(e => e.Gradingid).HasColumnName("GRADINGID");

                entity.Property(e => e.Mincredits).HasColumnName("MINCREDITS");

                entity.HasOne(d => d.Grading)
                    .WithMany(p => p.ClassparameterBks)
                    .HasForeignKey(d => d.Gradingid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("GRADINGSYSTEMCLASSPARAMETER_BK");

                entity.HasOne(d => d.Programmestream)
                    .WithMany(p => p.ClassparameterBks)
                    .HasForeignKey(d => d.Programmestreamid)
                    .HasConstraintName("PROGRAMMESTREAMCLASSPARAMETER_BK");
            });

            modelBuilder.Entity<Classroom>(entity =>
            {
                entity.HasKey(e => e.Classroomid)
                    .IsClustered(false);

                entity.ToTable("CLASSROOM");

                entity.Property(e => e.Classroomid)
                    .ValueGeneratedNever()
                    .HasColumnName("CLASSROOMID");

                entity.Property(e => e.Buildingid).HasColumnName("BUILDINGID");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Examcapacity).HasColumnName("EXAMCAPACITY");

                entity.Property(e => e.Examcrashcapacity).HasColumnName("EXAMCRASHCAPACITY");

                entity.Property(e => e.Lecturecapacity).HasColumnName("LECTURECAPACITY");

                entity.Property(e => e.Lecturecrashcapacity).HasColumnName("LECTURECRASHCAPACITY");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("NAME");

                entity.Property(e => e.Shortcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SHORTCODE");

                entity.HasOne(d => d.Building)
                    .WithMany(p => p.Classrooms)
                    .HasForeignKey(d => d.Buildingid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("BUILDINGCLASSROOM");

                entity.HasOne(d => d.College)
                    .WithMany(p => p.Classrooms)
                    .HasForeignKey(d => d.Collegeid)
                    .HasConstraintName("COLLEGECLASSROOM");
            });

            modelBuilder.Entity<Collection>(entity =>
            {
                entity.ToTable("COLLECTIONS");

                entity.Property(e => e.Collectionid).HasColumnName("COLLECTIONID");

                entity.Property(e => e.Collectionname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("COLLECTIONNAME");
            });

            modelBuilder.Entity<Collectionprogrammestream>(entity =>
            {
                entity.ToTable("COLLECTIONPROGRAMMESTREAM");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Collectionid).HasColumnName("COLLECTIONID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");
            });

            modelBuilder.Entity<College>(entity =>
            {
                entity.HasKey(e => e.Collegeid)
                    .IsClustered(false);

                entity.ToTable("COLLEGE");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Collegecode)
                    .HasMaxLength(10)
                    .HasColumnName("COLLEGECODE");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .HasColumnName("FAX");

                entity.Property(e => e.Head)
                    .HasMaxLength(100)
                    .HasColumnName("HEAD");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Phoneext)
                    .HasMaxLength(3)
                    .HasColumnName("PHONEEXT");

                entity.Property(e => e.Registrationemail)
                    .HasMaxLength(50)
                    .HasColumnName("REGISTRATIONEMAIL");

                entity.Property(e => e.Website)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("WEBSITE");
            });

            modelBuilder.Entity<College1>(entity =>
            {
                entity.HasKey(e => e.CollegeId)
                    .IsClustered(false);

                entity.ToTable("College", "tt");

                entity.Property(e => e.CollegeId).ValueGeneratedNever();

                entity.Property(e => e.CollegeName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Connecteddevice>(entity =>
            {
                entity.HasKey(e => new { e.Deviceid, e.Studentid });

                entity.ToTable("CONNECTEDDEVICE");

                entity.HasIndex(e => e.Studentid, "IX_CONNECTEDDEVICE1");

                entity.Property(e => e.Deviceid)
                    .HasMaxLength(50)
                    .HasColumnName("DEVICEID");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.App)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("APP");

                entity.Property(e => e.Appversioncode).HasColumnName("APPVERSIONCODE");

                entity.Property(e => e.Appversionname)
                    .HasMaxLength(10)
                    .HasColumnName("APPVERSIONNAME");

                entity.Property(e => e.Datetimeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("DATETIMEINSERTED");

                entity.Property(e => e.Datetimeupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("DATETIMEUPDATED");

                entity.Property(e => e.Devicename)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("DEVICENAME");

                entity.Property(e => e.Fcmregid)
                    .HasMaxLength(250)
                    .HasColumnName("FCMREGID");

                entity.Property(e => e.Fcmsenderid)
                    .HasMaxLength(50)
                    .HasColumnName("FCMSENDERID");

                entity.Property(e => e.Location)
                    .HasMaxLength(200)
                    .HasColumnName("LOCATION");

                entity.Property(e => e.Operatingsystem)
                    .HasMaxLength(150)
                    .HasColumnName("OPERATINGSYSTEM");
            });

            modelBuilder.Entity<Control>(entity =>
            {
                entity.HasKey(e => new { e.Formname, e.Controlname })
                    .IsClustered(false);

                entity.ToTable("CONTROL");

                entity.Property(e => e.Formname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FORMNAME");

                entity.Property(e => e.Controlname)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CONTROLNAME");

                entity.Property(e => e.Controltype)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CONTROLTYPE");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Isdefault).HasColumnName("ISDEFAULT");

                entity.Property(e => e.Navigation)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NAVIGATION");

                entity.Property(e => e.Ownercontrol)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("OWNERCONTROL");
            });

            modelBuilder.Entity<Controlrole>(entity =>
            {
                entity.HasKey(e => new { e.Formname, e.Controlname, e.Roleid })
                    .IsClustered(false);

                entity.ToTable("CONTROLROLE");

                entity.HasIndex(e => new { e.Formname, e.Roleid }, "missing_index_37");

                entity.Property(e => e.Formname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FORMNAME");

                entity.Property(e => e.Controlname)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CONTROLNAME");

                entity.Property(e => e.Roleid)
                    .HasMaxLength(128)
                    .HasColumnName("ROLEID");

                entity.Property(e => e.Controlstate).HasColumnName("CONTROLSTATE");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Controlroles)
                    .HasForeignKey(d => d.Roleid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ROLE_CONTROLROLE");

                entity.HasOne(d => d.Control)
                    .WithMany(p => p.Controlroles)
                    .HasForeignKey(d => new { d.Formname, d.Controlname })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONTROL_CONTROLROLE");
            });

            modelBuilder.Entity<Controlstate>(entity =>
            {
                entity.HasKey(e => e.Controlstateid)
                    .IsClustered(false);

                entity.ToTable("CONTROLSTATE");

                entity.Property(e => e.Controlstateid)
                    .ValueGeneratedNever()
                    .HasColumnName("CONTROLSTATEID");

                entity.Property(e => e.Controlstate1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CONTROLSTATE");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.Countryid)
                    .IsClustered(false);

                entity.ToTable("COUNTRY");

                entity.Property(e => e.Countryid)
                    .HasMaxLength(3)
                    .HasColumnName("COUNTRYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.Nationality)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NATIONALITY");

                entity.Property(e => e.Phonecode)
                    .HasMaxLength(5)
                    .HasColumnName("PHONECODE");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasKey(e => e.CourseId)
                    .IsClustered(false);

                entity.ToTable("Course", "tt");

                entity.Property(e => e.CourseCode)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.CourseName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<CourseLecturer1>(entity =>
            {
                entity.HasKey(e => e.CourseLecturerId)
                    .IsClustered(false);

                entity.ToTable("CourseLecturer", "tt");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.CourseLecturer1s)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CourseLecturer_Course");
            });

            modelBuilder.Entity<CourseSchedule>(entity =>
            {
                entity.HasKey(e => e.CourseScheduleId)
                    .IsClustered(false);

                entity.ToTable("CourseSchedule", "tt");

                entity.Property(e => e.CourseName).HasMaxLength(150);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Published).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.AcademicSemester)
                    .WithMany(p => p.CourseSchedules)
                    .HasForeignKey(d => d.AcademicSemesterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CourseSchedule_AcademicSemester");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.CourseSchedules)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CourseSchedule_Course");

                entity.HasOne(d => d.Period)
                    .WithMany(p => p.CourseSchedules)
                    .HasForeignKey(d => d.PeriodId)
                    .HasConstraintName("FK_CourseSchedule_TimeSlot");

                entity.HasOne(d => d.ProgrammeStream)
                    .WithMany(p => p.CourseSchedules)
                    .HasForeignKey(d => d.ProgrammeStreamId)
                    .HasConstraintName("FK_CourseSchedule_ProgrammeStream");

                entity.HasOne(d => d.WeekDay)
                    .WithMany(p => p.CourseSchedules)
                    .HasForeignKey(d => d.WeekDayId)
                    .HasConstraintName("FK_CourseSchedule_WeekDay");

                entity.HasOne(d => d.YearLevel)
                    .WithMany(p => p.CourseSchedules)
                    .HasForeignKey(d => d.YearLevelId)
                    .HasConstraintName("FK_CourseSchedule_YearLevel");
            });

            modelBuilder.Entity<CourseScheduleLecturer>(entity =>
            {
                entity.ToTable("CourseScheduleLecturer", "tt");

                entity.HasOne(d => d.CourseSchedule)
                    .WithMany(p => p.CourseScheduleLecturers)
                    .HasForeignKey(d => d.CourseScheduleId)
                    .HasConstraintName("FK_CourseScheduleLecturer_CourseSchedule");

                entity.HasOne(d => d.Lecturer)
                    .WithMany(p => p.CourseScheduleLecturers)
                    .HasForeignKey(d => d.LecturerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CourseScheduleLecturer_Lecturer");
            });

            modelBuilder.Entity<Courselecturer>(entity =>
            {
                entity.HasKey(e => new { e.Lecturerid, e.Coursecode, e.Acadlevelid, e.Programmestreamid, e.Acadyear, e.Sem })
                    .HasName("PK_COURSELECTURER_1");

                entity.ToTable("COURSELECTURER");

                entity.HasIndex(e => new { e.Coursecode, e.Acadlevelid, e.Programmestreamid, e.Acadyear, e.Sem }, "IX_COURSELECTURER");

                entity.Property(e => e.Lecturerid).HasColumnName("LECTURERID");

                entity.Property(e => e.Coursecode)
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Isprimary).HasColumnName("ISPRIMARY");

                entity.HasOne(d => d.Lecturer)
                    .WithMany(p => p.Courselecturers)
                    .HasForeignKey(d => d.Lecturerid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("LECTURERCOURSELECTURER");
            });

            modelBuilder.Entity<Courseregistrationexception>(entity =>
            {
                entity.HasKey(e => new { e.Studentid, e.Programmestreamid, e.Acadyear, e.Sem });

                entity.ToTable("COURSEREGISTRATIONEXCEPTION");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Datetimeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("DATETIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Enddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ENDDATE");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasColumnName("REASON");

                entity.Property(e => e.Startdate)
                    .HasColumnType("datetime")
                    .HasColumnName("STARTDATE");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("USERNAME");

                entity.HasOne(d => d.Programmestream)
                    .WithMany(p => p.Courseregistrationexceptions)
                    .HasForeignKey(d => d.Programmestreamid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROGRAMMESTREAM_COURSEREGISTRATIONEXCEPTION");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Courseregistrationexceptions)
                    .HasForeignKey(d => d.Studentid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STUDENT_COURSEREGISTRATIONEXCEPTION");
            });

            modelBuilder.Entity<Coursesetting>(entity =>
            {
                entity.HasKey(e => new { e.Programmestreamid, e.Optionid, e.Acadyear, e.Sem, e.Acadlevelid })
                    .IsClustered(false);

                entity.ToTable("COURSESETTING");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Optionid).HasColumnName("OPTIONID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Maxoptcourse1).HasColumnName("MAXOPTCOURSE1");

                entity.Property(e => e.Maxoptcourse2).HasColumnName("MAXOPTCOURSE2");

                entity.Property(e => e.Maxoptcourse3).HasColumnName("MAXOPTCOURSE3");

                entity.Property(e => e.Maxsemcredit).HasColumnName("MAXSEMCREDIT");

                entity.Property(e => e.Minoptcourse1).HasColumnName("MINOPTCOURSE1");

                entity.Property(e => e.Minoptcourse2).HasColumnName("MINOPTCOURSE2");

                entity.Property(e => e.Minoptcourse3).HasColumnName("MINOPTCOURSE3");

                entity.Property(e => e.Minsemcredit).HasColumnName("MINSEMCREDIT");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.Coursesettings)
                    .HasForeignKey(d => new { d.Acadyear, d.Sem })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SEMESTERCOURSESETTING");

                entity.HasOne(d => d.Programmeoption)
                    .WithMany(p => p.Coursesettings)
                    .HasForeignKey(d => new { d.Optionid, d.Programmestreamid })
                    .HasConstraintName("PROGRAMMEOPTIONCOURSESETTING");
            });

            modelBuilder.Entity<Coursestatus>(entity =>
            {
                entity.HasKey(e => e.Coursestatusid)
                    .IsClustered(false);

                entity.ToTable("COURSESTATUS");

                entity.Property(e => e.Coursestatusid)
                    .ValueGeneratedNever()
                    .HasColumnName("COURSESTATUSID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("NAME");

                entity.Property(e => e.Shortcode)
                    .HasMaxLength(50)
                    .HasColumnName("SHORTCODE");

                entity.Property(e => e.Usemark2computeaverage).HasColumnName("USEMARK2COMPUTEAVERAGE");
            });

            modelBuilder.Entity<Coursetype>(entity =>
            {
                entity.HasKey(e => e.Coursetypeid)
                    .IsClustered(false);

                entity.ToTable("COURSETYPE");

                entity.Property(e => e.Coursetypeid)
                    .ValueGeneratedNever()
                    .HasColumnName("COURSETYPEID");

                entity.Property(e => e.Iscore).HasColumnName("ISCORE");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<Covidvaccinetype>(entity =>
            {
                entity.HasKey(e => e.VaccineTypeId);

                entity.ToTable("COVIDVACCINETYPE");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.VaccineTypeName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.HasKey(e => e.Currencyid)
                    .IsClustered(false);

                entity.ToTable("CURRENCY");

                entity.Property(e => e.Currencyid)
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Isactive)
                    .IsRequired()
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Isdefault).HasColumnName("ISDEFAULT");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("NAME");

                entity.Property(e => e.Name2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("NAME2");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(5)
                    .HasColumnName("SYMBOL");
            });

            modelBuilder.Entity<Datasource>(entity =>
            {
                entity.HasKey(e => e.Sourceid);

                entity.ToTable("DATASOURCE");

                entity.Property(e => e.Sourceid)
                    .ValueGeneratedNever()
                    .HasColumnName("SOURCEID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<Dayofweek>(entity =>
            {
                entity.HasKey(e => e.Dayid)
                    .IsClustered(false);

                entity.ToTable("DAYOFWEEK");

                entity.Property(e => e.Dayid)
                    .ValueGeneratedNever()
                    .HasColumnName("DAYID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<Daysession>(entity =>
            {
                entity.HasKey(e => e.Daysessionid)
                    .IsClustered(false);

                entity.ToTable("DAYSESSION");

                entity.Property(e => e.Daysessionid)
                    .ValueGeneratedNever()
                    .HasColumnName("DAYSESSIONID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<Dddd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DDDD");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Lecturerid).HasColumnName("LECTURERID");

                entity.Property(e => e.Optionid).HasColumnName("OPTIONID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");
            });

            modelBuilder.Entity<Degree>(entity =>
            {
                entity.ToTable("DEGREE");

                entity.HasIndex(e => e.Degreelongname, "AK_DEGREE")
                    .IsUnique();

                entity.Property(e => e.Degreeid).HasColumnName("DEGREEID");

                entity.Property(e => e.Degreelongname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("DEGREELONGNAME");

                entity.Property(e => e.Degreeshortname)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("DEGREESHORTNAME");

                entity.Property(e => e.Degreetypeid).HasColumnName("DEGREETYPEID");

                entity.HasOne(d => d.Degreetype)
                    .WithMany(p => p.Degrees)
                    .HasForeignKey(d => d.Degreetypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DEGREE_DEGREETYPE");
            });

            modelBuilder.Entity<Degreetype>(entity =>
            {
                entity.ToTable("DEGREETYPE");

                entity.Property(e => e.Degreetypeid)
                    .ValueGeneratedNever()
                    .HasColumnName("DEGREETYPEID");

                entity.Property(e => e.Degreelevel).HasColumnName("DEGREELEVEL");

                entity.Property(e => e.Degreetypename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("DEGREETYPENAME");

                entity.Property(e => e.Graduatetypeid).HasColumnName("GRADUATETYPEID");
            });

            modelBuilder.Entity<Del2studentsWithtrails20212>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DEL2STUDENTS_WITHTRAILS2021_2");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadlevelidtrail).HasColumnName("ACADLEVELIDTRAIL");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Acadyeartrail).HasColumnName("ACADYEARTRAIL");

                entity.Property(e => e.Coursecode)
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursename)
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Coursestatusid).HasColumnName("COURSESTATUSID");

                entity.Property(e => e.Credit).HasColumnName("CREDIT");

                entity.Property(e => e.Grade)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GRADE");

                entity.Property(e => e.Numeq).HasColumnName("NUMEQ");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Semtrail).HasColumnName("SEMTRAIL");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Totalmark)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TOTALMARK");
            });

            modelBuilder.Entity<Del2studentsWithtrails20212Greaterthan2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DEL2STUDENTS_WITHTRAILS2021_2_GREATERTHAN2");

                entity.Property(e => e.Counttrails).HasColumnName("COUNTTRAILS");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<Del2studentsWithtrails20212Greaterthan2Registered>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DEL2STUDENTS_WITHTRAILS2021_2_GREATERTHAN2_REGISTERED");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Autopromoted).HasColumnName("AUTOPROMOTED");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Iscurrent).HasColumnName("ISCURRENT");

                entity.Property(e => e.Metadata)
                    .HasMaxLength(1000)
                    .HasColumnName("METADATA");

                entity.Property(e => e.Preregistrationstatus).HasColumnName("PREREGISTRATIONSTATUS");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Sourcerowguid).HasColumnName("SOURCEROWGUID");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Yr2).HasColumnName("YR2");
            });

            modelBuilder.Entity<DelCurrent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DEL_CURRENT");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Acadyearstring)
                    .HasMaxLength(61)
                    .IsUnicode(false)
                    .HasColumnName("ACADYEARSTRING");

                entity.Property(e => e.Campus)
                    .HasMaxLength(100)
                    .HasColumnName("CAMPUS");

                entity.Property(e => e.Campusid).HasColumnName("CAMPUSID");

                entity.Property(e => e.College)
                    .HasMaxLength(100)
                    .HasColumnName("COLLEGE");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .HasColumnName("DEPARTMENT");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Faculty)
                    .HasMaxLength(100)
                    .HasColumnName("FACULTY");

                entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");

                entity.Property(e => e.Feecategory)
                    .HasMaxLength(100)
                    .HasColumnName("FEECATEGORY");

                entity.Property(e => e.Feecategoryid).HasColumnName("FEECATEGORYID");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(101)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Graduatetype)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("GRADUATETYPE");

                entity.Property(e => e.Graduatetypeid).HasColumnName("GRADUATETYPEID");

                entity.Property(e => e.IsbiometricallyOrCourseregistered).HasColumnName("ISBIOMETRICALLY_OR_COURSEREGISTERED");

                entity.Property(e => e.Isbiometricallyverified).HasColumnName("ISBIOMETRICALLYVERIFIED");

                entity.Property(e => e.Iscourseregistered).HasColumnName("ISCOURSEREGISTERED");

                entity.Property(e => e.Isforeigner).HasColumnName("ISFOREIGNER");

                entity.Property(e => e.Isghanaian).HasColumnName("ISGHANAIAN");

                entity.Property(e => e.Isinfinalyear).HasColumnName("ISINFINALYEAR");

                entity.Property(e => e.Isingraceperiod).HasColumnName("ISINGRACEPERIOD");

                entity.Property(e => e.Othername)
                    .HasMaxLength(50)
                    .HasColumnName("OTHERNAME");

                entity.Property(e => e.Primarymobile)
                    .HasMaxLength(20)
                    .HasColumnName("PRIMARYMOBILE");

                entity.Property(e => e.Programmestream)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("PROGRAMMESTREAM");

                entity.Property(e => e.ProgrammestreamBiometricverificationrequired).HasColumnName("PROGRAMMESTREAM_BIOMETRICVERIFICATIONREQUIRED");

                entity.Property(e => e.Schoolmobile)
                    .HasMaxLength(20)
                    .HasColumnName("SCHOOLMOBILE");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentcategoryname)
                    .HasMaxLength(50)
                    .HasColumnName("STUDENTCATEGORYNAME");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("SURNAME");

                entity.Property(e => e.Tag)
                    .HasMaxLength(30)
                    .HasColumnName("TAG");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");
            });

            modelBuilder.Entity<DelCurrentx>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DEL_CURRENTX");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Acadyearstring)
                    .HasMaxLength(61)
                    .IsUnicode(false)
                    .HasColumnName("ACADYEARSTRING");

                entity.Property(e => e.Campus)
                    .HasMaxLength(100)
                    .HasColumnName("CAMPUS");

                entity.Property(e => e.Campusid).HasColumnName("CAMPUSID");

                entity.Property(e => e.College)
                    .HasMaxLength(100)
                    .HasColumnName("COLLEGE");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .HasColumnName("DEPARTMENT");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Faculty)
                    .HasMaxLength(100)
                    .HasColumnName("FACULTY");

                entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");

                entity.Property(e => e.Feecategory)
                    .HasMaxLength(100)
                    .HasColumnName("FEECATEGORY");

                entity.Property(e => e.Feecategoryid).HasColumnName("FEECATEGORYID");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(101)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Graduatetype)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("GRADUATETYPE");

                entity.Property(e => e.Graduatetypeid).HasColumnName("GRADUATETYPEID");

                entity.Property(e => e.IsbiometricallyOrCourseregistered).HasColumnName("ISBIOMETRICALLY_OR_COURSEREGISTERED");

                entity.Property(e => e.Isbiometricallyverified).HasColumnName("ISBIOMETRICALLYVERIFIED");

                entity.Property(e => e.Iscourseregistered).HasColumnName("ISCOURSEREGISTERED");

                entity.Property(e => e.Isforeigner).HasColumnName("ISFOREIGNER");

                entity.Property(e => e.Isghanaian).HasColumnName("ISGHANAIAN");

                entity.Property(e => e.Isinfinalyear).HasColumnName("ISINFINALYEAR");

                entity.Property(e => e.Isingraceperiod).HasColumnName("ISINGRACEPERIOD");

                entity.Property(e => e.Othername)
                    .HasMaxLength(50)
                    .HasColumnName("OTHERNAME");

                entity.Property(e => e.Primarymobile)
                    .HasMaxLength(20)
                    .HasColumnName("PRIMARYMOBILE");

                entity.Property(e => e.Programmestream)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("PROGRAMMESTREAM");

                entity.Property(e => e.ProgrammestreamBiometricverificationrequired).HasColumnName("PROGRAMMESTREAM_BIOMETRICVERIFICATIONREQUIRED");

                entity.Property(e => e.Schoolmobile)
                    .HasMaxLength(20)
                    .HasColumnName("SCHOOLMOBILE");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentcategoryname)
                    .HasMaxLength(50)
                    .HasColumnName("STUDENTCATEGORYNAME");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("SURNAME");

                entity.Property(e => e.Tag)
                    .HasMaxLength(30)
                    .HasColumnName("TAG");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");
            });

            modelBuilder.Entity<DelCwaFinalyear>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DEL_CWA_FINALYEARS");

                entity.Property(e => e.Cwa).HasColumnName("CWA");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<DelIdlarmisreconciled>(entity =>
            {
                entity.ToTable("DEL_IDLARMISRECONCILED");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(19, 9)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.Crp)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("CRP");

                entity.Property(e => e.Cru)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("CRU");

                entity.Property(e => e.Dr)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("DR");

                entity.Property(e => e.Oid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("OID");

                entity.Property(e => e.Oline)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OLINE");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Transdate)
                    .HasColumnType("datetime")
                    .HasColumnName("TRANSDATE");

                entity.Property(e => e.Transid)
                    .HasMaxLength(255)
                    .HasColumnName("TRANSID");
            });

            modelBuilder.Entity<DelResidencemove>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DEL_RESIDENCEMOVE");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Bookingcode).HasColumnName("BOOKINGCODE");

                entity.Property(e => e.Bookingdeadline)
                    .HasColumnType("datetime")
                    .HasColumnName("BOOKINGDEADLINE");

                entity.Property(e => e.Bookingtypeid).HasColumnName("BOOKINGTYPEID");

                entity.Property(e => e.Flag).HasColumnName("FLAG");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idx)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDX");

                entity.Property(e => e.Insertedby)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Ispaid).HasColumnName("ISPAID");

                entity.Property(e => e.Isreserved).HasColumnName("ISRESERVED");

                entity.Property(e => e.Newresidenceid).HasColumnName("NEWRESIDENCEID");

                entity.Property(e => e.Residenceid).HasColumnName("RESIDENCEID");

                entity.Property(e => e.Roomno)
                    .HasMaxLength(10)
                    .HasColumnName("ROOMNO");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");
            });

            modelBuilder.Entity<DelStudentregistered2All>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DEL_STUDENTREGISTERED2_ALL");

                entity.Property(e => e.Amountpaidsem).HasColumnName("AMOUNTPAIDSEM");

                entity.Property(e => e.Iscleared).HasColumnName("ISCLEARED");

                entity.Property(e => e.Iscourseregistered).HasColumnName("ISCOURSEREGISTERED");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.StudentBill4Acadyear).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.StudentSemFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<DelStudentregisteredWhileowing>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DEL_STUDENTREGISTERED_WHILEOWING");

                entity.Property(e => e.Amountpaidsem).HasColumnName("AMOUNTPAIDSEM");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.StudentBill4Acadyear).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.StudentSemFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<DelStudentregisteredWhileowing2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DEL_STUDENTREGISTERED_WHILEOWING2");

                entity.Property(e => e.Amountpaidsem).HasColumnName("AMOUNTPAIDSEM");

                entity.Property(e => e.Iscleared).HasColumnName("ISCLEARED");

                entity.Property(e => e.Iscourseregistered).HasColumnName("ISCOURSEREGISTERED");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.StudentBill4Acadyear).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.StudentSemFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<DelStudentregisteredWhileowingAcadrecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DEL_STUDENTREGISTERED_WHILEOWING_ACADRECORDS");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadrank).HasColumnName("ACADRANK");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.App)
                    .HasMaxLength(25)
                    .HasColumnName("APP");

                entity.Property(e => e.Appversion).HasColumnName("APPVERSION");

                entity.Property(e => e.Camark).HasColumnName("CAMARK");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursecode2)
                    .HasMaxLength(50)
                    .HasColumnName("COURSECODE2");

                entity.Property(e => e.Coursename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Coursestatusid).HasColumnName("COURSESTATUSID");

                entity.Property(e => e.Coursetypeid).HasColumnName("COURSETYPEID");

                entity.Property(e => e.Credit).HasColumnName("CREDIT");

                entity.Property(e => e.Electivesetid).HasColumnName("ELECTIVESETID");

                entity.Property(e => e.Endsemmark).HasColumnName("ENDSEMMARK");

                entity.Property(e => e.Examcentreid).HasColumnName("EXAMCENTREID");

                entity.Property(e => e.Grade)
                    .HasMaxLength(2)
                    .HasColumnName("GRADE");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Iscalc).HasColumnName("ISCALC");

                entity.Property(e => e.Isprevioustrail).HasColumnName("ISPREVIOUSTRAIL");

                entity.Property(e => e.Istrail).HasColumnName("ISTRAIL");

                entity.Property(e => e.Numeq).HasColumnName("NUMEQ");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Registeredonline).HasColumnName("REGISTEREDONLINE");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Sourcerowid).HasColumnName("SOURCEROWID");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Timeupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEUPDATED");

                entity.Property(e => e.Totalmark).HasColumnName("TOTALMARK");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(100)
                    .HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<DelStudentregisteredWhileowingAcadrecords2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DEL_STUDENTREGISTERED_WHILEOWING_ACADRECORDS2");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadrank).HasColumnName("ACADRANK");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.App)
                    .HasMaxLength(25)
                    .HasColumnName("APP");

                entity.Property(e => e.Appversion).HasColumnName("APPVERSION");

                entity.Property(e => e.Camark).HasColumnName("CAMARK");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursecode2)
                    .HasMaxLength(50)
                    .HasColumnName("COURSECODE2");

                entity.Property(e => e.Coursename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Coursestatusid).HasColumnName("COURSESTATUSID");

                entity.Property(e => e.Coursetypeid).HasColumnName("COURSETYPEID");

                entity.Property(e => e.Credit).HasColumnName("CREDIT");

                entity.Property(e => e.Electivesetid).HasColumnName("ELECTIVESETID");

                entity.Property(e => e.Endsemmark).HasColumnName("ENDSEMMARK");

                entity.Property(e => e.Examcentreid).HasColumnName("EXAMCENTREID");

                entity.Property(e => e.Grade)
                    .HasMaxLength(2)
                    .HasColumnName("GRADE");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Iscalc).HasColumnName("ISCALC");

                entity.Property(e => e.Isprevioustrail).HasColumnName("ISPREVIOUSTRAIL");

                entity.Property(e => e.Istrail).HasColumnName("ISTRAIL");

                entity.Property(e => e.Numeq).HasColumnName("NUMEQ");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Registeredonline).HasColumnName("REGISTEREDONLINE");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Sourcerowid).HasColumnName("SOURCEROWID");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Timeupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEUPDATED");

                entity.Property(e => e.Totalmark).HasColumnName("TOTALMARK");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(100)
                    .HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<DelStudentregisteredWhileowingMsg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DEL_STUDENTREGISTERED_WHILEOWING_MSG");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(100)
                    .HasColumnName("MOBILE");

                entity.Property(e => e.Msg)
                    .IsRequired()
                    .HasMaxLength(158)
                    .IsUnicode(false)
                    .HasColumnName("MSG");

                entity.Property(e => e.Othername)
                    .HasMaxLength(50)
                    .HasColumnName("OTHERNAME");

                entity.Property(e => e.Primarymobile)
                    .HasMaxLength(20)
                    .HasColumnName("PRIMARYMOBILE");

                entity.Property(e => e.Schoolmobile)
                    .HasMaxLength(20)
                    .HasColumnName("SCHOOLMOBILE");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("SURNAME");
            });

            modelBuilder.Entity<DelStudentregisteredWhileowingMsg2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DEL_STUDENTREGISTERED_WHILEOWING_MSG2");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(100)
                    .HasColumnName("MOBILE");

                entity.Property(e => e.Msg)
                    .IsRequired()
                    .HasMaxLength(158)
                    .IsUnicode(false)
                    .HasColumnName("MSG");

                entity.Property(e => e.Othername)
                    .HasMaxLength(50)
                    .HasColumnName("OTHERNAME");

                entity.Property(e => e.Primarymobile)
                    .HasMaxLength(4000)
                    .HasColumnName("PRIMARYMOBILE");

                entity.Property(e => e.Schoolmobile)
                    .HasMaxLength(4000)
                    .HasColumnName("SCHOOLMOBILE");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("SURNAME");
            });

            modelBuilder.Entity<DelStudentregisteredWhileowingMsgBelow10>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DEL_STUDENTREGISTERED_WHILEOWING_MSG_BELOW10");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(100)
                    .HasColumnName("MOBILE");

                entity.Property(e => e.Msg)
                    .IsRequired()
                    .HasMaxLength(158)
                    .IsUnicode(false)
                    .HasColumnName("MSG");

                entity.Property(e => e.Othername)
                    .HasMaxLength(50)
                    .HasColumnName("OTHERNAME");

                entity.Property(e => e.Primarymobile)
                    .HasMaxLength(4000)
                    .HasColumnName("PRIMARYMOBILE");

                entity.Property(e => e.Schoolmobile)
                    .HasMaxLength(4000)
                    .HasColumnName("SCHOOLMOBILE");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("SURNAME");
            });

            modelBuilder.Entity<DelStudentregisteredWhileowingMsgWithcheck>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DEL_STUDENTREGISTERED_WHILEOWING_MSG_WITHCHECK");

                entity.Property(e => e.Amountpaidsem).HasColumnName("AMOUNTPAIDSEM");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Resultmessage).HasColumnName("RESULTMESSAGE");

                entity.Property(e => e.StudentBill4Acadyear).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.StudentSemFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<DeleteTempSpecialgraduation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DELETE_TEMP_SPECIALGRADUATION");

                entity.Property(e => e.StudentId)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Deleteme>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DELETEME");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<Deleteme2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("deleteme2");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(255)
                    .HasColumnName("MOBILE");

                entity.Property(e => e.OthernameS)
                    .HasMaxLength(255)
                    .HasColumnName("Othername(s)");

                entity.Property(e => e.Programme).HasMaxLength(255);

                entity.Property(e => e.Sn).HasColumnName("SN");

                entity.Property(e => e.Stream)
                    .HasMaxLength(255)
                    .HasColumnName("STREAM");

                entity.Property(e => e.StudentId)
                    .HasMaxLength(255)
                    .HasColumnName("Student ID");

                entity.Property(e => e.Surname).HasMaxLength(255);

                entity.Property(e => e.Year).HasColumnName("YEAR");
            });

            modelBuilder.Entity<Delmary>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("delmary");

                entity.Property(e => e.StudentId)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Delmary2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("delmary2");

                entity.Property(e => e.EmailAddress).HasMaxLength(200);

                entity.Property(e => e.SchoolEmail)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Delmastercard>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DELMASTERCARD");

                entity.Property(e => e.Cohort)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("COHORT");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Sn).HasColumnName("SN");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<Delme>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DELME");

                entity.Property(e => e.Groupcode).HasColumnName("GROUPCODE");

                entity.Property(e => e.Indexno)
                    .HasMaxLength(50)
                    .HasColumnName("INDEXNO");

                entity.Property(e => e.Iscourseregistered).HasColumnName("ISCOURSEREGISTERED");

                entity.Property(e => e.Isinsemmidsem).HasColumnName("ISINSEMMIDSEM");

                entity.Property(e => e.Isverifiedmidsemat).HasColumnName("ISVERIFIEDMIDSEMAT");

                entity.Property(e => e.Isverifiedmidsemby)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ISVERIFIEDMIDSEMBY");

                entity.Property(e => e.Othername)
                    .HasMaxLength(50)
                    .HasColumnName("OTHERNAME");

                entity.Property(e => e.Programmestream)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("PROGRAMMESTREAM");

                entity.Property(e => e.Sortno1).HasColumnName("SORTNO1");

                entity.Property(e => e.Sortno2).HasColumnName("SORTNO2");

                entity.Property(e => e.Sortno3).HasColumnName("SORTNO3");

                entity.Property(e => e.Sortno4).HasColumnName("SORTNO4");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("SURNAME");

                entity.Property(e => e.Tag)
                    .HasMaxLength(30)
                    .HasColumnName("TAG");
            });

            modelBuilder.Entity<Delmegrad>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DELMEGRAD");

                entity.Property(e => e.Approvedby)
                    .HasMaxLength(100)
                    .HasColumnName("APPROVEDBY");

                entity.Property(e => e.Awardclassid).HasColumnName("AWARDCLASSID");

                entity.Property(e => e.Awardclassname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("AWARDCLASSNAME");

                entity.Property(e => e.Awardclassrank).HasColumnName("AWARDCLASSRANK");

                entity.Property(e => e.Batchid).HasColumnName("BATCHID");

                entity.Property(e => e.Campusid).HasColumnName("CAMPUSID");

                entity.Property(e => e.Campusname)
                    .HasMaxLength(100)
                    .HasColumnName("CAMPUSNAME");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Cwa)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("CWA");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Departmentname)
                    .HasMaxLength(100)
                    .HasColumnName("DEPARTMENTNAME");

                entity.Property(e => e.Effectivedate)
                    .HasColumnType("date")
                    .HasColumnName("EFFECTIVEDATE");

                entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");

                entity.Property(e => e.Graduationstreamid).HasColumnName("GRADUATIONSTREAMID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Indexno)
                    .HasMaxLength(20)
                    .HasColumnName("INDEXNO");

                entity.Property(e => e.Insertedby)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Isapproved).HasColumnName("ISAPPROVED");

                entity.Property(e => e.Isreviewed).HasColumnName("ISREVIEWED");

                entity.Property(e => e.Lastactiontaken)
                    .HasMaxLength(1)
                    .HasColumnName("LASTACTIONTAKEN");

                entity.Property(e => e.Lastactiontime)
                    .HasColumnType("datetime")
                    .HasColumnName("LASTACTIONTIME");

                entity.Property(e => e.Lastactionuser)
                    .HasMaxLength(100)
                    .HasColumnName("LASTACTIONUSER");

                entity.Property(e => e.Longprogrammename)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("LONGPROGRAMMENAME");

                entity.Property(e => e.Optionid).HasColumnName("OPTIONID");

                entity.Property(e => e.Programmeaward)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("PROGRAMMEAWARD");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Reviewedby)
                    .HasMaxLength(100)
                    .HasColumnName("REVIEWEDBY");

                entity.Property(e => e.Shortprogrammename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("SHORTPROGRAMMENAME");

                entity.Property(e => e.Specialization)
                    .HasMaxLength(100)
                    .HasColumnName("SPECIALIZATION");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeapproved)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEAPPROVED");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Timereviewed)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEREVIEWED");
            });

            modelBuilder.Entity<DelstudentsWithcwa20212>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DELSTUDENTS_WITHCWA2021_2");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Cwa).HasColumnName("CWA");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<DelstudentsWithtrails20212>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DELSTUDENTS_WITHTRAILS2021_2");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadlevelidtrail).HasColumnName("ACADLEVELIDTRAIL");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Acadyeartrail).HasColumnName("ACADYEARTRAIL");

                entity.Property(e => e.Coursecode)
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursename)
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Coursestatusid).HasColumnName("COURSESTATUSID");

                entity.Property(e => e.Credit).HasColumnName("CREDIT");

                entity.Property(e => e.Grade)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GRADE");

                entity.Property(e => e.Numeq).HasColumnName("NUMEQ");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Semtrail).HasColumnName("SEMTRAIL");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Totalmark)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TOTALMARK");
            });

            modelBuilder.Entity<DelstudentsWithtrails20212Cwa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DELSTUDENTS_WITHTRAILS2021_2_CWA");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadlevelidtrail).HasColumnName("ACADLEVELIDTRAIL");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Acadyeartrail).HasColumnName("ACADYEARTRAIL");

                entity.Property(e => e.Coursecode)
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursename)
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Coursestatusid).HasColumnName("COURSESTATUSID");

                entity.Property(e => e.Credit).HasColumnName("CREDIT");

                entity.Property(e => e.Grade)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GRADE");

                entity.Property(e => e.Numeq).HasColumnName("NUMEQ");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Semtrail).HasColumnName("SEMTRAIL");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Totalmark)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TOTALMARK");
            });

            modelBuilder.Entity<DelstudentsWithtrails20212CwaLessthan3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DELSTUDENTS_WITHTRAILS2021_2_CWA_LESSTHAN3");

                entity.Property(e => e.Counttrails).HasColumnName("COUNTTRAILS");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<DelstudentsWithtrails20212CwaLessthan3CwaBelowMin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DELSTUDENTS_WITHTRAILS2021_2_CWA_LESSTHAN3_CWA_BELOW_MIN");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Counttrails).HasColumnName("COUNTTRAILS");

                entity.Property(e => e.Cwa).HasColumnName("CWA");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<DelstudentsWithtrails20212CwaLessthan3CwaBelowMinRegistered>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DELSTUDENTS_WITHTRAILS2021_2_CWA_LESSTHAN3_CWA_BELOW_MIN_REGISTERED");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Autopromoted).HasColumnName("AUTOPROMOTED");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Iscurrent).HasColumnName("ISCURRENT");

                entity.Property(e => e.Metadata)
                    .HasMaxLength(1000)
                    .HasColumnName("METADATA");

                entity.Property(e => e.Preregistrationstatus).HasColumnName("PREREGISTRATIONSTATUS");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Sourcerowguid).HasColumnName("SOURCEROWGUID");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Yr2).HasColumnName("YR2");
            });

            modelBuilder.Entity<DelstudentsWithtrails20212Greaterthan2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DELSTUDENTS_WITHTRAILS2021_2_GREATERTHAN2");

                entity.Property(e => e.Counttrails).HasColumnName("COUNTTRAILS");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<DelstudentsWithtrails20212Greaterthan2Registered>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DELSTUDENTS_WITHTRAILS2021_2_GREATERTHAN2_REGISTERED");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Autopromoted).HasColumnName("AUTOPROMOTED");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Iscurrent).HasColumnName("ISCURRENT");

                entity.Property(e => e.Metadata)
                    .HasMaxLength(1000)
                    .HasColumnName("METADATA");

                entity.Property(e => e.Preregistrationstatus).HasColumnName("PREREGISTRATIONSTATUS");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Sourcerowguid).HasColumnName("SOURCEROWGUID");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Yr2).HasColumnName("YR2");
            });

            modelBuilder.Entity<Denomination>(entity =>
            {
                entity.ToTable("DENOMINATION");

                entity.Property(e => e.Denominationid).HasColumnName("DENOMINATIONID");

                entity.Property(e => e.Ischristian)
                    .HasColumnName("ISCHRISTIAN")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.Shortname)
                    .HasMaxLength(10)
                    .HasColumnName("SHORTNAME");

                entity.Property(e => e.Sortcol)
                    .HasColumnName("SORTCOL")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.Departmentid)
                    .IsClustered(false);

                entity.ToTable("DEPARTMENT");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .HasColumnName("FAX");

                entity.Property(e => e.Head)
                    .HasMaxLength(100)
                    .HasColumnName("HEAD");

                entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Phoneext)
                    .HasMaxLength(3)
                    .HasColumnName("PHONEEXT");

                entity.Property(e => e.Website)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("WEBSITE");

                entity.HasOne(d => d.College)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.Collegeid)
                    .HasConstraintName("COLLEGEDEPARTMENT");

                entity.HasOne(d => d.Faculty)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.Facultyid)
                    .HasConstraintName("FACULTYDEPARTMENT");
            });

            modelBuilder.Entity<Department1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Department", "tt");

                entity.Property(e => e.DepartmentId).ValueGeneratedOnAdd();

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<Disability>(entity =>
            {
                entity.HasKey(e => e.Disabilityid)
                    .IsClustered(false);

                entity.ToTable("DISABILITY");

                entity.Property(e => e.Disabilityid).HasColumnName("DISABILITYID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<Duration>(entity =>
            {
                entity.ToTable("DURATION");

                entity.Property(e => e.Durationid)
                    .ValueGeneratedNever()
                    .HasColumnName("DURATIONID");

                entity.Property(e => e.Durationname)
                    .HasMaxLength(50)
                    .HasColumnName("DURATIONNAME");

                entity.Property(e => e.Finalacadlevelid).HasColumnName("FINALACADLEVELID");

                entity.Property(e => e.Finalsem).HasColumnName("FINALSEM");
            });

            modelBuilder.Entity<Ebhr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EBHR");

                entity.Property(e => e.Bleeding).HasColumnName("BLEEDING");

                entity.Property(e => e.Bodyache).HasColumnName("BODYACHE");

                entity.Property(e => e.Contactwithantelope).HasColumnName("CONTACTWITHANTELOPE");

                entity.Property(e => e.Contactwithbat).HasColumnName("CONTACTWITHBAT");

                entity.Property(e => e.Contactwithillperson).HasColumnName("CONTACTWITHILLPERSON");

                entity.Property(e => e.Contactwithmonkey).HasColumnName("CONTACTWITHMONKEY");

                entity.Property(e => e.Datetimeupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("DATETIMEUPDATED");

                entity.Property(e => e.Diarrhoea).HasColumnName("DIARRHOEA");

                entity.Property(e => e.Headache).HasColumnName("HEADACHE");

                entity.Property(e => e.Livedortravelledout).HasColumnName("LIVEDORTRAVELLEDOUT");

                entity.Property(e => e.Livedortravelledoutlocation)
                    .HasMaxLength(255)
                    .HasColumnName("LIVEDORTRAVELLEDOUTLOCATION");

                entity.Property(e => e.Placeofresidence)
                    .HasMaxLength(255)
                    .HasColumnName("PLACEOFRESIDENCE");

                entity.Property(e => e.Reddenedeye).HasColumnName("REDDENEDEYE");

                entity.Property(e => e.Redishpeelyrash).HasColumnName("REDISHPEELYRASH");

                entity.Property(e => e.Sorethroat).HasColumnName("SORETHROAT");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Townofresidence)
                    .HasMaxLength(255)
                    .HasColumnName("TOWNOFRESIDENCE");

                entity.Property(e => e.Vomiting).HasColumnName("VOMITING");
            });

            modelBuilder.Entity<Ebolaassessment>(entity =>
            {
                entity.HasKey(e => e.Studentid)
                    .HasName("PK__EBOLAASS__495196F0E5205E76");

                entity.ToTable("EBOLAASSESSMENT");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Bleeding).HasColumnName("BLEEDING");

                entity.Property(e => e.Bodyache).HasColumnName("BODYACHE");

                entity.Property(e => e.Contactwithantelope).HasColumnName("CONTACTWITHANTELOPE");

                entity.Property(e => e.Contactwithbat).HasColumnName("CONTACTWITHBAT");

                entity.Property(e => e.Contactwithillperson).HasColumnName("CONTACTWITHILLPERSON");

                entity.Property(e => e.Contactwithillpersontime)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CONTACTWITHILLPERSONTIME");

                entity.Property(e => e.Contactwithmonkey).HasColumnName("CONTACTWITHMONKEY");

                entity.Property(e => e.Datetimeupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("DATETIMEUPDATED");

                entity.Property(e => e.Diarrhoea).HasColumnName("DIARRHOEA");

                entity.Property(e => e.Fever).HasColumnName("FEVER");

                entity.Property(e => e.Headache).HasColumnName("HEADACHE");

                entity.Property(e => e.Livedortravelledout).HasColumnName("LIVEDORTRAVELLEDOUT");

                entity.Property(e => e.Livedortravelledoutlocation)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("LIVEDORTRAVELLEDOUTLOCATION");

                entity.Property(e => e.Placeofresidence)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PLACEOFRESIDENCE");

                entity.Property(e => e.Reddenedeye).HasColumnName("REDDENEDEYE");

                entity.Property(e => e.Redishpeelyrash).HasColumnName("REDISHPEELYRASH");

                entity.Property(e => e.Rescountryid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("RESCOUNTRYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Sorethroat).HasColumnName("SORETHROAT");

                entity.Property(e => e.Townofresidence)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("TOWNOFRESIDENCE");

                entity.Property(e => e.Vomiting).HasColumnName("VOMITING");

                entity.HasOne(d => d.Student)
                    .WithOne(p => p.Ebolaassessment)
                    .HasForeignKey<Ebolaassessment>(d => d.Studentid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EBOLAASSESSMENT_STUDENT");
            });

            modelBuilder.Entity<Electiveset>(entity =>
            {
                entity.HasKey(e => e.Electivesetid)
                    .IsClustered(false);

                entity.ToTable("ELECTIVESET");

                entity.Property(e => e.Electivesetid)
                    .ValueGeneratedNever()
                    .HasColumnName("ELECTIVESETID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<Examcentre>(entity =>
            {
                entity.HasKey(e => e.Examcentreid)
                    .IsClustered(false);

                entity.ToTable("EXAMCENTRE");

                entity.Property(e => e.Examcentreid).HasColumnName("EXAMCENTREID");

                entity.Property(e => e.Centrename)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CENTRENAME");

                entity.Property(e => e.Isactive)
                    .IsRequired()
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Examinvigilator>(entity =>
            {
                entity.HasKey(e => new { e.Coursecode, e.Invigilatorid, e.Examperiodid, e.Yr, e.Programmestreamid, e.Acadyear, e.Sem })
                    .IsClustered(false);

                entity.ToTable("EXAMINVIGILATOR");

                entity.Property(e => e.Coursecode)
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Invigilatorid).HasColumnName("INVIGILATORID");

                entity.Property(e => e.Examperiodid).HasColumnName("EXAMPERIODID");

                entity.Property(e => e.Yr).HasColumnName("YR");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.HasOne(d => d.Invigilator)
                    .WithMany(p => p.Examinvigilators)
                    .HasForeignKey(d => d.Invigilatorid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("INVIGILATOREXAMINVIGILATOR");

                entity.HasOne(d => d.Examtimetabledetail)
                    .WithMany(p => p.Examinvigilators)
                    .HasForeignKey(d => new { d.Coursecode, d.Examperiodid, d.Yr, d.Programmestreamid, d.Acadyear, d.Sem })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("EXAMTIMETABLEDETAILEXAMINVIGILATOR");
            });

            modelBuilder.Entity<Examperiod>(entity =>
            {
                entity.HasKey(e => e.Examperiodid)
                    .IsClustered(false);

                entity.ToTable("EXAMPERIOD");

                entity.Property(e => e.Examperiodid)
                    .ValueGeneratedNever()
                    .HasColumnName("EXAMPERIODID");

                entity.Property(e => e.Daysessionid).HasColumnName("DAYSESSIONID");

                entity.Property(e => e.Endtime).HasColumnName("ENDTIME");

                entity.Property(e => e.Starttime).HasColumnName("STARTTIME");

                entity.HasOne(d => d.Daysession)
                    .WithMany(p => p.Examperiods)
                    .HasForeignKey(d => d.Daysessionid)
                    .HasConstraintName("DAYSESSIONEXAMPERIOD");
            });

            modelBuilder.Entity<Examtimetable>(entity =>
            {
                entity.HasKey(e => new { e.Coursecode, e.Examperiodid, e.Yr, e.Programmestreamid, e.Acadyear, e.Sem })
                    .IsClustered(false);

                entity.ToTable("EXAMTIMETABLE");

                entity.Property(e => e.Coursecode)
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Examperiodid).HasColumnName("EXAMPERIODID");

                entity.Property(e => e.Yr).HasColumnName("YR");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Examdate)
                    .HasColumnType("date")
                    .HasColumnName("EXAMDATE");

                entity.HasOne(d => d.Examperiod)
                    .WithMany(p => p.Examtimetables)
                    .HasForeignKey(d => d.Examperiodid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("EXAMPERIODEXAMTIMETABLE");
            });

            modelBuilder.Entity<Examtimetabledetail>(entity =>
            {
                entity.HasKey(e => new { e.Coursecode, e.Examperiodid, e.Yr, e.Programmestreamid, e.Acadyear, e.Sem })
                    .IsClustered(false);

                entity.ToTable("EXAMTIMETABLEDETAIL");

                entity.Property(e => e.Coursecode)
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Examperiodid).HasColumnName("EXAMPERIODID");

                entity.Property(e => e.Yr).HasColumnName("YR");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Classroomid).HasColumnName("CLASSROOMID");

                entity.Property(e => e.Numberofstudents).HasColumnName("NUMBEROFSTUDENTS");

                entity.Property(e => e.Numbertoprint).HasColumnName("NUMBERTOPRINT");

                entity.HasOne(d => d.Classroom)
                    .WithMany(p => p.Examtimetabledetails)
                    .HasForeignKey(d => d.Classroomid)
                    .HasConstraintName("CLASSROOMEXAMTIMETABLEDETAIL");

                entity.HasOne(d => d.Examtimetable)
                    .WithOne(p => p.Examtimetabledetail)
                    .HasForeignKey<Examtimetabledetail>(d => new { d.Coursecode, d.Examperiodid, d.Yr, d.Programmestreamid, d.Acadyear, d.Sem })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("EXAMTIMETABLEEXAMTIMETABLEDETAIL");
            });

            modelBuilder.Entity<Examverification>(entity =>
            {
                entity.ToTable("EXAMVERIFICATION");

                entity.HasIndex(e => new { e.Studentid, e.Acadyear, e.Sem, e.Coursecode }, "IX_EXAMVERIFICATION1");

                entity.HasIndex(e => new { e.Studentid, e.Acadyear, e.Sem, e.Coursecode }, "UX_EXAMVERIFICATION_STUDENTACADYEARSEMCOURSE")
                    .IsUnique();

                entity.Property(e => e.Examverificationid).HasColumnName("EXAMVERIFICATIONID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Isinsemendsem).HasColumnName("ISINSEMENDSEM");

                entity.Property(e => e.Isinsemmidsem).HasColumnName("ISINSEMMIDSEM");

                entity.Property(e => e.Isverifiedendsem).HasColumnName("ISVERIFIEDENDSEM");

                entity.Property(e => e.Isverifiedendsemat).HasColumnName("ISVERIFIEDENDSEMAT");

                entity.Property(e => e.Isverifiedendsemby)
                    .HasMaxLength(25)
                    .HasColumnName("ISVERIFIEDENDSEMBY");

                entity.Property(e => e.Isverifiedendsemmanually).HasColumnName("ISVERIFIEDENDSEMMANUALLY");

                entity.Property(e => e.Isverifiedmidsem).HasColumnName("ISVERIFIEDMIDSEM");

                entity.Property(e => e.Isverifiedmidsemat).HasColumnName("ISVERIFIEDMIDSEMAT");

                entity.Property(e => e.Isverifiedmidsemby)
                    .HasMaxLength(25)
                    .HasColumnName("ISVERIFIEDMIDSEMBY");

                entity.Property(e => e.Isverifiedmidsemmanually).HasColumnName("ISVERIFIEDMIDSEMMANUALLY");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.HasOne(d => d.CoursecodeNavigation)
                    .WithMany(p => p.Examverifications)
                    .HasForeignKey(d => d.Coursecode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EXAMVERIFICATION_MASTERCOURSE");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Examverifications)
                    .HasForeignKey(d => d.Studentid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EXAMVERIFICATION_STUDENT");
            });

            modelBuilder.Entity<ExamverificationDel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("examverification_del");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Examverificationid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("EXAMVERIFICATIONID");

                entity.Property(e => e.Isinsemendsem).HasColumnName("ISINSEMENDSEM");

                entity.Property(e => e.Isinsemmidsem).HasColumnName("ISINSEMMIDSEM");

                entity.Property(e => e.Isverifiedendsem).HasColumnName("ISVERIFIEDENDSEM");

                entity.Property(e => e.Isverifiedendsemat).HasColumnName("ISVERIFIEDENDSEMAT");

                entity.Property(e => e.Isverifiedendsemby)
                    .HasMaxLength(25)
                    .HasColumnName("ISVERIFIEDENDSEMBY");

                entity.Property(e => e.Isverifiedendsemmanually).HasColumnName("ISVERIFIEDENDSEMMANUALLY");

                entity.Property(e => e.Isverifiedmidsem).HasColumnName("ISVERIFIEDMIDSEM");

                entity.Property(e => e.Isverifiedmidsemat).HasColumnName("ISVERIFIEDMIDSEMAT");

                entity.Property(e => e.Isverifiedmidsemby)
                    .HasMaxLength(25)
                    .HasColumnName("ISVERIFIEDMIDSEMBY");

                entity.Property(e => e.Isverifiedmidsemmanually).HasColumnName("ISVERIFIEDMIDSEMMANUALLY");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<ExamverificationbackupDelete>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EXAMVERIFICATIONBACKUP_DELETE");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Examverificationid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("EXAMVERIFICATIONID");

                entity.Property(e => e.Isinsemendsem).HasColumnName("ISINSEMENDSEM");

                entity.Property(e => e.Isinsemmidsem).HasColumnName("ISINSEMMIDSEM");

                entity.Property(e => e.Isverifiedendsem).HasColumnName("ISVERIFIEDENDSEM");

                entity.Property(e => e.Isverifiedendsemat).HasColumnName("ISVERIFIEDENDSEMAT");

                entity.Property(e => e.Isverifiedendsemby)
                    .HasMaxLength(25)
                    .HasColumnName("ISVERIFIEDENDSEMBY");

                entity.Property(e => e.Isverifiedmidsem).HasColumnName("ISVERIFIEDMIDSEM");

                entity.Property(e => e.Isverifiedmidsemat).HasColumnName("ISVERIFIEDMIDSEMAT");

                entity.Property(e => e.Isverifiedmidsemby)
                    .HasMaxLength(25)
                    .HasColumnName("ISVERIFIEDMIDSEMBY");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<Examverificationerror>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EXAMVERIFICATIONERROR");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Examverificationid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("EXAMVERIFICATIONID");

                entity.Property(e => e.Isinsemendsem).HasColumnName("ISINSEMENDSEM");

                entity.Property(e => e.Isinsemmidsem).HasColumnName("ISINSEMMIDSEM");

                entity.Property(e => e.Isverifiedendsem).HasColumnName("ISVERIFIEDENDSEM");

                entity.Property(e => e.Isverifiedendsemat).HasColumnName("ISVERIFIEDENDSEMAT");

                entity.Property(e => e.Isverifiedendsemby)
                    .HasMaxLength(25)
                    .HasColumnName("ISVERIFIEDENDSEMBY");

                entity.Property(e => e.Isverifiedmidsem).HasColumnName("ISVERIFIEDMIDSEM");

                entity.Property(e => e.Isverifiedmidsemat).HasColumnName("ISVERIFIEDMIDSEMAT");

                entity.Property(e => e.Isverifiedmidsemby)
                    .HasMaxLength(25)
                    .HasColumnName("ISVERIFIEDMIDSEMBY");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<Exchangerate>(entity =>
            {
                entity.HasKey(e => new { e.Currencyid, e.Tdate })
                    .IsClustered(false);

                entity.ToTable("EXCHANGERATE");

                entity.Property(e => e.Currencyid)
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Tdate)
                    .HasColumnType("date")
                    .HasColumnName("TDATE");

                entity.Property(e => e.Xrate).HasColumnName("XRATE");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Exchangerates)
                    .HasForeignKey(d => d.Currencyid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CURRENCYEXCHANGERATE");
            });

            modelBuilder.Entity<Faculty>(entity =>
            {
                entity.HasKey(e => e.Facultyid)
                    .IsClustered(false);

                entity.ToTable("FACULTY");

                entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Facultycode)
                    .HasMaxLength(10)
                    .HasColumnName("FACULTYCODE");

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .HasColumnName("FAX");

                entity.Property(e => e.Head)
                    .HasMaxLength(100)
                    .HasColumnName("HEAD");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Phoneext)
                    .HasMaxLength(3)
                    .HasColumnName("PHONEEXT");

                entity.Property(e => e.Website)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("WEBSITE");

                entity.HasOne(d => d.College)
                    .WithMany(p => p.Faculties)
                    .HasForeignKey(d => d.Collegeid)
                    .HasConstraintName("COLLEGEFACULTY");
            });

            modelBuilder.Entity<Faculty1>(entity =>
            {
                entity.HasKey(e => e.FacultyId)
                    .IsClustered(false);

                entity.ToTable("Faculty", "tt");

                entity.Property(e => e.FacultyName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Feature>(entity =>
            {
                entity.HasKey(e => e.FeatureId)
                    .IsClustered(false);

                entity.ToTable("Feature", "tt");

                entity.Property(e => e.FeatureName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Feecategory>(entity =>
            {
                entity.HasKey(e => e.Feecategoryid)
                    .IsClustered(false);

                entity.ToTable("FEECATEGORY");

                entity.Property(e => e.Feecategoryid).HasColumnName("FEECATEGORYID");

                entity.Property(e => e.Currencyid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Feeclassificationid).HasColumnName("FEECLASSIFICATIONID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.Isactive)
                    .IsRequired()
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.Nextfeecategoryid).HasColumnName("NEXTFEECATEGORYID");

                entity.Property(e => e.Studentcategoryid).HasColumnName("STUDENTCATEGORYID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Feecategories)
                    .HasForeignKey(d => d.Currencyid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FEECATEGORY_CURRENCY");
            });

            modelBuilder.Entity<Feecategorymap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FEECATEGORYMAP");

                entity.Property(e => e.Feecategoryid).HasColumnName("FEECATEGORYID");

                entity.Property(e => e.Isfeepaying).HasColumnName("ISFEEPAYING");

                entity.Property(e => e.Isforeigner).HasColumnName("ISFOREIGNER");

                entity.Property(e => e.Isfreshman).HasColumnName("ISFRESHMAN");

                entity.Property(e => e.Isresidential).HasColumnName("ISRESIDENTIAL");
            });

            modelBuilder.Entity<Feeclassification>(entity =>
            {
                entity.HasKey(e => e.Feeclassificationid)
                    .IsClustered(false);

                entity.ToTable("FEECLASSIFICATION");

                entity.Property(e => e.Feeclassificationid)
                    .ValueGeneratedNever()
                    .HasColumnName("FEECLASSIFICATIONID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.Isactive)
                    .IsRequired()
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.ToTable("FEEDBACK");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.App)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("APP");

                entity.Property(e => e.Datetimeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("DATETIMEINSERTED");

                entity.Property(e => e.Feedbackmessage)
                    .IsRequired()
                    .HasColumnName("FEEDBACKMESSAGE");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<Feegroup>(entity =>
            {
                entity.ToTable("FEEGROUP");

                entity.Property(e => e.Feegroupid)
                    .ValueGeneratedNever()
                    .HasColumnName("FEEGROUPID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<Feeitem>(entity =>
            {
                entity.HasKey(e => e.Feeitemid)
                    .IsClustered(false);

                entity.ToTable("FEEITEM");

                entity.Property(e => e.Feeitemid)
                    .ValueGeneratedNever()
                    .HasColumnName("FEEITEMID");

                entity.Property(e => e.Feeitemcode)
                    .HasMaxLength(20)
                    .HasColumnName("FEEITEMCODE");

                entity.Property(e => e.Feeitemname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("FEEITEMNAME");
            });

            modelBuilder.Entity<Feeitembank>(entity =>
            {
                entity.HasKey(e => new { e.Feeitemid, e.Bankid })
                    .IsClustered(false);

                entity.ToTable("FEEITEMBANK");

                entity.Property(e => e.Feeitemid).HasColumnName("FEEITEMID");

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");
            });

            modelBuilder.Entity<Feeitembankaccount>(entity =>
            {
                entity.HasKey(e => new { e.Feeitemid, e.Bankid })
                    .IsClustered(false);

                entity.ToTable("FEEITEMBANKACCOUNT");

                entity.Property(e => e.Feeitemid).HasColumnName("FEEITEMID");

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.Bankaccountid).HasColumnName("BANKACCOUNTID");

                entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");
            });

            modelBuilder.Entity<Feeitembankaccountresidence>(entity =>
            {
                entity.HasKey(e => new { e.Feeitemid, e.Residenceid, e.Bankid })
                    .IsClustered(false);

                entity.ToTable("FEEITEMBANKACCOUNTRESIDENCE");

                entity.Property(e => e.Feeitemid).HasColumnName("FEEITEMID");

                entity.Property(e => e.Residenceid).HasColumnName("RESIDENCEID");

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.Bankaccountid).HasColumnName("BANKACCOUNTID");

                entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");
            });

            modelBuilder.Entity<Feeitemschedule>(entity =>
            {
                entity.HasKey(e => new { e.Feeitemid, e.Feecategoryid });

                entity.ToTable("FEEITEMSCHEDULE");

                entity.Property(e => e.Feeitemid).HasColumnName("FEEITEMID");

                entity.Property(e => e.Feecategoryid).HasColumnName("FEECATEGORYID");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.Currencyid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Isexactamountrequired).HasColumnName("ISEXACTAMOUNTREQUIRED");

                entity.Property(e => e.Maxamount)
                    .HasColumnType("money")
                    .HasColumnName("MAXAMOUNT");

                entity.Property(e => e.Minamount)
                    .HasColumnType("money")
                    .HasColumnName("MINAMOUNT");
            });

            modelBuilder.Entity<Feelog>(entity =>
            {
                entity.HasKey(e => e.Logid);

                entity.ToTable("FEELOG");

                entity.Property(e => e.Logid).HasColumnName("LOGID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Actiontaken)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACTIONTAKEN")
                    .IsFixedLength(true);

                entity.Property(e => e.Actiontime)
                    .HasColumnType("datetime")
                    .HasColumnName("ACTIONTIME");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Bank)
                    .HasMaxLength(100)
                    .HasColumnName("BANK");

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.Clientnetaddress)
                    .HasMaxLength(100)
                    .HasColumnName("CLIENTNETADDRESS");

                entity.Property(e => e.Currencyid)
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Feecategory)
                    .HasMaxLength(100)
                    .HasColumnName("FEECATEGORY");

                entity.Property(e => e.Feecategoryid).HasColumnName("FEECATEGORYID");

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Paymenttypeid).HasColumnName("PAYMENTTYPEID");

                entity.Property(e => e.Paymenttypeno)
                    .HasMaxLength(50)
                    .HasColumnName("PAYMENTTYPENO");

                entity.Property(e => e.Programmestream)
                    .HasMaxLength(100)
                    .HasColumnName("PROGRAMMESTREAM");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Receiptno)
                    .HasMaxLength(30)
                    .HasColumnName("RECEIPTNO");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Transactiontype)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("TRANSACTIONTYPE");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");

                entity.Property(e => e.Xrate).HasColumnName("XRATE");

                entity.Property(e => e.Yr).HasColumnName("YR");
            });

            modelBuilder.Entity<Feerequirement>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FEEREQUIREMENT");

                entity.Property(e => e.Feegroupid).HasColumnName("FEEGROUPID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Minpercent).HasColumnName("MINPERCENT");
            });

            modelBuilder.Entity<Feeschedule>(entity =>
            {
                entity.HasKey(e => new { e.Programmestreamid, e.Feecategoryid, e.Feetypeid, e.Acadyear, e.Sem, e.Acadlevelid })
                    .IsClustered(false);

                entity.ToTable("FEESCHEDULE");

                entity.HasIndex(e => new { e.Feecategoryid, e.Acadyear, e.Sem }, "IX_FEESCHEDULE1");

                entity.HasIndex(e => new { e.Feecategoryid, e.Acadyear, e.Sem, e.Feetypeid }, "IX_FEESCHEDULE2");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Feecategoryid).HasColumnName("FEECATEGORYID");

                entity.Property(e => e.Feetypeid).HasColumnName("FEETYPEID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.Currencyid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Fractionrequired)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("FRACTIONREQUIRED")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.Iscore).HasColumnName("ISCORE");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Timeupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEUPDATED");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(100)
                    .HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Feeschedules)
                    .HasForeignKey(d => d.Currencyid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CURRENCYFEESCHEDULE");

                entity.HasOne(d => d.Feecategory)
                    .WithMany(p => p.Feeschedules)
                    .HasForeignKey(d => d.Feecategoryid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FEECATEGORYFEESCHEDULE");

                entity.HasOne(d => d.Feetype)
                    .WithMany(p => p.Feeschedules)
                    .HasForeignKey(d => d.Feetypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FEETYPEFEESCHEDULE");

                entity.HasOne(d => d.Programmestream)
                    .WithMany(p => p.Feeschedules)
                    .HasForeignKey(d => d.Programmestreamid)
                    .HasConstraintName("PROGRAMMESTREAMFEESCHEDULE");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.Feeschedules)
                    .HasForeignKey(d => new { d.Acadyear, d.Sem })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SEMESTERFEESCHEDULE");
            });

            modelBuilder.Entity<Feethreshold>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FEETHRESHOLD");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Thresholdpercent).HasColumnName("THRESHOLDPERCENT");

                entity.Property(e => e.Thresholdvalue)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("THRESHOLDVALUE");
            });

            modelBuilder.Entity<Feethresholdprogrammestream>(entity =>
            {
                entity.ToTable("FEETHRESHOLDPROGRAMMESTREAM");

                entity.HasIndex(e => e.Programmestreamid, "IX_FEETHRESHOLDPROGRAMMESTREAM")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Thresholdvalue)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("THRESHOLDVALUE");
            });

            modelBuilder.Entity<Feetype>(entity =>
            {
                entity.HasKey(e => e.Feetypeid)
                    .IsClustered(false);

                entity.ToTable("FEETYPE");

                entity.Property(e => e.Feetypeid).HasColumnName("FEETYPEID");

                entity.Property(e => e.Feegroupid).HasColumnName("FEEGROUPID");

                entity.Property(e => e.Feeitemid).HasColumnName("FEEITEMID");

                entity.Property(e => e.Fractionrequired)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("FRACTIONREQUIRED")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Isactive)
                    .IsRequired()
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Mappedfeetypeid).HasColumnName("MAPPEDFEETYPEID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<Fff>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FFF");

                entity.Property(e => e.Del)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEL");
            });

            modelBuilder.Entity<FloorType>(entity =>
            {
                entity.HasKey(e => e.FloorTypeId)
                    .IsClustered(false);

                entity.ToTable("FloorType", "tt");

                entity.Property(e => e.FloorTypeId).ValueGeneratedNever();

                entity.Property(e => e.FloorTypeName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Gcmuser>(entity =>
            {
                entity.ToTable("GCMUSER");

                entity.HasIndex(e => e.Deviceid, "IX_GCMUSER_DEVICEID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Datetimeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("DATETIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Datetimeupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("DATETIMEUPDATED");

                entity.Property(e => e.Deviceid)
                    .HasMaxLength(50)
                    .HasColumnName("DEVICEID");

                entity.Property(e => e.Gcmregid)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("GCMREGID");

                entity.Property(e => e.Senderid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("SENDERID");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<Gradingsystem>(entity =>
            {
                entity.HasKey(e => e.Gradingid)
                    .IsClustered(false);

                entity.ToTable("GRADINGSYSTEM");

                entity.Property(e => e.Gradingid).HasColumnName("GRADINGID");

                entity.Property(e => e.Gradingsystemtypeid)
                    .HasColumnName("GRADINGSYSTEMTYPEID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.Sortno).HasColumnName("SORTNO");

                entity.HasOne(d => d.Gradingsystemtype)
                    .WithMany(p => p.Gradingsystems)
                    .HasForeignKey(d => d.Gradingsystemtypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GRADINGSYSTEM_GRADINGSYSTEMTYPE");
            });

            modelBuilder.Entity<Gradingsystemclass>(entity =>
            {
                entity.HasKey(e => new { e.Gradingid, e.Lowerlimit })
                    .IsClustered(false);

                entity.ToTable("GRADINGSYSTEMCLASS");

                entity.HasIndex(e => new { e.Gradingid, e.Awardclassid }, "AK_GRADINGSYSTEMCLASSAWARD")
                    .IsUnique();

                entity.HasIndex(e => new { e.Gradingid, e.Lowerlimit }, "AK_GRADINGSYSTEMCLASSLOWERLIMIT")
                    .IsUnique();

                entity.HasIndex(e => new { e.Gradingid, e.Upperlimit }, "AK_GRADINGSYSTEMCLASSUPPERLIMIT")
                    .IsUnique();

                entity.Property(e => e.Gradingid).HasColumnName("GRADINGID");

                entity.Property(e => e.Lowerlimit).HasColumnName("LOWERLIMIT");

                entity.Property(e => e.Award)
                    .HasMaxLength(50)
                    .HasColumnName("AWARD");

                entity.Property(e => e.Awardclassid).HasColumnName("AWARDCLASSID");

                entity.Property(e => e.Awardshortcode)
                    .HasMaxLength(10)
                    .HasColumnName("AWARDSHORTCODE");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Sortno).HasColumnName("SORTNO");

                entity.Property(e => e.Upperlimit).HasColumnName("UPPERLIMIT");

                entity.HasOne(d => d.Awardclass)
                    .WithMany(p => p.Gradingsystemclasses)
                    .HasForeignKey(d => d.Awardclassid)
                    .HasConstraintName("FK_GRADINGSYSTEMCLASS_AWARDCLASS");

                entity.HasOne(d => d.Grading)
                    .WithMany(p => p.Gradingsystemclasses)
                    .HasForeignKey(d => d.Gradingid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("GRADINGSYSTEMGRADINGSYSTEMCLASS");
            });

            modelBuilder.Entity<Gradingsystemnonscoringcourse>(entity =>
            {
                entity.ToTable("GRADINGSYSTEMNONSCORINGCOURSE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Gradingid).HasColumnName("GRADINGID");

                entity.HasOne(d => d.CoursecodeNavigation)
                    .WithMany(p => p.Gradingsystemnonscoringcourses)
                    .HasForeignKey(d => d.Coursecode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GRADINGSYSTEMNONSCORINGCOURSE_MASTERCOURSE");

                entity.HasOne(d => d.Grading)
                    .WithMany(p => p.Gradingsystemnonscoringcourses)
                    .HasForeignKey(d => d.Gradingid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GRADINGSYSTEMNONSCORINGCOURSE_GRADINGSYSTEM");
            });

            modelBuilder.Entity<Gradingsystemscoring>(entity =>
            {
                entity.HasKey(e => new { e.Gradingid, e.Lowerlimit })
                    .IsClustered(false);

                entity.ToTable("GRADINGSYSTEMSCORING");

                entity.HasIndex(e => new { e.Gradingid, e.Grade }, "AK_GRADINGSYSTEMSCORING_GRADE")
                    .IsUnique();

                entity.HasIndex(e => new { e.Gradingid, e.Lowerlimit }, "AK_GRADINGSYSTEMSCORING_LOWERLIMT")
                    .IsUnique();

                entity.HasIndex(e => new { e.Gradingid, e.Upperlimit }, "AK_GRADINGSYSTEMSCORING_UPPERLIMIT")
                    .IsUnique();

                entity.Property(e => e.Gradingid).HasColumnName("GRADINGID");

                entity.Property(e => e.Lowerlimit).HasColumnName("LOWERLIMIT");

                entity.Property(e => e.Grade)
                    .HasMaxLength(2)
                    .HasColumnName("GRADE");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Istrail).HasColumnName("ISTRAIL");

                entity.Property(e => e.Numeq).HasColumnName("NUMEQ");

                entity.Property(e => e.Remark)
                    .HasMaxLength(50)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Upperlimit).HasColumnName("UPPERLIMIT");

                entity.HasOne(d => d.Grading)
                    .WithMany(p => p.Gradingsystemscorings)
                    .HasForeignKey(d => d.Gradingid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("GRADINGSYSTEMGRADINGSYSTEMSCORING");
            });

            modelBuilder.Entity<Gradingsystemscoringexception>(entity =>
            {
                entity.HasKey(e => new { e.Gradingid, e.Coursecode });

                entity.ToTable("GRADINGSYSTEMSCORINGEXCEPTION");

                entity.Property(e => e.Gradingid).HasColumnName("GRADINGID");

                entity.Property(e => e.Coursecode)
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Mappedgradingid).HasColumnName("MAPPEDGRADINGID");

                entity.HasOne(d => d.CoursecodeNavigation)
                    .WithMany(p => p.Gradingsystemscoringexceptions)
                    .HasForeignKey(d => d.Coursecode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MASTERCOURSEGRADINGSYSTEMSCORINGEXCEPTION");

                entity.HasOne(d => d.Grading)
                    .WithMany(p => p.Gradingsystemscoringexceptions)
                    .HasForeignKey(d => d.Gradingid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GRADINGSYSTEMSCORINGEXCEPTION_GRADINGSYSTEM");
            });

            modelBuilder.Entity<Gradingsystemtype>(entity =>
            {
                entity.HasKey(e => e.Gradingsystemtypeid)
                    .IsClustered(false);

                entity.ToTable("GRADINGSYSTEMTYPE");

                entity.Property(e => e.Gradingsystemtypeid)
                    .ValueGeneratedNever()
                    .HasColumnName("GRADINGSYSTEMTYPEID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.Shortcode)
                    .HasMaxLength(10)
                    .HasColumnName("SHORTCODE");

                entity.Property(e => e.Shortcode2)
                    .HasMaxLength(10)
                    .HasColumnName("SHORTCODE2");
            });

            modelBuilder.Entity<Graduate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GRADUATE");

                entity.HasIndex(e => new { e.Studentid, e.Programmestreamid }, "AK_GRADUATE")
                    .IsUnique();

                entity.HasIndex(e => e.Timeinserted, "CI_GRADUATE")
                    .IsClustered();

                entity.HasIndex(e => e.Programmestreamid, "IX_GRADUATE2");

                entity.HasIndex(e => e.Graduationstreamid, "IX_GRADUATE3");

                entity.HasIndex(e => e.Id, "PK_GRADUATE")
                    .IsUnique();

                entity.Property(e => e.Approvedby)
                    .HasMaxLength(100)
                    .HasColumnName("APPROVEDBY");

                entity.Property(e => e.Awardclassid).HasColumnName("AWARDCLASSID");

                entity.Property(e => e.Awardclassname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("AWARDCLASSNAME");

                entity.Property(e => e.Awardclassrank).HasColumnName("AWARDCLASSRANK");

                entity.Property(e => e.Batchid).HasColumnName("BATCHID");

                entity.Property(e => e.Campusid).HasColumnName("CAMPUSID");

                entity.Property(e => e.Campusname)
                    .HasMaxLength(100)
                    .HasColumnName("CAMPUSNAME");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Cwa)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("CWA");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Departmentname)
                    .HasMaxLength(100)
                    .HasColumnName("DEPARTMENTNAME");

                entity.Property(e => e.Effectivedate)
                    .HasColumnType("date")
                    .HasColumnName("EFFECTIVEDATE");

                entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");

                entity.Property(e => e.Graduationstreamid).HasColumnName("GRADUATIONSTREAMID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Indexno)
                    .HasMaxLength(20)
                    .HasColumnName("INDEXNO");

                entity.Property(e => e.Insertedby)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Isapproved).HasColumnName("ISAPPROVED");

                entity.Property(e => e.Isreviewed).HasColumnName("ISREVIEWED");

                entity.Property(e => e.Lastactiontaken)
                    .HasMaxLength(1)
                    .HasColumnName("LASTACTIONTAKEN");

                entity.Property(e => e.Lastactiontime)
                    .HasColumnType("datetime")
                    .HasColumnName("LASTACTIONTIME");

                entity.Property(e => e.Lastactionuser)
                    .HasMaxLength(100)
                    .HasColumnName("LASTACTIONUSER");

                entity.Property(e => e.Longprogrammename)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("LONGPROGRAMMENAME");

                entity.Property(e => e.Optionid).HasColumnName("OPTIONID");

                entity.Property(e => e.Programmeaward)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("PROGRAMMEAWARD");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Reviewedby)
                    .HasMaxLength(100)
                    .HasColumnName("REVIEWEDBY");

                entity.Property(e => e.Shortprogrammename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("SHORTPROGRAMMENAME");

                entity.Property(e => e.Specialization)
                    .HasMaxLength(100)
                    .HasColumnName("SPECIALIZATION");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeapproved)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEAPPROVED");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Timereviewed)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEREVIEWED");

                entity.HasOne(d => d.Graduationstream)
                    .WithMany()
                    .HasForeignKey(d => d.Graduationstreamid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GRADUATE_GRADUATIONSTREAM");

                entity.HasOne(d => d.Studentprogramme)
                    .WithOne()
                    .HasForeignKey<Graduate>(d => new { d.Studentid, d.Programmestreamid })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GRADUATE_STUDENTPROGRAMME");

                entity.HasOne(d => d.StudentprogrammeNavigation)
                    .WithMany()
                    .HasPrincipalKey(p => new { p.Studentid, p.Programmestreamid, p.Optionid })
                    .HasForeignKey(d => new { d.Studentid, d.Programmestreamid, d.Optionid })
                    .HasConstraintName("FK_GRADUATE_STUDENTPROGRAMME1");
            });

            modelBuilder.Entity<Graduatelog>(entity =>
            {
                entity.HasKey(e => e.Logid)
                    .HasName("PK_GRADUATE_LOG");

                entity.ToTable("GRADUATELOG");

                entity.Property(e => e.Logid).HasColumnName("LOGID");

                entity.Property(e => e.Actiontaken)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("ACTIONTAKEN")
                    .IsFixedLength(true);

                entity.Property(e => e.Actiontime)
                    .HasColumnType("datetime")
                    .HasColumnName("ACTIONTIME");

                entity.Property(e => e.Approvedby)
                    .HasMaxLength(100)
                    .HasColumnName("APPROVEDBY");

                entity.Property(e => e.Awardclassid).HasColumnName("AWARDCLASSID");

                entity.Property(e => e.Awardclassname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("AWARDCLASSNAME");

                entity.Property(e => e.Awardclassrank).HasColumnName("AWARDCLASSRANK");

                entity.Property(e => e.Batchid).HasColumnName("BATCHID");

                entity.Property(e => e.Clientnetaddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("CLIENTNETADDRESS");

                entity.Property(e => e.Cwa)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("CWA");

                entity.Property(e => e.Departmentname)
                    .HasMaxLength(100)
                    .HasColumnName("DEPARTMENTNAME");

                entity.Property(e => e.Effectivedate)
                    .HasColumnType("date")
                    .HasColumnName("EFFECTIVEDATE");

                entity.Property(e => e.Graduationstreamid).HasColumnName("GRADUATIONSTREAMID");

                entity.Property(e => e.Hostname)
                    .HasMaxLength(100)
                    .HasColumnName("HOSTNAME");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Indexno)
                    .HasMaxLength(20)
                    .HasColumnName("INDEXNO");

                entity.Property(e => e.Insertedby)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Isapproved).HasColumnName("ISAPPROVED");

                entity.Property(e => e.Longprogrammename)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("LONGPROGRAMMENAME");

                entity.Property(e => e.Programmeaward)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("PROGRAMMEAWARD");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Shortprogrammename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("SHORTPROGRAMMENAME");

                entity.Property(e => e.Specialization)
                    .HasMaxLength(100)
                    .HasColumnName("SPECIALIZATION");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeapproved)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEAPPROVED");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<Graduatetype>(entity =>
            {
                entity.HasKey(e => e.Graduatetypeid)
                    .IsClustered(false);

                entity.ToTable("GRADUATETYPE");

                entity.Property(e => e.Graduatetypeid).HasColumnName("GRADUATETYPEID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<GraduationdataJune2016>(entity =>
            {
                entity.HasKey(e => e.Indexno);

                entity.ToTable("GRADUATIONDATA_JUNE2016");

                entity.Property(e => e.Indexno)
                    .HasMaxLength(255)
                    .HasColumnName("INDEXNO");

                entity.Property(e => e.Cwa).HasColumnName("CWA");

                entity.Property(e => e.Effectivedate)
                    .HasColumnType("date")
                    .HasColumnName("EFFECTIVEDATE");

                entity.Property(e => e.Programme)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("PROGRAMME");

                entity.Property(e => e.Studentname)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("STUDENTNAME");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("UNIT");
            });

            modelBuilder.Entity<GraduationdataJune2017>(entity =>
            {
                entity.HasKey(e => e.Indexno)
                    .HasName("PK_GRADUATIONDATA");

                entity.ToTable("GRADUATIONDATA_JUNE2017");

                entity.Property(e => e.Indexno)
                    .HasMaxLength(255)
                    .HasColumnName("INDEXNO");

                entity.Property(e => e.Cwa).HasColumnName("CWA");

                entity.Property(e => e.Effectivedate)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("EFFECTIVEDATE");

                entity.Property(e => e.Effectivedate2)
                    .HasMaxLength(50)
                    .HasColumnName("EFFECTIVEDATE2");

                entity.Property(e => e.Programme)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Studentname)
                    .HasMaxLength(255)
                    .HasColumnName("STUDENTNAME");

                entity.Property(e => e.Unit).HasMaxLength(255);
            });

            modelBuilder.Entity<Graduationfeeschedule>(entity =>
            {
                entity.ToTable("GRADUATIONFEESCHEDULE");

                entity.HasIndex(e => e.Graduationstreamid, "AK_GRADUATIONFEESCHEDULE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.Currencyid)
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID");

                entity.Property(e => e.Graduationstreamid).HasColumnName("GRADUATIONSTREAMID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Graduationpaymentexception>(entity =>
            {
                entity.HasKey(e => e.Studentid);

                entity.ToTable("GRADUATIONPAYMENTEXCEPTION");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<GraduationpaymentexceptionOld>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GRADUATIONPAYMENTEXCEPTION_OLD");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");
            });

            modelBuilder.Entity<Graduationpictureauthorizer>(entity =>
            {
                entity.ToTable("GRADUATIONPICTUREAUTHORIZER");

                entity.Property(e => e.Graduationpictureauthorizerid).HasColumnName("GRADUATIONPICTUREAUTHORIZERID");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Graduationpictureauthorizertypeid).HasColumnName("GRADUATIONPICTUREAUTHORIZERTYPEID");

                entity.Property(e => e.Isactive)
                    .IsRequired()
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Staffid)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnName("STAFFID");

                entity.HasOne(d => d.Graduationpictureauthorizertype)
                    .WithMany(p => p.Graduationpictureauthorizers)
                    .HasForeignKey(d => d.Graduationpictureauthorizertypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("GRADUATIONPICTUREAUTHORIZER_GRADUATIONPICTUREAUTHORIZERTYPE");
            });

            modelBuilder.Entity<Graduationpictureauthorizertype>(entity =>
            {
                entity.ToTable("GRADUATIONPICTUREAUTHORIZERTYPE");

                entity.Property(e => e.Graduationpictureauthorizertypeid)
                    .ValueGeneratedNever()
                    .HasColumnName("GRADUATIONPICTUREAUTHORIZERTYPEID");

                entity.Property(e => e.Graduationpictureauthorizertypename)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("GRADUATIONPICTUREAUTHORIZERTYPENAME");
            });

            modelBuilder.Entity<GraduationregisterTempAfterDeadline>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GRADUATIONREGISTER_TEMP_AFTER_DEADLINE");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.MessageSentTime).HasColumnType("datetime");

                entity.Property(e => e.StudentId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.VerifiedAt).HasColumnType("datetime");

                entity.Property(e => e.VerifiedBy).HasMaxLength(100);
            });

            modelBuilder.Entity<Graduationstream>(entity =>
            {
                entity.HasKey(e => e.Graduationstreamid)
                    .IsClustered(false);

                entity.ToTable("GRADUATIONSTREAM");

                entity.HasIndex(e => e.Graduationstreamname, "AK_GRADUATIONSTREAM")
                    .IsUnique();

                entity.HasIndex(e => new { e.Acadyear, e.Graduationtypeid }, "AK_GRADUATIONSTREAM2")
                    .IsUnique();

                entity.Property(e => e.Graduationstreamid)
                    .HasColumnName("GRADUATIONSTREAMID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Effectivedate)
                    .HasColumnType("date")
                    .HasColumnName("EFFECTIVEDATE");

                entity.Property(e => e.Enddate)
                    .HasColumnType("date")
                    .HasColumnName("ENDDATE");

                entity.Property(e => e.Graduationnumber).HasColumnName("GRADUATIONNUMBER");

                entity.Property(e => e.Graduationstreamname)
                    .HasMaxLength(100)
                    .HasColumnName("GRADUATIONSTREAMNAME");

                entity.Property(e => e.Graduationstreamstatusid).HasColumnName("GRADUATIONSTREAMSTATUSID");

                entity.Property(e => e.Graduationtypeid).HasColumnName("GRADUATIONTYPEID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Isclosed)
                    .IsRequired()
                    .HasColumnName("ISCLOSED")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Startdate)
                    .HasColumnType("date")
                    .HasColumnName("STARTDATE");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Graduationtype)
                    .WithMany(p => p.Graduationstreams)
                    .HasForeignKey(d => d.Graduationtypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GRADUATIONTYPE_GRADUATIONSTREAM");
            });

            modelBuilder.Entity<Graduationstreameffectivedate>(entity =>
            {
                entity.ToTable("GRADUATIONSTREAMEFFECTIVEDATE");

                entity.HasIndex(e => new { e.Graduationstreamid, e.Effectivedate }, "AK_GRADUATIONSTREAMEFFECTIVEDATE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Effectivedate)
                    .HasColumnType("date")
                    .HasColumnName("EFFECTIVEDATE");

                entity.Property(e => e.Graduationstreamid).HasColumnName("GRADUATIONSTREAMID");
            });

            modelBuilder.Entity<Graduationstreamsetting>(entity =>
            {
                entity.HasKey(e => new { e.Graduationstreamid, e.Graduatetypeid })
                    .IsClustered(false);

                entity.ToTable("GRADUATIONSTREAMSETTING");

                entity.HasIndex(e => e.Timeinserted, "ClusteredIndex-20210723-151848")
                    .IsClustered();

                entity.Property(e => e.Graduationstreamid).HasColumnName("GRADUATIONSTREAMID");

                entity.Property(e => e.Graduatetypeid).HasColumnName("GRADUATETYPEID");

                entity.Property(e => e.Isclosed).HasColumnName("ISCLOSED");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Graduationstreamstatus>(entity =>
            {
                entity.ToTable("GRADUATIONSTREAMSTATUS");

                entity.Property(e => e.Graduationstreamstatusid)
                    .ValueGeneratedNever()
                    .HasColumnName("GRADUATIONSTREAMSTATUSID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<Graduationtype>(entity =>
            {
                entity.ToTable("GRADUATIONTYPE");

                entity.Property(e => e.Graduationtypeid)
                    .ValueGeneratedNever()
                    .HasColumnName("GRADUATIONTYPEID");

                entity.Property(e => e.Graduationtypename)
                    .HasMaxLength(100)
                    .HasColumnName("GRADUATIONTYPENAME");
            });

            modelBuilder.Entity<Graduationuser>(entity =>
            {
                entity.HasKey(e => e.Userid);

                entity.ToTable("GRADUATIONUSER");

                entity.Property(e => e.Userid)
                    .HasMaxLength(128)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<Idcardapiclientupdate>(entity =>
            {
                entity.ToTable("IDCARDAPICLIENTUPDATE");

                entity.HasIndex(e => new { e.Clientid, e.Clienttype }, "IX_CLIENTID");

                entity.HasIndex(e => e.Maskedpan, "IX_PAN");

                entity.HasIndex(e => e.Phone, "IX_PHONE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Clientid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("CLIENTID");

                entity.Property(e => e.Clienttype)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("CLIENTTYPE");

                entity.Property(e => e.Maskedpan)
                    .HasMaxLength(50)
                    .HasColumnName("MASKEDPAN");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Timeactivated).HasColumnName("TIMEACTIVATED");

                entity.Property(e => e.Timeinserted)
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Idcardapidatastaff>(entity =>
            {
                entity.HasKey(e => e.ClientId)
                    .HasName("PK__IDCARDAP__E67E1A24F65CCFC0");

                entity.ToTable("IDCARDAPIDATASTAFF");

                entity.HasIndex(e => e.Phone, "IX_IDCARDSAPIDATASTAFF_PHONE")
                    .IsUnique();

                entity.Property(e => e.ClientId).HasMaxLength(10);

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.Expires)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.FirstName).HasMaxLength(150);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PostalAddress).HasMaxLength(500);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Idcardapidatastudent>(entity =>
            {
                entity.HasKey(e => e.ClientId)
                    .HasName("PK__IDCARDAP__E67E1A240F656E73");

                entity.ToTable("IDCARDAPIDATASTUDENT");

                entity.HasIndex(e => e.Phone, "IX_IDCARDSAPIDATASTUDENT_PHONE")
                    .IsUnique();

                entity.Property(e => e.ClientId).HasMaxLength(10);

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.Expires)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.FirstName).HasMaxLength(150);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PostalAddress).HasMaxLength(400);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Idcardapierrorlog>(entity =>
            {
                entity.ToTable("IDCARDAPIERRORLOG");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Exception).HasColumnName("EXCEPTION");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("MESSAGE");

                entity.Property(e => e.Timeinserted)
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Idcardapirequestlog>(entity =>
            {
                entity.ToTable("IDCARDAPIREQUESTLOG");

                entity.Property(e => e.ApiuserId).HasColumnName("APIUserId");

                entity.Property(e => e.ClientIp)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ClientIP");

                entity.Property(e => e.RequestDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RequestMethod).HasMaxLength(10);
            });

            modelBuilder.Entity<Idcardapitestuser>(entity =>
            {
                entity.HasKey(e => e.Clientid)
                    .HasName("PK__IDCARDAP__8E7CE2063AF7FE1A");

                entity.ToTable("IDCARDAPITESTUSER");

                entity.Property(e => e.Clientid)
                    .HasMaxLength(20)
                    .HasColumnName("CLIENTID");

                entity.Property(e => e.Dateofbirth)
                    .HasColumnType("date")
                    .HasColumnName("DATEOFBIRTH");

                entity.Property(e => e.Expires)
                    .HasMaxLength(20)
                    .HasColumnName("EXPIRES");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(70)
                    .HasColumnName("LASTNAME");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Postaladdress)
                    .IsRequired()
                    .HasMaxLength(512)
                    .HasColumnName("POSTALADDRESS");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .HasColumnName("TYPE");
            });

            modelBuilder.Entity<Idcardapiuser>(entity =>
            {
                entity.ToTable("IDCARDAPIUSER");

                entity.Property(e => e.Apikey)
                    .IsRequired()
                    .HasColumnName("APIKey");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Institution>(entity =>
            {
                entity.HasKey(e => e.Instid)
                    .IsClustered(false);

                entity.ToTable("INSTITUTION");

                entity.Property(e => e.Instid).HasColumnName("INSTID");

                entity.Property(e => e.Add1)
                    .HasMaxLength(100)
                    .HasColumnName("ADD1");

                entity.Property(e => e.Add2)
                    .HasMaxLength(100)
                    .HasColumnName("ADD2");

                entity.Property(e => e.Add3)
                    .HasMaxLength(100)
                    .HasColumnName("ADD3");

                entity.Property(e => e.Add4)
                    .HasMaxLength(100)
                    .HasColumnName("ADD4");

                entity.Property(e => e.Add5)
                    .HasMaxLength(100)
                    .HasColumnName("ADD5");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .HasColumnName("FAX");

                entity.Property(e => e.Institutiontypeid).HasColumnName("INSTITUTIONTYPEID");

                entity.Property(e => e.Islevelbased).HasColumnName("ISLEVELBASED");

                entity.Property(e => e.Logo).HasColumnName("LOGO");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Shortcode)
                    .HasMaxLength(10)
                    .HasColumnName("SHORTCODE");

                entity.Property(e => e.Website)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("WEBSITE");

                entity.HasOne(d => d.Institutiontype)
                    .WithMany(p => p.Institutions)
                    .HasForeignKey(d => d.Institutiontypeid)
                    .HasConstraintName("INSTITUTIONTYPEINSTITUTION");
            });

            modelBuilder.Entity<Institutiontype>(entity =>
            {
                entity.HasKey(e => e.Institutiontypeid)
                    .IsClustered(false);

                entity.ToTable("INSTITUTIONTYPE");

                entity.Property(e => e.Institutiontypeid)
                    .ValueGeneratedNever()
                    .HasColumnName("INSTITUTIONTYPEID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<Invigilator>(entity =>
            {
                entity.HasKey(e => e.Invigilatorid)
                    .IsClustered(false);

                entity.ToTable("INVIGILATOR");

                entity.Property(e => e.Invigilatorid).HasColumnName("INVIGILATORID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<Lect>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LECT");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("NAME");

                entity.Property(e => e.Othermail)
                    .HasMaxLength(255)
                    .HasColumnName("OTHERMAIL");

                entity.Property(e => e.Schoolemail)
                    .HasMaxLength(255)
                    .HasColumnName("SCHOOLEMAIL");

                entity.Property(e => e.Staffid)
                    .HasMaxLength(255)
                    .HasColumnName("STAFFID");
            });

            modelBuilder.Entity<Lectureperiod>(entity =>
            {
                entity.HasKey(e => e.Periodid)
                    .IsClustered(false);

                entity.ToTable("LECTUREPERIOD");

                entity.Property(e => e.Periodid)
                    .ValueGeneratedNever()
                    .HasColumnName("PERIODID");

                entity.Property(e => e.Daysessionid).HasColumnName("DAYSESSIONID");

                entity.Property(e => e.Endtime).HasColumnName("ENDTIME");

                entity.Property(e => e.Starttime).HasColumnName("STARTTIME");

                entity.HasOne(d => d.Daysession)
                    .WithMany(p => p.Lectureperiods)
                    .HasForeignKey(d => d.Daysessionid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DAYSESSIONLECTUREPERIOD");
            });

            modelBuilder.Entity<Lecturer>(entity =>
            {
                entity.HasKey(e => e.Lecturerid)
                    .IsClustered(false);

                entity.ToTable("LECTURER");

                entity.HasIndex(e => e.Staffid, "UK_LECTURER_STAFFID")
                    .IsUnique();

                entity.HasIndex(e => e.Staffid, "missing_index_360");

                entity.Property(e => e.Lecturerid).HasColumnName("LECTURERID");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(100)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.Staffid).HasColumnName("STAFFID");
            });

            modelBuilder.Entity<Lecturer1>(entity =>
            {
                entity.HasKey(e => e.LecturerId)
                    .IsClustered(false);

                entity.ToTable("Lecturer", "tt");

                entity.Property(e => e.LecturerName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.LecturerTitle)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.StaffId2).HasMaxLength(20);
            });

            modelBuilder.Entity<Lecturerpreference>(entity =>
            {
                entity.HasKey(e => new { e.Lecturerid, e.Coursecode, e.Yr, e.Programmestreamid, e.Acadyear, e.Sem })
                    .IsClustered(false);

                entity.ToTable("LECTURERPREFERENCE");

                entity.Property(e => e.Lecturerid)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("LECTURERID");

                entity.Property(e => e.Coursecode)
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Yr).HasColumnName("YR");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Classroomid).HasColumnName("CLASSROOMID");

                entity.Property(e => e.Dayid).HasColumnName("DAYID");

                entity.Property(e => e.Periodid).HasColumnName("PERIODID");

                entity.HasOne(d => d.Classroom)
                    .WithMany(p => p.Lecturerpreferences)
                    .HasForeignKey(d => d.Classroomid)
                    .HasConstraintName("CLASSROOMLECTURERPREFERENCE");

                entity.HasOne(d => d.Day)
                    .WithMany(p => p.Lecturerpreferences)
                    .HasForeignKey(d => d.Dayid)
                    .HasConstraintName("DAYOFWEEKLECTURERPREFERENCE");

                entity.HasOne(d => d.Period)
                    .WithMany(p => p.Lecturerpreferences)
                    .HasForeignKey(d => d.Periodid)
                    .HasConstraintName("LECTUREPERIODLECTURERPREFERENCE");
            });

            modelBuilder.Entity<Lecturetimetable>(entity =>
            {
                entity.HasKey(e => new { e.Dayid, e.Periodid, e.Programmeid, e.Coursecode, e.Yr, e.Programmestreamid, e.Acadyear, e.Sem })
                    .IsClustered(false);

                entity.ToTable("LECTURETIMETABLE");

                entity.Property(e => e.Dayid).HasColumnName("DAYID");

                entity.Property(e => e.Periodid).HasColumnName("PERIODID");

                entity.Property(e => e.Programmeid).HasColumnName("PROGRAMMEID");

                entity.Property(e => e.Coursecode)
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Yr).HasColumnName("YR");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Classroomid).HasColumnName("CLASSROOMID");

                entity.HasOne(d => d.Classroom)
                    .WithMany(p => p.Lecturetimetables)
                    .HasForeignKey(d => d.Classroomid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CLASSROOMLECTURETIMETABLE");

                entity.HasOne(d => d.Day)
                    .WithMany(p => p.Lecturetimetables)
                    .HasForeignKey(d => d.Dayid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DAYOFWEEKLECTURETIMETABLE");

                entity.HasOne(d => d.Period)
                    .WithMany(p => p.Lecturetimetables)
                    .HasForeignKey(d => d.Periodid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("LECTUREPERIODLECTURETIMETABLE");

                entity.HasOne(d => d.Programme)
                    .WithMany(p => p.Lecturetimetables)
                    .HasForeignKey(d => d.Programmeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PROGRAMMELECTURETIMETABLE");
            });

            modelBuilder.Entity<Level>(entity =>
            {
                entity.HasKey(e => e.LevelId)
                    .IsClustered(false);

                entity.ToTable("Level", "tt");

                entity.Property(e => e.LevelId).ValueGeneratedNever();

                entity.Property(e => e.LevelName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Mainfmisaccount>(entity =>
            {
                entity.ToTable("MAINFMISACCOUNTS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CrpForeign)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("CRP_FOREIGN");

                entity.Property(e => e.CrpIdl)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("CRP_IDL");

                entity.Property(e => e.CrpRegular)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("CRP_REGULAR");

                entity.Property(e => e.CruForeign)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("CRU_FOREIGN");

                entity.Property(e => e.CruGhfeepaying)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("CRU_GHFEEPAYING");

                entity.Property(e => e.CruIdl)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("CRU_IDL");

                entity.Property(e => e.CruParttime)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("CRU_PARTTIME");

                entity.Property(e => e.CruRegular)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("CRU_REGULAR");
            });

            modelBuilder.Entity<Manillaemailrecipient>(entity =>
            {
                entity.ToTable("MANILLAEMAILRECIPIENT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Emailaddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("EMAILADDRESS");

                entity.Property(e => e.Ismain).HasColumnName("ISMAIN");
            });

            modelBuilder.Entity<Maritalstatus>(entity =>
            {
                entity.HasKey(e => e.Maritalstatusid)
                    .IsClustered(false);

                entity.ToTable("MARITALSTATUS");

                entity.Property(e => e.Maritalstatusid).HasColumnName("MARITALSTATUSID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<Mastercourse>(entity =>
            {
                entity.HasKey(e => e.Coursecode)
                    .IsClustered(false);

                entity.ToTable("MASTERCOURSE");

                entity.HasIndex(e => new { e.Isopenelective, e.Sem }, "missing_index_64");

                entity.Property(e => e.Coursecode)
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Credit).HasColumnName("CREDIT");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Graduatetypeid).HasColumnName("GRADUATETYPEID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.Isopenelective).HasColumnName("ISOPENELECTIVE");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Mastercourses)
                    .HasForeignKey(d => d.Departmentid)
                    .HasConstraintName("DEPARTMENTMASTERCOURSE");

                entity.HasOne(d => d.Graduatetype)
                    .WithMany(p => p.Mastercourses)
                    .HasForeignKey(d => d.Graduatetypeid)
                    .HasConstraintName("GRADUATETYPEMASTERCOURSE");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Mismatchpayment>(entity =>
            {
                entity.ToTable("MISMATCHPAYMENTS");

                entity.HasIndex(e => e.Transactionid, "UI_TRANSACTION")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Altransactionid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ALTRANSACTIONID");

                entity.Property(e => e.Amountfromnsano)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AMOUNTFROMNSANO");

                entity.Property(e => e.Amountinsis)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AMOUNTINSIS");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Transactionid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TRANSACTIONID");
            });

            modelBuilder.Entity<Mobileappsetting>(entity =>
            {
                entity.ToTable("MOBILEAPPSETTING");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Customupdatemessage)
                    .HasMaxLength(800)
                    .HasColumnName("CUSTOMUPDATEMESSAGE");

                entity.Property(e => e.Helpurl)
                    .HasMaxLength(500)
                    .HasColumnName("HELPURL");

                entity.Property(e => e.Iscritical).HasColumnName("ISCRITICAL");

                entity.Property(e => e.Minversion).HasColumnName("MINVERSION");

                entity.Property(e => e.Registrationinstructionurl)
                    .HasMaxLength(500)
                    .HasColumnName("REGISTRATIONINSTRUCTIONURL");

                entity.Property(e => e.Sendfcmtoken).HasColumnName("SENDFCMTOKEN");

                entity.Property(e => e.Usecustomupdatemessage).HasColumnName("USECUSTOMUPDATEMESSAGE");
            });

            modelBuilder.Entity<Mobilenetworkcode>(entity =>
            {
                entity.ToTable("MOBILENETWORKCODE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Network)
                    .HasMaxLength(50)
                    .HasColumnName("NETWORK");

                entity.Property(e => e.Prefix)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("PREFIX");
            });

            modelBuilder.Entity<Netsetting>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NETSETTING");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Netsettingid).HasColumnName("NETSETTINGID");

                entity.Property(e => e.Sem).HasColumnName("SEM");
            });

            modelBuilder.Entity<NursingstudentsTemppwdDel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NURSINGSTUDENTS_TEMPPWD_DEL");

                entity.Property(e => e.Othername)
                    .HasMaxLength(50)
                    .HasColumnName("OTHERNAME");

                entity.Property(e => e.PhoneNumber).HasMaxLength(100);

                entity.Property(e => e.SchoolEmail).HasMaxLength(100);

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("SURNAME");
            });

            modelBuilder.Entity<Onlineadmin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ONLINEADMIN");

                entity.HasIndex(e => e.Username, "UQ__ONLINEAD__B15BE12E6D595625")
                    .IsUnique();

                entity.Property(e => e.Logincreated).HasColumnName("LOGINCREATED");

                entity.Property(e => e.Logincreateerror)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("LOGINCREATEERROR");

                entity.Property(e => e.Pass)
                    .HasMaxLength(100)
                    .HasColumnName("PASS");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<Onlinelog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ONLINELOG");

                entity.Property(e => e.Actiondate)
                    .HasColumnType("datetime")
                    .HasColumnName("ACTIONDATE");

                entity.Property(e => e.Actiontaken)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("ACTIONTAKEN");

                entity.Property(e => e.App)
                    .HasMaxLength(25)
                    .HasColumnName("APP");

                entity.Property(e => e.Appversion).HasColumnName("APPVERSION");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<Organizationalunit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ORGANIZATIONALUNIT");

                entity.Property(e => e.Orgunitname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("ORGUNITNAME");

                entity.Property(e => e.Ouid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("OUID");
            });

            modelBuilder.Entity<Paymentchannel>(entity =>
            {
                entity.ToTable("PAYMENTCHANNEL");

                entity.Property(e => e.Paymentchannelid)
                    .ValueGeneratedNever()
                    .HasColumnName("PAYMENTCHANNELID");

                entity.Property(e => e.Paymentchannelcode)
                    .HasMaxLength(10)
                    .HasColumnName("PAYMENTCHANNELCODE");

                entity.Property(e => e.Paymentchannelname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PAYMENTCHANNELNAME");
            });

            modelBuilder.Entity<Paymentlocation>(entity =>
            {
                entity.HasKey(e => e.Paymentlocid)
                    .IsClustered(false);

                entity.ToTable("PAYMENTLOCATION");

                entity.Property(e => e.Paymentlocid).HasColumnName("PAYMENTLOCID");

                entity.Property(e => e.Isactive)
                    .IsRequired()
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<Paymenttype>(entity =>
            {
                entity.HasKey(e => e.Paymenttypeid)
                    .IsClustered(false);

                entity.ToTable("PAYMENTTYPE");

                entity.Property(e => e.Paymenttypeid).HasColumnName("PAYMENTTYPEID");

                entity.Property(e => e.Isactive)
                    .IsRequired()
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Isbankpayment).HasColumnName("ISBANKPAYMENT");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<Pgstudentthesistopic>(entity =>
            {
                entity.HasKey(e => new { e.Studentid, e.Programmestreamid })
                    .HasName("PK_PGSTUDENTSTHESISTOPIC");

                entity.ToTable("PGSTUDENTTHESISTOPIC");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Effectivedate)
                    .HasColumnType("date")
                    .HasColumnName("EFFECTIVEDATE");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Passedoralexam).HasColumnName("PASSEDORALEXAM");

                entity.Property(e => e.Thesisstatus).HasColumnName("THESISSTATUS");

                entity.Property(e => e.Thesistopic)
                    .HasMaxLength(3000)
                    .HasColumnName("THESISTOPIC");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Timeupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEUPDATED");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.Studentprogramme)
                    .WithOne(p => p.Pgstudentthesistopic)
                    .HasForeignKey<Pgstudentthesistopic>(d => new { d.Studentid, d.Programmestreamid })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("STUDENTPROGRAMMEPGSTUDENTSTHESISTOPIC");
            });

            modelBuilder.Entity<Placeofresidence>(entity =>
            {
                entity.HasKey(e => e.Placeofresidenceid)
                    .IsClustered(false);

                entity.ToTable("PLACEOFRESIDENCE");

                entity.Property(e => e.Placeofresidenceid).HasColumnName("PLACEOFRESIDENCEID");

                entity.Property(e => e.Name)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<Programme>(entity =>
            {
                entity.HasKey(e => e.Programmeid)
                    .IsClustered(false);

                entity.ToTable("PROGRAMME");

                entity.HasIndex(e => e.Name, "AK_PROGRAMME")
                    .IsUnique();

                entity.HasIndex(e => e.Graduatetypeid, "IX_PROGRAMMEGRADUATETYPEID");

                entity.Property(e => e.Programmeid).HasColumnName("PROGRAMMEID");

                entity.Property(e => e.Academicgroupid).HasColumnName("ACADEMICGROUPID");

                entity.Property(e => e.Awardname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("AWARDNAME");

                entity.Property(e => e.Career)
                    .HasColumnType("ntext")
                    .HasColumnName("CAREER");

                entity.Property(e => e.Certificatetypeid).HasColumnName("CERTIFICATETYPEID");

                entity.Property(e => e.Coursecontent)
                    .HasColumnType("ntext")
                    .HasColumnName("COURSECONTENT");

                entity.Property(e => e.Degreeid).HasColumnName("DEGREEID");

                entity.Property(e => e.Graduatetypeid).HasColumnName("GRADUATETYPEID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.Longprogrammename)
                    .HasMaxLength(200)
                    .HasColumnName("LONGPROGRAMMENAME");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.Overview)
                    .HasColumnType("ntext")
                    .HasColumnName("OVERVIEW");

                entity.Property(e => e.Requirement)
                    .HasColumnType("ntext")
                    .HasColumnName("REQUIREMENT");

                entity.Property(e => e.Shortcode)
                    .HasMaxLength(50)
                    .HasColumnName("SHORTCODE");

                entity.Property(e => e.Shortname)
                    .HasMaxLength(50)
                    .HasColumnName("SHORTNAME");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Academicgroup)
                    .WithMany(p => p.Programmes)
                    .HasForeignKey(d => d.Academicgroupid)
                    .HasConstraintName("ACADEMICGROUPPROGRAMME");

                entity.HasOne(d => d.Certificatetype)
                    .WithMany(p => p.Programmes)
                    .HasForeignKey(d => d.Certificatetypeid)
                    .HasConstraintName("CERTIFICATETYPEPROGRAMME");

                entity.HasOne(d => d.Graduatetype)
                    .WithMany(p => p.Programmes)
                    .HasForeignKey(d => d.Graduatetypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("GRADUATETYPEPROGRAMME");
            });

            modelBuilder.Entity<ProgrammeStream1>(entity =>
            {
                entity.HasKey(e => e.ProgrammeStreamId)
                    .IsClustered(false);

                entity.ToTable("ProgrammeStream", "tt");

                entity.Property(e => e.ProgrammeStreamId).ValueGeneratedNever();

                entity.Property(e => e.ProgrammeStreamName)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Programmecourse>(entity =>
            {
                entity.HasKey(e => new { e.Programmestreamid, e.Acadyear, e.Sem, e.Coursecode, e.Acadlevelid })
                    .IsClustered(false);

                entity.ToTable("PROGRAMMECOURSE");

                entity.HasIndex(e => new { e.Programmestreamid, e.Acadyear, e.Sem, e.Acadlevelid }, "IX_PROGRAMMECOURSE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Coursecode)
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Coursename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Coursetypeid).HasColumnName("COURSETYPEID");

                entity.Property(e => e.Credit).HasColumnName("CREDIT");

                entity.Property(e => e.Estimatednumber).HasColumnName("ESTIMATEDNUMBER");

                entity.Property(e => e.Excludefromexamtimetable)
                    .HasColumnName("EXCLUDEFROMEXAMTIMETABLE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Excludefromlecturetimetable)
                    .IsRequired()
                    .HasColumnName("EXCLUDEFROMLECTURETIMETABLE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Lecturerid).HasColumnName("LECTURERID");

                entity.Property(e => e.Practicalcredit).HasColumnName("PRACTICALCREDIT");

                entity.Property(e => e.Teachingcredit).HasColumnName("TEACHINGCREDIT");

                entity.Property(e => e.Yr).HasColumnName("YR");

                entity.HasOne(d => d.CoursecodeNavigation)
                    .WithMany(p => p.Programmecourses)
                    .HasForeignKey(d => d.Coursecode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MASTERCOURSEPROGRAMMECOURSE");

                entity.HasOne(d => d.Coursetype)
                    .WithMany(p => p.Programmecourses)
                    .HasForeignKey(d => d.Coursetypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("COURSETYPEPROGRAMMECOURSE");

                entity.HasOne(d => d.Lecturer)
                    .WithMany(p => p.Programmecourses)
                    .HasForeignKey(d => d.Lecturerid)
                    .HasConstraintName("FK_PROGRAMMECOURSE_LECTURER");

                entity.HasOne(d => d.Programmestream)
                    .WithMany(p => p.Programmecourses)
                    .HasForeignKey(d => d.Programmestreamid)
                    .HasConstraintName("FK_PROGRAMMECOURSE_PROGRAMMESTREAM");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.Programmecourses)
                    .HasForeignKey(d => new { d.Acadyear, d.Sem })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SEMESTERPROGRAMMECOURSE");
            });

            modelBuilder.Entity<Programmeoption>(entity =>
            {
                entity.HasKey(e => new { e.Optionid, e.Programmestreamid })
                    .IsClustered(false);

                entity.ToTable("PROGRAMMEOPTION");

                entity.HasIndex(e => new { e.Programmestreamid, e.Name }, "missing_index_148");

                entity.Property(e => e.Optionid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("OPTIONID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Isavailableonline)
                    .IsRequired()
                    .HasColumnName("ISAVAILABLEONLINE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.Optioncode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OPTIONCODE");

                entity.HasOne(d => d.Programmestream)
                    .WithMany(p => p.Programmeoptions)
                    .HasForeignKey(d => d.Programmestreamid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PROGRAMMESTREAMPROGRAMMEOPTION");
            });

            modelBuilder.Entity<Programmeoptioncourse>(entity =>
            {
                entity.HasKey(e => new { e.Optionid, e.Programmestreamid, e.Acadyear, e.Sem, e.Acadlevelid, e.Coursecode })
                    .IsClustered(false);

                entity.ToTable("PROGRAMMEOPTIONCOURSE");

                entity.HasIndex(e => new { e.Programmestreamid, e.Acadyear, e.Sem, e.Acadlevelid }, "IX_PROGRAMMEOPTIONCOURSE");

                entity.HasIndex(e => new { e.Acadyear, e.Sem, e.Lecturerid }, "missing_index_20");

                entity.Property(e => e.Optionid).HasColumnName("OPTIONID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Coursecode)
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Electivesetid).HasColumnName("ELECTIVESETID");

                entity.Property(e => e.Isexemptresultcheck).HasColumnName("ISEXEMPTRESULTCHECK");

                entity.Property(e => e.Lecturerid).HasColumnName("LECTURERID");

                entity.HasOne(d => d.Electiveset)
                    .WithMany(p => p.Programmeoptioncourses)
                    .HasForeignKey(d => d.Electivesetid)
                    .HasConstraintName("ELECTIVESETPROGRAMMEOPTIONCOURSE");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.Programmeoptioncourses)
                    .HasForeignKey(d => new { d.Acadyear, d.Sem })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SEMESTERPROGRAMMEOPTIONCOURSE");

                entity.HasOne(d => d.Programmeoption)
                    .WithMany(p => p.Programmeoptioncourses)
                    .HasForeignKey(d => new { d.Optionid, d.Programmestreamid })
                    .HasConstraintName("PROGRAMMEOPTIONPROGRAMMEOPTIONCOURSE");

                entity.HasOne(d => d.Courselecturer)
                    .WithMany(p => p.Programmeoptioncourses)
                    .HasForeignKey(d => new { d.Lecturerid, d.Coursecode, d.Acadlevelid, d.Programmestreamid, d.Acadyear, d.Sem })
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_COURSELECTURER_PROGRAMMEOPTIONCOURSE");
            });

            modelBuilder.Entity<Programmeoptioncoursecampuslecturer>(entity =>
            {
                entity.HasKey(e => new { e.Optionid, e.Programmestreamid, e.Acadyear, e.Sem, e.Acadlevelid, e.Coursecode, e.Lecturerid, e.Campusid })
                    .IsClustered(false);

                entity.ToTable("PROGRAMMEOPTIONCOURSECAMPUSLECTURER");

                entity.Property(e => e.Optionid).HasColumnName("OPTIONID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Coursecode)
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Lecturerid).HasColumnName("LECTURERID");

                entity.Property(e => e.Campusid).HasColumnName("CAMPUSID");

                entity.Property(e => e.Lastaccess)
                    .HasColumnName("LASTACCESS")
                    .HasDefaultValueSql("('1900-01-01')");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.Programmeoptioncoursecampuslecturers)
                    .HasForeignKey(d => new { d.Acadyear, d.Sem })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SEMESTERPROGRAMMEOPTIONCOURSECAMPUSLECTURER");

                entity.HasOne(d => d.Programmeoption)
                    .WithMany(p => p.Programmeoptioncoursecampuslecturers)
                    .HasForeignKey(d => new { d.Optionid, d.Programmestreamid })
                    .HasConstraintName("PROGRAMMEOPTIONPROGRAMMEOPTIONCOURSECAMPUSLECTURER");

                entity.HasOne(d => d.Courselecturer)
                    .WithMany(p => p.Programmeoptioncoursecampuslecturers)
                    .HasForeignKey(d => new { d.Lecturerid, d.Coursecode, d.Acadlevelid, d.Programmestreamid, d.Acadyear, d.Sem })
                    .HasConstraintName("FK_COURSELECTURER_PROGRAMMEOPTIONCOURSECAMPUSLECTURER");
            });

            modelBuilder.Entity<Programmeoptioncourselecturer>(entity =>
            {
                entity.HasKey(e => new { e.Optionid, e.Programmestreamid, e.Acadyear, e.Sem, e.Acadlevelid, e.Coursecode, e.Lecturerid })
                    .IsClustered(false);

                entity.ToTable("PROGRAMMEOPTIONCOURSELECTURER");

                entity.HasIndex(e => new { e.Programmestreamid, e.Acadyear, e.Sem, e.Acadlevelid }, "IX_PROGRAMMEOPTIONCOURSELECTURER");

                entity.HasIndex(e => new { e.Acadyear, e.Sem, e.Coursecode }, "IX_PROGRAMMEOPTIONCOURSELECTURER_ASS");

                entity.Property(e => e.Optionid).HasColumnName("OPTIONID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Coursecode)
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Lecturerid).HasColumnName("LECTURERID");

                entity.Property(e => e.Lastaccess)
                    .HasColumnName("LASTACCESS")
                    .HasDefaultValueSql("('1900-01-01')");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.Programmeoptioncourselecturers)
                    .HasForeignKey(d => new { d.Acadyear, d.Sem })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SEMESTERPROGRAMMEOPTIONCOURSELECTURER");

                entity.HasOne(d => d.Programmeoption)
                    .WithMany(p => p.Programmeoptioncourselecturers)
                    .HasForeignKey(d => new { d.Optionid, d.Programmestreamid })
                    .HasConstraintName("PROGRAMMEOPTIONPROGRAMMEOPTIONCOURSELECTURER");

                entity.HasOne(d => d.Courselecturer)
                    .WithMany(p => p.Programmeoptioncourselecturers)
                    .HasForeignKey(d => new { d.Lecturerid, d.Coursecode, d.Acadlevelid, d.Programmestreamid, d.Acadyear, d.Sem })
                    .HasConstraintName("FK_COURSELECTURER_PROGRAMMEOPTIONCOURSELECTURER");
            });

            modelBuilder.Entity<Programmeoptionuser>(entity =>
            {
                entity.HasKey(e => new { e.Optionid, e.Programmestreamid, e.Userid })
                    .HasName("PK_PROGRAMMEOPTIONUSER_1");

                entity.ToTable("PROGRAMMEOPTIONUSER");

                entity.Property(e => e.Optionid).HasColumnName("OPTIONID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Userid)
                    .HasMaxLength(128)
                    .HasColumnName("USERID");

                entity.HasOne(d => d.Programmeoption)
                    .WithMany(p => p.Programmeoptionusers)
                    .HasForeignKey(d => new { d.Optionid, d.Programmestreamid })
                    .HasConstraintName("FK_PROGRAMMEOPTION_PROGRAMMEOPTIONUSER");
            });

            modelBuilder.Entity<Programmesemester>(entity =>
            {
                entity.HasKey(e => new { e.Programmestreamid, e.Acadyear, e.Sem, e.Acadlevelid })
                    .IsClustered(false);

                entity.ToTable("PROGRAMMESEMESTER");

                entity.HasIndex(e => new { e.Acadyear, e.Acadlevelid }, "IX_PROGRAMMESEMESTER");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Changecampus).HasColumnName("CHANGECAMPUS");

                entity.Property(e => e.Changeoption).HasColumnName("CHANGEOPTION");

                entity.Property(e => e.Enddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ENDDATE");

                entity.Property(e => e.Examenddate)
                    .HasColumnType("datetime")
                    .HasColumnName("EXAMENDDATE");

                entity.Property(e => e.Examstartdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EXAMSTARTDATE");

                entity.Property(e => e.Registrationenddate)
                    .HasColumnType("datetime")
                    .HasColumnName("REGISTRATIONENDDATE");

                entity.Property(e => e.Registrationstartdate)
                    .HasColumnType("datetime")
                    .HasColumnName("REGISTRATIONSTARTDATE");

                entity.Property(e => e.Resultsapproved).HasColumnName("RESULTSAPPROVED");

                entity.Property(e => e.Resultsapprovedby)
                    .HasMaxLength(100)
                    .HasColumnName("RESULTSAPPROVEDBY");

                entity.Property(e => e.Resultsapproveddate)
                    .HasColumnType("datetime")
                    .HasColumnName("RESULTSAPPROVEDDATE");

                entity.Property(e => e.Startdate)
                    .HasColumnType("datetime")
                    .HasColumnName("STARTDATE");

                entity.HasOne(d => d.Programmestream)
                    .WithMany(p => p.Programmesemesters)
                    .HasForeignKey(d => d.Programmestreamid)
                    .HasConstraintName("PROGRAMMESTREAMPROGRAMMESEMESTER");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.Programmesemesters)
                    .HasForeignKey(d => new { d.Acadyear, d.Sem })
                    .HasConstraintName("SEMESTERPROGRAMMESEMESTER");
            });

            modelBuilder.Entity<Programmestream>(entity =>
            {
                entity.HasKey(e => e.Programmestreamid)
                    .IsClustered(false);

                entity.ToTable("PROGRAMMESTREAM");

                entity.HasIndex(e => new { e.Programmeid, e.Timestreamid }, "AK_PROGRAMMESTREAM")
                    .IsUnique();

                entity.HasIndex(e => e.Collegeid, "IX_PROGRAMMESTREAM_COLLEGEID");

                entity.HasIndex(e => new { e.Programmeid, e.Timestreamid }, "_dta_index_PROGRAMMESTREAM_c_11_1783677402__K2_K3")
                    .IsClustered();

                entity.HasIndex(e => e.Timestreamid, "missing_index_59");

                entity.Property(e => e.Programmestreamid)
                    .ValueGeneratedNever()
                    .HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Addoptiontocert).HasColumnName("ADDOPTIONTOCERT");

                entity.Property(e => e.Affiliateddepartmenttid).HasColumnName("AFFILIATEDDEPARTMENTTID");

                entity.Property(e => e.Biometricverificationrequired)
                    .IsRequired()
                    .HasColumnName("BIOMETRICVERIFICATIONREQUIRED")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Calendarid).HasColumnName("CALENDARID");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Coresetid).HasColumnName("CORESETID");

                entity.Property(e => e.CrLine1)
                    .HasMaxLength(100)
                    .HasColumnName("CR_LINE1");

                entity.Property(e => e.CrLine2)
                    .HasMaxLength(100)
                    .HasColumnName("CR_LINE2");

                entity.Property(e => e.CrLine3)
                    .HasMaxLength(100)
                    .HasColumnName("CR_LINE3");

                entity.Property(e => e.CrLine4)
                    .HasMaxLength(100)
                    .HasColumnName("CR_LINE4");

                entity.Property(e => e.CtLine1)
                    .HasMaxLength(100)
                    .HasColumnName("CT_LINE1");

                entity.Property(e => e.CtLine2)
                    .HasMaxLength(100)
                    .HasColumnName("CT_LINE2");

                entity.Property(e => e.CtLine3)
                    .HasMaxLength(100)
                    .HasColumnName("CT_LINE3");

                entity.Property(e => e.CtLine4)
                    .HasMaxLength(100)
                    .HasColumnName("CT_LINE4");

                entity.Property(e => e.CtcLine1)
                    .HasMaxLength(100)
                    .HasColumnName("CTC_LINE1");

                entity.Property(e => e.CtcLine2)
                    .HasMaxLength(100)
                    .HasColumnName("CTC_LINE2");

                entity.Property(e => e.CtcLine3)
                    .HasMaxLength(100)
                    .HasColumnName("CTC_LINE3");

                entity.Property(e => e.CtcLine4)
                    .HasMaxLength(100)
                    .HasColumnName("CTC_LINE4");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Durationdescription)
                    .HasMaxLength(100)
                    .HasColumnName("DURATIONDESCRIPTION");

                entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");

                entity.Property(e => e.Feeclassificationid).HasColumnName("FEECLASSIFICATIONID");

                entity.Property(e => e.Finalsem).HasColumnName("FINALSEM");

                entity.Property(e => e.Finalyear).HasColumnName("FINALYEAR");

                entity.Property(e => e.Governingboard)
                    .HasMaxLength(50)
                    .HasColumnName("GOVERNINGBOARD");

                entity.Property(e => e.Gradingid).HasColumnName("GRADINGID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.Isactive)
                    .IsRequired()
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Isadmissionavailable).HasColumnName("ISADMISSIONAVAILABLE");

                entity.Property(e => e.Mincredits)
                    .HasColumnName("MINCREDITS")
                    .HasDefaultValueSql("((1000))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.Parentcollegeid).HasColumnName("PARENTCOLLEGEID");

                entity.Property(e => e.Parentdepartmentid).HasColumnName("PARENTDEPARTMENTID");

                entity.Property(e => e.Parentfacultyid).HasColumnName("PARENTFACULTYID");

                entity.Property(e => e.Programmeid).HasColumnName("PROGRAMMEID");

                entity.Property(e => e.Reporttitle)
                    .HasMaxLength(100)
                    .HasColumnName("REPORTTITLE");

                entity.Property(e => e.Resitcategoryid).HasColumnName("RESITCATEGORYID");

                entity.Property(e => e.Resittemplateid).HasColumnName("RESITTEMPLATEID");

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Streamcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STREAMCODE");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Timestreamid).HasColumnName("TIMESTREAMID");

                entity.Property(e => e.Transcriptourrefprefix)
                    .HasMaxLength(20)
                    .HasColumnName("TRANSCRIPTOURREFPREFIX");

                entity.Property(e => e.Wsitemid).HasColumnName("WSITEMID");

                entity.HasOne(d => d.Affiliateddepartmentt)
                    .WithMany(p => p.ProgrammestreamAffiliateddepartmentts)
                    .HasForeignKey(d => d.Affiliateddepartmenttid)
                    .HasConstraintName("DEPARTMENTPROGRAMMESTR46");

                entity.HasOne(d => d.Calendar)
                    .WithMany(p => p.Programmestreams)
                    .HasForeignKey(d => d.Calendarid)
                    .HasConstraintName("CALENDARPROGRAMMESTREAM");

                entity.HasOne(d => d.College)
                    .WithMany(p => p.Programmestreams)
                    .HasForeignKey(d => d.Collegeid)
                    .HasConstraintName("COLLEGEPROGRAMMESTREAM");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.ProgrammestreamDepartments)
                    .HasForeignKey(d => d.Departmentid)
                    .HasConstraintName("DEPARTMENTPROGRAMMESTREAM");

                entity.HasOne(d => d.Faculty)
                    .WithMany(p => p.Programmestreams)
                    .HasForeignKey(d => d.Facultyid)
                    .HasConstraintName("FACULTYPROGRAMMESTREAM");

                entity.HasOne(d => d.Grading)
                    .WithMany(p => p.Programmestreams)
                    .HasForeignKey(d => d.Gradingid)
                    .HasConstraintName("GRADINGSYSTEMPROGRAMMESTREAM");

                entity.HasOne(d => d.Programme)
                    .WithMany(p => p.Programmestreams)
                    .HasForeignKey(d => d.Programmeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PROGRAMMEPROGRAMMESTREAM");

                entity.HasOne(d => d.Resitcategory)
                    .WithMany(p => p.Programmestreams)
                    .HasForeignKey(d => d.Resitcategoryid)
                    .HasConstraintName("FK_RESITCATEGORY_PROGRAMMESTREAM");

                entity.HasOne(d => d.Resittemplate)
                    .WithMany(p => p.Programmestreams)
                    .HasForeignKey(d => d.Resittemplateid)
                    .HasConstraintName("FK_RESITTEMPLATE_PROGRAMMESTREAM");

                entity.HasOne(d => d.Timestream)
                    .WithMany(p => p.Programmestreams)
                    .HasForeignKey(d => d.Timestreamid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TIMESTREAMPROGRAMMESTREAM");

                entity.HasOne(d => d.Wsitem)
                    .WithMany(p => p.Programmestreams)
                    .HasForeignKey(d => d.Wsitemid)
                    .HasConstraintName("FK_WSITEM_PROGRAMMESTREAM");
            });

            modelBuilder.Entity<Programmestreamgroup>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("PROGRAMMESTREAMGROUP");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.Unitid).HasColumnName("UNITID");
            });

            modelBuilder.Entity<Programmestreamgroupdetail>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Programmestreamid })
                    .IsClustered(false);

                entity.ToTable("PROGRAMMESTREAMGROUPDETAIL");

                entity.HasIndex(e => e.Programmestreamid, "missing_index_86");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.Programmestreamgroupdetails)
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PROGRAMMESTREAMGROUPPROGRAMMESTREAMGROUPDETAIL");

                entity.HasOne(d => d.Programmestream)
                    .WithMany(p => p.Programmestreamgroupdetails)
                    .HasForeignKey(d => d.Programmestreamid)
                    .HasConstraintName("FK_PROGRAMMESTREAMGROUPDETAIL_PROGRAMMESTREAM");
            });

            modelBuilder.Entity<Programmestreamgroupfeecategory>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Feecategoryid });

                entity.ToTable("PROGRAMMESTREAMGROUPFEECATEGORY");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Feecategoryid).HasColumnName("FEECATEGORYID");

                entity.HasOne(d => d.Feecategory)
                    .WithMany(p => p.Programmestreamgroupfeecategories)
                    .HasForeignKey(d => d.Feecategoryid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FEECATEGORY_PROGRAMMESTREAMGROUPFEECATEGORY");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.Programmestreamgroupfeecategories)
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROGRAMMESTREAMGROUP_PROGRAMMESTREAMGROUPFEECATEGORY");
            });

            modelBuilder.Entity<Programmestreamgroupuser>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Userid })
                    .IsClustered(false);

                entity.ToTable("PROGRAMMESTREAMGROUPUSER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Userid)
                    .HasMaxLength(128)
                    .HasColumnName("USERID");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.Programmestreamgroupusers)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("PROGRAMMESTREAMGROUPPROGRAMMESTREAMGROUPUSER");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Programmestreamgroupusers)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASPNETUSERS_PROGRAMMESTREAMGROUPUSER");
            });

            modelBuilder.Entity<Programmestreampaymentblock>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PROGRAMMESTREAMPAYMENTBLOCK");

                entity.Property(e => e.Admissionoffercategoryid).HasColumnName("ADMISSIONOFFERCATEGORYID");

                entity.Property(e => e.Feecategoryid).HasColumnName("FEECATEGORYID");

                entity.Property(e => e.Isblocked)
                    .IsRequired()
                    .HasColumnName("ISBLOCKED")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Programmestreamwithsecondtieradmission>(entity =>
            {
                entity.HasKey(e => e.Programmestreamidstart)
                    .HasName("PK_PROGRAMMESTREAMINTWOTIERADMISSION");

                entity.ToTable("PROGRAMMESTREAMWITHSECONDTIERADMISSION");

                entity.Property(e => e.Programmestreamidstart)
                    .ValueGeneratedNever()
                    .HasColumnName("PROGRAMMESTREAMIDSTART");

                entity.Property(e => e.Programmestreamidend).HasColumnName("PROGRAMMESTREAMIDEND");
            });

            modelBuilder.Entity<Receiptsetting>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("RECEIPTSETTING");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Increment).HasColumnName("INCREMENT");

                entity.Property(e => e.Prefix)
                    .HasMaxLength(10)
                    .HasColumnName("PREFIX");

                entity.Property(e => e.Seed).HasColumnName("SEED");

                entity.Property(e => e.Suffix)
                    .HasMaxLength(10)
                    .HasColumnName("SUFFIX");
            });

            modelBuilder.Entity<Refundtype>(entity =>
            {
                entity.ToTable("REFUNDTYPE");

                entity.Property(e => e.Refundtypeid).HasColumnName("REFUNDTYPEID");

                entity.Property(e => e.Refundtype1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("REFUNDTYPE");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.HasKey(e => e.Regionid)
                    .IsClustered(false);

                entity.ToTable("REGION");

                entity.Property(e => e.Regionid)
                    .ValueGeneratedNever()
                    .HasColumnName("REGIONID");

                entity.Property(e => e.Countryid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("COUNTRYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("NAME");

                entity.Property(e => e.Shortcode)
                    .HasMaxLength(10)
                    .HasColumnName("SHORTCODE");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Regions)
                    .HasForeignKey(d => d.Countryid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("COUNTRYREGION");
            });

            modelBuilder.Entity<Registeredcoursesview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("REGISTEREDCOURSESVIEW");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Credit).HasColumnName("CREDIT");

                entity.Property(e => e.Grade)
                    .HasMaxLength(2)
                    .HasColumnName("GRADE");

                entity.Property(e => e.Programme)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("PROGRAMME");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Totalmark).HasColumnName("TOTALMARK");
            });

            modelBuilder.Entity<Religion>(entity =>
            {
                entity.HasKey(e => e.Religionid)
                    .IsClustered(false);

                entity.ToTable("RELIGION");

                entity.Property(e => e.Religionid).HasColumnName("RELIGIONID");

                entity.Property(e => e.Name)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<Reportviewlog>(entity =>
            {
                entity.ToTable("REPORTVIEWLOG");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Actiontime)
                    .HasColumnType("datetime")
                    .HasColumnName("ACTIONTIME");

                entity.Property(e => e.Reportname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("REPORTNAME");

                entity.Property(e => e.Txtdata)
                    .HasMaxLength(100)
                    .HasColumnName("TXTDATA");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<Residence>(entity =>
            {
                entity.HasKey(e => e.Residenceid)
                    .IsClustered(false);

                entity.ToTable("RESIDENCE");

                entity.Property(e => e.Residenceid).HasColumnName("RESIDENCEID");

                entity.Property(e => e.Altresidenceid).HasColumnName("ALTRESIDENCEID");

                entity.Property(e => e.Gender)
                    .HasMaxLength(2)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Istraditional).HasColumnName("ISTRADITIONAL");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.Oncampus).HasColumnName("ONCAMPUS");
            });

            modelBuilder.Entity<Residencebooking>(entity =>
            {
                entity.ToTable("RESIDENCEBOOKING", "res");

                entity.HasIndex(e => new { e.Studentid, e.Acadyear }, "AK_RESIDENCEBOOKING")
                    .IsUnique();

                entity.HasIndex(e => e.Bookingtypeid, "IX_RESIDENCEBOOKING_BOOKINGTYPEID");

                entity.HasIndex(e => e.Studentid, "IX_RESIDENCEBOOKING_STUDENTID");

                entity.HasIndex(e => e.Acadyear, "missing_index_15");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Bookingcode).HasColumnName("BOOKINGCODE");

                entity.Property(e => e.Bookingdeadline)
                    .HasColumnType("datetime")
                    .HasColumnName("BOOKINGDEADLINE");

                entity.Property(e => e.Bookingtypeid).HasColumnName("BOOKINGTYPEID");

                entity.Property(e => e.Flag).HasColumnName("FLAG");

                entity.Property(e => e.Insertedby)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Ispaid).HasColumnName("ISPAID");

                entity.Property(e => e.Isreserved).HasColumnName("ISRESERVED");

                entity.Property(e => e.Residenceid).HasColumnName("RESIDENCEID");

                entity.Property(e => e.Roomno)
                    .HasMaxLength(10)
                    .HasColumnName("ROOMNO");

                entity.Property(e => e.Roomno2)
                    .HasMaxLength(50)
                    .HasColumnName("ROOMNO2");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.HasOne(d => d.Bookingtype)
                    .WithMany(p => p.Residencebookings)
                    .HasForeignKey(d => d.Bookingtypeid)
                    .HasConstraintName("FK_BOOKINGTYPE_RESIDENCEBOOKING");

                entity.HasOne(d => d.Residence)
                    .WithMany(p => p.Residencebookings)
                    .HasForeignKey(d => d.Residenceid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RESIDENCE_RESIDENCEBOOKING");
            });

            modelBuilder.Entity<ResidencebookingBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RESIDENCEBOOKING_BACKUP", "res");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Action)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACTION")
                    .IsFixedLength(true);

                entity.Property(e => e.Bookingcode).HasColumnName("BOOKINGCODE");

                entity.Property(e => e.Bookingdeadline)
                    .HasColumnType("datetime")
                    .HasColumnName("BOOKINGDEADLINE");

                entity.Property(e => e.Bookingtypeid).HasColumnName("BOOKINGTYPEID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Ispaid).HasColumnName("ISPAID");

                entity.Property(e => e.Isreserved).HasColumnName("ISRESERVED");

                entity.Property(e => e.Residenceid).HasColumnName("RESIDENCEID");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");
            });

            modelBuilder.Entity<Residencebookingexception>(entity =>
            {
                entity.ToTable("RESIDENCEBOOKINGEXCEPTION", "res");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasColumnName("USERNAME")
                    .HasDefaultValueSql("(suser_sname())");
            });

            modelBuilder.Entity<Residencebookinglog>(entity =>
            {
                entity.HasKey(e => e.Logid);

                entity.ToTable("RESIDENCEBOOKINGLOG", "res");

                entity.Property(e => e.Logid).HasColumnName("LOGID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Actiontaken)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACTIONTAKEN")
                    .IsFixedLength(true);

                entity.Property(e => e.Actiontime)
                    .HasColumnType("datetime")
                    .HasColumnName("ACTIONTIME");

                entity.Property(e => e.Bookingcode).HasColumnName("BOOKINGCODE");

                entity.Property(e => e.Clientnetaddress)
                    .HasMaxLength(100)
                    .HasColumnName("CLIENTNETADDRESS");

                entity.Property(e => e.Fieldmodified)
                    .HasMaxLength(50)
                    .HasColumnName("FIELDMODIFIED");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(25)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Ispaid).HasColumnName("ISPAID");

                entity.Property(e => e.Isreserved).HasColumnName("ISRESERVED");

                entity.Property(e => e.Newvalue)
                    .HasMaxLength(50)
                    .HasColumnName("NEWVALUE");

                entity.Property(e => e.Oldvalue)
                    .HasMaxLength(50)
                    .HasColumnName("OLDVALUE");

                entity.Property(e => e.Residenceid).HasColumnName("RESIDENCEID");

                entity.Property(e => e.Roomno)
                    .HasMaxLength(10)
                    .HasColumnName("ROOMNO");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<Residencebookingtype>(entity =>
            {
                entity.HasKey(e => e.Bookingtypeid)
                    .HasName("PK_RESIDENCEAPPLICATIONTYPE");

                entity.ToTable("RESIDENCEBOOKINGTYPE", "res");

                entity.HasIndex(e => e.Bookingtypename, "UQ__RESIDENC__685628C3B54048BF")
                    .IsUnique();

                entity.Property(e => e.Bookingtypeid)
                    .ValueGeneratedNever()
                    .HasColumnName("BOOKINGTYPEID");

                entity.Property(e => e.Bookingtypename)
                    .HasMaxLength(100)
                    .HasColumnName("BOOKINGTYPENAME");
            });

            modelBuilder.Entity<Residenceprogrammestream>(entity =>
            {
                entity.ToTable("RESIDENCEPROGRAMMESTREAM", "res");

                entity.HasIndex(e => new { e.Residenceid, e.Programmestreamid }, "IX_RESIDENCEPROGRAMMESTREAM")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Residenceid).HasColumnName("RESIDENCEID");
            });

            modelBuilder.Entity<Residencequotalog>(entity =>
            {
                entity.ToTable("RESIDENCEQUOTALOG");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Actiontaken)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACTIONTAKEN")
                    .IsFixedLength(true);

                entity.Property(e => e.Actiontime)
                    .HasColumnType("datetime")
                    .HasColumnName("ACTIONTIME");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GENDER")
                    .IsFixedLength(true);

                entity.Property(e => e.Newvalue).HasColumnName("NEWVALUE");

                entity.Property(e => e.Oldvalue).HasColumnName("OLDVALUE");

                entity.Property(e => e.Residence)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("RESIDENCE");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<Residencequotum>(entity =>
            {
                entity.HasKey(e => new { e.Residenceid, e.Gender });

                entity.ToTable("RESIDENCEQUOTA");

                entity.Property(e => e.Residenceid).HasColumnName("RESIDENCEID");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GENDER")
                    .IsFixedLength(true);

                entity.Property(e => e.Blocked).HasColumnName("BLOCKED");

                entity.Property(e => e.Quota).HasColumnName("QUOTA");

                entity.Property(e => e.Timeupdated).HasColumnName("TIMEUPDATED");

                entity.Property(e => e.Tol).HasColumnName("TOL");
            });

            modelBuilder.Entity<Residencesetting>(entity =>
            {
                entity.ToTable("RESIDENCESETTINGS", "res");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Bedsreserved).HasColumnName("BEDSRESERVED");

                entity.Property(e => e.Reservedbedspergender).HasColumnName("RESERVEDBEDSPERGENDER");
            });

            modelBuilder.Entity<Residentialbilllog>(entity =>
            {
                entity.ToTable("RESIDENTIALBILLLOG");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Actiontaken)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ACTIONTAKEN")
                    .IsFixedLength(true);

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("COMMENT");

                entity.Property(e => e.Datetimeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("DATETIMEINSERTED");

                entity.Property(e => e.Insertedby)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Issuccessful).HasColumnName("ISSUCCESSFUL");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<Residentialcountlog>(entity =>
            {
                entity.ToTable("RESIDENTIALCOUNTLOG");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Number).HasColumnName("NUMBER");

                entity.Property(e => e.Residence)
                    .HasMaxLength(50)
                    .HasColumnName("RESIDENCE");

                entity.Property(e => e.Timeinserted)
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasColumnName("USERNAME")
                    .HasDefaultValueSql("(suser_sname())");
            });

            modelBuilder.Entity<Residentialloginlog>(entity =>
            {
                entity.ToTable("RESIDENTIALLOGINLOG");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Pin)
                    .HasMaxLength(50)
                    .HasColumnName("PIN");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(50)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasColumnName("USERNAME")
                    .HasDefaultValueSql("(suser_sname())");
            });

            modelBuilder.Entity<Resit2020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RESIT2020");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Trailcount).HasColumnName("TRAILCOUNT");

                entity.Property(e => e.Trails)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("TRAILS");
            });

            modelBuilder.Entity<Resit2020rev1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RESIT2020rev1");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Trailcount).HasColumnName("TRAILCOUNT");

                entity.Property(e => e.Trails)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("TRAILS");
            });

            modelBuilder.Entity<Resit2020rev2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RESIT2020rev2");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Trailcount).HasColumnName("TRAILCOUNT");

                entity.Property(e => e.Trails)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("TRAILS");
            });

            modelBuilder.Entity<Resit2020rev3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RESIT2020rev3");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Trailcount).HasColumnName("TRAILCOUNT");

                entity.Property(e => e.Trails)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("TRAILS");
            });

            modelBuilder.Entity<Resitcategory>(entity =>
            {
                entity.HasKey(e => e.Resitcategoryid)
                    .IsClustered(false);

                entity.ToTable("RESITCATEGORY");

                entity.Property(e => e.Resitcategoryid).HasColumnName("RESITCATEGORYID");

                entity.Property(e => e.Resitcategoryname)
                    .HasMaxLength(100)
                    .HasColumnName("RESITCATEGORYNAME");
            });

            modelBuilder.Entity<Resitfeecategorymapping>(entity =>
            {
                entity.HasKey(e => new { e.Resitcategoryid, e.Feecategoryid, e.Resittemplateid })
                    .IsClustered(false);

                entity.ToTable("RESITFEECATEGORYMAPPING");

                entity.Property(e => e.Resitcategoryid).HasColumnName("RESITCATEGORYID");

                entity.Property(e => e.Feecategoryid).HasColumnName("FEECATEGORYID");

                entity.Property(e => e.Resittemplateid).HasColumnName("RESITTEMPLATEID");

                entity.Property(e => e.Ispercentage).HasColumnName("ISPERCENTAGE");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("NAME");

                entity.Property(e => e.Resitamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("RESITAMOUNT");

                entity.Property(e => e.Supamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("SUPAMOUNT");

                entity.HasOne(d => d.Feecategory)
                    .WithMany(p => p.Resitfeecategorymappings)
                    .HasForeignKey(d => d.Feecategoryid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FEECATEGORY_RESITFEECATEGORYMAPPING");

                entity.HasOne(d => d.Resitcategory)
                    .WithMany(p => p.Resitfeecategorymappings)
                    .HasForeignKey(d => d.Resitcategoryid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RESITCATEGORY_RESITFEECATEGORYMAPPING");

                entity.HasOne(d => d.Resittemplate)
                    .WithMany(p => p.Resitfeecategorymappings)
                    .HasForeignKey(d => d.Resittemplateid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RESITTEMPLATE_RESITFEECATEGORYMAPPING");
            });

            modelBuilder.Entity<Resittemplate>(entity =>
            {
                entity.ToTable("RESITTEMPLATE");

                entity.Property(e => e.Resittemplateid).HasColumnName("RESITTEMPLATEID");

                entity.Property(e => e.Resittemplatename)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("RESITTEMPLATENAME");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.HasKey(e => e.RoomId)
                    .IsClustered(false);

                entity.ToTable("Room", "tt");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Notes).HasColumnType("ntext");

                entity.Property(e => e.RoomLabel).HasMaxLength(10);

                entity.Property(e => e.RoomLocation).HasMaxLength(100);

                entity.Property(e => e.RoomName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.RoomNumber).HasMaxLength(10);

                entity.HasOne(d => d.BuildingFloor)
                    .WithMany(p => p.Rooms)
                    .HasForeignKey(d => d.BuildingFloorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Room_BuildingLevel");

                entity.HasOne(d => d.College)
                    .WithMany(p => p.Rooms)
                    .HasForeignKey(d => d.CollegeId)
                    .HasConstraintName("FK_Room_College");

                entity.HasOne(d => d.Faculty)
                    .WithMany(p => p.Rooms)
                    .HasForeignKey(d => d.FacultyId)
                    .HasConstraintName("FK_Room_Faculty");

                entity.HasOne(d => d.FloorType)
                    .WithMany(p => p.Rooms)
                    .HasForeignKey(d => d.FloorTypeId)
                    .HasConstraintName("FK_Room_FloorType");
            });

            modelBuilder.Entity<Roombookingstore>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("roombookingstore");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Bookingcode).HasColumnName("BOOKINGCODE");

                entity.Property(e => e.Bookingdeadline)
                    .HasColumnType("datetime")
                    .HasColumnName("BOOKINGDEADLINE");

                entity.Property(e => e.Bookingtypeid).HasColumnName("BOOKINGTYPEID");

                entity.Property(e => e.Flag).HasColumnName("FLAG");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Ispaid).HasColumnName("ISPAID");

                entity.Property(e => e.Isreserved).HasColumnName("ISRESERVED");

                entity.Property(e => e.Residenceid).HasColumnName("RESIDENCEID");

                entity.Property(e => e.Roomno)
                    .HasMaxLength(10)
                    .HasColumnName("ROOMNO");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");
            });

            modelBuilder.Entity<Roombookingstore2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("roombookingstore2");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Altresidenceid).HasColumnName("ALTRESIDENCEID");

                entity.Property(e => e.Bookingcode).HasColumnName("BOOKINGCODE");

                entity.Property(e => e.Bookingdate)
                    .HasColumnType("datetime")
                    .HasColumnName("BOOKINGDATE");

                entity.Property(e => e.Bookingdeadline)
                    .HasColumnType("datetime")
                    .HasColumnName("BOOKINGDEADLINE");

                entity.Property(e => e.Bookingtypeid).HasColumnName("BOOKINGTYPEID");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Ispaid).HasColumnName("ISPAID");

                entity.Property(e => e.Isreserved).HasColumnName("ISRESERVED");

                entity.Property(e => e.Othername)
                    .HasMaxLength(50)
                    .HasColumnName("OTHERNAME");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Residence)
                    .HasMaxLength(100)
                    .HasColumnName("RESIDENCE");

                entity.Property(e => e.Residenceid).HasColumnName("RESIDENCEID");

                entity.Property(e => e.Roomno)
                    .HasMaxLength(10)
                    .HasColumnName("ROOMNO");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("SURNAME");
            });

            modelBuilder.Entity<Roombookingstore3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("roombookingstore3");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Altresidenceid).HasColumnName("ALTRESIDENCEID");

                entity.Property(e => e.Bookingcode).HasColumnName("BOOKINGCODE");

                entity.Property(e => e.Bookingdate)
                    .HasColumnType("datetime")
                    .HasColumnName("BOOKINGDATE");

                entity.Property(e => e.Bookingdeadline)
                    .HasColumnType("datetime")
                    .HasColumnName("BOOKINGDEADLINE");

                entity.Property(e => e.Bookingtypeid).HasColumnName("BOOKINGTYPEID");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Ispaid).HasColumnName("ISPAID");

                entity.Property(e => e.Isreserved).HasColumnName("ISRESERVED");

                entity.Property(e => e.Othername)
                    .HasMaxLength(50)
                    .HasColumnName("OTHERNAME");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Residence)
                    .HasMaxLength(100)
                    .HasColumnName("RESIDENCE");

                entity.Property(e => e.Residenceid).HasColumnName("RESIDENCEID");

                entity.Property(e => e.Roomno)
                    .HasMaxLength(10)
                    .HasColumnName("ROOMNO");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("SURNAME");
            });

            modelBuilder.Entity<RoompaymentDel>(entity =>
            {
                entity.ToTable("ROOMPAYMENT_del");

                entity.HasIndex(e => e.Residenceid, "missing_index_343");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.Bankname)
                    .HasMaxLength(100)
                    .HasColumnName("BANKNAME");

                entity.Property(e => e.Branchname)
                    .HasMaxLength(100)
                    .HasColumnName("BRANCHNAME");

                entity.Property(e => e.Currencyid)
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID");

                entity.Property(e => e.Financeid)
                    .HasMaxLength(50)
                    .HasColumnName("FINANCEID");

                entity.Property(e => e.Ismanual)
                    .IsRequired()
                    .HasColumnName("ISMANUAL")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Residenceid).HasColumnName("RESIDENCEID");

                entity.Property(e => e.Roomno)
                    .HasMaxLength(50)
                    .HasColumnName("ROOMNO");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Transactionid)
                    .HasMaxLength(50)
                    .HasColumnName("TRANSACTIONID");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");

                entity.Property(e => e.Wspaymentid).HasColumnName("WSPAYMENTID");
            });

            modelBuilder.Entity<RoomreservationDel>(entity =>
            {
                entity.ToTable("ROOMRESERVATION_del");

                entity.HasIndex(e => e.Residenceid, "IX_ROOMRESERVATION2");

                entity.HasIndex(e => e.Studentid, "missing_index_71");

                entity.HasIndex(e => e.Residenceid, "missing_index_73");

                entity.HasIndex(e => new { e.Residenceid, e.Transdate }, "missing_index_83");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.Bankname)
                    .HasMaxLength(100)
                    .HasColumnName("BANKNAME");

                entity.Property(e => e.Branchname)
                    .HasMaxLength(100)
                    .HasColumnName("BRANCHNAME");

                entity.Property(e => e.Currencyid)
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID");

                entity.Property(e => e.Ismanual)
                    .IsRequired()
                    .HasColumnName("ISMANUAL")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Residenceid).HasColumnName("RESIDENCEID");

                entity.Property(e => e.Roomno)
                    .HasMaxLength(50)
                    .HasColumnName("ROOMNO");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Transactionid)
                    .HasMaxLength(50)
                    .HasColumnName("TRANSACTIONID");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");
            });

            modelBuilder.Entity<Scholarshiptype>(entity =>
            {
                entity.ToTable("SCHOLARSHIPTYPE");

                entity.Property(e => e.Scholarshiptypeid).HasColumnName("SCHOLARSHIPTYPEID");

                entity.Property(e => e.Scholarshiptype1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SCHOLARSHIPTYPE");
            });

            modelBuilder.Entity<Semester>(entity =>
            {
                entity.HasKey(e => new { e.Acadyear, e.Sem })
                    .IsClustered(false);

                entity.ToTable("SEMESTER");

                entity.HasIndex(e => new { e.Acadyear, e.Sem }, "CI_SEMESTER")
                    .IsClustered();

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Islocked)
                    .IsRequired()
                    .HasColumnName("ISLOCKED")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.SemNavigation)
                    .WithMany(p => p.Semesters)
                    .HasForeignKey(d => d.Sem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SEMESTERTYPESEMESTER");
            });

            modelBuilder.Entity<Semester1>(entity =>
            {
                entity.HasKey(e => e.SemesterId)
                    .IsClustered(false);

                entity.ToTable("Semester", "tt");

                entity.Property(e => e.SemesterName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Semestertype>(entity =>
            {
                entity.HasKey(e => e.Sem)
                    .IsClustered(false);

                entity.ToTable("SEMESTERTYPE");

                entity.Property(e => e.Sem)
                    .ValueGeneratedNever()
                    .HasColumnName("SEM");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<Sheet1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sheet1$");

                entity.Property(e => e.Serviceno).HasColumnName("SERVICENO");
            });

            modelBuilder.Entity<Shssurvey>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SHSSURVEY");

                entity.Property(e => e.Emp)
                    .HasMaxLength(50)
                    .HasColumnName("EMP");

                entity.Property(e => e.Endyear)
                    .HasMaxLength(10)
                    .HasColumnName("ENDYEAR")
                    .IsFixedLength(true);

                entity.Property(e => e.Entyear)
                    .HasMaxLength(10)
                    .HasColumnName("ENTYEAR")
                    .IsFixedLength(true);

                entity.Property(e => e.Reg1)
                    .HasMaxLength(50)
                    .HasColumnName("REG1");

                entity.Property(e => e.Reg2)
                    .HasMaxLength(50)
                    .HasColumnName("REG2");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(50)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<Smsbroadcastlist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SMSBROADCASTLIST");

                entity.HasIndex(e => new { e.Messageid, e.Studentid }, "UK_STUDENT_MESSAGE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Isqueued).HasColumnName("ISQUEUED");

                entity.Property(e => e.Messageid).HasColumnName("MESSAGEID");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.Timequeued).HasColumnName("TIMEQUEUED");

                entity.HasOne(d => d.Message)
                    .WithMany()
                    .HasForeignKey(d => d.Messageid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SMSBROADCASTLIST_SMSBROADCASTMESSAGE");

                entity.HasOne(d => d.Student)
                    .WithMany()
                    .HasForeignKey(d => d.Studentid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SMSBROADCASTLIST_STUDENT");
            });

            modelBuilder.Entity<Smsbroadcastmessage>(entity =>
            {
                entity.HasKey(e => e.Messageid);

                entity.ToTable("SMSBROADCASTMESSAGE");

                entity.Property(e => e.Messageid).HasColumnName("MESSAGEID");

                entity.Property(e => e.Insertedby)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");

                entity.Property(e => e.Messagebody)
                    .IsRequired()
                    .HasColumnName("MESSAGEBODY");

                entity.Property(e => e.Timeinserted)
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(sysdatetime())");
            });

            modelBuilder.Entity<Smscategoryid>(entity =>
            {
                entity.HasKey(e => e.Smscategoryid1);

                entity.ToTable("SMSCATEGORYID");

                entity.Property(e => e.Smscategoryid1).HasColumnName("SMSCATEGORYID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.Studentid)
                    .IsClustered(false);

                entity.ToTable("STUDENT");

                entity.HasIndex(e => new { e.Surname, e.Othername }, "IX_STUDENT1");

                entity.HasIndex(e => new { e.Phone, e.Acadyearenrolled }, "IX_STUDENT2");

                entity.HasIndex(e => e.Gender, "IX_STUDENT_GENDER");

                entity.HasIndex(e => new { e.Birthdate, e.Studentid }, "_dta_index_STUDENT_11_756197744__K12_K1_2_3");

                entity.HasIndex(e => e.Studentid, "_dta_index_STUDENT_11_756197744__K1_2_3_4_5_7_12_13_17_22_23_25");

                entity.HasIndex(e => new { e.Studentid, e.Programmestreamid }, "_dta_index_STUDENT_c_11_756197744__K1_K60")
                    .IsClustered();

                entity.HasIndex(e => new { e.Schoolemail, e.Schoolpwd }, "missing_index_26");

                entity.HasIndex(e => e.Acadyearenrolled, "missing_index_9");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Acadyearenrolled).HasColumnName("ACADYEARENROLLED");

                entity.Property(e => e.Affiliateid)
                    .HasMaxLength(20)
                    .HasColumnName("AFFILIATEID");

                entity.Property(e => e.Bal)
                    .HasColumnType("money")
                    .HasColumnName("BAL");

                entity.Property(e => e.Birthcountryid)
                    .HasMaxLength(3)
                    .HasColumnName("BIRTHCOUNTRYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Birthdate)
                    .HasColumnType("date")
                    .HasColumnName("BIRTHDATE");

                entity.Property(e => e.Birthtown)
                    .HasMaxLength(100)
                    .HasColumnName("BIRTHTOWN");

                entity.Property(e => e.Countryid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("COUNTRYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Currencyid)
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID");

                entity.Property(e => e.Currentresidenceid).HasColumnName("CURRENTRESIDENCEID");

                entity.Property(e => e.Delme).HasColumnName("DELME");

                entity.Property(e => e.Denomination)
                    .HasMaxLength(100)
                    .HasColumnName("DENOMINATION");

                entity.Property(e => e.Denominationid).HasColumnName("DENOMINATIONID");

                entity.Property(e => e.Disability)
                    .HasMaxLength(50)
                    .HasColumnName("DISABILITY");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Feecategoryid).HasColumnName("FEECATEGORYID");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Guardianaddress)
                    .HasMaxLength(100)
                    .HasColumnName("GUARDIANADDRESS");

                entity.Property(e => e.Guardianemail)
                    .HasMaxLength(50)
                    .HasColumnName("GUARDIANEMAIL");

                entity.Property(e => e.Guardianname)
                    .HasMaxLength(100)
                    .HasColumnName("GUARDIANNAME");

                entity.Property(e => e.Guardianoccupation)
                    .HasMaxLength(100)
                    .HasColumnName("GUARDIANOCCUPATION");

                entity.Property(e => e.Guardianphone)
                    .HasMaxLength(50)
                    .HasColumnName("GUARDIANPHONE");

                entity.Property(e => e.Guardianrelationship)
                    .HasMaxLength(100)
                    .HasColumnName("GUARDIANRELATIONSHIP");

                entity.Property(e => e.Insertedby)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.Isforeigner).HasColumnName("ISFOREIGNER");

                entity.Property(e => e.Islessendowed).HasColumnName("ISLESSENDOWED");

                entity.Property(e => e.Islocked).HasColumnName("ISLOCKED");

                entity.Property(e => e.Linkedinurl).HasColumnName("LINKEDINURL");

                entity.Property(e => e.Logincreated).HasColumnName("LOGINCREATED");

                entity.Property(e => e.Logincreateerror)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("LOGINCREATEERROR");

                entity.Property(e => e.Maritalstatusid).HasColumnName("MARITALSTATUSID");

                entity.Property(e => e.Othername)
                    .HasMaxLength(50)
                    .HasColumnName("OTHERNAME");

                entity.Property(e => e.Passportno)
                    .HasMaxLength(20)
                    .HasColumnName("PASSPORTNO");

                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Phonecountrycode)
                    .HasMaxLength(5)
                    .HasColumnName("PHONECOUNTRYCODE");

                entity.Property(e => e.Picture).HasColumnName("PICTURE");

                entity.Property(e => e.Placeofresidenceid).HasColumnName("PLACEOFRESIDENCEID");

                entity.Property(e => e.Postadd1)
                    .HasMaxLength(300)
                    .HasColumnName("POSTADD1");

                entity.Property(e => e.Postadd2)
                    .HasMaxLength(200)
                    .HasColumnName("POSTADD2");

                entity.Property(e => e.Postadd3)
                    .HasMaxLength(100)
                    .HasColumnName("POSTADD3");

                entity.Property(e => e.Postadd4)
                    .HasMaxLength(100)
                    .HasColumnName("POSTADD4");

                entity.Property(e => e.Primarymobile)
                    .HasMaxLength(20)
                    .HasColumnName("PRIMARYMOBILE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Regionid).HasColumnName("REGIONID");

                entity.Property(e => e.Religionid).HasColumnName("RELIGIONID");

                entity.Property(e => e.Resadd1)
                    .HasMaxLength(300)
                    .HasColumnName("RESADD1");

                entity.Property(e => e.Resadd2)
                    .HasMaxLength(200)
                    .HasColumnName("RESADD2");

                entity.Property(e => e.Resadd3)
                    .HasMaxLength(100)
                    .HasColumnName("RESADD3");

                entity.Property(e => e.Resadd4)
                    .HasMaxLength(100)
                    .HasColumnName("RESADD4");

                entity.Property(e => e.Rescountryid)
                    .HasMaxLength(3)
                    .HasColumnName("RESCOUNTRYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Residenceid).HasColumnName("RESIDENCEID");

                entity.Property(e => e.Resregionid).HasColumnName("RESREGIONID");

                entity.Property(e => e.Schoolemail)
                    .HasMaxLength(100)
                    .HasColumnName("SCHOOLEMAIL");

                entity.Property(e => e.Schoolmobile)
                    .HasMaxLength(20)
                    .HasColumnName("SCHOOLMOBILE");

                entity.Property(e => e.Schoolmobileserialno)
                    .HasMaxLength(20)
                    .HasColumnName("SCHOOLMOBILESERIALNO");

                entity.Property(e => e.Schoolpwd)
                    .HasMaxLength(50)
                    .HasColumnName("SCHOOLPWD");

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Sourcerowguid).HasColumnName("SOURCEROWGUID");

                entity.Property(e => e.Sourcerowid).HasColumnName("SOURCEROWID");

                entity.Property(e => e.Ssn)
                    .HasMaxLength(100)
                    .HasColumnName("SSN");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("SURNAME");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Titleid).HasColumnName("TITLEID");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(100)
                    .HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.Placeofresidence)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.Placeofresidenceid)
                    .HasConstraintName("FK_STUDENT_PLACEOFRESIDENCE");

                entity.HasOne(d => d.Religion)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.Religionid)
                    .HasConstraintName("FK_STUDENT_RELIGION");

                entity.HasOne(d => d.Residence)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.Residenceid)
                    .HasConstraintName("FK_STUDENT_RESIDENCE");
            });

            modelBuilder.Entity<Student20220218>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STUDENT_20220218");

                entity.Property(e => e.Acadyearenrolled).HasColumnName("ACADYEARENROLLED");

                entity.Property(e => e.Affiliateid)
                    .HasMaxLength(20)
                    .HasColumnName("AFFILIATEID");

                entity.Property(e => e.Bal)
                    .HasColumnType("money")
                    .HasColumnName("BAL");

                entity.Property(e => e.Birthcountryid)
                    .HasMaxLength(3)
                    .HasColumnName("BIRTHCOUNTRYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Birthdate)
                    .HasColumnType("date")
                    .HasColumnName("BIRTHDATE");

                entity.Property(e => e.Birthtown)
                    .HasMaxLength(100)
                    .HasColumnName("BIRTHTOWN");

                entity.Property(e => e.Countryid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("COUNTRYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Currencyid)
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID");

                entity.Property(e => e.Currentresidenceid).HasColumnName("CURRENTRESIDENCEID");

                entity.Property(e => e.Delme).HasColumnName("DELME");

                entity.Property(e => e.Denomination)
                    .HasMaxLength(100)
                    .HasColumnName("DENOMINATION");

                entity.Property(e => e.Denominationid).HasColumnName("DENOMINATIONID");

                entity.Property(e => e.Disability)
                    .HasMaxLength(50)
                    .HasColumnName("DISABILITY");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Feecategoryid).HasColumnName("FEECATEGORYID");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Guardianaddress)
                    .HasMaxLength(100)
                    .HasColumnName("GUARDIANADDRESS");

                entity.Property(e => e.Guardianemail)
                    .HasMaxLength(50)
                    .HasColumnName("GUARDIANEMAIL");

                entity.Property(e => e.Guardianname)
                    .HasMaxLength(100)
                    .HasColumnName("GUARDIANNAME");

                entity.Property(e => e.Guardianoccupation)
                    .HasMaxLength(100)
                    .HasColumnName("GUARDIANOCCUPATION");

                entity.Property(e => e.Guardianphone)
                    .HasMaxLength(50)
                    .HasColumnName("GUARDIANPHONE");

                entity.Property(e => e.Guardianrelationship)
                    .HasMaxLength(100)
                    .HasColumnName("GUARDIANRELATIONSHIP");

                entity.Property(e => e.Insertedby)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.Isforeigner).HasColumnName("ISFOREIGNER");

                entity.Property(e => e.Islessendowed).HasColumnName("ISLESSENDOWED");

                entity.Property(e => e.Islocked).HasColumnName("ISLOCKED");

                entity.Property(e => e.Logincreated).HasColumnName("LOGINCREATED");

                entity.Property(e => e.Logincreateerror)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("LOGINCREATEERROR");

                entity.Property(e => e.Maritalstatusid).HasColumnName("MARITALSTATUSID");

                entity.Property(e => e.Othername)
                    .HasMaxLength(50)
                    .HasColumnName("OTHERNAME");

                entity.Property(e => e.Passportno)
                    .HasMaxLength(20)
                    .HasColumnName("PASSPORTNO");

                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Phonecountrycode)
                    .HasMaxLength(5)
                    .HasColumnName("PHONECOUNTRYCODE");

                entity.Property(e => e.Picture).HasColumnName("PICTURE");

                entity.Property(e => e.Placeofresidenceid).HasColumnName("PLACEOFRESIDENCEID");

                entity.Property(e => e.Postadd1)
                    .HasMaxLength(300)
                    .HasColumnName("POSTADD1");

                entity.Property(e => e.Postadd2)
                    .HasMaxLength(200)
                    .HasColumnName("POSTADD2");

                entity.Property(e => e.Postadd3)
                    .HasMaxLength(100)
                    .HasColumnName("POSTADD3");

                entity.Property(e => e.Postadd4)
                    .HasMaxLength(100)
                    .HasColumnName("POSTADD4");

                entity.Property(e => e.Primarymobile)
                    .HasMaxLength(20)
                    .HasColumnName("PRIMARYMOBILE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Regionid).HasColumnName("REGIONID");

                entity.Property(e => e.Religionid).HasColumnName("RELIGIONID");

                entity.Property(e => e.Resadd1)
                    .HasMaxLength(300)
                    .HasColumnName("RESADD1");

                entity.Property(e => e.Resadd2)
                    .HasMaxLength(200)
                    .HasColumnName("RESADD2");

                entity.Property(e => e.Resadd3)
                    .HasMaxLength(100)
                    .HasColumnName("RESADD3");

                entity.Property(e => e.Resadd4)
                    .HasMaxLength(100)
                    .HasColumnName("RESADD4");

                entity.Property(e => e.Rescountryid)
                    .HasMaxLength(3)
                    .HasColumnName("RESCOUNTRYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Residenceid).HasColumnName("RESIDENCEID");

                entity.Property(e => e.Resregionid).HasColumnName("RESREGIONID");

                entity.Property(e => e.Schoolemail)
                    .HasMaxLength(100)
                    .HasColumnName("SCHOOLEMAIL");

                entity.Property(e => e.Schoolmobile)
                    .HasMaxLength(20)
                    .HasColumnName("SCHOOLMOBILE");

                entity.Property(e => e.Schoolmobileserialno)
                    .HasMaxLength(20)
                    .HasColumnName("SCHOOLMOBILESERIALNO");

                entity.Property(e => e.Schoolpwd)
                    .HasMaxLength(50)
                    .HasColumnName("SCHOOLPWD");

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Sourcerowguid).HasColumnName("SOURCEROWGUID");

                entity.Property(e => e.Sourcerowid).HasColumnName("SOURCEROWID");

                entity.Property(e => e.Ssn)
                    .HasMaxLength(100)
                    .HasColumnName("SSN");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("SURNAME");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Titleid).HasColumnName("TITLEID");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(100)
                    .HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<StudentAt>(entity =>
            {
                entity.ToTable("STUDENT_AT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Actiontaken)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("ACTIONTAKEN")
                    .IsFixedLength(true);

                entity.Property(e => e.Actiontime)
                    .HasColumnType("datetime")
                    .HasColumnName("ACTIONTIME");

                entity.Property(e => e.Clientnetaddress)
                    .HasMaxLength(255)
                    .HasColumnName("CLIENTNETADDRESS");

                entity.Property(e => e.Fieldaffected)
                    .HasMaxLength(100)
                    .HasColumnName("FIELDAFFECTED");

                entity.Property(e => e.Fielddescription)
                    .HasMaxLength(100)
                    .HasColumnName("FIELDDESCRIPTION");

                entity.Property(e => e.Hostname)
                    .HasMaxLength(100)
                    .HasColumnName("HOSTNAME");

                entity.Property(e => e.Newvalue)
                    .HasMaxLength(500)
                    .HasColumnName("NEWVALUE");

                entity.Property(e => e.Oldvalue)
                    .HasMaxLength(500)
                    .HasColumnName("OLDVALUE");

                entity.Property(e => e.Recorddata)
                    .HasMaxLength(500)
                    .HasColumnName("RECORDDATA");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<StudentBirthdate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STUDENT_BIRTHDATE");

                entity.Property(e => e.Actiontaken)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("ACTIONTAKEN")
                    .IsFixedLength(true);

                entity.Property(e => e.Actiontime)
                    .HasColumnType("datetime")
                    .HasColumnName("ACTIONTIME");

                entity.Property(e => e.Clientnetaddress)
                    .HasMaxLength(255)
                    .HasColumnName("CLIENTNETADDRESS");

                entity.Property(e => e.Fieldaffected)
                    .HasMaxLength(100)
                    .HasColumnName("FIELDAFFECTED");

                entity.Property(e => e.Fielddescription)
                    .HasMaxLength(100)
                    .HasColumnName("FIELDDESCRIPTION");

                entity.Property(e => e.Hostid).HasColumnName("HOSTID");

                entity.Property(e => e.Hostname)
                    .HasMaxLength(100)
                    .HasColumnName("HOSTNAME");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Newvalue)
                    .HasMaxLength(500)
                    .HasColumnName("NEWVALUE");

                entity.Property(e => e.Oldvalue)
                    .HasMaxLength(500)
                    .HasColumnName("OLDVALUE");

                entity.Property(e => e.Recorddata)
                    .HasMaxLength(500)
                    .HasColumnName("RECORDDATA");

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<StudentBk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STUDENT_BK");

                entity.Property(e => e.Acadyearenrolled).HasColumnName("ACADYEARENROLLED");

                entity.Property(e => e.Affiliateid)
                    .HasMaxLength(20)
                    .HasColumnName("AFFILIATEID");

                entity.Property(e => e.Birthcountryid)
                    .HasMaxLength(3)
                    .HasColumnName("BIRTHCOUNTRYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Birthdate)
                    .HasColumnType("date")
                    .HasColumnName("BIRTHDATE");

                entity.Property(e => e.Birthtown)
                    .HasMaxLength(100)
                    .HasColumnName("BIRTHTOWN");

                entity.Property(e => e.Countryid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("COUNTRYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Currentresidenceid).HasColumnName("CURRENTRESIDENCEID");

                entity.Property(e => e.Delme).HasColumnName("DELME");

                entity.Property(e => e.Denomination)
                    .HasMaxLength(100)
                    .HasColumnName("DENOMINATION");

                entity.Property(e => e.Denominationid).HasColumnName("DENOMINATIONID");

                entity.Property(e => e.Disability)
                    .HasMaxLength(50)
                    .HasColumnName("DISABILITY");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Guardianaddress)
                    .HasMaxLength(100)
                    .HasColumnName("GUARDIANADDRESS");

                entity.Property(e => e.Guardianemail)
                    .HasMaxLength(50)
                    .HasColumnName("GUARDIANEMAIL");

                entity.Property(e => e.Guardianname)
                    .HasMaxLength(100)
                    .HasColumnName("GUARDIANNAME");

                entity.Property(e => e.Guardianoccupation)
                    .HasMaxLength(100)
                    .HasColumnName("GUARDIANOCCUPATION");

                entity.Property(e => e.Guardianphone)
                    .HasMaxLength(50)
                    .HasColumnName("GUARDIANPHONE");

                entity.Property(e => e.Guardianrelationship)
                    .HasMaxLength(100)
                    .HasColumnName("GUARDIANRELATIONSHIP");

                entity.Property(e => e.Insertedby)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.Isforeigner).HasColumnName("ISFOREIGNER");

                entity.Property(e => e.Islessendowed).HasColumnName("ISLESSENDOWED");

                entity.Property(e => e.Islocked).HasColumnName("ISLOCKED");

                entity.Property(e => e.Logincreated).HasColumnName("LOGINCREATED");

                entity.Property(e => e.Logincreateerror)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("LOGINCREATEERROR");

                entity.Property(e => e.Maritalstatusid).HasColumnName("MARITALSTATUSID");

                entity.Property(e => e.Othername)
                    .HasMaxLength(50)
                    .HasColumnName("OTHERNAME");

                entity.Property(e => e.Passportno)
                    .HasMaxLength(20)
                    .HasColumnName("PASSPORTNO");

                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Phonecountrycode)
                    .HasMaxLength(5)
                    .HasColumnName("PHONECOUNTRYCODE");

                entity.Property(e => e.Picture).HasColumnName("PICTURE");

                entity.Property(e => e.Placeofresidenceid).HasColumnName("PLACEOFRESIDENCEID");

                entity.Property(e => e.Postadd1)
                    .HasMaxLength(300)
                    .HasColumnName("POSTADD1");

                entity.Property(e => e.Postadd2)
                    .HasMaxLength(200)
                    .HasColumnName("POSTADD2");

                entity.Property(e => e.Postadd3)
                    .HasMaxLength(100)
                    .HasColumnName("POSTADD3");

                entity.Property(e => e.Postadd4)
                    .HasMaxLength(100)
                    .HasColumnName("POSTADD4");

                entity.Property(e => e.Primarymobile)
                    .HasMaxLength(20)
                    .HasColumnName("PRIMARYMOBILE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Regionid).HasColumnName("REGIONID");

                entity.Property(e => e.Religionid).HasColumnName("RELIGIONID");

                entity.Property(e => e.Resadd1)
                    .HasMaxLength(300)
                    .HasColumnName("RESADD1");

                entity.Property(e => e.Resadd2)
                    .HasMaxLength(200)
                    .HasColumnName("RESADD2");

                entity.Property(e => e.Resadd3)
                    .HasMaxLength(100)
                    .HasColumnName("RESADD3");

                entity.Property(e => e.Resadd4)
                    .HasMaxLength(100)
                    .HasColumnName("RESADD4");

                entity.Property(e => e.Rescountryid)
                    .HasMaxLength(3)
                    .HasColumnName("RESCOUNTRYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Residenceid).HasColumnName("RESIDENCEID");

                entity.Property(e => e.Resregionid).HasColumnName("RESREGIONID");

                entity.Property(e => e.Schoolemail)
                    .HasMaxLength(100)
                    .HasColumnName("SCHOOLEMAIL");

                entity.Property(e => e.Schoolmobile)
                    .HasMaxLength(20)
                    .HasColumnName("SCHOOLMOBILE");

                entity.Property(e => e.Schoolmobileserialno)
                    .HasMaxLength(20)
                    .HasColumnName("SCHOOLMOBILESERIALNO");

                entity.Property(e => e.Schoolpwd)
                    .HasMaxLength(50)
                    .HasColumnName("SCHOOLPWD");

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Sourcerowguid).HasColumnName("SOURCEROWGUID");

                entity.Property(e => e.Sourcerowid).HasColumnName("SOURCEROWID");

                entity.Property(e => e.Ssn)
                    .HasMaxLength(100)
                    .HasColumnName("SSN");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("SURNAME");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Titleid).HasColumnName("TITLEID");
            });

            modelBuilder.Entity<StudentCredit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STUDENT_CREDIT");

                entity.Property(e => e.Amount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.Currencyid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Narration)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NARRATION");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");

                entity.Property(e => e.Transtype)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("TRANSTYPE");

                entity.Property(e => e.Xrate).HasColumnName("XRATE");
            });

            modelBuilder.Entity<StudentDebit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STUDENT_DEBIT");

                entity.Property(e => e.Amount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.Currencyid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Narration)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NARRATION");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");

                entity.Property(e => e.Transtype)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("TRANSTYPE");

                entity.Property(e => e.Xrate).HasColumnName("XRATE");
            });

            modelBuilder.Entity<StudentGraduationDate>(entity =>
            {
                entity.HasKey(e => e.Graduationstreamid);

                entity.ToTable("StudentGraduationDate");

                entity.Property(e => e.Graduationstreamid)
                    .ValueGeneratedNever()
                    .HasColumnName("GRADUATIONSTREAMID");

                entity.Property(e => e.College)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Graduationdate).HasColumnName("GRADUATIONDATE");

                entity.HasOne(d => d.Graduationstream)
                    .WithOne(p => p.StudentGraduationDate)
                    .HasForeignKey<StudentGraduationDate>(d => d.Graduationstreamid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentGraduationDate_GRADUATIONSTREAM");
            });

            modelBuilder.Entity<Studentacadyear>(entity =>
            {
                entity.HasKey(e => new { e.Studentid, e.Programmestreamid, e.Acadyear });

                entity.ToTable("STUDENTACADYEAR");

                entity.HasIndex(e => new { e.Studentid, e.Programmestreamid, e.Acadyear, e.Acadlevelid }, "AK_STUDENTACADYEAR")
                    .IsUnique();

                entity.HasIndex(e => e.Acadyear, "IX_STUDENTACADYEAR");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Feecategoryid).HasColumnName("FEECATEGORYID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Isactive)
                    .IsRequired()
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Txtdata)
                    .HasMaxLength(1000)
                    .HasColumnName("TXTDATA");

                entity.Property(e => e.Yr).HasColumnName("YR");

                entity.Property(e => e.Yr2).HasColumnName("YR2");

                entity.HasOne(d => d.Acadlevel)
                    .WithMany(p => p.Studentacadyears)
                    .HasForeignKey(d => d.Acadlevelid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STUDENTACADYEAR_ACADEMICLEVEL");

                entity.HasOne(d => d.Studentprogramme)
                    .WithMany(p => p.Studentacadyears)
                    .HasForeignKey(d => new { d.Studentid, d.Programmestreamid })
                    .HasConstraintName("STUDENTPROGRAMMESTUDENTACADYEAR");
            });

            modelBuilder.Entity<Studentacadyear20220218>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STUDENTACADYEAR_20220218");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Feecategoryid).HasColumnName("FEECATEGORYID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Txtdata)
                    .HasMaxLength(1000)
                    .HasColumnName("TXTDATA");

                entity.Property(e => e.Yr).HasColumnName("YR");

                entity.Property(e => e.Yr2).HasColumnName("YR2");
            });

            modelBuilder.Entity<Studentbill>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("STUDENTBILL");

                entity.HasIndex(e => new { e.Studentid, e.Programmestreamid, e.Acadyear, e.Sem }, "AK_STUDENTBILL");

                entity.HasIndex(e => e.Acadyear, "IX_STUDENTBILL");

                entity.HasIndex(e => new { e.Feetypeid, e.Residenceid }, "IX_STUDENTBILL2");

                entity.HasIndex(e => new { e.Acadyear, e.Sem }, "missing_index_104");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Autogenerated).HasColumnName("AUTOGENERATED");

                entity.Property(e => e.Currencyid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Feecategoryid).HasColumnName("FEECATEGORYID");

                entity.Property(e => e.Feetypeid).HasColumnName("FEETYPEID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("INSERTEDBY")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.Iscommitted).HasColumnName("ISCOMMITTED");

                entity.Property(e => e.Narrative)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NARRATIVE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Residenceid).HasColumnName("RESIDENCEID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Timeupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEUPDATED");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");

                entity.Property(e => e.Transdate2)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE2");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEDBY");

                entity.Property(e => e.Xrate).HasColumnName("XRATE");
            });

            modelBuilder.Entity<StudentbiometricInclusion>(entity =>
            {
                entity.HasKey(e => new { e.Studentid, e.Acadyear, e.Sem });

                entity.ToTable("STUDENTBIOMETRIC_INCLUSION");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Clientnetaddress)
                    .HasMaxLength(50)
                    .HasColumnName("CLIENTNETADDRESS");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentbiometricInclusions)
                    .HasForeignKey(d => d.Studentid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STUDENTBIOMETRIC_INCLUSION_STUDENT");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.StudentbiometricInclusions)
                    .HasForeignKey(d => new { d.Acadyear, d.Sem })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STUDENTBIOMETRIC_INCLUSION_SEMESTER");
            });

            modelBuilder.Entity<Studentbiometricverification>(entity =>
            {
                entity.HasKey(e => new { e.Studentid, e.Acadyear, e.Sem });

                entity.ToTable("STUDENTBIOMETRICVERIFICATION");

                entity.HasIndex(e => new { e.Studentid, e.Acadyear, e.Sem }, "UX_STUDENTBIOMETRICVERIFICATION_STUDENTACADYEARSEM")
                    .IsUnique();

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Clientnetaddress)
                    .HasMaxLength(50)
                    .HasColumnName("CLIENTNETADDRESS");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Studentbiometricverifications)
                    .HasForeignKey(d => d.Studentid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STUDENTBIOMETRICVERIFICATION_STUDENT");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.Studentbiometricverifications)
                    .HasForeignKey(d => new { d.Acadyear, d.Sem })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STUDENTBIOMETRICVERIFICATION_SEMESTER");
            });

            modelBuilder.Entity<StudentbiometricverificationFirsthalf>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STUDENTBIOMETRICVERIFICATION_FIRSTHALF");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Clientnetaddress)
                    .HasMaxLength(50)
                    .HasColumnName("CLIENTNETADDRESS");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");
            });

            modelBuilder.Entity<Studentblocked>(entity =>
            {
                entity.HasKey(e => e.Studentid)
                    .IsClustered(false);

                entity.ToTable("STUDENTBLOCKED");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.Isblocked)
                    .IsRequired()
                    .HasColumnName("ISBLOCKED")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("REASON");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Studentcategory>(entity =>
            {
                entity.ToTable("STUDENTCATEGORY");

                entity.Property(e => e.Studentcategoryid)
                    .ValueGeneratedNever()
                    .HasColumnName("STUDENTCATEGORYID");

                entity.Property(e => e.Studentcategoryname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("STUDENTCATEGORYNAME");
            });

            modelBuilder.Entity<Studentcheckin>(entity =>
            {
                entity.HasKey(e => new { e.Studentid, e.Acadyear, e.Sem });

                entity.ToTable("STUDENTCHECKIN");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(25)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Checkinby)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("CHECKINBY");

                entity.Property(e => e.Checkindatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("CHECKINDATETIME");
            });

            modelBuilder.Entity<Studentcovidassessment>(entity =>
            {
                entity.HasKey(e => e.CovidAssessmentId)
                    .HasName("PK_CovidAssessment");

                entity.ToTable("STUDENTCOVIDASSESSMENT");

                entity.Property(e => e.Inserted).HasColumnType("datetime");

                entity.Property(e => e.InsertedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IsMohverified).HasColumnName("IsMOHVerified");

                entity.Property(e => e.StudentId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.VaccinationCardNumber).HasMaxLength(20);

                entity.Property(e => e.VaccinationCenter).HasMaxLength(100);

                entity.Property(e => e.VaccinationDate).HasColumnType("datetime");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Studentcovidassessments)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STUDENTCOVIDASSESSMENT_STUDENT");

                entity.HasOne(d => d.VaccineType)
                    .WithMany(p => p.Studentcovidassessments)
                    .HasForeignKey(d => d.VaccineTypeId)
                    .HasConstraintName("FK_STUDENTCOVIDASSESSMENT_COVIDVACCINETYPE");
            });

            modelBuilder.Entity<Studentcredit1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STUDENTCREDIT");

                entity.Property(e => e.Amount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.Currencyid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Narration)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NARRATION");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");

                entity.Property(e => e.Transtype)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("TRANSTYPE");

                entity.Property(e => e.Xrate).HasColumnName("XRATE");
            });

            modelBuilder.Entity<Studentdebit1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STUDENTDEBIT");

                entity.Property(e => e.Amount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.Currencyid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Narration)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NARRATION");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");

                entity.Property(e => e.Transtype)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("TRANSTYPE");

                entity.Property(e => e.Xrate).HasColumnName("XRATE");
            });

            modelBuilder.Entity<Studentemailverification>(entity =>
            {
                entity.HasKey(e => e.StudentId)
                    .HasName("PK_StudentEmailVerificationCheck");

                entity.ToTable("STUDENTEMAILVERIFICATION");

                entity.Property(e => e.StudentId).HasMaxLength(20);

                entity.Property(e => e.IsEmailVerificationSent)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Studentexamcentre>(entity =>
            {
                entity.HasKey(e => e.Studentid);

                entity.ToTable("STUDENTEXAMCENTRE");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Examcentreid).HasColumnName("EXAMCENTREID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Examcentre)
                    .WithMany(p => p.Studentexamcentres)
                    .HasForeignKey(d => d.Examcentreid)
                    .HasConstraintName("FK_STUDENTEXAMCENTRE_EXAMCENTRE");
            });

            modelBuilder.Entity<Studentfeecategory>(entity =>
            {
                entity.HasKey(e => new { e.Studentid, e.Programmestreamid, e.Acadyear, e.Sem })
                    .IsClustered(false);

                entity.ToTable("STUDENTFEECATEGORY");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Comment)
                    .HasMaxLength(100)
                    .HasColumnName("COMMENT");

                entity.Property(e => e.Feecategoryid).HasColumnName("FEECATEGORYID");

                entity.Property(e => e.Insertedby)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Sourcerowguid).HasColumnName("SOURCEROWGUID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Timeupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEUPDATED");

                entity.HasOne(d => d.Feecategory)
                    .WithMany(p => p.Studentfeecategories)
                    .HasForeignKey(d => d.Feecategoryid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FEECATEGORYSTUDENTFEECATEGORY");

                entity.HasOne(d => d.Studentsemester)
                    .WithOne(p => p.Studentfeecategory)
                    .HasForeignKey<Studentfeecategory>(d => new { d.Studentid, d.Programmestreamid, d.Acadyear, d.Sem })
                    .HasConstraintName("FK_STUDENTFEECATEGORY_STUDENTSEMESTER");
            });

            modelBuilder.Entity<Studentfeeclearance>(entity =>
            {
                entity.HasKey(e => new { e.Studentid, e.Programmestreamid, e.Acadyear, e.Sem })
                    .IsClustered(false);

                entity.ToTable("STUDENTFEECLEARANCE");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Reason)
                    .HasMaxLength(200)
                    .HasColumnName("REASON");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");

                entity.HasOne(d => d.Programmestream)
                    .WithMany(p => p.Studentfeeclearances)
                    .HasForeignKey(d => d.Programmestreamid)
                    .HasConstraintName("FK_STUDENTFEECLEARANCE_PROGRAMMESTREAM");
            });

            modelBuilder.Entity<Studentfeeclearancelog>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("STUDENTFEECLEARANCELOG");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Actiontaken)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("ACTIONTAKEN");

                entity.Property(e => e.Actiontime)
                    .HasColumnType("datetime")
                    .HasColumnName("ACTIONTIME");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Reason)
                    .HasMaxLength(200)
                    .HasColumnName("REASON");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<Studentfeeexemption>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("STUDENTFEEEXEMPTION");

                entity.HasIndex(e => new { e.Studentid, e.Acadyear, e.Sem }, "IX_STUDENTFEEEXEMPTION");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Currencyid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REASON");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");

                entity.Property(e => e.Xrate).HasColumnName("XRATE");

                entity.Property(e => e.Xrate2).HasColumnName("XRATE2");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Studentfeeexemptions)
                    .HasForeignKey(d => d.Currencyid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CURRENCYSTUDENTFEEEXEMPTION");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.Studentfeeexemptions)
                    .HasForeignKey(d => new { d.Acadyear, d.Sem })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SEMESTERSTUDENTFEEEXEMPTION");

                entity.HasOne(d => d.Studentsemester)
                    .WithMany(p => p.Studentfeeexemptions)
                    .HasForeignKey(d => new { d.Studentid, d.Programmestreamid, d.Acadyear, d.Sem })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("STUDENTSEMESTERSTUDENTFEEEXEMPTION");
            });

            modelBuilder.Entity<Studentgraduationregister>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.StudentId, e.GraduationStreamId });

                entity.ToTable("STUDENTGRADUATIONREGISTER");

                entity.HasIndex(e => new { e.StudentId, e.GraduationStreamId }, "IX_STUDENTGRADUATIONREGISTER")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.StudentId).HasMaxLength(20);

                entity.Property(e => e.Created).HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.MessageSentTime).HasColumnType("datetime");

                entity.Property(e => e.VerifiedAt).HasColumnType("datetime");

                entity.Property(e => e.VerifiedBy).HasMaxLength(100);
            });

            modelBuilder.Entity<Studentgraduationregisterlog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("STUDENTGRADUATIONREGISTERLOG");

                entity.Property(e => e.ActionTaken)
                    .HasMaxLength(1)
                    .IsFixedLength(true);

                entity.Property(e => e.ActionTime).HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.ClientNetAddress).HasMaxLength(255);

                entity.Property(e => e.NewApprovalValue).HasColumnName("New_ApprovalValue");

                entity.Property(e => e.NewPictureData).HasColumnName("New_PictureData");

                entity.Property(e => e.OldApprovalValue).HasColumnName("Old_ApprovalValue");

                entity.Property(e => e.OldPictureData).HasColumnName("Old_PictureData");

                entity.Property(e => e.StudentId)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Studentidgenerator>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("STUDENTIDGENERATOR");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Autogenerate).HasColumnName("AUTOGENERATE");

                entity.Property(e => e.Increment).HasColumnName("INCREMENT");

                entity.Property(e => e.Prefix)
                    .HasMaxLength(10)
                    .HasColumnName("PREFIX");

                entity.Property(e => e.Seed).HasColumnName("SEED");

                entity.Property(e => e.Suffix)
                    .HasMaxLength(10)
                    .HasColumnName("SUFFIX");
            });

            modelBuilder.Entity<Studentledger>(entity =>
            {
                entity.ToTable("STUDENTLEDGER");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.Bal)
                    .HasColumnType("money")
                    .HasColumnName("BAL");

                entity.Property(e => e.Currencyid)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Serialnumber).HasColumnName("SERIALNUMBER");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Transactiontype)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("TRANSACTIONTYPE");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");
            });

            modelBuilder.Entity<Studentloginerror>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("STUDENTLOGINERROR");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.App)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("APP");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<Studentloginlog>(entity =>
            {
                entity.ToTable("STUDENTLOGINLOG");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.App)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("APP");

                entity.Property(e => e.Browser)
                    .HasMaxLength(200)
                    .HasColumnName("BROWSER");

                entity.Property(e => e.Clientnetaddress)
                    .HasMaxLength(50)
                    .HasColumnName("CLIENTNETADDRESS");

                entity.Property(e => e.Devicename)
                    .HasMaxLength(100)
                    .HasColumnName("DEVICENAME");

                entity.Property(e => e.Hostname)
                    .HasMaxLength(50)
                    .HasColumnName("HOSTNAME");

                entity.Property(e => e.Lastlogin)
                    .HasColumnType("datetime")
                    .HasColumnName("LASTLOGIN");

                entity.Property(e => e.Os)
                    .HasMaxLength(100)
                    .HasColumnName("OS");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<Studentmedicalexam>(entity =>
            {
                entity.HasKey(e => e.Studentid);

                entity.ToTable("STUDENTMEDICALEXAM");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<Studentoncampusverification>(entity =>
            {
                entity.HasKey(e => new { e.Studentid, e.Acadyear, e.Sem });

                entity.ToTable("STUDENTONCAMPUSVERIFICATION");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Clientnetaddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CLIENTNETADDRESS");

                entity.Property(e => e.Insertedby)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Studentoncampusverifications)
                    .HasForeignKey(d => d.Studentid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STUDENTONCAMPUSVERIFICATION_STUDENT");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.Studentoncampusverifications)
                    .HasForeignKey(d => new { d.Acadyear, d.Sem })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STUDENTONCAMPUSVERIFICATION_SEMESTER");
            });

            modelBuilder.Entity<Studentpassreset>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STUDENTPASSRESET");

                entity.Property(e => e.App)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("APP");

                entity.Property(e => e.Browser)
                    .HasMaxLength(200)
                    .HasColumnName("BROWSER");

                entity.Property(e => e.Clientnetaddress)
                    .HasMaxLength(50)
                    .HasColumnName("CLIENTNETADDRESS");

                entity.Property(e => e.Datetimeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("DATETIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Devicename)
                    .HasMaxLength(100)
                    .HasColumnName("DEVICENAME");

                entity.Property(e => e.Hostname)
                    .HasMaxLength(50)
                    .HasColumnName("HOSTNAME");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Isreset).HasColumnName("ISRESET");

                entity.Property(e => e.Os)
                    .HasMaxLength(100)
                    .HasColumnName("OS");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<Studentpayment>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("STUDENTPAYMENT");

                entity.HasIndex(e => new { e.Studentid, e.Programmestreamid, e.Acadyear, e.Sem }, "AK_STUDENTPAYMENT");

                entity.HasIndex(e => e.Receiptno, "AK_STUDENTPAYMENT_RECEIPTNO")
                    .IsUnique()
                    .HasFilter("([TIMEINSERTED]>'2017-12-18')");

                entity.HasIndex(e => new { e.Studentid, e.Programmestreamid, e.Acadyear, e.Sem }, "IX_STUDENTPAYMENT");

                entity.HasIndex(e => new { e.Currencyid, e.Importbatchid }, "IX_STUDENTPAYMENT1");

                entity.HasIndex(e => new { e.Amount, e.Transdate }, "IX_STUDENTPAYMENT2");

                entity.HasIndex(e => new { e.Bankid, e.Transdate, e.Feeitemid }, "missing_index_162");

                entity.HasIndex(e => e.Reversedtransactionid, "missing_index_353");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Amount2).HasColumnName("AMOUNT2");

                entity.Property(e => e.Bankaccountno)
                    .HasMaxLength(100)
                    .HasColumnName("BANKACCOUNTNO");

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.Currencyid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Feeitemid).HasColumnName("FEEITEMID");

                entity.Property(e => e.Importbatchid)
                    .HasMaxLength(25)
                    .HasColumnName("IMPORTBATCHID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.Ischecked).HasColumnName("ISCHECKED");

                entity.Property(e => e.Isreversal).HasColumnName("ISREVERSAL");

                entity.Property(e => e.Narration)
                    .HasMaxLength(100)
                    .HasColumnName("NARRATION");

                entity.Property(e => e.Narrative)
                    .HasMaxLength(150)
                    .HasColumnName("NARRATIVE");

                entity.Property(e => e.Paymentlocid).HasColumnName("PAYMENTLOCID");

                entity.Property(e => e.Paymenttypeid).HasColumnName("PAYMENTTYPEID");

                entity.Property(e => e.Paymenttypeno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PAYMENTTYPENO");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Reason4reversal)
                    .HasMaxLength(100)
                    .HasColumnName("REASON4REVERSAL");

                entity.Property(e => e.Receiptno)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("RECEIPTNO");

                entity.Property(e => e.Receiptnoold)
                    .HasMaxLength(50)
                    .HasColumnName("RECEIPTNOOLD");

                entity.Property(e => e.Reversedtransactionid).HasColumnName("REVERSEDTRANSACTIONID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Sourcepaymentid).HasColumnName("SOURCEPAYMENTID");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Transactionid)
                    .HasMaxLength(50)
                    .HasColumnName("TRANSACTIONID");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(100)
                    .HasColumnName("UPDATEDBY");

                entity.Property(e => e.Xrate).HasColumnName("XRATE");

                entity.Property(e => e.Xrate2).HasColumnName("XRATE2");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.Studentpayments)
                    .HasForeignKey(d => d.Bankid)
                    .HasConstraintName("BANKSTUDENTPAYMENT");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Studentpayments)
                    .HasForeignKey(d => d.Currencyid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CURRENCYSTUDENTPAYMENT");

                entity.HasOne(d => d.Feeitem)
                    .WithMany(p => p.Studentpayments)
                    .HasForeignKey(d => d.Feeitemid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STUDENTPAYMENT_FEEITEM");

                entity.HasOne(d => d.Paymentloc)
                    .WithMany(p => p.Studentpayments)
                    .HasForeignKey(d => d.Paymentlocid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PAYMENTLOCATIONSTUDENTPAYMENT");

                entity.HasOne(d => d.Paymenttype)
                    .WithMany(p => p.Studentpayments)
                    .HasForeignKey(d => d.Paymenttypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PAYMENTTYPESTUDENTPAYMENT");

                entity.HasOne(d => d.Reversedtransaction)
                    .WithMany(p => p.InverseReversedtransaction)
                    .HasForeignKey(d => d.Reversedtransactionid)
                    .HasConstraintName("FK_REVERSAL");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.Studentpayments)
                    .HasForeignKey(d => new { d.Acadyear, d.Sem })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SEMESTERSTUDENTPAYMENT");
            });

            modelBuilder.Entity<Studentpaymentdeadlinefreshman>(entity =>
            {
                entity.HasKey(e => new { e.Studentid, e.Programmestreamid });

                entity.ToTable("STUDENTPAYMENTDEADLINEFRESHMEN");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Deadline)
                    .HasColumnType("datetime")
                    .HasColumnName("DEADLINE");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getutcdate())");
            });

            modelBuilder.Entity<Studentpaymentdeadlinefreshman1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STUDENTPAYMENTDEADLINEFRESHMEN__");

                entity.Property(e => e.Deadline)
                    .HasColumnType("datetime")
                    .HasColumnName("DEADLINE");

                entity.Property(e => e.Insertedby)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");
            });

            modelBuilder.Entity<Studentphoto>(entity =>
            {
                entity.HasKey(e => e.Studentid);

                entity.ToTable("STUDENTPHOTO");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Photo).HasColumnName("PHOTO");

                entity.Property(e => e.Sourcerowguid).HasColumnName("SOURCEROWGUID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Studentphotodownloaded>(entity =>
            {
                entity.HasKey(e => e.Studentid);

                entity.ToTable("STUDENTPHOTODOWNLOADED");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<StudentphotodownloadedIdcard>(entity =>
            {
                entity.HasKey(e => e.Studentid);

                entity.ToTable("STUDENTPHOTODOWNLOADED_IDCARD");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Studentphotoprocessed>(entity =>
            {
                entity.HasKey(e => e.Studentid);

                entity.ToTable("STUDENTPHOTOPROCESSED");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<Studentphotoupload>(entity =>
            {
                entity.HasKey(e => e.Studentid)
                    .HasName("PK__STUDENTP__495196F04070FF74");

                entity.ToTable("STUDENTPHOTOUPLOAD");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Photo).HasColumnName("PHOTO");

                entity.Property(e => e.Whenuploaded)
                    .HasColumnType("datetime")
                    .HasColumnName("WHENUPLOADED")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<StudentphotouploadUpdate>(entity =>
            {
                entity.HasKey(e => e.Studentid)
                    .HasName("PK__STUDENTP__495196F01CFB6B5C");

                entity.ToTable("STUDENTPHOTOUPLOAD_UPDATE");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Photo).HasColumnName("PHOTO");

                entity.Property(e => e.Whenuploaded)
                    .HasColumnType("datetime")
                    .HasColumnName("WHENUPLOADED")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<StudentpicExportError>(entity =>
            {
                entity.HasKey(e => e.Studentid)
                    .HasName("PK__STUDENTP__495196F08C0D0EAD");

                entity.ToTable("STUDENTPIC_EXPORT_ERROR");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<StudentpicExported>(entity =>
            {
                entity.HasKey(e => e.Studentid)
                    .HasName("PK__STUDENTP__495196F07A057364");

                entity.ToTable("STUDENTPIC_EXPORTED");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<Studentprogramme>(entity =>
            {
                entity.HasKey(e => new { e.Studentid, e.Programmestreamid })
                    .IsClustered(false);

                entity.ToTable("STUDENTPROGRAMME");

                entity.HasIndex(e => new { e.Studentid, e.Programmestreamid, e.Optionid }, "AK_STUDENTPROGRAMME2")
                    .IsUnique();

                entity.HasIndex(e => new { e.Programmestreamid, e.Optionid, e.Campusid }, "IX_STUDENTPROGRAMME");

                entity.HasIndex(e => new { e.Acadyearenrolled, e.Programmestreamid, e.Feecategoryid }, "IX_STUDENTPROGRAMME2");

                entity.HasIndex(e => e.Programmestreamid, "IX_STUDENTPROGRAMME_PROGRAMMESTREAMID2");

                entity.HasIndex(e => new { e.Programmestreamid, e.Studentid }, "_dta_index_STUDENTPROGRAMME_c_28_1460200252__K2_K1")
                    .IsClustered();

                entity.HasIndex(e => new { e.Programmestreamid, e.Optionid }, "missing_index_105");

                entity.HasIndex(e => e.Programmestreamid, "missing_index_290");

                entity.HasIndex(e => new { e.Programmestreamid, e.Campusid }, "missing_index_312");

                entity.HasIndex(e => e.Indexno, "missing_index_340");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Acadyearenrolled).HasColumnName("ACADYEARENROLLED");

                entity.Property(e => e.Admissionlevelid).HasColumnName("ADMISSIONLEVELID");

                entity.Property(e => e.Admissionmonth).HasColumnName("ADMISSIONMONTH");

                entity.Property(e => e.Admissionyear).HasColumnName("ADMISSIONYEAR");

                entity.Property(e => e.Aggregateobtained).HasColumnName("AGGREGATEOBTAINED");

                entity.Property(e => e.Autoadmitted).HasColumnName("AUTOADMITTED");

                entity.Property(e => e.Campusid).HasColumnName("CAMPUSID");

                entity.Property(e => e.Classid).HasColumnName("CLASSID");

                entity.Property(e => e.Datecompleted)
                    .HasColumnType("date")
                    .HasColumnName("DATECOMPLETED");

                entity.Property(e => e.Expectedcompletiondate)
                    .HasColumnType("date")
                    .HasColumnName("EXPECTEDCOMPLETIONDATE");

                entity.Property(e => e.Expirydate)
                    .HasColumnType("date")
                    .HasColumnName("EXPIRYDATE");

                entity.Property(e => e.Feecategoryid).HasColumnName("FEECATEGORYID");

                entity.Property(e => e.Feeclassificationid).HasColumnName("FEECLASSIFICATIONID");

                entity.Property(e => e.Fileno)
                    .HasMaxLength(50)
                    .HasColumnName("FILENO");

                entity.Property(e => e.Finalsem).HasColumnName("FINALSEM");

                entity.Property(e => e.Finalyear).HasColumnName("FINALYEAR");

                entity.Property(e => e.Graduationdate)
                    .HasColumnType("date")
                    .HasColumnName("GRADUATIONDATE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Indexno)
                    .HasMaxLength(50)
                    .HasColumnName("INDEXNO");

                entity.Property(e => e.Insertedby)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.Isfeepaying).HasColumnName("ISFEEPAYING");

                entity.Property(e => e.Isresidential).HasColumnName("ISRESIDENTIAL");

                entity.Property(e => e.Mincredits).HasColumnName("MINCREDITS");

                entity.Property(e => e.Optionid).HasColumnName("OPTIONID");

                entity.Property(e => e.Semenrolled).HasColumnName("SEMENROLLED");

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Sourcerowguid).HasColumnName("SOURCEROWGUID");

                entity.Property(e => e.Sourcerowid).HasColumnName("SOURCEROWID");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Campus)
                    .WithMany(p => p.Studentprogrammes)
                    .HasForeignKey(d => d.Campusid)
                    .HasConstraintName("CAMPUSSTUDENTPROGRAMME");

                entity.HasOne(d => d.Feeclassification)
                    .WithMany(p => p.Studentprogrammes)
                    .HasForeignKey(d => d.Feeclassificationid)
                    .HasConstraintName("FEECLASSIFICATIONSTUDENTPROGRAMME");

                entity.HasOne(d => d.Programmestream)
                    .WithMany(p => p.Studentprogrammes)
                    .HasForeignKey(d => d.Programmestreamid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PROGRAMMESTREAMSTUDENTPROGRAMME");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Studentprogrammes)
                    .HasForeignKey(d => d.Studentid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("STUDENTSTUDENTPROGRAMME");

                entity.HasOne(d => d.Classparameter)
                    .WithMany(p => p.Studentprogrammes)
                    .HasForeignKey(d => new { d.Classid, d.Programmestreamid })
                    .HasConstraintName("CLASSPARAMETERSTUDENTPROGRAMME");

                entity.HasOne(d => d.Programmeoption)
                    .WithMany(p => p.Studentprogrammes)
                    .HasForeignKey(d => new { d.Optionid, d.Programmestreamid })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PROGRAMMEOPTIONSTUDENTPROGRAMME");
            });

            modelBuilder.Entity<Studentprogramme20220218>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STUDENTPROGRAMME_20220218");

                entity.Property(e => e.Acadyearenrolled).HasColumnName("ACADYEARENROLLED");

                entity.Property(e => e.Admissionlevelid).HasColumnName("ADMISSIONLEVELID");

                entity.Property(e => e.Admissionmonth).HasColumnName("ADMISSIONMONTH");

                entity.Property(e => e.Admissionyear).HasColumnName("ADMISSIONYEAR");

                entity.Property(e => e.Aggregateobtained).HasColumnName("AGGREGATEOBTAINED");

                entity.Property(e => e.Autoadmitted).HasColumnName("AUTOADMITTED");

                entity.Property(e => e.Campusid).HasColumnName("CAMPUSID");

                entity.Property(e => e.Classid).HasColumnName("CLASSID");

                entity.Property(e => e.Datecompleted)
                    .HasColumnType("date")
                    .HasColumnName("DATECOMPLETED");

                entity.Property(e => e.Expectedcompletiondate)
                    .HasColumnType("date")
                    .HasColumnName("EXPECTEDCOMPLETIONDATE");

                entity.Property(e => e.Expirydate)
                    .HasColumnType("date")
                    .HasColumnName("EXPIRYDATE");

                entity.Property(e => e.Feecategoryid).HasColumnName("FEECATEGORYID");

                entity.Property(e => e.Feeclassificationid).HasColumnName("FEECLASSIFICATIONID");

                entity.Property(e => e.Fileno)
                    .HasMaxLength(50)
                    .HasColumnName("FILENO");

                entity.Property(e => e.Finalsem).HasColumnName("FINALSEM");

                entity.Property(e => e.Finalyear).HasColumnName("FINALYEAR");

                entity.Property(e => e.Graduationdate)
                    .HasColumnType("date")
                    .HasColumnName("GRADUATIONDATE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Indexno)
                    .HasMaxLength(50)
                    .HasColumnName("INDEXNO");

                entity.Property(e => e.Insertedby)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Isfeepaying).HasColumnName("ISFEEPAYING");

                entity.Property(e => e.Isresidential).HasColumnName("ISRESIDENTIAL");

                entity.Property(e => e.Mincredits).HasColumnName("MINCREDITS");

                entity.Property(e => e.Optionid).HasColumnName("OPTIONID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Semenrolled).HasColumnName("SEMENROLLED");

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Sourcerowguid).HasColumnName("SOURCEROWGUID");

                entity.Property(e => e.Sourcerowid).HasColumnName("SOURCEROWID");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");
            });

            modelBuilder.Entity<StudentprogrammeCampusBk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STUDENTPROGRAMME_CAMPUS_BK");

                entity.Property(e => e.Acadyearenrolled).HasColumnName("ACADYEARENROLLED");

                entity.Property(e => e.Admissionlevelid).HasColumnName("ADMISSIONLEVELID");

                entity.Property(e => e.Admissionmonth).HasColumnName("ADMISSIONMONTH");

                entity.Property(e => e.Admissionyear).HasColumnName("ADMISSIONYEAR");

                entity.Property(e => e.Aggregateobtained).HasColumnName("AGGREGATEOBTAINED");

                entity.Property(e => e.Autoadmitted).HasColumnName("AUTOADMITTED");

                entity.Property(e => e.Campusid).HasColumnName("CAMPUSID");

                entity.Property(e => e.Classid).HasColumnName("CLASSID");

                entity.Property(e => e.Datecompleted)
                    .HasColumnType("date")
                    .HasColumnName("DATECOMPLETED");

                entity.Property(e => e.Expectedcompletiondate)
                    .HasColumnType("date")
                    .HasColumnName("EXPECTEDCOMPLETIONDATE");

                entity.Property(e => e.Expirydate)
                    .HasColumnType("date")
                    .HasColumnName("EXPIRYDATE");

                entity.Property(e => e.Feecategoryid).HasColumnName("FEECATEGORYID");

                entity.Property(e => e.Feeclassificationid).HasColumnName("FEECLASSIFICATIONID");

                entity.Property(e => e.Fileno)
                    .HasMaxLength(50)
                    .HasColumnName("FILENO");

                entity.Property(e => e.Finalsem).HasColumnName("FINALSEM");

                entity.Property(e => e.Finalyear).HasColumnName("FINALYEAR");

                entity.Property(e => e.Graduationdate)
                    .HasColumnType("date")
                    .HasColumnName("GRADUATIONDATE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Indexno)
                    .HasMaxLength(50)
                    .HasColumnName("INDEXNO");

                entity.Property(e => e.Insertedby)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Isfeepaying).HasColumnName("ISFEEPAYING");

                entity.Property(e => e.Isresidential).HasColumnName("ISRESIDENTIAL");

                entity.Property(e => e.Mincredits).HasColumnName("MINCREDITS");

                entity.Property(e => e.Optionid).HasColumnName("OPTIONID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Semenrolled).HasColumnName("SEMENROLLED");

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Sourcerowguid).HasColumnName("SOURCEROWGUID");

                entity.Property(e => e.Sourcerowid).HasColumnName("SOURCEROWID");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");
            });

            modelBuilder.Entity<Studentprogrammelog>(entity =>
            {
                entity.HasKey(e => e.Logid)
                    .IsClustered(false);

                entity.ToTable("STUDENTPROGRAMMELOG");

                entity.Property(e => e.Logid).HasColumnName("LOGID");

                entity.Property(e => e.Actiontaken)
                    .HasMaxLength(1)
                    .HasColumnName("ACTIONTAKEN")
                    .IsFixedLength(true);

                entity.Property(e => e.Actiontime)
                    .HasColumnType("datetime")
                    .HasColumnName("ACTIONTIME");

                entity.Property(e => e.Clientnetaddress)
                    .HasMaxLength(255)
                    .HasColumnName("CLIENTNETADDRESS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NewProgrammestreamid).HasColumnName("NEW_PROGRAMMESTREAMID");

                entity.Property(e => e.OldProgrammestreamid).HasColumnName("OLD_PROGRAMMESTREAMID");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<Studentrefund>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("STUDENTREFUND");

                entity.HasIndex(e => new { e.Studentid, e.Acadyear, e.Sem }, "IX_STUDENTREFUND");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Currencyid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Foliono)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("FOLIONO");

                entity.Property(e => e.Importbatchid)
                    .HasMaxLength(25)
                    .HasColumnName("IMPORTBATCHID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Receiptno)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RECEIPTNO");

                entity.Property(e => e.Refundtypeid)
                    .HasColumnName("REFUNDTYPEID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Timeupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEUPDATED");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEDBY");

                entity.Property(e => e.Xrate).HasColumnName("XRATE");

                entity.Property(e => e.Xrate2).HasColumnName("XRATE2");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Studentrefunds)
                    .HasForeignKey(d => d.Currencyid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CURRENCYSTUDENTREFUND");

                entity.HasOne(d => d.Refundtype)
                    .WithMany(p => p.Studentrefunds)
                    .HasForeignKey(d => d.Refundtypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REFUNDTYPE_STUDENTREFUND");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.Studentrefunds)
                    .HasForeignKey(d => new { d.Acadyear, d.Sem })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SEMESTERSTUDENTREFUND");

                entity.HasOne(d => d.Studentsemester)
                    .WithMany(p => p.Studentrefunds)
                    .HasForeignKey(d => new { d.Studentid, d.Programmestreamid, d.Acadyear, d.Sem })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STUDENTREFUND_STUDENTSEMESTER");
            });

            modelBuilder.Entity<Studentrequiringcredential>(entity =>
            {
                entity.ToTable("STUDENTREQUIRINGCREDENTIALS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Isqueued).HasColumnName("ISQUEUED");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(sysdatetime())");
            });

            modelBuilder.Entity<Studentresidence>(entity =>
            {
                entity.HasKey(e => new { e.Studentid, e.Acadyear })
                    .HasName("PK_STUDENTRESIDENCE_1");

                entity.ToTable("STUDENTRESIDENCE");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Datebooked)
                    .HasColumnType("date")
                    .HasColumnName("DATEBOOKED");

                entity.Property(e => e.Residenceid).HasColumnName("RESIDENCEID");

                entity.Property(e => e.Roomno)
                    .HasMaxLength(100)
                    .HasColumnName("ROOMNO");

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .HasColumnName("SOURCE");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Studentresidence1>(entity =>
            {
                entity.ToTable("STUDENTRESIDENCE", "res");

                entity.HasIndex(e => e.Id, "UQ__STUDENTR__3214EC26696CE10E")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcadYear)
                    .HasMaxLength(50)
                    .HasColumnName("ACAD_YEAR");

                entity.Property(e => e.Billamount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("BILLAMOUNT");

                entity.Property(e => e.Datebooked)
                    .HasColumnType("date")
                    .HasColumnName("DATEBOOKED");

                entity.Property(e => e.Residenceid).HasColumnName("RESIDENCEID");

                entity.Property(e => e.Roomno)
                    .HasMaxLength(50)
                    .HasColumnName("ROOMNO");

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .HasColumnName("SOURCE");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Timesynced)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMESYNCED")
                    .HasDefaultValueSql("(getutcdate())");
            });

            modelBuilder.Entity<Studentscholarship>(entity =>
            {
                entity.HasKey(e => new { e.Studentid, e.Programmestreamid, e.Scholarshiptypeid, e.Acadyear });

                entity.ToTable("STUDENTSCHOLARSHIP");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Scholarshiptypeid).HasColumnName("SCHOLARSHIPTYPEID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Enddate)
                    .HasColumnType("date")
                    .HasColumnName("ENDDATE");

                entity.Property(e => e.Startdate)
                    .HasColumnType("date")
                    .HasColumnName("STARTDATE");

                entity.HasOne(d => d.Scholarshiptype)
                    .WithMany(p => p.Studentscholarships)
                    .HasForeignKey(d => d.Scholarshiptypeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SCHOLARSHIPTYPE_STUDENTSCHOLARSHIP");
            });

            modelBuilder.Entity<Studentscholarshippayment>(entity =>
            {
                entity.ToTable("STUDENTSCHOLARSHIPPAYMENT");

                entity.Property(e => e.Studentscholarshippaymentid)
                    .ValueGeneratedNever()
                    .HasColumnName("STUDENTSCHOLARSHIPPAYMENTID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Amountpaid).HasColumnName("AMOUNTPAID");

                entity.Property(e => e.Datepaid)
                    .HasColumnType("datetime")
                    .HasColumnName("DATEPAID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Scholarshiptypeid).HasColumnName("SCHOLARSHIPTYPEID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<Studentsemester>(entity =>
            {
                entity.HasKey(e => new { e.Studentid, e.Programmestreamid, e.Acadyear, e.Sem });

                entity.ToTable("STUDENTSEMESTER");

                entity.HasIndex(e => new { e.Studentid, e.Programmestreamid, e.Acadyear, e.Sem }, "AK_STUDENTSEMESTER")
                    .IsUnique();

                entity.HasIndex(e => new { e.Programmestreamid, e.Acadyear, e.Sem, e.Acadlevelid }, "IX_STUDENTSEMESTER");

                entity.HasIndex(e => new { e.Programmestreamid, e.Acadyear, e.Sem }, "IX_STUDENTSEMESTER2");

                entity.HasIndex(e => new { e.Acadyear, e.Sem, e.Preregistrationstatus }, "IX_STUDENTSEMESTER_1");

                entity.HasIndex(e => new { e.Acadyear, e.Sem, e.Preregistrationstatus }, "IX_STUDENTSEMESTER_PREREGISTRATIONSTATUS");

                entity.HasIndex(e => e.Preregistrationstatus, "IX_STUDENTSEMESTER_PREREGISTRATIONSTATUS2");

                entity.HasIndex(e => new { e.Studentid, e.Programmestreamid, e.Acadyear, e.Sem, e.Acadlevelid }, "UK_STUDENTSEMESTER")
                    .IsUnique();

                entity.HasIndex(e => new { e.Studentid, e.Programmestreamid, e.Acadlevelid }, "_dta_index_STUDENTSEMESTER_28_1633597058__K1_K2_K6_3");

                entity.HasIndex(e => e.Timeinserted, "missing_index_37");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Autopromoted).HasColumnName("AUTOPROMOTED");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Iscurrent)
                    .IsRequired()
                    .HasColumnName("ISCURRENT")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Metadata)
                    .HasMaxLength(1000)
                    .HasColumnName("METADATA");

                entity.Property(e => e.Preregistrationstatus)
                    .HasColumnName("PREREGISTRATIONSTATUS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Sourcerowguid).HasColumnName("SOURCEROWGUID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Yr2).HasColumnName("YR2");

                entity.HasOne(d => d.Acadlevel)
                    .WithMany(p => p.Studentsemesters)
                    .HasForeignKey(d => d.Acadlevelid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACADEMICLEVEL_STUDENTSEMESTER");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.Studentsemesters)
                    .HasForeignKey(d => new { d.Acadyear, d.Sem })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SEMESTERSTUDENTSEMESTER");

                entity.HasOne(d => d.Studentacadyear)
                    .WithMany(p => p.Studentsemesters)
                    .HasPrincipalKey(p => new { p.Studentid, p.Programmestreamid, p.Acadyear, p.Acadlevelid })
                    .HasForeignKey(d => new { d.Studentid, d.Programmestreamid, d.Acadyear, d.Acadlevelid })
                    .HasConstraintName("FK_STUDENTACADYEAR_STUDENTSEMESTER");
            });

            modelBuilder.Entity<Studentsemester20220218>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STUDENTSEMESTER_20220218");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Autopromoted).HasColumnName("AUTOPROMOTED");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Iscurrent).HasColumnName("ISCURRENT");

                entity.Property(e => e.Metadata)
                    .HasMaxLength(1000)
                    .HasColumnName("METADATA");

                entity.Property(e => e.Preregistrationstatus).HasColumnName("PREREGISTRATIONSTATUS");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Sourcerowguid).HasColumnName("SOURCEROWGUID");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Yr2).HasColumnName("YR2");
            });

            modelBuilder.Entity<Studentsm>(entity =>
            {
                entity.HasKey(e => e.Messageid)
                    .HasName("PK_STUDENTSMS_OLD");

                entity.ToTable("STUDENTSMS");

                entity.Property(e => e.Messageid)
                    .ValueGeneratedNever()
                    .HasColumnName("MESSAGEID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Isflagged).HasColumnName("ISFLAGGED");

                entity.Property(e => e.Messagecount).HasColumnName("MESSAGECOUNT");

                entity.Property(e => e.Messagedeliverystatus)
                    .HasMaxLength(50)
                    .HasColumnName("MESSAGEDELIVERYSTATUS");

                entity.Property(e => e.Messagelength).HasColumnName("MESSAGELENGTH");

                entity.Property(e => e.Mobileno)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("MOBILENO");

                entity.Property(e => e.Msg)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("MSG");

                entity.Property(e => e.Msgresponsestatus).HasColumnName("MSGRESPONSESTATUS");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Senderid)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("SENDERID")
                    .HasDefaultValueSql("(N'KNUST')");

                entity.Property(e => e.Smscategoryid).HasColumnName("SMSCATEGORYID");

                entity.Property(e => e.Smsid).HasColumnName("SMSID");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timesent)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMESENT")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Smscategory)
                    .WithMany(p => p.Studentsms)
                    .HasForeignKey(d => d.Smscategoryid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STUDENTSMS_OLD_SMSCATEGORYID");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Studentsms)
                    .HasForeignKey(d => d.Studentid)
                    .HasConstraintName("FK_STUDENTSMS_OLD_STUDENT");
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.HasKey(e => e.Tagid)
                    .IsClustered(false);

                entity.ToTable("TAG");

                entity.Property(e => e.Tagid)
                    .ValueGeneratedNever()
                    .HasColumnName("TAGID");

                entity.Property(e => e.Acadhead)
                    .HasMaxLength(50)
                    .HasColumnName("ACADHEAD");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("NAME");

                entity.Property(e => e.Pluraldef)
                    .HasMaxLength(200)
                    .HasColumnName("PLURALDEF");

                entity.Property(e => e.Promote).HasColumnName("PROMOTE");

                entity.Property(e => e.Show).HasColumnName("SHOW");

                entity.Property(e => e.Singulardef)
                    .HasMaxLength(200)
                    .HasColumnName("SINGULARDEF");

                entity.Property(e => e.Sortno).HasColumnName("SORTNO");
            });

            modelBuilder.Entity<Taggedstudent>(entity =>
            {
                entity.HasKey(e => new { e.Studentid, e.Programmestreamid, e.Acadyear, e.Sem })
                    .IsClustered(false);

                entity.ToTable("TAGGEDSTUDENT");

                entity.HasIndex(e => new { e.Acadyear, e.Sem }, "IX_IX_TAGGEDSTUDENT1");

                entity.HasIndex(e => new { e.Programmestreamid, e.Acadyear, e.Sem }, "IX_TAGGEDSTUDENT2");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.Reason)
                    .HasMaxLength(200)
                    .HasColumnName("REASON");

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.Taggedstudents)
                    .HasForeignKey(d => d.Tagid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TAGTAGGEDSTUDENT");

                entity.HasOne(d => d.Studentsemester)
                    .WithOne(p => p.Taggedstudent)
                    .HasForeignKey<Taggedstudent>(d => new { d.Studentid, d.Programmestreamid, d.Acadyear, d.Sem })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("STUDENTSEMESTERTAGGEDSTUDENT");
            });

            modelBuilder.Entity<Taggedstudentlog>(entity =>
            {
                entity.HasKey(e => e.Logid)
                    .IsClustered(false);

                entity.ToTable("TAGGEDSTUDENTLOG");

                entity.Property(e => e.Logid).HasColumnName("LOGID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Actiontaken)
                    .HasMaxLength(1)
                    .HasColumnName("ACTIONTAKEN")
                    .IsFixedLength(true);

                entity.Property(e => e.Actiontime)
                    .HasColumnType("datetime")
                    .HasColumnName("ACTIONTIME");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Programmestream)
                    .HasMaxLength(100)
                    .HasColumnName("PROGRAMMESTREAM");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Reason)
                    .HasMaxLength(200)
                    .HasColumnName("REASON");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Tag)
                    .HasMaxLength(50)
                    .HasColumnName("TAG")
                    .IsFixedLength(true);

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasColumnName("USERNAME");

                entity.Property(e => e.Yr).HasColumnName("YR");
            });

            modelBuilder.Entity<TemdelfeesPolicy20220420>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temdelfees_policy20220420");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Acadyearstring)
                    .HasMaxLength(20)
                    .HasColumnName("ACADYEARSTRING");

                entity.Property(e => e.Amountpaidsem)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("AMOUNTPAIDSEM");

                entity.Property(e => e.Campus)
                    .HasMaxLength(100)
                    .HasColumnName("CAMPUS");

                entity.Property(e => e.Campusid).HasColumnName("CAMPUSID");

                entity.Property(e => e.College)
                    .HasMaxLength(100)
                    .HasColumnName("COLLEGE");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .HasColumnName("DEPARTMENT");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Faculty)
                    .HasMaxLength(100)
                    .HasColumnName("FACULTY");

                entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");

                entity.Property(e => e.Feecategory)
                    .HasMaxLength(100)
                    .HasColumnName("FEECATEGORY");

                entity.Property(e => e.Feecategoryid).HasColumnName("FEECATEGORYID");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(100)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.Graduatetype)
                    .HasMaxLength(100)
                    .HasColumnName("GRADUATETYPE");

                entity.Property(e => e.Graduatetypeid).HasColumnName("GRADUATETYPEID");

                entity.Property(e => e.IsbiometricallyOrCourseregistered).HasColumnName("ISBIOMETRICALLY_OR_COURSEREGISTERED");

                entity.Property(e => e.Isbiometricallyverified).HasColumnName("ISBIOMETRICALLYVERIFIED");

                entity.Property(e => e.Iscourseregistered).HasColumnName("ISCOURSEREGISTERED");

                entity.Property(e => e.Isforeigner).HasColumnName("ISFOREIGNER");

                entity.Property(e => e.Isghanaian).HasColumnName("ISGHANAIAN");

                entity.Property(e => e.Isinfinalyear).HasColumnName("ISINFINALYEAR");

                entity.Property(e => e.Isingraceperiod).HasColumnName("ISINGRACEPERIOD");

                entity.Property(e => e.Minamount70)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_70");

                entity.Property(e => e.MinamountPolicy)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_POLICY");

                entity.Property(e => e.Othername)
                    .HasMaxLength(50)
                    .HasColumnName("OTHERNAME");

                entity.Property(e => e.Primarymobile)
                    .HasMaxLength(20)
                    .HasColumnName("PRIMARYMOBILE");

                entity.Property(e => e.Programmestream)
                    .HasMaxLength(100)
                    .HasColumnName("PROGRAMMESTREAM");

                entity.Property(e => e.ProgrammestreamBiometricverificationrequired).HasColumnName("PROGRAMMESTREAM_BIOMETRICVERIFICATIONREQUIRED");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Schoolmobile)
                    .HasMaxLength(20)
                    .HasColumnName("SCHOOLMOBILE");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.StudentBill4Acadyear).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.StudentMinPaymentAmountRequired).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.StudentSemFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentcategoryname)
                    .HasMaxLength(50)
                    .HasColumnName("STUDENTCATEGORYNAME");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("SURNAME");

                entity.Property(e => e.Tag)
                    .HasMaxLength(50)
                    .HasColumnName("TAG");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Totalamount)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("TOTALAMOUNT");
            });

            modelBuilder.Entity<TempBackupUser>(entity =>
            {
                entity.HasKey(e => e.Studentid);

                entity.ToTable("TEMP_BACKUP_USERS");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Schoolemail)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("SCHOOLEMAIL");
            });

            modelBuilder.Entity<TempBursaryKen>(entity =>
            {
                entity.HasKey(e => e.Studentid);

                entity.ToTable("TEMP_BURSARY_KEN");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(100)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<TempCollege>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_COLLEGE");

                entity.HasIndex(e => e.Collegeid, "UQ__TEMP_COL__89C2686A20F6218A")
                    .IsUnique();

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");
            });

            modelBuilder.Entity<TempContinuingDoesnotmeetPolicy>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_CONTINUING_DOESNOTMEET_POLICY");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Actiontime).HasColumnName("ACTIONTIME");

                entity.Property(e => e.Minamount70)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_70");

                entity.Property(e => e.MinamountPolicy)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_POLICY");

                entity.Property(e => e.Policybalance)
                    .HasColumnType("decimal(17, 2)")
                    .HasColumnName("POLICYBALANCE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Tagdetails)
                    .IsRequired()
                    .HasMaxLength(43)
                    .IsUnicode(false)
                    .HasColumnName("TAGDETAILS");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<TempContinuingMeetPolicy>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_CONTINUING_MEET_POLICY");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Actiontime).HasColumnName("ACTIONTIME");

                entity.Property(e => e.Minamount70)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_70");

                entity.Property(e => e.MinamountPolicy)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_POLICY");

                entity.Property(e => e.Policybalance)
                    .HasColumnType("decimal(17, 2)")
                    .HasColumnName("POLICYBALANCE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Tagdetails)
                    .IsRequired()
                    .HasMaxLength(43)
                    .IsUnicode(false)
                    .HasColumnName("TAGDETAILS");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<TempContinuingMeetPolicyDeleted>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_CONTINUING_MEET_POLICY_DELETED");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Reason)
                    .HasMaxLength(200)
                    .HasColumnName("REASON");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");
            });

            modelBuilder.Entity<TempFreshmenPostgraduateWronglyTagged>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_FRESHMEN_POSTGRADUATE_WRONGLY_TAGGED");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Actiontime).HasColumnName("ACTIONTIME");

                entity.Property(e => e.Minamount70)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_70");

                entity.Property(e => e.MinamountPolicy)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_POLICY");

                entity.Property(e => e.Policybalance)
                    .HasColumnType("decimal(17, 2)")
                    .HasColumnName("POLICYBALANCE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Tagdetails)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("TAGDETAILS");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<TempFreshmenPostgraduateWronglyTaggedDeleted>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_FRESHMEN_POSTGRADUATE_WRONGLY_TAGGED_DELETED");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Reason)
                    .HasMaxLength(200)
                    .HasColumnName("REASON");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");
            });

            modelBuilder.Entity<TempIdl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_IDL");

                entity.Property(e => e.Studentid).HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<TempJune15>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_JUNE15");

                entity.Property(e => e.Acadlevel)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ACADLEVEL");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Bal)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("BAL");

                entity.Property(e => e.Campus)
                    .HasMaxLength(100)
                    .HasColumnName("CAMPUS");

                entity.Property(e => e.College)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("COLLEGE");

                entity.Property(e => e.Currencyid)
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Degreelevel).HasColumnName("DEGREELEVEL");

                entity.Property(e => e.Degreetypename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("DEGREETYPENAME");

                entity.Property(e => e.Faculty)
                    .HasMaxLength(100)
                    .HasColumnName("FACULTY");

                entity.Property(e => e.Feecategory)
                    .HasMaxLength(100)
                    .HasColumnName("FEECATEGORY");

                entity.Property(e => e.Feeclassification)
                    .HasMaxLength(100)
                    .HasColumnName("FEECLASSIFICATION");

                entity.Property(e => e.Graduatetype)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("GRADUATETYPE");

                entity.Property(e => e.Primarymobile)
                    .HasMaxLength(20)
                    .HasColumnName("PRIMARYMOBILE");

                entity.Property(e => e.Programmestream)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("PROGRAMMESTREAM");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Schoolphone)
                    .HasMaxLength(20)
                    .HasColumnName("SCHOOLPHONE");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Studentname)
                    .IsRequired()
                    .HasMaxLength(101)
                    .HasColumnName("STUDENTNAME");
            });

            modelBuilder.Entity<TempJune28>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_JUNE28");

                entity.Property(e => e.Acadlevel)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ACADLEVEL");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Bal)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("BAL");

                entity.Property(e => e.Campus)
                    .HasMaxLength(100)
                    .HasColumnName("CAMPUS");

                entity.Property(e => e.College)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("COLLEGE");

                entity.Property(e => e.Currencyid)
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Degreelevel).HasColumnName("DEGREELEVEL");

                entity.Property(e => e.Degreetypename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("DEGREETYPENAME");

                entity.Property(e => e.Faculty)
                    .HasMaxLength(100)
                    .HasColumnName("FACULTY");

                entity.Property(e => e.Feecategory)
                    .HasMaxLength(100)
                    .HasColumnName("FEECATEGORY");

                entity.Property(e => e.Feeclassification)
                    .HasMaxLength(100)
                    .HasColumnName("FEECLASSIFICATION");

                entity.Property(e => e.Graduatetype)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("GRADUATETYPE");

                entity.Property(e => e.Primarymobile)
                    .HasMaxLength(20)
                    .HasColumnName("PRIMARYMOBILE");

                entity.Property(e => e.Programmestream)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("PROGRAMMESTREAM");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Schoolphone)
                    .HasMaxLength(20)
                    .HasColumnName("SCHOOLPHONE");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Studentname)
                    .IsRequired()
                    .HasMaxLength(101)
                    .HasColumnName("STUDENTNAME");
            });

            modelBuilder.Entity<TempKenCtm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_KEN_CTM");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .HasColumnName("NAME");

                entity.Property(e => e.Programmestream)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("PROGRAMMESTREAM");

                entity.Property(e => e.Reportedactualbal)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("REPORTEDACTUALBAL");

                entity.Property(e => e.Reportedsystembal)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("REPORTEDSYSTEMBAL");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Year)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("YEAR");
            });

            modelBuilder.Entity<TempKenDo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_KEN_DOS");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("NAME");

                entity.Property(e => e.Otherconcerns).HasColumnName("OTHERCONCERNS");

                entity.Property(e => e.Programme)
                    .HasMaxLength(100)
                    .HasColumnName("PROGRAMME");

                entity.Property(e => e.Proofofsubmission).HasColumnName("PROOFOFSUBMISSION");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(50)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timestamp)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMESTAMP");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<TempKenDuplicate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_KEN_DUPLICATE");

                entity.Property(e => e.Acadyear)
                    .HasMaxLength(255)
                    .HasColumnName("ACADYEAR");

                entity.Property(e => e.Admissionyear).HasColumnName("ADMISSIONYEAR");

                entity.Property(e => e.Birthdate)
                    .HasColumnType("datetime")
                    .HasColumnName("BIRTHDATE");

                entity.Property(e => e.Indexno)
                    .HasMaxLength(255)
                    .HasColumnName("INDEXNO");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Programmestream)
                    .HasMaxLength(255)
                    .HasColumnName("PROGRAMMESTREAM");

                entity.Property(e => e.Studentid).HasColumnName("STUDENTID");

                entity.Property(e => e.Studenttag)
                    .HasMaxLength(255)
                    .HasColumnName("STUDENTTAG");

                entity.Property(e => e.Tt)
                    .HasMaxLength(255)
                    .HasColumnName("tt");

                entity.Property(e => e.Year)
                    .HasMaxLength(255)
                    .HasColumnName("YEAR");
            });

            modelBuilder.Entity<TempKenVodaDistinct>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_KEN_VODA_DISTINCT");

                entity.Property(e => e.Phonenumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("PHONENUMBER");
            });

            modelBuilder.Entity<TempKenVodaFound2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_KEN_VODA_FOUND2");

                entity.Property(e => e.Phonenumber)
                    .HasMaxLength(50)
                    .HasColumnName("PHONENUMBER");
            });

            modelBuilder.Entity<TempKenVodum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_KEN_VODA");

                entity.Property(e => e.Phonenumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("PHONENUMBER");
            });

            modelBuilder.Entity<TempOccupant>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_occupants");

                entity.Property(e => e.Othername)
                    .HasMaxLength(100)
                    .HasColumnName("othername");

                entity.Property(e => e.Residence)
                    .HasMaxLength(100)
                    .HasColumnName("residence");

                entity.Property(e => e.Residenceid).HasColumnName("residenceid");

                entity.Property(e => e.Roomno)
                    .HasMaxLength(50)
                    .HasColumnName("roomno");

                entity.Property(e => e.Stno)
                    .HasMaxLength(10)
                    .HasColumnName("stno");

                entity.Property(e => e.Surname)
                    .HasMaxLength(100)
                    .HasColumnName("surname");
            });

            modelBuilder.Entity<TempOccupants2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_occupants2");

                entity.Property(e => e.AltResidenceId).HasColumnName("altResidenceId");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("date")
                    .HasColumnName("date_added");

                entity.Property(e => e.IsReservedRoom)
                    .HasMaxLength(50)
                    .HasColumnName("is_reserved_room");

                entity.Property(e => e.Othername)
                    .HasMaxLength(50)
                    .HasColumnName("othername");

                entity.Property(e => e.Residence)
                    .HasMaxLength(50)
                    .HasColumnName("residence");

                entity.Property(e => e.Roomno)
                    .HasMaxLength(50)
                    .HasColumnName("roomno");

                entity.Property(e => e.Stno)
                    .HasMaxLength(50)
                    .HasColumnName("stno");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("surname");
            });

            modelBuilder.Entity<TempResidencebooking20211231>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_residencebooking20211231", "res");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Bookingcode).HasColumnName("BOOKINGCODE");

                entity.Property(e => e.Bookingdeadline)
                    .HasColumnType("datetime")
                    .HasColumnName("BOOKINGDEADLINE");

                entity.Property(e => e.Bookingtypeid).HasColumnName("BOOKINGTYPEID");

                entity.Property(e => e.Flag).HasColumnName("FLAG");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Ispaid).HasColumnName("ISPAID");

                entity.Property(e => e.Isreserved).HasColumnName("ISRESERVED");

                entity.Property(e => e.Residenceid).HasColumnName("RESIDENCEID");

                entity.Property(e => e.Roomno)
                    .HasMaxLength(10)
                    .HasColumnName("ROOMNO");

                entity.Property(e => e.Roomno2)
                    .HasMaxLength(50)
                    .HasColumnName("ROOMNO2");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");
            });

            modelBuilder.Entity<TempResidentialBillImport>(entity =>
            {
                entity.HasKey(e => e.Studentid);

                entity.ToTable("TEMP_RESIDENTIAL_BILL_IMPORT");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(50)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Residence)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("RESIDENCE");

                entity.Property(e => e.Residenceid).HasColumnName("RESIDENCEID");

                entity.Property(e => e.Roomno)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("ROOMNO");
            });

            modelBuilder.Entity<TempReversalData20200121>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_REVERSAL_DATA20200121");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Bank)
                    .HasMaxLength(255)
                    .HasColumnName("BANK");

                entity.Property(e => e.Correctreceiptid).HasColumnName("CORRECTRECEIPTID");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE");

                entity.Property(e => e.Details)
                    .HasMaxLength(255)
                    .HasColumnName("DETAILS");

                entity.Property(e => e.Receiptid).HasColumnName("RECEIPTID");

                entity.Property(e => e.Studentid).HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<TempReversedTagContinuingMeetPolicy>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_REVERSED_TAG_CONTINUING_MEET_POLICY");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Actiontime).HasColumnName("ACTIONTIME");

                entity.Property(e => e.Minamount70)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_70");

                entity.Property(e => e.MinamountPolicy)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_POLICY");

                entity.Property(e => e.Policybalance)
                    .HasColumnType("decimal(17, 2)")
                    .HasColumnName("POLICYBALANCE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Tagdetails)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("TAGDETAILS");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<TempReversedTagFreshmenPostgraduate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_REVERSED_TAG_FRESHMEN_POSTGRADUATE");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Actiontime).HasColumnName("ACTIONTIME");

                entity.Property(e => e.Minamount70)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_70");

                entity.Property(e => e.MinamountPolicy)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_POLICY");

                entity.Property(e => e.Policybalance)
                    .HasColumnType("decimal(17, 2)")
                    .HasColumnName("POLICYBALANCE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Tagdetails)
                    .IsRequired()
                    .HasMaxLength(38)
                    .IsUnicode(false)
                    .HasColumnName("TAGDETAILS");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<TempReversedTagMeetPolicyDeferred>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_REVERSED_TAG_MEET_POLICY_DEFERRED");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Actiontime).HasColumnName("ACTIONTIME");

                entity.Property(e => e.Minamount70)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_70");

                entity.Property(e => e.MinamountPolicy)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_POLICY");

                entity.Property(e => e.Policybalance)
                    .HasColumnType("decimal(17, 2)")
                    .HasColumnName("POLICYBALANCE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Tagdetails)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("TAGDETAILS");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<TempReversedTagMeetPolicyDeferred10>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_REVERSED_TAG_MEET_POLICY_DEFERRED10");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Actiontime).HasColumnName("ACTIONTIME");

                entity.Property(e => e.Minamount70)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_70");

                entity.Property(e => e.MinamountPolicy)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_POLICY");

                entity.Property(e => e.Policybalance)
                    .HasColumnType("decimal(17, 2)")
                    .HasColumnName("POLICYBALANCE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Tagdetails)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("TAGDETAILS");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<TempReversedTagMeetPolicyDeferred2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_REVERSED_TAG_MEET_POLICY_DEFERRED2");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Actiontime).HasColumnName("ACTIONTIME");

                entity.Property(e => e.Minamount70)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_70");

                entity.Property(e => e.MinamountPolicy)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_POLICY");

                entity.Property(e => e.Policybalance)
                    .HasColumnType("decimal(17, 2)")
                    .HasColumnName("POLICYBALANCE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Tagdetails)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("TAGDETAILS");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<TempReversedTagMeetPolicyDeferred3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_REVERSED_TAG_MEET_POLICY_DEFERRED3");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Actiontime).HasColumnName("ACTIONTIME");

                entity.Property(e => e.Minamount70)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_70");

                entity.Property(e => e.MinamountPolicy)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_POLICY");

                entity.Property(e => e.Policybalance)
                    .HasColumnType("decimal(17, 2)")
                    .HasColumnName("POLICYBALANCE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Tagdetails)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("TAGDETAILS");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<TempReversedTagMeetPolicyDeferred4>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_REVERSED_TAG_MEET_POLICY_DEFERRED4");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Actiontime).HasColumnName("ACTIONTIME");

                entity.Property(e => e.Minamount70)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_70");

                entity.Property(e => e.MinamountPolicy)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_POLICY");

                entity.Property(e => e.Policybalance)
                    .HasColumnType("decimal(17, 2)")
                    .HasColumnName("POLICYBALANCE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Tagdetails)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("TAGDETAILS");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<TempReversedTagMeetPolicyDeferred5>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_REVERSED_TAG_MEET_POLICY_DEFERRED5");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Actiontime).HasColumnName("ACTIONTIME");

                entity.Property(e => e.Minamount70)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_70");

                entity.Property(e => e.MinamountPolicy)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_POLICY");

                entity.Property(e => e.Policybalance)
                    .HasColumnType("decimal(17, 2)")
                    .HasColumnName("POLICYBALANCE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Tagdetails)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("TAGDETAILS");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<TempReversedTagMeetPolicyDeferred6>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_REVERSED_TAG_MEET_POLICY_DEFERRED6");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Actiontime).HasColumnName("ACTIONTIME");

                entity.Property(e => e.Minamount70)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_70");

                entity.Property(e => e.MinamountPolicy)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_POLICY");

                entity.Property(e => e.Policybalance)
                    .HasColumnType("decimal(17, 2)")
                    .HasColumnName("POLICYBALANCE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Tagdetails)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("TAGDETAILS");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<TempReversedTagMeetPolicyDeferred7>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_REVERSED_TAG_MEET_POLICY_DEFERRED7");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Actiontime).HasColumnName("ACTIONTIME");

                entity.Property(e => e.Minamount70)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_70");

                entity.Property(e => e.MinamountPolicy)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_POLICY");

                entity.Property(e => e.Policybalance)
                    .HasColumnType("decimal(17, 2)")
                    .HasColumnName("POLICYBALANCE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Tagdetails)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("TAGDETAILS");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<TempReversedTagMeetPolicyDeferred8>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_REVERSED_TAG_MEET_POLICY_DEFERRED8");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Actiontime).HasColumnName("ACTIONTIME");

                entity.Property(e => e.Minamount70)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_70");

                entity.Property(e => e.MinamountPolicy)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_POLICY");

                entity.Property(e => e.Policybalance)
                    .HasColumnType("decimal(17, 2)")
                    .HasColumnName("POLICYBALANCE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Tagdetails)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("TAGDETAILS");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<TempReversedTagMeetPolicyDeferred9>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_REVERSED_TAG_MEET_POLICY_DEFERRED9");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Actiontime).HasColumnName("ACTIONTIME");

                entity.Property(e => e.Minamount70)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_70");

                entity.Property(e => e.MinamountPolicy)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_POLICY");

                entity.Property(e => e.Policybalance)
                    .HasColumnType("decimal(17, 2)")
                    .HasColumnName("POLICYBALANCE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Tagdetails)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("TAGDETAILS");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<TempReversedTagMeetPolicyPermanentlyRemoved>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_REVERSED_TAG_MEET_POLICY_PERMANENTLY_REMOVED");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Actiontime).HasColumnName("ACTIONTIME");

                entity.Property(e => e.Minamount70)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_70");

                entity.Property(e => e.MinamountPolicy)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_POLICY");

                entity.Property(e => e.Policybalance)
                    .HasColumnType("decimal(17, 2)")
                    .HasColumnName("POLICYBALANCE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Tagdetails)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("TAGDETAILS");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<TempReversedTagMeetPolicyPermanentlyRemoved2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_REVERSED_TAG_MEET_POLICY_PERMANENTLY_REMOVED2");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Actiontime).HasColumnName("ACTIONTIME");

                entity.Property(e => e.Minamount70)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_70");

                entity.Property(e => e.MinamountPolicy)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_POLICY");

                entity.Property(e => e.Policybalance)
                    .HasColumnType("decimal(17, 2)")
                    .HasColumnName("POLICYBALANCE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Tagdetails)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("TAGDETAILS");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<TempReversedTagMeetPolicyPermanentlyRemovedPg10>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_REVERSED_TAG_MEET_POLICY_PERMANENTLY_REMOVED_PG10");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Actiontime).HasColumnName("ACTIONTIME");

                entity.Property(e => e.Minamount70)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_70");

                entity.Property(e => e.MinamountPolicy)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_POLICY");

                entity.Property(e => e.Policybalance)
                    .HasColumnType("decimal(17, 2)")
                    .HasColumnName("POLICYBALANCE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Tagdetails)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("TAGDETAILS");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<TempReversedTagMeetPolicyPermanentlyRemovedPg3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_REVERSED_TAG_MEET_POLICY_PERMANENTLY_REMOVED_PG3");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Actiontime).HasColumnName("ACTIONTIME");

                entity.Property(e => e.Minamount70)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_70");

                entity.Property(e => e.MinamountPolicy)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_POLICY");

                entity.Property(e => e.Policybalance)
                    .HasColumnType("decimal(17, 2)")
                    .HasColumnName("POLICYBALANCE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Tagdetails)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("TAGDETAILS");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<TempReversedTagMeetPolicyPermanentlyRemovedPg4>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_REVERSED_TAG_MEET_POLICY_PERMANENTLY_REMOVED_PG4");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Actiontime).HasColumnName("ACTIONTIME");

                entity.Property(e => e.Minamount70)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_70");

                entity.Property(e => e.MinamountPolicy)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_POLICY");

                entity.Property(e => e.Policybalance)
                    .HasColumnType("decimal(17, 2)")
                    .HasColumnName("POLICYBALANCE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Tagdetails)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("TAGDETAILS");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<TempReversedTagMeetPolicyPermanentlyRemovedPg5>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_REVERSED_TAG_MEET_POLICY_PERMANENTLY_REMOVED_PG5");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Actiontime).HasColumnName("ACTIONTIME");

                entity.Property(e => e.Minamount70)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_70");

                entity.Property(e => e.MinamountPolicy)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_POLICY");

                entity.Property(e => e.Policybalance)
                    .HasColumnType("decimal(17, 2)")
                    .HasColumnName("POLICYBALANCE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Tagdetails)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("TAGDETAILS");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<TempReversedTagMeetPolicyPermanentlyRemovedPg6>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_REVERSED_TAG_MEET_POLICY_PERMANENTLY_REMOVED_PG6");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Actiontime).HasColumnName("ACTIONTIME");

                entity.Property(e => e.Minamount70)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_70");

                entity.Property(e => e.MinamountPolicy)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_POLICY");

                entity.Property(e => e.Policybalance)
                    .HasColumnType("decimal(17, 2)")
                    .HasColumnName("POLICYBALANCE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Tagdetails)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("TAGDETAILS");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<TempReversedTagMeetPolicyPermanentlyRemovedPg7>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_REVERSED_TAG_MEET_POLICY_PERMANENTLY_REMOVED_PG7");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Actiontime).HasColumnName("ACTIONTIME");

                entity.Property(e => e.Minamount70)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_70");

                entity.Property(e => e.MinamountPolicy)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_POLICY");

                entity.Property(e => e.Policybalance)
                    .HasColumnType("decimal(17, 2)")
                    .HasColumnName("POLICYBALANCE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Tagdetails)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("TAGDETAILS");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<TempReversedTagMeetPolicyPermanentlyRemovedPg8>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_REVERSED_TAG_MEET_POLICY_PERMANENTLY_REMOVED_PG8");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Actiontime).HasColumnName("ACTIONTIME");

                entity.Property(e => e.Minamount70)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_70");

                entity.Property(e => e.MinamountPolicy)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_POLICY");

                entity.Property(e => e.Policybalance)
                    .HasColumnType("decimal(17, 2)")
                    .HasColumnName("POLICYBALANCE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Tagdetails)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("TAGDETAILS");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<TempReversedTagMeetPolicyPermanentlyRemovedPg9>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_REVERSED_TAG_MEET_POLICY_PERMANENTLY_REMOVED_PG9");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Actiontime).HasColumnName("ACTIONTIME");

                entity.Property(e => e.Minamount70)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_70");

                entity.Property(e => e.MinamountPolicy)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_POLICY");

                entity.Property(e => e.Policybalance)
                    .HasColumnType("decimal(17, 2)")
                    .HasColumnName("POLICYBALANCE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Tagdetails)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("TAGDETAILS");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<TempReversedTagMeetPolicyPermanentlyRemovedUg10>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_REVERSED_TAG_MEET_POLICY_PERMANENTLY_REMOVED_UG10");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Actiontime).HasColumnName("ACTIONTIME");

                entity.Property(e => e.Minamount70)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_70");

                entity.Property(e => e.MinamountPolicy)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_POLICY");

                entity.Property(e => e.Policybalance)
                    .HasColumnType("decimal(17, 2)")
                    .HasColumnName("POLICYBALANCE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Tagdetails)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("TAGDETAILS");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<TempReversedTagMeetPolicyPermanentlyRemovedUg3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_REVERSED_TAG_MEET_POLICY_PERMANENTLY_REMOVED_UG3");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Actiontime).HasColumnName("ACTIONTIME");

                entity.Property(e => e.Minamount70)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_70");

                entity.Property(e => e.MinamountPolicy)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_POLICY");

                entity.Property(e => e.Policybalance)
                    .HasColumnType("decimal(17, 2)")
                    .HasColumnName("POLICYBALANCE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Tagdetails)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("TAGDETAILS");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<TempReversedTagMeetPolicyPermanentlyRemovedUg4>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_REVERSED_TAG_MEET_POLICY_PERMANENTLY_REMOVED_UG4");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Actiontime).HasColumnName("ACTIONTIME");

                entity.Property(e => e.Minamount70)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_70");

                entity.Property(e => e.MinamountPolicy)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_POLICY");

                entity.Property(e => e.Policybalance)
                    .HasColumnType("decimal(17, 2)")
                    .HasColumnName("POLICYBALANCE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Tagdetails)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("TAGDETAILS");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<TempReversedTagMeetPolicyPermanentlyRemovedUg5>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_REVERSED_TAG_MEET_POLICY_PERMANENTLY_REMOVED_UG5");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Actiontime).HasColumnName("ACTIONTIME");

                entity.Property(e => e.Minamount70)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_70");

                entity.Property(e => e.MinamountPolicy)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_POLICY");

                entity.Property(e => e.Policybalance)
                    .HasColumnType("decimal(17, 2)")
                    .HasColumnName("POLICYBALANCE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Tagdetails)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("TAGDETAILS");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<TempReversedTagMeetPolicyPermanentlyRemovedUg9>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_REVERSED_TAG_MEET_POLICY_PERMANENTLY_REMOVED_UG9");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Actiontime).HasColumnName("ACTIONTIME");

                entity.Property(e => e.Minamount70)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_70");

                entity.Property(e => e.MinamountPolicy)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_POLICY");

                entity.Property(e => e.Policybalance)
                    .HasColumnType("decimal(17, 2)")
                    .HasColumnName("POLICYBALANCE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Tagdetails)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("TAGDETAILS");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<TempReversedTagScholarship5>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_REVERSED_TAG_SCHOLARSHIP5");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<TempReversedTagScholarshipFresher5>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_REVERSED_TAG_SCHOLARSHIP_FRESHER5");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<TempScholarship>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_SCHOLARSHIP");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400)
                    .HasColumnName("NAME");

                entity.Property(e => e.Programme)
                    .IsRequired()
                    .HasColumnName("PROGRAMME");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<TempStudent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_STUDENT");

                entity.Property(e => e.Indexno)
                    .HasMaxLength(50)
                    .HasColumnName("INDEXNO");

                entity.Property(e => e.Optionid).HasColumnName("OPTIONID");

                entity.Property(e => e.Psid).HasColumnName("PSID");

                entity.Property(e => e.Yr).HasColumnName("YR");
            });

            modelBuilder.Entity<TempStudentprogrammeduration>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_STUDENTPROGRAMMEDURATION");

                entity.Property(e => e.Acadyearenrolled).HasColumnName("ACADYEARENROLLED");

                entity.Property(e => e.Duration).HasColumnName("DURATION");

                entity.Property(e => e.Programme)
                    .HasMaxLength(100)
                    .HasColumnName("PROGRAMME");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Yearlevel).HasColumnName("YEARLEVEL");
            });

            modelBuilder.Entity<TempStudentsupport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_STUDENTSUPPORT");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Support)
                    .HasMaxLength(10)
                    .HasColumnName("SUPPORT")
                    .IsFixedLength(true);

                entity.Property(e => e.Type)
                    .HasMaxLength(10)
                    .HasColumnName("TYPE")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TempTagstdfee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_TAGSTDFEES");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Feecategoryid).HasColumnName("FEECATEGORYID");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(100)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.IsbiometricallyOrCourseregistered)
                    .HasMaxLength(10)
                    .HasColumnName("ISBIOMETRICALLY_OR_COURSEREGISTERED")
                    .IsFixedLength(true);

                entity.Property(e => e.Isbiometricallyverified).HasColumnName("ISBIOMETRICALLYVERIFIED");

                entity.Property(e => e.Iscourseregistered).HasColumnName("ISCOURSEREGISTERED");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<TempVodadata1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_VODADATA1");

                entity.Property(e => e.Serviceno)
                    .HasMaxLength(255)
                    .HasColumnName("serviceno");

                entity.Property(e => e.Vmonth).HasColumnName("vmonth");
            });

            modelBuilder.Entity<TempVodadatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_VODADATA");

                entity.Property(e => e.Serviceno)
                    .HasMaxLength(255)
                    .HasColumnName("SERVICENO");

                entity.Property(e => e.Vmonth).HasColumnName("VMONTH");
            });

            modelBuilder.Entity<TempVodadistribution>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_VODADISTRIBUTION");

                entity.Property(e => e.Dateissued)
                    .HasColumnType("datetime")
                    .HasColumnName("DATEISSUED");

                entity.Property(e => e.Dmonth).HasColumnName("DMONTH");

                entity.Property(e => e.Schoolmobile)
                    .HasMaxLength(50)
                    .HasColumnName("SCHOOLMOBILE");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(50)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<TempVodafonevalidno>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_VODAFONEVALIDNO");

                entity.Property(e => e.Idnumber)
                    .HasMaxLength(20)
                    .HasColumnName("IDNUMBER");

                entity.Property(e => e.Schoolmobile)
                    .HasMaxLength(20)
                    .HasColumnName("SCHOOLMOBILE");

                entity.Property(e => e.Schoolmobileserialno)
                    .HasMaxLength(20)
                    .HasColumnName("SCHOOLMOBILESERIALNO");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .HasColumnName("STATUS")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TempVodaserv>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_VODASERV");

                entity.Property(e => e.Serviceno)
                    .HasMaxLength(50)
                    .HasColumnName("SERVICENO");
            });

            modelBuilder.Entity<Temparmisreconciled>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMPARMISRECONCILED");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(19, 9)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.Cr).HasColumnName("CR");

                entity.Property(e => e.Dr).HasColumnName("DR");

                entity.Property(e => e.Payername)
                    .HasMaxLength(100)
                    .HasColumnName("PAYERNAME");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Transdate).HasColumnName("TRANSDATE");

                entity.Property(e => e.Transdetails)
                    .HasMaxLength(250)
                    .HasColumnName("TRANSDETAILS");

                entity.Property(e => e.Transid)
                    .HasMaxLength(100)
                    .HasColumnName("TRANSID");
            });

            modelBuilder.Entity<Temparmisx>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMPARMISX");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(19, 9)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.Cr).HasColumnName("CR");

                entity.Property(e => e.Currencyid)
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Dr).HasColumnName("DR");

                entity.Property(e => e.Isexcluded).HasColumnName("ISEXCLUDED");

                entity.Property(e => e.Payername)
                    .HasMaxLength(100)
                    .HasColumnName("PAYERNAME");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Transdate).HasColumnName("TRANSDATE");

                entity.Property(e => e.Transdetails)
                    .HasMaxLength(250)
                    .HasColumnName("TRANSDETAILS");

                entity.Property(e => e.Transid)
                    .HasMaxLength(100)
                    .HasColumnName("TRANSID");
            });

            modelBuilder.Entity<Tempcredential>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMPCREDENTIALS");

                entity.Property(e => e.Schoolemail)
                    .HasMaxLength(100)
                    .HasColumnName("SCHOOLEMAIL");

                entity.Property(e => e.Schoolpwd)
                    .HasMaxLength(50)
                    .HasColumnName("SCHOOLPWD");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<Tempdel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMPDEL");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Acadyearstring)
                    .HasMaxLength(20)
                    .HasColumnName("ACADYEARSTRING");

                entity.Property(e => e.Amountpaidsem)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("AMOUNTPAIDSEM");

                entity.Property(e => e.Campus)
                    .HasMaxLength(100)
                    .HasColumnName("CAMPUS");

                entity.Property(e => e.Campusid).HasColumnName("CAMPUSID");

                entity.Property(e => e.College)
                    .HasMaxLength(100)
                    .HasColumnName("COLLEGE");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Denom)
                    .HasMaxLength(100)
                    .HasColumnName("DENOM");

                entity.Property(e => e.Denomination)
                    .HasMaxLength(100)
                    .HasColumnName("DENOMINATION");

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .HasColumnName("DEPARTMENT");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Faculty)
                    .HasMaxLength(100)
                    .HasColumnName("FACULTY");

                entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");

                entity.Property(e => e.Feecategory)
                    .HasMaxLength(100)
                    .HasColumnName("FEECATEGORY");

                entity.Property(e => e.Feecategoryid).HasColumnName("FEECATEGORYID");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(100)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Graduatetype)
                    .HasMaxLength(100)
                    .HasColumnName("GRADUATETYPE");

                entity.Property(e => e.Graduatetypeid).HasColumnName("GRADUATETYPEID");

                entity.Property(e => e.IsbiometricallyOrCourseregistered).HasColumnName("ISBIOMETRICALLY_OR_COURSEREGISTERED");

                entity.Property(e => e.Isbiometricallyverified).HasColumnName("ISBIOMETRICALLYVERIFIED");

                entity.Property(e => e.Iscourseregistered).HasColumnName("ISCOURSEREGISTERED");

                entity.Property(e => e.Isforeigner).HasColumnName("ISFOREIGNER");

                entity.Property(e => e.Isghanaian).HasColumnName("ISGHANAIAN");

                entity.Property(e => e.Isinfinalyear).HasColumnName("ISINFINALYEAR");

                entity.Property(e => e.Isingraceperiod).HasColumnName("ISINGRACEPERIOD");

                entity.Property(e => e.Othername)
                    .HasMaxLength(50)
                    .HasColumnName("OTHERNAME");

                entity.Property(e => e.Primarymobile)
                    .HasMaxLength(20)
                    .HasColumnName("PRIMARYMOBILE");

                entity.Property(e => e.Programmestream)
                    .HasMaxLength(100)
                    .HasColumnName("PROGRAMMESTREAM");

                entity.Property(e => e.ProgrammestreamBiometricverificationrequired).HasColumnName("PROGRAMMESTREAM_BIOMETRICVERIFICATIONREQUIRED");

                entity.Property(e => e.Schoolmobile)
                    .HasMaxLength(20)
                    .HasColumnName("SCHOOLMOBILE");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.StudentBill4Acadyear).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.StudentMinPaymentAmountRequired).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.StudentSemFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentcategoryname)
                    .HasMaxLength(50)
                    .HasColumnName("STUDENTCATEGORYNAME");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("SURNAME");

                entity.Property(e => e.Tag)
                    .HasMaxLength(50)
                    .HasColumnName("TAG");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Yr).HasColumnName("YR");
            });

            modelBuilder.Entity<Tempdel2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMPDEL2");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Acadyearstring)
                    .HasMaxLength(20)
                    .HasColumnName("ACADYEARSTRING");

                entity.Property(e => e.Birthdate)
                    .HasColumnType("date")
                    .HasColumnName("BIRTHDATE");

                entity.Property(e => e.Campus)
                    .HasMaxLength(100)
                    .HasColumnName("CAMPUS");

                entity.Property(e => e.Campusid).HasColumnName("CAMPUSID");

                entity.Property(e => e.College)
                    .HasMaxLength(100)
                    .HasColumnName("COLLEGE");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .HasColumnName("DEPARTMENT");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Faculty)
                    .HasMaxLength(100)
                    .HasColumnName("FACULTY");

                entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");

                entity.Property(e => e.Feecategory)
                    .HasMaxLength(100)
                    .HasColumnName("FEECATEGORY");

                entity.Property(e => e.Feecategoryid).HasColumnName("FEECATEGORYID");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(100)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Graduatetype)
                    .HasMaxLength(100)
                    .HasColumnName("GRADUATETYPE");

                entity.Property(e => e.Graduatetypeid).HasColumnName("GRADUATETYPEID");

                entity.Property(e => e.IsbiometricallyOrCourseregistered).HasColumnName("ISBIOMETRICALLY_OR_COURSEREGISTERED");

                entity.Property(e => e.Isbiometricallyverified).HasColumnName("ISBIOMETRICALLYVERIFIED");

                entity.Property(e => e.Iscourseregistered).HasColumnName("ISCOURSEREGISTERED");

                entity.Property(e => e.Isforeigner).HasColumnName("ISFOREIGNER");

                entity.Property(e => e.Isghanaian).HasColumnName("ISGHANAIAN");

                entity.Property(e => e.Isinfinalyear).HasColumnName("ISINFINALYEAR");

                entity.Property(e => e.Isingraceperiod).HasColumnName("ISINGRACEPERIOD");

                entity.Property(e => e.Othername)
                    .HasMaxLength(50)
                    .HasColumnName("OTHERNAME");

                entity.Property(e => e.Primarymobile)
                    .HasMaxLength(20)
                    .HasColumnName("PRIMARYMOBILE");

                entity.Property(e => e.Programmestream)
                    .HasMaxLength(100)
                    .HasColumnName("PROGRAMMESTREAM");

                entity.Property(e => e.ProgrammestreamBiometricverificationrequired).HasColumnName("PROGRAMMESTREAM_BIOMETRICVERIFICATIONREQUIRED");

                entity.Property(e => e.Schoolmobile)
                    .HasMaxLength(20)
                    .HasColumnName("SCHOOLMOBILE");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentcategoryname)
                    .HasMaxLength(50)
                    .HasColumnName("STUDENTCATEGORYNAME");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("SURNAME");

                entity.Property(e => e.Tag)
                    .HasMaxLength(50)
                    .HasColumnName("TAG");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Yr).HasColumnName("YR");
            });

            modelBuilder.Entity<TempdelBoampongdelete>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMPDEL_BOAMPONGDELETE");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Acadyearstring)
                    .HasMaxLength(20)
                    .HasColumnName("ACADYEARSTRING");

                entity.Property(e => e.Campus)
                    .HasMaxLength(100)
                    .HasColumnName("CAMPUS");

                entity.Property(e => e.Campusid).HasColumnName("CAMPUSID");

                entity.Property(e => e.College)
                    .HasMaxLength(100)
                    .HasColumnName("COLLEGE");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Denom)
                    .HasMaxLength(100)
                    .HasColumnName("DENOM");

                entity.Property(e => e.Denomination)
                    .HasMaxLength(100)
                    .HasColumnName("DENOMINATION");

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .HasColumnName("DEPARTMENT");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Faculty)
                    .HasMaxLength(100)
                    .HasColumnName("FACULTY");

                entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");

                entity.Property(e => e.Feecategory)
                    .HasMaxLength(100)
                    .HasColumnName("FEECATEGORY");

                entity.Property(e => e.Feecategoryid).HasColumnName("FEECATEGORYID");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(100)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Graduatetype)
                    .HasMaxLength(100)
                    .HasColumnName("GRADUATETYPE");

                entity.Property(e => e.Graduatetypeid).HasColumnName("GRADUATETYPEID");

                entity.Property(e => e.IsbiometricallyOrCourseregistered).HasColumnName("ISBIOMETRICALLY_OR_COURSEREGISTERED");

                entity.Property(e => e.Isbiometricallyverified).HasColumnName("ISBIOMETRICALLYVERIFIED");

                entity.Property(e => e.Iscourseregistered).HasColumnName("ISCOURSEREGISTERED");

                entity.Property(e => e.Isforeigner).HasColumnName("ISFOREIGNER");

                entity.Property(e => e.Isghanaian).HasColumnName("ISGHANAIAN");

                entity.Property(e => e.Isinfinalyear).HasColumnName("ISINFINALYEAR");

                entity.Property(e => e.Isingraceperiod).HasColumnName("ISINGRACEPERIOD");

                entity.Property(e => e.Othername)
                    .HasMaxLength(50)
                    .HasColumnName("OTHERNAME");

                entity.Property(e => e.Primarymobile)
                    .HasMaxLength(20)
                    .HasColumnName("PRIMARYMOBILE");

                entity.Property(e => e.Programmestream)
                    .HasMaxLength(100)
                    .HasColumnName("PROGRAMMESTREAM");

                entity.Property(e => e.ProgrammestreamBiometricverificationrequired).HasColumnName("PROGRAMMESTREAM_BIOMETRICVERIFICATIONREQUIRED");

                entity.Property(e => e.Schoolmobile)
                    .HasMaxLength(20)
                    .HasColumnName("SCHOOLMOBILE");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentcategoryname)
                    .HasMaxLength(50)
                    .HasColumnName("STUDENTCATEGORYNAME");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("SURNAME");

                entity.Property(e => e.Tag)
                    .HasMaxLength(50)
                    .HasColumnName("TAG");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Yr).HasColumnName("YR");
            });

            modelBuilder.Entity<Tempdelfee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMPDELFEES");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Acadyearstring)
                    .HasMaxLength(20)
                    .HasColumnName("ACADYEARSTRING");

                entity.Property(e => e.Amountpaidsem)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("AMOUNTPAIDSEM");

                entity.Property(e => e.Birthdate)
                    .HasColumnType("date")
                    .HasColumnName("BIRTHDATE");

                entity.Property(e => e.Campus)
                    .HasMaxLength(100)
                    .HasColumnName("CAMPUS");

                entity.Property(e => e.Campusid).HasColumnName("CAMPUSID");

                entity.Property(e => e.College)
                    .HasMaxLength(100)
                    .HasColumnName("COLLEGE");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Denom)
                    .HasMaxLength(100)
                    .HasColumnName("DENOM");

                entity.Property(e => e.Denomination)
                    .HasMaxLength(100)
                    .HasColumnName("DENOMINATION");

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .HasColumnName("DEPARTMENT");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Faculty)
                    .HasMaxLength(100)
                    .HasColumnName("FACULTY");

                entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");

                entity.Property(e => e.Feecategory)
                    .HasMaxLength(100)
                    .HasColumnName("FEECATEGORY");

                entity.Property(e => e.Feecategoryid).HasColumnName("FEECATEGORYID");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(100)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Graduatetype)
                    .HasMaxLength(100)
                    .HasColumnName("GRADUATETYPE");

                entity.Property(e => e.Graduatetypeid).HasColumnName("GRADUATETYPEID");

                entity.Property(e => e.IsbiometricallyOrCourseregistered).HasColumnName("ISBIOMETRICALLY_OR_COURSEREGISTERED");

                entity.Property(e => e.Isbiometricallyverified).HasColumnName("ISBIOMETRICALLYVERIFIED");

                entity.Property(e => e.Iscourseregistered).HasColumnName("ISCOURSEREGISTERED");

                entity.Property(e => e.Isforeigner).HasColumnName("ISFOREIGNER");

                entity.Property(e => e.Isghanaian).HasColumnName("ISGHANAIAN");

                entity.Property(e => e.Isinfinalyear).HasColumnName("ISINFINALYEAR");

                entity.Property(e => e.Isingraceperiod).HasColumnName("ISINGRACEPERIOD");

                entity.Property(e => e.Othername)
                    .HasMaxLength(50)
                    .HasColumnName("OTHERNAME");

                entity.Property(e => e.Primarymobile)
                    .HasMaxLength(20)
                    .HasColumnName("PRIMARYMOBILE");

                entity.Property(e => e.Programmestream)
                    .HasMaxLength(100)
                    .HasColumnName("PROGRAMMESTREAM");

                entity.Property(e => e.ProgrammestreamBiometricverificationrequired).HasColumnName("PROGRAMMESTREAM_BIOMETRICVERIFICATIONREQUIRED");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Schoolmobile)
                    .HasMaxLength(20)
                    .HasColumnName("SCHOOLMOBILE");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.StudentBill4Acadyear).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.StudentMinPaymentAmountRequired).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.StudentSemFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentcategoryname)
                    .HasMaxLength(50)
                    .HasColumnName("STUDENTCATEGORYNAME");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("SURNAME");

                entity.Property(e => e.Tag)
                    .HasMaxLength(50)
                    .HasColumnName("TAG");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");
            });

            modelBuilder.Entity<Tempdelfees2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMPDELFEES2");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Acadyearstring)
                    .HasMaxLength(20)
                    .HasColumnName("ACADYEARSTRING");

                entity.Property(e => e.Amountpaidsem)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("AMOUNTPAIDSEM");

                entity.Property(e => e.Birthdate)
                    .HasColumnType("date")
                    .HasColumnName("BIRTHDATE");

                entity.Property(e => e.Campus)
                    .HasMaxLength(100)
                    .HasColumnName("CAMPUS");

                entity.Property(e => e.Campusid).HasColumnName("CAMPUSID");

                entity.Property(e => e.College)
                    .HasMaxLength(100)
                    .HasColumnName("COLLEGE");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Denom)
                    .HasMaxLength(100)
                    .HasColumnName("DENOM");

                entity.Property(e => e.Denomination)
                    .HasMaxLength(100)
                    .HasColumnName("DENOMINATION");

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .HasColumnName("DEPARTMENT");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Faculty)
                    .HasMaxLength(100)
                    .HasColumnName("FACULTY");

                entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");

                entity.Property(e => e.Feecategory)
                    .HasMaxLength(100)
                    .HasColumnName("FEECATEGORY");

                entity.Property(e => e.Feecategoryid).HasColumnName("FEECATEGORYID");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(100)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Graduatetype)
                    .HasMaxLength(100)
                    .HasColumnName("GRADUATETYPE");

                entity.Property(e => e.Graduatetypeid).HasColumnName("GRADUATETYPEID");

                entity.Property(e => e.IsbiometricallyOrCourseregistered).HasColumnName("ISBIOMETRICALLY_OR_COURSEREGISTERED");

                entity.Property(e => e.Isbiometricallyverified).HasColumnName("ISBIOMETRICALLYVERIFIED");

                entity.Property(e => e.Iscourseregistered).HasColumnName("ISCOURSEREGISTERED");

                entity.Property(e => e.Isforeigner).HasColumnName("ISFOREIGNER");

                entity.Property(e => e.Isghanaian).HasColumnName("ISGHANAIAN");

                entity.Property(e => e.Isinfinalyear).HasColumnName("ISINFINALYEAR");

                entity.Property(e => e.Isingraceperiod).HasColumnName("ISINGRACEPERIOD");

                entity.Property(e => e.Othername)
                    .HasMaxLength(50)
                    .HasColumnName("OTHERNAME");

                entity.Property(e => e.Primarymobile)
                    .HasMaxLength(20)
                    .HasColumnName("PRIMARYMOBILE");

                entity.Property(e => e.Programmestream)
                    .HasMaxLength(100)
                    .HasColumnName("PROGRAMMESTREAM");

                entity.Property(e => e.ProgrammestreamBiometricverificationrequired).HasColumnName("PROGRAMMESTREAM_BIOMETRICVERIFICATIONREQUIRED");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Schoolmobile)
                    .HasMaxLength(20)
                    .HasColumnName("SCHOOLMOBILE");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.StudentBill4Acadyear).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.StudentMinArrersRequired).HasColumnType("decimal(16, 3)");

                entity.Property(e => e.StudentMinPaymentAmountRequired).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.StudentSemFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentcategoryname)
                    .HasMaxLength(50)
                    .HasColumnName("STUDENTCATEGORYNAME");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("SURNAME");

                entity.Property(e => e.Tag)
                    .HasMaxLength(50)
                    .HasColumnName("TAG");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");
            });

            modelBuilder.Entity<TempdelfeesPolicy>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMPDELFEES_POLICY");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Acadyearstring)
                    .HasMaxLength(20)
                    .HasColumnName("ACADYEARSTRING");

                entity.Property(e => e.Amountpaidsem)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("AMOUNTPAIDSEM");

                entity.Property(e => e.Campus)
                    .HasMaxLength(100)
                    .HasColumnName("CAMPUS");

                entity.Property(e => e.Campusid).HasColumnName("CAMPUSID");

                entity.Property(e => e.College)
                    .HasMaxLength(100)
                    .HasColumnName("COLLEGE");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .HasColumnName("DEPARTMENT");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Faculty)
                    .HasMaxLength(100)
                    .HasColumnName("FACULTY");

                entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");

                entity.Property(e => e.Feecategory)
                    .HasMaxLength(100)
                    .HasColumnName("FEECATEGORY");

                entity.Property(e => e.Feecategoryid).HasColumnName("FEECATEGORYID");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(100)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.Graduatetype)
                    .HasMaxLength(100)
                    .HasColumnName("GRADUATETYPE");

                entity.Property(e => e.Graduatetypeid).HasColumnName("GRADUATETYPEID");

                entity.Property(e => e.IsbiometricallyOrCourseregistered).HasColumnName("ISBIOMETRICALLY_OR_COURSEREGISTERED");

                entity.Property(e => e.Isbiometricallyverified).HasColumnName("ISBIOMETRICALLYVERIFIED");

                entity.Property(e => e.Iscourseregistered).HasColumnName("ISCOURSEREGISTERED");

                entity.Property(e => e.Isforeigner).HasColumnName("ISFOREIGNER");

                entity.Property(e => e.Isghanaian).HasColumnName("ISGHANAIAN");

                entity.Property(e => e.Isinfinalyear).HasColumnName("ISINFINALYEAR");

                entity.Property(e => e.Isingraceperiod).HasColumnName("ISINGRACEPERIOD");

                entity.Property(e => e.Minamount70)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_70");

                entity.Property(e => e.MinamountPolicy)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_POLICY");

                entity.Property(e => e.Othername)
                    .HasMaxLength(50)
                    .HasColumnName("OTHERNAME");

                entity.Property(e => e.Primarymobile)
                    .HasMaxLength(20)
                    .HasColumnName("PRIMARYMOBILE");

                entity.Property(e => e.Programmestream)
                    .HasMaxLength(100)
                    .HasColumnName("PROGRAMMESTREAM");

                entity.Property(e => e.ProgrammestreamBiometricverificationrequired).HasColumnName("PROGRAMMESTREAM_BIOMETRICVERIFICATIONREQUIRED");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Schoolmobile)
                    .HasMaxLength(20)
                    .HasColumnName("SCHOOLMOBILE");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.StudentBill4Acadyear).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.StudentMinPaymentAmountRequired).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.StudentSemFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentcategoryname)
                    .HasMaxLength(50)
                    .HasColumnName("STUDENTCATEGORYNAME");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("SURNAME");

                entity.Property(e => e.Tag)
                    .HasMaxLength(50)
                    .HasColumnName("TAG");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Totalamount)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("TOTALAMOUNT");
            });

            modelBuilder.Entity<TempdelfeesPolicy20220422>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMPDELFEES_POLICY_20220422");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Acadyearstring)
                    .HasMaxLength(20)
                    .HasColumnName("ACADYEARSTRING");

                entity.Property(e => e.Amountpaidsem)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("AMOUNTPAIDSEM");

                entity.Property(e => e.Campus)
                    .HasMaxLength(100)
                    .HasColumnName("CAMPUS");

                entity.Property(e => e.Campusid).HasColumnName("CAMPUSID");

                entity.Property(e => e.College)
                    .HasMaxLength(100)
                    .HasColumnName("COLLEGE");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .HasColumnName("DEPARTMENT");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Faculty)
                    .HasMaxLength(100)
                    .HasColumnName("FACULTY");

                entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");

                entity.Property(e => e.Feecategory)
                    .HasMaxLength(100)
                    .HasColumnName("FEECATEGORY");

                entity.Property(e => e.Feecategoryid).HasColumnName("FEECATEGORYID");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(100)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.Graduatetype)
                    .HasMaxLength(100)
                    .HasColumnName("GRADUATETYPE");

                entity.Property(e => e.Graduatetypeid).HasColumnName("GRADUATETYPEID");

                entity.Property(e => e.IsbiometricallyOrCourseregistered).HasColumnName("ISBIOMETRICALLY_OR_COURSEREGISTERED");

                entity.Property(e => e.Isbiometricallyverified).HasColumnName("ISBIOMETRICALLYVERIFIED");

                entity.Property(e => e.Iscourseregistered).HasColumnName("ISCOURSEREGISTERED");

                entity.Property(e => e.Isforeigner).HasColumnName("ISFOREIGNER");

                entity.Property(e => e.Isghanaian).HasColumnName("ISGHANAIAN");

                entity.Property(e => e.Isinfinalyear).HasColumnName("ISINFINALYEAR");

                entity.Property(e => e.Isingraceperiod).HasColumnName("ISINGRACEPERIOD");

                entity.Property(e => e.Minamount70)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_70");

                entity.Property(e => e.MinamountPolicy)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_POLICY");

                entity.Property(e => e.Othername)
                    .HasMaxLength(50)
                    .HasColumnName("OTHERNAME");

                entity.Property(e => e.Primarymobile)
                    .HasMaxLength(20)
                    .HasColumnName("PRIMARYMOBILE");

                entity.Property(e => e.Programmestream)
                    .HasMaxLength(100)
                    .HasColumnName("PROGRAMMESTREAM");

                entity.Property(e => e.ProgrammestreamBiometricverificationrequired).HasColumnName("PROGRAMMESTREAM_BIOMETRICVERIFICATIONREQUIRED");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Schoolmobile)
                    .HasMaxLength(20)
                    .HasColumnName("SCHOOLMOBILE");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.StudentBill4Acadyear).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.StudentMinPaymentAmountRequired).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.StudentSemFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentcategoryname)
                    .HasMaxLength(50)
                    .HasColumnName("STUDENTCATEGORYNAME");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("SURNAME");

                entity.Property(e => e.Tag)
                    .HasMaxLength(50)
                    .HasColumnName("TAG");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Totalamount)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("TOTALAMOUNT");
            });

            modelBuilder.Entity<TempdelfeesPolicy20220425>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMPDELFEES_POLICY_20220425");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Acadyearstring)
                    .HasMaxLength(20)
                    .HasColumnName("ACADYEARSTRING");

                entity.Property(e => e.Amountpaidsem)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("AMOUNTPAIDSEM");

                entity.Property(e => e.Campus)
                    .HasMaxLength(100)
                    .HasColumnName("CAMPUS");

                entity.Property(e => e.Campusid).HasColumnName("CAMPUSID");

                entity.Property(e => e.College)
                    .HasMaxLength(100)
                    .HasColumnName("COLLEGE");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .HasColumnName("DEPARTMENT");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Faculty)
                    .HasMaxLength(100)
                    .HasColumnName("FACULTY");

                entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");

                entity.Property(e => e.Feecategory)
                    .HasMaxLength(100)
                    .HasColumnName("FEECATEGORY");

                entity.Property(e => e.Feecategoryid).HasColumnName("FEECATEGORYID");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(100)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.Graduatetype)
                    .HasMaxLength(100)
                    .HasColumnName("GRADUATETYPE");

                entity.Property(e => e.Graduatetypeid).HasColumnName("GRADUATETYPEID");

                entity.Property(e => e.IsbiometricallyOrCourseregistered).HasColumnName("ISBIOMETRICALLY_OR_COURSEREGISTERED");

                entity.Property(e => e.Isbiometricallyverified).HasColumnName("ISBIOMETRICALLYVERIFIED");

                entity.Property(e => e.Iscourseregistered).HasColumnName("ISCOURSEREGISTERED");

                entity.Property(e => e.Isforeigner).HasColumnName("ISFOREIGNER");

                entity.Property(e => e.Isghanaian).HasColumnName("ISGHANAIAN");

                entity.Property(e => e.Isinfinalyear).HasColumnName("ISINFINALYEAR");

                entity.Property(e => e.Isingraceperiod).HasColumnName("ISINGRACEPERIOD");

                entity.Property(e => e.Minamount70)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_70");

                entity.Property(e => e.MinamountPolicy)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_POLICY");

                entity.Property(e => e.Othername)
                    .HasMaxLength(50)
                    .HasColumnName("OTHERNAME");

                entity.Property(e => e.Primarymobile)
                    .HasMaxLength(20)
                    .HasColumnName("PRIMARYMOBILE");

                entity.Property(e => e.Programmestream)
                    .HasMaxLength(100)
                    .HasColumnName("PROGRAMMESTREAM");

                entity.Property(e => e.ProgrammestreamBiometricverificationrequired).HasColumnName("PROGRAMMESTREAM_BIOMETRICVERIFICATIONREQUIRED");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Schoolmobile)
                    .HasMaxLength(20)
                    .HasColumnName("SCHOOLMOBILE");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.StudentBill4Acadyear).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.StudentMinPaymentAmountRequired).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.StudentSemFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentcategoryname)
                    .HasMaxLength(50)
                    .HasColumnName("STUDENTCATEGORYNAME");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("SURNAME");

                entity.Property(e => e.Tag)
                    .HasMaxLength(50)
                    .HasColumnName("TAG");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Totalamount)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("TOTALAMOUNT");
            });

            modelBuilder.Entity<TempdelfeesPolicy20220428>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMPDELFEES_POLICY_20220428");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Acadyearstring)
                    .HasMaxLength(20)
                    .HasColumnName("ACADYEARSTRING");

                entity.Property(e => e.Amountpaidsem)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("AMOUNTPAIDSEM");

                entity.Property(e => e.Campus)
                    .HasMaxLength(100)
                    .HasColumnName("CAMPUS");

                entity.Property(e => e.Campusid).HasColumnName("CAMPUSID");

                entity.Property(e => e.College)
                    .HasMaxLength(100)
                    .HasColumnName("COLLEGE");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .HasColumnName("DEPARTMENT");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Faculty)
                    .HasMaxLength(100)
                    .HasColumnName("FACULTY");

                entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");

                entity.Property(e => e.Feecategory)
                    .HasMaxLength(100)
                    .HasColumnName("FEECATEGORY");

                entity.Property(e => e.Feecategoryid).HasColumnName("FEECATEGORYID");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(100)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.Graduatetype)
                    .HasMaxLength(100)
                    .HasColumnName("GRADUATETYPE");

                entity.Property(e => e.Graduatetypeid).HasColumnName("GRADUATETYPEID");

                entity.Property(e => e.IsbiometricallyOrCourseregistered).HasColumnName("ISBIOMETRICALLY_OR_COURSEREGISTERED");

                entity.Property(e => e.Isbiometricallyverified).HasColumnName("ISBIOMETRICALLYVERIFIED");

                entity.Property(e => e.Iscourseregistered).HasColumnName("ISCOURSEREGISTERED");

                entity.Property(e => e.Isforeigner).HasColumnName("ISFOREIGNER");

                entity.Property(e => e.Isghanaian).HasColumnName("ISGHANAIAN");

                entity.Property(e => e.Isinfinalyear).HasColumnName("ISINFINALYEAR");

                entity.Property(e => e.Isingraceperiod).HasColumnName("ISINGRACEPERIOD");

                entity.Property(e => e.Minamount70)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_70");

                entity.Property(e => e.MinamountPolicy)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_POLICY");

                entity.Property(e => e.Othername)
                    .HasMaxLength(50)
                    .HasColumnName("OTHERNAME");

                entity.Property(e => e.Primarymobile)
                    .HasMaxLength(20)
                    .HasColumnName("PRIMARYMOBILE");

                entity.Property(e => e.Programmestream)
                    .HasMaxLength(100)
                    .HasColumnName("PROGRAMMESTREAM");

                entity.Property(e => e.ProgrammestreamBiometricverificationrequired).HasColumnName("PROGRAMMESTREAM_BIOMETRICVERIFICATIONREQUIRED");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Schoolmobile)
                    .HasMaxLength(20)
                    .HasColumnName("SCHOOLMOBILE");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.StudentBill4Acadyear).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.StudentMinPaymentAmountRequired).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.StudentSemFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentcategoryname)
                    .HasMaxLength(50)
                    .HasColumnName("STUDENTCATEGORYNAME");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("SURNAME");

                entity.Property(e => e.Tag)
                    .HasMaxLength(50)
                    .HasColumnName("TAG");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Totalamount)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("TOTALAMOUNT");
            });

            modelBuilder.Entity<TempdelfeesPolicy20220511>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMPDELFEES_POLICY_20220511");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Acadyearstring)
                    .HasMaxLength(20)
                    .HasColumnName("ACADYEARSTRING");

                entity.Property(e => e.Amountpaidsem)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("AMOUNTPAIDSEM");

                entity.Property(e => e.Campus)
                    .HasMaxLength(100)
                    .HasColumnName("CAMPUS");

                entity.Property(e => e.Campusid).HasColumnName("CAMPUSID");

                entity.Property(e => e.College)
                    .HasMaxLength(100)
                    .HasColumnName("COLLEGE");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .HasColumnName("DEPARTMENT");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Faculty)
                    .HasMaxLength(100)
                    .HasColumnName("FACULTY");

                entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");

                entity.Property(e => e.Feecategory)
                    .HasMaxLength(100)
                    .HasColumnName("FEECATEGORY");

                entity.Property(e => e.Feecategoryid).HasColumnName("FEECATEGORYID");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(100)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.Graduatetype)
                    .HasMaxLength(100)
                    .HasColumnName("GRADUATETYPE");

                entity.Property(e => e.Graduatetypeid).HasColumnName("GRADUATETYPEID");

                entity.Property(e => e.IsbiometricallyOrCourseregistered).HasColumnName("ISBIOMETRICALLY_OR_COURSEREGISTERED");

                entity.Property(e => e.Isbiometricallyverified).HasColumnName("ISBIOMETRICALLYVERIFIED");

                entity.Property(e => e.Iscourseregistered).HasColumnName("ISCOURSEREGISTERED");

                entity.Property(e => e.Isforeigner).HasColumnName("ISFOREIGNER");

                entity.Property(e => e.Isghanaian).HasColumnName("ISGHANAIAN");

                entity.Property(e => e.Isinfinalyear).HasColumnName("ISINFINALYEAR");

                entity.Property(e => e.Isingraceperiod).HasColumnName("ISINGRACEPERIOD");

                entity.Property(e => e.Minamount70)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_70");

                entity.Property(e => e.MinamountPolicy)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_POLICY");

                entity.Property(e => e.Othername)
                    .HasMaxLength(50)
                    .HasColumnName("OTHERNAME");

                entity.Property(e => e.Primarymobile)
                    .HasMaxLength(20)
                    .HasColumnName("PRIMARYMOBILE");

                entity.Property(e => e.Programmestream)
                    .HasMaxLength(100)
                    .HasColumnName("PROGRAMMESTREAM");

                entity.Property(e => e.ProgrammestreamBiometricverificationrequired).HasColumnName("PROGRAMMESTREAM_BIOMETRICVERIFICATIONREQUIRED");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Schoolmobile)
                    .HasMaxLength(20)
                    .HasColumnName("SCHOOLMOBILE");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.StudentBill4Acadyear).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.StudentMinPaymentAmountRequired).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.StudentSemFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentcategoryname)
                    .HasMaxLength(50)
                    .HasColumnName("STUDENTCATEGORYNAME");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("SURNAME");

                entity.Property(e => e.Tag)
                    .HasMaxLength(50)
                    .HasColumnName("TAG");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Totalamount)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("TOTALAMOUNT");
            });

            modelBuilder.Entity<TempdelfeesPolicy20220515>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMPDELFEES_POLICY_20220515");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Acadyearstring)
                    .HasMaxLength(20)
                    .HasColumnName("ACADYEARSTRING");

                entity.Property(e => e.Amountpaidsem)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("AMOUNTPAIDSEM");

                entity.Property(e => e.Campus)
                    .HasMaxLength(100)
                    .HasColumnName("CAMPUS");

                entity.Property(e => e.Campusid).HasColumnName("CAMPUSID");

                entity.Property(e => e.College)
                    .HasMaxLength(100)
                    .HasColumnName("COLLEGE");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .HasColumnName("DEPARTMENT");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Faculty)
                    .HasMaxLength(100)
                    .HasColumnName("FACULTY");

                entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");

                entity.Property(e => e.Feecategory)
                    .HasMaxLength(100)
                    .HasColumnName("FEECATEGORY");

                entity.Property(e => e.Feecategoryid).HasColumnName("FEECATEGORYID");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(100)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.Graduatetype)
                    .HasMaxLength(100)
                    .HasColumnName("GRADUATETYPE");

                entity.Property(e => e.Graduatetypeid).HasColumnName("GRADUATETYPEID");

                entity.Property(e => e.IsbiometricallyOrCourseregistered).HasColumnName("ISBIOMETRICALLY_OR_COURSEREGISTERED");

                entity.Property(e => e.Isbiometricallyverified).HasColumnName("ISBIOMETRICALLYVERIFIED");

                entity.Property(e => e.Iscourseregistered).HasColumnName("ISCOURSEREGISTERED");

                entity.Property(e => e.Isforeigner).HasColumnName("ISFOREIGNER");

                entity.Property(e => e.Isghanaian).HasColumnName("ISGHANAIAN");

                entity.Property(e => e.Isinfinalyear).HasColumnName("ISINFINALYEAR");

                entity.Property(e => e.Isingraceperiod).HasColumnName("ISINGRACEPERIOD");

                entity.Property(e => e.Minamount70)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_70");

                entity.Property(e => e.MinamountPolicy)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_POLICY");

                entity.Property(e => e.Othername)
                    .HasMaxLength(50)
                    .HasColumnName("OTHERNAME");

                entity.Property(e => e.Primarymobile)
                    .HasMaxLength(20)
                    .HasColumnName("PRIMARYMOBILE");

                entity.Property(e => e.Programmestream)
                    .HasMaxLength(100)
                    .HasColumnName("PROGRAMMESTREAM");

                entity.Property(e => e.ProgrammestreamBiometricverificationrequired).HasColumnName("PROGRAMMESTREAM_BIOMETRICVERIFICATIONREQUIRED");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Schoolmobile)
                    .HasMaxLength(20)
                    .HasColumnName("SCHOOLMOBILE");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.StudentBill4Acadyear).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.StudentMinPaymentAmountRequired).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.StudentSemFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentcategoryname)
                    .HasMaxLength(50)
                    .HasColumnName("STUDENTCATEGORYNAME");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("SURNAME");

                entity.Property(e => e.Tag)
                    .HasMaxLength(50)
                    .HasColumnName("TAG");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Totalamount)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("TOTALAMOUNT");
            });

            modelBuilder.Entity<TempdelfeesPolicy20220518>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMPDELFEES_POLICY_20220518");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Acadyearstring)
                    .HasMaxLength(20)
                    .HasColumnName("ACADYEARSTRING");

                entity.Property(e => e.Amountpaidsem)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("AMOUNTPAIDSEM");

                entity.Property(e => e.Campus)
                    .HasMaxLength(100)
                    .HasColumnName("CAMPUS");

                entity.Property(e => e.Campusid).HasColumnName("CAMPUSID");

                entity.Property(e => e.College)
                    .HasMaxLength(100)
                    .HasColumnName("COLLEGE");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .HasColumnName("DEPARTMENT");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Faculty)
                    .HasMaxLength(100)
                    .HasColumnName("FACULTY");

                entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");

                entity.Property(e => e.Feecategory)
                    .HasMaxLength(100)
                    .HasColumnName("FEECATEGORY");

                entity.Property(e => e.Feecategoryid).HasColumnName("FEECATEGORYID");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(100)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.Graduatetype)
                    .HasMaxLength(100)
                    .HasColumnName("GRADUATETYPE");

                entity.Property(e => e.Graduatetypeid).HasColumnName("GRADUATETYPEID");

                entity.Property(e => e.IsbiometricallyOrCourseregistered).HasColumnName("ISBIOMETRICALLY_OR_COURSEREGISTERED");

                entity.Property(e => e.Isbiometricallyverified).HasColumnName("ISBIOMETRICALLYVERIFIED");

                entity.Property(e => e.Iscourseregistered).HasColumnName("ISCOURSEREGISTERED");

                entity.Property(e => e.Isforeigner).HasColumnName("ISFOREIGNER");

                entity.Property(e => e.Isghanaian).HasColumnName("ISGHANAIAN");

                entity.Property(e => e.Isinfinalyear).HasColumnName("ISINFINALYEAR");

                entity.Property(e => e.Isingraceperiod).HasColumnName("ISINGRACEPERIOD");

                entity.Property(e => e.Minamount70)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_70");

                entity.Property(e => e.MinamountPolicy)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_POLICY");

                entity.Property(e => e.Othername)
                    .HasMaxLength(50)
                    .HasColumnName("OTHERNAME");

                entity.Property(e => e.Primarymobile)
                    .HasMaxLength(20)
                    .HasColumnName("PRIMARYMOBILE");

                entity.Property(e => e.Programmestream)
                    .HasMaxLength(100)
                    .HasColumnName("PROGRAMMESTREAM");

                entity.Property(e => e.ProgrammestreamBiometricverificationrequired).HasColumnName("PROGRAMMESTREAM_BIOMETRICVERIFICATIONREQUIRED");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Schoolmobile)
                    .HasMaxLength(20)
                    .HasColumnName("SCHOOLMOBILE");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.StudentBill4Acadyear).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.StudentMinPaymentAmountRequired).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.StudentSemFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentcategoryname)
                    .HasMaxLength(50)
                    .HasColumnName("STUDENTCATEGORYNAME");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("SURNAME");

                entity.Property(e => e.Tag)
                    .HasMaxLength(50)
                    .HasColumnName("TAG");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Totalamount)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("TOTALAMOUNT");
            });

            modelBuilder.Entity<TempdelfeesPolicy20220519>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMPDELFEES_POLICY_20220519");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Acadyearstring)
                    .HasMaxLength(20)
                    .HasColumnName("ACADYEARSTRING");

                entity.Property(e => e.Amountpaidsem)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("AMOUNTPAIDSEM");

                entity.Property(e => e.Campus)
                    .HasMaxLength(100)
                    .HasColumnName("CAMPUS");

                entity.Property(e => e.Campusid).HasColumnName("CAMPUSID");

                entity.Property(e => e.College)
                    .HasMaxLength(100)
                    .HasColumnName("COLLEGE");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .HasColumnName("DEPARTMENT");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Faculty)
                    .HasMaxLength(100)
                    .HasColumnName("FACULTY");

                entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");

                entity.Property(e => e.Feecategory)
                    .HasMaxLength(100)
                    .HasColumnName("FEECATEGORY");

                entity.Property(e => e.Feecategoryid).HasColumnName("FEECATEGORYID");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(100)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.Graduatetype)
                    .HasMaxLength(100)
                    .HasColumnName("GRADUATETYPE");

                entity.Property(e => e.Graduatetypeid).HasColumnName("GRADUATETYPEID");

                entity.Property(e => e.IsbiometricallyOrCourseregistered).HasColumnName("ISBIOMETRICALLY_OR_COURSEREGISTERED");

                entity.Property(e => e.Isbiometricallyverified).HasColumnName("ISBIOMETRICALLYVERIFIED");

                entity.Property(e => e.Iscourseregistered).HasColumnName("ISCOURSEREGISTERED");

                entity.Property(e => e.Isforeigner).HasColumnName("ISFOREIGNER");

                entity.Property(e => e.Isghanaian).HasColumnName("ISGHANAIAN");

                entity.Property(e => e.Isinfinalyear).HasColumnName("ISINFINALYEAR");

                entity.Property(e => e.Isingraceperiod).HasColumnName("ISINGRACEPERIOD");

                entity.Property(e => e.Minamount70)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_70");

                entity.Property(e => e.MinamountPolicy)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_POLICY");

                entity.Property(e => e.Othername)
                    .HasMaxLength(50)
                    .HasColumnName("OTHERNAME");

                entity.Property(e => e.Primarymobile)
                    .HasMaxLength(20)
                    .HasColumnName("PRIMARYMOBILE");

                entity.Property(e => e.Programmestream)
                    .HasMaxLength(100)
                    .HasColumnName("PROGRAMMESTREAM");

                entity.Property(e => e.ProgrammestreamBiometricverificationrequired).HasColumnName("PROGRAMMESTREAM_BIOMETRICVERIFICATIONREQUIRED");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Schoolmobile)
                    .HasMaxLength(20)
                    .HasColumnName("SCHOOLMOBILE");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.StudentBill4Acadyear).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.StudentMinPaymentAmountRequired).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.StudentSemFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentcategoryname)
                    .HasMaxLength(50)
                    .HasColumnName("STUDENTCATEGORYNAME");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("SURNAME");

                entity.Property(e => e.Tag)
                    .HasMaxLength(50)
                    .HasColumnName("TAG");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Totalamount)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("TOTALAMOUNT");
            });

            modelBuilder.Entity<TempdelfeesPolicySem1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMPDELFEES_POLICY_SEM1");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Acadyearstring)
                    .HasMaxLength(20)
                    .HasColumnName("ACADYEARSTRING");

                entity.Property(e => e.Amountpaidsem)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("AMOUNTPAIDSEM");

                entity.Property(e => e.Campus)
                    .HasMaxLength(100)
                    .HasColumnName("CAMPUS");

                entity.Property(e => e.Campusid).HasColumnName("CAMPUSID");

                entity.Property(e => e.College)
                    .HasMaxLength(100)
                    .HasColumnName("COLLEGE");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .HasColumnName("DEPARTMENT");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Faculty)
                    .HasMaxLength(100)
                    .HasColumnName("FACULTY");

                entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");

                entity.Property(e => e.Feecategory)
                    .HasMaxLength(100)
                    .HasColumnName("FEECATEGORY");

                entity.Property(e => e.Feecategoryid).HasColumnName("FEECATEGORYID");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(100)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.Graduatetype)
                    .HasMaxLength(100)
                    .HasColumnName("GRADUATETYPE");

                entity.Property(e => e.Graduatetypeid).HasColumnName("GRADUATETYPEID");

                entity.Property(e => e.IsbiometricallyOrCourseregistered).HasColumnName("ISBIOMETRICALLY_OR_COURSEREGISTERED");

                entity.Property(e => e.Isbiometricallyverified).HasColumnName("ISBIOMETRICALLYVERIFIED");

                entity.Property(e => e.Iscourseregistered).HasColumnName("ISCOURSEREGISTERED");

                entity.Property(e => e.Isforeigner).HasColumnName("ISFOREIGNER");

                entity.Property(e => e.Isghanaian).HasColumnName("ISGHANAIAN");

                entity.Property(e => e.Isinfinalyear).HasColumnName("ISINFINALYEAR");

                entity.Property(e => e.Isingraceperiod).HasColumnName("ISINGRACEPERIOD");

                entity.Property(e => e.Minamount70)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_70");

                entity.Property(e => e.MinamountPolicy)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("MINAMOUNT_POLICY");

                entity.Property(e => e.Othername)
                    .HasMaxLength(50)
                    .HasColumnName("OTHERNAME");

                entity.Property(e => e.Primarymobile)
                    .HasMaxLength(20)
                    .HasColumnName("PRIMARYMOBILE");

                entity.Property(e => e.Programmestream)
                    .HasMaxLength(100)
                    .HasColumnName("PROGRAMMESTREAM");

                entity.Property(e => e.ProgrammestreamBiometricverificationrequired).HasColumnName("PROGRAMMESTREAM_BIOMETRICVERIFICATIONREQUIRED");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Schoolmobile)
                    .HasMaxLength(20)
                    .HasColumnName("SCHOOLMOBILE");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.StudentBill4Acadyear).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.StudentFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.StudentMinPaymentAmountRequired).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.StudentSemFeeBalance).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Studentcategoryname)
                    .HasMaxLength(50)
                    .HasColumnName("STUDENTCATEGORYNAME");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("SURNAME");

                entity.Property(e => e.Tag)
                    .HasMaxLength(50)
                    .HasColumnName("TAG");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Totalamount)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("TOTALAMOUNT");
            });

            modelBuilder.Entity<Teststudent>(entity =>
            {
                entity.HasKey(e => e.Studentid);

                entity.ToTable("TESTSTUDENT");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TimeSlot>(entity =>
            {
                entity.HasKey(e => e.PeriodId)
                    .IsClustered(false);

                entity.ToTable("TimeSlot", "tt");

                entity.HasOne(d => d.WeekDay)
                    .WithMany(p => p.TimeSlots)
                    .HasForeignKey(d => d.WeekDayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TimeSlot_WeekDay");
            });

            modelBuilder.Entity<Timestream>(entity =>
            {
                entity.HasKey(e => e.Timestreamid)
                    .IsClustered(false);

                entity.ToTable("TIMESTREAM");

                entity.Property(e => e.Timestreamid)
                    .ValueGeneratedNever()
                    .HasColumnName("TIMESTREAMID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<TimetableUnit>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("TimetableUnit", "tt");

                entity.Property(e => e.UnitName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TimetableUser>(entity =>
            {
                entity.ToTable("TimetableUser", "tt");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.FullName).HasMaxLength(150);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.LastPasswordChangeDate).HasColumnType("datetime");

                entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.PasswordExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.StaffId).HasMaxLength(7);

                entity.Property(e => e.UserDescription).HasMaxLength(100);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<Title>(entity =>
            {
                entity.HasKey(e => e.Titleid)
                    .IsClustered(false);

                entity.ToTable("TITLE");

                entity.Property(e => e.Titleid).HasColumnName("TITLEID");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<Transcriptrequest>(entity =>
            {
                entity.HasKey(e => new { e.Requestid, e.Studentid, e.Programmestreamid, e.Transdate })
                    .IsClustered(false);

                entity.ToTable("TRANSCRIPTREQUEST");

                entity.HasIndex(e => new { e.Programmestreamid, e.Transdate }, "missing_index_189");

                entity.Property(e => e.Requestid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("REQUESTID");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Timeupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEUPDATED");

                entity.Property(e => e.Transstatusid).HasColumnName("TRANSSTATUSID");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.Transstatus)
                    .WithMany(p => p.Transcriptrequests)
                    .HasForeignKey(d => d.Transstatusid)
                    .HasConstraintName("TRANSCRIPTREQUESTSTATUSTRANSCRIPTREQUEST");
            });

            modelBuilder.Entity<Transcriptrequestdetail>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("TRANSCRIPTREQUESTDETAIL");

                entity.HasIndex(e => new { e.Programmestreamid, e.Transdate }, "missing_index_191");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Add1)
                    .HasMaxLength(100)
                    .HasColumnName("ADD1");

                entity.Property(e => e.Add2)
                    .HasMaxLength(100)
                    .HasColumnName("ADD2");

                entity.Property(e => e.Add3)
                    .HasMaxLength(100)
                    .HasColumnName("ADD3");

                entity.Property(e => e.Add4)
                    .HasMaxLength(100)
                    .HasColumnName("ADD4");

                entity.Property(e => e.Add5)
                    .HasMaxLength(100)
                    .HasColumnName("ADD5");

                entity.Property(e => e.Copies).HasColumnName("COPIES");

                entity.Property(e => e.Countryid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("COUNTRYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Isstudentcopy).HasColumnName("ISSTUDENTCOPY");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Requestid).HasColumnName("REQUESTID");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Timeupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEUPDATED");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Transcriptrequestdetails)
                    .HasForeignKey(d => d.Countryid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("COUNTRYTRANSCRIPTREQUESTDETAIL");

                entity.HasOne(d => d.Transcriptrequest)
                    .WithMany(p => p.Transcriptrequestdetails)
                    .HasForeignKey(d => new { d.Requestid, d.Studentid, d.Programmestreamid, d.Transdate })
                    .HasConstraintName("TRANSCRIPTREQUESTTRANSCRIPTREQUESTDETAIL");
            });

            modelBuilder.Entity<Transcriptrequeststatus>(entity =>
            {
                entity.HasKey(e => e.Transstatusid)
                    .IsClustered(false);

                entity.ToTable("TRANSCRIPTREQUESTSTATUS");

                entity.Property(e => e.Transstatusid)
                    .ValueGeneratedNever()
                    .HasColumnName("TRANSSTATUSID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<Tt>(entity =>
            {
                entity.HasKey(e => new { e.Coursecode, e.Lecturerid, e.Classroomid, e.Periodid })
                    .HasName("PK_TT_1");

                entity.ToTable("TT");

                entity.Property(e => e.Coursecode)
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Lecturerid).HasColumnName("LECTURERID");

                entity.Property(e => e.Classroomid).HasColumnName("CLASSROOMID");

                entity.Property(e => e.Periodid).HasColumnName("PERIODID");

                entity.Property(e => e.Groupid).HasColumnName("GROUPID");

                entity.HasOne(d => d.Ttclassroomlectureperiod)
                    .WithMany(p => p.Tts)
                    .HasForeignKey(d => new { d.Classroomid, d.Periodid })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TTCLASSROOMLECTURERPERIOD_TT");
            });

            modelBuilder.Entity<Ttcl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TTCL");

                entity.Property(e => e.Clid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CLID");

                entity.Property(e => e.Countstudent).HasColumnName("COUNTSTUDENT");

                entity.Property(e => e.Coursecode)
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Groupid).HasColumnName("GROUPID");

                entity.Property(e => e.Lecturerid).HasColumnName("LECTURERID");
            });

            modelBuilder.Entity<Ttclassroomlectureperiod>(entity =>
            {
                entity.HasKey(e => new { e.Classroomid, e.Periodid })
                    .HasName("PK_CLASSROOMLECTURERPERIOD");

                entity.ToTable("TTCLASSROOMLECTUREPERIOD");

                entity.Property(e => e.Classroomid).HasColumnName("CLASSROOMID");

                entity.Property(e => e.Periodid).HasColumnName("PERIODID");

                entity.HasOne(d => d.Classroom)
                    .WithMany(p => p.Ttclassroomlectureperiods)
                    .HasForeignKey(d => d.Classroomid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLASSROOM_CLASSROOMLECTURERPERIOD");

                entity.HasOne(d => d.Period)
                    .WithMany(p => p.Ttclassroomlectureperiods)
                    .HasForeignKey(d => d.Periodid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LECTUREPERIOD_CLASSROOMLECTURERPERIOD");
            });

            modelBuilder.Entity<Ttcourselecturerprogrammestreamgroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TTCOURSELECTURERPROGRAMMESTREAMGROUP");

                entity.Property(e => e.Countstudent).HasColumnName("COUNTSTUDENT");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Groupid).HasColumnName("GROUPID");

                entity.Property(e => e.Lecturerid).HasColumnName("LECTURERID");

                entity.Property(e => e.Optionid).HasColumnName("OPTIONID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");
            });

            modelBuilder.Entity<Ttxp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TTXP");

                entity.Property(e => e.Classroomid).HasColumnName("CLASSROOMID");

                entity.Property(e => e.Lecturecapacity).HasColumnName("LECTURECAPACITY");

                entity.Property(e => e.Periodid).HasColumnName("PERIODID");

                entity.Property(e => e.Xpid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("XPID");
            });

            modelBuilder.Entity<UgProgramme45>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UG_PROGRAMME_45");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");
            });

            modelBuilder.Entity<Unit>(entity =>
            {
                entity.ToTable("UNIT");

                entity.Property(e => e.Unitid).HasColumnName("UNITID");

                entity.Property(e => e.Unitname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("UNITNAME");
            });

            modelBuilder.Entity<UnitBuilding>(entity =>
            {
                entity.ToTable("UnitBuilding", "tt");

                entity.HasOne(d => d.Building)
                    .WithMany(p => p.UnitBuildings)
                    .HasForeignKey(d => d.BuildingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UnitBuilding_Building");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.UnitBuildings)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UnitBuilding_TimetableUnit");
            });

            modelBuilder.Entity<UnitProgrammeStream>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UnitProgrammeStream", "tt");

                entity.HasOne(d => d.ProgrammeStream)
                    .WithMany()
                    .HasForeignKey(d => d.ProgrammeStreamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UnitProgrammeStream_ProgrammeStream");

                entity.HasOne(d => d.Unit)
                    .WithMany()
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UnitProgrammeStream_TimetableUnit");
            });

            modelBuilder.Entity<UserUnit>(entity =>
            {
                entity.ToTable("UserUnit", "tt");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.UserUnits)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserUnit_TimetableUnit");
            });

            modelBuilder.Entity<Userloginlog>(entity =>
            {
                entity.ToTable("USERLOGINLOG");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Activity)
                    .HasMaxLength(100)
                    .HasColumnName("ACTIVITY");

                entity.Property(e => e.Appversion)
                    .HasMaxLength(50)
                    .HasColumnName("APPVERSION");

                entity.Property(e => e.Clientappname)
                    .HasMaxLength(100)
                    .HasColumnName("CLIENTAPPNAME");

                entity.Property(e => e.Clientnetaddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CLIENTNETADDRESS");

                entity.Property(e => e.Hostid).HasColumnName("HOSTID");

                entity.Property(e => e.Hostname)
                    .HasMaxLength(100)
                    .HasColumnName("HOSTNAME")
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.Logintime)
                    .HasColumnType("datetime")
                    .HasColumnName("LOGINTIME");

                entity.Property(e => e.Sessionid).HasColumnName("SESSIONID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<Usermanillaemailrecipient>(entity =>
            {
                entity.HasKey(e => new { e.Username, e.Emailaddress });

                entity.ToTable("USERMANILLAEMAILRECIPIENT");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("USERNAME");

                entity.Property(e => e.Emailaddress)
                    .HasMaxLength(100)
                    .HasColumnName("EMAILADDRESS");
            });

            modelBuilder.Entity<ViewAcademicrecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_ACADEMICRECORD");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Credit).HasColumnName("CREDIT");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<ViewAcademicrecordD>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_ACADEMICRECORD_D");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<ViewAccountSystemReceiptId>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_AccountSystemReceiptID");

                entity.Property(e => e.Receiptid).HasColumnName("RECEIPTID");
            });

            modelBuilder.Entity<ViewAdmissioncampus>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_ADMISSIONCAMPUS");

                entity.Property(e => e.Campusid).HasColumnName("CAMPUSID");

                entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");

                entity.Property(e => e.Isdefault).HasColumnName("ISDEFAULT");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.Regionid).HasColumnName("REGIONID");
            });

            modelBuilder.Entity<ViewAdmissioncountry>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_ADMISSIONCOUNTRY");

                entity.Property(e => e.Countrycode2)
                    .HasMaxLength(2)
                    .HasColumnName("COUNTRYCODE2");

                entity.Property(e => e.Countryid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("COUNTRYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Countryorder).HasColumnName("COUNTRYORDER");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.Nationality)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NATIONALITY");

                entity.Property(e => e.Phonecode)
                    .HasMaxLength(10)
                    .HasColumnName("PHONECODE");

                entity.Property(e => e.Phonecode2)
                    .HasMaxLength(10)
                    .HasColumnName("PHONECODE2");
            });

            modelBuilder.Entity<ViewAdmissiongroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_ADMISSIONGROUP");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Admissiongroupid).HasColumnName("ADMISSIONGROUPID");

                entity.Property(e => e.Admissionstreamid).HasColumnName("ADMISSIONSTREAMID");

                entity.Property(e => e.Campuschoicecount).HasColumnName("CAMPUSCHOICECOUNT");

                entity.Property(e => e.Campusid).HasColumnName("CAMPUSID");

                entity.Property(e => e.Canselectcampus).HasColumnName("CANSELECTCAMPUS");

                entity.Property(e => e.Feecategoryid).HasColumnName("FEECATEGORYID");

                entity.Property(e => e.Graduatetypeid).HasColumnName("GRADUATETYPEID");

                entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");

                entity.Property(e => e.Isinternational).HasColumnName("ISINTERNATIONAL");

                entity.Property(e => e.Mappingcode)
                    .HasMaxLength(10)
                    .HasColumnName("MAPPINGCODE");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.Programmechoicecount).HasColumnName("PROGRAMMECHOICECOUNT");
            });

            modelBuilder.Entity<ViewAdmissionoffercategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_ADMISSIONOFFERCATEGORY");

                entity.Property(e => e.Admissionoffercategoryid).HasColumnName("ADMISSIONOFFERCATEGORYID");

                entity.Property(e => e.Feecategoryid).HasColumnName("FEECATEGORYID");

                entity.Property(e => e.Feefilename)
                    .HasMaxLength(500)
                    .HasColumnName("FEEFILENAME");

                entity.Property(e => e.Letterhead)
                    .HasMaxLength(100)
                    .HasColumnName("LETTERHEAD");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.Offer)
                    .HasMaxLength(50)
                    .HasColumnName("OFFER");
            });

            modelBuilder.Entity<ViewAdmissionprogrammeoption>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_ADMISSIONPROGRAMMEOPTION");

                entity.Property(e => e.Isavailableonline).HasColumnName("ISAVAILABLEONLINE");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.Optionid).HasColumnName("OPTIONID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");
            });

            modelBuilder.Entity<ViewAdmissionreligion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_ADMISSIONRELIGION");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("NAME");

                entity.Property(e => e.Religionid).HasColumnName("RELIGIONID");
            });

            modelBuilder.Entity<ViewAdmissionresidence>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_ADMISSIONRESIDENCE");

                entity.Property(e => e.Isinternational).HasColumnName("ISINTERNATIONAL");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.Residenceid).HasColumnName("RESIDENCEID");
            });

            modelBuilder.Entity<ViewAdmissiontitle>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_ADMISSIONTITLE");

                entity.Property(e => e.Gender)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Titleid).HasColumnName("TITLEID");
            });

            modelBuilder.Entity<ViewAlumniDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_AlumniDetails");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.FacebookUrl)
                    .HasMaxLength(200)
                    .HasColumnName("FacebookURL");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.HallOfAffiliation).HasMaxLength(100);

                entity.Property(e => e.NationalServiceInstitution).HasMaxLength(200);

                entity.Property(e => e.OtherNames)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.ServicePostingLocation).HasMaxLength(200);

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.TelegramNumber).HasMaxLength(20);

                entity.Property(e => e.TwitterHandle).HasMaxLength(200);

                entity.Property(e => e.WhatsappNumber)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ViewApplicant>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_APPLICANT");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Admissiongroupid).HasColumnName("ADMISSIONGROUPID");

                entity.Property(e => e.Admissionlevelid).HasColumnName("ADMISSIONLEVELID");

                entity.Property(e => e.Admissionstatusid).HasColumnName("ADMISSIONSTATUSID");

                entity.Property(e => e.Applicantid)
                    .HasMaxLength(20)
                    .HasColumnName("APPLICANTID");

                entity.Property(e => e.Applicationmodeid).HasColumnName("APPLICATIONMODEID");

                entity.Property(e => e.Applicationtypeid).HasColumnName("APPLICATIONTYPEID");

                entity.Property(e => e.Bestaggregate).HasColumnName("BESTAGGREGATE");

                entity.Property(e => e.Birthdate)
                    .HasColumnType("date")
                    .HasColumnName("BIRTHDATE");

                entity.Property(e => e.Birthplace)
                    .HasMaxLength(50)
                    .HasColumnName("BIRTHPLACE");

                entity.Property(e => e.Bondexpirydate)
                    .HasColumnType("date")
                    .HasColumnName("BONDEXPIRYDATE");

                entity.Property(e => e.Bondorganisation)
                    .HasMaxLength(100)
                    .HasColumnName("BONDORGANISATION");

                entity.Property(e => e.Consider4feepaying).HasColumnName("CONSIDER4FEEPAYING");

                entity.Property(e => e.Consider4parallel).HasColumnName("CONSIDER4PARALLEL");

                entity.Property(e => e.Countryid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("COUNTRYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Diabilityid).HasColumnName("DIABILITYID");

                entity.Property(e => e.Disabilitydetails)
                    .HasMaxLength(100)
                    .HasColumnName("DISABILITYDETAILS");

                entity.Property(e => e.Dobday).HasColumnName("DOBDAY");

                entity.Property(e => e.Dobmonth).HasColumnName("DOBMONTH");

                entity.Property(e => e.Dobyear).HasColumnName("DOBYEAR");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Entranceexamscore).HasColumnName("ENTRANCEEXAMSCORE");

                entity.Property(e => e.Envelopeno)
                    .HasMaxLength(25)
                    .HasColumnName("ENVELOPENO");

                entity.Property(e => e.Envelopeserialno).HasColumnName("ENVELOPESERIALNO");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(50)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Homeregionid).HasColumnName("HOMEREGIONID");

                entity.Property(e => e.Hometown)
                    .HasMaxLength(50)
                    .HasColumnName("HOMETOWN");

                entity.Property(e => e.Infocertifiedbyapplicant).HasColumnName("INFOCERTIFIEDBYAPPLICANT");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Interviewscore).HasColumnName("INTERVIEWSCORE");

                entity.Property(e => e.Isbonded).HasColumnName("ISBONDED");

                entity.Property(e => e.Isdisabled).HasColumnName("ISDISABLED");

                entity.Property(e => e.Isdisqualified).HasColumnName("ISDISQUALIFIED");

                entity.Property(e => e.Islessendowed).HasColumnName("ISLESSENDOWED");

                entity.Property(e => e.Isresidential).HasColumnName("ISRESIDENTIAL");

                entity.Property(e => e.Isresultverified).HasColumnName("ISRESULTVERIFIED");

                entity.Property(e => e.Isstaff).HasColumnName("ISSTAFF");

                entity.Property(e => e.Isstaffchild).HasColumnName("ISSTAFFCHILD");

                entity.Property(e => e.Isstaffdevelopment).HasColumnName("ISSTAFFDEVELOPMENT");

                entity.Property(e => e.Issubmitted).HasColumnName("ISSUBMITTED");

                entity.Property(e => e.Laststep).HasColumnName("LASTSTEP");

                entity.Property(e => e.Maritalstatusid).HasColumnName("MARITALSTATUSID");

                entity.Property(e => e.Nextofkin)
                    .HasMaxLength(100)
                    .HasColumnName("NEXTOFKIN");

                entity.Property(e => e.Nextofkinadd1)
                    .HasMaxLength(100)
                    .HasColumnName("NEXTOFKINADD1");

                entity.Property(e => e.Nextofkinadd2)
                    .HasMaxLength(100)
                    .HasColumnName("NEXTOFKINADD2");

                entity.Property(e => e.Nextofkinadd3)
                    .HasMaxLength(100)
                    .HasColumnName("NEXTOFKINADD3");

                entity.Property(e => e.Nextofkinadd4)
                    .HasMaxLength(100)
                    .HasColumnName("NEXTOFKINADD4");

                entity.Property(e => e.Othername)
                    .HasMaxLength(50)
                    .HasColumnName("OTHERNAME");

                entity.Property(e => e.Passedengmath).HasColumnName("PASSEDENGMATH");

                entity.Property(e => e.Paymenttypeno)
                    .HasMaxLength(20)
                    .HasColumnName("PAYMENTTYPENO");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Phonecountryid)
                    .HasMaxLength(3)
                    .HasColumnName("PHONECOUNTRYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Postadd1)
                    .HasMaxLength(100)
                    .HasColumnName("POSTADD1");

                entity.Property(e => e.Postadd2)
                    .HasMaxLength(100)
                    .HasColumnName("POSTADD2");

                entity.Property(e => e.Postadd3)
                    .HasMaxLength(100)
                    .HasColumnName("POSTADD3");

                entity.Property(e => e.Postadd4)
                    .HasMaxLength(100)
                    .HasColumnName("POSTADD4");

                entity.Property(e => e.Presentoccupation)
                    .HasMaxLength(50)
                    .HasColumnName("PRESENTOCCUPATION");

                entity.Property(e => e.Religion)
                    .HasMaxLength(100)
                    .HasColumnName("RELIGION");

                entity.Property(e => e.Religionid).HasColumnName("RELIGIONID");

                entity.Property(e => e.Resadd1)
                    .HasMaxLength(100)
                    .HasColumnName("RESADD1");

                entity.Property(e => e.Resadd2)
                    .HasMaxLength(100)
                    .HasColumnName("RESADD2");

                entity.Property(e => e.Resadd3)
                    .HasMaxLength(100)
                    .HasColumnName("RESADD3");

                entity.Property(e => e.Resadd4)
                    .HasMaxLength(100)
                    .HasColumnName("RESADD4");

                entity.Property(e => e.Residenceid).HasColumnName("RESIDENCEID");

                entity.Property(e => e.Resregionid).HasColumnName("RESREGIONID");

                entity.Property(e => e.Sponsoradd1)
                    .HasMaxLength(100)
                    .HasColumnName("SPONSORADD1");

                entity.Property(e => e.Sponsoradd2)
                    .HasMaxLength(100)
                    .HasColumnName("SPONSORADD2");

                entity.Property(e => e.Sponsoradd3)
                    .HasMaxLength(100)
                    .HasColumnName("SPONSORADD3");

                entity.Property(e => e.Sponsoradd4)
                    .HasMaxLength(100)
                    .HasColumnName("SPONSORADD4");

                entity.Property(e => e.Sponsoremail)
                    .HasMaxLength(50)
                    .HasColumnName("SPONSOREMAIL");

                entity.Property(e => e.Sponsorname)
                    .HasMaxLength(100)
                    .HasColumnName("SPONSORNAME");

                entity.Property(e => e.Sponsorphone)
                    .HasMaxLength(50)
                    .HasColumnName("SPONSORPHONE");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("SURNAME");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Timesubmitted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMESUBMITTED");

                entity.Property(e => e.Timeupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEUPDATED");

                entity.Property(e => e.Titleid).HasColumnName("TITLEID");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(100)
                    .HasColumnName("UPDATEDBY");

                entity.Property(e => e.Workexperience)
                    .HasMaxLength(400)
                    .HasColumnName("WORKEXPERIENCE");

                entity.Property(e => e.Workexperienceinyears).HasColumnName("WORKEXPERIENCEINYEARS");

                entity.Property(e => e.Workplace)
                    .HasMaxLength(100)
                    .HasColumnName("WORKPLACE");
            });

            modelBuilder.Entity<ViewApplicantadmitted>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_APPLICANTADMITTED");

                entity.Property(e => e.Acadyearenrolled).HasColumnName("ACADYEARENROLLED");

                entity.Property(e => e.Admissionlevelid).HasColumnName("ADMISSIONLEVELID");

                entity.Property(e => e.Admissionoffercategoryid).HasColumnName("ADMISSIONOFFERCATEGORYID");

                entity.Property(e => e.Aggregateobtained).HasColumnName("AGGREGATEOBTAINED");

                entity.Property(e => e.Applicantid)
                    .HasMaxLength(20)
                    .HasColumnName("APPLICANTID");

                entity.Property(e => e.Autoadmitted).HasColumnName("AUTOADMITTED");

                entity.Property(e => e.Campusid).HasColumnName("CAMPUSID");

                entity.Property(e => e.Canprint).HasColumnName("CANPRINT");

                entity.Property(e => e.Cansenddata).HasColumnName("CANSENDDATA");

                entity.Property(e => e.Canview).HasColumnName("CANVIEW");

                entity.Property(e => e.Feecategoryid).HasColumnName("FEECATEGORYID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Isaccepted).HasColumnName("ISACCEPTED");

                entity.Property(e => e.Lecturesessionid).HasColumnName("LECTURESESSIONID");

                entity.Property(e => e.Monthid).HasColumnName("MONTHID");

                entity.Property(e => e.Optionid).HasColumnName("OPTIONID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .HasColumnName("REMARKS");

                entity.Property(e => e.Residenceid).HasColumnName("RESIDENCEID");

                entity.Property(e => e.Semenrolled).HasColumnName("SEMENROLLED");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeaccepted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEACCEPTED");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");
            });

            modelBuilder.Entity<ViewApplicantadmittedqueue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_APPLICANTADMITTEDQUEUE");

                entity.Property(e => e.Applicantadmittedid).HasColumnName("APPLICANTADMITTEDID");

                entity.Property(e => e.Applicantid).HasColumnName("APPLICANTID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");
            });

            modelBuilder.Entity<ViewApplicantdisability>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_APPLICANTDISABILITY");

                entity.Property(e => e.Applicantid)
                    .HasMaxLength(20)
                    .HasColumnName("APPLICANTID");

                entity.Property(e => e.Disability)
                    .HasMaxLength(100)
                    .HasColumnName("DISABILITY");

                entity.Property(e => e.Disabilityid).HasColumnName("DISABILITYID");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<ViewApplicantlgn>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_APPLICANTLGN");

                entity.Property(e => e.Applicantid)
                    .HasMaxLength(20)
                    .HasColumnName("APPLICANTID");

                entity.Property(e => e.Lgnid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("LGNID");

                entity.Property(e => e.Pin)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("PIN");
            });

            modelBuilder.Entity<ViewApplicantpicture>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_APPLICANTPICTURE");

                entity.Property(e => e.Applicantid)
                    .HasMaxLength(20)
                    .HasColumnName("APPLICANTID");

                entity.Property(e => e.Picture)
                    .IsRequired()
                    .HasColumnName("PICTURE");
            });

            modelBuilder.Entity<ViewCombinedAcademicFee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_CombinedAcademicFee");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.Currencyid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Narrative)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NARRATIVE");

                entity.Property(e => e.Paymentmode)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("PAYMENTMODE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Transactionid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TRANSACTIONID");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");
            });

            modelBuilder.Entity<ViewCredit>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_CREDIT");

                entity.Property(e => e.Amount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.Currencyid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Narration)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NARRATION");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");

                entity.Property(e => e.Transtype)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("TRANSTYPE");

                entity.Property(e => e.Xrate).HasColumnName("XRATE");
            });

            modelBuilder.Entity<ViewDebit>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DEBIT");

                entity.Property(e => e.Amount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.Currencyid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Narration)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NARRATION");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");

                entity.Property(e => e.Transtype)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("TRANSTYPE");

                entity.Property(e => e.Xrate).HasColumnName("XRATE");
            });

            modelBuilder.Entity<ViewFresher>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_FRESHER");

                entity.Property(e => e.Admmode).HasColumnName("ADMMODE");

                entity.Property(e => e.Countryid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("COUNTRYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Countryname)
                    .HasMaxLength(100)
                    .HasColumnName("COUNTRYNAME");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Othername)
                    .HasMaxLength(50)
                    .HasColumnName("OTHERNAME");

                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Programmestream)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("PROGRAMMESTREAM");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Residence)
                    .HasMaxLength(100)
                    .HasColumnName("RESIDENCE");

                entity.Property(e => e.Residenceid).HasColumnName("RESIDENCEID");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("SURNAME");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");
            });

            modelBuilder.Entity<ViewFresher1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_FRESHER", "res");

                entity.Property(e => e.Admmode).HasColumnName("ADMMODE");

                entity.Property(e => e.Countryid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("COUNTRYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Countryname)
                    .HasMaxLength(100)
                    .HasColumnName("COUNTRYNAME");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Othername)
                    .HasMaxLength(50)
                    .HasColumnName("OTHERNAME");

                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Programmestream)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("PROGRAMMESTREAM");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Residence)
                    .HasMaxLength(100)
                    .HasColumnName("RESIDENCE");

                entity.Property(e => e.Residenceid).HasColumnName("RESIDENCEID");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("SURNAME");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");
            });

            modelBuilder.Entity<ViewFresher2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_FRESHER2");

                entity.Property(e => e.Countryid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("COUNTRYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Countryname)
                    .HasMaxLength(100)
                    .HasColumnName("COUNTRYNAME");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Othername)
                    .HasMaxLength(50)
                    .HasColumnName("OTHERNAME");

                entity.Property(e => e.Programmestream)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("PROGRAMMESTREAM");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Residence)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("RESIDENCE");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("SURNAME");
            });

            modelBuilder.Entity<ViewFresherphoto>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_FRESHERPHOTO");

                entity.Property(e => e.Photo).HasColumnName("PHOTO");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<ViewFreshman>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_FRESHMAN");

                entity.Property(e => e.Countryid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("COUNTRYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Countryname)
                    .HasMaxLength(100)
                    .HasColumnName("COUNTRYNAME");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Othername)
                    .HasMaxLength(50)
                    .HasColumnName("OTHERNAME");

                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Programmestream)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("PROGRAMMESTREAM");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("SURNAME");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");
            });

            modelBuilder.Entity<ViewGraduate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Graduate");

                entity.Property(e => e.College)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("COLLEGE");

                entity.Property(e => e.Effectivedate)
                    .HasColumnType("date")
                    .HasColumnName("EFFECTIVEDATE");

                entity.Property(e => e.Indexno)
                    .HasMaxLength(20)
                    .HasColumnName("INDEXNO");

                entity.Property(e => e.Isapproved).HasColumnName("ISAPPROVED");

                entity.Property(e => e.Longprogrammename)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("LONGPROGRAMMENAME");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Shortprogrammename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("SHORTPROGRAMMENAME");

                entity.Property(e => e.Specialization)
                    .HasMaxLength(100)
                    .HasColumnName("SPECIALIZATION");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<ViewGraduateCurrent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Graduate_Current");

                entity.Property(e => e.College)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("COLLEGE");

                entity.Property(e => e.Effectivedate)
                    .HasColumnType("date")
                    .HasColumnName("EFFECTIVEDATE");

                entity.Property(e => e.Graduationstreamid).HasColumnName("GRADUATIONSTREAMID");

                entity.Property(e => e.Indexno)
                    .HasMaxLength(20)
                    .HasColumnName("INDEXNO");

                entity.Property(e => e.Longprogrammename)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("LONGPROGRAMMENAME");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Shortprogrammename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("SHORTPROGRAMMENAME");

                entity.Property(e => e.Specialization)
                    .HasMaxLength(100)
                    .HasColumnName("SPECIALIZATION");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<ViewGraduationAllowPayment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_GraduationAllowPayment");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<ViewLecturer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewLecturer", "tt");

                entity.Property(e => e.LecturerName)
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.LecturerTitle).HasMaxLength(25);

                entity.Property(e => e.Lecturerid).HasColumnName("LECTURERID");

                entity.Property(e => e.Staffid).HasColumnName("STAFFID");

                entity.Property(e => e.Staffid2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("STAFFID2");
            });

            modelBuilder.Entity<ViewLecturerCourse>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewLecturerCourses");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Lecturerid).HasColumnName("LECTURERID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.Programme)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Staffid).HasColumnName("STAFFID");
            });

            modelBuilder.Entity<ViewMissingprogrammestream>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_MISSINGPROGRAMMESTREAM");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.Number).HasColumnName("NUMBER");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");
            });

            modelBuilder.Entity<ViewOfflinePayment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_OfflinePayment");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Bankaccountno)
                    .HasMaxLength(100)
                    .HasColumnName("BANKACCOUNTNO");

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.Currencyid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Feeitemid).HasColumnName("FEEITEMID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Ischecked).HasColumnName("ISCHECKED");

                entity.Property(e => e.Isreversal).HasColumnName("ISREVERSAL");

                entity.Property(e => e.Narrative)
                    .HasMaxLength(150)
                    .HasColumnName("NARRATIVE");

                entity.Property(e => e.Paymentlocid).HasColumnName("PAYMENTLOCID");

                entity.Property(e => e.Paymenttypeid).HasColumnName("PAYMENTTYPEID");

                entity.Property(e => e.Paymenttypeno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PAYMENTTYPENO");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Reason4reversal)
                    .HasMaxLength(100)
                    .HasColumnName("REASON4REVERSAL");

                entity.Property(e => e.Receiptno)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("RECEIPTNO");

                entity.Property(e => e.Reversedtransactionid).HasColumnName("REVERSEDTRANSACTIONID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Transactionid)
                    .HasMaxLength(50)
                    .HasColumnName("TRANSACTIONID");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEDBY");

                entity.Property(e => e.Xrate).HasColumnName("XRATE");
            });

            modelBuilder.Entity<ViewOnlinePaymentTransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_OnlinePaymentTransaction");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Alttransactionid)
                    .HasMaxLength(50)
                    .HasColumnName("ALTTRANSACTIONID");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.Bankaccountno)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("BANKACCOUNTNO");

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.Bankname)
                    .HasMaxLength(100)
                    .HasColumnName("BANKNAME");

                entity.Property(e => e.Branchname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("BRANCHNAME");

                entity.Property(e => e.Clientname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("CLIENTNAME");

                entity.Property(e => e.Currencyid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Feeitem)
                    .HasMaxLength(100)
                    .HasColumnName("FEEITEM");

                entity.Property(e => e.Feeitemid).HasColumnName("FEEITEMID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Ischecked).HasColumnName("ISCHECKED");

                entity.Property(e => e.Isconfirmed).HasColumnName("ISCONFIRMED");

                entity.Property(e => e.Narrative)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NARRATIVE");

                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Reason4reversal)
                    .HasMaxLength(100)
                    .HasColumnName("REASON4REVERSAL");

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Teller)
                    .HasMaxLength(50)
                    .HasColumnName("TELLER");

                entity.Property(e => e.Timeconfirmed).HasColumnName("TIMECONFIRMED");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Transactionid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TRANSACTIONID");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");

                entity.Property(e => e.Xrate)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("XRATE");
            });

            modelBuilder.Entity<ViewOnlineWebPayment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_OnlineWebPayments");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.Bankaccountno)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("BANKACCOUNTNO");

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.Bankname)
                    .HasMaxLength(100)
                    .HasColumnName("BANKNAME");

                entity.Property(e => e.Branchname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("BRANCHNAME");

                entity.Property(e => e.Clientname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("CLIENTNAME");

                entity.Property(e => e.Currencyid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Feeitem)
                    .HasMaxLength(100)
                    .HasColumnName("FEEITEM");

                entity.Property(e => e.Feeitemid).HasColumnName("FEEITEMID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Ischecked).HasColumnName("ISCHECKED");

                entity.Property(e => e.Isconfirmed).HasColumnName("ISCONFIRMED");

                entity.Property(e => e.Narrative)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NARRATIVE");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Reason4reversal)
                    .HasMaxLength(100)
                    .HasColumnName("REASON4REVERSAL");

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Teller)
                    .HasMaxLength(50)
                    .HasColumnName("TELLER");

                entity.Property(e => e.Timeconfirmed).HasColumnName("TIMECONFIRMED");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Transactionid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TRANSACTIONID");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");

                entity.Property(e => e.Xrate)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("XRATE");
            });

            modelBuilder.Entity<ViewOnlinepayment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_ONLINEPAYMENT");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Alttransactionid)
                    .HasMaxLength(50)
                    .HasColumnName("ALTTRANSACTIONID");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.Bankaccountno)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("BANKACCOUNTNO");

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.Bankname)
                    .HasMaxLength(100)
                    .HasColumnName("BANKNAME");

                entity.Property(e => e.Branchname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("BRANCHNAME");

                entity.Property(e => e.Clientname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("CLIENTNAME");

                entity.Property(e => e.Clientnetaddress)
                    .HasMaxLength(255)
                    .HasColumnName("CLIENTNETADDRESS");

                entity.Property(e => e.Currencyid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Feeitemid).HasColumnName("FEEITEMID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Ischecked).HasColumnName("ISCHECKED");

                entity.Property(e => e.Isconfirmed).HasColumnName("ISCONFIRMED");

                entity.Property(e => e.Isflagged).HasColumnName("ISFLAGGED");

                entity.Property(e => e.Isuploaded).HasColumnName("ISUPLOADED");

                entity.Property(e => e.Narrative)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NARRATIVE");

                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Reason4reversal)
                    .HasMaxLength(100)
                    .HasColumnName("REASON4REVERSAL");

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Reversedtransactionid)
                    .HasMaxLength(50)
                    .HasColumnName("REVERSEDTRANSACTIONID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Teller)
                    .HasMaxLength(50)
                    .HasColumnName("TELLER");

                entity.Property(e => e.Timeconfirmed).HasColumnName("TIMECONFIRMED");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Transactionid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TRANSACTIONID");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");

                entity.Property(e => e.Xrate)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("XRATE");
            });

            modelBuilder.Entity<ViewPayment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_PAYMENTS");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Bankaccountno)
                    .HasMaxLength(20)
                    .HasColumnName("BANKACCOUNTNO");

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.Currencyid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Feeitemid).HasColumnName("FEEITEMID");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasColumnName("ID");

                entity.Property(e => e.Narration)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NARRATION");

                entity.Property(e => e.Paymentmode)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("PAYMENTMODE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Transactionid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TRANSACTIONID");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");

                entity.Property(e => e.Xrate).HasColumnName("XRATE");
            });

            modelBuilder.Entity<ViewPaymentsGraduation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_PAYMENTS_GRADUATION");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Bank)
                    .HasMaxLength(100)
                    .HasColumnName("BANK");

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.Currencyid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Paymentmode)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("PAYMENTMODE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Transactionid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TRANSACTIONID");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");
            });

            modelBuilder.Entity<ViewPaymentsOffline>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_PAYMENTS_OFFLINE");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Bankaccountno)
                    .HasMaxLength(100)
                    .HasColumnName("BANKACCOUNTNO");

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.Currencyid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Feeitemid).HasColumnName("FEEITEMID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Ischecked).HasColumnName("ISCHECKED");

                entity.Property(e => e.Isreversal).HasColumnName("ISREVERSAL");

                entity.Property(e => e.Narrative)
                    .HasMaxLength(150)
                    .HasColumnName("NARRATIVE");

                entity.Property(e => e.Paymentlocid).HasColumnName("PAYMENTLOCID");

                entity.Property(e => e.Paymenttypeid).HasColumnName("PAYMENTTYPEID");

                entity.Property(e => e.Paymenttypeno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PAYMENTTYPENO");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Reason4reversal)
                    .HasMaxLength(100)
                    .HasColumnName("REASON4REVERSAL");

                entity.Property(e => e.Receiptno)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("RECEIPTNO");

                entity.Property(e => e.Reversedtransactionid).HasColumnName("REVERSEDTRANSACTIONID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Transactionid)
                    .HasMaxLength(50)
                    .HasColumnName("TRANSACTIONID");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(100)
                    .HasColumnName("UPDATEDBY");

                entity.Property(e => e.Xrate).HasColumnName("XRATE");
            });

            modelBuilder.Entity<ViewPaymentsOnline>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_PAYMENTS_ONLINE");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Alttransactionid)
                    .HasMaxLength(50)
                    .HasColumnName("ALTTRANSACTIONID");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.Bankaccountno)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("BANKACCOUNTNO");

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.Bankname)
                    .HasMaxLength(100)
                    .HasColumnName("BANKNAME");

                entity.Property(e => e.Branchname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("BRANCHNAME");

                entity.Property(e => e.Clientname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("CLIENTNAME");

                entity.Property(e => e.Clientnetaddress)
                    .HasMaxLength(255)
                    .HasColumnName("CLIENTNETADDRESS");

                entity.Property(e => e.Currencyid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Feeitemid).HasColumnName("FEEITEMID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Ischecked).HasColumnName("ISCHECKED");

                entity.Property(e => e.Isconfirmed).HasColumnName("ISCONFIRMED");

                entity.Property(e => e.Isflagged).HasColumnName("ISFLAGGED");

                entity.Property(e => e.Isuploaded).HasColumnName("ISUPLOADED");

                entity.Property(e => e.Narrative)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NARRATIVE");

                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Reason4reversal)
                    .HasMaxLength(100)
                    .HasColumnName("REASON4REVERSAL");

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Reversedtransactionid)
                    .HasMaxLength(50)
                    .HasColumnName("REVERSEDTRANSACTIONID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Teller)
                    .HasMaxLength(50)
                    .HasColumnName("TELLER");

                entity.Property(e => e.Timeconfirmed).HasColumnName("TIMECONFIRMED");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Transactionid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TRANSACTIONID");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");

                entity.Property(e => e.Xrate)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("XRATE");
            });

            modelBuilder.Entity<ViewPaymentsOnlineFee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_PAYMENTS_ONLINE_FEES");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Accountreceiptid).HasColumnName("ACCOUNTRECEIPTID");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.AmountSplit)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AMOUNT_SPLIT");

                entity.Property(e => e.Bankaccountno)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("BANKACCOUNTNO");

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.Bankname)
                    .HasMaxLength(100)
                    .HasColumnName("BANKNAME");

                entity.Property(e => e.Branchname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("BRANCHNAME");

                entity.Property(e => e.Clientname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("CLIENTNAME");

                entity.Property(e => e.Clientnetaddress)
                    .HasMaxLength(255)
                    .HasColumnName("CLIENTNETADDRESS");

                entity.Property(e => e.Currencyid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Feeitemid).HasColumnName("FEEITEMID");

                entity.Property(e => e.FeeitemidSplit).HasColumnName("FEEITEMID_SPLIT");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Ischecked).HasColumnName("ISCHECKED");

                entity.Property(e => e.Isconfirmed).HasColumnName("ISCONFIRMED");

                entity.Property(e => e.Isflagged).HasColumnName("ISFLAGGED");

                entity.Property(e => e.Isreversal).HasColumnName("ISREVERSAL");

                entity.Property(e => e.Narrative)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NARRATIVE");

                entity.Property(e => e.Paymentchannelid).HasColumnName("PAYMENTCHANNELID");

                entity.Property(e => e.Paymentservice)
                    .HasMaxLength(100)
                    .HasColumnName("PAYMENTSERVICE");

                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Reason4reversal)
                    .HasMaxLength(100)
                    .HasColumnName("REASON4REVERSAL");

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Reversedtransactionid)
                    .HasMaxLength(50)
                    .HasColumnName("REVERSEDTRANSACTIONID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Teller)
                    .HasMaxLength(50)
                    .HasColumnName("TELLER");

                entity.Property(e => e.Timeconfirmed).HasColumnName("TIMECONFIRMED");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Transactionid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TRANSACTIONID");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");

                entity.Property(e => e.Xrate)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("XRATE");
            });

            modelBuilder.Entity<ViewPaymentsOnlineResidential>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_PAYMENTS_ONLINE_RESIDENTIAL");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Accountreceiptid).HasColumnName("ACCOUNTRECEIPTID");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.AmountSplit)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AMOUNT_SPLIT");

                entity.Property(e => e.Bankaccountno)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("BANKACCOUNTNO");

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.Bankname)
                    .HasMaxLength(100)
                    .HasColumnName("BANKNAME");

                entity.Property(e => e.Branchname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("BRANCHNAME");

                entity.Property(e => e.Clientname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("CLIENTNAME");

                entity.Property(e => e.Clientnetaddress)
                    .HasMaxLength(255)
                    .HasColumnName("CLIENTNETADDRESS");

                entity.Property(e => e.Currencyid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Feeitemid).HasColumnName("FEEITEMID");

                entity.Property(e => e.FeeitemidSplit).HasColumnName("FEEITEMID_SPLIT");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Ischecked).HasColumnName("ISCHECKED");

                entity.Property(e => e.Isconfirmed).HasColumnName("ISCONFIRMED");

                entity.Property(e => e.Isflagged).HasColumnName("ISFLAGGED");

                entity.Property(e => e.Isreversal).HasColumnName("ISREVERSAL");

                entity.Property(e => e.Narrative)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NARRATIVE");

                entity.Property(e => e.Paymentchannelid).HasColumnName("PAYMENTCHANNELID");

                entity.Property(e => e.Paymentservice)
                    .HasMaxLength(100)
                    .HasColumnName("PAYMENTSERVICE");

                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Reason4reversal)
                    .HasMaxLength(100)
                    .HasColumnName("REASON4REVERSAL");

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Reversedtransactionid)
                    .HasMaxLength(50)
                    .HasColumnName("REVERSEDTRANSACTIONID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Teller)
                    .HasMaxLength(50)
                    .HasColumnName("TELLER");

                entity.Property(e => e.Timeconfirmed).HasColumnName("TIMECONFIRMED");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Transactionid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TRANSACTIONID");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");

                entity.Property(e => e.Xrate)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("XRATE");
            });

            modelBuilder.Entity<ViewProgrammestream>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_PROGRAMMESTREAM");

                entity.Property(e => e.Addoptiontocert).HasColumnName("ADDOPTIONTOCERT");

                entity.Property(e => e.Affiliateddepartmenttid).HasColumnName("AFFILIATEDDEPARTMENTTID");

                entity.Property(e => e.Biometricverificationrequired).HasColumnName("BIOMETRICVERIFICATIONREQUIRED");

                entity.Property(e => e.Calendarid).HasColumnName("CALENDARID");

                entity.Property(e => e.Collegeid).HasColumnName("COLLEGEID");

                entity.Property(e => e.Coresetid).HasColumnName("CORESETID");

                entity.Property(e => e.CrLine1)
                    .HasMaxLength(100)
                    .HasColumnName("CR_LINE1");

                entity.Property(e => e.CrLine2)
                    .HasMaxLength(100)
                    .HasColumnName("CR_LINE2");

                entity.Property(e => e.CrLine3)
                    .HasMaxLength(100)
                    .HasColumnName("CR_LINE3");

                entity.Property(e => e.CrLine4)
                    .HasMaxLength(100)
                    .HasColumnName("CR_LINE4");

                entity.Property(e => e.CtLine1)
                    .HasMaxLength(100)
                    .HasColumnName("CT_LINE1");

                entity.Property(e => e.CtLine2)
                    .HasMaxLength(100)
                    .HasColumnName("CT_LINE2");

                entity.Property(e => e.CtLine3)
                    .HasMaxLength(100)
                    .HasColumnName("CT_LINE3");

                entity.Property(e => e.CtLine4)
                    .HasMaxLength(100)
                    .HasColumnName("CT_LINE4");

                entity.Property(e => e.CtcLine1)
                    .HasMaxLength(100)
                    .HasColumnName("CTC_LINE1");

                entity.Property(e => e.CtcLine2)
                    .HasMaxLength(100)
                    .HasColumnName("CTC_LINE2");

                entity.Property(e => e.CtcLine3)
                    .HasMaxLength(100)
                    .HasColumnName("CTC_LINE3");

                entity.Property(e => e.CtcLine4)
                    .HasMaxLength(100)
                    .HasColumnName("CTC_LINE4");

                entity.Property(e => e.Departmentid).HasColumnName("DEPARTMENTID");

                entity.Property(e => e.Durationdescription)
                    .HasMaxLength(100)
                    .HasColumnName("DURATIONDESCRIPTION");

                entity.Property(e => e.Facultyid).HasColumnName("FACULTYID");

                entity.Property(e => e.Feeclassificationid).HasColumnName("FEECLASSIFICATIONID");

                entity.Property(e => e.Finalsem).HasColumnName("FINALSEM");

                entity.Property(e => e.Finalyear).HasColumnName("FINALYEAR");

                entity.Property(e => e.Governingboard)
                    .HasMaxLength(50)
                    .HasColumnName("GOVERNINGBOARD");

                entity.Property(e => e.Gradingid).HasColumnName("GRADINGID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");

                entity.Property(e => e.Isadmissionavailable).HasColumnName("ISADMISSIONAVAILABLE");

                entity.Property(e => e.Mincredits).HasColumnName("MINCREDITS");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.Parentcollegeid).HasColumnName("PARENTCOLLEGEID");

                entity.Property(e => e.Parentdepartmentid).HasColumnName("PARENTDEPARTMENTID");

                entity.Property(e => e.Parentfacultyid).HasColumnName("PARENTFACULTYID");

                entity.Property(e => e.Programmeid).HasColumnName("PROGRAMMEID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Reporttitle)
                    .HasMaxLength(100)
                    .HasColumnName("REPORTTITLE");

                entity.Property(e => e.Resitcategoryid).HasColumnName("RESITCATEGORYID");

                entity.Property(e => e.Resittemplateid).HasColumnName("RESITTEMPLATEID");

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Timestreamid).HasColumnName("TIMESTREAMID");

                entity.Property(e => e.Transcriptourrefprefix)
                    .HasMaxLength(20)
                    .HasColumnName("TRANSCRIPTOURREFPREFIX");

                entity.Property(e => e.Wsitemid).HasColumnName("WSITEMID");
            });

            modelBuilder.Entity<ViewReceipt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Receipt");

                entity.Property(e => e.Accountgroupid).HasColumnName("ACCOUNTGROUPID");

                entity.Property(e => e.Amount)
                    .HasColumnType("numeric(19, 9)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.Awarddate)
                    .HasColumnType("date")
                    .HasColumnName("AWARDDATE");

                entity.Property(e => e.Checked).HasColumnName("CHECKED");

                entity.Property(e => e.Chequeno)
                    .HasMaxLength(50)
                    .HasColumnName("CHEQUENO")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Datetimedeleted).HasColumnName("DATETIMEDELETED");

                entity.Property(e => e.Glaccountid).HasColumnName("GLACCOUNTID");

                entity.Property(e => e.Glaccountsubid).HasColumnName("GLACCOUNTSUBID");

                entity.Property(e => e.Glaccounttransid).HasColumnName("GLACCOUNTTRANSID");

                entity.Property(e => e.IBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("I_BY")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.IDatetime).HasColumnName("I_DATETIME");

                entity.Property(e => e.Isaward).HasColumnName("ISAWARD");

                entity.Property(e => e.Isclosed).HasColumnName("ISCLOSED");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Isrestricted).HasColumnName("ISRESTRICTED");

                entity.Property(e => e.Isrevision).HasColumnName("ISREVISION");

                entity.Property(e => e.IudBy)
                    .HasMaxLength(50)
                    .HasColumnName("IUD_BY")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.IudDatetime).HasColumnName("IUD_DATETIME");

                entity.Property(e => e.Oldreceiptdate)
                    .HasColumnType("date")
                    .HasColumnName("OLDRECEIPTDATE");

                entity.Property(e => e.Oldreceiptid)
                    .HasMaxLength(50)
                    .HasColumnName("OLDRECEIPTID")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Payername)
                    .HasMaxLength(100)
                    .HasColumnName("PAYERNAME")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Posteddatetime).HasColumnName("POSTEDDATETIME");

                entity.Property(e => e.Receiptid).HasColumnName("RECEIPTID");

                entity.Property(e => e.Receiptprinted).HasColumnName("RECEIPTPRINTED");

                entity.Property(e => e.Receiptprinteddatetime).HasColumnName("RECEIPTPRINTEDDATETIME");

                entity.Property(e => e.Serialno).HasColumnName("SERIALNO");

                entity.Property(e => e.Sourceamount)
                    .HasColumnType("numeric(19, 9)")
                    .HasColumnName("SOURCEAMOUNT");

                entity.Property(e => e.Sourcecurrencyid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("SOURCECURRENCYID")
                    .IsFixedLength(true)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Sourcesystem)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SOURCESYSTEM")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Sourcesystemid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOURCESYSTEMID")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Transactiondate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSACTIONDATE");

                entity.Property(e => e.Transactiondetails)
                    .HasMaxLength(300)
                    .HasColumnName("TRANSACTIONDETAILS")
                    .UseCollation("Latin1_General_CI_AS");
            });

            modelBuilder.Entity<ViewResidencebooking>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_RESIDENCEBOOKING", "res");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Altresidenceid).HasColumnName("ALTRESIDENCEID");

                entity.Property(e => e.Bookingcode).HasColumnName("BOOKINGCODE");

                entity.Property(e => e.Bookingdate)
                    .HasColumnType("datetime")
                    .HasColumnName("BOOKINGDATE");

                entity.Property(e => e.Bookingdeadline)
                    .HasColumnType("datetime")
                    .HasColumnName("BOOKINGDEADLINE");

                entity.Property(e => e.Bookingtypeid).HasColumnName("BOOKINGTYPEID");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Ispaid).HasColumnName("ISPAID");

                entity.Property(e => e.Isreserved).HasColumnName("ISRESERVED");

                entity.Property(e => e.Othername)
                    .HasMaxLength(50)
                    .HasColumnName("OTHERNAME");

                entity.Property(e => e.Residence)
                    .HasMaxLength(100)
                    .HasColumnName("RESIDENCE");

                entity.Property(e => e.Residenceid).HasColumnName("RESIDENCEID");

                entity.Property(e => e.Roomno)
                    .HasMaxLength(10)
                    .HasColumnName("ROOMNO");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("SURNAME");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");
            });

            modelBuilder.Entity<ViewResidencebookingBlockedroom>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_RESIDENCEBOOKING_BLOCKEDROOM", "res");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Altresidenceid).HasColumnName("ALTRESIDENCEID");

                entity.Property(e => e.Bookingcode).HasColumnName("BOOKINGCODE");

                entity.Property(e => e.Bookingdate)
                    .HasColumnType("datetime")
                    .HasColumnName("BOOKINGDATE");

                entity.Property(e => e.Bookingdeadline)
                    .HasColumnType("datetime")
                    .HasColumnName("BOOKINGDEADLINE");

                entity.Property(e => e.Flag).HasColumnName("FLAG");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Ispaid).HasColumnName("ISPAID");

                entity.Property(e => e.Isreserved).HasColumnName("ISRESERVED");

                entity.Property(e => e.Othername)
                    .HasMaxLength(50)
                    .HasColumnName("OTHERNAME");

                entity.Property(e => e.Residence)
                    .HasMaxLength(100)
                    .HasColumnName("RESIDENCE");

                entity.Property(e => e.Residenceid).HasColumnName("RESIDENCEID");

                entity.Property(e => e.Roomno)
                    .HasMaxLength(10)
                    .HasColumnName("ROOMNO");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("SURNAME");
            });

            modelBuilder.Entity<ViewResidencebookingOnline>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_RESIDENCEBOOKING_ONLINE", "res");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Altresidenceid).HasColumnName("ALTRESIDENCEID");

                entity.Property(e => e.Bookingcode).HasColumnName("BOOKINGCODE");

                entity.Property(e => e.Bookingdate)
                    .HasColumnType("datetime")
                    .HasColumnName("BOOKINGDATE");

                entity.Property(e => e.Bookingdeadline)
                    .HasColumnType("datetime")
                    .HasColumnName("BOOKINGDEADLINE");

                entity.Property(e => e.Bookingtypeid).HasColumnName("BOOKINGTYPEID");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Ispaid).HasColumnName("ISPAID");

                entity.Property(e => e.Isreserved).HasColumnName("ISRESERVED");

                entity.Property(e => e.Othername)
                    .HasMaxLength(50)
                    .HasColumnName("OTHERNAME");

                entity.Property(e => e.Residence)
                    .HasMaxLength(100)
                    .HasColumnName("RESIDENCE");

                entity.Property(e => e.Residenceid).HasColumnName("RESIDENCEID");

                entity.Property(e => e.Roomno)
                    .HasMaxLength(10)
                    .HasColumnName("ROOMNO");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("SURNAME");
            });

            modelBuilder.Entity<ViewResidencebookingTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_RESIDENCEBOOKING_temp", "res");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Altresidenceid).HasColumnName("ALTRESIDENCEID");

                entity.Property(e => e.Bookingcode).HasColumnName("BOOKINGCODE");

                entity.Property(e => e.Bookingdate)
                    .HasColumnType("datetime")
                    .HasColumnName("BOOKINGDATE");

                entity.Property(e => e.Bookingdeadline)
                    .HasColumnType("datetime")
                    .HasColumnName("BOOKINGDEADLINE");

                entity.Property(e => e.Bookingtypeid).HasColumnName("BOOKINGTYPEID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Ispaid).HasColumnName("ISPAID");

                entity.Property(e => e.Isreserved).HasColumnName("ISRESERVED");

                entity.Property(e => e.Residence)
                    .HasMaxLength(100)
                    .HasColumnName("RESIDENCE");

                entity.Property(e => e.Residenceid).HasColumnName("RESIDENCEID");

                entity.Property(e => e.Roomno)
                    .HasMaxLength(10)
                    .HasColumnName("ROOMNO");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");
            });

            modelBuilder.Entity<ViewResidencepayment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_RESIDENCEPAYMENT", "res");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.Bankname)
                    .HasMaxLength(100)
                    .HasColumnName("BANKNAME");

                entity.Property(e => e.Branchname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("BRANCHNAME");

                entity.Property(e => e.Currencyid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasColumnName("ID");

                entity.Property(e => e.Residence)
                    .HasMaxLength(100)
                    .HasColumnName("RESIDENCE");

                entity.Property(e => e.Residenceid).HasColumnName("RESIDENCEID");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Transactionid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TRANSACTIONID");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");
            });

            modelBuilder.Entity<ViewResidentialbill>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_RESIDENTIALBILL");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Currencyid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Feetype)
                    .HasMaxLength(100)
                    .HasColumnName("FEETYPE");

                entity.Property(e => e.Feetypeid).HasColumnName("FEETYPEID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Residence)
                    .HasMaxLength(100)
                    .HasColumnName("RESIDENCE");

                entity.Property(e => e.Residenceid).HasColumnName("RESIDENCEID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");
            });

            modelBuilder.Entity<ViewResidentialpaymentDel>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_RESIDENTIALPAYMENT_del");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.Bankname)
                    .HasMaxLength(100)
                    .HasColumnName("BANKNAME");

                entity.Property(e => e.Branchname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("BRANCHNAME");

                entity.Property(e => e.Currencyid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Residence)
                    .HasMaxLength(100)
                    .HasColumnName("RESIDENCE");

                entity.Property(e => e.Residenceid).HasColumnName("RESIDENCEID");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Transactionid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TRANSACTIONID");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");
            });

            modelBuilder.Entity<ViewResidentialquotum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_RESIDENTIALQUOTA");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GENDER")
                    .IsFixedLength(true);

                entity.Property(e => e.Quota).HasColumnName("QUOTA");

                entity.Property(e => e.Residence)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("RESIDENCE");

                entity.Property(e => e.Timeupdated).HasColumnName("TIMEUPDATED");
            });

            modelBuilder.Entity<ViewResidentialquotum1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_RESIDENTIALQUOTA", "res");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GENDER")
                    .IsFixedLength(true);

                entity.Property(e => e.Quota).HasColumnName("QUOTA");

                entity.Property(e => e.Residence)
                    .HasMaxLength(100)
                    .HasColumnName("RESIDENCE");

                entity.Property(e => e.Residenceid).HasColumnName("RESIDENCEID");

                entity.Property(e => e.Timeupdated).HasColumnName("TIMEUPDATED");

                entity.Property(e => e.Tol).HasColumnName("TOL");
            });

            modelBuilder.Entity<ViewRoomreservation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_ROOMRESERVATION");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.Bankname)
                    .HasMaxLength(100)
                    .HasColumnName("BANKNAME");

                entity.Property(e => e.Branchname)
                    .HasMaxLength(100)
                    .HasColumnName("BRANCHNAME");

                entity.Property(e => e.Currencyid)
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ismanual).HasColumnName("ISMANUAL");

                entity.Property(e => e.Residence)
                    .HasMaxLength(100)
                    .HasColumnName("RESIDENCE");

                entity.Property(e => e.Residenceid).HasColumnName("RESIDENCEID");

                entity.Property(e => e.Roomno)
                    .HasMaxLength(50)
                    .HasColumnName("ROOMNO");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Transactionid)
                    .HasMaxLength(50)
                    .HasColumnName("TRANSACTIONID");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");

                entity.Property(e => e.Wspaymentid).HasColumnName("WSPAYMENTID");
            });

            modelBuilder.Entity<ViewStudent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_STUDENT");

                entity.Property(e => e.Acadyearenrolled).HasColumnName("ACADYEARENROLLED");

                entity.Property(e => e.Birthdate)
                    .HasColumnType("date")
                    .HasColumnName("BIRTHDATE");

                entity.Property(e => e.Countryid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("COUNTRYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Feecategoryid).HasColumnName("FEECATEGORYID");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Othername)
                    .HasMaxLength(50)
                    .HasColumnName("OTHERNAME");

                entity.Property(e => e.Primarymobile)
                    .HasMaxLength(20)
                    .HasColumnName("PRIMARYMOBILE");

                entity.Property(e => e.Programmestream)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("PROGRAMMESTREAM");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Schoolemail)
                    .HasMaxLength(100)
                    .HasColumnName("SCHOOLEMAIL");

                entity.Property(e => e.Schoolmobile)
                    .HasMaxLength(20)
                    .HasColumnName("SCHOOLMOBILE");

                entity.Property(e => e.Schoolpwd)
                    .HasMaxLength(50)
                    .HasColumnName("SCHOOLPWD");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Studentname)
                    .IsRequired()
                    .HasMaxLength(101)
                    .HasColumnName("STUDENTNAME");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("SURNAME");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");
            });

            modelBuilder.Entity<ViewStudent1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_STUDENT", "hospital");

                entity.Property(e => e.Acadyearenrolled).HasColumnName("ACADYEARENROLLED");

                entity.Property(e => e.Birthdate)
                    .HasColumnType("date")
                    .HasColumnName("BIRTHDATE");

                entity.Property(e => e.Countryid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("COUNTRYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Othername)
                    .HasMaxLength(50)
                    .HasColumnName("OTHERNAME");

                entity.Property(e => e.Primarymobile)
                    .HasMaxLength(20)
                    .HasColumnName("PRIMARYMOBILE");

                entity.Property(e => e.Programmestream)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("PROGRAMMESTREAM");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Schoolemail)
                    .HasMaxLength(100)
                    .HasColumnName("SCHOOLEMAIL");

                entity.Property(e => e.Schoolmobile)
                    .HasMaxLength(20)
                    .HasColumnName("SCHOOLMOBILE");

                entity.Property(e => e.Schoolpwd)
                    .HasMaxLength(50)
                    .HasColumnName("SCHOOLPWD");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Studentname)
                    .IsRequired()
                    .HasMaxLength(101)
                    .HasColumnName("STUDENTNAME");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("SURNAME");
            });

            modelBuilder.Entity<ViewStudentCredential>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_StudentCredential");

                entity.Property(e => e.Schoolemail)
                    .HasMaxLength(100)
                    .HasColumnName("SCHOOLEMAIL");

                entity.Property(e => e.Schoolpwd)
                    .HasMaxLength(50)
                    .HasColumnName("SCHOOLPWD");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<ViewStudentbiometricverification>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_STUDENTBIOMETRICVERIFICATION");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");
            });

            modelBuilder.Entity<ViewStudentblocked>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_STUDENTBLOCKED");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<ViewStudentcourse>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_STUDENTCOURSE");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Coursestatusid).HasColumnName("COURSESTATUSID");

                entity.Property(e => e.Credit).HasColumnName("CREDIT");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");
            });

            modelBuilder.Entity<ViewStudentcoursePostgraduate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_STUDENTCOURSE_POSTGRADUATE");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Coursestatusid).HasColumnName("COURSESTATUSID");

                entity.Property(e => e.Credit).HasColumnName("CREDIT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");
            });

            modelBuilder.Entity<ViewStudentmedicalexam>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_STUDENTMEDICALEXAM", "hospital");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<ViewStudentpayment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_STUDENTPAYMENT");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Amount2).HasColumnName("AMOUNT2");

                entity.Property(e => e.Bankaccountno)
                    .HasMaxLength(100)
                    .HasColumnName("BANKACCOUNTNO");

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.Currencyid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Importbatchid)
                    .HasMaxLength(25)
                    .HasColumnName("IMPORTBATCHID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Ischecked).HasColumnName("ISCHECKED");

                entity.Property(e => e.Isreversal).HasColumnName("ISREVERSAL");

                entity.Property(e => e.Narrative)
                    .HasMaxLength(150)
                    .HasColumnName("NARRATIVE");

                entity.Property(e => e.Paymentlocid).HasColumnName("PAYMENTLOCID");

                entity.Property(e => e.Paymenttypeid).HasColumnName("PAYMENTTYPEID");

                entity.Property(e => e.Paymenttypeno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PAYMENTTYPENO");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Reason4reversal)
                    .HasMaxLength(100)
                    .HasColumnName("REASON4REVERSAL");

                entity.Property(e => e.Receiptno)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("RECEIPTNO");

                entity.Property(e => e.Receiptnoold)
                    .HasMaxLength(50)
                    .HasColumnName("RECEIPTNOOLD");

                entity.Property(e => e.Reversedtransactionid).HasColumnName("REVERSEDTRANSACTIONID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Sourceid).HasColumnName("SOURCEID");

                entity.Property(e => e.Sourcepaymentid).HasColumnName("SOURCEPAYMENTID");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Transactionid)
                    .HasMaxLength(50)
                    .HasColumnName("TRANSACTIONID");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEDBY");

                entity.Property(e => e.Xrate).HasColumnName("XRATE");

                entity.Property(e => e.Xrate2).HasColumnName("XRATE2");
            });

            modelBuilder.Entity<ViewStudentphoto>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_STUDENTPHOTO");

                entity.Property(e => e.Photo).HasColumnName("PHOTO");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<ViewStudentresidence>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_STUDENTRESIDENCE");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Datebooked)
                    .HasColumnType("date")
                    .HasColumnName("DATEBOOKED");

                entity.Property(e => e.Residence)
                    .HasMaxLength(100)
                    .HasColumnName("RESIDENCE");

                entity.Property(e => e.Residenceid).HasColumnName("RESIDENCEID");

                entity.Property(e => e.Roomno)
                    .HasMaxLength(100)
                    .HasColumnName("ROOMNO");

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .HasColumnName("SOURCE");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");
            });

            modelBuilder.Entity<ViewStudenttranscript>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_STUDENTTRANSCRIPT");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Coursestatusid).HasColumnName("COURSESTATUSID");

                entity.Property(e => e.Credit).HasColumnName("CREDIT");

                entity.Property(e => e.Grade)
                    .HasMaxLength(2)
                    .HasColumnName("GRADE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Iscalc).HasColumnName("ISCALC");

                entity.Property(e => e.Istrail).HasColumnName("ISTRAIL");

                entity.Property(e => e.Numeq).HasColumnName("NUMEQ");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Totalmark).HasColumnName("TOTALMARK");
            });

            modelBuilder.Entity<ViewStudentunbilled>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_STUDENTUNBILLED", "res");

                entity.Property(e => e.AcadYear)
                    .HasMaxLength(50)
                    .HasColumnName("ACAD_YEAR");

                entity.Property(e => e.Altresidenceid).HasColumnName("ALTRESIDENCEID");

                entity.Property(e => e.Billamount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("BILLAMOUNT");

                entity.Property(e => e.Datebooked)
                    .HasColumnType("date")
                    .HasColumnName("DATEBOOKED");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Residenceid).HasColumnName("RESIDENCEID");

                entity.Property(e => e.Roomno)
                    .HasMaxLength(50)
                    .HasColumnName("ROOMNO");

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .HasColumnName("SOURCE");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");
            });

            modelBuilder.Entity<ViewTaggedstudent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_TAGGEDSTUDENT");

                entity.Property(e => e.Acadyear)
                    .HasMaxLength(41)
                    .HasColumnName("ACADYEAR");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Programmestream)
                    .HasMaxLength(100)
                    .HasColumnName("PROGRAMMESTREAM");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Reason)
                    .HasMaxLength(200)
                    .HasColumnName("REASON");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Tag)
                    .HasMaxLength(50)
                    .HasColumnName("TAG");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");
            });

            modelBuilder.Entity<ViewTestpayment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_TESTPAYMENT");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.Bankaccountno)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("BANKACCOUNTNO");

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.Bankname)
                    .HasMaxLength(100)
                    .HasColumnName("BANKNAME");

                entity.Property(e => e.Branchname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("BRANCHNAME");

                entity.Property(e => e.Clientname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("CLIENTNAME");

                entity.Property(e => e.Clientnetaddress)
                    .HasMaxLength(255)
                    .HasColumnName("CLIENTNETADDRESS");

                entity.Property(e => e.Currencyid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Feeitemid).HasColumnName("FEEITEMID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Ischecked).HasColumnName("ISCHECKED");

                entity.Property(e => e.Isconfirmed).HasColumnName("ISCONFIRMED");

                entity.Property(e => e.Isflagged).HasColumnName("ISFLAGGED");

                entity.Property(e => e.Narrative)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NARRATIVE");

                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Reason4reversal)
                    .HasMaxLength(100)
                    .HasColumnName("REASON4REVERSAL");

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Reversedtransactionid)
                    .HasMaxLength(50)
                    .HasColumnName("REVERSEDTRANSACTIONID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Teller)
                    .HasMaxLength(50)
                    .HasColumnName("TELLER");

                entity.Property(e => e.Timeconfirmed).HasColumnName("TIMECONFIRMED");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Transactionid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TRANSACTIONID");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");

                entity.Property(e => e.Xrate)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("XRATE");
            });

            modelBuilder.Entity<ViewUnconfirmedTransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_UnconfirmedTransactions");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Alttransactionid)
                    .HasMaxLength(50)
                    .HasColumnName("ALTTRANSACTIONID");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.Appname)
                    .HasMaxLength(25)
                    .HasColumnName("APPNAME");

                entity.Property(e => e.Appversioncode)
                    .HasMaxLength(25)
                    .HasColumnName("APPVERSIONCODE");

                entity.Property(e => e.Bankaccountno)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("BANKACCOUNTNO");

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.Bankname)
                    .HasMaxLength(100)
                    .HasColumnName("BANKNAME");

                entity.Property(e => e.Branchname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("BRANCHNAME");

                entity.Property(e => e.Clientname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("CLIENTNAME");

                entity.Property(e => e.Clientnetaddress)
                    .HasMaxLength(255)
                    .HasColumnName("CLIENTNETADDRESS");

                entity.Property(e => e.Currencyid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Feeitemid).HasColumnName("FEEITEMID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Ischecked).HasColumnName("ISCHECKED");

                entity.Property(e => e.Isconfirmed).HasColumnName("ISCONFIRMED");

                entity.Property(e => e.Isflagged).HasColumnName("ISFLAGGED");

                entity.Property(e => e.Isreversal).HasColumnName("ISREVERSAL");

                entity.Property(e => e.Isuploaded).HasColumnName("ISUPLOADED");

                entity.Property(e => e.Narrative)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NARRATIVE");

                entity.Property(e => e.Osname)
                    .HasMaxLength(25)
                    .HasColumnName("OSNAME");

                entity.Property(e => e.Paymentchannelid).HasColumnName("PAYMENTCHANNELID");

                entity.Property(e => e.Paymentservice)
                    .HasMaxLength(100)
                    .HasColumnName("PAYMENTSERVICE");

                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Reason4reversal)
                    .HasMaxLength(100)
                    .HasColumnName("REASON4REVERSAL");

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Reversedtransactionid)
                    .HasMaxLength(50)
                    .HasColumnName("REVERSEDTRANSACTIONID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Teller)
                    .HasMaxLength(50)
                    .HasColumnName("TELLER");

                entity.Property(e => e.Timeconfirmed).HasColumnName("TIMECONFIRMED");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Timeuploaded).HasColumnName("TIMEUPLOADED");

                entity.Property(e => e.Transactionid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TRANSACTIONID");

                entity.Property(e => e.Transactionstatus)
                    .HasMaxLength(100)
                    .HasColumnName("TRANSACTIONSTATUS");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");

                entity.Property(e => e.Xrate)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("XRATE");
            });

            modelBuilder.Entity<ViewUnconfirmedWebPaymentOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_UnconfirmedWebPaymentOrder");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.Bankaccountno)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("BANKACCOUNTNO");

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.Bankname)
                    .HasMaxLength(100)
                    .HasColumnName("BANKNAME");

                entity.Property(e => e.Branchname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("BRANCHNAME");

                entity.Property(e => e.Clientname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("CLIENTNAME");

                entity.Property(e => e.Clientnetaddress)
                    .HasMaxLength(255)
                    .HasColumnName("CLIENTNETADDRESS");

                entity.Property(e => e.Currencyid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Feeitemid).HasColumnName("FEEITEMID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Ischecked).HasColumnName("ISCHECKED");

                entity.Property(e => e.Isconfirmed).HasColumnName("ISCONFIRMED");

                entity.Property(e => e.Isflagged).HasColumnName("ISFLAGGED");

                entity.Property(e => e.Narrative)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NARRATIVE");

                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Reason4reversal)
                    .HasMaxLength(100)
                    .HasColumnName("REASON4REVERSAL");

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Reversedtransactionid)
                    .HasMaxLength(50)
                    .HasColumnName("REVERSEDTRANSACTIONID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Teller)
                    .HasMaxLength(50)
                    .HasColumnName("TELLER");

                entity.Property(e => e.Timeconfirmed).HasColumnName("TIMECONFIRMED");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Transactionid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TRANSACTIONID");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");

                entity.Property(e => e.Xrate)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("XRATE");
            });

            modelBuilder.Entity<ViewUserpayment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_USERPAYMENTS");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Accountreceiptid).HasColumnName("ACCOUNTRECEIPTID");

                entity.Property(e => e.Alttransactionid)
                    .HasMaxLength(50)
                    .HasColumnName("ALTTRANSACTIONID");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Bankname)
                    .HasMaxLength(100)
                    .HasColumnName("BANKNAME");

                entity.Property(e => e.Branchname)
                    .HasMaxLength(100)
                    .HasColumnName("BRANCHNAME");

                entity.Property(e => e.Currencyid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Currencyname)
                    .HasMaxLength(50)
                    .HasColumnName("CURRENCYNAME");

                entity.Property(e => e.Currencysymbol)
                    .HasMaxLength(5)
                    .HasColumnName("CURRENCYSYMBOL");

                entity.Property(e => e.Feeitemcode)
                    .HasMaxLength(20)
                    .HasColumnName("FEEITEMCODE");

                entity.Property(e => e.Feeitemname)
                    .HasMaxLength(100)
                    .HasColumnName("FEEITEMNAME");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasColumnName("ID");

                entity.Property(e => e.Isconfirmed).HasColumnName("ISCONFIRMED");

                entity.Property(e => e.Isreversal).HasColumnName("ISREVERSAL");

                entity.Property(e => e.Narrative)
                    .HasMaxLength(150)
                    .HasColumnName("NARRATIVE");

                entity.Property(e => e.Paymentchannelcode)
                    .HasMaxLength(10)
                    .HasColumnName("PAYMENTCHANNELCODE");

                entity.Property(e => e.Paymentchannelname)
                    .HasMaxLength(50)
                    .HasColumnName("PAYMENTCHANNELNAME");

                entity.Property(e => e.Paymentservice)
                    .HasMaxLength(100)
                    .HasColumnName("PAYMENTSERVICE");

                entity.Property(e => e.Paymenttype)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PAYMENTTYPE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Reversalreason)
                    .HasMaxLength(100)
                    .HasColumnName("REVERSALREASON");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeconfirmed).HasColumnName("TIMECONFIRMED");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Transactionid)
                    .HasMaxLength(50)
                    .HasColumnName("TRANSACTIONID");

                entity.Property(e => e.Transactionstatus)
                    .HasMaxLength(100)
                    .HasColumnName("TRANSACTIONSTATUS");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");
            });

            modelBuilder.Entity<ViewValidresidencebooking>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_VALIDRESIDENCEBOOKING", "res");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Altresidenceid).HasColumnName("ALTRESIDENCEID");

                entity.Property(e => e.Bookingcode).HasColumnName("BOOKINGCODE");

                entity.Property(e => e.Bookingdate)
                    .HasColumnType("datetime")
                    .HasColumnName("BOOKINGDATE");

                entity.Property(e => e.Bookingdeadline)
                    .HasColumnType("datetime")
                    .HasColumnName("BOOKINGDEADLINE");

                entity.Property(e => e.Bookingtypeid).HasColumnName("BOOKINGTYPEID");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Ispaid).HasColumnName("ISPAID");

                entity.Property(e => e.Isreserved).HasColumnName("ISRESERVED");

                entity.Property(e => e.Othername)
                    .HasMaxLength(50)
                    .HasColumnName("OTHERNAME");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Residence)
                    .HasMaxLength(100)
                    .HasColumnName("RESIDENCE");

                entity.Property(e => e.Residenceid).HasColumnName("RESIDENCEID");

                entity.Property(e => e.Roomno)
                    .HasMaxLength(10)
                    .HasColumnName("ROOMNO");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("SURNAME");
            });

            modelBuilder.Entity<ViewValidresidencebooking2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_VALIDRESIDENCEBOOKING2", "res");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Altresidenceid).HasColumnName("ALTRESIDENCEID");

                entity.Property(e => e.Bookingcode).HasColumnName("BOOKINGCODE");

                entity.Property(e => e.Bookingdate)
                    .HasColumnType("datetime")
                    .HasColumnName("BOOKINGDATE");

                entity.Property(e => e.Bookingdeadline)
                    .HasColumnType("datetime")
                    .HasColumnName("BOOKINGDEADLINE");

                entity.Property(e => e.Bookingtypeid).HasColumnName("BOOKINGTYPEID");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Ispaid).HasColumnName("ISPAID");

                entity.Property(e => e.Isreserved).HasColumnName("ISRESERVED");

                entity.Property(e => e.Othername)
                    .HasMaxLength(50)
                    .HasColumnName("OTHERNAME");

                entity.Property(e => e.Residence)
                    .HasMaxLength(100)
                    .HasColumnName("RESIDENCE");

                entity.Property(e => e.Residenceid).HasColumnName("RESIDENCEID");

                entity.Property(e => e.Roomno)
                    .HasMaxLength(10)
                    .HasColumnName("ROOMNO");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("SURNAME");
            });

            modelBuilder.Entity<ViewWebPaymentOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_WebPaymentOrder");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Alttransactionid)
                    .HasMaxLength(50)
                    .HasColumnName("ALTTRANSACTIONID");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.Bankaccountno)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("BANKACCOUNTNO");

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.Bankname)
                    .HasMaxLength(100)
                    .HasColumnName("BANKNAME");

                entity.Property(e => e.Branchname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("BRANCHNAME");

                entity.Property(e => e.Clientname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("CLIENTNAME");

                entity.Property(e => e.Currencyid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Feeitemid).HasColumnName("FEEITEMID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Ischecked).HasColumnName("ISCHECKED");

                entity.Property(e => e.Isconfirmed).HasColumnName("ISCONFIRMED");

                entity.Property(e => e.Narrative)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NARRATIVE");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Reason4reversal)
                    .HasMaxLength(100)
                    .HasColumnName("REASON4REVERSAL");

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Teller)
                    .HasMaxLength(50)
                    .HasColumnName("TELLER");

                entity.Property(e => e.Timeconfirmed).HasColumnName("TIMECONFIRMED");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Transactionid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TRANSACTIONID");

                entity.Property(e => e.Transactionstatus)
                    .HasMaxLength(100)
                    .HasColumnName("TRANSACTIONSTATUS");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");

                entity.Property(e => e.Xrate)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("XRATE");
            });

            modelBuilder.Entity<ViewWspayment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_WSPAYMENT");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Accountreceiptid).HasColumnName("ACCOUNTRECEIPTID");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.AmountSplit)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AMOUNT_SPLIT");

                entity.Property(e => e.Bankaccountno)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("BANKACCOUNTNO");

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.Bankname)
                    .HasMaxLength(100)
                    .HasColumnName("BANKNAME");

                entity.Property(e => e.Branchname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("BRANCHNAME");

                entity.Property(e => e.Clientname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("CLIENTNAME");

                entity.Property(e => e.Clientnetaddress)
                    .HasMaxLength(255)
                    .HasColumnName("CLIENTNETADDRESS");

                entity.Property(e => e.Currencyid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Feeitemid).HasColumnName("FEEITEMID");

                entity.Property(e => e.FeeitemidSplit).HasColumnName("FEEITEMID_SPLIT");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Ischecked).HasColumnName("ISCHECKED");

                entity.Property(e => e.Isconfirmed).HasColumnName("ISCONFIRMED");

                entity.Property(e => e.Isflagged).HasColumnName("ISFLAGGED");

                entity.Property(e => e.Isreversal).HasColumnName("ISREVERSAL");

                entity.Property(e => e.Narrative)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NARRATIVE");

                entity.Property(e => e.Paymentchannelid).HasColumnName("PAYMENTCHANNELID");

                entity.Property(e => e.Paymentservice)
                    .HasMaxLength(100)
                    .HasColumnName("PAYMENTSERVICE");

                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Reason4reversal)
                    .HasMaxLength(100)
                    .HasColumnName("REASON4REVERSAL");

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Reversedtransactionid)
                    .HasMaxLength(50)
                    .HasColumnName("REVERSEDTRANSACTIONID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Teller)
                    .HasMaxLength(50)
                    .HasColumnName("TELLER");

                entity.Property(e => e.Timeconfirmed).HasColumnName("TIMECONFIRMED");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Transactionid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TRANSACTIONID");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");

                entity.Property(e => e.Xrate)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("XRATE");
            });

            modelBuilder.Entity<ViewWspaymentAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_WSPAYMENT_ALL");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Accountreceiptid).HasColumnName("ACCOUNTRECEIPTID");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.Bankaccountno)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("BANKACCOUNTNO");

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.Bankname)
                    .HasMaxLength(100)
                    .HasColumnName("BANKNAME");

                entity.Property(e => e.Branchname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("BRANCHNAME");

                entity.Property(e => e.Clientname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("CLIENTNAME");

                entity.Property(e => e.Clientnetaddress)
                    .HasMaxLength(255)
                    .HasColumnName("CLIENTNETADDRESS");

                entity.Property(e => e.Currencyid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Feeitemid).HasColumnName("FEEITEMID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Ischecked).HasColumnName("ISCHECKED");

                entity.Property(e => e.Isconfirmed).HasColumnName("ISCONFIRMED");

                entity.Property(e => e.Isflagged).HasColumnName("ISFLAGGED");

                entity.Property(e => e.Isreversal).HasColumnName("ISREVERSAL");

                entity.Property(e => e.Narrative)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NARRATIVE");

                entity.Property(e => e.Paymentchannelid).HasColumnName("PAYMENTCHANNELID");

                entity.Property(e => e.Paymentservice)
                    .HasMaxLength(100)
                    .HasColumnName("PAYMENTSERVICE");

                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Reason4reversal)
                    .HasMaxLength(100)
                    .HasColumnName("REASON4REVERSAL");

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Reversedtransactionid)
                    .HasMaxLength(50)
                    .HasColumnName("REVERSEDTRANSACTIONID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Teller)
                    .HasMaxLength(50)
                    .HasColumnName("TELLER");

                entity.Property(e => e.Timeconfirmed).HasColumnName("TIMECONFIRMED");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Transactionid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TRANSACTIONID");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");

                entity.Property(e => e.Xrate)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("XRATE");
            });

            modelBuilder.Entity<Viewacademicrecordactualreg>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEWACADEMICRECORDACTUALREG");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Coursestatusid).HasColumnName("COURSESTATUSID");

                entity.Property(e => e.Coursetypeid).HasColumnName("COURSETYPEID");

                entity.Property(e => e.Credit).HasColumnName("CREDIT");

                entity.Property(e => e.Electivesetid).HasColumnName("ELECTIVESETID");

                entity.Property(e => e.Grade)
                    .HasMaxLength(2)
                    .HasColumnName("GRADE");

                entity.Property(e => e.Isprevioustrail).HasColumnName("ISPREVIOUSTRAIL");

                entity.Property(e => e.Numeq).HasColumnName("NUMEQ");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Registeredonline).HasColumnName("REGISTEREDONLINE");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Totalmark).HasColumnName("TOTALMARK");
            });

            modelBuilder.Entity<Viewacademicrecordactualresult>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEWACADEMICRECORDACTUALRESULT");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Camark).HasColumnName("CAMARK");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Coursestatusid).HasColumnName("COURSESTATUSID");

                entity.Property(e => e.Coursetypeid).HasColumnName("COURSETYPEID");

                entity.Property(e => e.Credit).HasColumnName("CREDIT");

                entity.Property(e => e.Electivesetid).HasColumnName("ELECTIVESETID");

                entity.Property(e => e.Endsemmark).HasColumnName("ENDSEMMARK");

                entity.Property(e => e.Grade)
                    .HasMaxLength(2)
                    .HasColumnName("GRADE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Isapproved).HasColumnName("ISAPPROVED");

                entity.Property(e => e.Isprevioustrail).HasColumnName("ISPREVIOUSTRAIL");

                entity.Property(e => e.Istrail).HasColumnName("ISTRAIL");

                entity.Property(e => e.Numeq).HasColumnName("NUMEQ");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Registeredonline).HasColumnName("REGISTEREDONLINE");

                entity.Property(e => e.Resultsapproved).HasColumnName("RESULTSAPPROVED");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Totalmark).HasColumnName("TOTALMARK");
            });

            modelBuilder.Entity<Viewacademicrecordonlinereg>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEWACADEMICRECORDONLINEREG");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Coursestatusid).HasColumnName("COURSESTATUSID");

                entity.Property(e => e.Coursetypeid).HasColumnName("COURSETYPEID");

                entity.Property(e => e.Credit).HasColumnName("CREDIT");

                entity.Property(e => e.Electivesetid).HasColumnName("ELECTIVESETID");

                entity.Property(e => e.Grade)
                    .HasMaxLength(2)
                    .HasColumnName("GRADE");

                entity.Property(e => e.Isprevioustrail).HasColumnName("ISPREVIOUSTRAIL");

                entity.Property(e => e.Numeq).HasColumnName("NUMEQ");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Registeredonline).HasColumnName("REGISTEREDONLINE");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Totalmark).HasColumnName("TOTALMARK");
            });

            modelBuilder.Entity<Viewcombinedpayment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEWCOMBINEDPAYMENT");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.Currencyid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Narrative)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NARRATIVE");

                entity.Property(e => e.Paymentmode)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("PAYMENTMODE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Transactionid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TRANSACTIONID");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");

                entity.Property(e => e.Xrate).HasColumnName("XRATE");
            });

            modelBuilder.Entity<Viewcourse>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEWCOURSE");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Coursetypeid).HasColumnName("COURSETYPEID");

                entity.Property(e => e.Credit).HasColumnName("CREDIT");

                entity.Property(e => e.Electivesetid).HasColumnName("ELECTIVESETID");

                entity.Property(e => e.Optionid).HasColumnName("OPTIONID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");
            });

            modelBuilder.Entity<Viewcoursesassessedon>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEWCOURSESASSESSEDON");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Lecturerid).HasColumnName("LECTURERID");

                entity.Property(e => e.Published).HasColumnName("PUBLISHED");

                entity.Property(e => e.Sem).HasColumnName("SEM");
            });

            modelBuilder.Entity<Viewdistinctprogrammecoursecodelecturer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEWDISTINCTPROGRAMMECOURSECODELECTURER");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Lecturerid).HasColumnName("LECTURERID");

                entity.Property(e => e.Sem).HasColumnName("SEM");
            });

            modelBuilder.Entity<Viewdistinctprogrammecourselecturer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEWDISTINCTPROGRAMMECOURSELECTURER");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Lecturerid).HasColumnName("LECTURERID");

                entity.Property(e => e.Programme)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("PROGRAMME");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");
            });

            modelBuilder.Entity<Viewdistinctprogrammeyrlecturer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEWDISTINCTPROGRAMMEYRLECTURER");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Lecturerid).HasColumnName("LECTURERID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");
            });

            modelBuilder.Entity<Viewinstitution>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEWINSTITUTION");

                entity.Property(e => e.Instid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("INSTID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.Shortcode)
                    .HasMaxLength(10)
                    .HasColumnName("SHORTCODE");
            });

            modelBuilder.Entity<Viewlectureracadrecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEWLECTURERACADRECORDS");

                entity.Property(e => e.Acadlevel)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ACADLEVEL");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Camark).HasColumnName("CAMARK");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Coursestatuscode)
                    .HasMaxLength(50)
                    .HasColumnName("COURSESTATUSCODE");

                entity.Property(e => e.Coursestatusid).HasColumnName("COURSESTATUSID");

                entity.Property(e => e.Credit).HasColumnName("CREDIT");

                entity.Property(e => e.Endsemmark).HasColumnName("ENDSEMMARK");

                entity.Property(e => e.Grade)
                    .HasMaxLength(2)
                    .HasColumnName("GRADE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Indexno)
                    .HasMaxLength(50)
                    .HasColumnName("INDEXNO");

                entity.Property(e => e.Lecturerid).HasColumnName("LECTURERID");

                entity.Property(e => e.Name)
                    .HasMaxLength(102)
                    .HasColumnName("NAME");

                entity.Property(e => e.Numeq).HasColumnName("NUMEQ");

                entity.Property(e => e.Oldmark)
                    .HasMaxLength(50)
                    .HasColumnName("OLDMARK");

                entity.Property(e => e.Optionid).HasColumnName("OPTIONID");

                entity.Property(e => e.Optionname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("OPTIONNAME");

                entity.Property(e => e.Programme)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("PROGRAMME");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Totalmark).HasColumnName("TOTALMARK");
            });

            modelBuilder.Entity<Viewprogrammecourselecturer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEWPROGRAMMECOURSELECTURER");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Lecturerid).HasColumnName("LECTURERID");

                entity.Property(e => e.Programme)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("PROGRAMME");

                entity.Property(e => e.Sem).HasColumnName("SEM");
            });

            modelBuilder.Entity<Viewpustudentphoto>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEWPUSTUDENTPHOTOS");

                entity.Property(e => e.Photo).HasColumnName("PHOTO");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<Viewstaffappsgetcoursedetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEWSTAFFAPPSGETCOURSEDETAILS");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Camark).HasColumnName("CAMARK");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Coursestatuscode)
                    .HasMaxLength(50)
                    .HasColumnName("COURSESTATUSCODE");

                entity.Property(e => e.Coursestatusid).HasColumnName("COURSESTATUSID");

                entity.Property(e => e.Credit).HasColumnName("CREDIT");

                entity.Property(e => e.Endsemmark).HasColumnName("ENDSEMMARK");

                entity.Property(e => e.Grade)
                    .HasMaxLength(2)
                    .HasColumnName("GRADE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Indexno)
                    .HasMaxLength(50)
                    .HasColumnName("INDEXNO");

                entity.Property(e => e.Lecturerid).HasColumnName("LECTURERID");

                entity.Property(e => e.Name)
                    .HasMaxLength(102)
                    .HasColumnName("NAME");

                entity.Property(e => e.Numeq).HasColumnName("NUMEQ");

                entity.Property(e => e.Oldmark)
                    .HasMaxLength(50)
                    .HasColumnName("OLDMARK");

                entity.Property(e => e.Optionid).HasColumnName("OPTIONID");

                entity.Property(e => e.Optionname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("OPTIONNAME");

                entity.Property(e => e.Programme)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("PROGRAMME");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEUPDATED");

                entity.Property(e => e.Totalmark).HasColumnName("TOTALMARK");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(100)
                    .HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Viewstudentbill>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEWSTUDENTBILL");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<Viewstudentprogramme>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEWSTUDENTPROGRAMME");

                entity.Property(e => e.Campusid).HasColumnName("CAMPUSID");

                entity.Property(e => e.Indexno)
                    .HasMaxLength(50)
                    .HasColumnName("INDEXNO");

                entity.Property(e => e.Isfeepaying).HasColumnName("ISFEEPAYING");

                entity.Property(e => e.Isresidential).HasColumnName("ISRESIDENTIAL");

                entity.Property(e => e.Optionid).HasColumnName("OPTIONID");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<Viewstudidentity>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEWSTUDIDENTITY");

                entity.Property(e => e.Birthdate)
                    .HasColumnType("date")
                    .HasColumnName("BIRTHDATE");

                entity.Property(e => e.Countryid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("COUNTRYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Currentresidenceid).HasColumnName("CURRENTRESIDENCEID");

                entity.Property(e => e.Denomination)
                    .HasMaxLength(100)
                    .HasColumnName("DENOMINATION");

                entity.Property(e => e.Denominationid).HasColumnName("DENOMINATIONID");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Othername)
                    .HasMaxLength(50)
                    .HasColumnName("OTHERNAME");

                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Picture).HasColumnName("PICTURE");

                entity.Property(e => e.Placeofresidenceid).HasColumnName("PLACEOFRESIDENCEID");

                entity.Property(e => e.Postadd1)
                    .HasMaxLength(300)
                    .HasColumnName("POSTADD1");

                entity.Property(e => e.Postadd2)
                    .HasMaxLength(200)
                    .HasColumnName("POSTADD2");

                entity.Property(e => e.Postadd3)
                    .HasMaxLength(100)
                    .HasColumnName("POSTADD3");

                entity.Property(e => e.Postadd4)
                    .HasMaxLength(100)
                    .HasColumnName("POSTADD4");

                entity.Property(e => e.Primarymobile)
                    .HasMaxLength(20)
                    .HasColumnName("PRIMARYMOBILE");

                entity.Property(e => e.Regionid).HasColumnName("REGIONID");

                entity.Property(e => e.Religionid).HasColumnName("RELIGIONID");

                entity.Property(e => e.Resadd1)
                    .HasMaxLength(300)
                    .HasColumnName("RESADD1");

                entity.Property(e => e.Resadd2)
                    .HasMaxLength(200)
                    .HasColumnName("RESADD2");

                entity.Property(e => e.Resadd3)
                    .HasMaxLength(100)
                    .HasColumnName("RESADD3");

                entity.Property(e => e.Resadd4)
                    .HasMaxLength(100)
                    .HasColumnName("RESADD4");

                entity.Property(e => e.Schoolemail)
                    .HasMaxLength(100)
                    .HasColumnName("SCHOOLEMAIL");

                entity.Property(e => e.Schoolmobile)
                    .HasMaxLength(20)
                    .HasColumnName("SCHOOLMOBILE");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("SURNAME");

                entity.Property(e => e.Titleid).HasColumnName("TITLEID");
            });

            modelBuilder.Entity<Viewupdateacademicrecordactual>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEWUPDATEACADEMICRECORDACTUAL");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadrank).HasColumnName("ACADRANK");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.App)
                    .HasMaxLength(25)
                    .HasColumnName("APP");

                entity.Property(e => e.Camark).HasColumnName("CAMARK");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Coursestatusid).HasColumnName("COURSESTATUSID");

                entity.Property(e => e.Coursetypeid).HasColumnName("COURSETYPEID");

                entity.Property(e => e.Credit).HasColumnName("CREDIT");

                entity.Property(e => e.Electivesetid).HasColumnName("ELECTIVESETID");

                entity.Property(e => e.Endsemmark).HasColumnName("ENDSEMMARK");

                entity.Property(e => e.Grade)
                    .HasMaxLength(2)
                    .HasColumnName("GRADE");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Iscalc).HasColumnName("ISCALC");

                entity.Property(e => e.Isprevioustrail).HasColumnName("ISPREVIOUSTRAIL");

                entity.Property(e => e.Istrail).HasColumnName("ISTRAIL");

                entity.Property(e => e.Numeq).HasColumnName("NUMEQ");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Registeredonline).HasColumnName("REGISTEREDONLINE");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Timeupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEUPDATED");

                entity.Property(e => e.Totalmark).HasColumnName("TOTALMARK");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(100)
                    .HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Viewupdateacademicrecordonline>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEWUPDATEACADEMICRECORDONLINE");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.App)
                    .HasMaxLength(25)
                    .HasColumnName("APP");

                entity.Property(e => e.Camark).HasColumnName("CAMARK");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Coursestatusid).HasColumnName("COURSESTATUSID");

                entity.Property(e => e.Coursetypeid).HasColumnName("COURSETYPEID");

                entity.Property(e => e.Credit).HasColumnName("CREDIT");

                entity.Property(e => e.Electivesetid).HasColumnName("ELECTIVESETID");

                entity.Property(e => e.Endsemmark).HasColumnName("ENDSEMMARK");

                entity.Property(e => e.Grade)
                    .HasMaxLength(2)
                    .HasColumnName("GRADE");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Iscalc).HasColumnName("ISCALC");

                entity.Property(e => e.Isprevioustrail).HasColumnName("ISPREVIOUSTRAIL");

                entity.Property(e => e.Istrail).HasColumnName("ISTRAIL");

                entity.Property(e => e.Numeq).HasColumnName("NUMEQ");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Registeredonline).HasColumnName("REGISTEREDONLINE");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Timeupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEUPDATED");

                entity.Property(e => e.Totalmark).HasColumnName("TOTALMARK");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Viewupdateacadrecordlecturer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEWUPDATEACADRECORDLECTURER");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Camark).HasColumnName("CAMARK");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("COURSECODE");

                entity.Property(e => e.Coursestatusid).HasColumnName("COURSESTATUSID");

                entity.Property(e => e.Endsemmark).HasColumnName("ENDSEMMARK");

                entity.Property(e => e.Grade)
                    .HasMaxLength(2)
                    .HasColumnName("GRADE");

                entity.Property(e => e.Iscalc).HasColumnName("ISCALC");

                entity.Property(e => e.Istrail).HasColumnName("ISTRAIL");

                entity.Property(e => e.Numeq).HasColumnName("NUMEQ");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEUPDATED");

                entity.Property(e => e.Totalmark).HasColumnName("TOTALMARK");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(100)
                    .HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<VodafoneTimeMatch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VODAFONE_TIME_MATCH");

                entity.Property(e => e.AcctCode)
                    .HasMaxLength(255)
                    .HasColumnName("ACCT_CODE");

                entity.Property(e => e.BillingAcct)
                    .HasMaxLength(255)
                    .HasColumnName("BILLING_ACCT");

                entity.Property(e => e.ChargeAmt).HasColumnName("CHARGE_AMT");

                entity.Property(e => e.ChargeCodeType)
                    .HasMaxLength(255)
                    .HasColumnName("CHARGE_CODE_TYPE");

                entity.Property(e => e.InvoiceDate)
                    .HasMaxLength(255)
                    .HasColumnName("INVOICE_DATE");

                entity.Property(e => e.Msisdn)
                    .HasMaxLength(255)
                    .HasColumnName("MSISDN");

                entity.Property(e => e.OfferingName)
                    .HasMaxLength(255)
                    .HasColumnName("OFFERING_NAME");

                entity.Property(e => e.ProductSegregation)
                    .HasMaxLength(255)
                    .HasColumnName("PRODUCT_SEGREGATION");

                entity.Property(e => e.TaxAmt).HasColumnName("TAX_AMT");

                entity.Property(e => e.Total).HasColumnName("TOTAL");

                entity.Property(e => e.Vodafonenumber)
                    .HasMaxLength(255)
                    .HasColumnName("VODAFONENUMBER");
            });

            modelBuilder.Entity<VodafoneTimeUnmatch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VODAFONE_TIME_UNMATCH");

                entity.Property(e => e.AcctCode)
                    .HasMaxLength(255)
                    .HasColumnName("ACCT_CODE");

                entity.Property(e => e.BillingAcct)
                    .HasMaxLength(255)
                    .HasColumnName("BILLING_ACCT");

                entity.Property(e => e.ChargeAmt).HasColumnName("CHARGE_AMT");

                entity.Property(e => e.ChargeCodeType)
                    .HasMaxLength(255)
                    .HasColumnName("CHARGE_CODE_TYPE");

                entity.Property(e => e.InvoiceDate)
                    .HasMaxLength(255)
                    .HasColumnName("INVOICE_DATE");

                entity.Property(e => e.Msisdn)
                    .HasMaxLength(255)
                    .HasColumnName("MSISDN");

                entity.Property(e => e.OfferingName)
                    .HasMaxLength(255)
                    .HasColumnName("OFFERING_NAME");

                entity.Property(e => e.ProductSegregation)
                    .HasMaxLength(255)
                    .HasColumnName("PRODUCT_SEGREGATION");

                entity.Property(e => e.TaxAmt).HasColumnName("TAX_AMT");

                entity.Property(e => e.Total).HasColumnName("TOTAL");

                entity.Property(e => e.Vodafonenumber)
                    .HasMaxLength(255)
                    .HasColumnName("VODAFONENUMBER");
            });

            modelBuilder.Entity<Vodafonesurvey>(entity =>
            {
                entity.ToTable("VODAFONESURVEY");

                entity.HasIndex(e => e.Studentid, "IX_VODAFONESURVEY1");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Choice).HasColumnName("CHOICE");

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .HasColumnName("COMMENT");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");
            });

            modelBuilder.Entity<WeekDay>(entity =>
            {
                entity.HasKey(e => e.WeekDayId)
                    .IsClustered(false);

                entity.ToTable("WeekDay", "tt");

                entity.Property(e => e.WeekDayName)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Wsitem>(entity =>
            {
                entity.HasKey(e => e.Wsitem1)
                    .IsClustered(false);

                entity.ToTable("WSITEM");

                entity.Property(e => e.Wsitem1).HasColumnName("WSITEM");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<Wsitemfeecategory>(entity =>
            {
                entity.HasKey(e => new { e.Wsitem, e.Feecategoryid })
                    .HasName("PK248")
                    .IsClustered(false);

                entity.ToTable("WSITEMFEECATEGORY");

                entity.Property(e => e.Wsitem).HasColumnName("WSITEM");

                entity.Property(e => e.Feecategoryid).HasColumnName("FEECATEGORYID");

                entity.HasOne(d => d.Feecategory)
                    .WithMany(p => p.Wsitemfeecategories)
                    .HasForeignKey(d => d.Feecategoryid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RefFEECATEGORY5561");

                entity.HasOne(d => d.WsitemNavigation)
                    .WithMany(p => p.Wsitemfeecategories)
                    .HasForeignKey(d => d.Wsitem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RefWSITEM5551");
            });

            modelBuilder.Entity<Wsitemfeecategorybankaccount>(entity =>
            {
                entity.HasKey(e => new { e.Wsitem, e.Feecategoryid, e.Bankaccountid })
                    .HasName("PK249")
                    .IsClustered(false);

                entity.ToTable("WSITEMFEECATEGORYBANKACCOUNT");

                entity.Property(e => e.Wsitem).HasColumnName("WSITEM");

                entity.Property(e => e.Feecategoryid).HasColumnName("FEECATEGORYID");

                entity.Property(e => e.Bankaccountid).HasColumnName("BANKACCOUNTID");

                entity.HasOne(d => d.Bankaccount)
                    .WithMany(p => p.Wsitemfeecategorybankaccounts)
                    .HasForeignKey(d => d.Bankaccountid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RefBANKACCOUNT5581");

                entity.HasOne(d => d.Wsitemfeecategory)
                    .WithMany(p => p.Wsitemfeecategorybankaccounts)
                    .HasForeignKey(d => new { d.Wsitem, d.Feecategoryid })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RefWSITEMFEECATEGORY5571");
            });

            modelBuilder.Entity<Wsorderidseed>(entity =>
            {
                entity.ToTable("WSORDERIDSEED");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Seed)
                    .HasColumnName("SEED")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");
            });

            modelBuilder.Entity<Wspayment>(entity =>
            {
                entity.ToTable("WSPAYMENT");

                entity.HasIndex(e => new { e.Isflagged, e.Isconfirmed, e.Studentid, e.Feeitemid }, "<Name of Missing Index, sysname,>");

                entity.HasIndex(e => new { e.Accountreceiptid, e.Timeinserted }, "IX_ACCOUNTRECEIPTID");

                entity.HasIndex(e => new { e.Bankid, e.Transactionid }, "IX_WSPAYMENT");

                entity.HasIndex(e => new { e.Reversedtransactionid, e.Feeitemid, e.Isconfirmed, e.Isflagged, e.Isuploaded, e.Studentid, e.Programmestreamid, e.Bankid, e.Timeinserted }, "IX_WSPAYMENT1");

                entity.HasIndex(e => e.Accountreceiptid, "IX_WSPAYMENT_ACCOUNTRECEIPTID");

                entity.HasIndex(e => new { e.Bankid, e.Isconfirmed, e.Timeinserted, e.Transactionstatus }, "IX_WSPAYMENT_TRANSACTIONSTATUS");

                entity.HasIndex(e => new { e.Studentid, e.Transdate, e.Feeitemid, e.Isflagged, e.Isconfirmed, e.Programmestreamid, e.Acadyear, e.Sem, e.Currencyid, e.Bankid, e.Transactionid }, "_dta_index_WSPAYMENT_11_2136394680__K2_K13_K12_K22_K20_K3_K33_K34_K14_K6_K9_11_15");

                entity.HasIndex(e => new { e.Studentid, e.Isconfirmed, e.Isflagged, e.Acadyear, e.Feeitemid }, "missing_index_17");

                entity.HasIndex(e => new { e.Bankid, e.Bankaccountno, e.Reversedtransactionid, e.Feeitemid, e.Currencyid, e.Isconfirmed, e.Isflagged, e.Isuploaded, e.Programmestreamid }, "missing_index_256");

                entity.HasIndex(e => new { e.Reversedtransactionid, e.Feeitemid, e.Isconfirmed, e.Isflagged, e.Isuploaded, e.Studentid, e.Programmestreamid, e.Bankid }, "missing_index_258");

                entity.HasIndex(e => new { e.Isconfirmed, e.Isflagged, e.Studentid, e.Bankid, e.Transdate }, "missing_index_294");

                entity.HasIndex(e => e.Isuploaded, "missing_index_3673");

                entity.HasIndex(e => new { e.Isconfirmed, e.Isflagged, e.Acadyear, e.Sem, e.Studentid, e.Feeitemid }, "missing_index_97");

                entity.HasIndex(e => new { e.Isconfirmed, e.Isflagged, e.Studentid, e.Feeitemid }, "missing_index_99");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Accountreceiptid).HasColumnName("ACCOUNTRECEIPTID");

                entity.Property(e => e.Alttransactionid)
                    .HasMaxLength(50)
                    .HasColumnName("ALTTRANSACTIONID");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.AmountSplit)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AMOUNT_SPLIT");

                entity.Property(e => e.Appname)
                    .HasMaxLength(25)
                    .HasColumnName("APPNAME");

                entity.Property(e => e.Appversioncode)
                    .HasMaxLength(25)
                    .HasColumnName("APPVERSIONCODE");

                entity.Property(e => e.Bankaccountno)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("BANKACCOUNTNO");

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.Bankname)
                    .HasMaxLength(100)
                    .HasColumnName("BANKNAME");

                entity.Property(e => e.Branchname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("BRANCHNAME");

                entity.Property(e => e.Clientname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("CLIENTNAME");

                entity.Property(e => e.Clientnetaddress)
                    .HasMaxLength(255)
                    .HasColumnName("CLIENTNETADDRESS");

                entity.Property(e => e.Confirmedby)
                    .HasMaxLength(256)
                    .HasColumnName("CONFIRMEDBY");

                entity.Property(e => e.Currencyid)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYID")
                    .IsFixedLength(true);

                entity.Property(e => e.Feeitemid).HasColumnName("FEEITEMID");

                entity.Property(e => e.FeeitemidSplit).HasColumnName("FEEITEMID_SPLIT");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY");

                entity.Property(e => e.Ischecked).HasColumnName("ISCHECKED");

                entity.Property(e => e.Isconfirmed).HasColumnName("ISCONFIRMED");

                entity.Property(e => e.Isflagged).HasColumnName("ISFLAGGED");

                entity.Property(e => e.Isreversal).HasColumnName("ISREVERSAL");

                entity.Property(e => e.Isuploaded).HasColumnName("ISUPLOADED");

                entity.Property(e => e.Narrative)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("NARRATIVE");

                entity.Property(e => e.Osname)
                    .HasMaxLength(25)
                    .HasColumnName("OSNAME");

                entity.Property(e => e.Paymentchannelid).HasColumnName("PAYMENTCHANNELID");

                entity.Property(e => e.Paymentservice)
                    .HasMaxLength(100)
                    .HasColumnName("PAYMENTSERVICE");

                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Reason4reversal)
                    .HasMaxLength(100)
                    .HasColumnName("REASON4REVERSAL");

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Reversedtransactionid)
                    .HasMaxLength(50)
                    .HasColumnName("REVERSEDTRANSACTIONID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Teller)
                    .HasMaxLength(50)
                    .HasColumnName("TELLER");

                entity.Property(e => e.Timeconfirmed).HasColumnName("TIMECONFIRMED");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED");

                entity.Property(e => e.Timeuploaded).HasColumnName("TIMEUPLOADED");

                entity.Property(e => e.Transactionid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TRANSACTIONID");

                entity.Property(e => e.Transactionstatus)
                    .HasMaxLength(100)
                    .HasColumnName("TRANSACTIONSTATUS");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");

                entity.Property(e => e.Xrate)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("XRATE")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Wspaymentaccepttransaction>(entity =>
            {
                entity.HasKey(e => new { e.Bankid, e.Transactionid });

                entity.ToTable("WSPAYMENTACCEPTTRANSACTION");

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.Transactionid)
                    .HasMaxLength(50)
                    .HasColumnName("TRANSACTIONID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.Reason)
                    .HasMaxLength(50)
                    .HasColumnName("REASON");

                entity.Property(e => e.Timeinserted)
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.Wspaymentaccepttransactions)
                    .HasForeignKey(d => d.Bankid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WSPAYMENTACCEPTTRANSACTION_BANK");
            });

            modelBuilder.Entity<Wspaymentsplit>(entity =>
            {
                entity.ToTable("WSPAYMENTSPLIT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.Autosplit).HasColumnName("AUTOSPLIT");

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.Clientnetaddress)
                    .HasMaxLength(255)
                    .HasColumnName("CLIENTNETADDRESS");

                entity.Property(e => e.Feeitemid).HasColumnName("FEEITEMID");

                entity.Property(e => e.Insertedby)
                    .HasMaxLength(100)
                    .HasColumnName("INSERTEDBY")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.Studentid)
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Timeinserted)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMEINSERTED")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Transactionid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TRANSACTIONID");
            });

            modelBuilder.Entity<Wsresponse>(entity =>
            {
                entity.HasKey(e => e.Responseid)
                    .IsClustered(false);

                entity.ToTable("WSRESPONSE");

                entity.Property(e => e.Responseid)
                    .ValueGeneratedNever()
                    .HasColumnName("RESPONSEID");

                entity.Property(e => e.Responsemessage)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("RESPONSEMESSAGE");
            });

            modelBuilder.Entity<Wsuser>(entity =>
            {
                entity.ToTable("WSUSER");

                entity.Property(e => e.Wsuserid).HasColumnName("WSUSERID");

                entity.Property(e => e.Gid)
                    .HasMaxLength(50)
                    .HasColumnName("GID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<Wsuserbank>(entity =>
            {
                entity.ToTable("WSUSERBANK");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<Xresit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("XRESIT");

                entity.Property(e => e.Acadlevelid).HasColumnName("ACADLEVELID");

                entity.Property(e => e.Acadyear).HasColumnName("ACADYEAR");

                entity.Property(e => e.Programmestreamid).HasColumnName("PROGRAMMESTREAMID");

                entity.Property(e => e.Sem).HasColumnName("SEM");

                entity.Property(e => e.Studentid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Trailcount).HasColumnName("TRAILCOUNT");
            });

            modelBuilder.Entity<YearLevel>(entity =>
            {
                entity.HasKey(e => e.YearLevelId)
                    .IsClustered(false);

                entity.ToTable("YearLevel", "tt");

                entity.Property(e => e.YearLevelId).ValueGeneratedNever();

                entity.Property(e => e.YearLevelName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
