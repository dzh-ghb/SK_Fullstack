const fs = require('fs');

const path = require('path');
const filePath1 = path.join(__dirname, 'data.json');

// Объект
const product = {
    id: 123456,
    name: "Smartphone",
    brand: "Samsung",
    model: "Galaxy S20",
    price: 799.99,
    features: {
        processor: "Exynos",
        ram: "8 GB",
        storage: "128 GB",
        battery: "4000 mAh"
    }
};

// Преобразование объекта в формат JSON
let jsonString = JSON.stringify(product);

// Асинхронная запись в файл
fs.writeFile(filePath1, jsonString, 'utf8', (err) => { // запись JSON в файл data.json
    if (err) {
        console.error("Ошибка при записи файла: ", err);
        return;
    }
    console.log("Файл был успешно записан.");
});

// Асинхронное чтение из файла
fs.readFile(filePath1, 'utf8', (err, data) => {
    if (err) {
        console.error("Ошибка при чтении файла: ", err);
        return;
    }
    const phone = JSON.parse(data); // парсинг объекта из JSON-файла в объект JS
    console.log("Прочитанный продукт:", phone);
    console.log(phone.features.ram);
});
