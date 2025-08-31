// let a = 111, b = 21, c = 31;
// if (a > b && a > c) {
//     console.log(`max = ${a}`);
// } else if (b > c) {
//     console.log(`max = ${b}`);
// } else {
//     console.log(`max = ${c}`);
// }

let amount = Number(prompt("Введите сумму покупки:"));
let bonus = amount >= 1000 ? Math.floor(amount / 10) : 0;
// if (amount >= 1000) {
//     bonus = parseInt(amount * 0.1);
// } else {
//     bonus = 0;
// }
console.log(bonus);
alert(bonus);