// Оператор равенства
console.log(5 == 5);   // true
console.log(5 == "5"); // true
console.log(5 == 10);  // false

// Оператор строгого равенства
console.log("\n");
console.log(5 === 5);   // true
console.log(5 === "5"); // false

// Оператор неравенства
console.log("\n");
console.log(5 != 10);  // true
console.log(5 != "5"); // false

// Оператор строгого неравенства
console.log("\n");
console.log(5 !== "5"); // true
console.log(5 !== 10);   // true
console.log(5 !== 5);    // false

// Операторы больше и меньше
console.log("\n");
console.log(5 > 3); // true
console.log(5 < 3); // false

// Операторы больше или равно и меньше или равно
console.log("\n");
console.log(5 >= 5); // true
console.log(5 <= 3); // false

// Логические операторы
console.log("\n");
console.log(true && true);   // true
console.log(true && false);  // false
console.log(true || false);  // true
console.log(false || false); // false
console.log(!true);           // false
console.log(!false);          // true

// Преобразование к логическому типу - пример: проверка переменных на логику
console.log("\n");
console.log(!!0);       // false
console.log(!!1);       // true
console.log(!!"");      // false
console.log(!!"hello"); // true
console.log(!!null);    // false
console.log(!!undefined); // false
console.log(!!NaN);     // false

console.log("\n");
// 
let data = "yep";
if (data/*!!data*/) { //проверка на наличие ввода данных (истинность)
    console.log("+");
}
if (!data) { //проверка на отсутствие ввода (ложность)
    console.log("-");
}