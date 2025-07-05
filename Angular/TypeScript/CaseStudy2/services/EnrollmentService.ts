import { Student, StudentData } from "../Models/Student";

export class EnrollmentService {
    private students: Student[] = [];

    enroll(data: StudentData): void {
        const student = new Student(data);
        this.students.push(student);
    }

    showAll(): void {
        for (const student of this.students) {
            student.display();
        }
    }
}
