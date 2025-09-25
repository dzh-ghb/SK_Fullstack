const numbers = [];

for (let i = 0; i < 5; i++) {
    numbers.push(parseInt(Math.random() * 20 - 10));
}
console.log(numbers);
console.log("\n");

function getItems(arr, func) { // getItems - функция высшего порядка, func - функция, например, предикат или колбек-функция
    const res = [];
    for (let i = 0; i < arr.length; i++) {
        const item = arr[i];
        if (func(item)) {
            res.push(item);
        }
    }
    return res;
}

const func = item => item % 2 === 0;
// console.log(getItems(numbers, func)); // основная логика скрыта (инкапсулирована) в getItems()
// console.log(getItems(numbers, item => item % 5 === 0)); // передача условий выборки через лямбда-функцию в аргумент
// console.log(getItems(numbers, item => item < 0));
// console.log(getItems(numbers, item => item > 5));


console.log(numbers.filter(e => e < 0));
console.log(numbers.map(e => e ** 3));

