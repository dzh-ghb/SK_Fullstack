function changeTextBtnClick() {
    // textContainer.textContent = "New text";
    const tBVal = tB.value;
    textContainer.textContent = tBVal;
    // форматированный текст (интерпретируется как html)
    textContainer.innerHTML = `<b><i>${tBVal}</i></b>`;
}
function clearTextBtnClick() {
    tB.value = ``;
    textContainer.innerHTML = `Начальный текст`;
}

const tB = document.getElementById("textBox");
const textContainer = document.getElementById("textContainer");
const changeTextBtn = document.getElementById("changeTextBtn");
const clearTextBtn = document.getElementById("clearTextBtn");

changeTextBtn.addEventListener("click", changeTextBtnClick);
clearTextBtn.addEventListener("click", clearTextBtnClick);

// function btnClick() {
//     // Изменяем текст в контейнере
//     textContainer.innerHTML = "<b><u>Новый текст</u></b>";
// }

// // Получаем ссылку на кнопку и контейнер текста
// const changeTextBtn = document.getElementById("changeTextBtn");
// const textContainer = document.getElementById("textContainer");

// // Добавляем обработчик события клика на кнопку
// changeTextBtn.addEventListener("click", btnClick);