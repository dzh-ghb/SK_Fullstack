const textBox = document.getElementById("textBox");
const addListBtn = document.getElementById("addListBtn");
const clearListBtn = document.getElementById("clearListBtn");
const listContainer = document.getElementById("listContainer");

textBox.value = "Элемент списка";

addListBtn.addEventListener("click", function () {
    // создание нового элемента списка
    const listItem = document.createElement("li");
    listItem.textContent = textBox.value;

    // добавление элемента в контейнер списка
    listContainer.appendChild(listItem);
});

clearListBtn.addEventListener("click", function () {
    const listItems = document.querySelectorAll("li");
    listItems.forEach(listItem => {
        listItem.parentNode.removeChild(listItem);
    });
});

// // Получаем ссылку на кнопку и контейнер списка
// const addListBtn = document.getElementById("addListBtn");
// const listContainer = document.getElementById("listContainer");

// // Добавляем обработчик события клика на кнопку
// addListBtn.addEventListener("click", function () {
//     for (let i = 0; i < 5; i++) {
//         // Создаем новый элемент списка
//         const listItem = document.createElement("li");
//         listItem.textContent = `${i + 1}-й элемент списка`;

//         // Добавляем элемент в контейнер списка
//         listContainer.appendChild(listItem);
//     }
// });