let peopleCount = Number(prompt("Сколько человек было за столом?"));
let billAmount = parseFloat(prompt("Сумма общего счета"));
let tipPercent = Number.parseInt(prompt("Сумма чаевых (в % от общего счета)"));

if (isNaN(peopleCount)
    || isNaN(billAmount)
    || isNaN(tipPercent) //если не число || не м.б. преобразовано в число (глобальная функция)
    || peopleCount <= 0
    || billAmount <= 0
    || tipPercent < 0) { //на чай можно не оставлять - 0%
    alert("Ошибка ввода данных");
} else {
    let amountWithTip = billAmount + billAmount * (tipPercent / 100);
    let amountToPayPerPerson = Math.ceil(amountWithTip / peopleCount);

    alert(`Сумма общего счета на ${peopleCount} чел.: ${billAmount} у.е.`
        + '\n' + `На чай: ${tipPercent}% от суммы счета`
        + '\n' + `К оплате с каждого: ${amountToPayPerPerson} у.е.`)
}


// let billAmount = Number.parseFloat(prompt("Сумма счёта"));
// let tipPercentage = parseFloat(prompt("Процент чаевых"));
// let numberOfPeople = Number.parseInt(prompt("Сколько человек участвовало в обеде"));

// if (isNaN(billAmount)
//     || isNaN(tipPercentage)
//     || isNaN(numberOfPeople)
//     || billAmount <= 0
//     || tipPercentage < 0
//     || numberOfPeople <= 0
// ) {
//     alert("Ошибка ввода данных");
// } else {
//     let tipAmount = 1000 * tipPercentage / 100;
//     let totalAmount = billAmount + tipAmount;
//     let perPersonAmount = totalAmount / numberOfPeople;

//     alert("Общий счёт: " + totalAmount);
//     alert("Процент чаевых: " + String(tipPercentage) + "%");
//     alert(`С каждого: ${perPersonAmount}`);
// }