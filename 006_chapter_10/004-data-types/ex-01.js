// 1. Число (Number)
let num = 10;
console.log(` >> num`);
console.log(num); // 10
console.log(typeof num); // number

console.log('\n' + ` >> floatNum`);
let floatNum = 3.14;
console.log(floatNum); // 3.14
console.log(typeof floatNum); // number

// 2. Строка (String)
let str = "Привет, мир!"; // " ", ' ', ` `
console.log('\n' + str); // Привет, мир!
console.log(typeof str); // string

// 3. Логический (Boolean)
let isTrue = 52 > 28; //можно выражения 12 > 3
console.log('\n' + isTrue); // true
console.log(typeof isTrue); // boolean

let isFalse = false;
console.log('\n' + isFalse); // false
console.log(typeof isFalse); // boolean

// 4. Null
let nullValue = null;
console.log('\n' + nullValue); // null
console.log(typeof nullValue); // object

// 5. Undefined
let undefinedValue;
console.log('\n' + undefinedValue); // undefined
console.log(typeof undefinedValue); // undefined

// 6. Массив (Array)
let arr = [1, 2, 3, 4, 5];
console.log('\n' + arr); // [1, 2, 3, 4, 5]
console.log(typeof arr); // object

// 7. Объект (Object)
let obj = {
    name: "Jane",
    age: 30,
    city: "Smolensk"
};
console.log('\n' + obj); // {name: "Jane", age: 30, city: "Smolensk"}
console.log(typeof obj); // object
console.log(obj.name); // object

// 8. Функция (Function) - стандартное объявление
function greet(name) {
    console.log('\n' + "Привет, " + name + "!");
}
greet("Ben - функции");
// стрелочное объявление
const greet2 = (name) => console.log("Привет, " + name + "!");
greet2("Benz - стрелочный");

console.log('\n' + greet); // [Function: greet]
console.log(typeof greet); // function

// 9. Символ (Symbol)
let sym = Symbol("описание");
console.log('\n');
console.log(sym); // Symbol(описание)
console.log(typeof sym); // symbol

// 10. BigInt
console.log('\n');
const bigNumber = 1234567890123456789012345678901234567890n;
const bigNumber1 = 1234567890123456789012345678901234567890;
console.log(bigNumber); // 1234567890123456789012345678901234567890n
console.log(bigNumber1); // 1234567890123456789012345678901234567890
console.log(typeof bigNumber); // bigint
console.log(typeof bigNumber1); // number