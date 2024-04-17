"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.LineArray = void 0;
var ValueGenerator_1 = require("./ValueGenerator");
var LineArray = /** @class */ (function () {
    function LineArray(type, count, userFill) {
        if (userFill === void 0) { userFill = false; }
        this.array = [];
        this._type = type;
        if (userFill) {
            this.UserFill();
        }
        else {
            this.RandomFill();
        }
    }
    LineArray.prototype.UserFill = function () {
        console.log("Введите значения массива: ");
        for (var i = 0; i < this.array.length; i++) {
            console.log("\u0412\u0432\u0435\u0434\u0438\u0442\u0435 \u0437\u043D\u0430\u0447\u0435\u043D\u0438\u0435 \u044D\u043B-\u0442\u0430 \u043C\u0430\u0441\u0441\u0438\u0432\u0430 \u0441 \u0438\u043D\u0434\u0435\u043A\u0441\u043E\u043C ".concat(i));
            this.array[i] = new ValueGenerator_1.ValueGenerator(this._type).generate();
        }
    };
    LineArray.prototype.RandomFill = function () {
        for (var i = 0; i < this.array.length; i++) {
            this.array[i] = new ValueGenerator_1.ValueGenerator(this._type).generate();
        }
    };
    LineArray.prototype.Push = function (value) {
        this.array.push(value);
    };
    LineArray.prototype.Pop = function (index) {
        this.array.splice(index, 1);
    };
    LineArray.prototype.Sort = function () {
        this.array.sort();
    };
    LineArray.prototype.toString = function () {
        return this.array.toString();
    };
    LineArray.prototype.Print = function () {
        console.log(this.toString());
    };
    LineArray.prototype.Length = function () {
        return this.array.length;
    };
    LineArray.prototype.Count = function (condition) {
        return this.array.filter(condition).length;
    };
    //Проверка выполнения переданного условия хотя бы одного элемента массива.
    LineArray.prototype.CheckOne = function (condition) {
        for (var i = 0; i < this.array.length; i++) {
            if (condition) {
                return true;
            }
        }
        return false;
    };
    //Проверка выполнения переданного условия для всех элементов массива.
    LineArray.prototype.CheckAll = function (condition) {
        for (var i = 0; i < this.array.length; i++) {
            if (!condition) {
                return false;
            }
        }
        return true;
    };
    //Проверка наличия элемента в массиве.
    LineArray.prototype.CheckElement = function (value) {
        return this.array.includes(value);
    };
    //Применение переданного действия ко всем элементам массива.
    LineArray.prototype.Map = function (condition) {
        return this.array.map(condition);
    };
    //Получение элементов массива, удовлетворяющих переданному условию.
    LineArray.prototype.IfCondition = function (condition) {
        return this.array.filter(condition);
    };
    //Переворот массива.
    LineArray.prototype.Reverse = function () {
        return this.array.reverse();
    };
    //Получение минимального элемента массива.
    LineArray.prototype.Min = function () {
        var min = this.array[0];
        for (var i = 0; i < this.array.length; i++) {
            if (this.array[i] < min) {
                min = this.array[i];
            }
        }
        return min;
    };
    //Получение минимального элемента массива.
    LineArray.prototype.Max = function () {
        var max = this.array[0];
        for (var i = 0; i < this.array.length; i++) {
            if (this.array[i] > max) {
                max = this.array[i];
            }
        }
        return max;
    };
    //Получить заданное количество элементов массива с указанного индекса.
    LineArray.prototype.Take = function (index, count) {
        return this.array.slice(index, count);
    };
    //Итерирование по экземпляру массива с помощью цикла foreach
    LineArray.prototype.ForEach = function (callback) {
        this.array.forEach(callback);
    };
    return LineArray;
}());
exports.LineArray = LineArray;
