// Создание массива с использованием литералов массива [] - нумерация позиций элементов с нуля
console.log("№0");
let arr1 = [1, 2, 3, 4, 5]; //через let НЕ РЕКОМЕНДУЕТСЯ
console.log(arr1);
arr1 = [1, 25]; //но при объявлении через let работает
arr1[0] = 52;
console.log(arr1);

// Создание массива с использованием конструктора new Array()
const arr2 = new Array("apple", "banana", "orange");

console.log("\n№1");
// Доступ к элементам массива по индексу
const arr = ["apple", "banana", "orange"];
console.log(arr[0]); // Выведет "apple"

console.log("\n№2");
// Добавление и удаление элементов массива
console.log(arr);
arr.push("grape"); // Добавляет элемент "grape" в конец массива
console.log(arr); // Выведет ["apple", "banana", "orange", "grape"]

console.log("\n№3");
console.log(arr);
let drop = arr.pop(); // Удаляет и возвращает последний элемент массива
// arr.push("123");
console.log(drop);
console.log(arr); // Выведет ["apple", "banana", "orange"]

console.log("\n№4");
console.log(arr);
arr.unshift("kiwi"); // Добавляет элемент "kiwi" в начало массива
console.log(arr); // Выведет ["kiwi", "apple", "banana", "orange"]

console.log("\n№5");
console.log(arr);
let shift = arr.shift(); // Удаляет и возвращает первый элемент массива
console.log(shift);
console.log(arr); // Выведет ["apple", "banana", "orange"]

console.log("\n№6");
// Перебор элементов массива с использованием цикла for
for (let i = 0; i < arr.length; i++) {
    console.log(arr[i]);
}

console.log("\n№7");
// Перебор элементов массива с использованием цикла for...of
for (const fruit of arr) {
    console.log(fruit);
}

console.log("\n№8");
// Использование цикла for...of для вывода значений массива array
const array = [10, 20, 30, 40, 50];
for (const value of array) {
    console.log(value); // Выведет значения массива
}

console.log("\n№9");
// Перебор элементов массива с использованием цикла for...in (НЕ РЕКОМЕНДУЕТСЯ для массивов)
for (const index in arr) {
    console.log(arr[index]);
}

console.log("\n№10");
console.log(arr);
// Использование метода splice для удаления и вставки элементов
arr.splice(1, 1, "grape", "watermelon"); // Удаляет один элемент с индексом 1 и вставляет "grape" и "watermelon" на его место
console.log(arr); // Выведет ["apple", "grape", "watermelon", "orange"]

console.log("\n№11");
console.log(arr);
// Использование метода slice для создания подмассива
const subArray = arr.slice(1, 3); // Создает подмассив, начиная с индекса 1 (включительно) и заканчивая индексом 3 (не включительно)
console.log(subArray); // Выведет ["grape", "watermelon"]

console.log("\n№12");
console.log(arr);
// Использование метода concat для объединения массивов
const newArr = arr.concat(["pineapple", "melon"]); // Создает новый массив, объединяя текущий массив и переданный массив
console.log(newArr); // Выведет ["apple", "grape", "watermelon", "orange", "pineapple", "melon"]

console.log("\n№13");
console.log(arr);
// Использование метода reverse для изменения порядка элементов
arr.reverse(); // Меняет порядок элементов в массиве на обратный
console.log(arr); // Выведет ["orange", "watermelon", "grape", "apple"]

console.log("\n№14");
console.log(arr);
// Использование метода sort для сортировки элементов
arr.sort(); // Сортирует элементы массива в алфавитном порядке
console.log(arr); // Выведет ["apple", "grape", "orange", "watermelon"]


/**

// Обход массива с использованием метода forEach
arr.forEach(function (element) {
    console.log(element);
});

 */