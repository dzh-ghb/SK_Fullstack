const select = (items, employee) => {
    const temp = [];
    for (const item of items) {
        temp.push(employee(item));
    }
    return temp;
}

const where = (items, logic) => {
    const temp = [];
    for (const item of items) {
        if (logic(item)) {
            temp.push(item);
        }
    }
    return temp;
}

let numbers = [1, 2, 3, 4, 5];

const alex = (value) => {
    return value * 10;
}
const res3 = select(numbers, alex);
console.log(res3);

const mark = (value) => {
    return value * 2;
}
let res = select(numbers, mark); // преобразует элементы numbers по правилам стрелочной функции mark -
// путем умножения каждого элемента на 2
console.log(res);

const logic = (el) => {
    return el % 2 === 0;
}
const res1 = where(numbers, logic);
console.log(res1);

res = where(numbers, e => e % 3 === 0);
console.log(res);

