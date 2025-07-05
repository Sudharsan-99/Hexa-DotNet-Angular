import { EnrollmentService } from "./services/EnrollmentService";
import { sampleStudents } from "./data/studentsData";

const service = new EnrollmentService();

for (const student of sampleStudents) {
    service.enroll(student);
}

service.showAll();
