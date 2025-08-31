// 1. Преобразование к строке
console.log("__1__");
let numToStr = 10;
let toStr = String(numToStr);
console.log(toStr); // "10"
console.log(typeof numToStr); // number
console.log(typeof toStr); // string


// 2. Преобразование к числу
console.log("\n__2__");
let strToNum = "10";
console.log(Number(strToNum)); // 10
console.log(Number(26 * 2 == 52)); // 0

// 3. Преобразование к логическому типу
console.log("\n__3__");
let strToBool = "DZHITS";
console.log(Boolean(strToBool)); // true

// 4. Неявное преобразование
console.log("\n__4__");
let implicitConversion = 10 + "20";
console.log(implicitConversion); // "1020"

// 5. Неявное преобразование при сравнении
console.log("\n__5__");
let num = 10;
let str = "10";
console.log(num == str); // true - неявное преобразование к одному типу
console.log(num === str); // false - сравнение с учетом типа


// Примеры ошибок и путаницы при преобразовании типов

// Непонимание различий между типами данных
console.log("\n__6__");
// let confusionExample = num + Number(str);
let confusionExample = num + str; //неявное преобразования числа к строке
console.log(confusionExample); // "1020"

// Явное преобразование типов
let implicitExample = num.toString() + str;
console.log(implicitExample); // "1020"

// Преобразование строки в число
console.log("\n__7__");
let intFromString = Number.parseInt("10");
console.log(`Преобразование строки "10" в целое число: ${intFromString}`);

let floatFromString = Number.parseFloat("10.5");
console.log(`Преобразование строки "10.5" в число с плавающей точкой: ${floatFromString}`);

// Проверка на NaN и целое число
console.log("\n__8__");
console.log(`Является ли "abc" NaN: ${Number.isNaN(Number("abc"))}`);
console.log(`Является ли "abc" NaN: ${Number.isNaN("abc")}`); // true только для значения NaN
console.log(`Является ли "abc" NaN: ${isNaN("abc")}`); // true - значение можно преобразовать в число

console.log(`Является ли 5 целым числом: ${Number.isInteger(5)}`);
console.log(`Является ли 5.5 целым числом: ${Number.isInteger(5.5)}`); // true - только целые числа
// false - не число, не целое число, NaN, Infinity, -Infinity

// Проверка на конечное число
console.log("\n__9__");
console.log(`Является ли 5.5 конечным числом: ${Number.isFinite(5.5)}`); // true - только конечные числа
// false - NaN, Infinity, -Infinity и не числа, в отличие от глобальной isFinite не приводит типы

// Деление на ноль
console.log("\n__10__");
console.log(`Результат деления -10 на 0: ${-10 / 0}`); // Добавлено пояснение

console.log("\n__11__");
console.log(isNaN("42"));
console.log(Number.isNaN("42"));
console.log(Number.isNaN("NaN"));
console.log(Number.isNaN(NaN));
console.log(Number.isNaN(0 / 0));
console.log(isNaN(0 / 0));
console.log(Number.isNaN(undefined));

console.log("\n__12__");
console.log(parseInt("10.5"));      // 10
console.log(parseInt("10", 2));     // 2 (двоичная система)
console.log(Number.parseInt("0xFF", 16));  // 255 (шестнадцатеричная система)

console.log(parseFloat("10.5"));    // 10.5
console.log(parseFloat("10"));      // 10
console.log(Number.parseFloat("1e3"));  // 1000

console.log(Number.parseInt("123str"));
console.log(Number.parseInt("e12312"));

console.log(Number.parseFloat("1e5"));
console.log(Number.parseFloat("e12312"));