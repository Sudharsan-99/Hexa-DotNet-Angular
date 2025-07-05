var Department;
(function (Department) {
    Department["HR"] = "HR";
    Department["IT"] = "IT";
    Department["Sales"] = "Sales";
})(Department || (Department = {}));
var Employee = /** @class */ (function () {
    function Employee(data) {
        this.name = data.name;
        this.age = data.age;
        this.department = data.department;
        this.baseSalary = data.baseSalary;
        this.netSalary = this.calculateNetSalary();
        this.category = this.categorize();
    }
    Employee.prototype.calculateBonus = function () {
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
    };
    Employee.prototype.calculateNetSalary = function () {
        return this.baseSalary + this.calculateBonus();
    };
    Employee.prototype.categorize = function () {
        if (this.netSalary >= 80000) {
            return "High Earner";
        }
        else if (this.netSalary >= 50000) {
            return "Mid Earner";
        }
        else {
            return "Low Earner";
        }
    };
    Employee.prototype.displayDetails = function () {
        console.log("Employee Name: ".concat(this.name));
        console.log("Age: ".concat(this.age));
        console.log("Department: ".concat(this.department));
        console.log("Base Salary: \u20B9".concat(this.baseSalary));
        console.log("Net Salary (with bonus): \u20B9".concat(this.netSalary));
        console.log("Category: ".concat(this.category));
        console.log('------------------------');
    };
    return Employee;
}());
var employees = [
    new Employee({ name: "Ravi", age: 28, department: Department.IT, baseSalary: 60000 }),
    new Employee({ name: "Priya", age: 32, department: Department.HR, baseSalary: 48000 }),
    new Employee({ name: "Arjun", age: 26, department: Department.Sales, baseSalary: 85000 }),
];
for (var _i = 0, employees_1 = employees; _i < employees_1.length; _i++) {
    var emp = employees_1[_i];
    emp.displayDetails();
}
