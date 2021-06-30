class Rectangle {
    constructor(width, height, color) {
        this.width = Number(width);
        this.height = Number(height);
        this.color = color;
    }

    get color() {
        return this._color.charAt(0).toUpperCase() + this._color.slice(1);
    }

    set color(value) {
        this._color = value;
    }

    calcArea() {
        return this.width * this.height;
    }
}

let rect = new Rectangle(4, 5, 'red');
console.log(rect.width);
console.log(rect.height);
console.log(rect.color);
console.log(rect.calcArea());