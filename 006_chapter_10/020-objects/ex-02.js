const person = {
    name: "John",
    age: 30,
    greet: function () {
        console.log("Hello, my name is " + this.name);
    }
};

person.name = "Jane"
person.greet();

person.greet = () => {
    console.log("BEEEN " + person.name);
}
person.newLogic = () => console.log("newLogic");
person.newLogic();

console.log(person.age);
console.log(person["age"]);

for (const key in person) { // обычное используется для доступа ТОЛЬКО к свойствам
    // console.log(key);
    const item = person[key];
    if (typeof item === "function") { // проверка, что обращаемся к функции
        const func = item.bind(person);
        func();
    }
    else { // обращение к свойству
        console.log(item);
    }
    // console.log(person[key]); // для функций работает по-другому
}