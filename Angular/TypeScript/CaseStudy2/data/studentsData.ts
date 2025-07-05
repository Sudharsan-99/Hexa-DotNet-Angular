import { StudentData, CourseType } from "../Models/Student";

export const sampleStudents: StudentData[] = [
    { name: "Sneha", age: 20, courseName: CourseType.Angular, knowsHTML: true },
    { name: "Karan", age: 17, courseName: CourseType.NodeJS, knowsHTML: false },
    { name: "Riya", age: 22, courseName: CourseType.Angular, knowsHTML: false },
    { name: "Aman", age: 25, courseName: CourseType.FullStack, knowsHTML: true }
];
