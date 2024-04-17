import { ValueGenerator } from "./ValueGenerator";  
export class LineArray <T> {
    private readonly _type: string;
    
    array: T[] = [];
    constructor(type : string, count: number, userFill = false) {
        this._type = type; 
        
        if (userFill) {
            this.UserFill();
        } else {
            this.RandomFill();
        }

    }

    private UserFill() {
        console.log("Введите значения массива: ");
        for (let i = 0; i < this.array.length; i++) {
            console.log(`Введите значение эл-та массива с индексом ${i}`);
            this.array[i] = new ValueGenerator<T>(this._type).generate();
        }
    }    
    private RandomFill() {
        for (let i = 0; i < this.array.length; i++) {
            this.array[i] = new ValueGenerator<T>(this._type).generate();
        }
    }

    public Push(value: T):void {
        this.array.push(value);
    }

    public Pop(index : number):void {
        this.array.splice(index, 1);
    }

    public Sort():void {
        this.array.sort();
    }

    public toString(): string {
        return this.array.toString();
    }
    
    public Print() {
        console.log(this.toString());
    }

    public Length (): number {
        return this.array.length;
    }

    public Count (condition : (value: T) => boolean): number {
        return this.array.filter(condition).length;
    }

    //Проверка выполнения переданного условия хотя бы одного элемента массива.

    public CheckOne (condition : boolean) : boolean {
        for (let i = 0; i < this.array.length; i++) {
            if (condition) {
                return true;
            }
        }
        return false;
    }

    //Проверка выполнения переданного условия для всех элементов массива.
    public CheckAll (condition : boolean) : boolean {
        for (let i = 0; i < this.array.length; i++) {
            if (!condition) {
                return false;
            }
        }
        return true;
    }

    //Проверка наличия элемента в массиве.
    public CheckElement (value : T): boolean {
        return this.array.includes(value);
    }

    //Применение переданного действия ко всем элементам массива.
    public Map (condition : (value: T) => T): T[] {
        return this.array.map(condition);
    }

    //Получение элементов массива, удовлетворяющих переданному условию.
    public IfCondition (condition : (value: T) => boolean): T[] {
        return this.array.filter(condition);
    }

    //Переворот массива.
    public Reverse (): T[] {
        return this.array.reverse();
    }

    //Получение минимального элемента массива.
    public Min (): T {
        let min = this.array[0];
        for (let i = 0; i < this.array.length; i++) {
            if (this.array[i] < min) {
                min = this.array[i];
            }
        }
        return min;
    }

     //Получение минимального элемента массива.
     public Max (): T {
        let max = this.array[0];
        for (let i = 0; i < this.array.length; i++) {
            if (this.array[i] > max) {
                max = this.array[i];
            }
        }
        return max;
     }

    
    //Получить заданное количество элементов массива с указанного индекса.

    public Take (index : number, count : number): T[] {
        return this.array.slice(index, count);
    }

    //Итерирование по экземпляру массива с помощью цикла foreach

    public ForEach (callback: (value: T, index: number) => void): void {
        this.array.forEach (callback);
    }
}      

