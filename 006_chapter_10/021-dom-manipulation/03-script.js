const startAnimation = (color, width, height, delay) => {
    // анимирование изменения цвета фона
    box.style.transition = "background-color 1s ease-in-out";
    box.style.backgroundColor = `${color}`;

    // анимирование изменения размера
    setTimeout(() => {
        box.style.transition = "width 1s ease-in-out, height 1s ease-in-out";
        box.style.width = `${width}px`;
        box.style.height = `${height}px`;
    }, delay);
}

const box = document.getElementById("box");
const animateBtn = document.getElementById("animateBtn");
const defaultStateBtn = document.getElementById("defaultStateBtn");

animateBtn.addEventListener("click", function () {
    startAnimation("green", 200, 200, 1000);
});

defaultStateBtn.addEventListener("click", function () {
    startAnimation("yellow", 100, 100, 1000);
});

// // Получаем ссылку на элемент и кнопку
// const box = document.getElementById("box");
// const animateBtn = document.getElementById("animateBtn");

// // Добавляем обработчик события клика на кнопку
// animateBtn.addEventListener("click", function () {
//     // Анимируем изменение цвета фона
//     box.style.transition = "background-color 1s ease-in-out";
//     box.style.backgroundColor = "blue";

//     // Анимируем изменение размера
//     setTimeout(() => {
//         box.style.transition = "width 1s ease-in-out, height 1s ease-in-out";
//         box.style.width = "200px";
//         box.style.height = "200px";
//     }, 1000);
// });