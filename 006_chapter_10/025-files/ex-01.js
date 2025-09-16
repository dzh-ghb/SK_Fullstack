const fs = require('fs');

const path = require('path');
const filePath1 = path.join(__dirname, 'example.txt');
const filePath2 = path.join(__dirname, 'example2.txt');

// Данные для записи
const data = "Пример текста для записи в файл.";

// Асинхронная запись в файл
fs.writeFile(filePath1, data, 'utf8', (err) => { //имя файла записи (создается), данные для записи, кодировка, обработка ошибок
    if (err) { //обработчик ошибок лучше добавлять всегда
        console.error("Ошибка при записи файла: ", err); //err - объект ошибки
        return;
    }
    console.log("Файл был успешно записан.");
});

// Асинхронное чтение из файла
fs.readFile(filePath2, 'utf8', (err, data) => { //имя файла чтения, кодировка, ошибка, объект записи
    if (err) {
        console.error("Ошибка при чтении файла: ", err);
        return;
    }
    console.log("Содержимое файла: ", data);
});