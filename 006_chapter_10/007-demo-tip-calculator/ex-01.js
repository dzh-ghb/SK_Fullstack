let peopleCount = Number(prompt("Сколько человек было за столом?"));
let billAmount = parseFloat(prompt("Сумма общего счета"));
let tipPercent = Number.parseInt(prompt("Сумма чаевых (в % от общего счета)"));

let amountWithTip = billAmount + billAmount * (tipPercent / 100);
let amountToPayPerPerson = Math.ceil(amountWithTip / peopleCount);

alert(`Сумма общего счета на ${peopleCount} чел.: ${billAmount} у.е.`
    + '\n' + `На чай: ${tipPercent}% от суммы счета`
    + '\n' + `К оплате с каждого: ${amountToPayPerPerson} у.е.`)

// console.log(`Сумма общего счета на ${peopleCount} чел.: ${totalBill} у.е.`
//     + '\n' + `На чай: ${tipPercent}% от суммы счета`
//     + '\n' + `К оплате с каждого: ${amountToPayPerPerson} у.е.`)

// TODO: защита от дурака


// let billAmount = Number.parseFloat(prompt("Сумма счёта"));
// let tipPercentage = parseFloat(prompt("Процент чаевых"));
// let numberOfPeople = Number.parseInt(prompt("Сколько человек участвовало в обеде"));

// let tipAmount = 1000 * tipPercentage / 100;
// let totalAmount = billAmount + tipAmount;
// let perPersonAmount = totalAmount / numberOfPeople;

// alert("Общий счёт: " + totalAmount);
// alert("Процент чаевых: " + String(tipPercentage) + "%");
// alert(`С каждого: ${perPersonAmount}`);