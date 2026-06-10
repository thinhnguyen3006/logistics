let student = {
    name:"Thịnh",
    age: 22,
    major: "Công nghệ thông tin",
};

let json= JSON.stringify(student);
console.log(json); // In ra chuỗi JSON

let jsonString = '{"name":"Thịnh","age":22,"major":"Công nghệ thông tin"}';
let studentObj = JSON.parse(jsonString);
console.log(studentObj.name); // In ra "Thịnh"
console.log(studentObj.age); // In ra 22
console.log(studentObj.major); // In ra "Công nghệ thông tin"