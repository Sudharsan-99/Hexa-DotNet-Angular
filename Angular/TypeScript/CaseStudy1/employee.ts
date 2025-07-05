enum Department {
    HR = "HR",
    IT = "IT",
    Sales = "Sales"
}

interface EmployeeData {
    name: string;
    age: number;
    department: Department;
    baseSalary: number;
}

class Employee {
    name: string;
    age: number;
    department: Department;
    baseSalary: number;
    netSalary: number;
    category: string;

    constructor(data: EmployeeData) {
        this.name = data.name;
        this.age = data.age;
        this.department = data.department;
        this.baseSalary = data.baseSalary;
        this.netSalary = this.calculateNetSalary();
        this.category = this.categorize();
    }

    private calculateBonus(): number {
        switch (this.department) {
            case Department.HR:
                return this.baseSalary * 0.10;
            case Department.IT:
                return this.baseSalary * 0.15;
            case Department.Sales:
                return this.baseSalary * 0.12;
            default:
                return 0;
        }
    }

    private calculateNetSalary(): number {
        return this.baseSalary + this.calculateBonus();
    }

    private categorize(): string {
        if (this.netSalary >= 80000) {
            return "High Earner";
        } else if (this.netSalary >= 50000) {
            return "Mid Earner";
        } else {
            return "Low Earner";
        }
    }

    public displayDetails(): void {
        console.log(`Employee Name: ${this.name}`);
        console.log(`Age: ${this.age}`);
        console.log(`Department: ${this.department}`);
        console.log(`Base Salary: ₹${this.baseSalary}`);
        console.log(`Net Salary (with bonus): ₹${this.netSalary}`);
        console.log(`Category: ${this.category}`);
        console.log('------------------------');
    }
}

const employees: Employee[] = [
    new Employee({ name: "Ravi", age: 28, department: Department.IT, baseSalary: 60000 }),
    new Employee({ name: "Priya", age: 32, department: Department.HR, baseSalary: 48000 }),
    new Employee({ name: "Arjun", age: 26, department: Department.Sales, baseSalary: 85000 }),
];

for (const emp of employees) {
    emp.displayDetails();
}
