export class ValueGenerator<T> {

    private readonly _type: string;

    constructor(type: string) {
        this._type = type;
    }
    public generate(): T {
        switch (this._type) {
            case 'number':
                return ValueGenerator.randomNumber(0, 100) as T;
            case 'boolean':
                return ValueGenerator.randomBool() as T;
            case 'string':
                return ValueGenerator.randomString(10) as T;
            default:
                return ValueGenerator.randomNumber(0, 100) as T;
        }
    }
    public static randomNumber(min: number, max: number): number {
        return Math.random() * (max - min) + min;
    }

    public static randomBool(): boolean {
        return Math.random() >= 0.5;
    }

    public static randomString(length: number): string {
        let result = '';
        const characters = 'ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789';
        const charactersLength = characters.length;
        for (let i = 0; i < length; i++) {
            result += characters.charAt(Math.floor(Math.random() * charactersLength));
        }
        return result;
    }
}