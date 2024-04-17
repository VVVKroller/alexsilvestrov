"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.ValueGenerator = void 0;
var ValueGenerator = /** @class */ (function () {
    function ValueGenerator(type) {
        this._type = type;
    }
    ValueGenerator.prototype.generate = function () {
        switch (this._type) {
            case 'number':
                return ValueGenerator.randomNumber(0, 100);
            case 'boolean':
                return ValueGenerator.randomBool();
            case 'string':
                return ValueGenerator.randomString(10);
            default:
                return ValueGenerator.randomNumber(0, 100);
        }
    };
    ValueGenerator.randomNumber = function (min, max) {
        return Math.random() * (max - min) + min;
    };
    ValueGenerator.randomBool = function () {
        return Math.random() >= 0.5;
    };
    ValueGenerator.randomString = function (length) {
        var result = '';
        var characters = 'ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789';
        var charactersLength = characters.length;
        for (var i = 0; i < length; i++) {
            result += characters.charAt(Math.floor(Math.random() * charactersLength));
        }
        return result;
    };
    return ValueGenerator;
}());
exports.ValueGenerator = ValueGenerator;
