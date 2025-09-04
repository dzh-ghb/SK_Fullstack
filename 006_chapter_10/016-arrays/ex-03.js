// генерация массива, заполненного случайными числами и распечатать его
const arr = []; //пустой массив
let sum = 0;
let strOut = "";

for (let i = 0; i < 10; i++) {
    // arr[i] = parseInt(Math.random() * 100);
    arr.push(parseInt(Math.random() * 100));
    sum += arr[i];
    strOut += `[${arr[i]}] `;
}

console.log(arr + "\n\nсумма элементов: " + sum + "\n\nстрока: " + strOut.trim());