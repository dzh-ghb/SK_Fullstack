// index.js
// импорт { конкретных сущностей } из отдельных модулей
import * as myMath from './my-math.js';
import { PI, add, Rectangle } from './my-math.js';

import subtract from './def-subtract.js' //импорт по умолчанию - задаем название для импорта "экспорта по умолчанию"

import * as util from './util.js'; // импорт всего и задание названия объекта для обращения
import { multiply as mul } from './util.js'; // импорт с переименовыванием


console.log("* as myMath");
console.log(myMath.PI);
console.log(myMath.add(1, 2));
console.log(new myMath.Rectangle(3, 2).height);

console.log("\n{ PI, add, Rectangle }");
console.log(add(2, 3)); // 5
console.log(PI); // 3.14
console.log(new Rectangle(5, 8).width); // 8

console.log("\nsubtract");
console.log(subtract(5, 3)); // 2

console.log("\n* as util");
console.log(util.multiply(2, 3)); // 6

console.log("\n{ multiply as mul }");
console.log(mul(3, 4)); // 12
