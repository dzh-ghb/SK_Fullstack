const array = [];

for (let i = 0; i < 5; i++) {
    const el = Math.floor(Math.random() * 10);
    array.push(el);
}
console.log(array);


let sum = 0;
let strOut = "";

for (let i = 0; i < array.length; i++) {
    const element = array[i];
    strOut += `[${element}] `;
    sum += element;
}
console.log(strOut);
console.log(sum);


const arr0 = [1, 2, 3, 4, 5];
// arr0 = [5, 4, 3, 2, 1];
arr0[1] = 52;
arr0.push(20);
// arr0.unshift(20);
console.log(arr0);
// let item = arr0.pop();
let item = arr0.shift();
console.log(arr0);