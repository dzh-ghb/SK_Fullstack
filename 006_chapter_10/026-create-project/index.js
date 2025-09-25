// Импорт модуля
const readlineSync = require('readline-sync');

// Wait for user's response.
let userName = readlineSync.question('May I have your name?\nInput name: ');
console.log('Hi ' + userName + '!');

// let userName = readlineSync.question('May I have your name?\nInput name: ', {
//     hideEchoBack: true // блюр вводимого текста символами "*"
// });
// console.log('Hi ' + userName + '!');