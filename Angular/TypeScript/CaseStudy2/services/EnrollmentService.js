"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.EnrollmentService = void 0;
const Student_1 = require("../Models/Student");
class EnrollmentService {
    constructor() {
        this.students = [];
    }
    enroll(data) {
        const student = new Student_1.Student(data);
        this.students.push(student);
    }
    showAll() {
        for (const student of this.students) {
            student.display();
        }
    }
}
exports.EnrollmentService = EnrollmentService;
