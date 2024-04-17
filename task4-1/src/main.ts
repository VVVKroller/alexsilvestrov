import {LineArray} from "./Linearray";

const array1 = new LineArray<number>("int", 10, true);

array1.Push(2);
array1.Push(1);
array1.Push(4);
array1.Push(8);
array1.Push(5);
array1.Push(6);
array1.Push(10);
array1.Push(3);
array1.Push(7);
array1.Push(9);
array1.Pop(2);
array1.Sort()
console.log(array1.Max());
console.log(array1.Min());
console.log(array1.Take(1, 3));
console.log(array1.toString());
console.log(array1.CheckOne(2 === 2));
console.log(array1.CheckAll(2 === 2));
console.log(array1.CheckElement(2));
console.log(array1.Map(x => x * 2));
console.log(array1.IfCondition(x => x > 5));
console.log(array1.Reverse());
array1.ForEach(x => console.log(x));
console.log(array1.Count(x => x > 5));

const array2 = new LineArray<string>("string", 10, true);

array2.Push("2")
array2.Push("1")
array2.Push("4")
array2.Push("8")
array2.Push("5")
array2.Push("6")
array2.Push("10")
array2.Push("3")
array2.Push("7")
array2.Push("9")
array2.Pop(2)
array2.Sort()
console.log(array2.Max());
console.log(array2.Min());
console.log(array2.Take(1, 3));
console.log(array2.toString());
console.log(array2.CheckOne(2 === 2));
console.log(array2.CheckAll(2 === 2));
console.log(array2.CheckElement("2"));
console.log(array2.Map(x => x + "2"));
console.log(array2.IfCondition(x => x.length > 5));
console.log(array2.Reverse());
array2.ForEach(x => console.log(x));
console.log(array2.Count(x => x.length > 5));