export enum CourseType {
    Angular = "Angular",
    NodeJS = "Node.js",
    FullStack = "FullStack"
}

export interface StudentData {
    name: string;
    age: number;
    courseName: CourseType;
    knowsHTML: boolean;
}

export class Student {
    name: string;
    age: number;
    courseName: CourseType;
    knowsHTML: boolean;
    courseCategory: string;
    enrollmentStatus: string;

    constructor(data: StudentData) {
        this.name = data.name;
        this.age = data.age;
        this.courseName = data.courseName;
        this.knowsHTML = data.knowsHTML;
        this.courseCategory = this.getCourseCategory();
        this.enrollmentStatus = this.getEnrollmentStatus();
    }

    private getCourseCategory(): string {
        switch (this.courseName) {
            case CourseType.Angular: return "Front-End";
            case CourseType.NodeJS: return "Back-End";
            case CourseType.FullStack: return "Full-Stack";
            default: return "Unknown";
        }
    }

    private getEnrollmentStatus(): string {
        if (this.age < 18) return "Not Eligible";
        if (this.courseName === CourseType.Angular && !this.knowsHTML) return "Not Eligible";
        return "Eligible";
    }

    public display(): void {
        console.log(`Student Name: ${this.name}`);
        console.log(`Age: ${this.age}`);
        console.log(`Course: ${this.courseName}`);
        console.log(`Knows HTML: ${this.knowsHTML}`);
        console.log(`Course Category: ${this.courseCategory}`);
        console.log(`Enrollment Status: ${this.enrollmentStatus}`);
        console.log('------------------------');
    }
}
