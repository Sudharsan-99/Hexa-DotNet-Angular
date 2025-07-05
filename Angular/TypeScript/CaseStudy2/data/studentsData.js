"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.sampleStudents = void 0;
const Student_1 = require("../Models/Student");
exports.sampleStudents = [
    { name: "Sneha", age: 20, courseName: Student_1.CourseType.Angular, knowsHTML: true },
    { name: "Karan", age: 17, courseName: Student_1.CourseType.NodeJS, knowsHTML: false },
    { name: "Riya", age: 22, courseName: Student_1.CourseType.Angular, knowsHTML: false },
    { name: "Aman", age: 25, courseName: Student_1.CourseType.FullStack, knowsHTML: true }
];
