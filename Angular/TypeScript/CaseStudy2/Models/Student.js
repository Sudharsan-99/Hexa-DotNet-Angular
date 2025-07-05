"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Student = exports.CourseType = void 0;
var CourseType;
(function (CourseType) {
    CourseType["Angular"] = "Angular";
    CourseType["NodeJS"] = "Node.js";
    CourseType["FullStack"] = "FullStack";
})(CourseType || (exports.CourseType = CourseType = {}));
class Student {
    constructor(data) {
        this.name = data.name;
        this.age = data.age;
        this.courseName = data.courseName;
        this.knowsHTML = data.knowsHTML;
        this.courseCategory = this.getCourseCategory();
        this.enrollmentStatus = this.getEnrollmentStatus();
    }
    getCourseCategory() {
        switch (this.courseName) {
            case CourseType.Angular: return "Front-End";
            case CourseType.NodeJS: return "Back-End";
            case CourseType.FullStack: return "Full-Stack";
            default: return "Unknown";
        }
    }
    getEnrollmentStatus() {
        if (this.age < 18)
            return "Not Eligible";
        if (this.courseName === CourseType.Angular && !this.knowsHTML)
            return "Not Eligible";
        return "Eligible";
    }
    display() {
        console.log(`Student Name: ${this.name}`);
        console.log(`Age: ${this.age}`);
        console.log(`Course: ${this.courseName}`);
        console.log(`Knows HTML: ${this.knowsHTML}`);
        console.log(`Course Category: ${this.courseCategory}`);
        console.log(`Enrollment Status: ${this.enrollmentStatus}`);
        console.log('------------------------');
    }
}
exports.Student = Student;
