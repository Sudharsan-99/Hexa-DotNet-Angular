"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const EnrollmentService_1 = require("./services/EnrollmentService");
const studentsData_1 = require("./data/studentsData");
const service = new EnrollmentService_1.EnrollmentService();
for (const student of studentsData_1.sampleStudents) {
    service.enroll(student);
}
service.showAll();
