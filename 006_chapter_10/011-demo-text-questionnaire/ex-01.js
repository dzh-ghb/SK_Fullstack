let score = 0;
let question = "Было два козла - сколько? На размышление дается 30 секунд [30, 1337, 52]";
let answer = prompt(question);

if (answer === "30") {
    score += 10;
    alert("Точно так, но когда?🤷‍♂️");
} else {
    alert("Покумекай 🫠");
}

question = "'Деп' или не `деп`? [да, нет]";
answer = prompt(question);
if (answer === "нет" || answer === "no") {
    score += 10;
    alert("Верное решение 👍");
} else if (answer === "да" || answer === "yes") {
    alert("ты не Джонни Деп 😎");
} else {
    alert("Шта? 🤠");
}

alert(`Итоговый счет: ${score}`);



// let score = 0;
// let question = "Что означает слово 'cat'? [кошка, собака]";
// let answer = prompt(question);
// if (answer === "кошка") {
//     score = score + 10;
//     alert("Всё верно! 😎");
// }
// else {
//     alert("Нужно подумать ещё 🫣");
// }
// question = "Что означает слово 'dog'? [кошка, собака]";
// answer = prompt(question);
// if (answer === "собака") {
//     score = score + 10;
//     alert("Всё верно! 😎");
// }
// else {
//     alert("Нужно подумать ещё 🫣");
// }

// alert("Счёт: " + score);