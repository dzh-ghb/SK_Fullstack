const firstName = `DZH`;
const lastName = `ITS`;
const age = 28;

// для строк можно использоваться разные кавычки
console.log(firstName + ` ` + lastName + `, ` + age + ` y.o.`);
// console.log(firstName + ' ' + lastName + ', ' + age + ' y.o.');
// console.log(firstName + " " + lastName + ", " + age + " y.o.");


// ` (обратные одинарные кавычки) дают возможность комбинации вывода не через конкатенацию (+)
// console.log(firstName);
console.log(`${firstName} ${lastName}, ${age} y.o.`);
// console.log('${firstName} ${lastName}, ${age} y.o.');

let theme = "Ben"
console.log("\n" + theme);
theme = "Benzo";
console.log(`${theme}`);


let its = "ndbt";
console.log(`${its} - ye, ye, ye, ndbt`);