// my-math.js
// именованный экспорт константы, функции, класса
export const PI = 3.14;

export function add(x, y) {
    return x + y;
}

export class Rectangle {
    constructor(height, width) {
        this.height = height;
        this.width = width;
    }
}
