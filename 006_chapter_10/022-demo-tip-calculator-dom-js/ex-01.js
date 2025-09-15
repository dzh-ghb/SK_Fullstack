// функции расчета
const tipAmountFunc = (billAmount, tipPercent) => billAmount * (tipPercent / 100);
const totalAmountFunc = (billAmount, tipAmount) => billAmount + tipAmount;
const amountPerPersonFunc = (totalAmount, peopleCount) => totalAmount / peopleCount;

// получение доступа к элементам:
// поля ввода
const billAmountInput = document.getElementById("billAmountInput");
const tipPercentInput = document.getElementById("tipPercentInput");
const peopleCountInput = document.getElementById("peopleCountInput");
// кнопки
const calcButton = document.getElementById("calcButton");
const clearButton = document.getElementById("clearButton");
// поля вывода
const tipAmountContainer = document.getElementById("tipAmountContainer");
const totalAmountContainer = document.getElementById("totalAmountContainer");
const amountPerPersonContainer = document.getElementById("amountPerPersonContainer");

// обработка нажатий кнопок
calcButton.addEventListener("click", function () {
    const billAmount = parseFloat(billAmountInput.value);
    const tipPercent = parseFloat(tipPercentInput.value);
    const peopleCount = parseFloat(peopleCountInput.value);

    if (isNaN(peopleCount)
        || isNaN(billAmount)
        || isNaN(tipPercent) //если не число || не м.б. преобразовано в число (глобальная функция)
        || peopleCount <= 0
        || billAmount <= 0
        || tipPercent < 0) { //на чай можно не оставлять - 0%
        alert("Ошибка ввода данных");
        return;
    }

    const tipAmount = tipAmountFunc(billAmount, tipPercent);
    const totalAmount = totalAmountFunc(billAmount, tipAmount);
    const amountPerPerson = amountPerPersonFunc(totalAmount, peopleCount);
    tipAmountContainer.textContent = tipAmount.toFixed(2);
    totalAmountContainer.textContent = totalAmount.toFixed(2);
    amountPerPersonContainer.textContent = amountPerPerson.toFixed(2);
});

clearButton.addEventListener("click", function () {
    billAmountInput.value = "";
    tipPercentInput.value = "";
    peopleCountInput.value = "";
    tipAmountContainer.textContent = "";
    totalAmountContainer.textContent = "";
    amountPerPersonContainer.textContent = "";
});