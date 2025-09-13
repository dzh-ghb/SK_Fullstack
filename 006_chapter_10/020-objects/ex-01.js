const user = { // создание объекта через литералы
    name: "John",
    age: 30, // запятую лучше оставлять
    // (чтобы не было проблем при добавлении новых свойств/методов из-за забытой запятой)
};

const person = {
    name: "John", // свойство (переменная в контексте объекта)
    age: 30,
    greet: function () { // метод (функция в контексте объекта)
        console.log("Hello, my name is " + this.name);
    }
};
console.log("#0");
person.greet();

// Используем стрелочную функцию для сохранения (изменения / добавления) контекста
person.greet = () => {
    console.log("Hello, benzo " + person.name);
};
person.name = "Den";
person.age = 28;
console.log("\n#1\n" + person.name);
person.greet();
// console.log(person["age"]);
console.log(person.age);

// Добавление новой логики через стрелочную функцию
person.newLogic = () => console.log("DZHITS");
person.newLogic = () => console.log("DZHITS_NDBT");
person.newLogic();

const car = new Object(); // создание объекта через конструктор
car.mark = "Toyota";
car.model = "Corolla";
car.year = 2020;

function Book(title, author) { // создание объекта через функцию-конструктор
    this.title = title;
    this.author = author;
}
const book = new Book("Книга", "Автор книги"); //создание объекта / экземпляра
console.log("\n#2\n" + book.title + " " + book.author);


console.log("\n#3");
// Использование цикла for...in для вывода свойств объекта person
for (const key in person) {
    console.log(key + ": " + person[key]);
    // console.log(key);
    console.log(person[key]);
}
const person1 = {
    firstName: "John",
    lastName: "Doe",
    age: 30
};

console.log("\n#4");
for (let key in person1) {
    console.log(key + ": " + person1[key]);
}

const product = {
    "id": 123456,
    "name": "Smartphone",
    "brand": "Samsung",
    "model": "Galaxy S20",
    "price": 799.99,
    "features": {
        "processor": "Exynos",
        "ram": "8 GB",
        "storage": "128 GB",
        "battery": "4000 mAh"
    }
};