// Примеры использования объекта Math
console.log(11 / 4);
console.log(Math.ceil(11 / 4));
console.log(Math.round(11 / 4));
console.log(Math.floor(11 / 4));
console.log(11 % 4);

// Константы
console.log("\n");
console.log(`Значение числа Пи (π): ${Math.PI}`);
// основание натурального логарифма
console.log(`Значение числа e: ${Math.E}`);

// Основные функции Math
console.log("\n");
console.log(`Абсолютное значение -10: ${Math.abs(-10)}`);
console.log(`Квадратный корень из 16: ${Math.sqrt(16)}`);
console.log(`2 в степени 3: ${Math.pow(2, 3)}`);
console.log(`2 в степени 3: ${2 ** 3}`); //альтернативный вариант

console.log(`Округление вверх 4.3: ${Math.ceil(4.3)}`);
console.log(`Округление вниз 4.7: ${Math.floor(4.7)}`);
console.log(`Математическое округление 4.5: ${Math.round(4.5)}`);
console.log(`Математическое округление 4.4: ${Math.round(4.4)}`);

// ПсеУдорандом
console.log("\n");
console.log(`Псевдослучайное число от 0 до 1 (не включая): ${Math.random()}`);
console.log(`Псевдослучайное число от 0 до 10 (не включая): ${Math.round(Math.random() * 10)}`);
console.log(`Псевдослучайное число от -5 до 5 (не включая): ${Math.round(Math.random() * 10) - 5}`);
// [0, 1) - полуинтервал
// (1, 3) - интервал; [1, 7] - отрезок; (1, 5] -полуинтервал; [2, 66) - полуинтервал

// Тригонометрические функции
console.log("\n");
console.log(`Синус угла π радиан: ${Math.sin(Math.PI)}`);
console.log(`Косинус угла π радиан: ${Math.cos(Math.PI)}`);
console.log(`Тангенс угла π/4 радиан: ${Math.tan(Math.PI / 4)}`);

// Логарифмические функции
console.log("\n");
console.log(`Натуральный логарифм числа e: ${Math.log(Math.E)}`);
console.log(`Десятичный логарифм числа 100: ${Math.log10(100)}`);

// Прочие функции
console.log("\n");
console.log(`Минимальное число из (1, 2, 3): ${Math.min(1, 2, 3)}`);
console.log(`Максимальное число из (1, 2, 3): ${Math.max(1, 2, 3)}`);